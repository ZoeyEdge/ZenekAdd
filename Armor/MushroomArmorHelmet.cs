using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class MushroomArmorHelmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mushroom Helmet"); 
			Tooltip.SetDefault("Fashionable");
		}

		public override void SetDefaults() 
		{
			item.faceSlot = 1;
			item.width = 50;
			item.height = 50;
			item.defense = 2;
			item.value = Item.sellPrice(silver: 3);
			item.rare = 1;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 3);
			recipe.AddIngredient(ItemID.WoodHelmet);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}