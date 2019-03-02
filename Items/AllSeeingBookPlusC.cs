using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class AllSeeingBookPlusC : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("All Seeing Book+");
            Tooltip.SetDefault("It sees more than everything...");
		}

		public override void SetDefaults()
		{
			item.damage = 86;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 22;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 72;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 72;
			item.useAnimation = 72;
			item.shoot = mod.ProjectileType("FriendlyEye");
			item.value = Item.sellPrice(gold: 2);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AllSeeingBookButCrimsonlol", 1);
			recipe.AddIngredient(ItemID.CrimtaneBar, 12);
			recipe.AddIngredient(ItemID.TissueSample, 8);
            recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}