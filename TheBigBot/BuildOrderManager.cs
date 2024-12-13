using SC2APIProtocol;
using Sharky;
using TheBigBot.BuildOrders;


namespace TheBigBot
{
    public class BuildOrderManager : TheBigBotManager
	{
		public override bool SkipFrame { get => false; }
		public BuildOrder build_order;

		public BuildOrderManager(Mediator mediator, BuildOrder build_order) : base(mediator) 
		{
			this.build_order = build_order;
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

#region conditions
		public bool TimePassed(object arg)
		{
			double time = (double)arg;
			return time > 10;
		}
		public bool HasBuilding(object arg)
		{
			UnitTypes unit_type = (UnitTypes)arg;
			return false;
		}

		#endregion

#region actions
		public bool BuildFirstPylon(object ignored)
		{
			return false;
		}
		public bool BuildBuilding(object arg)
		{
			UnitTypes unit_type = (UnitTypes)arg;
			return false;
		}
		public bool ChronoBuilding(object arg)
		{
			UnitTypes unit_type = (UnitTypes)arg;
			return false;
		}
		public bool Scout(object ignored)
		{
			return false;
		}
		public bool ImmediatlySemiSaturateGasses(object ignored)
		{
			return false;
		}
		public bool ContinueMakingWorkers(object ignored)
		{
			return false;
		}
		public bool TrainUnit(object arg)
		{
			UnitTypes unit_type = (UnitTypes)arg;
			return false;
		}
		public bool TrainUnits(object arg)
		{
			Tuple<UnitTypes, int> unit_type = (Tuple<UnitTypes, int>)arg;
			return false;
		}
		public bool ResearchWarpgate(object ignored)
		{
			return false;
		}
		public bool SafeRallyPoint(object arg)
		{
			UnitTypes unit_type = (UnitTypes)arg;
			return false;
		}
		public bool RemoveScoutToProxy(object arg)
		{
			Tuple<UnitTypes, int> unit_type = (Tuple<UnitTypes, int>)arg;
			return false;
		}
		public bool SendAdeptHarassProtoss(object ignored)
		{
			return false;
		}
		public bool SendAllInAttack(object ignored)
		{
			return false;
		}
		public bool ContinueBuildingPylons(object ignored)
		{
			return false;
		}
		public bool WarpInAtProxy(object ignored)
		{
			return false;
		}

		#endregion
	}
}
