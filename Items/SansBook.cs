using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class SansBook : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bone Bomber+");
            Tooltip.SetDefault("+666% Attack power if you consumed calcium in the last 24 hours");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 12;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 32;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 32;
			item.useAnimation = 32;
			item.shoot = mod.ProjectileType("SBone");
			item.value = Item.sellPrice(gold: 2);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }    

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 5 + Main.rand.Next(1); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(180);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 180f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
	}
}