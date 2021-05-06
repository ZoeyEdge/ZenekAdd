using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ZenekAdd.Items.Accessory
{
	public class GraniteSoul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Granite Soul");
			Tooltip.SetDefault("Minions inflict 'confusion' to targeted foes"
			+ "\nScared and weak, let no one near");
		}

		public override void SetDefaults() 
		{
			item.width = 34;
			item.height = 34;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 2);
			item.rare = 2;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GraniteSoulEffect>().effect = true;
        }
		
		public class GraniteSoulEffect : ModPlayer
        {
            public bool effect;

            public override void ResetEffects()
            {  
                effect = false;
            }
        }
		
		public class GraniteSoulHit : GlobalProjectile
        {
            public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
            {
                if (Main.player[projectile.owner].GetModPlayer<GraniteSoulEffect>().effect)
                {
                    if (projectile.minion && target.whoAmI == Main.player[projectile.owner].MinionAttackTargetNPC)
                    {
                        target.AddBuff(31, 600);
                    }
                }
            }
        }
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Granite, 66);
			recipe.AddIngredient(mod.GetItem("GranitePowerCell"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}