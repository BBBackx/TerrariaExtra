using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Projectiles
{
	public class SG : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stardust Grenade");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.BouncyGrenade);
			aiType = ProjectileID.BouncyGrenade;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.BouncyGrenade;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 0; i++)
			{
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 4f, Main.rand.Next(-3, 2) * .12f, Main.rand.Next(-3, -2) * .12f, ProjectileID.BouncyGrenade, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}

			public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(2) == 0)
			{
				target.AddBuff(BuffID.Venom, 1500);
				target.AddBuff(BuffID.OnFire, 1500);
				target.AddBuff(BuffID.CursedInferno, 1500);
				target.AddBuff(BuffID.Confused, 1500);
				target.AddBuff(BuffID.Poisoned, 1500);
				target.AddBuff(BuffID.Frostburn, 1500);
				target.AddBuff(BuffID.Ichor, 1500);
				target.AddBuff(BuffID.Suffocation, 1500);
				target.AddBuff(BuffID.Cursed, 1500);
				target.AddBuff(BuffID.Wet, 1500);
				target.AddBuff(BuffID.Slimed, 1500);
				target.AddBuff(BuffID.OgreSpit, 1500);
			}
		}
	}
}