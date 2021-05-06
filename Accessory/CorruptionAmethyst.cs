using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class CorruptionAmethyst : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Boosts your move speed and melee speed"
			+ "\nLooking at the Amethyst makes you lose your mind");
		}

		public override void SetDefaults() {
			item.width = 11;
			item.height = 18;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 50);
			item.rare = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.meleeSpeed += 1;
			player.moveSpeed += 2;
		}
	}
}