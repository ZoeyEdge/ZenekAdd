using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class LeafyArmorBody : ModItem
	{
		public override void SetStaticDefaults() 
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Leafy Breastplate");
			Tooltip.SetDefault("+3% minion damage");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 20;
			item.value = Item.sellPrice(silver: 6);
			item.rare = 1;
			item.defense = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
            player.minionDamage += 00.03f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 60);
			recipe.AddIngredient(ItemID.Acorn, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}