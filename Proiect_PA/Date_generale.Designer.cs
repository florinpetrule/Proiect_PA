namespace Proiect_PA
{
    partial class date_generale
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
            this.nume = new System.Windows.Forms.Label();
            this.instututia = new System.Windows.Forms.Label();
            this.statut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autorizare = new System.Windows.Forms.Label();
            this.modifica = new System.Windows.Forms.Button();
            this.textBoxStatut = new System.Windows.Forms.TextBox();
            this.textBoxDesemnare = new System.Windows.Forms.TextBox();
            this.listBox_pers = new System.Windows.Forms.ListBox();
            this.exit = new System.Windows.Forms.Button();
            this.textBoxInstitutie = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.Label();
            this.descriere = new System.Windows.Forms.Label();
            this.richTextBoxDescriere = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCategoria = new System.Windows.Forms.RichTextBox();
            this.adauga = new System.Windows.Forms.Button();
            this.modifica_autorizari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume.ForeColor = System.Drawing.Color.Maroon;
            this.nume.Location = new System.Drawing.Point(12, 32);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(228, 21);
            this.nume.TabIndex = 0;
            this.nume.Text = "Selecteaza Numele Persoanei:";
            // 
            // instututia
            // 
            this.instututia.AutoSize = true;
            this.instututia.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instututia.Location = new System.Drawing.Point(12, 279);
            this.instututia.Name = "instututia";
            this.instututia.Size = new System.Drawing.Size(80, 21);
            this.instututia.TabIndex = 1;
            this.instututia.Text = "Institutia:";
            // 
            // statut
            // 
            this.statut.AutoSize = true;
            this.statut.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut.Location = new System.Drawing.Point(12, 362);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(172, 21);
            this.statut.TabIndex = 2;
            this.statut.Text = "Statutul de securitate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desemnat sa insoteasca provizii:";
            // 
            // autorizare
            // 
            this.autorizare.AutoSize = true;
            this.autorizare.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorizare.ForeColor = System.Drawing.Color.Maroon;
            this.autorizare.Location = new System.Drawing.Point(746, 32);
            this.autorizare.Name = "autorizare";
            this.autorizare.Size = new System.Drawing.Size(326, 21);
            this.autorizare.TabIndex = 4;
            this.autorizare.Text = "Autorizat sa introduca urmatoarele articole:";
            // 
            // modifica
            // 
            this.modifica.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modifica.Location = new System.Drawing.Point(718, 563);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(178, 36);
            this.modifica.TabIndex = 5;
            this.modifica.Text = "Actualizare date";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // textBoxStatut
            // 
            this.textBoxStatut.Location = new System.Drawing.Point(258, 364);
            this.textBoxStatut.Name = "textBoxStatut";
            this.textBoxStatut.ReadOnly = true;
            this.textBoxStatut.Size = new System.Drawing.Size(415, 20);
            this.textBoxStatut.TabIndex = 7;
            // 
            // textBoxDesemnare
            // 
            this.textBoxDesemnare.Location = new System.Drawing.Point(258, 459);
            this.textBoxDesemnare.Name = "textBoxDesemnare";
            this.textBoxDesemnare.ReadOnly = true;
            this.textBoxDesemnare.Size = new System.Drawing.Size(415, 20);
            this.textBoxDesemnare.TabIndex = 8;
            // 
            // listBox_pers
            // 
            this.listBox_pers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_pers.FormattingEnabled = true;
            this.listBox_pers.ItemHeight = 20;
            this.listBox_pers.Location = new System.Drawing.Point(321, 32);
            this.listBox_pers.Name = "listBox_pers";
            this.listBox_pers.Size = new System.Drawing.Size(287, 204);
            this.listBox_pers.TabIndex = 9;
            this.listBox_pers.SelectedIndexChanged += new System.EventHandler(this.listBox_pers_SelectedIndexChanged);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.Location = new System.Drawing.Point(934, 563);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 36);
            this.exit.TabIndex = 11;
            this.exit.Text = "Iesire aplicatie";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBoxInstitutie
            // 
            this.textBoxInstitutie.Location = new System.Drawing.Point(258, 279);
            this.textBoxInstitutie.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInstitutie.Name = "textBoxInstitutie";
            this.textBoxInstitutie.ReadOnly = true;
            this.textBoxInstitutie.Size = new System.Drawing.Size(415, 20);
            this.textBoxInstitutie.TabIndex = 12;
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(745, 85);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(92, 20);
            this.categoria.TabIndex = 13;
            this.categoria.Text = "Categoria:";
            this.categoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // descriere
            // 
            this.descriere.AutoSize = true;
            this.descriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriere.Location = new System.Drawing.Point(746, 256);
            this.descriere.Name = "descriere";
            this.descriere.Size = new System.Drawing.Size(91, 20);
            this.descriere.TabIndex = 14;
            this.descriere.Text = "Descriere:";
            // 
            // richTextBoxDescriere
            // 
            this.richTextBoxDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescriere.ForeColor = System.Drawing.Color.DarkMagenta;
            this.richTextBoxDescriere.Location = new System.Drawing.Point(750, 279);
            this.richTextBoxDescriere.Name = "richTextBoxDescriere";
            this.richTextBoxDescriere.ReadOnly = true;
            this.richTextBoxDescriere.Size = new System.Drawing.Size(308, 203);
            this.richTextBoxDescriere.TabIndex = 16;
            this.richTextBoxDescriere.Text = "";
            this.richTextBoxDescriere.TextChanged += new System.EventHandler(this.richTextBoxDescriere_TextChanged);
            // 
            // richTextBoxCategoria
            // 
            this.richTextBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBoxCategoria.Location = new System.Drawing.Point(749, 108);
            this.richTextBoxCategoria.Name = "richTextBoxCategoria";
            this.richTextBoxCategoria.ReadOnly = true;
            this.richTextBoxCategoria.Size = new System.Drawing.Size(297, 91);
            this.richTextBoxCategoria.TabIndex = 17;
            this.richTextBoxCategoria.Text = "";
            // 
            // adauga
            // 
            this.adauga.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga.Location = new System.Drawing.Point(505, 563);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(168, 36);
            this.adauga.TabIndex = 18;
            this.adauga.TabStop = false;
            this.adauga.Text = "Adauga persoane";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // modifica_autorizari
            // 
            this.modifica_autorizari.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica_autorizari.Location = new System.Drawing.Point(269, 563);
            this.modifica_autorizari.Name = "modifica_autorizari";
            this.modifica_autorizari.Size = new System.Drawing.Size(173, 36);
            this.modifica_autorizari.TabIndex = 19;
            this.modifica_autorizari.Text = "Modifica autorizari";
            this.modifica_autorizari.UseVisualStyleBackColor = true;
            this.modifica_autorizari.Click += new System.EventHandler(this.modifica_autorizari_Click);
            // 
            // date_generale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1123, 628);
            this.Controls.Add(this.modifica_autorizari);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.richTextBoxCategoria);
            this.Controls.Add(this.richTextBoxDescriere);
            this.Controls.Add(this.descriere);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.textBoxInstitutie);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.listBox_pers);
            this.Controls.Add(this.textBoxDesemnare);
            this.Controls.Add(this.textBoxStatut);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.autorizare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.instututia);
            this.Controls.Add(this.nume);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "date_generale";
            this.Text = "Date Generale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label instututia;
        private System.Windows.Forms.Label statut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label autorizare;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.TextBox textBoxStatut;
        private System.Windows.Forms.TextBox textBoxDesemnare;
        private System.Windows.Forms.ListBox listBox_pers;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBoxInstitutie;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Label descriere;
        private System.Windows.Forms.RichTextBox richTextBoxDescriere;
        private System.Windows.Forms.RichTextBox richTextBoxCategoria;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.Button modifica_autorizari;
    }
}

