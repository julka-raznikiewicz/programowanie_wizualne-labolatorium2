namespace labolatorium2
{
    partial class transport
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(154, 77);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "kurier";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(154, 141);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(125, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "paczkomat";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(154, 205);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(151, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "odbiór własny";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(479, 193);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 3;
            button1.Text = "wybierz";
            button1.UseVisualStyleBackColor = true;
            // 
            // transport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "transport";
            Text = "transport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
    }
}