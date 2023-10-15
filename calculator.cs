namespace cs1a;

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Calculator
{
    private static readonly HashSet<string> binaryOperators = new HashSet<string> { "+", "-", "*", "/", "^", "%", "C", "P" };
    private static readonly HashSet<string> unaryOperators = new HashSet<string> { "log", "ln", "sin", "cos", "tan", "sqrt", "cbrt", "asin", "acos", "atan", "hsin","hcos", "htan","abs", "neg", "pi", "!"};

    public double Evaluate(string expression)
    {
        List<string> tokens = Tokenize(expression);
        List<string> rpn = ConvertToRPN(tokens);
        Stack<double> nums = new Stack<double>();

        foreach (string token in rpn){
            if (!unaryOperators.Contains(token) && !binaryOperators.Contains(token)){
                nums.Push(double.Parse(token));
            }
            else if (binaryOperators.Contains(token)){
                double val2 = nums.Pop();
                double val1 = nums.Pop();
                nums.Push(PerformOperationBinary(token, val1, val2)); 
            }
            else if (unaryOperators.Contains(token)){
                double val = nums.Pop();
                nums.Push(PerformOperationUnary(token, val)); 
            }
        }

        if (nums.Count == 1){
            return nums.Pop();
        }
        else{
            throw new ArgumentException("Invalid expression");
        }
    }

    public double PerformOperationBinary(string op, double val1, double val2)
    {
        switch (op)
        {
            case "+":
                return val1 + val2;
            case "-":
                return val1 - val2;
            case "*":
                return val1 * val2;
            case "/":
                return val1 / val2;
            case "^":
                return Math.Pow(val1, val2);
            case "%":
                return val1 % val2;
			case "C":
				double combinations = factorial(val1)/(factorial(val2) * factorial(val1 - val2));
				return (combinations >= 1)? combinations: 0;
			case "P":
				return factorial(val1)/factorial(val1 - val2);
				
            default:
                return 0;
        }
    }

    public double PerformOperationUnary(string op, double val)
    {
        switch (op)
        {
            case "sin":
                return Math.Sin(val);
            case "cos":
                return Math.Cos(val);
            case "tan":
                return Math.Tan(val);
            case "log":
                return Math.Log(val);
            case "ln":
                return Math.Log10(val);
            case "asin":
                return Math.Asin(val);
            case "acos":
                return Math.Acos(val);
            case "atan":
                return Math.Atan(val);
            case "hsin":
                return Math.Sinh(val);
            case "hcos":
                return Math.Cosh(val);
            case "htan":
                return Math.Tanh(val);
            case "sqrt":
                return Math.Sqrt(val);
            case "cbrt":
                return Math.Cbrt(val);
            case "abs":
                return Math.Abs(val);
			case "neg":
				return val * -1; 
			case "!":
				return factorial(val);
            default:
                return 0;
        }
    }

    public List<string> Tokenize(string expression)
    {
        List<string> tokens = new List<string>();
        string pattern = @"(\d+(\.\d*)?)|(\b(log|ln|sin|cos|tan|sqrt|cbrt|asin|acos|atan|hsin|hcos|htan|abs|neg|pi)\b)|([+\-*/^%CP()])|(-\d+(\.\d*)?)|(\()|(\))";

        MatchCollection matches = Regex.Matches(expression, pattern);

        foreach (Match match in matches){
            tokens.Add(match.Value);
        }

        return tokens;
    }

    public List<string> ConvertToRPN(List<string> tokens){
        List<string> rpn = new List<string>();
        Stack<string> operatorStack = new Stack<string>();
		int currentIndex = 0;
        foreach (string token in tokens){
            if (double.TryParse(token, out _) || token == "pi"){
				if(token == "pi"){
					rpn.Add("3.14159265358979");
				}else {
					rpn.Add(token);
				}
            }
			else if(token == "-")
			{
				if(currentIndex == 0){
					operatorStack.Push("neg");
				} else {
					if(binaryOperators.Contains(tokens[currentIndex - 1]) || unaryOperators.Contains(tokens[currentIndex - 1]) ){
						operatorStack.Push("neg");
					}else if(double.TryParse(tokens[currentIndex - 1], out _)){
						operatorStack.Push("-");
					}else if(tokens[currentIndex - 1] == ")" ){
						operatorStack.Push("-");
					}
				}
				
			}
            else if ((binaryOperators.Contains(token) || unaryOperators.Contains(token)) && token != "-")
            {
                while (operatorStack.Count > 0 && precedence(token) <= precedence(operatorStack.Peek()))
                {
                    rpn.Add(operatorStack.Pop());
                }
                operatorStack.Push(token);
            }
            else if (token == "("){
                operatorStack.Push(token);
            }
            else if (token == ")"){
                while (operatorStack.Count > 0 && operatorStack.Peek() != "(")
                {
                    rpn.Add(operatorStack.Pop());
                }
                if (operatorStack.Count > 0 && operatorStack.Peek() == "(")
                {
                    operatorStack.Pop();
                }
                else{
                    throw new ArgumentException("Mismatched parentheses");
                }
            }
			currentIndex++;
        }
        while (operatorStack.Count > 0)
        {
            rpn.Add(operatorStack.Pop());
        }

        return rpn;
    }
	public double factorial(double n){
		if(n == 2) return 2;
		
		return n * factorial(n-1);
	}
    public int precedence(string op)
    {
        switch (op)
        {
            case "+":
            case "-":
                return 1;
            case "*":
            case "/":
			case "abs":
			
                return 2;
            case "sin":
            case "cos":
            case "tan":
            case "log":
            case "ln":
        	case "asin":
    		case "acos":
    		case "atan":
    		case "hsin":
    		case "hcos":
    		case "htan":
			case "neg":
			case "C":
			case "P":
                return 3;
            case "^":
            case "sqrt":
            case "cbrt":
                return 4;
            default:
                return 0;
        }
    }
}
public class Initialize{
	public void initializeCalculator(){
		int consoleWidth = Console.WindowWidth;
		string line = new string('=', consoleWidth);
		Calculator calculator = new Calculator();
        Console.Write("\tWrite Expression: ");
        string expression = Console.ReadLine();
        try
        {
            double result = calculator.Evaluate(expression);
            Console.WriteLine("\tResult: " + result + "\n\n");
			Console.WriteLine(line);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("\tError: " + ex.Message);
			Console.WriteLine(line);
        }


	}
	public void showOptions(){
		int consoleWidth = Console.WindowWidth;
		string line = new string('=', consoleWidth);
		Console.WriteLine(line);
		Console.WriteLine("\n\tSum:'val 1 + val2'. ex: 4 + 2\n");
		Console.WriteLine("\tDifference:'val1 - val2'. ex: 4 - 2\n");
		Console.WriteLine("\tMultiplication:'val1 * val2' ex: 4 * 2\n");
		Console.WriteLine("\tDivision:val1 / val2ex. 4 /2\n");
		Console.WriteLine("\tModulo: %, same format for Combinations(C), Permutations (P), and Exponantiation(^). Ex 4C2 * 4P2 % 10 ^ 0\n");
		Console.WriteLine("\tFor inputting negative numbers use 'neg()'.ex: neg(1) // outputs -1\n");
		Console.WriteLine("\tSine: sin 'val'. ex: sin(10). Same format for: cos, tan, asin, acos, atan, Square Root (sqrt),Cube Root (cbrt), absolute value (abs)\n");
		Console.WriteLine("\tSinh: hsin 'val'. ex: hsin(10). Same format for cosh (hcos) , tanh (htan)\n");
		Console.WriteLine("\tFor using PI, just type pi directly. ex: pi * 3\n\n");
		Console.WriteLine(line);
	}
	public void exit(){
		int consoleWidth = Console.WindowWidth;
		string line = new string('=', consoleWidth);
		Console.WriteLine("\tThank you for using!\n");
		Console.WriteLine("\n" + line);
		Environment.Exit(0);
	}
	public void choices(){
		int consoleWidth = Console.WindowWidth;
		string line = new string('=', consoleWidth);

		Console.WriteLine("\n\t[A] Calculate");
		Console.WriteLine("\t[B] Show Commands");
		Console.WriteLine("\t[C] Exit");
		
		Console.Write("\n\tEnter Choice: ");

	}
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
		Initialize initializeCalc = new Initialize();
		int consoleWidth = Console.WindowWidth;
		string line = new string('=', consoleWidth);
		bool start = true;
		Console.WriteLine(line + "\n\n");
		while(start){
			initializeCalc.choices();
			char choice = char.Parse(Console.ReadLine());
			switch(char.ToUpper(choice)){
				case 'A':
					initializeCalc.initializeCalculator();
					Console.WriteLine("\n\n" + line + "\n");
					break;
				case 'B':
					initializeCalc.showOptions();
					break;
				case 'C':
					initializeCalc.exit();
					break;
				default:
					Console.WriteLine("Invalid Option.");
					break;
			}
		}
    }
}