using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TerrariaExtra.Items
{
	public class TrueIronIntervention : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Hallowed Havoc");
            Tooltip.SetDefault("Shoots sharp pieces of hallowed bars"
            + "\nSome say getting hit by this is more painful than stepping on a 10 lego bricks at the same time");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 4;
			item.rare = 6;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 10;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 10;
			item.useAnimation = 10;
			item.shoot = mod.ProjectileType("HallowedGlass");
			item.value = Item.sellPrice(gold: 12);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "IronIntervention", 1);
            recipe.AddIngredient(null, "BrokenHeroBook", 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}    

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}
	}
}