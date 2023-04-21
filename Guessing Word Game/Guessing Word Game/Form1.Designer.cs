namespace Guessing_Word_Game
{
	partial class frmGuessingGame
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
			this.tbxAnswer = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblWord = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lbWrongWords = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbxAnswer
			// 
			this.tbxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxAnswer.Location = new System.Drawing.Point(66, 119);
			this.tbxAnswer.Name = "tbxAnswer";
			this.tbxAnswer.Size = new System.Drawing.Size(365, 29);
			this.tbxAnswer.TabIndex = 0;
			this.tbxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(187, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Guess";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblWord
			// 
			this.lblWord.AutoSize = true;
			this.lblWord.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWord.ForeColor = System.Drawing.Color.White;
			this.lblWord.Location = new System.Drawing.Point(213, 44);
			this.lblWord.Name = "lblWord";
			this.lblWord.Size = new System.Drawing.Size(51, 20);
			this.lblWord.TabIndex = 2;
			this.lblWord.Text = "W?rd";
			this.lblWord.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.panel1.Controls.Add(this.lblWord);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(517, 101);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(535, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(247, 38);
			this.panel2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(77, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Wrong guess";
			// 
			// lbWrongWords
			// 
			this.lbWrongWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbWrongWords.FormattingEnabled = true;
			this.lbWrongWords.ItemHeight = 20;
			this.lbWrongWords.Location = new System.Drawing.Point(535, 56);
			this.lbWrongWords.Name = "lbWrongWords";
			this.lbWrongWords.Size = new System.Drawing.Size(247, 164);
			this.lbWrongWords.TabIndex = 5;
			this.lbWrongWords.SelectedIndexChanged += new System.EventHandler(this.lbWrongWords_SelectedIndexChanged);
			// 
			// frmGuessingGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 236);
			this.Controls.Add(this.lbWrongWords);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbxAnswer);
			this.Name = "frmGuessingGame";
			this.Text = "Guess the Word";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbxAnswer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblWord;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lbWrongWords;
	}
}

