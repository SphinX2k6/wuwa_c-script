using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002AFD RID: 11005
	[NullableContext(1)]
	[Nullable(0)]
	public class IConsoleManager
	{
		// Token: 0x0602848B RID: 165003 RVA: 0x003D49EC File Offset: 0x003D2BEC
		public static void RegisterConsoleCommand(string Name, string Help, Action Command, EConsoleVariableFlags Flags)
		{
			FSharpherealConsoleCommandDelegate fsharpherealConsoleCommandDelegate = new FSharpherealConsoleCommandDelegate();
			fsharpherealConsoleCommandDelegate.Bind(Command);
			UConsoleCommandBPL.RegisterConsoleCommand(Name, Help, fsharpherealConsoleCommandDelegate, (uint)Flags);
		}

		// Token: 0x0602848C RID: 165004 RVA: 0x003D4A10 File Offset: 0x003D2C10
		public static void RegisterConsoleCommand(string Name, string Help, FSharpherealConsoleCommandWithArgsDelegate.FSharpherealConsoleCommandWithArgsDelegate_ScriptDelegate Command, EConsoleVariableFlags Flags)
		{
			FSharpherealConsoleCommandWithArgsDelegate fsharpherealConsoleCommandWithArgsDelegate = new FSharpherealConsoleCommandWithArgsDelegate();
			fsharpherealConsoleCommandWithArgsDelegate.Bind(Command);
			UConsoleCommandBPL.RegisterConsoleCommandWithArgs(Name, Help, fsharpherealConsoleCommandWithArgsDelegate, (uint)Flags);
		}

		// Token: 0x0602848D RID: 165005 RVA: 0x003D4A34 File Offset: 0x003D2C34
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

		// Token: 0x0602848E RID: 165006 RVA: 0x003D4A58 File Offset: 0x003D2C58
		public static void RegisterConsoleCommand(string Name, string Help, FSharpherealConsoleCommandWithWorldAndArgsDelegate.FSharpherealConsoleCommandWithWorldAndArgsDelegate_ScriptDelegate Command, EConsoleVariableFlags Flags)
		{
			FSharpherealConsoleCommandWithWorldAndArgsDelegate fsharpherealConsoleCommandWithWorldAndArgsDelegate = new FSharpherealConsoleCommandWithWorldAndArgsDelegate();
			fsharpherealConsoleCommandWithWorldAndArgsDelegate.Bind(Command);
			UConsoleCommandBPL.RegisterConsoleCommandWithWorldAndArgs(Name, Help, fsharpherealConsoleCommandWithWorldAndArgsDelegate, (uint)Flags);
		}

		// Token: 0x0602848F RID: 165007 RVA: 0x003D4A7C File Offset: 0x003D2C7C
		public static bool GetConsoleBoolVariable(string Name)
		{
			bool result = false;
			if (!UConsoleCommandBPL.GetConsoleBoolVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x06028490 RID: 165008 RVA: 0x003D4A9C File Offset: 0x003D2C9C
		public static int GetConsoleIntVariable(string Name)
		{
			int result = 0;
			if (!UConsoleCommandBPL.GetConsoleIntVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x06028491 RID: 165009 RVA: 0x003D4ABC File Offset: 0x003D2CBC
		public static float GetConsoleFloatVariable(string Name)
		{
			float result = 0f;
			if (!UConsoleCommandBPL.GetConsoleFloatVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x06028492 RID: 165010 RVA: 0x003D4AE0 File Offset: 0x003D2CE0
		public static string GetConsoleStringVariable(string Name)
		{
			string result = null;
			if (!UConsoleCommandBPL.GetConsoleStringVariable(Name, ref result))
			{
				throw new KeyNotFoundException();
			}
			return result;
		}

		// Token: 0x06028493 RID: 165011 RVA: 0x003D4B00 File Offset: 0x003D2D00
		public static bool SetConsoleVariable(string Name, bool Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleBoolVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x06028494 RID: 165012 RVA: 0x003D4B0A File Offset: 0x003D2D0A
		public static bool SetConsoleVariable(string Name, int Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleIntVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x06028495 RID: 165013 RVA: 0x003D4B14 File Offset: 0x003D2D14
		public static bool SetConsoleVariable(string Name, float Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleFloatVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x06028496 RID: 165014 RVA: 0x003D4B1E File Offset: 0x003D2D1E
		public static bool SetConsoleVariable(string Name, string Value, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_SetByCode)
		{
			return UConsoleCommandBPL.SetConsoleStringVariable(Name, Value, (uint)Flags);
		}

		// Token: 0x06028497 RID: 165015 RVA: 0x003D4B28 File Offset: 0x003D2D28
		public static void RegisterConsoleVariable(string Name, bool DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleBoolVariable(Name, DefaultValue, Help, (uint)Flags);
		}

		// Token: 0x06028498 RID: 165016 RVA: 0x003D4B33 File Offset: 0x003D2D33
		public static void RegisterConsoleVariable(string Name, int DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleIntVariable(Name, DefaultValue, Help, (uint)Flags);
		}

		// Token: 0x06028499 RID: 165017 RVA: 0x003D4B3E File Offset: 0x003D2D3E
		public static void RegisterConsoleVariable(string Name, float DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleFloatVariable(Name, DefaultValue, Help, (uint)Flags);
		}

		// Token: 0x0602849A RID: 165018 RVA: 0x003D4B49 File Offset: 0x003D2D49
		public static void RegisterConsoleVariable(string Name, string DefaultValue, string Help, EConsoleVariableFlags Flags = EConsoleVariableFlags.ECVF_Default)
		{
			UConsoleCommandBPL.RegisterConsoleStringVariable(Name, DefaultValue, Help, (uint)Flags);
		}
	}
}
