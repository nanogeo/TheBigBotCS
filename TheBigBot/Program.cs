using SC2APIProtocol;
using Sharky;
using Sharky.DefaultBot;
using System;

namespace TheBigBot
{
	class Program
	{
		static void Main(string[] args)
		{
			var gameConnection = new GameConnection();
			var defaultSharkyBot = new DefaultSharkyBot(gameConnection);

			var theBigBot = defaultSharkyBot.CreateBot(defaultSharkyBot.Managers, defaultSharkyBot.DebugService);

			var myRace = Race.Protoss;

			if (args.Length == 0)
			{
				gameConnection.RunSinglePlayer(theBigBot, @"GresvanAIE.SC2Map", myRace, Race.Terran, Difficulty.Easy, AIBuild.RandomBuild).Wait();
			}
			else
			{
				gameConnection.RunLadder(theBigBot, myRace, args).Wait();
			}
		}
	}
}