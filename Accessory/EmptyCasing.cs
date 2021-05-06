using static ZenekAdd.TestPlayer;
using ZenekAdd;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class EmptyCasing : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Empty Casing");
			Tooltip.SetDefault("+7% Ranged damage"
			+ "\nIt's very worn out");
		}

		public override void SetDefaults() 
		{
			item.width = 34;
			item.height = 34;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 23);
			item.rare = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
            player.rangedDamage += 0.07f;
		}	
	}
}