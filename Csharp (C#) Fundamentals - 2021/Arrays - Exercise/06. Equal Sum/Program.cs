﻿using System;
using System.Linq;

public class Example
{
	public static void Main()
	{
		int[] array = Console.ReadLine()
			.Split()
			.Select(int.Parse)
			.ToArray();

		for (int i = 0; i < array.Length; i++)
		{
			int leftSum = 0;
			int rightSum = 0;
			for (int j = 0; j < i; j++)
			{
				leftSum += array[j];
			}
			for (int k = i + 1; k < array.Length; k++)
			{
				rightSum += array[k];
			}
			if (leftSum == rightSum)
			{
				Console.WriteLine(i);
				return;
			}
		}
		Console.WriteLine("no");

	}
}

