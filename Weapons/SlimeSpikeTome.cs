using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class SlimeSpikeTome : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Slime Spike Tome");
			Tooltip.SetDefault("Shoots out a slimy spike");
		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.magic = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 1;
			Item.buyPrice(0, 0, 0, 30);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.mana = 2;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("SlimeSpike");
            item.shootSpeed = 20f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.AddIngredient(ItemID.StoneBlock, 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}