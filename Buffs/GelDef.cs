using Terraria;
using Terraria.ModLoader;

namespace ZenekAdd.Buffs
{
    public class GelDef : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Jelly Stand");
            Description.SetDefault("Grants +3 defense and you move slightly faster");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 3; //Grants a +3 defense boost to the player while the buff is active.
			player.moveSpeed += 1; //Grants a +1 move speed boost to the player while the buff is active.
        }
    }
}