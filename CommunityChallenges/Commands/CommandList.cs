namespace CommunityChallenges.Commands
{
	public static class CommandList
	{
		public static List<CommandBase> Commands = new();

		public static void Init()
		{
			// add commands to list

			// ...

			//

			foreach (var cmd in Commands)
			{
				cmd.AddToConsole();
			}
		}
	}
}
