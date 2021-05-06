using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class GraniteMechanicBoots : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Granite's Mechanic Boots");
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 18;
			item.value = Item.sellPrice(silver: 4);
			item.rare = 1;
			item.defense = 2;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Granite, 20);
			recipe.AddIngredient(mod.GetItem("GranitePowerCell"), 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}