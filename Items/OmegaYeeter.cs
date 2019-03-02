using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class OmegaYeeter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonlord's Mega Magic");
            Tooltip.SetDefault("Warning: Might lag your game!");
		}

		public override void SetDefaults()
		{
			item.damage = 111;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 40;
			item.rare = 11;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 50;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 50f;
			item.useAnimation = 50;
			item.shoot = mod.ProjectileType("NightJ");
			item.value = Item.sellPrice(platinum: 20);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TerraTome", 1);
			recipe.AddIngredient(null, "SpaceSorcery", 1);
            recipe.AddIngredient(null, "CombinedCrystals", 1);
            recipe.AddIngredient(null, "StrongSeasons", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
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
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("CC"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SC"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SG"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("IC"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NebulaRainbow"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("LunarFollow"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("CC"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("HallowedGlass"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SCactus"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("WSnowball"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("ALeaf"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SFlower"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Daybreak, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MoonlordBullet, damage, knockBack, player.whoAmI);
			}
			return true;
		}
	}
}