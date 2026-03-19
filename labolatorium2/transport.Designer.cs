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
            checkBoxDowoz = new CheckBox();
            checkBoxEkspres = new CheckBox();
            checkBoxOdbiorOsobisty = new CheckBox();
            buttonOK = new Button();
            buttonAnuluj = new Button();
            SuspendLayout();
            // 
            // checkBoxDowoz
            // 
            checkBoxDowoz.AutoSize = true;
            checkBoxDowoz.Location = new Point(154, 77);
            checkBoxDowoz.Name = "checkBoxDowoz";
            checkBoxDowoz.Size = new Size(92, 29);
            checkBoxDowoz.TabIndex = 0;
            checkBoxDowoz.Text = "dowóz";
            checkBoxDowoz.UseVisualStyleBackColor = true;
            // 
            // checkBoxEkspres
            // 
            checkBoxEkspres.AutoSize = true;
            checkBoxEkspres.Location = new Point(154, 141);
            checkBoxEkspres.Name = "checkBoxEkspres";
            checkBoxEkspres.Size = new Size(98, 29);
            checkBoxEkspres.TabIndex = 1;
            checkBoxEkspres.Text = "ekspres";
            checkBoxEkspres.UseVisualStyleBackColor = true;
            // 
            // checkBoxOdbiorOsobisty
            // 
            checkBoxOdbiorOsobisty.AutoSize = true;
            checkBoxOdbiorOsobisty.Location = new Point(154, 205);
            checkBoxOdbiorOsobisty.Name = "checkBoxOdbiorOsobisty";
            checkBoxOdbiorOsobisty.Size = new Size(151, 29);
            checkBoxOdbiorOsobisty.TabIndex = 2;
            checkBoxOdbiorOsobisty.Text = "odbiór własny";
            checkBoxOdbiorOsobisty.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(154, 274);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(112, 41);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "wybierz";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonAnuluj
            // 
            buttonAnuluj.Location = new Point(309, 277);
            buttonAnuluj.Name = "buttonAnuluj";
            buttonAnuluj.Size = new Size(112, 34);
            buttonAnuluj.TabIndex = 4;
            buttonAnuluj.Text = "Anuluj";
            buttonAnuluj.UseVisualStyleBackColor = true;
            // 
            // transport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(buttonAnuluj);
            Controls.Add(buttonOK);
            Controls.Add(checkBoxOdbiorOsobisty);
            Controls.Add(checkBoxEkspres);
            Controls.Add(checkBoxDowoz);
            Name = "transport";
            Text = "transport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxDowoz;
        private CheckBox checkBoxEkspres;
        private CheckBox checkBoxOdbiorOsobisty;
        private Button buttonOK;
        private Button buttonAnuluj;
    }
}