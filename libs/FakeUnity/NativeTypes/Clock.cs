using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeUnity.NativeTypes
{
    public class Clock
    {
        public enum ClockMode { Ticks, Countdown }

        /// <summary>
        /// Tryb w jakim działa zegar
        /// </summary>
        public ClockMode Mode = ClockMode.Ticks;

        /// <summary>
        /// Akcesory do dodawania/ usuwania słuchaczy zdarzenia Tick
        /// </summary>
        public event EventHandler Tick
        {
            add
            {
                Console.WriteLine($"Listener added: {value.Method}");
                _tick += value;
            }
            remove
            {
                Console.WriteLine($"Listener removed: {value.Method}");
                _tick -= value;
            }
        }

        /// <summary>
        /// Zdarzenie przechowujące listę słuchaczy do cyklicznego wywoływania co odpowiednią ilość ms (Frequency)
        /// </summary>
        private event EventHandler _tick;

        /// <summary>
        /// Token do zatrzymywania operacji zadań (Task)
        /// </summary>
        private CancellationTokenSource _token = new CancellationTokenSource();

        /// <summary>
        /// Czy token został zaktualizowany (utworzony na nowo)
        /// </summary>
        private bool _tokenUpdated = true;

        /// <summary>
        /// Odpowiada za włączanie/ wyłączanie zegarka
        /// </summary>
        public bool Enabled
        {
            get => _enabled;
            set
            {
                while (!_tokenUpdated) ;

                _enabled = value;

                if (_enabled)
                {
                    switch(Mode)
                    {
                        case ClockMode.Ticks:
                            StartTicking();
                            break;
                        case ClockMode.Countdown:
                            Task.Run(() => StartCountdown(), _token.Token);
                            break;
                    }
                }
                else
                {
                    _token.Cancel();
                    _tokenUpdated = false;
                }
            }
        }

        /// <summary>
        /// Odpowiada za włączanie/ wyłączanie zegarka
        /// </summary>
        private bool _enabled;

        /// <summary>
        /// Odpowiada za włączanie zegarka
        /// </summary>
        public void Enable() => Enabled = true;

        /// <summary>
        /// Odpowiada za wyłączanie zegarka
        /// </summary>
        public void Disable() => Enabled = false;

        /// <summary>
        /// Częstotliwość w jakiej cyklicznie wywołuje się zdarzenie Tick (w milisekundach)
        /// </summary>
        public int Frequency
        {
            get => _frequency;
            set => _frequency = value;
        }

        /// <summary>
        /// Częstotliwość w jakiej cyklicznie wywołuje się zdarzenie Tick (w milisekundach)
        /// </summary>
        private int _frequency;

        public int Delay;

        /// <summary>
        /// Konstruktor bezparametrowy ustawia wartość "Frequency" na 1000 i "Delay" na 0
        /// </summary>
        public Clock() : this(1000, 0)
        {
        }

        /// <summary>
        /// Konstruktor 1-parametrowy ustawia wartość "Frequency" na frequency i "Delay" na 0
        /// </summary>
        /// <param name="frequency"></param>
        public Clock(int frequency) : this(frequency, 0)
        {
        }

        /// <summary>
        /// Konstruktor 2-parametrowy ustawia wartość "Frequency" na frequency i "Delay" na delay
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="delay"></param>
        public Clock(int frequency = 1000, int delay = 0)
        {
            _frequency = frequency;
            _enabled = false;
            Delay = delay;
        }

        /// <summary>
        /// Metoda wywołująca zdarzenie Tick z odpowiednim opóźnieniem (Delay) i częstotliwością (Frequency)
        /// </summary>
        private void StartTicking()
        {
            try
            {
                _token.Token.ThrowIfCancellationRequested();

                Thread.Sleep(Delay);

                Task task = new Task(() =>
                {
                    while (_enabled)
                    {
                        _token.Token.ThrowIfCancellationRequested();

                        try
                        {
                            _tick.Invoke(this, System.EventArgs.Empty);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                        Thread.Sleep(_frequency);
                    }
                });
                task.Start();
            }
            finally
            {
                _token.Dispose();
                _token = new CancellationTokenSource();
                _tokenUpdated = true;

                Console.WriteLine("Clock has been disabled");
            }
        }

        private void StartCountdown()
        {
            Thread.Sleep(Delay / _frequency);
            _tick.Invoke(this, System.EventArgs.Empty);
        }

        /// <summary>
        /// Usuwa wszystkich słuchaczy zdarzenia Tick
        /// </summary>
        public void ClearEvents()
        {
            foreach (Delegate d in _tick.GetInvocationList())
                Tick -= d as EventHandler;
        }
    }
}