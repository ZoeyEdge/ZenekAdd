using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class EternalFire : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Necklace of the Eternal Fire");
			Tooltip.SetDefault("Minions inflict fire upon targeted foes");
		}

		public override void SetDefaults() 
		{
			item.width = 26;
			item.height = 36;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 5);
			item.rare = 3;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<EternalFireEffect>().effect = true;
        }
		
		public class EternalFireEffect : ModPlayer
        {
            public bool effect;

            public override void ResetEffects()
            {  
                effect = false;
            }
        }
		
		public class EternalFireHit : GlobalProjectile
        {
            public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
            {
                if (Main.player[projectile.owner].GetModPlayer<EternalFireEffect>().effect)
                {
                    if (projectile.minion && target.whoAmI == Main.player[projectile.owner].MinionAttackTargetNPC)
                    {
                        target.AddBuff(24, 360);
                    }
                }
            }
        }
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 25);
			recipe.AddIngredient(ItemID.Fireblossom, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}