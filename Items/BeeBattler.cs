using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class BeeBattler : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bee Battler");
            Tooltip.SetDefault("#RightsForBees!");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 3;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 7;
			item.UseSound = SoundID.Item11;
			item.useStyle = 7;
			item.shootSpeed = 7f;
			item.useAnimation = 4;
			item.shoot = ProjectileID.GiantBee;
			item.value = Item.sellPrice(gold: 3);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 14);
			recipe.AddIngredient(ItemID.HoneyBlock, 14);
            recipe.AddIngredient(ItemID.Hive, 14);
            recipe.AddIngredient(ItemID.Stinger, 8);
            recipe.AddIngredient(ItemID.HoneyBucket, 2);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(null, "StingerStorm", 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}