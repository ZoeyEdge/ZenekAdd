using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ZenekAdd;
using ZenekAdd.Items.Armor;

namespace ZenekAdd.Projectiles.Minions.Special
{
	public class GraniteChunk : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Granite Chunk");
		}

		public override void SetDefaults()
		{
			projectile.width = 28;
			projectile.height = 26;
			projectile.friendly = true;
			projectile.timeLeft = 2;
			projectile.penetrate = -1;
			projectile.minion = true;
			projectile.tileCollide = false;
		}
		
		public override void AI()
        {
            //Making player variable "p" set as the projectile's owner
		    Player p = Main.player[projectile.owner];
			Projectile proj = Main.projectile[1];

            //Factors for calculations
            double deg = (double) projectile.ai[1]; //The degrees, you can multiply projectile.ai[1] to make it orbit faster, may be choppy depending on the value
            double rad = deg * (Math.PI / 180); //Convert degrees to radians
            double dist = 42; //Distance away from the player
 
            /*Position the player based on where the player is, the Sin/Cos of the angle times the /
            /distance for the desired distance away from the player minus the projectile's width   /
            /and height divided by two so the center of the projectile is at the right place.     */
            projectile.position.X = p.Center.X - (int)(Math.Cos(rad) * dist) - projectile.width/2;
            projectile.position.Y = p.Center.Y - (int)(Math.Sin(rad) * dist) - projectile.height/2;
 
            //Increase the counter/angle in degrees by 1 point, you can change the rate here too, but the orbit may look choppy depending on the value
            projectile.ai[1] += 2f;
			
			Player player = Main.player[projectile.owner];
			if (player.GetModPlayer<ArmorSetSpecial>().granite)
            {
                projectile.timeLeft = 2;
            }
            //timer++;
			
		}
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)  
        {
            target.AddBuff(31, 600); 
        }
	}
}