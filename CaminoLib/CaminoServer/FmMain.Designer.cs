namespace CaminoServer
{
    partial class FmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.LStatus = new System.Windows.Forms.Label();
            this.LPlayer2Info = new System.Windows.Forms.Label();
            this.LPlayer1Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(12, 215);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(71, 24);
            this.LStatus.TabIndex = 0;
            this.LStatus.Text = "label1";
            // 
            // LPlayer2Info
            // 
            this.LPlayer2Info.AutoSize = true;
            this.LPlayer2Info.Location = new System.Drawing.Point(12, 9);
            this.LPlayer2Info.Name = "LPlayer2Info";
            this.LPlayer2Info.Size = new System.Drawing.Size(71, 24);
            this.LPlayer2Info.TabIndex = 1;
            this.LPlayer2Info.Text = "label1";
            // 
            // LPlayer1Info
            // 
            this.LPlayer1Info.AutoSize = true;
            this.LPlayer1Info.Location = new System.Drawing.Point(12, 449);
            this.LPlayer1Info.Name = "LPlayer1Info";
            this.LPlayer1Info.Size = new System.Drawing.Size(71, 24);
            this.LPlayer1Info.TabIndex = 2;
            this.LPlayer1Info.Text = "label1";
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 482);
            this.Controls.Add(this.LPlayer1Info);
            this.Controls.Add(this.LPlayer2Info);
            this.Controls.Add(this.LStatus);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LPlayer2Info;
        private System.Windows.Forms.Label LPlayer1Info;
    }
}

