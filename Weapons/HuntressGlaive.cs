using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class HuntressGlaive : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Huntress Glaive");
			Tooltip.SetDefault("Throw a laser glaive that comes back"
			+"\nPiercing when it hits an enemy at it's highest range");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.ranged = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.width = 38;
			item.height = 38;
			item.useTime = 46;
			item.useAnimation = 46;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.buyPrice(0, 0, 32, 0);
			item.value = Item.sellPrice (0, 0, 27, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("HuntressGlaivePROJ");
            item.shootSpeed = 20f;
		}
	}
}