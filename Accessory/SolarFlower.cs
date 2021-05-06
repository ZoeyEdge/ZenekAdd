using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class SolarFlower : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Solar Flower");
			Tooltip.SetDefault("Increased Mana regeneration during the day"
			+ "\n+5% Magic Critical Chance during the night");
		}

		public override void SetDefaults() 
		{
			item.width = 34;
			item.height = 34;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 15);
			item.rare = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
            if (Main.dayTime) 
			{
				player.manaRegen += 5;
			}
			else
			{
				player.magicCrit += 5;
			}
		}	
	}
}