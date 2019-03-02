using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class Paper : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to make books");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 33;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.AddTile(TileID.Sawmill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}