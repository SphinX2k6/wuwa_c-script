using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008AD RID: 2221
	[NullableContext(1)]
	[Nullable(0)]
	public class IConsoleManager
	{
		// Token: 0x0600BE45 RID: 48709 RVA: 0x0012FD48 File Offset: 0x0012DF48
		public static void RegisterConsoleCommand(string Name, string Help, Action Command, EConsoleVariableFlags Flags)
		{
			FSharpherealConsoleCommandDelegate fsharpherealConsoleCommandDelegate = new FSharpherealConsoleCommandDelegate();
			fsharpherealConsoleCommandDelegate.Bind(Command);
			UConsoleCommandBPL.RegisterConsoleCommand(Name, Help, fsharpherealConsoleCommandDelegate, (uint)Flags);
		}

		// Token: 0x0600BE46 RID: 48710 RVA: 0x0012FD6C File Offset: 0x0012DF6C
		public static void RegisterConsoleCommand(string Name, string Help, FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate Command, EConsoleVariableFlags Flags)
		{
			FSharpherealConsoleCommandWithArgsDelegate fsharpherealConsoleCommandWithArgsDelegate = new FSharpherealConsoleCommandWithArgsDelegate();
			fsharpherealConsoleCommandWithArgsDelegate.Bind(Command);
			UConsoleCommandBPL.RegisterConsoleCommandWithArgs(Name, Help, fsharpherealConsoleCommandWithArgsDelegate, (uint)Flags);
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x0012FD90 File Offset: 0x0012DF90
		public static void RegisterConsoleCommand(string Name, string Help, [Nullable(new byte[]
		{
			1,
			2
		})] Action<UWorld> Command, EConsoleVariableFlags Flags)
		{
			FSharpherealConsoleCommandWithWorldDelegate fsharpherealConsoleCommandWithWorldDelegate = new FSharpherealConsoleCommandWithWorldDelegate();
			fsharpherealConsoleCommandWithWorldDelegate.Bind(Command);
			UConsoleCommandBPL.RegisterConsoleCommandWithWorld(Name, Help, fsharpherealConsoleCommandWithWorldDelegate, (uint)Flags);
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x0012FDB4 File Offset: 0x0012DFB4
		public static void RegisterConsoleCommand(string Name, string Help, FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate Command, EConsoleVariableFlags Flags)
		{
			FSharpherealConsoleCommandWithWorldAndArgsDelegate fsharpherealConsoleCommandWithWorldAndArgsDelegate = new FSharpherealConsoleCommandWithWorldAndArgsDelegate();
			fsharpherealConsoleCommandWithWorldAndArgsDelegate.Bind(Command);
			UConsoleCommandBPL.RegisterConsoleCommandWithWorldAndArgs(Name, Help, fsharpherealConsoleCommandWithWorldAndArgsDelegate, (uint)Flags);
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x0012FDD8 File Offset: 0x0012DFD8
		public static bool GetConsoleBoolVariable(string Name)
		{
			bool result = false;
			if (!UConsoleCommandBPL.GetConsoleBoolVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x0012FDF8 File Offset: 0x0012DFF8
		public static int GetConsoleIntVariable(string Name)
		{
			int result = 0;
			if (!UConsoleCommandBPL.GetConsoleIntVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x0012FE18 File Offset: 0x0012E018
		public static float GetConsoleFloatVariable(string Name)
		{
			float result = 0f;
			if (!UConsoleCommandBPL.GetConsoleFloatVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x0600BE4C RID: 48716 RVA: 0x0012FE3C File Offset: 0x0012E03C
		public static string GetConsoleStringVariable(string Name)
		{
			string result = null;
			if (!UConsoleCommandBPL.GetConsoleStringVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x0600BE4D RID: 48717 RVA: 0x0012FE5C File Offset: 0x0012E05C
		public static bool SetConsoleVariable(string Name, bool Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleBoolVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x0600BE4E RID: 48718 RVA: 0x0012FE66 File Offset: 0x0012E066
		public static bool SetConsoleVariable(string Name, int Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleIntVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x0600BE4F RID: 48719 RVA: 0x0012FE70 File Offset: 0x0012E070
		public static bool SetConsoleVariable(string Name, float Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleFloatVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x0600BE50 RID: 48720 RVA: 0x0012FE7A File Offset: 0x0012E07A
		public static bool SetConsoleVariable(string Name, string Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleStringVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x0600BE51 RID: 48721 RVA: 0x0012FE84 File Offset: 0x0012E084
		public static void RegisterConsoleVariable(string Name, bool DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleBoolVariable(Name, DefaultValue, Help, (uint)Flags);
		}

		// Token: 0x0600BE52 RID: 48722 RVA: 0x0012FE8F File Offset: 0x0012E08F
		public static void RegisterConsoleVariable(string Name, int DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleIntVariable(Name, DefaultValue, Help, (uint)Flags);
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x0012FE9A File Offset: 0x0012E09A
		public static void RegisterConsoleVariable(string Name, float DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleFloatVariable(Name, DefaultValue, Help, (uint)Flags);
		}

		// Token: 0x0600BE54 RID: 48724 RVA: 0x0012FEA5 File Offset: 0x0012E0A5
		public static void RegisterConsoleVariable(string Name, string DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleStringVariable(Name, DefaultValue, Help, (uint)Flags);
		}
	}
}
