using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class CraftingCultist : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crafting Cultist");
            Tooltip.SetDefault("This just doesn't seem right...");
		}

		public override void SetDefaults()
		{
			item.damage = 73;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 14;
			item.rare = 4;
			item.expert = false;
			item.width = 32;
			item.height = 28;
			item.useTime = 28;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.knockBack =11;
			item.shootSpeed = 28;
			item.useAnimation = 28;
			item.shoot = mod.ProjectileType("MSword");
			item.value = Item.sellPrice(gold: 8);
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MagicMiner", 1);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.Diamond, 20);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}