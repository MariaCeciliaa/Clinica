namespace Clinica
{
    partial class PacientesCriar
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
            this.codigo_label = new System.Windows.Forms.Label();
            this.codigo_valor = new System.Windows.Forms.TextBox();
            this.nome_valor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.idade_valor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.cidade_valor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.cpf_valor = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.doenca_valor = new System.Windows.Forms.TextBox();
            this.doenca_label = new System.Windows.Forms.Label();
            this.titulo_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(87, 79);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 0;
            this.codigo_label.Text = "Codigo:";
            // 
            // codigo_valor
            // 
            this.codigo_valor.Location = new System.Drawing.Point(178, 76);
            this.codigo_valor.Name = "codigo_valor";
            this.codigo_valor.Size = new System.Drawing.Size(233, 20);
            this.codigo_valor.TabIndex = 1;
            this.codigo_valor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nome_valor
            // 
            this.nome_valor.Location = new System.Drawing.Point(178, 124);
            this.nome_valor.Name = "nome_valor";
            this.nome_valor.Size = new System.Drawing.Size(233, 20);
            this.nome_valor.TabIndex = 3;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(87, 127);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 2;
            this.nome_label.Text = "Nome:";
            // 
            // idade_valor
            // 
            this.idade_valor.Location = new System.Drawing.Point(178, 173);
            this.idade_valor.Name = "idade_valor";
            this.idade_valor.Size = new System.Drawing.Size(233, 20);
            this.idade_valor.TabIndex = 5;
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(87, 176);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(37, 13);
            this.idade_label.TabIndex = 4;
            this.idade_label.Text = "Idade:";
            // 
            // cidade_valor
            // 
            this.cidade_valor.Location = new System.Drawing.Point(178, 227);
            this.cidade_valor.Name = "cidade_valor";
            this.cidade_valor.Size = new System.Drawing.Size(233, 20);
            this.cidade_valor.TabIndex = 7;
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(87, 230);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(44, 13);
            this.cidade_label.TabIndex = 6;
            this.cidade_label.Text = "CIdade:";
            // 
            // cpf_valor
            // 
            this.cpf_valor.Location = new System.Drawing.Point(178, 284);
            this.cpf_valor.Name = "cpf_valor";
            this.cpf_valor.Size = new System.Drawing.Size(233, 20);
            this.cpf_valor.TabIndex = 9;
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(87, 287);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(30, 13);
            this.cpf_label.TabIndex = 8;
            this.cpf_label.Text = "CPF:";
            // 
            // doenca_valor
            // 
            this.doenca_valor.Location = new System.Drawing.Point(178, 335);
            this.doenca_valor.Name = "doenca_valor";
            this.doenca_valor.Size = new System.Drawing.Size(233, 20);
            this.doenca_valor.TabIndex = 11;
            // 
            // doenca_label
            // 
            this.doenca_label.AutoSize = true;
            this.doenca_label.Location = new System.Drawing.Point(87, 338);
            this.doenca_label.Name = "doenca_label";
            this.doenca_label.Size = new System.Drawing.Size(48, 13);
            this.doenca_label.TabIndex = 10;
            this.doenca_label.Text = "Doença:";
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(174, 23);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(172, 20);
            this.titulo_label.TabIndex = 12;
            this.titulo_label.Text = "Criar Novo Paciente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PacientesCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.doenca_valor);
            this.Controls.Add(this.doenca_label);
            this.Controls.Add(this.cpf_valor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cidade_valor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.idade_valor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nome_valor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigo_valor);
            this.Controls.Add(this.codigo_label);
            this.Name = "PacientesCriar";
            this.Text = "PacientesCriar";
            this.Load += new System.EventHandler(this.PacientesCriar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.TextBox codigo_valor;
        private System.Windows.Forms.TextBox nome_valor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox idade_valor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox cidade_valor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox cpf_valor;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox doenca_valor;
        private System.Windows.Forms.Label doenca_label;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}