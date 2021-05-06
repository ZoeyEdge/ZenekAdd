using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Buffs;
using Microsoft.Xna.Framework;

namespace ZenekAdd.Items.Weapons
{
	public class GelEdge : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gelatinous Edge"); 
			Tooltip.SetDefault("Shoots a fast piercing slime spike"
			+ "\nTrue melee strikes grants the 'Jelly Stand' buff");
		}

		public override void SetDefaults() 
		{
			item.damage = 22;
			item.melee = true;
			item.width = 76;
			item.height = 80;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 1;
			item.knockBack = 7;
			Item.buyPrice(0, 0, 20, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
            item.shoot = mod.ProjectileType("GelSpike");
            item.shootSpeed = 18f;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			player.AddBuff(ModContent.BuffType<Buffs.GelDef>(), 300);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 150);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.LightsBane, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}