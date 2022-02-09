
namespace Snake.Screens
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Board = new System.Windows.Forms.PictureBox();
            this.FruitPickedLabel = new System.Windows.Forms.Label();
            this.GameSocket = new System.Windows.Forms.TableLayoutPanel();
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.PowerUpsPicked = new System.Windows.Forms.Label();
            this.TimeSpendInGameLabel = new System.Windows.Forms.Label();
            this.StatisticsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.GameSocket.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.StatisticsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(27, 75);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(104, 46);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score";
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Board.Location = new System.Drawing.Point(0, 0);
            this.Board.Margin = new System.Windows.Forms.Padding(0);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(536, 504);
            this.Board.TabIndex = 2;
            this.Board.TabStop = false;
            // 
            // FruitPickedLabel
            // 
            this.FruitPickedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FruitPickedLabel.AutoSize = true;
            this.FruitPickedLabel.BackColor = System.Drawing.Color.Transparent;
            this.FruitPickedLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FruitPickedLabel.ForeColor = System.Drawing.Color.White;
            this.FruitPickedLabel.Location = new System.Drawing.Point(27, 121);
            this.FruitPickedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FruitPickedLabel.Name = "FruitPickedLabel";
            this.FruitPickedLabel.Size = new System.Drawing.Size(201, 46);
            this.FruitPickedLabel.TabIndex = 4;
            this.FruitPickedLabel.Text = "Fruit Picked";
            // 
            // GameSocket
            // 
            this.GameSocket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.GameSocket.ColumnCount = 2;
            this.GameSocket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.GameSocket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.GameSocket.Controls.Add(this.StatsPanel, 1, 0);
            this.GameSocket.Controls.Add(this.Board, 0, 0);
            this.GameSocket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameSocket.Location = new System.Drawing.Point(0, 0);
            this.GameSocket.Margin = new System.Windows.Forms.Padding(0);
            this.GameSocket.Name = "GameSocket";
            this.GameSocket.RowCount = 1;
            this.GameSocket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GameSocket.Size = new System.Drawing.Size(766, 504);
            this.GameSocket.TabIndex = 5;
            // 
            // StatsPanel
            // 
            this.StatsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.StatsPanel.Controls.Add(this.StatisticsGroupBox);
            this.StatsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsPanel.Location = new System.Drawing.Point(536, 0);
            this.StatsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Padding = new System.Windows.Forms.Padding(30);
            this.StatsPanel.Size = new System.Drawing.Size(230, 504);
            this.StatsPanel.TabIndex = 0;
            // 
            // PowerUpsPicked
            // 
            this.PowerUpsPicked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerUpsPicked.AutoSize = true;
            this.PowerUpsPicked.BackColor = System.Drawing.Color.Transparent;
            this.PowerUpsPicked.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PowerUpsPicked.ForeColor = System.Drawing.Color.White;
            this.PowerUpsPicked.Location = new System.Drawing.Point(27, 167);
            this.PowerUpsPicked.Margin = new System.Windows.Forms.Padding(0);
            this.PowerUpsPicked.Name = "PowerUpsPicked";
            this.PowerUpsPicked.Size = new System.Drawing.Size(286, 46);
            this.PowerUpsPicked.TabIndex = 5;
            this.PowerUpsPicked.Text = "PowerUps Picked";
            // 
            // TimeSpendInGameLabel
            // 
            this.TimeSpendInGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSpendInGameLabel.AutoSize = true;
            this.TimeSpendInGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeSpendInGameLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeSpendInGameLabel.ForeColor = System.Drawing.Color.White;
            this.TimeSpendInGameLabel.Location = new System.Drawing.Point(27, 213);
            this.TimeSpendInGameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimeSpendInGameLabel.Name = "TimeSpendInGameLabel";
            this.TimeSpendInGameLabel.Size = new System.Drawing.Size(97, 46);
            this.TimeSpendInGameLabel.TabIndex = 6;
            this.TimeSpendInGameLabel.Text = "Time";
            // 
            // StatisticsGroupBox
            // 
            this.StatisticsGroupBox.AutoSize = true;
            this.StatisticsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StatisticsGroupBox.Controls.Add(this.ScoreLabel);
            this.StatisticsGroupBox.Controls.Add(this.TimeSpendInGameLabel);
            this.StatisticsGroupBox.Controls.Add(this.FruitPickedLabel);
            this.StatisticsGroupBox.Controls.Add(this.PowerUpsPicked);
            this.StatisticsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsGroupBox.Font = new System.Drawing.Font("Calibri", 25.8F);
            this.StatisticsGroupBox.ForeColor = System.Drawing.Color.White;
            this.StatisticsGroupBox.Location = new System.Drawing.Point(30, 30);
            this.StatisticsGroupBox.Name = "StatisticsGroupBox";
            this.StatisticsGroupBox.Size = new System.Drawing.Size(170, 444);
            this.StatisticsGroupBox.TabIndex = 7;
            this.StatisticsGroupBox.TabStop = false;
            this.StatisticsGroupBox.Text = "Statistics";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.GameSocket);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(766, 504);
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.GameSocket.ResumeLayout(false);
            this.StatsPanel.ResumeLayout(false);
            this.StatsPanel.PerformLayout();
            this.StatisticsGroupBox.ResumeLayout(false);
            this.StatisticsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        public System.Windows.Forms.Label ScoreLabel;
        public System.Windows.Forms.Label FruitPickedLabel;
        private System.Windows.Forms.TableLayoutPanel GameSocket;
        private System.Windows.Forms.Panel StatsPanel;
        public System.Windows.Forms.PictureBox Board;
        public System.Windows.Forms.Label PowerUpsPicked;
        public System.Windows.Forms.Label TimeSpendInGameLabel;
        private System.Windows.Forms.GroupBox StatisticsGroupBox;
    }
}
