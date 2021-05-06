using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Projectiles.Minions.Special;
using ZenekAdd;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GraniteMechanicHead : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Granite's Mechanic Headgear");
			Tooltip.SetDefault("+1 Minion Slot");
		}

		public override void SetDefaults() 
		{
			item.faceSlot = 1;
			item.width = 24;
			item.height = 28;
			item.defense = 3;
			item.value = Item.sellPrice(silver: 10);
			item.rare = 1;
		}
		
		public override void UpdateEquip(Player player) 
		{
            player.maxMinions += 1;
		}
		
        public override bool IsArmorSet(Item head, Item body, Item legs) 
		{
			return body.type == ModContent.ItemType<GraniteMechanicBody>() && legs.type == ModContent.ItemType<GraniteMechanicBoots>();
		}
		
		public override void UpdateArmorSet(Player player) 
		{
		    player.setBonus = "Summons a Granite Chunk to orbit and defend you";
			player.GetModPlayer<ArmorSetSpecial>().granite = true;
			
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Granite, 30);
			recipe.AddIngredient(mod.GetItem("GranitePowerCell"), 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}