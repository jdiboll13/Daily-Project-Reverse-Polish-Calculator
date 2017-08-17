using System;
using System.Collections.Generic;

public class ReversePolishCalc {

    // You'll need a variable here to keep track of the top of the stack
    var topOfStack;

    // The array of the input string split up
    private String[] tokens;

    // The stack
    private String[] stack;

    public double Calculate(String input) {

        // 1. Use the String split method to split the string into tokens at the commas
        tokens = input.Split(',');
        Console.WriteLine(tokens);

        // 2. Allocate a stack as big as the number of tokens
        var myStack = new Stack<string>();
        stack = new string[tokens.Length];

        // 3. write the algorithm
        for(int i = 0; i < tokens.Length; ++i) 
        {
            // calls to push() and pop() and do the math here

        }

        // 4. return the result
        return pop();
    }

    private void Push(String number) {
        // push on the stack
        Stack.Push(number);
    }

    private void Push(double d) {
        // change the double to a string and then push it on the stack
    }

    private double Pop() {
        // remove the string from the top of the stack and convert it to a double and return it
    }
}
