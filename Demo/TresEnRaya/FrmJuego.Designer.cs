namespace TresEnRaya
{
    partial class FrmJuego
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnReiniciar = new Button();
            lblTurno = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblVictoriasX = new Label();
            lblVictoriasO = new Label();
            lblEmpates = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Tres en Raya";
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(38, 48);
            btn1.Name = "btn1";
            btn1.Size = new Size(74, 74);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnMarcar_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(118, 48);
            btn2.Name = "btn2";
            btn2.Size = new Size(74, 74);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnMarcar_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(198, 48);
            btn3.Name = "btn3";
            btn3.Size = new Size(74, 74);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnMarcar_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(198, 128);
            btn6.Name = "btn6";
            btn6.Size = new Size(74, 74);
            btn6.TabIndex = 6;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnMarcar_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(118, 128);
            btn5.Name = "btn5";
            btn5.Size = new Size(74, 74);
            btn5.TabIndex = 5;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnMarcar_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(38, 128);
            btn4.Name = "btn4";
            btn4.Size = new Size(74, 74);
            btn4.TabIndex = 4;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnMarcar_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(198, 208);
            btn9.Name = "btn9";
            btn9.Size = new Size(74, 74);
            btn9.TabIndex = 9;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnMarcar_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(118, 208);
            btn8.Name = "btn8";
            btn8.Size = new Size(74, 74);
            btn8.TabIndex = 8;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnMarcar_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(38, 208);
            btn7.Name = "btn7";
            btn7.Size = new Size(74, 74);
            btn7.TabIndex = 7;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnMarcar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(117, 288);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 10;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(12, 26);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(55, 15);
            lblTurno.TabIndex = 11;
            lblTurno.Text = "Turno: --";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 304);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 12;
            label3.Text = "Jugador X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 319);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 13;
            label4.Text = "Jugador O:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 304);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 14;
            label5.Text = "Empates:";
            // 
            // lblVictoriasX
            // 
            lblVictoriasX.AutoSize = true;
            lblVictoriasX.Location = new Point(81, 304);
            lblVictoriasX.Name = "lblVictoriasX";
            lblVictoriasX.Size = new Size(13, 15);
            lblVictoriasX.TabIndex = 15;
            lblVictoriasX.Text = "0";
            // 
            // lblVictoriasO
            // 
            lblVictoriasO.AutoSize = true;
            lblVictoriasO.Location = new Point(81, 319);
            lblVictoriasO.Name = "lblVictoriasO";
            lblVictoriasO.Size = new Size(13, 15);
            lblVictoriasO.TabIndex = 16;
            lblVictoriasO.Text = "0";
            // 
            // lblEmpates
            // 
            lblEmpates.AutoSize = true;
            lblEmpates.Location = new Point(257, 304);
            lblEmpates.Name = "lblEmpates";
            lblEmpates.Size = new Size(13, 15);
            lblEmpates.TabIndex = 17;
            lblEmpates.Text = "0";
            // 
            // FrmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 337);
            Controls.Add(lblEmpates);
            Controls.Add(lblVictoriasO);
            Controls.Add(lblVictoriasX);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTurno);
            Controls.Add(btnReiniciar);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "::: Tres en Raya :::";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnReiniciar;
        private Label lblTurno;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblVictoriasX;
        private Label lblVictoriasO;
        private Label lblEmpates;
    }
}
