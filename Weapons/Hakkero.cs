using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace ZenekAdd.Items.Weapons
{
    public class Hakkero : ModItem
    {
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mini-Hakkero");
			Tooltip.SetDefault("It ain't magic if it ain't flashy. Terraria's all about firepower!");
		}
		
        public override void SetDefaults()
        {
            item.damage = 86;                       
            item.magic = true;  
            item.width = 30;    
            item.height = 30;   
            item.useTime = 30;   
            item.useAnimation = 30;   
            item.useStyle = 5;        
            item.noMelee = true;   
            item.knockBack = 2;  
            item.value = Item.buyPrice(5, 0, 0, 0); 
            item.rare = -12;   
            item.mana = 20;
            item.UseSound = SoundID.Item21; 
            item.autoReuse = true; 
            item.shoot = mod.ProjectileType("MarisaPROJ3");  
            item.shootSpeed = 15f;    
        }
		
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int choice = Main.rand.Next(2);
            if (choice == 0)
			{
			    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("MarisaPROJ1") , damage, knockBack, player.whoAmI); 
			}
			
			if (choice == 1)
			{
			    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("MarisaPROJ2") , damage, knockBack, player.whoAmI);
			}
            float numberProjectiles = 5; // how many projectiles to shoot?
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f; //this defines the distance of the projectiles form the player when the projectile spawns
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f; // This defines the projectile roatation and speed. .4f == projectile speed
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }  
    }
}