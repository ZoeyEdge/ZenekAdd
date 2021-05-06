using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class IceArmorGreaves : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Ice Greaves");
		}

		public override void SetDefaults() 
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.sellPrice(silver: 2);
			item.rare = 1;
			item.defense = 1;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddIngredient(ItemID.IceBlock, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}