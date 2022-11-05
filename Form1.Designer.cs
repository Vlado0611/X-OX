
namespace X_OX
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.lblXPlayer = new System.Windows.Forms.Label();
            this.lblOXPlayer = new System.Windows.Forms.Label();
            this.txtXPlayer = new System.Windows.Forms.TextBox();
            this.txtOPlayer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(282, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Baze podataka";
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameTitle.Location = new System.Drawing.Point(323, 66);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(134, 31);
            this.lblGameTitle.TabIndex = 1;
            this.lblGameTitle.Text = "X-OX Igra";
            this.lblGameTitle.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblXPlayer
            // 
            this.lblXPlayer.AutoSize = true;
            this.lblXPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXPlayer.Location = new System.Drawing.Point(157, 154);
            this.lblXPlayer.Name = "lblXPlayer";
            this.lblXPlayer.Size = new System.Drawing.Size(91, 25);
            this.lblXPlayer.TabIndex = 2;
            this.lblXPlayer.Text = "X - igrac:";
            this.lblXPlayer.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOXPlayer
            // 
            this.lblOXPlayer.AutoSize = true;
            this.lblOXPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOXPlayer.Location = new System.Drawing.Point(157, 225);
            this.lblOXPlayer.Name = "lblOXPlayer";
            this.lblOXPlayer.Size = new System.Drawing.Size(107, 25);
            this.lblOXPlayer.TabIndex = 3;
            this.lblOXPlayer.Text = "OX - igrac:";
            this.lblOXPlayer.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtXPlayer
            // 
            this.txtXPlayer.Location = new System.Drawing.Point(288, 158);
            this.txtXPlayer.Name = "txtXPlayer";
            this.txtXPlayer.Size = new System.Drawing.Size(202, 22);
            this.txtXPlayer.TabIndex = 4;
            // 
            // txtOPlayer
            // 
            this.txtOPlayer.Location = new System.Drawing.Point(288, 228);
            this.txtOPlayer.Name = "txtOPlayer";
            this.txtOPlayer.Size = new System.Drawing.Size(202, 22);
            this.txtOPlayer.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(288, 339);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 51);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "POCNI";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtOPlayer);
            this.Controls.Add(this.txtXPlayer);
            this.Controls.Add(this.lblOXPlayer);
            this.Controls.Add(this.lblXPlayer);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X-OX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Label lblXPlayer;
        private System.Windows.Forms.Label lblOXPlayer;
        private System.Windows.Forms.TextBox txtXPlayer;
        private System.Windows.Forms.TextBox txtOPlayer;
        private System.Windows.Forms.Button btnStart;
    }
}

