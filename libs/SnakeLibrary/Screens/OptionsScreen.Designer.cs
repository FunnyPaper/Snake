
namespace SnakeLibrary.Screens
{
    partial class OptionsScreen
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameSpeedLabel = new System.Windows.Forms.Label();
            this.GameSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.BoardCollisionCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.MainTableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsTableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.LabelsTableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.GameSpeedFormulaLabel = new System.Windows.Forms.Label();
            this.GameSpeedFormulaComboBox = new System.Windows.Forms.ComboBox();
            this.PointFormulaComboBox = new System.Windows.Forms.ComboBox();
            this.PointFormulaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameSpeedTrackBar)).BeginInit();
            this.OptionsGroupBox.SuspendLayout();
            this.MainTableGrid.SuspendLayout();
            this.ButtonsTableGrid.SuspendLayout();
            this.LabelsTableGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameSpeedLabel
            // 
            this.GameSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GameSpeedLabel.AutoSize = true;
            this.GameSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameSpeedLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.GameSpeedLabel.Location = new System.Drawing.Point(73, 10);
            this.GameSpeedLabel.Margin = new System.Windows.Forms.Padding(10);
            this.GameSpeedLabel.Name = "GameSpeedLabel";
            this.GameSpeedLabel.Size = new System.Drawing.Size(236, 37);
            this.GameSpeedLabel.TabIndex = 0;
            this.GameSpeedLabel.Text = "Game Tick Speed:";
            // 
            // GameSpeedTrackBar
            // 
            this.GameSpeedTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.GameSpeedTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameSpeedTrackBar.Location = new System.Drawing.Point(329, 10);
            this.GameSpeedTrackBar.Margin = new System.Windows.Forms.Padding(10);
            this.GameSpeedTrackBar.Maximum = 100;
            this.GameSpeedTrackBar.Minimum = 50;
            this.GameSpeedTrackBar.Name = "GameSpeedTrackBar";
            this.GameSpeedTrackBar.Size = new System.Drawing.Size(266, 56);
            this.GameSpeedTrackBar.TabIndex = 1;
            this.GameSpeedTrackBar.TickFrequency = 5;
            this.GameSpeedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.GameSpeedTrackBar.Value = 50;
            // 
            // BoardCollisionCheckBox
            // 
            this.BoardCollisionCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardCollisionCheckBox.AutoSize = true;
            this.BoardCollisionCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.BoardCollisionCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BoardCollisionCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoardCollisionCheckBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoardCollisionCheckBox.ForeColor = System.Drawing.Color.White;
            this.BoardCollisionCheckBox.Location = new System.Drawing.Point(87, 143);
            this.BoardCollisionCheckBox.Margin = new System.Windows.Forms.Padding(10);
            this.BoardCollisionCheckBox.Name = "BoardCollisionCheckBox";
            this.BoardCollisionCheckBox.Size = new System.Drawing.Size(222, 41);
            this.BoardCollisionCheckBox.TabIndex = 3;
            this.BoardCollisionCheckBox.Text = "Board Collision";
            this.BoardCollisionCheckBox.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveButton.FlatAppearance.BorderSize = 5;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(136, 30);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(222, 79);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.SaveButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            // 
            // DefaultButton
            // 
            this.DefaultButton.BackColor = System.Drawing.Color.Transparent;
            this.DefaultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DefaultButton.FlatAppearance.BorderSize = 5;
            this.DefaultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultButton.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DefaultButton.ForeColor = System.Drawing.Color.White;
            this.DefaultButton.Location = new System.Drawing.Point(378, 30);
            this.DefaultButton.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(224, 79);
            this.DefaultButton.TabIndex = 5;
            this.DefaultButton.Text = "Default";
            this.DefaultButton.UseVisualStyleBackColor = false;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            this.DefaultButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.DefaultButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.AutoSize = true;
            this.OptionsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionsGroupBox.Controls.Add(this.MainTableGrid);
            this.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsGroupBox.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OptionsGroupBox.ForeColor = System.Drawing.Color.White;
            this.OptionsGroupBox.Location = new System.Drawing.Point(30, 30);
            this.OptionsGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.OptionsGroupBox.Size = new System.Drawing.Size(638, 507);
            this.OptionsGroupBox.TabIndex = 10;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // MainTableGrid
            // 
            this.MainTableGrid.BackColor = System.Drawing.Color.Transparent;
            this.MainTableGrid.ColumnCount = 1;
            this.MainTableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableGrid.Controls.Add(this.ButtonsTableGrid, 0, 1);
            this.MainTableGrid.Controls.Add(this.LabelsTableGrid, 0, 0);
            this.MainTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableGrid.Location = new System.Drawing.Point(0, 53);
            this.MainTableGrid.Name = "MainTableGrid";
            this.MainTableGrid.RowCount = 2;
            this.MainTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.MainTableGrid.Size = new System.Drawing.Size(638, 454);
            this.MainTableGrid.TabIndex = 11;
            // 
            // ButtonsTableGrid
            // 
            this.ButtonsTableGrid.AutoSize = true;
            this.ButtonsTableGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonsTableGrid.ColumnCount = 3;
            this.ButtonsTableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableGrid.Controls.Add(this.DefaultButton, 2, 0);
            this.ButtonsTableGrid.Controls.Add(this.SaveButton, 1, 0);
            this.ButtonsTableGrid.Controls.Add(this.MenuButton, 0, 0);
            this.ButtonsTableGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsTableGrid.Location = new System.Drawing.Point(3, 312);
            this.ButtonsTableGrid.Name = "ButtonsTableGrid";
            this.ButtonsTableGrid.Padding = new System.Windows.Forms.Padding(30);
            this.ButtonsTableGrid.RowCount = 1;
            this.ButtonsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableGrid.Size = new System.Drawing.Size(632, 139);
            this.ButtonsTableGrid.TabIndex = 0;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MenuButton.FlatAppearance.BorderSize = 5;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Location = new System.Drawing.Point(30, 30);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(106, 79);
            this.MenuButton.TabIndex = 10;
            this.MenuButton.Text = "<-";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            this.MenuButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.MenuButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            // 
            // LabelsTableGrid
            // 
            this.LabelsTableGrid.ColumnCount = 2;
            this.LabelsTableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelsTableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelsTableGrid.Controls.Add(this.GameSpeedFormulaComboBox, 1, 1);
            this.LabelsTableGrid.Controls.Add(this.PointFormulaComboBox, 1, 3);
            this.LabelsTableGrid.Controls.Add(this.GameSpeedTrackBar, 1, 0);
            this.LabelsTableGrid.Controls.Add(this.GameSpeedLabel, 0, 0);
            this.LabelsTableGrid.Controls.Add(this.GameSpeedFormulaLabel, 0, 1);
            this.LabelsTableGrid.Controls.Add(this.BoardCollisionCheckBox, 0, 2);
            this.LabelsTableGrid.Controls.Add(this.PointFormulaLabel, 0, 3);
            this.LabelsTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelsTableGrid.Location = new System.Drawing.Point(0, 0);
            this.LabelsTableGrid.Margin = new System.Windows.Forms.Padding(0);
            this.LabelsTableGrid.Name = "LabelsTableGrid";
            this.LabelsTableGrid.RowCount = 4;
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LabelsTableGrid.Size = new System.Drawing.Size(638, 303);
            this.LabelsTableGrid.TabIndex = 1;
            // 
            // GameSpeedFormulaLabel
            // 
            this.GameSpeedFormulaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GameSpeedFormulaLabel.AutoSize = true;
            this.GameSpeedFormulaLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameSpeedFormulaLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameSpeedFormulaLabel.ForeColor = System.Drawing.Color.White;
            this.GameSpeedFormulaLabel.Location = new System.Drawing.Point(48, 86);
            this.GameSpeedFormulaLabel.Margin = new System.Windows.Forms.Padding(10);
            this.GameSpeedFormulaLabel.Name = "GameSpeedFormulaLabel";
            this.GameSpeedFormulaLabel.Size = new System.Drawing.Size(261, 37);
            this.GameSpeedFormulaLabel.TabIndex = 7;
            this.GameSpeedFormulaLabel.Text = "Game Tick Formula:";
            // 
            // GameSpeedFormulaComboBox
            // 
            this.GameSpeedFormulaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.GameSpeedFormulaComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameSpeedFormulaComboBox.Enabled = false;
            this.GameSpeedFormulaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameSpeedFormulaComboBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.GameSpeedFormulaComboBox.ForeColor = System.Drawing.Color.White;
            this.GameSpeedFormulaComboBox.FormattingEnabled = true;
            this.GameSpeedFormulaComboBox.Location = new System.Drawing.Point(329, 86);
            this.GameSpeedFormulaComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.GameSpeedFormulaComboBox.Name = "GameSpeedFormulaComboBox";
            this.GameSpeedFormulaComboBox.Size = new System.Drawing.Size(266, 32);
            this.GameSpeedFormulaComboBox.Sorted = true;
            this.GameSpeedFormulaComboBox.TabIndex = 8;
            this.GameSpeedFormulaComboBox.Text = "pick...";
            // 
            // PointFormulaComboBox
            // 
            this.PointFormulaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.PointFormulaComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PointFormulaComboBox.Enabled = false;
            this.PointFormulaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointFormulaComboBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.PointFormulaComboBox.ForeColor = System.Drawing.Color.White;
            this.PointFormulaComboBox.FormattingEnabled = true;
            this.PointFormulaComboBox.Location = new System.Drawing.Point(329, 204);
            this.PointFormulaComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.PointFormulaComboBox.Name = "PointFormulaComboBox";
            this.PointFormulaComboBox.Size = new System.Drawing.Size(266, 32);
            this.PointFormulaComboBox.Sorted = true;
            this.PointFormulaComboBox.TabIndex = 9;
            this.PointFormulaComboBox.Text = "pick...";
            // 
            // PointFormulaLabel
            // 
            this.PointFormulaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointFormulaLabel.AutoSize = true;
            this.PointFormulaLabel.BackColor = System.Drawing.Color.Transparent;
            this.PointFormulaLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PointFormulaLabel.ForeColor = System.Drawing.Color.White;
            this.PointFormulaLabel.Location = new System.Drawing.Point(112, 204);
            this.PointFormulaLabel.Margin = new System.Windows.Forms.Padding(10);
            this.PointFormulaLabel.Name = "PointFormulaLabel";
            this.PointFormulaLabel.Size = new System.Drawing.Size(197, 37);
            this.PointFormulaLabel.TabIndex = 6;
            this.PointFormulaLabel.Text = "Point Formula:";
            // 
            // OptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.OptionsGroupBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "OptionsScreen";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(698, 567);
            ((System.ComponentModel.ISupportInitialize)(this.GameSpeedTrackBar)).EndInit();
            this.OptionsGroupBox.ResumeLayout(false);
            this.MainTableGrid.ResumeLayout(false);
            this.MainTableGrid.PerformLayout();
            this.ButtonsTableGrid.ResumeLayout(false);
            this.LabelsTableGrid.ResumeLayout(false);
            this.LabelsTableGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameSpeedLabel;
        private System.Windows.Forms.TrackBar GameSpeedTrackBar;
        private System.Windows.Forms.CheckBox BoardCollisionCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.TableLayoutPanel MainTableGrid;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableGrid;
        private System.Windows.Forms.TableLayoutPanel LabelsTableGrid;
        private System.Windows.Forms.ComboBox GameSpeedFormulaComboBox;
        private System.Windows.Forms.ComboBox PointFormulaComboBox;
        private System.Windows.Forms.Label GameSpeedFormulaLabel;
        private System.Windows.Forms.Label PointFormulaLabel;
    }
}
