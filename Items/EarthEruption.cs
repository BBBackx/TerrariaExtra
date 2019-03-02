using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class EarthEruption : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earth Eruption");
            Tooltip.SetDefault("Aaaahahah... that's hot, that's hot!");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 6;
			item.rare = 1;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 20f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("MagicDirt");
			item.value = Item.sellPrice(copper: 80);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 15);
			recipe.AddIngredient(ItemID.MudBlock, 15);
			recipe.AddIngredient(ItemID.FallenStar, 2);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}