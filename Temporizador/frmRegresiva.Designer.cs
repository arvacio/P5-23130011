﻿namespace Temporizador
{
    partial class frmRegresiva
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
            components = new System.ComponentModel.Container();
            label5 = new Label();
            label4 = new Label();
            lblSegundos = new Label();
            lblMinutos = new Label();
            lblHoras = new Label();
            btnEstablecer = new Button();
            btnIniciar = new Button();
            timerRegresiva = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(391, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 159);
            label5.TabIndex = 11;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(161, 11);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 159);
            label4.TabIndex = 10;
            label4.Text = ":";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundos.Location = new Point(450, 22);
            lblSegundos.Margin = new Padding(2, 0, 2, 0);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(197, 159);
            lblSegundos.TabIndex = 9;
            lblSegundos.Text = "00";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(237, 22);
            lblMinutos.Margin = new Padding(2, 0, 2, 0);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(197, 159);
            lblMinutos.TabIndex = 8;
            lblMinutos.Text = "00";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoras.Location = new Point(-1, 22);
            lblHoras.Margin = new Padding(2, 0, 2, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(197, 159);
            lblHoras.TabIndex = 7;
            lblHoras.Text = "00";
            // 
            // btnEstablecer
            // 
            btnEstablecer.Location = new Point(225, 184);
            btnEstablecer.Margin = new Padding(2);
            btnEstablecer.Name = "btnEstablecer";
            btnEstablecer.Size = new Size(90, 55);
            btnEstablecer.TabIndex = 12;
            btnEstablecer.Text = "Establecer tiempo";
            btnEstablecer.UseVisualStyleBackColor = true;
            btnEstablecer.Click += btnEstablecer_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(324, 184);
            btnIniciar.Margin = new Padding(2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(90, 55);
            btnIniciar.TabIndex = 13;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += button2_Click;
            // 
            // timerRegresiva
            // 
            timerRegresiva.Interval = 1000;
            timerRegresiva.Tick += timerRegresiva_Tick;
            // 
            // frmRegresiva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 259);
            Controls.Add(btnIniciar);
            Controls.Add(btnEstablecer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHoras);
            Margin = new Padding(2);
            Name = "frmRegresiva";
            Text = "Cuenta Regresiva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label lblSegundos;
        private Label lblMinutos;
        private Label lblHoras;
        private Button btnEstablecer;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timerRegresiva;
    }
}