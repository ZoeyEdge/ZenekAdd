using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class SentryACC : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bruh Crystal");
			Tooltip.SetDefault("+1 Sentry Slot"
			+ "\nPlease work");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 35);
			item.rare = 1;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.maxTurrets += 1;
		}
	}
}