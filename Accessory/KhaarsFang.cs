using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class KhaarsFang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Khaar's Fang");
			Tooltip.SetDefault("Higher crit chance"
			+ "\nOne of many fangs, probably very cute without these");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 10);
			item.rare = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.meleeCrit += 3;
			player.magicCrit += 3;
			player.rangedCrit += 3;
		}
	}
}