/*using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ZenekAdd.Scrapped
{
	internal class WormVirusHead : Worm
	{
		public override void SetDefaults() {
			// Head is 10 defence, body 20, tail 30.
			npc.CloneDefaults(NPCID.DiggerHead);
			npc.aiStyle = -1;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.lifeMax = 725;
			// SCRAPPED VIRUS ENEMY, DOESNT SPAWN
		}

		public override void Init() {
			base.Init();
			head = true;
		}

		private int attackCounter;
		public override void SendExtraAI(BinaryWriter writer) {
			writer.Write(attackCounter);
		}

		public override void ReceiveExtraAI(BinaryReader reader) {
			attackCounter = reader.ReadInt32();
		}

		public override void CustomBehavior() {
			if (Main.netMode != 1) {
				if (attackCounter > 0) {
					attackCounter--;
				}

				Player target = Main.player[npc.target];
				if (attackCounter <= 0 && Vector2.Distance(npc.Center, target.Center) < 200 && Collision.CanHit(npc.Center, 1, 1, target.Center, 1, 1)) {
					Vector2 direction = (target.Center - npc.Center).SafeNormalize(Vector2.UnitX);
					direction = direction.RotatedByRandom(MathHelper.ToRadians(10));

					int projectile = Projectile.NewProjectile(npc.Center, direction * 1, ProjectileID.ShadowBeamHostile, 5, 0, Main.myPlayer);
					Main.projectile[projectile].timeLeft = 300;
					attackCounter = 500;
					npc.netUpdate = true;
				}
			}
		}
	}

	internal class WormVirusBody : Worm
	{
		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.DiggerBody);
			npc.aiStyle = -1;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.lifeMax = 725;
		}
	}

	internal class WormVirusTail : Worm
	{
		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.DiggerTail);
			npc.aiStyle = -1;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.lifeMax = 725;
			
		}

		public override void Init() {
			base.Init();
			tail = true;
		}
	}

	// I made this 2nd base class to limit code repetition.
	public abstract class WormVirus : Worm
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Worm Virus");
		}

		public override void Init() {
			minLength = 5;
			maxLength = 5;
			npc.noGravity = true;
			tailType = ModContent.NPCType<KhaarTail>();
			bodyType = ModContent.NPCType<KhaarBody>();
			headType = ModContent.NPCType<KhaarHead>();
			speed = 15f;
			turnSpeed = 0.050f;
		}
	}
}*/