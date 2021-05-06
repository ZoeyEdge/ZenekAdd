using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ZenekAdd.Buffs;

namespace ZenekAdd.Projectiles.Minions
{   
    public class GraniteDrone : MinionINFO
    {
        public override void SetDefaults()
        {
            projectile.netImportant = true;
            projectile.width = 69;
            projectile.height = 51;
            Main.projFrames[projectile.type] = 6;
            projectile.friendly = true;
            Main.projPet[projectile.type] = true;
            projectile.minion = true;
            projectile.netImportant = true;
            projectile.minionSlots = 1;
            projectile.penetrate = 1;
            projectile.timeLeft = 18000;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
            inertia = 30f;
            shoot = mod.ProjectileType("GraniteBolt");
            shootSpeed = 10f;
            ProjectileID.Sets.LightPet[projectile.type] = true;
            Main.projPet[projectile.type] = true;
        }
 
        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            TestPlayer modPlayer = (TestPlayer)player.GetModPlayer(mod, "TestPlayer");
            if (player.dead)
            {
                modPlayer.GraniteDrone = false;
            }
            if (modPlayer.GraniteDrone)
            {
                projectile.timeLeft = 2;
            }
        }
 
        public override void CreateDust()
        {
            Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.6f, 0.9f, 0.3f);
        }
 
        public override void SelectFrame()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 8)
            {
                projectile.frameCounter = 0;
                projectile.frame = (projectile.frame + 1) % 6;
            }
        }
    }
}