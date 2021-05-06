using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class Equalizer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Equalizer"); 
			Tooltip.SetDefault("Disables life regen when held"
			+ "\nGet close enough to death, and you will become Death himself");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.width = 34;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 6;
			Item.buyPrice(0, 2, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}
		
		public virtual void HoldItem(Player player)
		{
			player.lifeRegen = 0;
		}
	}
}