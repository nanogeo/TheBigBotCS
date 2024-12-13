using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigBot.BuildOrders
{
    public struct BuildOrderStep
    {
        Func<object, bool> condition;
        Func<object, bool> action;
        object condition_arg;
        object action_arg;
        public BuildOrderStep(Func<object, bool> condition, object condition_arg, Func<object, bool> action, object action_arg)
        {
            this.condition = condition;
            this.action = action;
            this.condition_arg = condition_arg;
            this.action_arg = action_arg;
        }
    }

    public abstract class BuildOrder
    {
        public List<BuildOrderStep> steps;
        public int current_step = 0;

        public BuildOrder()
        {
            steps = new List<BuildOrderStep>();
        }
    }
}
