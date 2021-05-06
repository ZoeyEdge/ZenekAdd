using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class IceSpikeTome : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ice Spike Tome");
			Tooltip.SetDefault("Shoots out an icy spike"
			+ "\nInflicts Frostburn");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.magic = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 1;
			Item.buyPrice(0, 0, 12, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.mana = 5;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("IceSpike");
            item.shootSpeed = 20f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SlimeSpikeTome"));
			recipe.AddIngredient(ItemID.IceBlock, 10);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.Snowball, 3);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}