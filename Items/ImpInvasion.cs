using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class ImpInvasion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Imp Invasion");
            Tooltip.SetDefault("Eat like an Imp. Fight like an Imp. Be the Imp!");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 10;
			item.rare = 4;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 34;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 34f;
			item.useAnimation = 34;
			item.shoot = ProjectileID.ImpFireball;
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}