using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class Zenekrang : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Zenekrang");
			Tooltip.SetDefault("Shoot out stupidity that comes back to you");
		}

		public override void SetDefaults() 
		{
			item.damage = 16;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 35;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("Zenekrang2");
            item.shootSpeed = 20f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("DumShard"));
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}