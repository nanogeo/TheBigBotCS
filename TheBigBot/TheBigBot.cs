using SC2APIProtocol;
using Sharky;

namespace TheBigBot
{
	public class TheBigBot : ISharkyBot
	{
		public IEnumerable<SC2APIProtocol.Action> OnFrame(ResponseObservation observation)
		{
			List<SC2APIProtocol.Action> actions = new List<SC2APIProtocol.Action>();
			return actions;
		}
		public void OnEnd(ResponseObservation observation, Result result)
		{

		}
		public void OnStart(ResponseGameInfo gameInfo, ResponseData data, ResponsePing pingResponse, ResponseObservation observation, uint playerId, String opponentId)
		{

		}
	}
}
