namespace juego_num_aleatorios
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            label3 = new Label();
            hScrollBar1 = new HScrollBar();
            hScrollBar2 = new HScrollBar();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            intentos = new DataGridViewTextBoxColumn();
            nroElegido = new DataGridViewTextBoxColumn();
            resultado = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            button3 = new Button();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(497, 51);
            label1.Name = "label1";
            label1.Size = new Size(410, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Juego con Números";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(806, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 33);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(497, 314);
            button1.Name = "button1";
            button1.Size = new Size(195, 58);
            button1.TabIndex = 2;
            button1.Text = "Iniciar Juego";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(720, 314);
            button2.Name = "button2";
            button2.Size = new Size(195, 58);
            button2.TabIndex = 3;
            button2.Text = "Intentar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(544, 154);
            label2.Name = "label2";
            label2.Size = new Size(256, 37);
            label2.TabIndex = 4;
            label2.Text = "Ingrese el número:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(144, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 230);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dificultad";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(18, 172);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 25);
            radioButton3.TabIndex = 8;
            radioButton3.Text = "Difícil";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 115);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 25);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "Medio";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(18, 55);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 25);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Fácil";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(554, 257);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Activar pista";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(720, 259);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 7;
            label3.Text = "El número es";
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(497, 433);
            hScrollBar1.Maximum = 10;
            hScrollBar1.Minimum = 1;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(418, 37);
            hScrollBar1.TabIndex = 8;
            hScrollBar1.Value = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // hScrollBar2
            // 
            hScrollBar2.LargeChange = 1;
            hScrollBar2.Location = new Point(497, 513);
            hScrollBar2.Maximum = 60;
            hScrollBar2.Minimum = 10;
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(418, 37);
            hScrollBar2.TabIndex = 9;
            hScrollBar2.Value = 10;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(497, 394);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 10;
            label4.Text = "Número de intentos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(497, 482);
            label5.Name = "label5";
            label5.Size = new Size(224, 21);
            label5.TabIndex = 11;
            label5.Text = "Tiempo de juego (segundos):";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { intentos, nroElegido, resultado });
            dataGridView1.Location = new Point(1039, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 408);
            dataGridView1.TabIndex = 12;
            // 
            // intentos
            // 
            intentos.HeaderText = "Intento Nro";
            intentos.Name = "intentos";
            // 
            // nroElegido
            // 
            nroElegido.HeaderText = "Número Elegido";
            nroElegido.Name = "nroElegido";
            // 
            // resultado
            // 
            resultado.HeaderText = "Resultado";
            resultado.Name = "resultado";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(727, 482);
            label6.Name = "label6";
            label6.Size = new Size(25, 21);
            label6.TabIndex = 13;
            label6.Text = "10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(664, 394);
            label7.Name = "label7";
            label7.Size = new Size(16, 21);
            label7.TabIndex = 14;
            label7.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(761, 466);
            label8.Name = "label8";
            label8.Size = new Size(253, 37);
            label8.TabIndex = 15;
            label8.Text = "¡Tiempo Agotado!";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(740, 378);
            label9.Name = "label9";
            label9.Size = new Size(274, 37);
            label9.TabIndex = 16;
            label9.Text = "¡Intentos Agotados!";
            label9.TextAlign = ContentAlignment.TopCenter;
            label9.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(144, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 177);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrar Pares";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(27, 48);
            label10.Name = "label10";
            label10.Size = new Size(154, 42);
            label10.TabIndex = 18;
            label10.Text = "Muestra nros pares \r\nusando recursiva";
            // 
            // button3
            // 
            button3.Location = new Point(40, 117);
            button3.Name = "button3";
            button3.Size = new Size(105, 39);
            button3.TabIndex = 0;
            button3.Text = "Mostrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(1039, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(344, 84);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Puntaje";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(196, 42);
            label12.Name = "label12";
            label12.Size = new Size(19, 21);
            label12.TabIndex = 9;
            label12.Text = "0";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(62, 42);
            label11.Name = "label11";
            label11.Size = new Size(108, 21);
            label11.TabIndex = 8;
            label11.Text = "Su puntaje es:";
            label11.Click += label11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 605);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(hScrollBar2);
            Controls.Add(hScrollBar1);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private Label label3;
        private HScrollBar hScrollBar1;
        private HScrollBar hScrollBar2;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn intentos;
        private DataGridViewTextBoxColumn nroElegido;
        private DataGridViewTextBoxColumn resultado;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private Button button3;
        private Label label10;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
    }
}
