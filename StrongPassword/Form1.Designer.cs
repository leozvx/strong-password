namespace StrongPassword
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_ViewPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(38, 78);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(212, 20);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(38, 124);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(0, 13);
            this.lbl_Result.TabIndex = 1;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(271, 78);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(119, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Clean";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_ViewPass
            // 
            this.btn_ViewPass.Location = new System.Drawing.Point(271, 107);
            this.btn_ViewPass.Name = "btn_ViewPass";
            this.btn_ViewPass.Size = new System.Drawing.Size(119, 23);
            this.btn_ViewPass.TabIndex = 3;
            this.btn_ViewPass.Text = "Show Password";
            this.btn_ViewPass.UseVisualStyleBackColor = true;
            this.btn_ViewPass.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password  Tester";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ViewPass);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txt_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strong Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_ViewPass;
        private System.Windows.Forms.Label label2;
    }
}

