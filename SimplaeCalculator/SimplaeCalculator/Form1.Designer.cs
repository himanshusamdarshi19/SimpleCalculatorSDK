using System;
using System.Windows.Forms;

namespace SimplaeCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.left_shft = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.right_shft = new System.Windows.Forms.Button();
            this.full_stp = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.equal_to = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.opn_crly_brac = new System.Windows.Forms.Button();
            this.Delete_All = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clos_crly_brac = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(21, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(749, 80);
            this.textBox1.TabIndex = 0;
            //this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // left_shft
            // 
            this.left_shft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_shft.Location = new System.Drawing.Point(21, 119);
            this.left_shft.Name = "left_shft";
            this.left_shft.Size = new System.Drawing.Size(117, 55);
            this.left_shft.TabIndex = 1;
            this.left_shft.Text = "<<";
            this.left_shft.UseVisualStyleBackColor = true;
            this.left_shft.Click += new System.EventHandler(this.left_shft_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(21, 180);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(117, 55);
            this.seven.TabIndex = 2;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(170, 180);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(122, 55);
            this.eight.TabIndex = 3;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(634, 180);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(136, 55);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "CC";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(479, 364);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 58);
            this.add.TabIndex = 6;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // right_shft
            // 
            this.right_shft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_shft.Location = new System.Drawing.Point(170, 119);
            this.right_shft.Name = "right_shft";
            this.right_shft.Size = new System.Drawing.Size(122, 55);
            this.right_shft.TabIndex = 7;
            this.right_shft.Text = ">>";
            this.right_shft.UseVisualStyleBackColor = true;
            this.right_shft.Click += new System.EventHandler(this.right_shft_Click);
            // 
            // full_stp
            // 
            this.full_stp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_stp.Location = new System.Drawing.Point(325, 364);
            this.full_stp.Name = "full_stp";
            this.full_stp.Size = new System.Drawing.Size(123, 58);
            this.full_stp.TabIndex = 8;
            this.full_stp.Text = ".";
            this.full_stp.UseVisualStyleBackColor = true;
            this.full_stp.Click += new System.EventHandler(this.full_stp_Click);
            // 
            // Mod
            // 
            this.Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mod.Location = new System.Drawing.Point(634, 241);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(136, 55);
            this.Mod.TabIndex = 9;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.Mod_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(170, 364);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(122, 58);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(325, 180);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(123, 55);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // equal_to
            // 
            this.equal_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_to.Location = new System.Drawing.Point(634, 302);
            this.equal_to.Name = "equal_to";
            this.equal_to.Size = new System.Drawing.Size(136, 120);
            this.equal_to.TabIndex = 12;
            this.equal_to.Text = "=";
            this.equal_to.UseVisualStyleBackColor = true;
            this.equal_to.Click += new System.EventHandler(this.equal_to_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(325, 302);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(123, 56);
            this.three.TabIndex = 13;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(479, 302);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(126, 56);
            this.sub.TabIndex = 14;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(479, 241);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(126, 55);
            this.mul.TabIndex = 15;
            this.mul.Text = "x";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(170, 241);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(122, 55);
            this.five.TabIndex = 16;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(21, 241);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(117, 55);
            this.four.TabIndex = 17;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(21, 302);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(117, 56);
            this.one.TabIndex = 18;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(170, 302);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(122, 56);
            this.two.TabIndex = 19;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_minus.Location = new System.Drawing.Point(21, 364);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(117, 58);
            this.plus_minus.TabIndex = 20;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = true;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // opn_crly_brac
            // 
            this.opn_crly_brac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opn_crly_brac.Location = new System.Drawing.Point(325, 119);
            this.opn_crly_brac.Name = "opn_crly_brac";
            this.opn_crly_brac.Size = new System.Drawing.Size(123, 55);
            this.opn_crly_brac.TabIndex = 21;
            this.opn_crly_brac.Text = "(";
            this.opn_crly_brac.UseVisualStyleBackColor = true;
            this.opn_crly_brac.Click += new System.EventHandler(this.opn_crly_brac_Click);
            // 
            // Delete_All
            // 
            this.Delete_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_All.Location = new System.Drawing.Point(634, 119);
            this.Delete_All.Name = "Delete_All";
            this.Delete_All.Size = new System.Drawing.Size(136, 55);
            this.Delete_All.TabIndex = 22;
            this.Delete_All.Text = "AC";
            this.Delete_All.UseVisualStyleBackColor = true;
            this.Delete_All.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(479, 180);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(126, 55);
            this.div.TabIndex = 23;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clos_crly_brac
            // 
            this.clos_crly_brac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clos_crly_brac.Location = new System.Drawing.Point(479, 119);
            this.clos_crly_brac.Name = "clos_crly_brac";
            this.clos_crly_brac.Size = new System.Drawing.Size(126, 55);
            this.clos_crly_brac.TabIndex = 24;
            this.clos_crly_brac.Text = ")";
            this.clos_crly_brac.UseVisualStyleBackColor = true;
            this.clos_crly_brac.Click += new System.EventHandler(this.clos_crly_brac_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(325, 241);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(123, 55);
            this.six.TabIndex = 25;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.six);
            this.Controls.Add(this.clos_crly_brac);
            this.Controls.Add(this.div);
            this.Controls.Add(this.Delete_All);
            this.Controls.Add(this.opn_crly_brac);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.three);
            this.Controls.Add(this.equal_to);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.full_stp);
            this.Controls.Add(this.right_shft);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.left_shft);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button left_shft;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button right_shft;
        private System.Windows.Forms.Button full_stp;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button equal_to;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button opn_crly_brac;
        private System.Windows.Forms.Button Delete_All;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clos_crly_brac;
        private System.Windows.Forms.Button six;
    }
}

