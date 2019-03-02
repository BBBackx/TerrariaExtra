using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class StardustStriker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stardust Striker");
            Tooltip.SetDefault("The Debuff Deluxe Pack!");
		}

		public override void SetDefaults()
		{
			item.damage = 66;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 10;
			item.rare = 10;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 19;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 19;
			item.useAnimation = 19;
			item.shoot = mod.ProjectileType("SG");
			item.value = Item.sellPrice(gold: 10);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentStardust, 12);
            recipe.AddIngredient(ItemID.FragmentNebula, 6);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.Grenade, 99);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}