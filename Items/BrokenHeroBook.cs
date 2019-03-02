using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class BrokenHeroBook : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Old and dusty, it's impossible to read what was once written here");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 32;
			item.maxStack = 1;
			item.value = 100;
			item.rare = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Bookifier", 1);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}