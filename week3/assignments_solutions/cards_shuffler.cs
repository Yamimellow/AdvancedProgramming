using System;

namespace shuffle_cards
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			string[] cards = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10" , "J","Q","K"};
			string[] suits = {"S" , "H" , "D" , "C" };
			
			string[] playing_cards = new string[52];
			
			
			//Initialize the cards [ in order first ]
			for (int i = 0; i < 4 ; i ++)
			{
				for (int j = 0 ; j < 13; j++)
				{
					playing_cards[i*13 + j] = cards[j] + " " + suits[i];
					//Console.WriteLine(playing_cards[i*13 + j]);
				}
			}
			
			Random r = new Random();
			//This idea by Nour which was better than mine.
			//Shuffle The Cards.
			
			for (int i = 51;i>0;i--)
			{
				int p = r.Next(0,i+1);
				string temp = playing_cards[i];
				playing_cards[i] = playing_cards[p];
				playing_cards[p] = temp;
			}
			
			for (int i = 0; i < 4 ; i ++)
			{
				Console.WriteLine("Player {0}",i+1);
				for (int j = 0 ; j < 13; j++)
				{
					
					Console.Write(playing_cards[i*13 + j] + ",");
				}
				Console.WriteLine("");
				Console.WriteLine("----");
			}
			
			
		}
	}
}
