using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200078F RID: 1935
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineMessages.EngineServiceExecuteCommand")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FEngineServiceExecuteCommand : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060064CD RID: 25805 RVA: 0x000909BD File Offset: 0x0008EBBD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineServiceExecuteCommand._ScriptStructPtr != 0) ? FEngineServiceExecuteCommand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineMessages.EngineServiceExecuteCommand", ref FEngineServiceExecuteCommand._ScriptStructPtr);
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x000909E1 File Offset: 0x0008EBE1
		// (set) Token: 0x060064CF RID: 25807 RVA: 0x000909F5 File Offset: 0x0008EBF5
		public unsafe string Command
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceExecuteCommand.__PropertyOffset_Command)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceExecuteCommand.__PropertyOffset_Command)), value);
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x060064D0 RID: 25808 RVA: 0x00090A0A File Offset: 0x0008EC0A
		// (set) Token: 0x060064D1 RID: 25809 RVA: 0x00090A1E File Offset: 0x0008EC1E
		public unsafe string UserName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceExecuteCommand.__PropertyOffset_UserName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceExecuteCommand.__PropertyOffset_UserName)), value);
			}
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00090A33 File Offset: 0x0008EC33
		public FEngineServiceExecuteCommand()
		{
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x00090A3B File Offset: 0x0008EC3B
		public FEngineServiceExecuteCommand(string Command, string UserName)
		{
			this.Command = Command;
			this.UserName = UserName;
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00090A51 File Offset: 0x0008EC51
		protected override IntPtr GetUStructPtr()
		{
			return FEngineServiceExecuteCommand.StaticStruct();
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00090A5D File Offset: 0x0008EC5D
		[NullableContext(2)]
		public FEngineServiceExecuteCommand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x00090A67 File Offset: 0x0008EC67
		public FEngineServiceExecuteCommand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x00090A72 File Offset: 0x0008EC72
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineServiceExecuteCommand(Pointer, false, true);
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x00090A7C File Offset: 0x0008EC7C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineServiceExecuteCommand(Pointer, MemoryOwner);
		}

		// Token: 0x040030DB RID: 12507
		public const string __ObjectPath = "/Script/EngineMessages.EngineServiceExecuteCommand";

		// Token: 0x040030DC RID: 12508
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030DD RID: 12509
		internal static int __PropertyOffset_Command;

		// Token: 0x040030DE RID: 12510
		internal static int __PropertyOffset_UserName;
	}
}
