namespace labolatorium2
{
    partial class rabat
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
            label1 = new Label();
            textBoxKod = new TextBox();
            buttonOK = new Button();
            buttonAnuluj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 0;
            label1.Text = "Wpisz kod rabatowy (STUDENT/PIZZA)";
            // 
            // textBoxKod
            // 
            textBoxKod.Location = new Point(41, 82);
            textBoxKod.Name = "textBoxKod";
            textBoxKod.Size = new Size(150, 31);
            textBoxKod.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(41, 151);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(112, 34);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Dodaj";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonAnuluj
            // 
            buttonAnuluj.Location = new Point(236, 151);
            buttonAnuluj.Name = "buttonAnuluj";
            buttonAnuluj.Size = new Size(112, 34);
            buttonAnuluj.TabIndex = 3;
            buttonAnuluj.Text = "Anuluj";
            buttonAnuluj.UseVisualStyleBackColor = true;
            buttonAnuluj.Click += buttonAnuluj_Click;
            // 
            // rabat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 259);
            Controls.Add(buttonAnuluj);
            Controls.Add(buttonOK);
            Controls.Add(textBoxKod);
            Controls.Add(label1);
            Name = "rabat";
            Text = "rabat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxKod;
        private Button buttonOK;
        private Button buttonAnuluj;
    }
}