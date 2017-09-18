namespace WindowsFormsApplication2
{
    partial class RandomNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomNumber));
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(253, 100);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(177, 28);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblParagraph
            // 
            this.lblParagraph.Location = new System.Drawing.Point(13, 27);
            this.lblParagraph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(495, 69);
            this.lblParagraph.TabIndex = 1;
            this.lblParagraph.Text = resources.GetString("lblParagraph.Text");
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(137, 102);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(81, 22);
            this.txtGuess.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(43, 106);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(62, 17);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult.Location = new System.Drawing.Point(137, 151);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(339, 22);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(43, 155);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(77, 201);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(204, 32);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Generate New Number";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(311, 201);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(97, 31);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // RandomNumber
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(521, 284);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblParagraph);
            this.Controls.Add(this.btnGuess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess My Number";
            this.Load += new System.EventHandler(this.RandomNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblParagraph;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
    }
}

