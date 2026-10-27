using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000671 RID: 1649
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorDot")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorDot : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057D7 RID: 22487 RVA: 0x0007ECDC File Offset: 0x0007CEDC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorDot._ScriptStructPtr != 0) ? FRigUnit_MathVectorDot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorDot", ref FRigUnit_MathVectorDot._ScriptStructPtr);
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060057D8 RID: 22488 RVA: 0x0007ED00 File Offset: 0x0007CF00
		// (set) Token: 0x060057D9 RID: 22489 RVA: 0x0007ED14 File Offset: 0x0007CF14
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorDot.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorDot.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060057DA RID: 22490 RVA: 0x0007ED29 File Offset: 0x0007CF29
		// (set) Token: 0x060057DB RID: 22491 RVA: 0x0007ED3D File Offset: 0x0007CF3D
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorDot.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorDot.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060057DC RID: 22492 RVA: 0x0007ED52 File Offset: 0x0007CF52
		// (set) Token: 0x060057DD RID: 22493 RVA: 0x0007ED62 File Offset: 0x0007CF62
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorDot.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorDot.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x0007ED73 File Offset: 0x0007CF73
		public FRigUnit_MathVectorDot()
		{
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x0007ED7B File Offset: 0x0007CF7B
		public FRigUnit_MathVectorDot(FVector A, FVector B, float Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x0007ED98 File Offset: 0x0007CF98
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorDot.StaticStruct();
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x0007EDA4 File Offset: 0x0007CFA4
		[NullableContext(2)]
		public FRigUnit_MathVectorDot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x0007EDAE File Offset: 0x0007CFAE
		public FRigUnit_MathVectorDot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x0007EDB9 File Offset: 0x0007CFB9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorDot(Pointer, false, true);
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x0007EDC3 File Offset: 0x0007CFC3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorDot(Pointer, MemoryOwner);
		}

		// Token: 0x0400295E RID: 10590
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorDot";

		// Token: 0x0400295F RID: 10591
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002960 RID: 10592
		internal static int __PropertyOffset_A;

		// Token: 0x04002961 RID: 10593
		internal static int __PropertyOffset_B;

		// Token: 0x04002962 RID: 10594
		internal static int __PropertyOffset_Result;
	}
}
