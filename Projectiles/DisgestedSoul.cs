using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class DisgestedSoul : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DisgestedSoul");
		}

		public override void SetDefaults()
		{
			projectile.width = 34;
			projectile.height = 63;
			projectile.friendly = true;
			projectile.maxPenetrate = -1;
			projectile.magic = true;
			projectile.tileCollide = false;
			projectile.timeLeft = 1300;
			//projectile.rotation += 0.4f * (float)projectile.direction;
		}
        
		public override void AI()
		{
			for(int i = 0; i < 200; i++)
            {
				NPC target = Main.npc[i];
                //If the npc is hostile
                if(!target.friendly);
                {
                    //Get the shoot trajectory from the projectile and target
                    float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
                    float shootToY = target.position.Y - projectile.Center.Y;
                    float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                    //If the distance between the live targeted npc and the projectile is less than 480 pixels
                    if(distance < 480f && !target.friendly && target.active)
                    {
                        //Divide the factor, 3f, which is the desired velocity
                        distance = 3f / distance;
   
                        //Multiply the distance by a multiplier if you wish the projectile to have go faster
                        shootToX *= distance * 5;
                        shootToY *= distance * 5;

                        //Set the velocities to the shoot values
                        projectile.velocity.X = shootToX;
                        projectile.velocity.Y = shootToY;
						
						projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
                        projectile.localAI[0] += 1f;
                        projectile.alpha = (int)projectile.localAI[0] * 2;
					}
				}
			}
		}
	}
}