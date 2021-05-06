using Terraria;
using ZenekAdd.Tiles;
using Terraria.ModLoader;
using Terraria.ID;

namespace ZenekAdd.Items.Placeable
{
	public class KhaarTrophy : ModItem
	{
		public override void SetDefaults() {
			item.width = 30;
			item.height = 30;
			item.maxStack = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			Item.buyPrice(0, 15, 0, 0);
			item.rare = 2;
			item.createTile = ModContent.TileType<BossTrophy>();
			item.placeStyle = 0;
		}
	}
}