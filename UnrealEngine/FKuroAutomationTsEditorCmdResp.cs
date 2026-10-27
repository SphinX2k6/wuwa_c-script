using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016A6 RID: 5798
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroAutomationTsEditorCmdResp")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroAutomationTsEditorCmdResp : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601504D RID: 86093 RVA: 0x001EE2E2 File Offset: 0x001EC4E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAutomationTsEditorCmdResp._ScriptStructPtr != 0) ? FKuroAutomationTsEditorCmdResp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAutomationTool.KuroAutomationTsEditorCmdResp", ref FKuroAutomationTsEditorCmdResp._ScriptStructPtr);
		}

		// Token: 0x1700532B RID: 21291
		// (get) Token: 0x0601504E RID: 86094 RVA: 0x001EE306 File Offset: 0x001EC506
		// (set) Token: 0x0601504F RID: 86095 RVA: 0x001EE31A File Offset: 0x001EC51A
		public unsafe string Type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTsEditorCmdResp.__PropertyOffset_Type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTsEditorCmdResp.__PropertyOffset_Type)), value);
			}
		}

		// Token: 0x1700532C RID: 21292
		// (get) Token: 0x06015050 RID: 86096 RVA: 0x001EE32F File Offset: 0x001EC52F
		// (set) Token: 0x06015051 RID: 86097 RVA: 0x001EE33F File Offset: 0x001EC53F
		public unsafe bool Success
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAutomationTsEditorCmdResp.__PropertyOffset_Success) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAutomationTsEditorCmdResp.__PropertyOffset_Success) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015052 RID: 86098 RVA: 0x001EE350 File Offset: 0x001EC550
		public FKuroAutomationTsEditorCmdResp()
		{
		}

		// Token: 0x06015053 RID: 86099 RVA: 0x001EE358 File Offset: 0x001EC558
		public FKuroAutomationTsEditorCmdResp(string Type, bool Success)
		{
			this.Type = Type;
			this.Success = Success;
		}

		// Token: 0x06015054 RID: 86100 RVA: 0x001EE36E File Offset: 0x001EC56E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAutomationTsEditorCmdResp.StaticStruct();
		}

		// Token: 0x06015055 RID: 86101 RVA: 0x001EE37A File Offset: 0x001EC57A
		[NullableContext(2)]
		public FKuroAutomationTsEditorCmdResp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015056 RID: 86102 RVA: 0x001EE384 File Offset: 0x001EC584
		public FKuroAutomationTsEditorCmdResp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015057 RID: 86103 RVA: 0x001EE38F File Offset: 0x001EC58F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAutomationTsEditorCmdResp(Pointer, false, true);
		}

		// Token: 0x06015058 RID: 86104 RVA: 0x001EE399 File Offset: 0x001EC599
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAutomationTsEditorCmdResp(Pointer, MemoryOwner);
		}

		// Token: 0x0400B71A RID: 46874
		public const string __ObjectPath = "/Script/KuroAutomationTool.KuroAutomationTsEditorCmdResp";

		// Token: 0x0400B71B RID: 46875
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B71C RID: 46876
		internal static int __PropertyOffset_Type;

		// Token: 0x0400B71D RID: 46877
		internal static int __PropertyOffset_Success;
	}
}
