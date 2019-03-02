using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class NightBookD : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Necromancer");
            Tooltip.SetDefault("Call upon the 4 cursed balls of death!");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 14;
			item.rare = 4;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 36;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 36f;
			item.useAnimation = 36;
			item.shoot = mod.ProjectileType("NightJ");
			item.value = Item.sellPrice(gold: 10);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SansBook", 1);
			recipe.AddIngredient(null, "BeeBattler", 1);
			recipe.AddIngredient(null, "ImpInvasionPlus", 1);
			recipe.AddIngredient(null, "AllSeeingBookPlusD", 1);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

       	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightE"), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightH"), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("NightB"), damage, knockBack, player.whoAmI);
			}
			return true;
		}
	}
}