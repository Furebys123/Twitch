using EloBuddy;
using EloBuddy.SDK;

namespace AddonTemplate.Modes
{
    public sealed class JungleClear : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            // Only execute this mode when the orbwalker is on jungleclear mode
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.JungleClear);
        }

        public override void Execute()
        {
            // TODO: Add jungleclear logic here
        }
        {
           
            if (W.IsReady())
           {
               var target = TargetSelector.GetTarget(W.Range, DamageType.Physical);
               if (target != null)
               {
                    W.Cast(target);
               }
                if (E.IsReady())
                {
                    var target = TargetSelector.GetTarget(E.Range, DamageType.Physical);
                    if (target != null)
                    {
                        E.Cast(target);
                    }
                }
        }
            }
    }
}
