using SC2APIProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharky;
using Sharky.Builds.Protoss;

namespace TheBigBot.BuildOrders
{
	public class ThreeGateRobo :BuildOrder
	{
		public ThreeGateRobo(BuildOrderManager manager) 
		{
			steps = new List<BuildOrderStep>();
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	8.5,									(Func<object, bool>)manager.BuildFirstPylon,				0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	27,										(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_GATEWAY));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	33,										(Func<object, bool>)manager.ChronoBuilding,					UnitTypes.PROTOSS_NEXUS));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	34,										(Func<object, bool>)manager.Scout,							0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	41,										(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_ASSIMILATOR));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	41,										(Func<object, bool>)manager.ImmediatlySemiSaturateGasses,	0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	41,										(Func<object, bool>)manager.ContinueMakingWorkers,			0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	55,										(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_ASSIMILATOR));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	63,										(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_GATEWAY));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	73,										(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_CYBERNETICSCORE));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	88,										(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_PYLON));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.HasBuilding,	UnitTypes.PROTOSS_CYBERNETICSCORE,		(Func<object, bool>)manager.TrainUnits,						new Tuple<UnitTypes, int>(UnitTypes.PROTOSS_ADEPT, 2)));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.HasBuilding,	UnitTypes.PROTOSS_CYBERNETICSCORE,		(Func<object, bool>)manager.ResearchWarpgate,				0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.HasBuilding,	UnitTypes.PROTOSS_CYBERNETICSCORE,		(Func<object, bool>)manager.ChronoBuilding,					UnitTypes.PROTOSS_CYBERNETICSCORE));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.HasBuilding,	UnitTypes.PROTOSS_CYBERNETICSCORE,		(Func<object, bool>)manager.SafeRallyPoint,					UnitTypes.PROTOSS_GATEWAY));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	126,									(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_ROBOTICSFACILITY));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	127,									(Func<object, bool>)manager.RemoveScoutToProxy,				new Tuple<UnitTypes, int>(UnitTypes.PROTOSS_GATEWAY, 1)));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	145,									(Func<object, bool>)manager.TrainUnits,						new Tuple<UnitTypes, int>(UnitTypes.PROTOSS_STALKER, 2)));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	145,									(Func<object, bool>)manager.SendAdeptHarassProtoss,			0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	175,									(Func<object, bool>)manager.SendAllInAttack,				0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	175,									(Func<object, bool>)manager.TrainUnits,						new Tuple<UnitTypes, int > (UnitTypes.PROTOSS_STALKER, 2)));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	175,									(Func<object, bool>)manager.TrainUnit,						UnitTypes.PROTOSS_WARPPRISM));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	175,									(Func<object, bool>)manager.ChronoBuilding,					UnitTypes.PROTOSS_ROBOTICSFACILITY));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	186,									(Func<object, bool>)manager.BuildBuilding,					UnitTypes.PROTOSS_PYLON));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	210,									(Func<object, bool>)manager.ContinueBuildingPylons,			0));
			steps.Add(new BuildOrderStep((Func<object, bool>)manager.TimePassed,	210,									(Func<object, bool>)manager.WarpInAtProxy,					0));
		}
	}
}

