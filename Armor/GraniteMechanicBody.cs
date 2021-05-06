using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class GraniteMechanicBody : ModItem
	{
		public override void SetStaticDefaults() 
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Granite's Mechanic Suit");
			Tooltip.SetDefault("+10% Minion Damage");
		}

		public override void SetDefaults() 
		{
			item.width = 26;
			item.height = 22;
			item.value = Item.sellPrice(silver: 12);
			item.rare = 1;
			item.defense = 4;
		}
		
		public override void UpdateEquip(Player player) 
		{
            player.minionDamage += 0.1f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Granite, 50);
			recipe.AddIngredient(mod.GetItem("GranitePowerCell"), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}