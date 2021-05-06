using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using ZenekAdd.Items.Armor;

namespace ZenekAdd
{
    public class ArmorSetSpecial : ModPlayer
    {
        public bool granite = false;
        public override void ResetEffects()
        {
            granite = false;
        }
		
        public override void PreUpdate()
        {
            if (granite && player.ownedProjectileCounts[mod.ProjectileType("GraniteChunk")] < 1)
            {
                Projectile.NewProjectile(player.Center, Vector2.Zero, mod.ProjectileType("GraniteChunk"), (int)(20f), 0, player.whoAmI);
            }
        }
    }
}