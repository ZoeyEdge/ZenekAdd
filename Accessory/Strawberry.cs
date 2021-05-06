using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using ZenekAdd.Tiles;
using Microsoft.Xna.Framework;

namespace ZenekAdd.Items.Accessory
{
	public class Strawberry : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Reduces your health to 1"
			+ "\nYou can now perform a powerful dash"
			+ "\nYou can now climb walls"
			+ "\nFall damage immunity"
			+ "\n'Everything's okay, Terrarian?'");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 52;
			item.accessory = true;
			item.value = Item.sellPrice(gold: 1);
			item.rare = 10;
		}
		
		public override void UpdateEquip(Player player) 
		{
			player.statLifeMax2 = 1;
			player.noFallDmg = true;
			player.spikedBoots += 2;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			ModDashPlayer mp = player.GetModPlayer<ModDashPlayer>();

			//If the dash is not active, immediately return so we don't do any of the logic for it
			if(!mp.DashActive)
				return;

			//This is where we set the afterimage effect.  You can replace these two lines with whatever you want to happen during the dash
			//Some Examples include:  spawning dust where the player is, adding buffs, making the player immune, etc.
			//Here we take advantage of "player.eocDash" and "player.armorEffectDrawShadowEOCShield" to get the Shield of Cthulhu's afterimage effect
			player.eocDash = mp.DashTimer;
			player.armorEffectDrawShadowEOCShield = true;

			//If the dash has just started, apply the dash velocity in whatever direction we wanted to dash towards
			if(mp.DashTimer == ModDashPlayer.MAX_DASH_TIMER)
			{
				Vector2 newVelocity = player.velocity;
					
				//Only apply the dash velocity if our current speed in the wanted direction is less than DashVelocity
				if((mp.DashDir == ModDashPlayer.DashUp && player.velocity.Y > -mp.DashVelocity) || (mp.DashDir == ModDashPlayer.DashDown && player.velocity.Y < mp.DashVelocity))
				{
					//Y-velocity is set here
					//If the direction requested was DashUp, then we adjust the velocity to make the dash appear "faster" due to gravity being immediately in effect
					//This adjustment is roughly 1.3x the intended dash velocity
					float dashDirection = mp.DashDir == ModDashPlayer.DashDown ? 1 : -1.3f;
					newVelocity.Y = dashDirection * mp.DashVelocity;
				}
				else if((mp.DashDir == ModDashPlayer.DashLeft && player.velocity.X > -mp.DashVelocity) || (mp.DashDir == ModDashPlayer.DashRight && player.velocity.X < mp.DashVelocity))
				{
					//X-velocity is set here
					int dashDirection = mp.DashDir == ModDashPlayer.DashRight ? 1 : -1;
					newVelocity.X = dashDirection * mp.DashVelocity;
				}

				player.velocity = newVelocity;
			}

			//Decrement the timers
			mp.DashTimer--;
			mp.DashDelay--;

			if(mp.DashDelay == 0)
			{
				//The dash has ended.  Reset the fields
				mp.DashDelay = ModDashPlayer.MAX_DASH_DELAY;
				mp.DashTimer = ModDashPlayer.MAX_DASH_TIMER;
				mp.DashActive = false;
			}
		}
	}

	public class ModDashPlayer : ModPlayer
	{
		    //These indicate what direction is what in the timer arrays used
		    public static readonly int DashDown = 0;
		    public static readonly int DashUp = 1;
		    public static readonly int DashRight = 2;
		    public static readonly int DashLeft = 3;

		    //The direction the player is currently dashing towards.  Defaults to -1 if no dash is ocurring.
		    public int DashDir = -1;

		    //The fields related to the dash accessory
		    public bool DashActive = false;
		    public int DashDelay = MAX_DASH_DELAY;
		    public int DashTimer = MAX_DASH_TIMER;
		    //The initial velocity.  10 velocity is about 37.5 tiles/second or 50 mph
		    public readonly float DashVelocity = 20f;
		    //These two fields are the max values for the delay between dashes and the length of the dash in that order
		    //The time is measured in frames
		    public static readonly int MAX_DASH_DELAY = 50;
		    public static readonly int MAX_DASH_TIMER = 35;

		public override void ResetEffects()
		{
			    //ResetEffects() is called not long after player.doubleTapCardinalTimer's values have been set
			
			    //Check if the ModDashAccessory is equipped and also check against this priority:
			    // If the Shield of Cthulhu, Master Ninja Gear, Tabi and/or Solar Armour set is equipped, prevent this accessory from doing its dash effect
			    //The priority is used to prevent undesirable effects.
			    //Without it, the player is able to use the ModDashAccessory's dash as well as the vanilla ones
			    bool dashAccessoryEquipped = false;

			    //This is the loop used in vanilla to update/check the not-vanity accessories
			    for(int i = 3; i < 8 + player.extraAccessorySlots; i++)
			    {
				    Item item = player.armor[i];

				    //Set the flag for the ModDashAccessory being equipped if we have it equipped OR immediately return if any of the accessories are
				    // one of the higher-priority ones
				    if(item.type == ModContent.ItemType<Strawberry>())
					    dashAccessoryEquipped = true;
				    else if(item.type == ItemID.EoCShield || item.type == ItemID.MasterNinjaGear || item.type == ItemID.Tabi)
					    return;
			    }

			    //If we don't have the ModDashAccessory equipped or the player has the Solor armor set equipped, return immediately
			    //Also return if the player is currently on a mount, since dashes on a mount look weird, or if the dash was already activated
			    if(!dashAccessoryEquipped || player.setSolar || player.mount.Active || DashActive)
				    return;

			    //When a directional key is pressed and released, vanilla starts a 15 tick (1/4 second) timer during which a second press activates a dash
			    //If the timers are set to 15, then this is the first press just processed by the vanilla logic.  Otherwise, it's a double-tap
			    if(player.controlDown && player.releaseDown && player.doubleTapCardinalTimer[DashDown] < 15)
				    DashDir = DashDown;
			    else if(player.controlUp && player.releaseUp && player.doubleTapCardinalTimer[DashUp] < 15)
				    DashDir = DashUp;
			    else if(player.controlRight && player.releaseRight && player.doubleTapCardinalTimer[DashRight] < 15)
				    DashDir = DashRight;
			    else if(player.controlLeft && player.releaseLeft && player.doubleTapCardinalTimer[DashLeft] < 15)
				    DashDir = DashLeft;
			    else
				    return;	   //No dash was activated, return

			    DashActive = true;
		}
	}
}