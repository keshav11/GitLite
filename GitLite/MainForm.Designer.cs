/*
 * Created by SharpDevelop.
 * User: Keshav
 * Date: 8/28/2015
 * Time: 7:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GitLite
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.textCommitMessage = new System.Windows.Forms.TextBox();
            this.textResultBox = new System.Windows.Forms.TextBox();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonPull = new System.Windows.Forms.Button();
            this.textCommandString = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textProjectLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCommitMessage
            // 
            this.textCommitMessage.Location = new System.Drawing.Point(34, 211);
            this.textCommitMessage.Multiline = true;
            this.textCommitMessage.Name = "textCommitMessage";
            this.textCommitMessage.Size = new System.Drawing.Size(662, 42);
            this.textCommitMessage.TabIndex = 2;
            this.textCommitMessage.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // textResultBox
            // 
            this.textResultBox.Location = new System.Drawing.Point(34, 364);
            this.textResultBox.Multiline = true;
            this.textResultBox.Name = "textResultBox";
            this.textResultBox.Size = new System.Drawing.Size(813, 150);
            this.textResultBox.TabIndex = 2;
            this.textResultBox.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(723, 211);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(124, 42);
            this.buttonCommit.TabIndex = 3;
            this.buttonCommit.Text = "Commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.Button2Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(201, 106);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(123, 59);
            this.buttonPush.TabIndex = 5;
            this.buttonPush.Text = "Push Current Branch";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.Button3Click);
            // 
            // buttonPull
            // 
            this.buttonPull.Location = new System.Drawing.Point(37, 106);
            this.buttonPull.Name = "buttonPull";
            this.buttonPull.Size = new System.Drawing.Size(130, 59);
            this.buttonPull.TabIndex = 6;
            this.buttonPull.Text = "Pull Current Branch";
            this.buttonPull.UseVisualStyleBackColor = true;
            // 
            // textCommandString
            // 
            this.textCommandString.Location = new System.Drawing.Point(34, 287);
            this.textCommandString.Multiline = true;
            this.textCommandString.Name = "textCommandString";
            this.textCommandString.Size = new System.Drawing.Size(662, 42);
            this.textCommandString.TabIndex = 8;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(723, 287);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(124, 42);
            this.buttonExecute.TabIndex = 9;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.Button5Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // textProjectLocation
            // 
            this.textProjectLocation.Location = new System.Drawing.Point(164, 35);
            this.textProjectLocation.Name = "textProjectLocation";
            this.textProjectLocation.Size = new System.Drawing.Size(582, 24);
            this.textProjectLocation.TabIndex = 4;
            this.textProjectLocation.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Project Location";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textCommandString);
            this.Controls.Add(this.buttonPull);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.textProjectLocation);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.textResultBox);
            this.Controls.Add(this.textCommitMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "GitLite";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button buttonExecute;
		private System.Windows.Forms.TextBox textCommandString;
		private System.Windows.Forms.Button buttonPull;
		private System.Windows.Forms.Button buttonPush;
		private System.Windows.Forms.Button buttonCommit;
		private System.Windows.Forms.TextBox textResultBox;
		private System.Windows.Forms.TextBox textCommitMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textProjectLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
