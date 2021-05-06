using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using ZenekAdd.Projectiles.Minions;

namespace ZenekAdd.Items.Weapons
{
    public class GraniteControlStaff : ModItem
    {
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Granite Energy Staff");
			Tooltip.SetDefault("Summons a granite energy core");
		}
 
        public override void SetDefaults()
        {
            item.damage = 22; 
            item.mana = 20;     
            item.width = 42;  
            item.height = 42;
            item.useTime = 30;  
            item.useAnimation = 30;    
            item.useStyle = 1;  
            item.noMelee = true; 
            item.knockBack = 3f;  
            item.value = Item.buyPrice(0, 0, 60, 0);
            item.value = Item.sellPrice (0, 0, 45, 0);			
            item.rare = 2;  
            item.UseSound = SoundID.Item44;   
            item.autoReuse = true;   
            item.shoot = mod.ProjectileType("GraniteCore");   
            item.summon = true; //This defines if it does Summon damage and if its effected by Summon increasing Armor/Accessories.
            item.sentry = true; //tells the game that this is a sentry
        }
 
        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 SPos = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY); //this make so the projectile will spawn at the mouse cursor position
            position = SPos;
            for (int l = 0; l < Main.projectile.Length; l++)
            {   //this make so you can only spawn one of this projectile at the time,
                /*Projectile proj = Main.projectile[l];
                if (proj.active && proj.type == item.shoot && proj.owner == player.whoAmI)
                {
                    proj.active = false;
                }*/
            }
            return true;
        }
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Granite, 30);
			recipe.AddIngredient(mod.GetItem("GranitePowerCell"), 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }


    public class GraniteCore : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Core");
        }

        public override void SetDefaults()
        {
            projectile.width = 50; //Set the hitbox width
            projectile.height = 54;   //Set the hitbox heinght
            projectile.hostile = false;    //tells the game if is hostile or not.
            projectile.friendly = false;   //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.ignoreWater = true;    //Tells the game whether or not projectile will be affected by water
            Main.projFrames[projectile.type] = 3;  //this is where you add how many frames u'r projectile has to make the animation
            projectile.timeLeft = 2500;  // this is the projectile life time( 60 = 1 second so 900 is 15 seconds )     
            projectile.penetrate = -1; //Tells the game how many enemies it can hit before being destroyed  -1 is infinity
            projectile.tileCollide = true; //Tells the game whether or not it can collide with tiles/ terrain
            projectile.sentry = true; //tells the game that this is a sentry
        }
		
		 public override void Kill(int timeLeft)
        {
 
            Main.PlaySound(2, projectile.Center, 62);  //this make so when this projectile disappear will make this sound. you can find all the sound ID here: https://github.com/bluemagic123/tModLoader/wiki/Vanilla-Sound-IDs
 
            for (int i = 0; i < 20; i++) //this i a for loop tham make the dust spawn , the higher is the value the more dust will spawn
            {
                int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 187, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 120, default(Color), 3.50f);   //this make so when this projectile disappear will spawn dust, change PinkPlame to what dust you want from Terraria, or add mod.DustType("CustomDustName") for your custom dust
                Main.dust[dust].noGravity = false; //this make so the dust has no gravity
                Main.dust[dust].velocity *= 2.5f;
            }
        }
 
        public override void AI()
        {
            for (int i = 0; i < 1; i++)
            {
                int dust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 187, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, 120, default(Color), 1.50f);   //this make so when this projectile is active has dust around , change PinkPlame to what dust you want from Terraria, or add mod.DustType("CustomDustName") for your custom dust
                Main.dust[dust].noGravity = true; //this make so the dust is effected by gravity
                Main.dust[dust].velocity *= 0.9f;
            }
            projectile.rotation += 1.5f;   //this make the projctile to rotate
 
            //---------------------------------------------------This make this projectile1 shot another projectile2 to a target if is in between the distance and this projectile1 ------------------------------------------------------------------------
 
 
            //Getting the npc to fire at
            for (int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];
 
                //Getting the shooting trajectory
                float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
                float shootToY = target.position.Y + (float)target.height * 0.5f - projectile.Center.Y;
                float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));
 
                //If the distance between the projectile and the live target is active
                if (distance < 520f && !target.friendly && target.active)  //distance < 520 this is the projectile1 distance from the target if the tarhet is in that range the this projectile1 will shot the projectile2
                {
                    if (projectile.ai[0] > 180f)//this make so the projectile1 shoot a projectile every 2 seconds(60 = 1 second so 120 = 2 seconds) 
                    {
                        //Dividing the factor of 2f which is the desired velocity by distance
                        distance = 1.6f / distance;
 
                        //Multiplying the shoot trajectory with distance times a multiplier if you so choose to
                        shootToX *= distance * 3;
                        shootToY *= distance * 3;
                        int damage = 20;  //this is the projectile2 damage                   
                                          //Shoot projectile and set ai back to 0
                        Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootToX, shootToY, mod.ProjectileType("GraniteBolt"), damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile mod.ProjectileType("FlamethrowerProj") is an example of how to spawn a modded projectile. if you want to shot a terraria prjectile add instead ProjectileID.FrostBlast
                        Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 24); //24 is the sound, so when this projectile is shot will make that sound
                        projectile.ai[0] = 0f;
                    }
                }
            }
            projectile.ai[0] += 1f;
 
        }
    }
}