using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class KhaarsTear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Khaar's Tear");
			Tooltip.SetDefault("Reduces your minion slots to 1, but minion damage is massively increased"
			+ "\nEven the mightiest beasts cry");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 18;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 15);
			item.rare = -12;
		}
		
		public override void UpdateEquip(Player player)
	    {
			player.maxMinions = 1;
            player.minionDamage += 2.5f;
		}
	}
}