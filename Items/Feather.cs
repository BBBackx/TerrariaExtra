using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class Feather : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Harpy Hazard");
            Tooltip.SetDefault("I thought you were gonna use those feathers for a pillow...");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 8;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 20f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("MagicFeather");
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 15);
			recipe.AddIngredient(ItemID.Cloud, 25);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}