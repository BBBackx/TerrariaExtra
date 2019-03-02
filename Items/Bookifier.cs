using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class Bookifier : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Makes some items into books");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 22;
			item.maxStack = 1;
			item.value = 100;
			item.rare = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}