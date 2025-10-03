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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(47, 102, 129);
            label1.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(373, 23);
            label1.Name = "label1";
            label1.Size = new Size(113, 29);
            label1.TabIndex = 0;
            label1.Text = "ALUMNOS";
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Medium", 10.2F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 40);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Franklin Gothic Medium", 10.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 40);
            label3.TabIndex = 1;
            label3.Text = "Apellido:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Franklin Gothic Medium", 10.2F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 40);
            label4.TabIndex = 1;
            label4.Text = "Fecha de nacimiento:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Franklin Gothic Medium", 10.2F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 40);
            label5.TabIndex = 1;
            label5.Text = "Pais:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Franklin Gothic Medium", 10.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 40);
            label6.TabIndex = 1;
            label6.Text = "Edad:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.FromArgb(47, 102, 129);
            btn_limpiar.Location = new Point(94, 377);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(94, 29);
            btn_limpiar.TabIndex = 2;
            btn_limpiar.Text = "LIMPIAR";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.ForeColor = Color.FromArgb(47, 102, 129);
            btn_cerrar.Location = new Point(337, 377);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(94, 29);
            btn_cerrar.TabIndex = 3;
            btn_cerrar.Text = "CERRAR";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // tb_nombre
            // 
            tb_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_nombre.Location = new Point(166, 7);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(294, 27);
            tb_nombre.TabIndex = 4;
            // 
            // tb_apellido
            // 
            tb_apellido.Location = new Point(166, 7);
            tb_apellido.Name = "tb_apellido";
            tb_apellido.Size = new Size(294, 27);
            tb_apellido.TabIndex = 5;
            // 
            // dtp_fechaNac
            // 
            dtp_fechaNac.Location = new Point(168, 5);
            dtp_fechaNac.Name = "dtp_fechaNac";
            dtp_fechaNac.Size = new Size(292, 27);
            dtp_fechaNac.TabIndex = 6;
            // 
            // cb_pais
            // 
            cb_pais.FormattingEnabled = true;
            cb_pais.Location = new Point(165, 7);
            cb_pais.Name = "cb_pais";
            cb_pais.Size = new Size(292, 28);
            cb_pais.TabIndex = 7;
            // 
            // tb_edad
            // 
            tb_edad.Location = new Point(168, 7);
            tb_edad.Name = "tb_edad";
            tb_edad.Size = new Size(122, 27);
            tb_edad.TabIndex = 8;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(366, 6);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(94, 29);
            btn_calcular.TabIndex = 9;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_nombre);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 40);
            panel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(47, 102, 129);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(36, 117);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(467, 238);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_apellido);
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 40);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dtp_fechaNac);
            panel3.Location = new Point(3, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 40);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(cb_pais);
            panel4.Location = new Point(3, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 40);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(tb_edad);
            panel5.Controls.Add(btn_calcular);
            panel5.Location = new Point(3, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(460, 40);
            panel5.TabIndex = 12;
            // 
            // Alumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(93, 104, 138);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_limpiar);
            Controls.Add(label1);
            Name = "Alumnos";
            Text = "Alumnos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}