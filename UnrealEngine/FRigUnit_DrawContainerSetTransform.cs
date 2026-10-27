using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005A2 RID: 1442
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DrawContainerSetTransform")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_DrawContainerSetTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D5B RID: 19803 RVA: 0x00072482 File Offset: 0x00070682
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DrawContainerSetTransform._ScriptStructPtr != 0) ? FRigUnit_DrawContainerSetTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DrawContainerSetTransform", ref FRigUnit_DrawContainerSetTransform._ScriptStructPtr);
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x000724A6 File Offset: 0x000706A6
		// (set) Token: 0x06004D5D RID: 19805 RVA: 0x000724BA File Offset: 0x000706BA
		public unsafe FName InstructionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetTransform.__PropertyOffset_InstructionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetTransform.__PropertyOffset_InstructionName) = value;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06004D5E RID: 19806 RVA: 0x000724CF File Offset: 0x000706CF
		// (set) Token: 0x06004D5F RID: 19807 RVA: 0x000724E3 File Offset: 0x000706E3
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x000724F8 File Offset: 0x000706F8
		public FRigUnit_DrawContainerSetTransform()
		{
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00072500 File Offset: 0x00070700
		[NullableContext(1)]
		public FRigUnit_DrawContainerSetTransform(FName InstructionName, FTransform Transform, FControlRigExecuteContext ExecuteContext)
		{
			this.InstructionName = InstructionName;
			this.Transform = Transform;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x0007251D File Offset: 0x0007071D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DrawContainerSetTransform.StaticStruct();
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00072529 File Offset: 0x00070729
		[NullableContext(2)]
		public FRigUnit_DrawContainerSetTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00072533 File Offset: 0x00070733
		public FRigUnit_DrawContainerSetTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x0007253E File Offset: 0x0007073E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DrawContainerSetTransform(Pointer, false, true);
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00072548 File Offset: 0x00070748
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DrawContainerSetTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0400255E RID: 9566
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DrawContainerSetTransform";

		// Token: 0x0400255F RID: 9567
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002560 RID: 9568
		internal static int __PropertyOffset_InstructionName;

		// Token: 0x04002561 RID: 9569
		internal static int __PropertyOffset_Transform;
	}
}
