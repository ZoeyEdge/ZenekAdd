using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class ManaLeech : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mana Leech");
			Tooltip.SetDefault("Higher mana cost but +20% Magic Damage"
			+ "\nIt's rumored all leeches come from the blue stars you see on the sky");
		}

		public override void SetDefaults() 
		{
			item.width = 28;
			item.height = 28;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 30);
			item.value = Item.buyPrice(silver: 65);
			item.rare = 2;
		}
		
		public override void UpdateEquip(Player player) 
		{
            player.manaCost += 0.3f; // changes the mana cost of any weapon that uses it
			player.magicDamage += 0.2f;
		}	
	}
}