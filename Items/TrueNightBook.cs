using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class TrueNightBook : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Night Necromancer");
            Tooltip.SetDefault("Call upon the 6 cursed balls of death!");
		}

		public override void SetDefaults()
		{
			item.damage = 55;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 16;
			item.rare = 6;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 38;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 38f;
			item.useAnimation = 38;
			item.shoot = mod.ProjectileType("NightJ");
			item.value = Item.sellPrice(gold: 10);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BrokenHeroBook", 1);
			recipe.AddIngredient(null, "NightBook", 1);
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
			}
			return true;
		}
	}
}