using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Projectiles
{
	public class ALeaf : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Autumn Leaf");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Leaf);
			aiType = ProjectileID.Leaf;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.Leaf;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 0; i++)
			{
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 4f, Main.rand.Next(-3, 2) * .12f, Main.rand.Next(-3, -2) * .12f, ProjectileID.Leaf, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}

			public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(2) == 0)
			{
				target.AddBuff(BuffID.Confused, 300);
			}
		}
	}
}