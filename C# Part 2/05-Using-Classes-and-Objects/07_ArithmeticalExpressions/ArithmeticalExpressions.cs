using System;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

class ArithmeticalExpressions
{
    /*	Write a program that calculates the value of given arithmetical expression.
    	The expression can contain the following elements only: 
            o	Real numbers, e.g. 5, 18.33, 3.14159, 12.6 
            o	Arithmetic operators: +, -, *, / (standard priorities)
            o	Mathematical functions: ln(x), sqrt(x), pow(x,y) 
            o	Brackets (for changing the default priorities): (, ).*/

    static void Main()
    {
        Console.Write("Write an expression: ");
        string str = Console.ReadLine();

        Console.WriteLine("Result = {0:0.###}", Evaluate(str));
    }

    static object Evaluate(string str)
    {
        CSharpCodeProvider compiler = new CSharpCodeProvider();
        CompilerParameters options = new CompilerParameters();
        options.ReferencedAssemblies.Add("system.dll");
        options.GenerateInMemory = true;

        string source = PrepareSource(str);
        var assembly = compiler.CompileAssemblyFromSource(options, source).CompiledAssembly;
        var evaluator = assembly.CreateInstance("Evaluator");

        return evaluator.GetType().GetMethod("Evaluate").Invoke(evaluator, null);
    }

    static string PrepareSource(string str)
    {
        str = str.Replace("sqrt", "Math.Sqrt").Replace("ln", "Math.Log").Replace("pow", "Math.Pow");

        return @"
using System;
public class Evaluator
{
public double Evaluate()
{
return expression;
}
}".Replace("expression", str);
    }
}