using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeLibrary.Settings;

namespace SnakeLibrary.Screens
{
    public partial class OptionsScreen : UserControl, IScreen
    {
        public event EventHandler MenuStart;

        public OptionsScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            CreateBindings();

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

        private void CreateBindings()
        {
            Binding handle;
            this.GameSpeedTrackBar.DataBindings.Add(new Binding("Value", SettingsManager.TemporaryState, "GameTickSpeed"));
            this.BoardCollisionCheckBox.DataBindings.Add(new Binding("Checked", SettingsManager.TemporaryState, "BoardCollisionOn"));

            //handle = new Binding("Text", SettingsManager.TemporaryState, "PointFormula");
            //handle.Parse += FormatToPointFormulaEnum;
            //this.PointFormulaComboBox.DataBindings.Add(handle);
            //this.PointFormulaComboBox.DataSource = Enum.GetNames(typeof(PointFormula)).ToList();

            //handle = new Binding("Text", SettingsManager.TemporaryState, "GameTickSpeedFormula");
            //handle.Parse += FormatToGameTickSpeedFormulaEnum;
            //this.GameSpeedFormulaComboBox.DataBindings.Add(handle);
            //this.GameSpeedFormulaComboBox.DataSource = Enum.GetNames(typeof(GameTickSpeedFormula)).ToList();

            handle = new Binding("Text", GameSpeedTrackBar, "Value");
            handle.Format += (s, e) =>
            {
                if (e.DesiredType == typeof(string))
                {
                    e.Value = $"Game Tick Speed [{e.Value}]:";
                }
            };
            this.GameSpeedLabel.DataBindings.Add(handle);
        }

        private void FormatToPointFormulaEnum(object sender, ConvertEventArgs e)
        {
            //if(e.DesiredType == typeof(PointFormula))
            //{
            //    e.Value = Enum.Parse(typeof(PointFormula), e.Value.ToString());
            //}
        }

        private void FormatToGameTickSpeedFormulaEnum(object sender, ConvertEventArgs e)
        {
            //if (e.DesiredType == typeof(GameTickSpeedFormula))
            //{
            //    e.Value = Enum.Parse(typeof(GameTickSpeedFormula), e.Value.ToString());
            //}
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SettingsManager.Save();
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            SettingsManager.Default();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SettingsManager.Cancel();
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