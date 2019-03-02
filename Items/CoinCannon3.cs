using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class CoinCannon3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Coin Cannon - Gold");
            Tooltip.SetDefault("Able to buy expensive watches and big houses");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 4;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 4;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.useAnimation = 4;
			item.shoot = ProjectileID.GoldCoin;
			item.value = Item.sellPrice(gold: 5);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 999);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(null, "CoinCannon1", 1);
			recipe.AddIngredient(null, "CoinCannon2", 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}