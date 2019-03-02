using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class MagicMiner : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Miner");
            Tooltip.SetDefault("I don't think this is the right game");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 11;
			item.rare = 4;
			item.expert = false;
			item.width = 32;
			item.height = 28;
			item.useTime = 28;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.knockBack = 8;
			item.shootSpeed = 28;
			item.useAnimation = 28;
			item.shoot = mod.ProjectileType("MDiamond");
			item.value = Item.sellPrice(gold: 4);
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 15);
			recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.Diamond, 20);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}