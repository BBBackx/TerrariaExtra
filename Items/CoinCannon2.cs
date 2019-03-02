using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class CoinCannon2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Coin Cannon - Silver");
            Tooltip.SetDefault("Able to afford food and an appartment");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 4;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.useAnimation = 4;
			item.shoot = ProjectileID.SilverCoin;
			item.value = Item.sellPrice(silver: 5);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverCoin, 999);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(null, "CoinCannon1", 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}