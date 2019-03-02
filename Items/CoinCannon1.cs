using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class CoinCannon1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Coin Cannon - Copper");
            Tooltip.SetDefault("People who use this are probably homeless");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 1;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 4;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.useAnimation = 4;
			item.shoot = ProjectileID.CopperCoin;
			item.value = Item.sellPrice(copper: 5);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperCoin, 999);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}