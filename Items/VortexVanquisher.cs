using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class VortexVanquisher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Vanquisher");
            Tooltip.SetDefault("Hell yeah, lasers!");
		}

		public override void SetDefaults()
		{
			item.damage = 52;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 6;
			item.rare = 10;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 9;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 9f;
			item.useAnimation = 9;
			item.shoot = ProjectileID.MoonlordBullet;
			item.value = Item.sellPrice(gold: 11);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VortexBeater, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 6);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(3); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(40));
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
	}
}