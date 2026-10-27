using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200059F RID: 1439
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DrawContainerGetInstruction")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_DrawContainerGetInstruction : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D35 RID: 19765 RVA: 0x000721F4 File Offset: 0x000703F4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DrawContainerGetInstruction._ScriptStructPtr != 0) ? FRigUnit_DrawContainerGetInstruction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DrawContainerGetInstruction", ref FRigUnit_DrawContainerGetInstruction._ScriptStructPtr);
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x00072218 File Offset: 0x00070418
		// (set) Token: 0x06004D37 RID: 19767 RVA: 0x0007222C File Offset: 0x0007042C
		public unsafe FName InstructionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerGetInstruction.__PropertyOffset_InstructionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerGetInstruction.__PropertyOffset_InstructionName) = value;
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x00072241 File Offset: 0x00070441
		// (set) Token: 0x06004D39 RID: 19769 RVA: 0x00072255 File Offset: 0x00070455
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerGetInstruction.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerGetInstruction.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x0007226A File Offset: 0x0007046A
		// (set) Token: 0x06004D3B RID: 19771 RVA: 0x0007227E File Offset: 0x0007047E
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerGetInstruction.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerGetInstruction.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x00072293 File Offset: 0x00070493
		public FRigUnit_DrawContainerGetInstruction()
		{
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x0007229B File Offset: 0x0007049B
		public FRigUnit_DrawContainerGetInstruction(FName InstructionName, FLinearColor Color, FTransform Transform)
		{
			this.InstructionName = InstructionName;
			this.Color = Color;
			this.Transform = Transform;
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x000722B8 File Offset: 0x000704B8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DrawContainerGetInstruction.StaticStruct();
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x000722C4 File Offset: 0x000704C4
		[NullableContext(2)]
		public FRigUnit_DrawContainerGetInstruction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x000722CE File Offset: 0x000704CE
		public FRigUnit_DrawContainerGetInstruction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x000722D9 File Offset: 0x000704D9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DrawContainerGetInstruction(Pointer, false, true);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x000722E3 File Offset: 0x000704E3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DrawContainerGetInstruction(Pointer, MemoryOwner);
		}

		// Token: 0x04002551 RID: 9553
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DrawContainerGetInstruction";

		// Token: 0x04002552 RID: 9554
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002553 RID: 9555
		internal static int __PropertyOffset_InstructionName;

		// Token: 0x04002554 RID: 9556
		internal static int __PropertyOffset_Color;

		// Token: 0x04002555 RID: 9557
		internal static int __PropertyOffset_Transform;
	}
}
