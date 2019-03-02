using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Projectiles
{
	public class lmao : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("lol");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.DD2BetsyFireball);
			aiType = ProjectileID.DD2BetsyFireball;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.DD2BetsyFireball;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 0; i++)
			{
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 4f, Main.rand.Next(-3, 2) * .12f, Main.rand.Next(-3, -2) * .12f, ProjectileID.DD2BetsyFireball, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
}