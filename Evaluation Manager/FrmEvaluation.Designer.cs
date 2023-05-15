namespace Evaluation_Manager {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.lbl_aktivnost = new System.Windows.Forms.Label();
            this.lbl_UvjetZaPotpis = new System.Windows.Forms.Label();
            this.lbl_UvjetZaOcjenu = new System.Windows.Forms.Label();
            this.lbl_datum_evaluacije = new System.Windows.Forms.Label();
            this.lbl_ocjenjivac = new System.Windows.Forms.Label();
            this.lbl_Bodovi = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(12, 33);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(196, 21);
            this.cboActivities.TabIndex = 0;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(280, 34);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 1;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(195, 256);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 2;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(12, 60);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(474, 149);
            this.txtActivityDescription.TabIndex = 3;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(386, 34);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinForGrade.TabIndex = 4;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(301, 256);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(100, 20);
            this.txtEvaluationDate.TabIndex = 5;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(407, 256);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(79, 20);
            this.numPoints.TabIndex = 6;
            // 
            // lbl_aktivnost
            // 
            this.lbl_aktivnost.AutoSize = true;
            this.lbl_aktivnost.Location = new System.Drawing.Point(12, 17);
            this.lbl_aktivnost.Name = "lbl_aktivnost";
            this.lbl_aktivnost.Size = new System.Drawing.Size(54, 13);
            this.lbl_aktivnost.TabIndex = 7;
            this.lbl_aktivnost.Text = "Aktivnost:";
            // 
            // lbl_UvjetZaPotpis
            // 
            this.lbl_UvjetZaPotpis.AutoSize = true;
            this.lbl_UvjetZaPotpis.Location = new System.Drawing.Point(277, 18);
            this.lbl_UvjetZaPotpis.Name = "lbl_UvjetZaPotpis";
            this.lbl_UvjetZaPotpis.Size = new System.Drawing.Size(80, 13);
            this.lbl_UvjetZaPotpis.TabIndex = 8;
            this.lbl_UvjetZaPotpis.Text = "Uvjet za potpis:";
            // 
            // lbl_UvjetZaOcjenu
            // 
            this.lbl_UvjetZaOcjenu.AutoSize = true;
            this.lbl_UvjetZaOcjenu.Location = new System.Drawing.Point(383, 18);
            this.lbl_UvjetZaOcjenu.Name = "lbl_UvjetZaOcjenu";
            this.lbl_UvjetZaOcjenu.Size = new System.Drawing.Size(84, 13);
            this.lbl_UvjetZaOcjenu.TabIndex = 9;
            this.lbl_UvjetZaOcjenu.Text = "Uvjet za ocjenu:";
            // 
            // lbl_datum_evaluacije
            // 
            this.lbl_datum_evaluacije.AutoSize = true;
            this.lbl_datum_evaluacije.Location = new System.Drawing.Point(303, 240);
            this.lbl_datum_evaluacije.Name = "lbl_datum_evaluacije";
            this.lbl_datum_evaluacije.Size = new System.Drawing.Size(92, 13);
            this.lbl_datum_evaluacije.TabIndex = 10;
            this.lbl_datum_evaluacije.Text = "Datum evaluacije:";
            // 
            // lbl_ocjenjivac
            // 
            this.lbl_ocjenjivac.AutoSize = true;
            this.lbl_ocjenjivac.Location = new System.Drawing.Point(192, 240);
            this.lbl_ocjenjivac.Name = "lbl_ocjenjivac";
            this.lbl_ocjenjivac.Size = new System.Drawing.Size(57, 13);
            this.lbl_ocjenjivac.TabIndex = 11;
            this.lbl_ocjenjivac.Text = "Ocjenjivač";
            // 
            // lbl_Bodovi
            // 
            this.lbl_Bodovi.AutoSize = true;
            this.lbl_Bodovi.Location = new System.Drawing.Point(404, 240);
            this.lbl_Bodovi.Name = "lbl_Bodovi";
            this.lbl_Bodovi.Size = new System.Drawing.Size(43, 13);
            this.lbl_Bodovi.TabIndex = 12;
            this.lbl_Bodovi.Text = "Bodovi:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(316, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(407, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl_Bodovi);
            this.Controls.Add(this.lbl_ocjenjivac);
            this.Controls.Add(this.lbl_datum_evaluacije);
            this.Controls.Add(this.lbl_UvjetZaOcjenu);
            this.Controls.Add(this.lbl_UvjetZaPotpis);
            this.Controls.Add(this.lbl_aktivnost);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label lbl_aktivnost;
        private System.Windows.Forms.Label lbl_UvjetZaPotpis;
        private System.Windows.Forms.Label lbl_UvjetZaOcjenu;
        private System.Windows.Forms.Label lbl_datum_evaluacije;
        private System.Windows.Forms.Label lbl_ocjenjivac;
        private System.Windows.Forms.Label lbl_Bodovi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}