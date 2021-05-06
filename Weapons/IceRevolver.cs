using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Items.Weapons
{
	public class IceRevolver : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Frozenolver");
			Tooltip.SetDefault("Cool down your foes!");
		}

		public override void SetDefaults() 
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 52;
			item.height = 28;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 5;
			Item.buyPrice(0, 0, 8, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.shoot = 10; // uhhh idk they told me to do this
			item.useAmmo = AmmoID.Bullet; // uses bullets as ammo
			item.shootSpeed = 15f;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}