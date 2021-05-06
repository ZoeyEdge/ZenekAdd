using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class IceArmorHelmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ice Helmet"); 
		}

		public override void SetDefaults() 
		{
			item.faceSlot = 1;
			item.width = 28;
			item.height = 22;
			item.defense = 2;
			item.value = Item.sellPrice(silver: 5);
			item.rare = 1;
		}
		
        public override bool IsArmorSet(Item head, Item body, Item legs) 
		{
			return body.type == ModContent.ItemType<IceArmorBreastplate>() && legs.type == ModContent.ItemType<IceArmorGreaves>();
		}
		
		public override void UpdateArmorSet(Player player) 
		{
		    player.setBonus = "Ranged Damage increased";
			player.rangedDamage += 0.2f;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddIngredient(ItemID.IceBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}