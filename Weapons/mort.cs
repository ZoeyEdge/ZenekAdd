using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class mort : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mort");
			Tooltip.SetDefault("poggers");
		}

		public override void SetDefaults() 
		{
			item.damage = 999;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			Item.buyPrice(4, 2, 0, 0);
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}