using System;

namespace BelajarLogicCs
{
	class Program
	{
		static void Main(string[] args)
		{

			//Uncomment one of these below:

			//TwoSumMethod();
			IsPolindromeMethod();

		}

		#region Two Sum
		private static void TwoSumMethod()
		{
			//Two Sums
			int[] nums = new int[5];
			Console.WriteLine("Masukkan Array:");
			for (int i = 0; i < nums.Length; i++)
			{
				nums[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("=================================");
			Console.WriteLine("Target:");
			int target = int.Parse(Console.ReadLine());
			Console.WriteLine("=================================");
			int[] result = new int[2];
			result = TwoSum(nums, target);

			Console.WriteLine("Hasil:");
			Console.WriteLine(result[0]);
			Console.WriteLine(result[1]);
			Console.WriteLine("=================================");
		}

		public static int[] TwoSum(int[] nums, int target)
		{
			int[] result = new int[2];
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[j] + nums[i] == target)
					{
						result[0] = i;
						result[1] = j;
						return result;

					}
				}
			}
			return null;

		}

		#endregion

		#region is Polindrome?

		public static void IsPolindromeMethod()
		{
			int input = int.Parse(Console.ReadLine());
			Console.WriteLine(IsPalindrome(input));
		}
		public static bool IsPalindrome(int x)
		{

			string reversed = "";
			string str = x.ToString();
			int strLength = str.Length - 1;

			while (strLength >= 0)
			{
				reversed += str[strLength];
				strLength--;
			}

			if(str == reversed)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion

	}

}

