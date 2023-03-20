// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.Metrics;
using System.Text.Json;

Console.WriteLine("Hello, World!");

//პირველი ამოცანა
bool IsPalindrome(string text)
{
	int length = text.Length;
	for (int i = 0; i < length / 2; i++)
	{
		if (text[i] != text[length - 1 - i])
		{
			return false;
		}
	}
	return true;
}

string input = "racecar";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome);

//მეორე ამოცანა

int MinSplit(int amount)
{
	int[] coins = { 50, 20, 10, 5, 1 }; 
	int count = 0;

	foreach (int coin in coins)
	{
		count += amount / coin;
		amount %= coin;
	}

	return count;
}

int amount = 76;
int coinCount = MinSplit(amount);
Console.WriteLine(coinCount);

//მესამე ამოცანა

int NotContains(int[] array)
{
	HashSet<int> set = new HashSet<int>(array);
	int i = 1;
	while (set.Contains(i))
	{
		i++;
	}
	return i;
}

int[] array = { 1, 2, 3, 5 };
int result = NotContains(array);
Console.WriteLine(result);

//მეოთხე ამოცანა

bool IsProperly(string sequence)
{
	int count = 0;
	foreach (char c in sequence)
	{
		if (c == '(')
		{
			count++;
		}
		else if (c == ')')
		{
			count--;
			if (count < 0)
			{
				return false;
			}
		}
	}
	return count == 0;
}


string sequence = "((()()))";
bool isProperlyPlaced = IsProperly(sequence);
Console.WriteLine(isProperlyPlaced);

//მეხუთე ამოცანა

int CountVariants(int stairCount)
{
	if (stairCount <= 0)
	{
		return 0;
	}
	else if (stairCount == 1)
	{
		return 1;
	}
	else if (stairCount == 2)
	{
		return 2;
	}
	else
	{
		int[] variants = new int[stairCount];
		variants[0] = 1;
		variants[1] = 2;
		for (int i = 2; i < stairCount; i++)
		{
			variants[i] = variants[i - 1] + variants[i - 2];
		}
		return variants[stairCount - 1];
	}
}

int stairCount = 5;
int variantCount = CountVariants(stairCount);
Console.WriteLine(variantCount);







