using ModData;
using ModSettings;
using System.Reflection;

namespace CommunityChallenges
{
	public static class Settings
	{

		internal static readonly ModSettings ModSettings = new();
		internal static readonly ModDataManager DataManager = new(nameof(CommunityChallenges), false);

		public static void OnLoad()
		{
			ModSettings.AddToModSettings("Stream Utils");
		}
	}

	public class ModSettings : JsonModSettings
	{
		public ModSettings() : base(Path.Combine(Mod.BaseDirectory, "user-settings"))
		{
			RefreshAllFields();
		}

		protected override void OnConfirm()
		{
			base.OnConfirm();
		}

		protected override void OnChange(FieldInfo field, object? oldValue, object? newValue)
		{
			base.OnChange(field, oldValue, newValue);
		}

		public void RefreshAllFields()
		{

		}
	}
}
