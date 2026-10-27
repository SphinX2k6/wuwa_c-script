using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005A1 RID: 1441
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DrawContainerSetThickness")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRigUnit_DrawContainerSetThickness : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D4F RID: 19791 RVA: 0x000723BB File Offset: 0x000705BB
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DrawContainerSetThickness._ScriptStructPtr != 0) ? FRigUnit_DrawContainerSetThickness._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DrawContainerSetThickness", ref FRigUnit_DrawContainerSetThickness._ScriptStructPtr);
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x000723DF File Offset: 0x000705DF
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x000723F3 File Offset: 0x000705F3
		public unsafe FName InstructionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetThickness.__PropertyOffset_InstructionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetThickness.__PropertyOffset_InstructionName) = value;
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06004D52 RID: 19794 RVA: 0x00072408 File Offset: 0x00070608
		// (set) Token: 0x06004D53 RID: 19795 RVA: 0x00072418 File Offset: 0x00070618
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetThickness.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DrawContainerSetThickness.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00072429 File Offset: 0x00070629
		public FRigUnit_DrawContainerSetThickness()
		{
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x00072431 File Offset: 0x00070631
		[NullableContext(1)]
		public FRigUnit_DrawContainerSetThickness(FName InstructionName, float Thickness, FControlRigExecuteContext ExecuteContext)
		{
			this.InstructionName = InstructionName;
			this.Thickness = Thickness;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x0007244E File Offset: 0x0007064E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DrawContainerSetThickness.StaticStruct();
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x0007245A File Offset: 0x0007065A
		[NullableContext(2)]
		public FRigUnit_DrawContainerSetThickness(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00072464 File Offset: 0x00070664
		public FRigUnit_DrawContainerSetThickness(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x0007246F File Offset: 0x0007066F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DrawContainerSetThickness(Pointer, false, true);
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00072479 File Offset: 0x00070679
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DrawContainerSetThickness(Pointer, MemoryOwner);
		}

		// Token: 0x0400255A RID: 9562
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DrawContainerSetThickness";

		// Token: 0x0400255B RID: 9563
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400255C RID: 9564
		internal static int __PropertyOffset_InstructionName;

		// Token: 0x0400255D RID: 9565
		internal static int __PropertyOffset_Thickness;
	}
}
