using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class DayBreakDrama : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Daybreak Drama");
            Tooltip.SetDefault("You can't just turn a melee weapon into a magic one like that!");
		}

		public override void SetDefaults()
		{
			item.damage = 72;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 7;
			item.rare = 10;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 7;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 7f;
			item.useAnimation = 7;
			item.shoot = ProjectileID.Daybreak;
			item.value = Item.sellPrice(gold: 2);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DayBreak, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 6);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}