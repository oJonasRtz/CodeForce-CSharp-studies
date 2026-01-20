static class TheatreSquares
{
	public static ulong Solve(ulong n, ulong m, ulong a)
	{
		ulong x = n / a + (n % a == 0 ? 0UL : 1UL);
		ulong y = m / a + (m % a == 0 ? 0UL : 1UL);

		return x * y;
	}
}

static class Program {
	static void Main()
	{
		string[] inputs = System.Console.ReadLine().Split(' ');
		ulong n = ulong.Parse(inputs[0]);
		ulong m = ulong.Parse(inputs[1]);
		ulong a = ulong.Parse(inputs[2]);

		ulong res = TheatreSquares.Solve(n, m, a);

		System.Console.WriteLine(res);
	}
}
