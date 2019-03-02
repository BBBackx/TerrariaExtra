using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaExtra.Items
{
	public class Explode : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("/Explode");
            Tooltip.SetDefault("Not to be messed around with!");
		}

		public override void SetDefaults()
		{
			item.damage = 999;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 11;
			item.expert = false;
			item.width = 28;
			item.height = 30;
			item.useTime = 4;
			item.UseSound = SoundID.Item11;
			item.useStyle = 5;
			item.shootSpeed = 4f;
			item.useAnimation = 4;
			item.shoot = mod.ProjectileType("lmao");
			item.value = Item.sellPrice(platinum: 40);
			item.autoReuse = true;
		}
	}
}