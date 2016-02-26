using EloBuddy;
using EloBuddy.SDK;

// Using the config like this makes your life easier, trust me
using Settings = AddonTemplate.Config.Modes.Combo;

namespace AddonTemplate.Modes
{
    public sealed class Combo : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            // Only execute this mode when the orbwalker is on combo mode
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo);
        }

        public override void Execute()
        {
            // TODO: Add combo logic here
            // See how I used the Settings.UseQ here, this is why I love my way of using
            // the menu in the Config class!
            if (Settings.UseW && W.IsReady())
            {
                var target = TargetSelector.GetTarget(W.Range, DamageType.Physical);
                if (target != null)
                {
                    W.Cast(target);
                }
                if (Settings.UseE && E.IsReady())
                {
                    var target = TargetSelector.GetTarget(E.Range, DamageType.Physical);
                    if (target != null)
                    {
                        E.Cast(target);
                    }

                    if (Settings.UseR && R.IsReady())
                    {
                        var target = TargetSelector.GetTarget(R.Range, DamageType.Physical);
                        if (target != null)
                        {
                            R.Cast(target);
                        }

                    }
        }
    }
}
