using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class CrimsonicOrb : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Crimsonic Orb");
			Tooltip.SetDefault("Summons a fleshy orb to orbit around and defend you");
		}

		public override void SetDefaults() 
		{
			item.damage = 31;
			item.magic = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.knockBack = 1;
			Item.buyPrice(0, 0, 27, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.mana = 20;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("CrimOrb");
            item.shootSpeed = 25f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TissueSample, 30);
			recipe.AddIngredient(ItemID.Vertebrae, 10);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}