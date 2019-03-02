using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class BookofSnow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Winter Wonderland");
            Tooltip.SetDefault("2 snowballs for the price of 1!");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 3;
			item.rare = 2;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 16;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 22;
			item.shoot = mod.ProjectileType("WSnowball");
			item.value = Item.sellPrice(gold: 2);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 3);
			recipe.AddIngredient(ItemID.Snowball, 50);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}