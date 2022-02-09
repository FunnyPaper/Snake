
namespace Snake.Screens
{
    partial class PauseScreen
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
            this.LayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.ContinueLabel = new System.Windows.Forms.Label();
            this.PauseLabel = new System.Windows.Forms.Label();
            this.LayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutTable
            // 
            this.LayoutTable.AutoSize = true;
            this.LayoutTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(70)))));
            this.LayoutTable.ColumnCount = 3;
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LayoutTable.Controls.Add(this.ContinueLabel, 1, 2);
            this.LayoutTable.Controls.Add(this.PauseLabel, 1, 1);
            this.LayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutTable.Location = new System.Drawing.Point(0, 0);
            this.LayoutTable.Name = "LayoutTable";
            this.LayoutTable.RowCount = 4;
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutTable.Size = new System.Drawing.Size(617, 466);
            this.LayoutTable.TabIndex = 3;
            // 
            // ContinueLabel
            // 
            this.ContinueLabel.AutoSize = true;
            this.ContinueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContinueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContinueLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContinueLabel.ForeColor = System.Drawing.Color.White;
            this.ContinueLabel.Location = new System.Drawing.Point(33, 278);
            this.ContinueLabel.Name = "ContinueLabel";
            this.ContinueLabel.Size = new System.Drawing.Size(549, 116);
            this.ContinueLabel.TabIndex = 1;
            this.ContinueLabel.Text = "- press any key to continue -";
            this.ContinueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PauseLabel
            // 
            this.PauseLabel.AutoSize = true;
            this.PauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.PauseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseLabel.Font = new System.Drawing.Font("Calibri", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PauseLabel.ForeColor = System.Drawing.Color.White;
            this.PauseLabel.Location = new System.Drawing.Point(33, 69);
            this.PauseLabel.Name = "PauseLabel";
            this.PauseLabel.Size = new System.Drawing.Size(549, 209);
            this.PauseLabel.TabIndex = 0;
            this.PauseLabel.Text = "PAUSE ||";
            this.PauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.LayoutTable);
            this.Name = "PauseScreen";
            this.Size = new System.Drawing.Size(617, 466);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PauseScreen_KeyPress);
            this.LayoutTable.ResumeLayout(false);
            this.LayoutTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutTable;
        private System.Windows.Forms.Label ContinueLabel;
        private System.Windows.Forms.Label PauseLabel;
    }
}
