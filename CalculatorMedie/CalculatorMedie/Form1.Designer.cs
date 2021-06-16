
namespace CalculatorMedie
{
    partial class FrmMain
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
            this.lstMedii = new System.Windows.Forms.ListBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.txtMedii = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.grbTeza = new System.Windows.Forms.GroupBox();
            this.rdbFaraTeza = new System.Windows.Forms.RadioButton();
            this.rdbCuTeza = new System.Windows.Forms.RadioButton();
            this.lblTeza = new System.Windows.Forms.Label();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.lblMedie = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            this.txtMedie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTeza = new System.Windows.Forms.Panel();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbTeza.SuspendLayout();
            this.pnlTeza.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMedii
            // 
            this.lstMedii.FormattingEnabled = true;
            this.lstMedii.ItemHeight = 16;
            this.lstMedii.Location = new System.Drawing.Point(321, 127);
            this.lstMedii.Name = "lstMedii";
            this.lstMedii.Size = new System.Drawing.Size(150, 180);
            this.lstMedii.TabIndex = 0;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(670, 304);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(118, 35);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtMedii
            // 
            this.txtMedii.Location = new System.Drawing.Point(341, 90);
            this.txtMedii.Name = "txtMedii";
            this.txtMedii.Size = new System.Drawing.Size(110, 22);
            this.txtMedii.TabIndex = 2;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(373, 70);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(50, 17);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "MEDII";
            // 
            // grbTeza
            // 
            this.grbTeza.Controls.Add(this.rdbFaraTeza);
            this.grbTeza.Controls.Add(this.rdbCuTeza);
            this.grbTeza.Location = new System.Drawing.Point(582, 104);
            this.grbTeza.Name = "grbTeza";
            this.grbTeza.Size = new System.Drawing.Size(160, 104);
            this.grbTeza.TabIndex = 4;
            this.grbTeza.TabStop = false;
            // 
            // rdbFaraTeza
            // 
            this.rdbFaraTeza.AutoSize = true;
            this.rdbFaraTeza.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFaraTeza.Location = new System.Drawing.Point(4, 57);
            this.rdbFaraTeza.Name = "rdbFaraTeza";
            this.rdbFaraTeza.Size = new System.Drawing.Size(152, 21);
            this.rdbFaraTeza.TabIndex = 1;
            this.rdbFaraTeza.TabStop = true;
            this.rdbFaraTeza.Text = "MEDIA FARA TEZA";
            this.rdbFaraTeza.UseVisualStyleBackColor = true;
            // 
            // rdbCuTeza
            // 
            this.rdbCuTeza.AutoSize = true;
            this.rdbCuTeza.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCuTeza.Location = new System.Drawing.Point(4, 21);
            this.rdbCuTeza.Name = "rdbCuTeza";
            this.rdbCuTeza.Size = new System.Drawing.Size(135, 21);
            this.rdbCuTeza.TabIndex = 0;
            this.rdbCuTeza.TabStop = true;
            this.rdbCuTeza.Text = "MEDIA CU TEZA";
            this.rdbCuTeza.UseVisualStyleBackColor = true;
            this.rdbCuTeza.CheckedChanged += new System.EventHandler(this.rdbCuTeza_CheckedChanged);
            // 
            // lblTeza
            // 
            this.lblTeza.AutoSize = true;
            this.lblTeza.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeza.Location = new System.Drawing.Point(607, 84);
            this.lblTeza.Name = "lblTeza";
            this.lblTeza.Size = new System.Drawing.Size(114, 17);
            this.lblTeza.TabIndex = 5;
            this.lblTeza.Text = "MEDIA CU TEZA";
            this.lblTeza.Click += new System.EventHandler(this.lblTeza_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculeaza.Location = new System.Drawing.Point(670, 403);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(118, 35);
            this.btnCalculeaza.TabIndex = 6;
            this.btnCalculeaza.Text = "CALCULEAZA";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // lblMedie
            // 
            this.lblMedie.AutoSize = true;
            this.lblMedie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedie.Location = new System.Drawing.Point(24, 368);
            this.lblMedie.Name = "lblMedie";
            this.lblMedie.Size = new System.Drawing.Size(87, 23);
            this.lblMedie.TabIndex = 7;
            this.lblMedie.Text = "MEDIA :";
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(670, 357);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(118, 35);
            this.btnSterge.TabIndex = 9;
            this.btnSterge.Text = "STERGE";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // txtMedie
            // 
            this.txtMedie.Location = new System.Drawing.Point(10, 32);
            this.txtMedie.Name = "txtMedie";
            this.txtMedie.Size = new System.Drawing.Size(113, 22);
            this.txtMedie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOTA TEZA";
            // 
            // pnlTeza
            // 
            this.pnlTeza.Controls.Add(this.label1);
            this.pnlTeza.Controls.Add(this.txtMedie);
            this.pnlTeza.Location = new System.Drawing.Point(586, 219);
            this.pnlTeza.Name = "pnlTeza";
            this.pnlTeza.Size = new System.Drawing.Size(137, 79);
            this.pnlTeza.TabIndex = 11;
            // 
            // lblFinal
            // 
            this.lblFinal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(117, 371);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(43, 17);
            this.lblFinal.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(28, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 35);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.pnlTeza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.lblMedie);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.lblTeza);
            this.Controls.Add(this.grbTeza);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtMedii);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lstMedii);
            this.Name = "FrmMain";
            this.Text = "Calculator medii";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grbTeza.ResumeLayout(false);
            this.grbTeza.PerformLayout();
            this.pnlTeza.ResumeLayout(false);
            this.pnlTeza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedii;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox txtMedii;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox grbTeza;
        private System.Windows.Forms.RadioButton rdbFaraTeza;
        private System.Windows.Forms.RadioButton rdbCuTeza;
        private System.Windows.Forms.Label lblTeza;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Label lblMedie;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.TextBox txtMedie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTeza;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnReset;
    }
}

