using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class StinkShroom : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("+20 HP"
			+ "\nNot eatable");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 7);
			item.rare = 1;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.statLifeMax2 += 20;
		}
	}
}