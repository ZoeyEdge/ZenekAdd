using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GelArmorHelmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gel Helmet"); 
		}

		public override void SetDefaults() 
		{
			item.faceSlot = 1;
			item.width = 24;
			item.height = 18;
			item.defense = 1;
			item.value = Item.sellPrice(silver: 3);
			item.rare = 1;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) 
		{
			return body.type == ModContent.ItemType<GelArmorBreastplace>() && legs.type == ModContent.ItemType<GelArmorGreaves>();
		}
		
		public override void UpdateArmorSet(Player player) 
		{
		    player.setBonus = "+20 Max Mana";
			player.statManaMax2 += 20;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}