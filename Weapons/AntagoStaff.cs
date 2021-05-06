using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class AntagoStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Antago Staff");
			Tooltip.SetDefault("Casts an explosive fireball");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 40;
			item.magic = true;
			item.width = 42;
			item.height = 42;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			Item.buyPrice(0, 10, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.mana = 20;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("Fireball");
            item.shootSpeed = 30f;
		}
	}
}