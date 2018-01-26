using Terraria.ModLoader;

namespace TerrariaTestMod
{
	class TerrariaTestMod : Mod
	{
		public TerrariaTestMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
