using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class FlameSpitter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flame Spitter");
            Tooltip.SetDefault("Like a flamethrower, but it's a book!"			
			+ "\nUses Gel and Mana");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Flamethrower);
			item.damage = 12;
			item.width = 28;
			item.height = 30;
			item.mana = 6;
			item.crit = 2;
			item.knockBack = 2;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeGun, 1);
			recipe.AddIngredient(ItemID.Gel, 20);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}