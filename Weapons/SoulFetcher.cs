using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class SoulFetcher : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Fetcher");
			Tooltip.SetDefault("Sends a homing disgested soul");
		}

		public override void SetDefaults() 
		{
			item.damage = 29;
			item.magic = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 37;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			Item.buyPrice(0, 0, 30, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.mana = 12;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("DisgestedSoul");
            item.shootSpeed = 15f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowScale, 30);
			recipe.AddIngredient(ItemID.RottenChunk, 10);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}