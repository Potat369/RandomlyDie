using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace RandomlyDie;

public class RandomlyDieConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;
    
    [DefaultValue(480)]
    [Range(1, int.MaxValue)]
    public int Chance;
}