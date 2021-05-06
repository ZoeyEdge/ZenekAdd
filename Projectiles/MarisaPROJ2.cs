using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Projectiles
{
	public class MarisaPROJ2 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Danmaku Star");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 28;
			projectile.height = 27;
			projectile.friendly = true;
			projectile.maxPenetrate = -1;
			projectile.magic = true;
			projectile.tileCollide = true;
			projectile.rotation += 0.4f * (float)projectile.direction;
		}

        //For all of the NPC slots in Main.npc
        //Note, you can replace NPC with other entities such as Projectiles and Players
        public override void AI()
        {
            for(int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];
                //If the npc is hostile
                if(!target.friendly)
                {
                    //Get the shoot trajectory from the projectile and target
                    float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
                    float shootToY = target.position.Y - projectile.Center.Y;
                    float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                    //If the distance between the live targeted npc and the projectile is less than 300 pixels
                    if(distance < 300f && !target.friendly && target.active)
                    {
                        //Divide the factor, 3f, which is the desired velocity
                        distance = 3f / distance;
   
                        //Multiply the distance by a multiplier if you wish the projectile to have go faster
                        shootToX *= distance * 6;
                        shootToY *= distance * 6;

                        //Set the velocities to the shoot values
                        projectile.velocity.X = shootToX;
                        projectile.velocity.Y = shootToY;
                    }
                }
            }
        }
	}
}