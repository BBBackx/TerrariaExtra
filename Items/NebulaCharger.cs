using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class NebulaCharger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Charger");
            Tooltip.SetDefault("Charge it up or shoot it right away!");
		}

		public override void SetDefaults()
		{
			item.damage = 118;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 7;
			item.rare = 10;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 13;
			item.UseSound = SoundID.Item30;
			item.useStyle = 5;
			item.shootSpeed = 13f;
			item.useAnimation = 13;
			item.shoot = mod.ProjectileType("NebulaRainbow");
			item.value = Item.sellPrice(gold: 10);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentNebula, 18);
			recipe.AddIngredient(ItemID.RainbowRod, 1);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}