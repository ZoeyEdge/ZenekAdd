using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Material
{
    public class DumShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A shard of someone really dumb");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.sellPrice(copper: 1);
            item.rare = -1;
            // Set other item.X values here
        }
    }
}