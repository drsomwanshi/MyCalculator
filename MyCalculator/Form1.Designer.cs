﻿namespace MyCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button13, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button14, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button15, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button17, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 177);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(145, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(74, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 29);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(145, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 29);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(74, 143);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 29);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(145, 143);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 29);
            this.button11.TabIndex = 10;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.NumBtnClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(216, 143);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 29);
            this.button12.TabIndex = 11;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(216, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(65, 29);
            this.button13.TabIndex = 12;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OpBtnClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(216, 38);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(65, 29);
            this.button14.TabIndex = 13;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.OpBtnClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(216, 73);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(65, 29);
            this.button15.TabIndex = 14;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.OpBtnClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(216, 108);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(65, 29);
            this.button16.TabIndex = 15;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.OpBtnClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(145, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(65, 29);
            this.button17.TabIndex = 16;
            this.button17.Text = "Back";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 249);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MyCalculator";
            this.Click += new System.EventHandler(this.NumBtnClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}

