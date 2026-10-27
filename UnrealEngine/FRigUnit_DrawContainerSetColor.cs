using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005A0 RID: 1440
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DrawContainerSetColor")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_DrawContainerSetColor : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D43 RID: 19779 RVA: 0x000722EC File Offset: 0x000704EC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DrawContainerSetColor._ScriptStructPtr != 0) ? FRigUnit_DrawContainerSetColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DrawContainerSetColor", ref FRigUnit_DrawContainerSetColor._ScriptStructPtr);
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06004D44 RID: 19780 RVA: 0x00072310 File Offset: 0x00070510
		// (set) Token: 0x06004D45 RID: 19781 RVA: 0x00072324 File Offset: 0x00070524
		public unsafe FName InstructionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetColor.__PropertyOffset_InstructionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetColor.__PropertyOffset_InstructionName) = value;
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x00072339 File Offset: 0x00070539
		// (set) Token: 0x06004D47 RID: 19783 RVA: 0x0007234D File Offset: 0x0007054D
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetColor.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetColor.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x00072362 File Offset: 0x00070562
		public FRigUnit_DrawContainerSetColor()
		{
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x0007236A File Offset: 0x0007056A
		[NullableContext(1)]
		public FRigUnit_DrawContainerSetColor(FName InstructionName, FLinearColor Color, FControlRigExecuteContext ExecuteContext)
		{
			this.InstructionName = InstructionName;
			this.Color = Color;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00072387 File Offset: 0x00070587
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DrawContainerSetColor.StaticStruct();
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x00072393 File Offset: 0x00070593
		[NullableContext(2)]
		public FRigUnit_DrawContainerSetColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x0007239D File Offset: 0x0007059D
		public FRigUnit_DrawContainerSetColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x000723A8 File Offset: 0x000705A8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DrawContainerSetColor(Pointer, false, true);
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x000723B2 File Offset: 0x000705B2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DrawContainerSetColor(Pointer, MemoryOwner);
		}

		// Token: 0x04002556 RID: 9558
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DrawContainerSetColor";

		// Token: 0x04002557 RID: 9559
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002558 RID: 9560
		internal static int __PropertyOffset_InstructionName;

		// Token: 0x04002559 RID: 9561
		internal static int __PropertyOffset_Color;
	}
}
