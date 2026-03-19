namespace labolatorium2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewKoszyk = new ListView();
            Produkt = new ColumnHeader();
            Cena = new ColumnHeader();
            buttonWybierz = new Button();
            buttonTransport = new Button();
            buttonZaplac = new Button();
            labelCena = new Label();
            buttonRabat = new Button();
            SuspendLayout();
            // 
            // listViewKoszyk
            // 
            listViewKoszyk.Columns.AddRange(new ColumnHeader[] { Produkt, Cena });
            listViewKoszyk.Location = new Point(76, 36);
            listViewKoszyk.Name = "listViewKoszyk";
            listViewKoszyk.Size = new Size(251, 344);
            listViewKoszyk.TabIndex = 0;
            listViewKoszyk.UseCompatibleStateImageBehavior = false;
            listViewKoszyk.View = View.Details;
            // 
            // buttonWybierz
            // 
            buttonWybierz.Location = new Point(444, 139);
            buttonWybierz.Name = "buttonWybierz";
            buttonWybierz.Size = new Size(171, 46);
            buttonWybierz.TabIndex = 1;
            buttonWybierz.Text = "wybierz";
            buttonWybierz.UseVisualStyleBackColor = true;
            buttonWybierz.Click += buttonWybierz_Click;
            // 
            // buttonTransport
            // 
            buttonTransport.Location = new Point(444, 209);
            buttonTransport.Name = "buttonTransport";
            buttonTransport.Size = new Size(171, 47);
            buttonTransport.TabIndex = 2;
            buttonTransport.Text = "transport";
            buttonTransport.UseVisualStyleBackColor = true;
            buttonTransport.Click += buttonTransport_Click;
            // 
            // buttonZaplac
            // 
            buttonZaplac.Location = new Point(444, 335);
            buttonZaplac.Name = "buttonZaplac";
            buttonZaplac.Size = new Size(171, 45);
            buttonZaplac.TabIndex = 3;
            buttonZaplac.Text = "zapłać";
            buttonZaplac.UseVisualStyleBackColor = true;
            buttonZaplac.Click += buttonZaplac_Click;
            // 
            // labelCena
            // 
            labelCena.AutoSize = true;
            labelCena.Location = new Point(488, 64);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(55, 25);
            labelCena.TabIndex = 4;
            labelCena.Text = "Cena:";
            // 
            // buttonRabat
            // 
            buttonRabat.Location = new Point(444, 276);
            buttonRabat.Name = "buttonRabat";
            buttonRabat.Size = new Size(171, 39);
            buttonRabat.TabIndex = 5;
            buttonRabat.Text = "rabat";
            buttonRabat.UseVisualStyleBackColor = true;
            buttonRabat.Click += buttonRabat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRabat);
            Controls.Add(labelCena);
            Controls.Add(buttonZaplac);
            Controls.Add(buttonTransport);
            Controls.Add(buttonWybierz);
            Controls.Add(listViewKoszyk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewKoszyk;
        private Button buttonWybierz;
        private Button buttonTransport;
        private Button buttonZaplac;
        private Label labelCena;
        private ColumnHeader Produkt;
        private ColumnHeader Cena;
        private Button buttonRabat;
    }
}
