using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006CA RID: 1738
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlVector2D_Entry")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRigUnit_SetMultiControlVector2D_Entry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CE7 RID: 23783 RVA: 0x000854D2 File Offset: 0x000836D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlVector2D_Entry._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlVector2D_Entry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlVector2D_Entry", ref FRigUnit_SetMultiControlVector2D_Entry._ScriptStructPtr);
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x000854F6 File Offset: 0x000836F6
		// (set) Token: 0x06005CE9 RID: 23785 RVA: 0x0008550A File Offset: 0x0008370A
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D_Entry.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D_Entry.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x0008551F File Offset: 0x0008371F
		// (set) Token: 0x06005CEB RID: 23787 RVA: 0x00085533 File Offset: 0x00083733
		public unsafe FVector2D Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D_Entry.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D_Entry.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x00085548 File Offset: 0x00083748
		public FRigUnit_SetMultiControlVector2D_Entry()
		{
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x00085550 File Offset: 0x00083750
		public FRigUnit_SetMultiControlVector2D_Entry(FName Control, FVector2D Vector)
		{
			this.Control = Control;
			this.Vector = Vector;
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x00085566 File Offset: 0x00083766
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlVector2D_Entry.StaticStruct();
		}

		// Token: 0x06005CEF RID: 23791 RVA: 0x00085572 File Offset: 0x00083772
		[NullableContext(2)]
		public FRigUnit_SetMultiControlVector2D_Entry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x0008557C File Offset: 0x0008377C
		public FRigUnit_SetMultiControlVector2D_Entry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00085587 File Offset: 0x00083787
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlVector2D_Entry(Pointer, false, true);
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x00085591 File Offset: 0x00083791
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlVector2D_Entry(Pointer, MemoryOwner);
		}

		// Token: 0x04002B77 RID: 11127
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlVector2D_Entry";

		// Token: 0x04002B78 RID: 11128
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B79 RID: 11129
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B7A RID: 11130
		internal static int __PropertyOffset_Vector;
	}
}
