using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Word_Game
{
	public partial class frmGuessingGame : Form
	{
		
		public frmGuessingGame()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StringBuilder hiddenWord = new StringBuilder("c??????r");
			lblWord.Text = hiddenWord.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string answer = "computer";

			if (tbxAnswer.Text.Equals(answer))
			{
				lblWord.Text = answer.ToString();
				MessageBox.Show("Correct guess!");
			} else
			{
				
				lbWrongWords.Items.Add(tbxAnswer.Text);
				this.Controls.Add(lbWrongWords);
				MessageBox.Show("Wrong guess!\nTry Again.");
				
			}
			
		}

		private void lbWrongWords_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
