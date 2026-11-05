namespace CursoWindowsForms
{
    partial class Frm_HelloWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWord));
            lbl_Titulo = new Label();
            Btn_Sair = new Button();
            Btn_ModificaLabel = new Button();
            Txt_ConteudoLabel = new TextBox();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(25, 29);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(213, 19);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Btn_Sair
            // 
            Btn_Sair.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Sair.Location = new Point(291, 360);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(172, 35);
            Btn_Sair.TabIndex = 1;
            Btn_Sair.Text = "Fechar a aplicação";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Btn_ModificaLabel
            // 
            Btn_ModificaLabel.Location = new Point(25, 51);
            Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            Btn_ModificaLabel.Size = new Size(213, 32);
            Btn_ModificaLabel.TabIndex = 2;
            Btn_ModificaLabel.Text = "Modifica Texto do Label";
            Btn_ModificaLabel.UseVisualStyleBackColor = true;
            Btn_ModificaLabel.Click += Btn_ModificaLabel_Click;
            // 
            // Txt_ConteudoLabel
            // 
            Txt_ConteudoLabel.Location = new Point(25, 99);
            Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            Txt_ConteudoLabel.Size = new Size(326, 26);
            Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(475, 407);
            Controls.Add(Txt_ConteudoLabel);
            Controls.Add(Btn_ModificaLabel);
            Controls.Add(Btn_Sair);
            Controls.Add(lbl_Titulo);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_HelloWord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hello World!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Button Btn_Sair;
        private Button Btn_ModificaLabel;
        private TextBox Txt_ConteudoLabel;
    }
}
