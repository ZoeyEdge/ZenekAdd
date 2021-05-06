using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Material
{
    public class GranitePowerCell : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Granite Power Cell");
            Tooltip.SetDefault("A magical crystal made out of granite"
			+"\nSeems to power up granite creatures");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 30;
            item.maxStack = 99;
            item.value = Item.sellPrice(silver: 5);;
            item.rare = 2;
        }
    }
}