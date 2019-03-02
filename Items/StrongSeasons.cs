using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class StrongSeasons : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strong Seasons");
            Tooltip.SetDefault("Climate change isn't real because it's cold outside");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 8;
			item.rare = 3;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 20f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("SCactus");
			item.value = Item.sellPrice(gold: 10);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BookofSnow", 1);
			recipe.AddIngredient(null, "SpringSprouter", 1);
			recipe.AddIngredient(null, "SummerSmoker", 1);
			recipe.AddIngredient(null, "AutumnAgression", 1);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

       	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("WSnowball"), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("ALeaf"), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SFlower"), damage, knockBack, player.whoAmI);
			}
			return true;
		}
	}
}