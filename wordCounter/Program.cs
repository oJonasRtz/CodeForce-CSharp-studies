using System;
using System.Collections.Generic;
using System.IO;

static class Counter
{
	private static void Print(Dictionary<string, int> d)
	{
		foreach (var item in d)
			Console.WriteLine($"{item.Key} -> {item.Value}");	
	}

	public static void Words(string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			Console.WriteLine("No text provided.");
			return;
		}

		var myDict = new Dictionary<string, int>();
		string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

		foreach (string word in words)
			myDict[word] = myDict.GetValueOrDefault(word, 0) + 1;

		Print(myDict);
	}
}

class Program
{
	static void Main()
	{
		var startMemory = GC.GetTotalMemory(true);
		string text = File.ReadAllText("text.txt");

		Counter.Words(text);
		var endMemory = GC.GetTotalMemory(true); 
		Console.WriteLine($"Memory used: {(endMemory - startMemory) / (1024 * 1024)} MB");
	}
}
