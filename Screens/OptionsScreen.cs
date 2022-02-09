using System;
using System.Windows.Forms;
using SnakeObjs.GameHooks;

namespace Snake.Screens
{
    public partial class OptionsScreen : UserControl, IScreen
    {
        public event EventHandler MenuStart;

        public OptionsScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.CreateFieldsBindings();
            this.CreateLabelsBindings();
            this.CreateCustomBindings();
            this.HideScreen();
        }

        public void ShowScreen()
        {
            this.Show();
            this.Enabled = true;
            this.Focus();
        }

        public void HideScreen()
        {
            this.Hide();
            this.Enabled = false;
        }

        private void CreateFieldsBindings()
        {
            Binding[] bindings = new Binding[10];

            // tworzenie bindingów pól
            bindings[0] = new Binding(nameof(BoardCollisionCheckBox.Checked), Settings.TemporaryState, nameof(Settings.TemporaryState.BoardCollision));
            bindings[1] = new Binding(nameof(RowCountTrackBar.Value), Settings.TemporaryState, nameof(Settings.TemporaryState.Rows));
            bindings[2] = new Binding(nameof(ColumnCountTrackBar.Value), Settings.TemporaryState, nameof(Settings.TemporaryState.Columns));
            bindings[3] = new Binding(nameof(SnakeSegmentsCountTrackBar.Value), Settings.TemporaryState, nameof(Settings.TemporaryState.StartingSnakeSegments));
            bindings[4] = new Binding(nameof(GeneratePowerUpsCheckBox.Checked), Settings.TemporaryState, nameof(Settings.TemporaryState.GeneratePowerUps));
            bindings[5] = new Binding(nameof(PowerUpsPerGeneratorTrackBar.Value), Settings.TemporaryState, nameof(Settings.TemporaryState.MaxPowerUpCount));
            bindings[6] = new Binding(nameof(GeneratorsCountTrackBar.Value), Settings.TemporaryState, nameof(Settings.TemporaryState.GeneratorsCount));
            //bindings[7] = new Binding(nameof(), Settings.TemporaryState, nameof(Settings.TemporaryState.));
            //bindings[8] = new Binding(nameof(), Settings.TemporaryState, nameof(Settings.TemporaryState.));
            //bindings[9] = new Binding(nameof(), Settings.TemporaryState, nameof(Settings.TemporaryState.));

            // dodawanie bindingów pól
            this.BoardCollisionCheckBox.DataBindings.Add(bindings[0]);
            this.RowCountTrackBar.DataBindings.Add(bindings[1]);
            this.ColumnCountTrackBar.DataBindings.Add(bindings[2]);
            this.SnakeSegmentsCountTrackBar.DataBindings.Add(bindings[3]);
            this.GeneratePowerUpsCheckBox.DataBindings.Add(bindings[4]);
            this.PowerUpsPerGeneratorTrackBar.DataBindings.Add(bindings[5]);
            this.GeneratorsCountTrackBar.DataBindings.Add(bindings[6]);
            //.DataBindings.Add(bindings[7]);
            //.DataBindings.Add(bindings[8]);
            //.DataBindings.Add(bindings[9]);
        }

        private void CreateLabelsBindings()
        {
            Binding[] labels = new Binding[5];

            RowCountLabel.UpdateLabelBinding(ref labels[0], RowCountTrackBar, nameof(RowCountTrackBar.Value), RowCountLabel.Text, " [", "]");
            ColumnCountLabel.UpdateLabelBinding(ref labels[1], ColumnCountTrackBar, nameof(ColumnCountTrackBar.Value), ColumnCountLabel.Text, " [", "]");
            SnakeSegmentsCountLabel.UpdateLabelBinding(ref labels[2], SnakeSegmentsCountTrackBar, nameof(SnakeSegmentsCountTrackBar.Value), SnakeSegmentsCountLabel.Text, " [", "]");
            PowerUpsPerGeneratorLabel.UpdateLabelBinding(ref labels[3], PowerUpsPerGeneratorTrackBar, nameof(PowerUpsPerGeneratorTrackBar.Value), PowerUpsPerGeneratorLabel.Text, " [", "]");
            GeneratorsCountLabel.UpdateLabelBinding(ref labels[4], GeneratorsCountTrackBar, nameof(GeneratorsCountTrackBar.Value), GeneratorsCountLabel.Text, " [", "]");
        }

        private void CreateCustomBindings()
        {
            Binding[] bindings = new Binding[2];

            bindings[0] = new Binding(nameof(GeneratorsCountTrackBar.Enabled), GeneratePowerUpsCheckBox, nameof(GeneratePowerUpsCheckBox.Checked));
            bindings[1] = new Binding(nameof(PowerUpsPerGeneratorTrackBar.Enabled), GeneratePowerUpsCheckBox, nameof(GeneratePowerUpsCheckBox.Checked));

            this.GeneratorsCountTrackBar.DataBindings.Add(bindings[0]);
            this.PowerUpsPerGeneratorTrackBar.DataBindings.Add(bindings[1]);
        }

        // CZITOWANKO XD
        private ConvertEventHandler CreateLabelFormat(string text)
        {
            return (o, e) =>
            {
                if (e.DesiredType == typeof(string))
                {
                    e.Value = $"{text} [{e.Value}]";
                }
            };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.Save();
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            Settings.Default();
            //DeleteBindings();
            //CreateBindings();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Settings.Cancel();
            MenuStart?.Invoke(sender, e);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = this.ForeColor;
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = this.BackColor;
        }
    }
}