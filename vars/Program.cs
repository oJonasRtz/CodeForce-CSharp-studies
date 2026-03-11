using System;
using System.Collections;

class Program
{
	static void Print(object[] data)
	{
		foreach (object item in data)
		{
			if (item == null)
				continue;
			if (item is not IEnumerable collection || item is string) {
				Console.WriteLine($"{item} (Type: {item.GetType()})");
				continue;
			}

			Console.WriteLine($"Collection (Type: {item.GetType()}):");
			foreach (var element in collection)
				Console.WriteLine($"  - {element}");
		}
	}
	static void Main()
	{
		object[] myVars =
		[
			42,
			"42",
			3.14,
			true,
			new List<int> { 1, 2, 3 },
			new Dictionary<string, int> { {"one", 1}, {"two", 2} },
			(42, "forty-two"), //tuple
			new HashSet<int> { 1, 2, 3 },
			new int[] { 1, 2, 3 },
		];
		
		Print(myVars);
	}
}
