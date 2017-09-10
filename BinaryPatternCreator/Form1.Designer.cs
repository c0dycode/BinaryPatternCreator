namespace BinaryPatternCreator
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
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.lblPattern1 = new System.Windows.Forms.Label();
            this.lblPattern2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInput1.Location = new System.Drawing.Point(13, 41);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(591, 20);
            this.textBoxInput1.TabIndex = 0;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInput2.Location = new System.Drawing.Point(13, 110);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(591, 20);
            this.textBoxInput2.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(13, 188);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(591, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // lblPattern1
            // 
            this.lblPattern1.AutoSize = true;
            this.lblPattern1.Location = new System.Drawing.Point(13, 22);
            this.lblPattern1.Name = "lblPattern1";
            this.lblPattern1.Size = new System.Drawing.Size(57, 13);
            this.lblPattern1.TabIndex = 3;
            this.lblPattern1.Text = "Pattern #1";
            // 
            // lblPattern2
            // 
            this.lblPattern2.AutoSize = true;
            this.lblPattern2.Location = new System.Drawing.Point(13, 91);
            this.lblPattern2.Name = "lblPattern2";
            this.lblPattern2.Size = new System.Drawing.Size(57, 13);
            this.lblPattern2.TabIndex = 4;
            this.lblPattern2.Text = "Pattern #2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 169);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(150, 226);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(616, 261);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPattern2);
            this.Controls.Add(this.lblPattern1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textBoxInput1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Byte Searchpattern Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label lblPattern1;
        private System.Windows.Forms.Label lblPattern2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
    }
}

