namespace Proiect_PA
{
    partial class ModificaAutorizari
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
            this.modifica = new System.Windows.Forms.Label();
            this.introducere = new System.Windows.Forms.Label();
            this.selectPers = new System.Windows.Forms.Label();
            this.comboBox_nume = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_categoria = new System.Windows.Forms.RichTextBox();
            this.richTextBox_descriere = new System.Windows.Forms.RichTextBox();
            this.categoria = new System.Windows.Forms.Label();
            this.descriere = new System.Windows.Forms.Label();
            this.modificCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_idPers = new System.Windows.Forms.TextBox();
            this.comboBox_categorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_modifica = new System.Windows.Forms.Button();
            this.selectie_pers = new System.Windows.Forms.Label();
            this.comboBox_selectiePers = new System.Windows.Forms.ComboBox();
            this.idpers = new System.Windows.Forms.Label();
            this.textBox_ID_pers = new System.Windows.Forms.TextBox();
            this.selectieCategorie = new System.Windows.Forms.Label();
            this.comboBox_categorieArt = new System.Windows.Forms.ComboBox();
            this.textBox_categorie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_autorizare = new System.Windows.Forms.RichTextBox();
            this.adaugAutorizare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifica
            // 
            this.modifica.AutoSize = true;
            this.modifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica.ForeColor = System.Drawing.Color.Blue;
            this.modifica.Location = new System.Drawing.Point(73, 33);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(397, 25);
            this.modifica.TabIndex = 0;
            this.modifica.Text = "Modificari ale autorizarilor existente:";
            // 
            // introducere
            // 
            this.introducere.AutoSize = true;
            this.introducere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introducere.ForeColor = System.Drawing.Color.Navy;
            this.introducere.Location = new System.Drawing.Point(763, 33);
            this.introducere.Name = "introducere";
            this.introducere.Size = new System.Drawing.Size(214, 24);
            this.introducere.TabIndex = 1;
            this.introducere.Text = "Introducere autorizari:";
            // 
            // selectPers
            // 
            this.selectPers.AutoSize = true;
            this.selectPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPers.ForeColor = System.Drawing.Color.Blue;
            this.selectPers.Location = new System.Drawing.Point(28, 76);
            this.selectPers.Name = "selectPers";
            this.selectPers.Size = new System.Drawing.Size(200, 16);
            this.selectPers.TabIndex = 2;
            this.selectPers.Text = "Selectati numele persoanei:";
            // 
            // comboBox_nume
            // 
            this.comboBox_nume.FormattingEnabled = true;
            this.comboBox_nume.Location = new System.Drawing.Point(234, 71);
            this.comboBox_nume.Name = "comboBox_nume";
            this.comboBox_nume.Size = new System.Drawing.Size(258, 21);
            this.comboBox_nume.TabIndex = 3;
            this.comboBox_nume.Text = "Selectati numele persoanei";
            this.comboBox_nume.SelectedIndexChanged += new System.EventHandler(this.comboBox_nume_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persoana selectata este autorizata sa introduca urmatoarele articole interzise:";
            // 
            // richTextBox_categoria
            // 
            this.richTextBox_categoria.Location = new System.Drawing.Point(37, 215);
            this.richTextBox_categoria.Name = "richTextBox_categoria";
            this.richTextBox_categoria.ReadOnly = true;
            this.richTextBox_categoria.Size = new System.Drawing.Size(138, 96);
            this.richTextBox_categoria.TabIndex = 5;
            this.richTextBox_categoria.Text = "";
            // 
            // richTextBox_descriere
            // 
            this.richTextBox_descriere.Location = new System.Drawing.Point(199, 215);
            this.richTextBox_descriere.Name = "richTextBox_descriere";
            this.richTextBox_descriere.ReadOnly = true;
            this.richTextBox_descriere.Size = new System.Drawing.Size(293, 96);
            this.richTextBox_descriere.TabIndex = 6;
            this.richTextBox_descriere.Text = "";
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(37, 189);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(55, 13);
            this.categoria.TabIndex = 7;
            this.categoria.Text = "Categoria:";
            // 
            // descriere
            // 
            this.descriere.AutoSize = true;
            this.descriere.Location = new System.Drawing.Point(196, 189);
            this.descriere.Name = "descriere";
            this.descriere.Size = new System.Drawing.Size(55, 13);
            this.descriere.TabIndex = 8;
            this.descriere.Text = "Descriere:";
            // 
            // modificCategoria
            // 
            this.modificCategoria.AutoSize = true;
            this.modificCategoria.ForeColor = System.Drawing.Color.Maroon;
            this.modificCategoria.Location = new System.Drawing.Point(37, 377);
            this.modificCategoria.Name = "modificCategoria";
            this.modificCategoria.Size = new System.Drawing.Size(103, 13);
            this.modificCategoria.TabIndex = 9;
            this.modificCategoria.Text = "Modificati Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(34, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dupa modificare, persoana va putea introduce urmatoarele articole interzise:";
            // 
            // richTextBoxDes
            // 
            this.richTextBoxDes.Location = new System.Drawing.Point(40, 432);
            this.richTextBoxDes.Name = "richTextBoxDes";
            this.richTextBoxDes.ReadOnly = true;
            this.richTextBoxDes.Size = new System.Drawing.Size(461, 107);
            this.richTextBoxDes.TabIndex = 11;
            this.richTextBoxDes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(75, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID-ul Persoanei selectate este urmatorul:";
            // 
            // textBox_idPers
            // 
            this.textBox_idPers.Location = new System.Drawing.Point(389, 103);
            this.textBox_idPers.Name = "textBox_idPers";
            this.textBox_idPers.ReadOnly = true;
            this.textBox_idPers.Size = new System.Drawing.Size(33, 20);
            this.textBox_idPers.TabIndex = 13;
            // 
            // comboBox_categorie
            // 
            this.comboBox_categorie.FormattingEnabled = true;
            this.comboBox_categorie.Location = new System.Drawing.Point(136, 374);
            this.comboBox_categorie.Name = "comboBox_categorie";
            this.comboBox_categorie.Size = new System.Drawing.Size(266, 21);
            this.comboBox_categorie.TabIndex = 14;
            this.comboBox_categorie.SelectedIndexChanged += new System.EventHandler(this.comboBox_categorie_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(427, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(460, 374);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(32, 20);
            this.textBox_ID.TabIndex = 16;
            // 
            // button_modifica
            // 
            this.button_modifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_modifica.Location = new System.Drawing.Point(100, 546);
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.Size = new System.Drawing.Size(330, 49);
            this.button_modifica.TabIndex = 17;
            this.button_modifica.Text = "Modifica autorizarea persoanei selectate";
            this.button_modifica.UseVisualStyleBackColor = true;
            this.button_modifica.Click += new System.EventHandler(this.button_modifica_Click);
            // 
            // selectie_pers
            // 
            this.selectie_pers.AutoSize = true;
            this.selectie_pers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectie_pers.ForeColor = System.Drawing.Color.Navy;
            this.selectie_pers.Location = new System.Drawing.Point(673, 71);
            this.selectie_pers.Name = "selectie_pers";
            this.selectie_pers.Size = new System.Drawing.Size(378, 16);
            this.selectie_pers.TabIndex = 18;
            this.selectie_pers.Text = "Selectati numele persoanei care nu detine autorizatie:";
            // 
            // comboBox_selectiePers
            // 
            this.comboBox_selectiePers.FormattingEnabled = true;
            this.comboBox_selectiePers.Location = new System.Drawing.Point(730, 106);
            this.comboBox_selectiePers.Name = "comboBox_selectiePers";
            this.comboBox_selectiePers.Size = new System.Drawing.Size(275, 21);
            this.comboBox_selectiePers.TabIndex = 19;
            this.comboBox_selectiePers.Text = "Selectati numele persoanei";
            this.comboBox_selectiePers.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectiePers_SelectedIndexChanged);
            // 
            // idpers
            // 
            this.idpers.AutoSize = true;
            this.idpers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpers.ForeColor = System.Drawing.Color.Navy;
            this.idpers.Location = new System.Drawing.Point(673, 189);
            this.idpers.Name = "idpers";
            this.idpers.Size = new System.Drawing.Size(288, 16);
            this.idpers.TabIndex = 20;
            this.idpers.Text = "ID-ul Persoanei selectate este urmatorul:";
            // 
            // textBox_ID_pers
            // 
            this.textBox_ID_pers.Location = new System.Drawing.Point(981, 188);
            this.textBox_ID_pers.Name = "textBox_ID_pers";
            this.textBox_ID_pers.ReadOnly = true;
            this.textBox_ID_pers.Size = new System.Drawing.Size(33, 20);
            this.textBox_ID_pers.TabIndex = 21;
            // 
            // selectieCategorie
            // 
            this.selectieCategorie.AutoSize = true;
            this.selectieCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectieCategorie.ForeColor = System.Drawing.Color.Navy;
            this.selectieCategorie.Location = new System.Drawing.Point(619, 253);
            this.selectieCategorie.Name = "selectieCategorie";
            this.selectieCategorie.Size = new System.Drawing.Size(142, 16);
            this.selectieCategorie.TabIndex = 22;
            this.selectieCategorie.Text = "Selectati categoria:";
            // 
            // comboBox_categorieArt
            // 
            this.comboBox_categorieArt.FormattingEnabled = true;
            this.comboBox_categorieArt.Location = new System.Drawing.Point(779, 252);
            this.comboBox_categorieArt.Name = "comboBox_categorieArt";
            this.comboBox_categorieArt.Size = new System.Drawing.Size(295, 21);
            this.comboBox_categorieArt.TabIndex = 23;
            this.comboBox_categorieArt.Text = "Selectati categoria";
            this.comboBox_categorieArt.SelectedIndexChanged += new System.EventHandler(this.comboBox_categorieArt_SelectedIndexChanged);
            // 
            // textBox_categorie
            // 
            this.textBox_categorie.Location = new System.Drawing.Point(1094, 253);
            this.textBox_categorie.Name = "textBox_categorie";
            this.textBox_categorie.ReadOnly = true;
            this.textBox_categorie.Size = new System.Drawing.Size(36, 20);
            this.textBox_categorie.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(619, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Persoana selectata va fi autorizata sa introduca urmatoarele aticole interzise:";
            // 
            // richTextBox_autorizare
            // 
            this.richTextBox_autorizare.Location = new System.Drawing.Point(676, 377);
            this.richTextBox_autorizare.Name = "richTextBox_autorizare";
            this.richTextBox_autorizare.ReadOnly = true;
            this.richTextBox_autorizare.Size = new System.Drawing.Size(375, 96);
            this.richTextBox_autorizare.TabIndex = 26;
            this.richTextBox_autorizare.Text = "";
            // 
            // adaugAutorizare
            // 
            this.adaugAutorizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugAutorizare.ForeColor = System.Drawing.Color.Navy;
            this.adaugAutorizare.Location = new System.Drawing.Point(767, 546);
            this.adaugAutorizare.Name = "adaugAutorizare";
            this.adaugAutorizare.Size = new System.Drawing.Size(208, 36);
            this.adaugAutorizare.TabIndex = 27;
            this.adaugAutorizare.Text = "Adauga autorizare";
            this.adaugAutorizare.UseVisualStyleBackColor = true;
            this.adaugAutorizare.Click += new System.EventHandler(this.adaugAutorizare_Click);
            // 
            // ModificaAutorizari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 607);
            this.Controls.Add(this.adaugAutorizare);
            this.Controls.Add(this.richTextBox_autorizare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_categorie);
            this.Controls.Add(this.comboBox_categorieArt);
            this.Controls.Add(this.selectieCategorie);
            this.Controls.Add(this.textBox_ID_pers);
            this.Controls.Add(this.idpers);
            this.Controls.Add(this.comboBox_selectiePers);
            this.Controls.Add(this.selectie_pers);
            this.Controls.Add(this.button_modifica);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_categorie);
            this.Controls.Add(this.textBox_idPers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modificCategoria);
            this.Controls.Add(this.descriere);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.richTextBox_descriere);
            this.Controls.Add(this.richTextBox_categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_nume);
            this.Controls.Add(this.selectPers);
            this.Controls.Add(this.introducere);
            this.Controls.Add(this.modifica);
            this.Name = "ModificaAutorizari";
            this.Text = "ModificaAutorizari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifica;
        private System.Windows.Forms.Label introducere;
        private System.Windows.Forms.Label selectPers;
        private System.Windows.Forms.ComboBox comboBox_nume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_categoria;
        private System.Windows.Forms.RichTextBox richTextBox_descriere;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Label descriere;
        private System.Windows.Forms.Label modificCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_idPers;
        private System.Windows.Forms.ComboBox comboBox_categorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button_modifica;
        private System.Windows.Forms.Label selectie_pers;
        private System.Windows.Forms.ComboBox comboBox_selectiePers;
        private System.Windows.Forms.Label idpers;
        private System.Windows.Forms.TextBox textBox_ID_pers;
        private System.Windows.Forms.Label selectieCategorie;
        private System.Windows.Forms.ComboBox comboBox_categorieArt;
        private System.Windows.Forms.TextBox textBox_categorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_autorizare;
        private System.Windows.Forms.Button adaugAutorizare;
    }
}