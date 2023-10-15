namespace cs1a;
using System.Drawing;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public partial class Form1 : Form
{
	public InputBox inputExpressionBox;
	public OutputBox outputResultBox;
	private leftButtons n0, n1, n2, n3, n4, n5, n6, n7, n8, n9, b3, b4;
	private specialLeftButtons equal, b1, b2;
	private rightButtons u1, u2, u3, u4, u5, u6, u7, u8, u9, u10, u11, u12, u13, u14, u15, u16, b5, b6, b7, b8, pi, bspace, clear;


	private HashSet<string> special = new HashSet<string> { "log()", "ln()", "sin()", "cos()", "tan()", "sqrt()", "cbrt()", "asin()", "acos()", "atan()", "hsin()","hcos()", "htan()","abs()", "neg()" };
	
    public Form1()
    {
        InitializeComponent();
    }
	
	private void InputBox_Click(object sender, EventArgs e)
	{
		if (inputExpressionBox.Text == "Input Expression here: ")
		{
			inputExpressionBox.Text = "";
			inputExpressionBox.ForeColor = SystemColors.ControlText;
			inputExpressionBox.ReadOnly = false;
		}
	}
	private void Button_Click(object sender, EventArgs e)
    {
        if (inputExpressionBox.Text == "Input Expression here: ")
        {
            inputExpressionBox.Text = "";
            inputExpressionBox.ForeColor = SystemColors.ControlText;
            inputExpressionBox.ReadOnly = false;
        }
		if (sender is Button button)
		{
			if(button.Text == "="){
				outputResultBox.Text = "";
				outputResultBox.SelectionStart = 0;
				outputResultBox.Text = inputExpressionBox.Text;
			}
			else if(button.Text == "CLEAR"){
				inputExpressionBox.Text = "";
			} 
			else if(button.Text == "bspace"){
				if(inputExpressionBox.SelectionStart > 0){
					int newCaretPos = inputExpressionBox.SelectionStart - 1;
					inputExpressionBox.Text = inputExpressionBox.Text.Remove(newCaretPos, 1);
					inputExpressionBox.SelectionStart = newCaretPos;
					inputExpressionBox.Focus();
				}
			}
			else if(special.Contains(button.Text))
			{
				int currentPos = inputExpressionBox.SelectionStart;
				inputExpressionBox.Text = inputExpressionBox.Text.Insert(currentPos, button.Text);
				inputExpressionBox.SelectionStart = currentPos + button.Text.Length - 1;
				inputExpressionBox.Focus();
			}
			else {
				int nextPos = inputExpressionBox.SelectionStart + 1;
				inputExpressionBox.Text = inputExpressionBox.Text.Insert(inputExpressionBox.SelectionStart, button.Text);
				inputExpressionBox.SelectionStart = nextPos;
			}
		}

    }
	
}

