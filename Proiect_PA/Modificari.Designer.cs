namespace Proiect_PA
{
    partial class Modificari
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
            this.persoana = new System.Windows.Forms.Label();
            this.institutia = new System.Windows.Forms.Label();
            this.statut = new System.Windows.Forms.Label();
            this.desemnat = new System.Windows.Forms.Label();
            this.textBox_statut = new System.Windows.Forms.TextBox();
            this.textBox_desemnat = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.comboBox_pers = new System.Windows.Forms.ComboBox();
            this.titlu = new System.Windows.Forms.Label();
            this.actualizeaza = new System.Windows.Forms.Button();
            this.textBox_institutie = new System.Windows.Forms.TextBox();
            this.modifica_nume = new System.Windows.Forms.Label();
            this.modific_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.comboBox_statut = new System.Windows.Forms.ComboBox();
            this.comboBox_inst = new System.Windows.Forms.ComboBox();
            this.comboBox_desemnare = new System.Windows.Forms.ComboBox();
            this.textBox_IDstatut = new System.Windows.Forms.TextBox();
            this.textBox_IDinst = new System.Windows.Forms.TextBox();
            this.textBox_IDdesemnare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // persoana
            // 
            this.persoana.AutoSize = true;
            this.persoana.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persoana.Location = new System.Drawing.Point(26, 93);
            this.persoana.Name = "persoana";
            this.persoana.Size = new System.Drawing.Size(228, 21);
            this.persoana.TabIndex = 0;
            this.persoana.Text = "Selecteaza Numele Persoanei:";
            // 
            // institutia
            // 
            this.institutia.AutoSize = true;
            this.institutia.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.institutia.Location = new System.Drawing.Point(26, 153);
            this.institutia.Name = "institutia";
            this.institutia.Size = new System.Drawing.Size(80, 21);
            this.institutia.TabIndex = 1;
            this.institutia.Text = "Institutia:";
            // 
            // statut
            // 
            this.statut.AutoSize = true;
            this.statut.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut.Location = new System.Drawing.Point(26, 206);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(172, 21);
            this.statut.TabIndex = 2;
            this.statut.Text = "Statutul de securitate:";
            // 
            // desemnat
            // 
            this.desemnat.AutoSize = true;
            this.desemnat.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desemnat.Location = new System.Drawing.Point(26, 256);
            this.desemnat.Name = "desemnat";
            this.desemnat.Size = new System.Drawing.Size(245, 21);
            this.desemnat.TabIndex = 3;
            this.desemnat.Text = "Desemnat sa insoteasca provizii:";
            // 
            // textBox_statut
            // 
            this.textBox_statut.Location = new System.Drawing.Point(278, 208);
            this.textBox_statut.Name = "textBox_statut";
            this.textBox_statut.ReadOnly = true;
            this.textBox_statut.Size = new System.Drawing.Size(250, 20);
            this.textBox_statut.TabIndex = 6;
            // 
            // textBox_desemnat
            // 
            this.textBox_desemnat.Location = new System.Drawing.Point(278, 258);
            this.textBox_desemnat.Name = "textBox_desemnat";
            this.textBox_desemnat.ReadOnly = true;
            this.textBox_desemnat.Size = new System.Drawing.Size(250, 20);
            this.textBox_desemnat.TabIndex = 7;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.Location = new System.Drawing.Point(1108, 409);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(165, 35);
            this.exit.TabIndex = 14;
            this.exit.Text = "Iesire Aplicatie";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // comboBox_pers
            // 
            this.comboBox_pers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pers.FormattingEnabled = true;
            this.comboBox_pers.Location = new System.Drawing.Point(278, 93);
            this.comboBox_pers.Name = "comboBox_pers";
            this.comboBox_pers.Size = new System.Drawing.Size(250, 28);
            this.comboBox_pers.TabIndex = 16;
            this.comboBox_pers.SelectedIndexChanged += new System.EventHandler(this.comboBox_pers_SelectedIndexChanged_1);
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.Location = new System.Drawing.Point(50, 9);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(538, 31);
            this.titlu.TabIndex = 17;
            this.titlu.Text = "Pagina modificari date despre persoane:";
            // 
            // actualizeaza
            // 
            this.actualizeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizeaza.ForeColor = System.Drawing.Color.DodgerBlue;
            this.actualizeaza.Location = new System.Drawing.Point(955, 320);
            this.actualizeaza.Name = "actualizeaza";
            this.actualizeaza.Size = new System.Drawing.Size(318, 36);
            this.actualizeaza.TabIndex = 20;
            this.actualizeaza.Text = "Actualizeaza datele persoanei";
            this.actualizeaza.UseVisualStyleBackColor = true;
            this.actualizeaza.Click += new System.EventHandler(this.actualizeaza_Click);
            // 
            // textBox_institutie
            // 
            this.textBox_institutie.Location = new System.Drawing.Point(278, 153);
            this.textBox_institutie.Name = "textBox_institutie";
            this.textBox_institutie.ReadOnly = true;
            this.textBox_institutie.Size = new System.Drawing.Size(250, 20);
            this.textBox_institutie.TabIndex = 22;
            // 
            // modifica_nume
            // 
            this.modifica_nume.AutoSize = true;
            this.modifica_nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica_nume.Location = new System.Drawing.Point(595, 130);
            this.modifica_nume.Name = "modifica_nume";
            this.modifica_nume.Size = new System.Drawing.Size(238, 20);
            this.modifica_nume.TabIndex = 24;
            this.modifica_nume.Text = "Modificati numele persoanei:";
            // 
            // modific_id
            // 
            this.modific_id.AutoSize = true;
            this.modific_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modific_id.Location = new System.Drawing.Point(595, 172);
            this.modific_id.Name = "modific_id";
            this.modific_id.Size = new System.Drawing.Size(159, 20);
            this.modific_id.TabIndex = 25;
            this.modific_id.Text = "Selectati  Statutul:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Selectati Instituta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Selectati Desemnare:";
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(851, 130);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(422, 20);
            this.textBox_nume.TabIndex = 29;
            // 
            // comboBox_statut
            // 
            this.comboBox_statut.FormattingEnabled = true;
            this.comboBox_statut.Location = new System.Drawing.Point(851, 174);
            this.comboBox_statut.Name = "comboBox_statut";
            this.comboBox_statut.Size = new System.Drawing.Size(381, 21);
            this.comboBox_statut.TabIndex = 30;
            this.comboBox_statut.Text = "Selectati Statutul";
            this.comboBox_statut.SelectedIndexChanged += new System.EventHandler(this.comboBox_statut_SelectedIndexChanged);
            // 
            // comboBox_inst
            // 
            this.comboBox_inst.FormattingEnabled = true;
            this.comboBox_inst.Location = new System.Drawing.Point(851, 217);
            this.comboBox_inst.Name = "comboBox_inst";
            this.comboBox_inst.Size = new System.Drawing.Size(381, 21);
            this.comboBox_inst.TabIndex = 31;
            this.comboBox_inst.Text = "Selectati Institutia";
            this.comboBox_inst.SelectedIndexChanged += new System.EventHandler(this.comboBox_inst_SelectedIndexChanged);
            // 
            // comboBox_desemnare
            // 
            this.comboBox_desemnare.FormattingEnabled = true;
            this.comboBox_desemnare.Location = new System.Drawing.Point(851, 255);
            this.comboBox_desemnare.Name = "comboBox_desemnare";
            this.comboBox_desemnare.Size = new System.Drawing.Size(381, 21);
            this.comboBox_desemnare.TabIndex = 32;
            this.comboBox_desemnare.Text = "Selectati Desemnare";
            this.comboBox_desemnare.SelectedIndexChanged += new System.EventHandler(this.comboBox_desemnare_SelectedIndexChanged);
            // 
            // textBox_IDstatut
            // 
            this.textBox_IDstatut.Location = new System.Drawing.Point(1248, 175);
            this.textBox_IDstatut.Name = "textBox_IDstatut";
            this.textBox_IDstatut.ReadOnly = true;
            this.textBox_IDstatut.Size = new System.Drawing.Size(25, 20);
            this.textBox_IDstatut.TabIndex = 43;
            // 
            // textBox_IDinst
            // 
            this.textBox_IDinst.Location = new System.Drawing.Point(1248, 219);
            this.textBox_IDinst.Name = "textBox_IDinst";
            this.textBox_IDinst.ReadOnly = true;
            this.textBox_IDinst.Size = new System.Drawing.Size(25, 20);
            this.textBox_IDinst.TabIndex = 44;
            // 
            // textBox_IDdesemnare
            // 
            this.textBox_IDdesemnare.Location = new System.Drawing.Point(1248, 257);
            this.textBox_IDdesemnare.Name = "textBox_IDdesemnare";
            this.textBox_IDdesemnare.ReadOnly = true;
            this.textBox_IDdesemnare.Size = new System.Drawing.Size(25, 20);
            this.textBox_IDdesemnare.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "ID-ul Persoanei selectate:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(851, 93);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(30, 26);
            this.textBox_ID.TabIndex = 47;
            // 
            // Modificari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1305, 477);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_IDdesemnare);
            this.Controls.Add(this.textBox_IDinst);
            this.Controls.Add(this.textBox_IDstatut);
            this.Controls.Add(this.comboBox_desemnare);
            this.Controls.Add(this.comboBox_inst);
            this.Controls.Add(this.comboBox_statut);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modific_id);
            this.Controls.Add(this.modifica_nume);
            this.Controls.Add(this.textBox_institutie);
            this.Controls.Add(this.actualizeaza);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.comboBox_pers);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textBox_desemnat);
            this.Controls.Add(this.textBox_statut);
            this.Controls.Add(this.desemnat);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.institutia);
            this.Controls.Add(this.persoana);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Modificari";
            this.Text = "Modificari";
            this.Load += new System.EventHandler(this.Modificari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label persoana;
        private System.Windows.Forms.Label institutia;
        private System.Windows.Forms.Label statut;
        private System.Windows.Forms.Label desemnat;
        private System.Windows.Forms.TextBox textBox_statut;
        private System.Windows.Forms.TextBox textBox_desemnat;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox comboBox_pers;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button actualizeaza;
        private System.Windows.Forms.TextBox textBox_institutie;
        private System.Windows.Forms.Label modifica_nume;
        private System.Windows.Forms.Label modific_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.ComboBox comboBox_statut;
        private System.Windows.Forms.ComboBox comboBox_inst;
        private System.Windows.Forms.ComboBox comboBox_desemnare;
        private System.Windows.Forms.TextBox textBox_IDstatut;
        private System.Windows.Forms.TextBox textBox_IDinst;
        private System.Windows.Forms.TextBox textBox_IDdesemnare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
    }
}