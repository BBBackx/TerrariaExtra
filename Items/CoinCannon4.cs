using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class CoinCannon4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Coin Cannon - Platinum");
            Tooltip.SetDefault("Top 10 richest people in the Terraria universe...");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 6;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 4;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.useAnimation = 4;
			item.shoot = ProjectileID.PlatinumCoin;
			item.value = Item.sellPrice(platinum: 3);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumCoin, 150);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(null, "CoinCannon1", 1);
			recipe.AddIngredient(null, "CoinCannon2", 1);
			recipe.AddIngredient(null, "CoinCannon3", 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}