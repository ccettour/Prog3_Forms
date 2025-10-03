namespace formulario
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            tb_num2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_num1 = new TextBox();
            label3 = new Label();
            rb_suma = new RadioButton();
            rb_resta = new RadioButton();
            rb_multi = new RadioButton();
            rb_division = new RadioButton();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btn_calcular = new Button();
            lb_resultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(247, 165, 165);
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(495, 97);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(125, 27);
            tb_num2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.2F);
            label1.ForeColor = Color.FromArgb(255, 242, 239);
            label1.Location = new Point(346, 47);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 2;
            label1.Text = "Primer numero:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 10.2F);
            label2.ForeColor = Color.FromArgb(255, 242, 239);
            label2.Location = new Point(346, 100);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 2;
            label2.Text = "Segundo numero:";
            label2.Click += label1_Click;
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(495, 44);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(125, 27);
            tb_num1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 10.2F);
            label3.ForeColor = Color.FromArgb(255, 242, 239);
            label3.Location = new Point(346, 167);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Operación:";
            label3.Click += label1_Click;
            // 
            // rb_suma
            // 
            rb_suma.AutoSize = true;
            rb_suma.ForeColor = Color.FromArgb(255, 242, 239);
            rb_suma.Location = new Point(495, 165);
            rb_suma.Name = "rb_suma";
            rb_suma.Size = new Size(72, 24);
            rb_suma.TabIndex = 3;
            rb_suma.TabStop = true;
            rb_suma.Text = "Sumar";
            rb_suma.UseVisualStyleBackColor = true;
            // 
            // rb_resta
            // 
            rb_resta.AutoSize = true;
            rb_resta.ForeColor = Color.FromArgb(255, 242, 239);
            rb_resta.Location = new Point(495, 195);
            rb_resta.Name = "rb_resta";
            rb_resta.Size = new Size(71, 24);
            rb_resta.TabIndex = 3;
            rb_resta.TabStop = true;
            rb_resta.Text = "Restar";
            rb_resta.UseVisualStyleBackColor = true;
            // 
            // rb_multi
            // 
            rb_multi.AutoSize = true;
            rb_multi.ForeColor = Color.FromArgb(255, 242, 239);
            rb_multi.Location = new Point(496, 225);
            rb_multi.Name = "rb_multi";
            rb_multi.Size = new Size(101, 24);
            rb_multi.TabIndex = 3;
            rb_multi.TabStop = true;
            rb_multi.Text = "Multiplicar";
            rb_multi.UseVisualStyleBackColor = true;
            // 
            // rb_division
            // 
            rb_division.AutoSize = true;
            rb_division.ForeColor = Color.FromArgb(255, 242, 239);
            rb_division.Location = new Point(495, 255);
            rb_division.Name = "rb_division";
            rb_division.Size = new Size(74, 24);
            rb_division.TabIndex = 3;
            rb_division.TabStop = true;
            rb_division.Text = "Dividir";
            rb_division.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 10.2F);
            label4.ForeColor = Color.FromArgb(255, 242, 239);
            label4.Location = new Point(346, 373);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 2;
            label4.Text = "Resultado:";
            label4.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 399);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(488, 311);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(94, 29);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Font = new Font("Franklin Gothic Medium", 10.2F);
            lb_resultado.ForeColor = Color.FromArgb(255, 242, 239);
            lb_resultado.Location = new Point(495, 373);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(0, 21);
            lb_resultado.TabIndex = 8;
            lb_resultado.Click += label5_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(93, 104, 138);
            ClientSize = new Size(800, 450);
            Controls.Add(lb_resultado);
            Controls.Add(btn_calcular);
            Controls.Add(pictureBox1);
            Controls.Add(rb_division);
            Controls.Add(rb_multi);
            Controls.Add(rb_resta);
            Controls.Add(rb_suma);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_num1);
            Controls.Add(tb_num2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tb_num2;
        private Label label1;
        private Label label2;
        private TextBox tb_num1;
        private Label label3;
        private RadioButton rb_suma;
        private RadioButton rb_resta;
        private RadioButton rb_multi;
        private RadioButton rb_division;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btn_calcular;
        private Label lb_resultado;
    }
}