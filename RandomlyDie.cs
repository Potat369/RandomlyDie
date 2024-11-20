using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Animations;
using Terraria.Localization;
using Terraria.ModLoader;

namespace RandomlyDie
{
	public class RandomlyDie : Mod;

	public class RandomlyDieSystem : ModSystem
	{
		private int ticksPassed;
		public override void PreUpdatePlayers()
		{
			ticksPassed++;
			if (ticksPassed != 60) return;
			ticksPassed = 0;
			int chance = ModContent.GetInstance<RandomlyDieConfig>().Chance;
			foreach (var player in Main.ActivePlayers)
			{
				if (player.dead) continue;
				if (!Main.rand.NextBool(chance)) continue;
				player.KillMe(PlayerDeathReason.LegacyEmpty(), 0, 0);
			}
		}
	}
}
