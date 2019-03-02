using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Projectiles
{
	public class Slapper : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slapper");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.CannonballFriendly);
			aiType = ProjectileID.CannonballFriendly;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.CannonballFriendly;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 0; i++)
			{
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 4f, Main.rand.Next(-3, 2) * .12f, Main.rand.Next(-3, -2) * .12f, ProjectileID.CannonballFriendly, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
}