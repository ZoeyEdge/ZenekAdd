using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class InfectedDumShard : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Boosts life regen and mana regen"
			+ "\nOf course we need edge!");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 5, copper: 25);
			item.rare = -1;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.lifeRegen += 2;
			player.manaRegen += 2;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("DumShard"));
			recipe.AddIngredient(ItemID.OrangeDye, 5);
			recipe.AddIngredient(ItemID.OrangePaint, 15);
			recipe.AddIngredient(ItemID.OrangeBloodroot);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}