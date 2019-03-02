using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class TerraTome2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Tome");
            Tooltip.SetDefault("Call upon the 7 cursed balls of death!");
		}

		public override void SetDefaults()
		{
			item.damage = 62;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 18;
			item.rare = 7;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 34;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 34f;
			item.useAnimation = 34;
			item.shoot = mod.ProjectileType("NightJ");
			item.value = Item.sellPrice(gold: 12);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TrueNightBook", 1);
			recipe.AddIngredient(null, "TrueIronIntervention", 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

       	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightE"), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightH"), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightB"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightP"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightZ"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightP"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("HallowedGlass"), damage, knockBack, player.whoAmI);
			}
			return true;
		}
	}
}