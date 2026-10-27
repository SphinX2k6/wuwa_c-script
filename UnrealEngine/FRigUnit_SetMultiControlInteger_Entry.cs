using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C6 RID: 1734
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlInteger_Entry")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_SetMultiControlInteger_Entry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CB1 RID: 23729 RVA: 0x0008508A File Offset: 0x0008328A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlInteger_Entry._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlInteger_Entry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlInteger_Entry", ref FRigUnit_SetMultiControlInteger_Entry._ScriptStructPtr);
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06005CB2 RID: 23730 RVA: 0x000850AE File Offset: 0x000832AE
		// (set) Token: 0x06005CB3 RID: 23731 RVA: 0x000850C2 File Offset: 0x000832C2
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger_Entry.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger_Entry.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06005CB4 RID: 23732 RVA: 0x000850D7 File Offset: 0x000832D7
		// (set) Token: 0x06005CB5 RID: 23733 RVA: 0x000850E7 File Offset: 0x000832E7
		public unsafe int IntegerValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger_Entry.__PropertyOffset_IntegerValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger_Entry.__PropertyOffset_IntegerValue) = value;
			}
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x000850F8 File Offset: 0x000832F8
		public FRigUnit_SetMultiControlInteger_Entry()
		{
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x00085100 File Offset: 0x00083300
		public FRigUnit_SetMultiControlInteger_Entry(FName Control, int IntegerValue)
		{
			this.Control = Control;
			this.IntegerValue = IntegerValue;
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x00085116 File Offset: 0x00083316
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlInteger_Entry.StaticStruct();
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x00085122 File Offset: 0x00083322
		[NullableContext(2)]
		public FRigUnit_SetMultiControlInteger_Entry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x0008512C File Offset: 0x0008332C
		public FRigUnit_SetMultiControlInteger_Entry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x00085137 File Offset: 0x00083337
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlInteger_Entry(Pointer, false, true);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x00085141 File Offset: 0x00083341
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlInteger_Entry(Pointer, MemoryOwner);
		}

		// Token: 0x04002B60 RID: 11104
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlInteger_Entry";

		// Token: 0x04002B61 RID: 11105
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B62 RID: 11106
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B63 RID: 11107
		internal static int __PropertyOffset_IntegerValue;
	}
}
