using System.Drawing;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace cs1a;

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
		
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        int padding = 25;
        this.ClientSize = new Size(1100 + 2 * padding, 400 + 2 * padding);
		
        this.inputExpressionBox = new InputBox();
        this.inputExpressionBox.Location = new System.Drawing.Point(50, 50);
		this.Controls.Add(inputExpressionBox);
		this.inputExpressionBox.Click += new System.EventHandler(this.InputBox_Click);

        this.outputResultBox = new OutputBox();
        this.outputResultBox.Location = new Point(50, 100);
		this.outputResultBox.Text = "hahahaahah";
		this.Controls.Add(outputResultBox);
		
		this.n7 = new leftButtons();
		this.n7.Location = new Point(1000 - 380 + 10, 600 - 450);
		this.n7.Text = "7";
		this.Controls.Add(n7);
		this.n7.Click += new System.EventHandler(this.Button_Click);
		
		this.n8 = new leftButtons();
		this.n8.Location = new Point(this.n7.Location.X + 125, this.n7.Location.Y);
		this.n8.Text = "8";
		this.Controls.Add(n8);
		this.n8.Click += new System.EventHandler(this.Button_Click);
		
		this.n9 = new leftButtons();
		this.n9.Location = new Point(this.n8.Location.X + 125, this.n8.Location.Y);
		this.n9.Text = "9";
		this.Controls.Add(n9);
		this.n9.Click += new System.EventHandler(this.Button_Click);
		
		this.b1 = new specialLeftButtons();
		this.b1.Location = new Point(this.n9.Location.X + 125, this.n9.Location.Y);
		this.b1.Text = "+";
		this.Controls.Add(b1);
		this.b1.Click += new System.EventHandler(this.Button_Click);
	
		this.n4 = new leftButtons();
		this.n4.Location = new Point(this.n7.Location.X, this.n7.Location.Y + 50);
		this.n4.Text = "4";
		this.Controls.Add(n4);
		this.n4.Click += new System.EventHandler(this.Button_Click);
		
		this.n5 = new leftButtons();
		this.n5.Location = new Point(this.n8.Location.X, this.n8.Location.Y + 50);
		this.n5.Text = "5";
		this.Controls.Add(n5);
		this.n5.Click += new System.EventHandler(this.Button_Click);
		
		this.n6 = new leftButtons();
		this.n6.Location = new Point(this.n9.Location.X, this.n9.Location.Y + 50);
		this.n6.Text = "6";
		this.Controls.Add(n6);
		this.n6.Click += new System.EventHandler(this.Button_Click);
		
		this.b2 = new specialLeftButtons();
		this.b2.Location = new Point(this.b1.Location.X, this.b1.Location.Y + 50);
		this.b2.Text = "-";
		this.Controls.Add(b2);
		this.b2.Click += new System.EventHandler(this.Button_Click);
		
		this.n1 = new leftButtons();
		this.n1.Location = new Point(this.n4.Location.X, this.n4.Location.Y + 50);
		this.n1.Text = "1";
		this.Controls.Add(n1);
		this.n1.Click += new System.EventHandler(this.Button_Click);

		this.n2 = new leftButtons();
		this.n2.Location = new Point(this.n5.Location.X, this.n5.Location.Y + 50);
		this.n2.Text = "2";
		this.Controls.Add(n2);
		this.n2.Click += new System.EventHandler(this.Button_Click);
		
		this.n3 = new leftButtons();
		this.n3.Location = new Point(this.n6.Location.X, this.n6.Location.Y + 50);
		this.n3.Text = "3";
		this.Controls.Add(n3);
		this.n3.Click += new System.EventHandler(this.Button_Click);
		
		this.n0 = new leftButtons();
		this.n0.Location = new Point(this.n1.Location.X, this.n1.Location.Y + 50);
		this.n0.Text = "0";
		this.Controls.Add(n0);
		this.n0.Click += new System.EventHandler(this.Button_Click);
		
		this.b3 = new leftButtons();
		this.b3.Location = new Point(this.n2.Location.X, this.n2.Location.Y + 50);
		this.b3.Text = "*";
		this.Controls.Add(b3);
		this.b3.Click += new System.EventHandler(this.Button_Click);
		
		this.b4 = new leftButtons();
		this.b4.Location = new Point(this.n3.Location.X, this.n3.Location.Y + 50);
		this.b4.Text = "/";
		this.Controls.Add(b4);
		this.b4.Click += new System.EventHandler(this.Button_Click);
		
		this.equal = new specialLeftButtons();
		this.equal.Location = new Point(this.b2.Location.X, this.b2.Location.Y + 50);
		this.equal.Text = "=";
		this.equal.Size = new System.Drawing.Size(63, 50 * 2);
		this.Controls.Add(equal);
		this.b4.Click += new System.EventHandler(this.Button_Click);
		
		this.u1 = new rightButtons();
		this.u1.Location = new Point(75, this.n7.Location.Y);
		this.u1.Text = "sin()";
		this.Controls.Add(u1);
		this.u1.Click += new System.EventHandler(this.Button_Click);
		
		this.u2 = new rightButtons();
		this.u2.Location = new Point(this.u1.Location.X + 100, this.u1.Location.Y);
		this.u2.Text = "cos()";
		this.Controls.Add(u2);
		this.u2.Click += new System.EventHandler(this.Button_Click);
		
		this.u3 = new rightButtons();
		this.u3.Location = new Point(this.u2.Location.X + 100, this.u1.Location.Y);
		this.u3.Text = "tan()";
		this.Controls.Add(u3);
		this.u3.Click += new System.EventHandler(this.Button_Click);
		
		this.bspace = new rightButtons();
		this.bspace.Location = new Point(this.u3.Location.X + 100, this.u1.Location.Y);
		this.bspace.Text = "bspace";
		this.Controls.Add(bspace);
		this.bspace.Click += new System.EventHandler(this.Button_Click);
		
		this.clear = new rightButtons();
		this.clear.Location = new Point(this.bspace.Location.X + 100, this.u1.Location.Y);
		this.clear.Text = "CLEAR";
		this.Controls.Add(clear);
		this.clear.Click += new System.EventHandler(this.Button_Click);
		
		this.u4 = new rightButtons();
		this.u4.Location = new Point(this.u1.Location.X, this.u1.Location.Y + 50);
		this.u4.Text = "asin()";
		this.Controls.Add(u4);
		this.u4.Click += new System.EventHandler(this.Button_Click);
		
		this.u5 = new rightButtons();
		this.u5.Location = new Point(this.u2.Location.X, this.u2.Location.Y + 50);
		this.u5.Text = "acos()";
		this.Controls.Add(u5);
		this.u5.Click += new System.EventHandler(this.Button_Click);
		
		this.u6 = new rightButtons();
		this.u6.Location = new Point(this.u3.Location.X, this.u3.Location.Y + 50);
		this.u6.Text = "atan()";
		this.Controls.Add(u6);
		this.u6.Click += new System.EventHandler(this.Button_Click);
		
		this.u16 = new rightButtons();
		this.u16.Location = new Point(this.bspace.Location.X, this.bspace.Location.Y + 50);
		this.u16.Text = "neg()";
		this.Controls.Add(u16);
		this.u16.Click += new System.EventHandler(this.Button_Click);
		
		this.pi = new rightButtons();
		this.pi.Location = new Point(this.clear.Location.X, this.clear.Location.Y + 50);
		this.pi.Text = "pi";
		this.Controls.Add(pi);
		this.pi.Click += new System.EventHandler(this.Button_Click);
		
		this.u7 = new rightButtons();
		this.u7.Location = new Point(this.u4.Location.X, this.u4.Location.Y + 50);
		this.u7.Text = "hsin";
		this.Controls.Add(u7);
		this.u7.Click += new System.EventHandler(this.Button_Click);
		
		this.u8 = new rightButtons();
		this.u8.Location = new Point(this.u5.Location.X, this.u4.Location.Y + 50);
		this.u8.Text = "cosh()";
		this.Controls.Add(u8);
		this.u8.Click += new System.EventHandler(this.Button_Click);
		
		this.u9 = new rightButtons();
		this.u9.Location = new Point(this.u6.Location.X, this.u6.Location.Y+50);
		this.u9.Text = "tanh()";
		this.Controls.Add(u9);
		this.u9.Click += new System.EventHandler(this.Button_Click);
		
		this.b7 = new rightButtons();
		this.b7.Location = new Point(this.u16.Location.X, this.u16.Location.Y + 50);
		this.b7.Text = "C";
		this.Controls.Add(b7);
		this.b7.Click += new System.EventHandler(this.Button_Click);
		
		this.b8 = new rightButtons();
		this.b8.Location = new Point(this.pi.Location.X, this.pi.Location.Y + 50);
		this.b8.Text = "P";
		this.Controls.Add(b8);
		this.b8.Click += new System.EventHandler(this.Button_Click);
		
		this.b5 = new rightButtons();
		this.b5.Location = new Point(this.u7.Location.X, this.u7.Location.Y + 50);
		this.b5.Text = "^";
		this.Controls.Add(b5);
		this.b5.Click += new System.EventHandler(this.Button_Click);
		
		this.b6 = new rightButtons();
		this.b6.Location = new Point(this.u8.Location.X, this.u8.Location.Y + 50);
		this.b6.Text = "%";
		this.Controls.Add(b6);
		this.b6.Click += new System.EventHandler(this.Button_Click);
		
		this.u15 = new rightButtons();
		this.u15.Location = new Point(this.u9.Location.X, this.u9.Location.Y + 50);
		this.u15.Text = "abs()";
		this.Controls.Add(u15);
		this.u15.Click += new System.EventHandler(this.Button_Click);
		
		this.u13 = new rightButtons();
		this.u13.Location = new Point(this.b7.Location.X, this.b7.Location.Y + 50);
		this.u13.Text = "log()";
		this.Controls.Add(u13);
		this.u13.Click += new System.EventHandler(this.Button_Click);
		
		this.u14 = new rightButtons();
		this.u14.Location = new Point(this.b8.Location.X, this.b8.Location.Y + 50);
		this.u14.Text = "ln()";
		this.Controls.Add(u14);
		this.u14.Click += new System.EventHandler(this.Button_Click);
		
		this.u10 = new rightButtons();
		this.u10.Location = new Point(this.b5.Location.X, this.b5.Location.Y + 50);
		this.u10.Text = "!";
		this.Controls.Add(u10);
		this.u10.Click += new EventHandler(this.Button_Click);
		
		this.u11 = new rightButtons();
		this.u11.Location = new Point(this.b6.Location.X, this.b6.Location.Y + 50);
		this.u11.Text = "sqrt()";
		this.Controls.Add(u11);
		this.u11.Click += new EventHandler(this.Button_Click);
		
		this.u12 = new rightButtons();
		this.u12.Location = new Point(this.u15.Location.X, this.u15.Location.Y + 50);
		this.u12.Text = "cbrt()";
		this.Controls.Add(u12);
		this.u12.Click += new EventHandler(this.Button_Click);
		
        this.Text = "Form1";
		this.BackColor = ColorTranslator.FromHtml("#212529");
		this.FormBorderStyle = FormBorderStyle.FixedSingle; 

    }

	public class InputBox : TextBox
	{
		public InputBox()
		{
			this.Size = new System.Drawing.Size(1050, 150);
			this.Text = "Input Expression here: ";
			this.ReadOnly = true;
			this.Font = new System.Drawing.Font("Courier New", 12);
			this.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
			this.BackColor = ColorTranslator.FromHtml("#5a5a5a");
			this.TextChanged += InputBox_TextChanged; 
		}

		private void InputBox_TextChanged(object sender, EventArgs e)
		{
			this.ForeColor = Color.White;
		}
	}


	public class OutputBox : TextBox
	{
		public OutputBox()
		{
			this.Size = new System.Drawing.Size(1050, 150);
			this.Font = new System.Drawing.Font("Courier New", 12);
			this.ReadOnly = false;
			this.ForeColor = ColorTranslator.FromHtml("#d3d3d3");
			this.BackColor = ColorTranslator.FromHtml("#5a5a5a");

		}
	}


    public class leftButtons : Button
    {
        public leftButtons()
        {
            this.Size = new System.Drawing.Size(125, 50);
            this.Font = new System.Drawing.Font("Times New Roman", 10);
			this.BackColor = ColorTranslator.FromHtml("#7c7c7c");
			this.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
    }
	
	public class specialLeftButtons : leftButtons
	{
		public specialLeftButtons()
		{
			this.Size = new System.Drawing.Size(63, 50);
		}
	}
	
	public class rightButtons : Button
	{
		public rightButtons()
		{
			this.Size = new System.Drawing.Size(100, 50);
            this.Font = new System.Drawing.Font("Times New Roman", 10);
			this.BackColor = ColorTranslator.FromHtml("#7c7c7c");
			this.ForeColor = ColorTranslator.FromHtml("#ffffff");

		}
	}

    #endregion
}
