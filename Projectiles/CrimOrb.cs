using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class CrimOrb : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("CrimOrb");
		}

		public override void SetDefaults()
		{
			projectile.width = 46;
			projectile.height = 46;
			projectile.friendly = true;
			projectile.maxPenetrate = -1;
			projectile.magic = true;
			projectile.tileCollide = false;
		}
		
		public override void AI()
        {
            //Making player variable "p" set as the projectile's owner
		    Player p = Main.player[projectile.owner];

            //Factors for calculations
            double deg = (double) projectile.ai[1]; //The degrees, you can multiply projectile.ai[1] to make it orbit faster, may be choppy depending on the value
            double rad = deg * (Math.PI / 180); //Convert degrees to radians
            double dist = 32; //Distance away from the player
 
            /*Position the player based on where the player is, the Sin/Cos of the angle times the /
            /distance for the desired distance away from the player minus the projectile's width   /
            /and height divided by two so the center of the projectile is at the right place.     */
            projectile.position.X = p.Center.X - (int)(Math.Cos(rad) * dist) - projectile.width/2;
            projectile.position.Y = p.Center.Y - (int)(Math.Sin(rad) * dist) - projectile.height/2;
 
            //Increase the counter/angle in degrees by 1 point, you can change the rate here too, but the orbit may look choppy depending on the value
            projectile.ai[1] += 1f;
		}
	}
}