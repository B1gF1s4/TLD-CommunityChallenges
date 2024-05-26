using CommunityChallenges.Commands;
using MelonLoader;
using MelonLoader.Utils;

namespace CommunityChallenges
{
	public class Mod : MelonMod
	{
		public const string BaseDirectory = nameof(CommunityChallenges);

		public override void OnInitializeMelon()
		{
			base.OnInitializeMelon();

			Directory.CreateDirectory(Path.Combine(
				MelonEnvironment.ModsDirectory, BaseDirectory));

			CommandList.Init();

			Settings.OnLoad();
		}
	}
}
