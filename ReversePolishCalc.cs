using System;
using System.Collections.Generic;

public class ReversePolishCalc {

    // You'll need a variable here to keep track of the top of the stack

    // The array of the input string split up
    private String[] tokens;

    // The stack
    private Stack<string> stack = new Stack<string>();

    public double Calculate(String input) {

        // 1. Use the String split method to split the string into tokens at the commas
        tokens = input.Split(',');
        Console.WriteLine(tokens);

        

        // 3. write the algorithm
        for(int i = 0; i < tokens.Length; ++i) 
        {
            if (tokens[i] == "+")
            {
                var a = double.Parse(stack.Pop());
                var b = double.Parse(stack.Pop());
                var result = b + a;
                var realResult = result.ToString();
                stack.Push(realResult);
            }
            else if (tokens[i] == "-")
            {
                var a = double.Parse(stack.Pop());
                var b = double.Parse(stack.Pop());
                var result = b - a;
                var realResult = result.ToString();
                stack.Push(realResult);
            }
            else if (tokens[i] == "*")
            {
                var a = double.Parse(stack.Pop());
                var b = double.Parse(stack.Pop());
                var result = b * a;
                var realResult = result.ToString();
                stack.Push(realResult);
            }
            else if (tokens[i] == "/")
            {
                var a = double.Parse(stack.Pop());
                var b = double.Parse(stack.Pop());
                var result = b / a;
                var realResult = result.ToString();
                stack.Push(realResult);
            }
            else
            {
                stack.Push(tokens[i]);
            }
        }
        var finalResult = stack.Pop();

        return double.Parse(finalResult);
    }
}
