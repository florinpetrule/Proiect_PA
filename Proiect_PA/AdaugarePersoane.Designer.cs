namespace Proiect_PA
{
    partial class AdaugarePersoane
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
            this.titlu = new System.Windows.Forms.Label();
            this.introducereNume = new System.Windows.Forms.Label();
            this.alegeStatut = new System.Windows.Forms.Label();
            this.alegeInstitutie = new System.Windows.Forms.Label();
            this.alegeDesemnare = new System.Windows.Forms.Label();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.comboBox_statut = new System.Windows.Forms.ComboBox();
            this.comboBox_inst = new System.Windows.Forms.ComboBox();
            this.comboBox_desemnare = new System.Windows.Forms.ComboBox();
            this.textBox_IDstatut = new System.Windows.Forms.TextBox();
            this.textBox_IDinstitutie = new System.Windows.Forms.TextBox();
            this.textBox_IDdesemnare = new System.Windows.Forms.TextBox();
            this.adauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.titlu.Location = new System.Drawing.Point(144, 9);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(484, 31);
            this.titlu.TabIndex = 0;
            this.titlu.Text = "Adaugare persoane in baza de date:";
            // 
            // introducereNume
            // 
            this.introducereNume.AutoSize = true;
            this.introducereNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introducereNume.Location = new System.Drawing.Point(38, 109);
            this.introducereNume.Name = "introducereNume";
            this.introducereNume.Size = new System.Drawing.Size(248, 20);
            this.introducereNume.TabIndex = 1;
            this.introducereNume.Text = "Introduceti numele persoanei:";
            // 
            // alegeStatut
            // 
            this.alegeStatut.AutoSize = true;
            this.alegeStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alegeStatut.Location = new System.Drawing.Point(38, 161);
            this.alegeStatut.Name = "alegeStatut";
            this.alegeStatut.Size = new System.Drawing.Size(212, 20);
            this.alegeStatut.TabIndex = 2;
            this.alegeStatut.Text = "Selectati statut persoana";
            // 
            // alegeInstitutie
            // 
            this.alegeInstitutie.AutoSize = true;
            this.alegeInstitutie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alegeInstitutie.Location = new System.Drawing.Point(38, 215);
            this.alegeInstitutie.Name = "alegeInstitutie";
            this.alegeInstitutie.Size = new System.Drawing.Size(226, 20);
            this.alegeInstitutie.TabIndex = 3;
            this.alegeInstitutie.Text = "Selectati numele institutiei:";
            // 
            // alegeDesemnare
            // 
            this.alegeDesemnare.AutoSize = true;
            this.alegeDesemnare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alegeDesemnare.Location = new System.Drawing.Point(38, 267);
            this.alegeDesemnare.Name = "alegeDesemnare";
            this.alegeDesemnare.Size = new System.Drawing.Size(189, 20);
            this.alegeDesemnare.TabIndex = 4;
            this.alegeDesemnare.Text = "Selectati desemnarea:";
            // 
            // textBox_nume
            // 
            this.textBox_nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nume.Location = new System.Drawing.Point(293, 108);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(438, 26);
            this.textBox_nume.TabIndex = 5;
            // 
            // comboBox_statut
            // 
            this.comboBox_statut.FormattingEnabled = true;
            this.comboBox_statut.Location = new System.Drawing.Point(293, 162);
            this.comboBox_statut.Name = "comboBox_statut";
            this.comboBox_statut.Size = new System.Drawing.Size(401, 21);
            this.comboBox_statut.TabIndex = 6;
            this.comboBox_statut.Text = "Selectati statut";
            this.comboBox_statut.SelectedIndexChanged += new System.EventHandler(this.comboBox_statut_SelectedIndexChanged);
            // 
            // comboBox_inst
            // 
            this.comboBox_inst.FormattingEnabled = true;
            this.comboBox_inst.Location = new System.Drawing.Point(293, 214);
            this.comboBox_inst.Name = "comboBox_inst";
            this.comboBox_inst.Size = new System.Drawing.Size(401, 21);
            this.comboBox_inst.TabIndex = 7;
            this.comboBox_inst.Text = "Selectati institutia";
            this.comboBox_inst.SelectedIndexChanged += new System.EventHandler(this.comboBox_inst_SelectedIndexChanged);
            // 
            // comboBox_desemnare
            // 
            this.comboBox_desemnare.FormattingEnabled = true;
            this.comboBox_desemnare.Location = new System.Drawing.Point(293, 269);
            this.comboBox_desemnare.Name = "comboBox_desemnare";
            this.comboBox_desemnare.Size = new System.Drawing.Size(401, 21);
            this.comboBox_desemnare.TabIndex = 8;
            this.comboBox_desemnare.Text = "Selectati  desemnarea";
            this.comboBox_desemnare.SelectedIndexChanged += new System.EventHandler(this.comboBox_desemnare_SelectedIndexChanged);
            // 
            // textBox_IDstatut
            // 
            this.textBox_IDstatut.Location = new System.Drawing.Point(700, 163);
            this.textBox_IDstatut.Name = "textBox_IDstatut";
            this.textBox_IDstatut.ReadOnly = true;
            this.textBox_IDstatut.Size = new System.Drawing.Size(31, 20);
            this.textBox_IDstatut.TabIndex = 9;
            // 
            // textBox_IDinstitutie
            // 
            this.textBox_IDinstitutie.Location = new System.Drawing.Point(700, 215);
            this.textBox_IDinstitutie.Name = "textBox_IDinstitutie";
            this.textBox_IDinstitutie.ReadOnly = true;
            this.textBox_IDinstitutie.Size = new System.Drawing.Size(31, 20);
            this.textBox_IDinstitutie.TabIndex = 10;
            // 
            // textBox_IDdesemnare
            // 
            this.textBox_IDdesemnare.Location = new System.Drawing.Point(700, 269);
            this.textBox_IDdesemnare.Name = "textBox_IDdesemnare";
            this.textBox_IDdesemnare.ReadOnly = true;
            this.textBox_IDdesemnare.Size = new System.Drawing.Size(31, 20);
            this.textBox_IDdesemnare.TabIndex = 11;
            // 
            // adauga
            // 
            this.adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adauga.ForeColor = System.Drawing.Color.DarkRed;
            this.adauga.Location = new System.Drawing.Point(530, 351);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(201, 35);
            this.adauga.TabIndex = 12;
            this.adauga.Text = "Adauga persoana";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // AdaugarePersoane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(840, 503);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.textBox_IDdesemnare);
            this.Controls.Add(this.textBox_IDinstitutie);
            this.Controls.Add(this.textBox_IDstatut);
            this.Controls.Add(this.comboBox_desemnare);
            this.Controls.Add(this.comboBox_inst);
            this.Controls.Add(this.comboBox_statut);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.alegeDesemnare);
            this.Controls.Add(this.alegeInstitutie);
            this.Controls.Add(this.alegeStatut);
            this.Controls.Add(this.introducereNume);
            this.Controls.Add(this.titlu);
            this.Name = "AdaugarePersoane";
            this.Text = "AdaugarePersoane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Label introducereNume;
        private System.Windows.Forms.Label alegeStatut;
        private System.Windows.Forms.Label alegeInstitutie;
        private System.Windows.Forms.Label alegeDesemnare;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.ComboBox comboBox_statut;
        private System.Windows.Forms.ComboBox comboBox_inst;
        private System.Windows.Forms.ComboBox comboBox_desemnare;
        private System.Windows.Forms.TextBox textBox_IDstatut;
        private System.Windows.Forms.TextBox textBox_IDinstitutie;
        private System.Windows.Forms.TextBox textBox_IDdesemnare;
        private System.Windows.Forms.Button adauga;
    }
}