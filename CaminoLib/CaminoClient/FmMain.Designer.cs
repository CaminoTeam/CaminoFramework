namespace CaminoClient
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
            this.LPlayerName = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.BtJoinGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LPlayerName
            // 
            this.LPlayerName.AutoSize = true;
            this.LPlayerName.Location = new System.Drawing.Point(12, 502);
            this.LPlayerName.Name = "LPlayerName";
            this.LPlayerName.Size = new System.Drawing.Size(176, 24);
            this.LPlayerName.TabIndex = 0;
            this.LPlayerName.Text = "Unknown Player";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(13, 536);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(218, 24);
            this.LStatus.TabIndex = 1;
            this.LStatus.Text = "Awaiting connection";
            // 
            // BtJoinGame
            // 
            this.BtJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtJoinGame.Location = new System.Drawing.Point(363, 519);
            this.BtJoinGame.Name = "BtJoinGame";
            this.BtJoinGame.Size = new System.Drawing.Size(95, 38);
            this.BtJoinGame.TabIndex = 2;
            this.BtJoinGame.Text = "Start";
            this.BtJoinGame.UseVisualStyleBackColor = true;
            this.BtJoinGame.Click += new System.EventHandler(this.BtJoinGame_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 569);
            this.Controls.Add(this.BtJoinGame);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LPlayerName);
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

        private System.Windows.Forms.Label LPlayerName;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Button BtJoinGame;
    }
}

