using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class LeafyArmorHelmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Leafy Headgear"); 
		}

		public override void SetDefaults() 
		{
			item.faceSlot = 1;
			item.width = 28;
			item.height = 24;
			item.defense = 1;
			item.value = Item.sellPrice(silver: 1);
			item.rare = 1;
		}
		
        public override bool IsArmorSet(Item head, Item body, Item legs) 
		{
			return body.type == ModContent.ItemType<LeafyArmorBody>() && legs.type == ModContent.ItemType<LeafyArmorBoots>();
		}
		
		public override void UpdateArmorSet(Player player) 
		{
		    player.setBonus = "+1 minion slot";
			player.maxMinions += 1;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 32);
			recipe.AddIngredient(ItemID.Acorn, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}