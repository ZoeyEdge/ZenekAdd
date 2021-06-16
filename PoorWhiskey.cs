using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items
{
    public class PoorWhiskey : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Poor Whiskey");
			Tooltip.SetDefault("Some poor, bad quality whiskey in a glass"
			+ "\nMaybe it will attract something lifeless?");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 26;
            item.maxStack = 1;
            item.value = Item.buyPrice(0, 0, 5, 0); 
            item.rare = -1;
        }
    }
}