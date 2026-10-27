using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016A5 RID: 5797
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroAutomationTsEditorCmd")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroAutomationTsEditorCmd : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015041 RID: 86081 RVA: 0x001EE222 File Offset: 0x001EC422
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAutomationTsEditorCmd._ScriptStructPtr != 0) ? FKuroAutomationTsEditorCmd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAutomationTool.KuroAutomationTsEditorCmd", ref FKuroAutomationTsEditorCmd._ScriptStructPtr);
		}

		// Token: 0x17005329 RID: 21289
		// (get) Token: 0x06015042 RID: 86082 RVA: 0x001EE246 File Offset: 0x001EC446
		// (set) Token: 0x06015043 RID: 86083 RVA: 0x001EE25A File Offset: 0x001EC45A
		public unsafe string Type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTsEditorCmd.__PropertyOffset_Type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroAutomationTsEditorCmd.__PropertyOffset_Type)), value);
			}
		}

		// Token: 0x1700532A RID: 21290
		// (get) Token: 0x06015044 RID: 86084 RVA: 0x001EE26F File Offset: 0x001EC46F
		// (set) Token: 0x06015045 RID: 86085 RVA: 0x001EE27F File Offset: 0x001EC47F
		public unsafe int TestServerPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAutomationTsEditorCmd.__PropertyOffset_TestServerPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAutomationTsEditorCmd.__PropertyOffset_TestServerPort) = value;
			}
		}

		// Token: 0x06015046 RID: 86086 RVA: 0x001EE290 File Offset: 0x001EC490
		public FKuroAutomationTsEditorCmd()
		{
		}

		// Token: 0x06015047 RID: 86087 RVA: 0x001EE298 File Offset: 0x001EC498
		public FKuroAutomationTsEditorCmd(string Type, int TestServerPort)
		{
			this.Type = Type;
			this.TestServerPort = TestServerPort;
		}

		// Token: 0x06015048 RID: 86088 RVA: 0x001EE2AE File Offset: 0x001EC4AE
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAutomationTsEditorCmd.StaticStruct();
		}

		// Token: 0x06015049 RID: 86089 RVA: 0x001EE2BA File Offset: 0x001EC4BA
		[NullableContext(2)]
		public FKuroAutomationTsEditorCmd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601504A RID: 86090 RVA: 0x001EE2C4 File Offset: 0x001EC4C4
		public FKuroAutomationTsEditorCmd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601504B RID: 86091 RVA: 0x001EE2CF File Offset: 0x001EC4CF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAutomationTsEditorCmd(Pointer, false, true);
		}

		// Token: 0x0601504C RID: 86092 RVA: 0x001EE2D9 File Offset: 0x001EC4D9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAutomationTsEditorCmd(Pointer, MemoryOwner);
		}

		// Token: 0x0400B716 RID: 46870
		public const string __ObjectPath = "/Script/KuroAutomationTool.KuroAutomationTsEditorCmd";

		// Token: 0x0400B717 RID: 46871
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B718 RID: 46872
		internal static int __PropertyOffset_Type;

		// Token: 0x0400B719 RID: 46873
		internal static int __PropertyOffset_TestServerPort;
	}
}
