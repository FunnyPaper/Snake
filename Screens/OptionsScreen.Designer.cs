
namespace Snake.Screens
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
            this.BoardCollisionCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DefaultButton = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.MainTableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsTableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.LabelsTableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.RowCountLabel = new System.Windows.Forms.Label();
            this.ColumnCountLabel = new System.Windows.Forms.Label();
            this.ColumnCountTrackBar = new System.Windows.Forms.TrackBar();
            this.RowCountTrackBar = new System.Windows.Forms.TrackBar();
            this.SnakeSegmentsCountLabel = new System.Windows.Forms.Label();
            this.SnakeSegmentsCountTrackBar = new System.Windows.Forms.TrackBar();
            this.GeneratePowerUpsCheckBox = new System.Windows.Forms.CheckBox();
            this.GeneratorsCountLabel = new System.Windows.Forms.Label();
            this.GeneratorsCountTrackBar = new System.Windows.Forms.TrackBar();
            this.PowerUpsPerGeneratorLabel = new System.Windows.Forms.Label();
            this.PowerUpsPerGeneratorTrackBar = new System.Windows.Forms.TrackBar();
            this.OptionsGroupBox.SuspendLayout();
            this.MainTableGrid.SuspendLayout();
            this.ButtonsTableGrid.SuspendLayout();
            this.LabelsTableGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeSegmentsCountTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratorsCountTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpsPerGeneratorTrackBar)).BeginInit();
            this.SuspendLayout();
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
            this.BoardCollisionCheckBox.Location = new System.Drawing.Point(87, 10);
            this.BoardCollisionCheckBox.Margin = new System.Windows.Forms.Padding(10);
            this.BoardCollisionCheckBox.Name = "BoardCollisionCheckBox";
            this.BoardCollisionCheckBox.Size = new System.Drawing.Size(222, 23);
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
            this.LabelsTableGrid.Controls.Add(this.PowerUpsPerGeneratorLabel, 0, 6);
            this.LabelsTableGrid.Controls.Add(this.GeneratePowerUpsCheckBox, 0, 4);
            this.LabelsTableGrid.Controls.Add(this.BoardCollisionCheckBox, 0, 0);
            this.LabelsTableGrid.Controls.Add(this.RowCountLabel, 0, 1);
            this.LabelsTableGrid.Controls.Add(this.ColumnCountLabel, 0, 2);
            this.LabelsTableGrid.Controls.Add(this.RowCountTrackBar, 1, 1);
            this.LabelsTableGrid.Controls.Add(this.ColumnCountTrackBar, 1, 2);
            this.LabelsTableGrid.Controls.Add(this.SnakeSegmentsCountLabel, 0, 3);
            this.LabelsTableGrid.Controls.Add(this.SnakeSegmentsCountTrackBar, 1, 3);
            this.LabelsTableGrid.Controls.Add(this.GeneratorsCountLabel, 0, 5);
            this.LabelsTableGrid.Controls.Add(this.GeneratorsCountTrackBar, 1, 5);
            this.LabelsTableGrid.Controls.Add(this.PowerUpsPerGeneratorTrackBar, 1, 6);
            this.LabelsTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelsTableGrid.Location = new System.Drawing.Point(0, 0);
            this.LabelsTableGrid.Margin = new System.Windows.Forms.Padding(0);
            this.LabelsTableGrid.Name = "LabelsTableGrid";
            this.LabelsTableGrid.RowCount = 7;
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LabelsTableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.LabelsTableGrid.Size = new System.Drawing.Size(638, 303);
            this.LabelsTableGrid.TabIndex = 1;
            // 
            // RowCountLabel
            // 
            this.RowCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RowCountLabel.AutoSize = true;
            this.RowCountLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.RowCountLabel.Location = new System.Drawing.Point(162, 53);
            this.RowCountLabel.Margin = new System.Windows.Forms.Padding(10);
            this.RowCountLabel.Name = "RowCountLabel";
            this.RowCountLabel.Size = new System.Drawing.Size(147, 23);
            this.RowCountLabel.TabIndex = 5;
            this.RowCountLabel.Text = "Row count";
            // 
            // ColumnCountLabel
            // 
            this.ColumnCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnCountLabel.AutoSize = true;
            this.ColumnCountLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.ColumnCountLabel.Location = new System.Drawing.Point(119, 96);
            this.ColumnCountLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ColumnCountLabel.Name = "ColumnCountLabel";
            this.ColumnCountLabel.Size = new System.Drawing.Size(190, 23);
            this.ColumnCountLabel.TabIndex = 7;
            this.ColumnCountLabel.Text = "Column count";
            // 
            // ColumnCountTrackBar
            // 
            this.ColumnCountTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColumnCountTrackBar.Location = new System.Drawing.Point(329, 96);
            this.ColumnCountTrackBar.Margin = new System.Windows.Forms.Padding(10);
            this.ColumnCountTrackBar.Maximum = 40;
            this.ColumnCountTrackBar.Minimum = 20;
            this.ColumnCountTrackBar.Name = "ColumnCountTrackBar";
            this.ColumnCountTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColumnCountTrackBar.Size = new System.Drawing.Size(299, 23);
            this.ColumnCountTrackBar.TabIndex = 8;
            this.ColumnCountTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ColumnCountTrackBar.Value = 20;
            // 
            // RowCountTrackBar
            // 
            this.RowCountTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RowCountTrackBar.Location = new System.Drawing.Point(329, 53);
            this.RowCountTrackBar.Margin = new System.Windows.Forms.Padding(10);
            this.RowCountTrackBar.Maximum = 40;
            this.RowCountTrackBar.Minimum = 20;
            this.RowCountTrackBar.Name = "RowCountTrackBar";
            this.RowCountTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RowCountTrackBar.Size = new System.Drawing.Size(299, 23);
            this.RowCountTrackBar.TabIndex = 9;
            this.RowCountTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RowCountTrackBar.Value = 20;
            // 
            // SnakeSegmentsCountLabel
            // 
            this.SnakeSegmentsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SnakeSegmentsCountLabel.AutoSize = true;
            this.SnakeSegmentsCountLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.SnakeSegmentsCountLabel.Location = new System.Drawing.Point(17, 139);
            this.SnakeSegmentsCountLabel.Margin = new System.Windows.Forms.Padding(10);
            this.SnakeSegmentsCountLabel.Name = "SnakeSegmentsCountLabel";
            this.SnakeSegmentsCountLabel.Size = new System.Drawing.Size(292, 23);
            this.SnakeSegmentsCountLabel.TabIndex = 10;
            this.SnakeSegmentsCountLabel.Text = "Snake segments count";
            // 
            // SnakeSegmentsCountTrackBar
            // 
            this.SnakeSegmentsCountTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SnakeSegmentsCountTrackBar.Location = new System.Drawing.Point(329, 139);
            this.SnakeSegmentsCountTrackBar.Margin = new System.Windows.Forms.Padding(10);
            this.SnakeSegmentsCountTrackBar.Minimum = 1;
            this.SnakeSegmentsCountTrackBar.Name = "SnakeSegmentsCountTrackBar";
            this.SnakeSegmentsCountTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SnakeSegmentsCountTrackBar.Size = new System.Drawing.Size(299, 23);
            this.SnakeSegmentsCountTrackBar.TabIndex = 11;
            this.SnakeSegmentsCountTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SnakeSegmentsCountTrackBar.Value = 4;
            // 
            // GeneratePowerUpsCheckBox
            // 
            this.GeneratePowerUpsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratePowerUpsCheckBox.AutoSize = true;
            this.GeneratePowerUpsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.GeneratePowerUpsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GeneratePowerUpsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratePowerUpsCheckBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GeneratePowerUpsCheckBox.ForeColor = System.Drawing.Color.White;
            this.GeneratePowerUpsCheckBox.Location = new System.Drawing.Point(26, 182);
            this.GeneratePowerUpsCheckBox.Margin = new System.Windows.Forms.Padding(10);
            this.GeneratePowerUpsCheckBox.Name = "GeneratePowerUpsCheckBox";
            this.GeneratePowerUpsCheckBox.Size = new System.Drawing.Size(283, 23);
            this.GeneratePowerUpsCheckBox.TabIndex = 12;
            this.GeneratePowerUpsCheckBox.Text = "Generate PowerUps";
            this.GeneratePowerUpsCheckBox.UseVisualStyleBackColor = false;
            // 
            // GeneratorsCountLabel
            // 
            this.GeneratorsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratorsCountLabel.AutoSize = true;
            this.GeneratorsCountLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.GeneratorsCountLabel.Location = new System.Drawing.Point(79, 225);
            this.GeneratorsCountLabel.Margin = new System.Windows.Forms.Padding(10);
            this.GeneratorsCountLabel.Name = "GeneratorsCountLabel";
            this.GeneratorsCountLabel.Size = new System.Drawing.Size(230, 23);
            this.GeneratorsCountLabel.TabIndex = 13;
            this.GeneratorsCountLabel.Text = "Generators count";
            // 
            // GeneratorsCountTrackBar
            // 
            this.GeneratorsCountTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratorsCountTrackBar.Location = new System.Drawing.Point(329, 225);
            this.GeneratorsCountTrackBar.Margin = new System.Windows.Forms.Padding(10);
            this.GeneratorsCountTrackBar.Maximum = 3;
            this.GeneratorsCountTrackBar.Minimum = 1;
            this.GeneratorsCountTrackBar.Name = "GeneratorsCountTrackBar";
            this.GeneratorsCountTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GeneratorsCountTrackBar.Size = new System.Drawing.Size(299, 23);
            this.GeneratorsCountTrackBar.TabIndex = 14;
            this.GeneratorsCountTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.GeneratorsCountTrackBar.Value = 3;
            // 
            // PowerUpsPerGeneratorLabel
            // 
            this.PowerUpsPerGeneratorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerUpsPerGeneratorLabel.AutoSize = true;
            this.PowerUpsPerGeneratorLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.PowerUpsPerGeneratorLabel.Location = new System.Drawing.Point(113, 268);
            this.PowerUpsPerGeneratorLabel.Margin = new System.Windows.Forms.Padding(10);
            this.PowerUpsPerGeneratorLabel.Name = "PowerUpsPerGeneratorLabel";
            this.PowerUpsPerGeneratorLabel.Size = new System.Drawing.Size(196, 25);
            this.PowerUpsPerGeneratorLabel.TabIndex = 15;
            this.PowerUpsPerGeneratorLabel.Text = "PowerUps per generator";
            // 
            // PowerUpsPerGeneratorTrackBar
            // 
            this.PowerUpsPerGeneratorTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerUpsPerGeneratorTrackBar.Location = new System.Drawing.Point(329, 268);
            this.PowerUpsPerGeneratorTrackBar.Margin = new System.Windows.Forms.Padding(10);
            this.PowerUpsPerGeneratorTrackBar.Maximum = 5;
            this.PowerUpsPerGeneratorTrackBar.Minimum = 1;
            this.PowerUpsPerGeneratorTrackBar.Name = "PowerUpsPerGeneratorTrackBar";
            this.PowerUpsPerGeneratorTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PowerUpsPerGeneratorTrackBar.Size = new System.Drawing.Size(299, 25);
            this.PowerUpsPerGeneratorTrackBar.TabIndex = 16;
            this.PowerUpsPerGeneratorTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PowerUpsPerGeneratorTrackBar.Value = 3;
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
            this.OptionsGroupBox.ResumeLayout(false);
            this.MainTableGrid.ResumeLayout(false);
            this.MainTableGrid.PerformLayout();
            this.ButtonsTableGrid.ResumeLayout(false);
            this.LabelsTableGrid.ResumeLayout(false);
            this.LabelsTableGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeSegmentsCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratorsCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpsPerGeneratorTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox BoardCollisionCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DefaultButton;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.TableLayoutPanel MainTableGrid;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableGrid;
        private System.Windows.Forms.TableLayoutPanel LabelsTableGrid;
        private System.Windows.Forms.Label RowCountLabel;
        private System.Windows.Forms.Label ColumnCountLabel;
        private System.Windows.Forms.TrackBar ColumnCountTrackBar;
        private System.Windows.Forms.TrackBar RowCountTrackBar;
        private System.Windows.Forms.Label SnakeSegmentsCountLabel;
        private System.Windows.Forms.TrackBar SnakeSegmentsCountTrackBar;
        private System.Windows.Forms.CheckBox GeneratePowerUpsCheckBox;
        private System.Windows.Forms.Label PowerUpsPerGeneratorLabel;
        private System.Windows.Forms.Label GeneratorsCountLabel;
        private System.Windows.Forms.TrackBar GeneratorsCountTrackBar;
        private System.Windows.Forms.TrackBar PowerUpsPerGeneratorTrackBar;
    }
}
