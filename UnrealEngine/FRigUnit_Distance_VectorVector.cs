using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000598 RID: 1432
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Distance_VectorVector")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_Distance_VectorVector : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CD1 RID: 19665 RVA: 0x0007190C File Offset: 0x0006FB0C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Distance_VectorVector._ScriptStructPtr != 0) ? FRigUnit_Distance_VectorVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Distance_VectorVector", ref FRigUnit_Distance_VectorVector._ScriptStructPtr);
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x00071930 File Offset: 0x0006FB30
		// (set) Token: 0x06004CD3 RID: 19667 RVA: 0x00071944 File Offset: 0x0006FB44
		public unsafe FVector Argument0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Distance_VectorVector.__PropertyOffset_Argument0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Distance_VectorVector.__PropertyOffset_Argument0) = value;
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x00071959 File Offset: 0x0006FB59
		// (set) Token: 0x06004CD5 RID: 19669 RVA: 0x0007196D File Offset: 0x0006FB6D
		public unsafe FVector Argument1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Distance_VectorVector.__PropertyOffset_Argument1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Distance_VectorVector.__PropertyOffset_Argument1) = value;
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x00071982 File Offset: 0x0006FB82
		// (set) Token: 0x06004CD7 RID: 19671 RVA: 0x00071992 File Offset: 0x0006FB92
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Distance_VectorVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Distance_VectorVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x000719A3 File Offset: 0x0006FBA3
		public FRigUnit_Distance_VectorVector()
		{
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x000719AB File Offset: 0x0006FBAB
		public FRigUnit_Distance_VectorVector(FVector Argument0, FVector Argument1, float Result)
		{
			this.Argument0 = Argument0;
			this.Argument1 = Argument1;
			this.Result = Result;
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x000719C8 File Offset: 0x0006FBC8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Distance_VectorVector.StaticStruct();
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x000719D4 File Offset: 0x0006FBD4
		[NullableContext(2)]
		public FRigUnit_Distance_VectorVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x000719DE File Offset: 0x0006FBDE
		public FRigUnit_Distance_VectorVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x000719E9 File Offset: 0x0006FBE9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Distance_VectorVector(Pointer, false, true);
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x000719F3 File Offset: 0x0006FBF3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Distance_VectorVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002523 RID: 9507
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Distance_VectorVector";

		// Token: 0x04002524 RID: 9508
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002525 RID: 9509
		internal static int __PropertyOffset_Argument0;

		// Token: 0x04002526 RID: 9510
		internal static int __PropertyOffset_Argument1;

		// Token: 0x04002527 RID: 9511
		internal static int __PropertyOffset_Result;
	}
}
