using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000794 RID: 1940
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineSettings.AutoCompleteCommand")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAutoCompleteCommand : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600650A RID: 25866 RVA: 0x00090E15 File Offset: 0x0008F015
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutoCompleteCommand._ScriptStructPtr != 0) ? FAutoCompleteCommand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineSettings.AutoCompleteCommand", ref FAutoCompleteCommand._ScriptStructPtr);
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x00090E39 File Offset: 0x0008F039
		// (set) Token: 0x0600650C RID: 25868 RVA: 0x00090E4D File Offset: 0x0008F04D
		public unsafe string Command
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutoCompleteCommand.__PropertyOffset_Command)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutoCompleteCommand.__PropertyOffset_Command)), value);
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x0600650D RID: 25869 RVA: 0x00090E62 File Offset: 0x0008F062
		// (set) Token: 0x0600650E RID: 25870 RVA: 0x00090E76 File Offset: 0x0008F076
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutoCompleteCommand.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutoCompleteCommand.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x00090E8B File Offset: 0x0008F08B
		public FAutoCompleteCommand()
		{
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x00090E93 File Offset: 0x0008F093
		public FAutoCompleteCommand(string Command, string Desc)
		{
			this.Command = Command;
			this.Desc = Desc;
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x00090EA9 File Offset: 0x0008F0A9
		protected override IntPtr GetUStructPtr()
		{
			return FAutoCompleteCommand.StaticStruct();
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x00090EB5 File Offset: 0x0008F0B5
		[NullableContext(2)]
		public FAutoCompleteCommand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x00090EBF File Offset: 0x0008F0BF
		public FAutoCompleteCommand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x00090ECA File Offset: 0x0008F0CA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutoCompleteCommand(Pointer, false, true);
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00090ED4 File Offset: 0x0008F0D4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutoCompleteCommand(Pointer, MemoryOwner);
		}

		// Token: 0x040030F1 RID: 12529
		public const string __ObjectPath = "/Script/EngineSettings.AutoCompleteCommand";

		// Token: 0x040030F2 RID: 12530
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030F3 RID: 12531
		internal static int __PropertyOffset_Command;

		// Token: 0x040030F4 RID: 12532
		internal static int __PropertyOffset_Desc;
	}
}
