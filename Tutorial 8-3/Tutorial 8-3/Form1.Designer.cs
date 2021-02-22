namespace Tutorial_8_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.unformatButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(73, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a telephone number in the format (XXX)XXX-XXXX and I will unformat it.";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(229, 122);
            this.numberTextBox.Multiline = true;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(290, 42);
            this.numberTextBox.TabIndex = 1;
            // 
            // unformatButton
            // 
            this.unformatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.unformatButton.Location = new System.Drawing.Point(203, 206);
            this.unformatButton.Name = "unformatButton";
            this.unformatButton.Size = new System.Drawing.Size(144, 46);
            this.unformatButton.TabIndex = 2;
            this.unformatButton.Text = "unformat";
            this.unformatButton.UseVisualStyleBackColor = true;
            this.unformatButton.Click += new System.EventHandler(this.unformatButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ExitButton.Location = new System.Drawing.Point(393, 206);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(144, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.unformatButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button unformatButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

