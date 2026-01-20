class YoungPhysicist
{
	private static readonly string[] outputs = {"NO", "YES"};
	public static string Solve(List<long[]>	n)
	{
		if (n == null || n.Count == 0)
			return outputs[0];

		long	x = 0, y = 0, z = 0;
		for (int line = 1; line < n.Count; line++)
		{
			x += n[line][0];
			y += n[line][1];
			z += n[line][2];
		}

		int key = (x == 0 && y == 0 && z == 0) ? 1 : 0;

		return outputs[key];
	}
}

class Program
{
	static void Main()
	{
		List<long[]>	n = new();

		string?	line;
		while ((line = System.Console.ReadLine()) != null)
		{
			string[]	input = line.Split(' ');
			long[]	nums = Array.ConvertAll(input, long.Parse);
			n.Add(nums);
		}

		System.Console.WriteLine(YoungPhysicist.Solve(n));
	}
}
