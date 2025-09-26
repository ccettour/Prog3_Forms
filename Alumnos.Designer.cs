namespace formulario
{
    partial class Alumnos
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_limpiar = new Button();
            btn_cerrar = new Button();
            tb_nombre = new TextBox();
            tb_apellido = new TextBox();
            dtp_fechaNac = new DateTimePicker();
            cb_pais = new ComboBox();
            tb_edad = new TextBox();
            btn_calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(359, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 29);
            label1.TabIndex = 0;
            label1.Text = "ALUMNOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 10.2F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(41, 66);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 10.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(41, 104);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 1;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 10.2F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(41, 143);
            label4.Name = "label4";
            label4.Size = new Size(164, 21);
            label4.TabIndex = 1;
            label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 10.2F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(41, 185);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 1;
            label5.Text = "Pais:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 10.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(41, 224);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 1;
            label6.Text = "Edad:";
            label6.Click += label6_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(293, 315);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(94, 29);
            btn_limpiar.TabIndex = 2;
            btn_limpiar.Text = "LIMPIAR";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(503, 315);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(94, 29);
            btn_cerrar.TabIndex = 3;
            btn_cerrar.Text = "CERRAR";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(232, 63);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(292, 27);
            tb_nombre.TabIndex = 4;
            // 
            // tb_apellido
            // 
            tb_apellido.Location = new Point(232, 101);
            tb_apellido.Name = "tb_apellido";
            tb_apellido.Size = new Size(292, 27);
            tb_apellido.TabIndex = 5;
            // 
            // dtp_fechaNac
            // 
            dtp_fechaNac.Location = new Point(232, 138);
            dtp_fechaNac.Name = "dtp_fechaNac";
            dtp_fechaNac.Size = new Size(292, 27);
            dtp_fechaNac.TabIndex = 6;
            // 
            // cb_pais
            // 
            cb_pais.FormattingEnabled = true;
            cb_pais.Location = new Point(232, 182);
            cb_pais.Name = "cb_pais";
            cb_pais.Size = new Size(292, 28);
            cb_pais.TabIndex = 7;
            cb_pais.SelectedIndexChanged += cb_pais_SelectedIndexChanged;
            // 
            // tb_edad
            // 
            tb_edad.Location = new Point(232, 221);
            tb_edad.Name = "tb_edad";
            tb_edad.Size = new Size(122, 27);
            tb_edad.TabIndex = 8;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(378, 220);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(94, 29);
            btn_calcular.TabIndex = 9;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // Alumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(93, 104, 138);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_calcular);
            Controls.Add(tb_edad);
            Controls.Add(cb_pais);
            Controls.Add(dtp_fechaNac);
            Controls.Add(tb_apellido);
            Controls.Add(tb_nombre);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_limpiar);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Alumnos";
            Text = "Alumnos";
            Load += Alumnos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_limpiar;
        private Button btn_cerrar;
        private TextBox tb_nombre;
        private TextBox tb_apellido;
        private DateTimePicker dtp_fechaNac;
        private ComboBox cb_pais;
        private TextBox tb_edad;
        private Button btn_calcular;
    }
}