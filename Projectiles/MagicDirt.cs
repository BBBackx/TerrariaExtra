using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Projectiles
{
	public class MagicDirt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MagicDirt");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.BallofFire);
			aiType = ProjectileID.BallofFire;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.BallofFire;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 0; i++)
			{
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 13f, Main.rand.Next(-7, 8) * .23f, Main.rand.Next(-7, -2) * .22f, ProjectileID.BallofFire, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 8;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}

			public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(2) == 0)
			{
				target.AddBuff(BuffID.OnFire, 300);
			}
		}
	}
}