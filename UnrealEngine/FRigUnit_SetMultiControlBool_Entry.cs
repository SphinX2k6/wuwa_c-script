using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C2 RID: 1730
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlBool_Entry")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_SetMultiControlBool_Entry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C7D RID: 23677 RVA: 0x00084C72 File Offset: 0x00082E72
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlBool_Entry._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlBool_Entry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlBool_Entry", ref FRigUnit_SetMultiControlBool_Entry._ScriptStructPtr);
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06005C7E RID: 23678 RVA: 0x00084C96 File Offset: 0x00082E96
		// (set) Token: 0x06005C7F RID: 23679 RVA: 0x00084CAA File Offset: 0x00082EAA
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlBool_Entry.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlBool_Entry.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x00084CBF File Offset: 0x00082EBF
		// (set) Token: 0x06005C81 RID: 23681 RVA: 0x00084CCF File Offset: 0x00082ECF
		public unsafe bool BoolValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlBool_Entry.__PropertyOffset_BoolValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlBool_Entry.__PropertyOffset_BoolValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x00084CE0 File Offset: 0x00082EE0
		public FRigUnit_SetMultiControlBool_Entry()
		{
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x00084CE8 File Offset: 0x00082EE8
		public FRigUnit_SetMultiControlBool_Entry(FName Control, bool BoolValue)
		{
			this.Control = Control;
			this.BoolValue = BoolValue;
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00084CFE File Offset: 0x00082EFE
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlBool_Entry.StaticStruct();
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x00084D0A File Offset: 0x00082F0A
		[NullableContext(2)]
		public FRigUnit_SetMultiControlBool_Entry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x00084D14 File Offset: 0x00082F14
		public FRigUnit_SetMultiControlBool_Entry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x00084D1F File Offset: 0x00082F1F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlBool_Entry(Pointer, false, true);
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00084D29 File Offset: 0x00082F29
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlBool_Entry(Pointer, MemoryOwner);
		}

		// Token: 0x04002B4A RID: 11082
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlBool_Entry";

		// Token: 0x04002B4B RID: 11083
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B4C RID: 11084
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B4D RID: 11085
		internal static int __PropertyOffset_BoolValue;
	}
}
