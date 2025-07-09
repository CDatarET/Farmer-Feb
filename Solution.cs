using System;

public class Test
{
    
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int boundary = (int)Math.Sqrt(number);
        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
    
     public static int NextPrime(int n)
    {
        int candidate = n + 1;
        while (!IsPrime(candidate))
        {
            candidate++;
        }
        return candidate;
    }

	public static void Main()
	{
	    
	    
		int cases = int.Parse(Console.ReadLine());
		
		for(int c = 0; c < cases; c++){
		    string[] inputs = Console.ReadLine().Split();
		    int x = int.Parse(inputs[0]);
		    int y = int.Parse(inputs[1]);
		    
		    int z = x + y;
		    
		    int add = NextPrime(z);
	    
		    Console.WriteLine(add - z);
		}
	}
}
