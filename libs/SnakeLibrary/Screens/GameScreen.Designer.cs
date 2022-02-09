
namespace SnakeLibrary.Screens
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
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.GameSocket = new System.Windows.Forms.TableLayoutPanel();
            this.StatsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.GameSocket.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.Location = new System.Drawing.Point(18, 77);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(123, 46);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score: ";
            // 
            // Board
            // 
            this.Board.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Board.Location = new System.Drawing.Point(121, 62);
            this.Board.Margin = new System.Windows.Forms.Padding(0);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(252, 320);
            this.Board.TabIndex = 2;
            this.Board.TabStop = false;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpeedLabel.Location = new System.Drawing.Point(16, 123);
            this.SpeedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(125, 46);
            this.SpeedLabel.TabIndex = 4;
            this.SpeedLabel.Text = "Speed:";
            // 
            // GameSocket
            // 
            this.GameSocket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GameSocket.ColumnCount = 2;
            this.GameSocket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.GameSocket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.GameSocket.Controls.Add(this.StatsPanel, 1, 0);
            this.GameSocket.Controls.Add(this.Board, 0, 0);
            this.GameSocket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameSocket.Location = new System.Drawing.Point(30, 30);
            this.GameSocket.Margin = new System.Windows.Forms.Padding(0);
            this.GameSocket.Name = "GameSocket";
            this.GameSocket.RowCount = 1;
            this.GameSocket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GameSocket.Size = new System.Drawing.Size(706, 444);
            this.GameSocket.TabIndex = 5;
            this.GameSocket.Resize += new System.EventHandler(this.GameSocket_Resize);
            // 
            // StatsPanel
            // 
            this.StatsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatsPanel.Controls.Add(this.ScoreLabel);
            this.StatsPanel.Controls.Add(this.SpeedLabel);
            this.StatsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsPanel.Location = new System.Drawing.Point(494, 0);
            this.StatsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(212, 444);
            this.StatsPanel.TabIndex = 0;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.GameSocket);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameScreen";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(766, 504);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.GameSocket.ResumeLayout(false);
            this.StatsPanel.ResumeLayout(false);
            this.StatsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Board;
        public System.Windows.Forms.Label ScoreLabel;
        public System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TableLayoutPanel GameSocket;
        private System.Windows.Forms.Panel StatsPanel;
    }
}
