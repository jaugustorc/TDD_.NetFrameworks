﻿namespace Agenda.UIDesktop
{
    partial class Form1
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
            this.lblNovoContato = new System.Windows.Forms.Label();
            this.txtNovoContato = new System.Windows.Forms.TextBox();
            this.lblContatoSalvo = new System.Windows.Forms.Label();
            this.txtContatoSalvo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNovoContato
            // 
            this.lblNovoContato.AutoSize = true;
            this.lblNovoContato.Location = new System.Drawing.Point(26, 25);
            this.lblNovoContato.Name = "lblNovoContato";
            this.lblNovoContato.Size = new System.Drawing.Size(73, 13);
            this.lblNovoContato.TabIndex = 0;
            this.lblNovoContato.Text = "Novo Contato";
            // 
            // txtNovoContato
            // 
            this.txtNovoContato.Location = new System.Drawing.Point(29, 41);
            this.txtNovoContato.Name = "txtNovoContato";
            this.txtNovoContato.Size = new System.Drawing.Size(303, 20);
            this.txtNovoContato.TabIndex = 1;
            // 
            // lblContatoSalvo
            // 
            this.lblContatoSalvo.AutoSize = true;
            this.lblContatoSalvo.Location = new System.Drawing.Point(26, 67);
            this.lblContatoSalvo.Name = "lblContatoSalvo";
            this.lblContatoSalvo.Size = new System.Drawing.Size(74, 13);
            this.lblContatoSalvo.TabIndex = 2;
            this.lblContatoSalvo.Text = "Contato Salvo"; 
            // 
            // txtContatoSalvo
            // 
            this.txtContatoSalvo.Location = new System.Drawing.Point(29, 83);
            this.txtContatoSalvo.Name = "txtContatoSalvo";
            this.txtContatoSalvo.Size = new System.Drawing.Size(303, 20);
            this.txtContatoSalvo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(94, 119);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(175, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtContatoSalvo);
            this.Controls.Add(this.lblContatoSalvo);
            this.Controls.Add(this.txtNovoContato);
            this.Controls.Add(this.lblNovoContato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNovoContato;
        private System.Windows.Forms.TextBox txtNovoContato;
        private System.Windows.Forms.Label lblContatoSalvo;
        private System.Windows.Forms.TextBox txtContatoSalvo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

