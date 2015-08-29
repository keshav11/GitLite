/*
 * Created by SharpDevelop.
 * User: Keshav
 * Date: 8/28/2015
 * Time: 7:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GitLite
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();			
			new RunCommand();
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{  
        }
		
		void Button1Click(object sender, EventArgs e)
		{

		}
		
		void Button3Click(object sender, EventArgs e)
		{
            string checkOut = "git push -u origin " + this.textBranch.Text;
            this.textResultBox.Text = RunCommand.runCommand(checkOut, this.textProjectLocation.Text);
        }
		
		void Button2Click(object sender, EventArgs e)
		{
            string gitCommit = "git commit -m " + "\"" + this.textCommitMessage.Text + "\"";
            this.textResultBox.Text = RunCommand.runCommand(gitCommit, this.textProjectLocation.Text);
        }
		
		void Label1Click(object sender, EventArgs e)
		{
          
        }
		
		void Button5Click(object sender, EventArgs e)
		{
			this.textResultBox.Text = RunCommand.runCommand(this.textCommandString.Text, this.textProjectLocation.Text);
		}

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textProjectLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            string gitPull = "git pull";
            this.textResultBox.Text = RunCommand.runCommand(gitPull, this.textProjectLocation.Text);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string checkOut = "git checkout "+ this.textBranch.Text;
            this.textResultBox.Text = RunCommand.runCommand(checkOut, this.textProjectLocation.Text);
        }
    }
}
