using EloBuddy;
using EloBuddy.SDK;

namespace AddonTemplate.Modes
{
    public sealed class LaneClear : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            // Only execute this mode when the orbwalker is on laneclear mode
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LaneClear);
        }

        public override void Execute()
        {
            // TODO: Add laneclear logic here
            if (W.IsReady())
           {
               var target = TargetSelector.GetTarget(W.Range, DamageType .Physical);
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
