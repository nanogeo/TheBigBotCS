using SC2APIProtocol;
using Sharky.Managers;


namespace TheBigBot
{
	public class BuildOrderManager : TheBigBotManager
	{
		public override bool SkipFrame { get => false; }

		public BuildOrderManager(Mediator mediator) : base(mediator) 
		{
			
		}

		public override void OnStart(ResponseGameInfo gameInfo, ResponseData data, ResponsePing pingResponse, ResponseObservation observation, uint playerId, string opponentId)
		{

		}

		public override IEnumerable<SC2APIProtocol.Action> OnFrame(ResponseObservation observation)
		{
			List<SC2APIProtocol.Action> actions = new List<SC2APIProtocol.Action>();
			return actions;
		}

		public override void OnEnd(ResponseObservation observation, Result result)
		{
			if (observation != null)
			{
				System.Console.WriteLine($"{observation.Observation.GameLoop} {GetType().Name} {TotalFrameTime:F2}ms, average: {(TotalFrameTime / observation.Observation.GameLoop):F2}ms");
			}
			else
			{
				System.Console.WriteLine("OnEnd Observation null");
			}
		}



	}
}
