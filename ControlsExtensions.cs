using System.Windows.Forms;
using SnakeObjs.GameHooks;

namespace Snake
{
    public static class ControlsExtensions
    {
        public static Binding UpdateLabelBinding(this Label label, ref Binding binding, object source, string dataMember, string text, string firstDelim = default(string), string secondDelim = default(string))
        {
            if (binding != null)
                label.DataBindings.Remove(binding);

            binding = new Binding("Text", source, dataMember);
            binding.Format += (o, e) =>
            {
                if (e.DesiredType == typeof(string))
                {
                    e.Value = $"{text}{firstDelim}{e.Value}{secondDelim}";
                }
            };

            label.DataBindings.Add(binding);

            return binding;
        }
    }
}
