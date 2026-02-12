namespace CadAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textMesa = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextData = new System.Windows.Forms.MaskedTextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mensalidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "CidadeId";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(165, 45);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(126, 20);
            this.textId.TabIndex = 4;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(165, 79);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(126, 20);
            this.textNome.TabIndex = 5;
            // 
            // textMesa
            // 
            this.textMesa.Location = new System.Drawing.Point(165, 118);
            this.textMesa.Name = "textMesa";
            this.textMesa.Size = new System.Drawing.Size(126, 20);
            this.textMesa.TabIndex = 6;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(165, 155);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(126, 20);
            this.textCidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Nasc";
            // 
            // maskedTextData
            // 
            this.maskedTextData.Location = new System.Drawing.Point(165, 196);
            this.maskedTextData.Mask = "00/00/0000";
            this.maskedTextData.Name = "maskedTextData";
            this.maskedTextData.Size = new System.Drawing.Size(126, 20);
            this.maskedTextData.TabIndex = 9;
            this.maskedTextData.ValidatingType = typeof(System.DateTime);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(16, 260);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(125, 40);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.maskedTextData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textMesa);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textMesa;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextData;
        private System.Windows.Forms.Button btnInserir;
    }
}

