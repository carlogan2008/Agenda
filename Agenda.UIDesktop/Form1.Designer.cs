namespace Agenda.UIDesktop
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
            label1 = new Label();
            lblContatoNovo = new Label();
            txtContatoNovo = new TextBox();
            lblContatoSalvo = new Label();
            txtContatoSalvo = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblContatoNovo
            // 
            lblContatoNovo.AutoSize = true;
            lblContatoNovo.Location = new Point(20, 17);
            lblContatoNovo.Name = "lblContatoNovo";
            lblContatoNovo.Size = new Size(80, 15);
            lblContatoNovo.TabIndex = 1;
            lblContatoNovo.Text = "Contato novo";
            // 
            // txtContatoNovo
            // 
            txtContatoNovo.Location = new Point(24, 35);
            txtContatoNovo.Name = "txtContatoNovo";
            txtContatoNovo.Size = new Size(337, 23);
            txtContatoNovo.TabIndex = 2;
            // 
            // lblContatoSalvo
            // 
            lblContatoSalvo.AutoSize = true;
            lblContatoSalvo.Location = new Point(24, 71);
            lblContatoSalvo.Name = "lblContatoSalvo";
            lblContatoSalvo.Size = new Size(80, 15);
            lblContatoSalvo.TabIndex = 3;
            lblContatoSalvo.Text = "Contato salvo";
            // 
            // txtContatoSalvo
            // 
            txtContatoSalvo.Location = new Point(24, 89);
            txtContatoSalvo.Name = "txtContatoSalvo";
            txtContatoSalvo.Size = new Size(337, 23);
            txtContatoSalvo.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(148, 137);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtContatoSalvo);
            Controls.Add(lblContatoSalvo);
            Controls.Add(txtContatoNovo);
            Controls.Add(lblContatoNovo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblContatoNovo;
        private TextBox txtContatoNovo;
        private Label lblContatoSalvo;
        private TextBox txtContatoSalvo;
        private Button btnSalvar;
    }
}