namespace EtudiantTest
{
    partial class frmEtudiantTest
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom1 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom1 = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtPrenom2 = new System.Windows.Forms.TextBox();
            this.lblPrenom2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(37, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom:";
            // 
            // lblPrenom1
            // 
            this.lblPrenom1.AutoSize = true;
            this.lblPrenom1.Location = new System.Drawing.Point(17, 80);
            this.lblPrenom1.Name = "lblPrenom1";
            this.lblPrenom1.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom1.TabIndex = 1;
            this.lblPrenom1.Text = "Prénom1:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(309, 34);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(75, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(167, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtPrenom1
            // 
            this.txtPrenom1.Location = new System.Drawing.Point(75, 77);
            this.txtPrenom1.Name = "txtPrenom1";
            this.txtPrenom1.Size = new System.Drawing.Size(167, 20);
            this.txtPrenom1.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(344, 31);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(167, 20);
            this.txtAge.TabIndex = 5;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 212);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(709, 261);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prénom";
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 173;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Téléphone";
            this.columnHeader4.Width = 181;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(727, 444);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(808, 444);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtPrenom2
            // 
            this.txtPrenom2.Location = new System.Drawing.Point(75, 118);
            this.txtPrenom2.Name = "txtPrenom2";
            this.txtPrenom2.Size = new System.Drawing.Size(167, 20);
            this.txtPrenom2.TabIndex = 10;
            // 
            // lblPrenom2
            // 
            this.lblPrenom2.AutoSize = true;
            this.lblPrenom2.Location = new System.Drawing.Point(17, 121);
            this.lblPrenom2.Name = "lblPrenom2";
            this.lblPrenom2.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom2.TabIndex = 9;
            this.lblPrenom2.Text = "Prénom2:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(344, 80);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(167, 20);
            this.txtTelephone.TabIndex = 12;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(277, 83);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 11;
            this.lblTelephone.Text = "Téléphone:";
            // 
            // frmEtudiantTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 479);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtPrenom2);
            this.Controls.Add(this.lblPrenom2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPrenom1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPrenom1);
            this.Controls.Add(this.lblNom);
            this.Name = "frmEtudiantTest";
            this.Text = "EtudiantTest";
            this.Load += new System.EventHandler(this.frmEtudiantTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtPrenom2;
        private System.Windows.Forms.Label lblPrenom2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
    }
}

