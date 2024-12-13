using Sharky.Managers;


namespace TheBigBot
{

	public class TheBigBotManager : SharkyManager
	{
		Mediator mediator;
		public TheBigBotManager(Mediator mediator) 
		{
			this.mediator = mediator;
		}
	}
}
