using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Projectiles;

namespace ZenekAdd.Items.Weapons
{
	public class WatchfulEye : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Watchful Eye");
			Tooltip.SetDefault("Cast a magical-demon eye to strike your foe"
			+ "\n'It's hard on the eyes!'");
		}

		public override void SetDefaults() 
		{
			item.damage = 26;
			item.magic = true;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.mana = 8;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("MagicalEye");
            item.shootSpeed = 13f;
		}
	}
}