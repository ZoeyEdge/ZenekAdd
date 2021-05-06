using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class CrimsonRuby : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Increases minion damage and adds +1 minion slot"
			+ "\nLooking at the Ruby makes you want to join the hivemind");
		}

		public override void SetDefaults() 
		{
			item.width = 11;
			item.height = 18;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 50);
			item.rare = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.maxMinions += 1;
			player.minionDamage += 0.05f;
		}
	}
}