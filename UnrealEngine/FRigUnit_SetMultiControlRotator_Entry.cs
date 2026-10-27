using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C8 RID: 1736
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlRotator_Entry")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FRigUnit_SetMultiControlRotator_Entry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CCB RID: 23755 RVA: 0x00085296 File Offset: 0x00083496
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlRotator_Entry._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlRotator_Entry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlRotator_Entry", ref FRigUnit_SetMultiControlRotator_Entry._ScriptStructPtr);
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06005CCC RID: 23756 RVA: 0x000852BA File Offset: 0x000834BA
		// (set) Token: 0x06005CCD RID: 23757 RVA: 0x000852CE File Offset: 0x000834CE
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator_Entry.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator_Entry.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06005CCE RID: 23758 RVA: 0x000852E3 File Offset: 0x000834E3
		// (set) Token: 0x06005CCF RID: 23759 RVA: 0x000852F7 File Offset: 0x000834F7
		public unsafe FRotator Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator_Entry.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator_Entry.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06005CD0 RID: 23760 RVA: 0x0008530C File Offset: 0x0008350C
		// (set) Token: 0x06005CD1 RID: 23761 RVA: 0x0008531C File Offset: 0x0008351C
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator_Entry.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator_Entry.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x0008532D File Offset: 0x0008352D
		public FRigUnit_SetMultiControlRotator_Entry()
		{
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x00085335 File Offset: 0x00083535
		public FRigUnit_SetMultiControlRotator_Entry(FName Control, FRotator Rotator, EBoneGetterSetterMode Space)
		{
			this.Control = Control;
			this.Rotator = Rotator;
			this.Space = Space;
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x00085352 File Offset: 0x00083552
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlRotator_Entry.StaticStruct();
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x0008535E File Offset: 0x0008355E
		[NullableContext(2)]
		public FRigUnit_SetMultiControlRotator_Entry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x00085368 File Offset: 0x00083568
		public FRigUnit_SetMultiControlRotator_Entry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x00085373 File Offset: 0x00083573
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlRotator_Entry(Pointer, false, true);
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x0008537D File Offset: 0x0008357D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlRotator_Entry(Pointer, MemoryOwner);
		}

		// Token: 0x04002B6B RID: 11115
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlRotator_Entry";

		// Token: 0x04002B6C RID: 11116
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B6D RID: 11117
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B6E RID: 11118
		internal static int __PropertyOffset_Rotator;

		// Token: 0x04002B6F RID: 11119
		internal static int __PropertyOffset_Space;
	}
}
