
namespace Snake.Screens
{
    partial class GameOverScreen
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
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.FruitPickedLabel = new System.Windows.Forms.Label();
            this.PowerUpsPicked = new System.Windows.Forms.Label();
            this.TimeSpendInGameLabel = new System.Windows.Forms.Label();
            this.SegmentsOnDeathLabel = new System.Windows.Forms.Label();
            this.LayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameOverLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.White;
            this.GameOverLabel.Location = new System.Drawing.Point(46, 38);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(338, 114);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "GAME OVER";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreLabel.Font = new System.Drawing.Font("Calibri", 24F);
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(46, 152);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(338, 63);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "- Score: -";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutTable
            // 
            this.LayoutTable.AutoSize = true;
            this.LayoutTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutTable.BackColor = System.Drawing.Color.Transparent;
            this.LayoutTable.ColumnCount = 3;
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutTable.Controls.Add(this.SegmentsOnDeathLabel, 1, 5);
            this.LayoutTable.Controls.Add(this.ScoreLabel, 1, 2);
            this.LayoutTable.Controls.Add(this.GameOverLabel, 1, 1);
            this.LayoutTable.Controls.Add(this.FruitPickedLabel, 1, 3);
            this.LayoutTable.Controls.Add(this.PowerUpsPicked, 1, 4);
            this.LayoutTable.Controls.Add(this.TimeSpendInGameLabel, 1, 6);
            this.LayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutTable.Location = new System.Drawing.Point(0, 0);
            this.LayoutTable.Name = "LayoutTable";
            this.LayoutTable.RowCount = 8;
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.812758F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.13486F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.98859F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.812758F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.812758F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.812758F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.812758F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.812758F));
            this.LayoutTable.Size = new System.Drawing.Size(438, 546);
            this.LayoutTable.TabIndex = 2;
            // 
            // FruitPickedLabel
            // 
            this.FruitPickedLabel.AutoSize = true;
            this.FruitPickedLabel.BackColor = System.Drawing.Color.Transparent;
            this.FruitPickedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FruitPickedLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FruitPickedLabel.ForeColor = System.Drawing.Color.White;
            this.FruitPickedLabel.Location = new System.Drawing.Point(43, 215);
            this.FruitPickedLabel.Name = "FruitPickedLabel";
            this.FruitPickedLabel.Size = new System.Drawing.Size(344, 38);
            this.FruitPickedLabel.TabIndex = 5;
            this.FruitPickedLabel.Text = "Fruit Picked";
            this.FruitPickedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerUpsPicked
            // 
            this.PowerUpsPicked.AutoSize = true;
            this.PowerUpsPicked.BackColor = System.Drawing.Color.Transparent;
            this.PowerUpsPicked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PowerUpsPicked.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PowerUpsPicked.ForeColor = System.Drawing.Color.White;
            this.PowerUpsPicked.Location = new System.Drawing.Point(43, 253);
            this.PowerUpsPicked.Name = "PowerUpsPicked";
            this.PowerUpsPicked.Size = new System.Drawing.Size(344, 20);
            this.PowerUpsPicked.TabIndex = 6;
            this.PowerUpsPicked.Text = "PowerUps Picked";
            this.PowerUpsPicked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeSpendInGameLabel
            // 
            this.TimeSpendInGameLabel.AutoSize = true;
            this.TimeSpendInGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeSpendInGameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSpendInGameLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeSpendInGameLabel.ForeColor = System.Drawing.Color.White;
            this.TimeSpendInGameLabel.Location = new System.Drawing.Point(43, 273);
            this.TimeSpendInGameLabel.Name = "TimeSpendInGameLabel";
            this.TimeSpendInGameLabel.Size = new System.Drawing.Size(344, 20);
            this.TimeSpendInGameLabel.TabIndex = 8;
            this.TimeSpendInGameLabel.Text = "Time";
            this.TimeSpendInGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SegmentsOnDeathLabel
            // 
            this.SegmentsOnDeathLabel.AutoSize = true;
            this.SegmentsOnDeathLabel.BackColor = System.Drawing.Color.Transparent;
            this.SegmentsOnDeathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SegmentsOnDeathLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SegmentsOnDeathLabel.ForeColor = System.Drawing.Color.White;
            this.SegmentsOnDeathLabel.Location = new System.Drawing.Point(47, 254);
            this.SegmentsOnDeathLabel.Name = "SegmentsOnDeathLabel";
            this.SegmentsOnDeathLabel.Size = new System.Drawing.Size(344, 38);
            this.SegmentsOnDeathLabel.TabIndex = 7;
            this.SegmentsOnDeathLabel.Text = "Segments On Death";
            this.SegmentsOnDeathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.LayoutTable);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(438, 546);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameOverScreen_KeyPress);
            this.LayoutTable.ResumeLayout(false);
            this.LayoutTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.TableLayoutPanel LayoutTable;
        private System.Windows.Forms.Label ScoreLabel;
        public System.Windows.Forms.Label FruitPickedLabel;
        public System.Windows.Forms.Label PowerUpsPicked;
        public System.Windows.Forms.Label TimeSpendInGameLabel;
        public System.Windows.Forms.Label SegmentsOnDeathLabel;
    }
}
