using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000635 RID: 1589
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionFromTwoVectors : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054D8 RID: 21720 RVA: 0x0007B3D4 File Offset: 0x000795D4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionFromTwoVectors._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionFromTwoVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors", ref FRigUnit_MathQuaternionFromTwoVectors._ScriptStructPtr);
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x0007B3F8 File Offset: 0x000795F8
		// (set) Token: 0x060054DA RID: 21722 RVA: 0x0007B40C File Offset: 0x0007960C
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromTwoVectors.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromTwoVectors.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x0007B421 File Offset: 0x00079621
		// (set) Token: 0x060054DC RID: 21724 RVA: 0x0007B435 File Offset: 0x00079635
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromTwoVectors.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromTwoVectors.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x0007B44A File Offset: 0x0007964A
		// (set) Token: 0x060054DE RID: 21726 RVA: 0x0007B45E File Offset: 0x0007965E
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromTwoVectors.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromTwoVectors.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x0007B473 File Offset: 0x00079673
		public FRigUnit_MathQuaternionFromTwoVectors()
		{
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x0007B47B File Offset: 0x0007967B
		public FRigUnit_MathQuaternionFromTwoVectors(FVector A, FVector B, FQuat Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x0007B498 File Offset: 0x00079698
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionFromTwoVectors.StaticStruct();
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x0007B4A4 File Offset: 0x000796A4
		[NullableContext(2)]
		public FRigUnit_MathQuaternionFromTwoVectors(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x0007B4AE File Offset: 0x000796AE
		public FRigUnit_MathQuaternionFromTwoVectors(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x0007B4B9 File Offset: 0x000796B9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionFromTwoVectors(Pointer, false, true);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x0007B4C3 File Offset: 0x000796C3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionFromTwoVectors(Pointer, MemoryOwner);
		}

		// Token: 0x04002844 RID: 10308
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionFromTwoVectors";

		// Token: 0x04002845 RID: 10309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002846 RID: 10310
		internal static int __PropertyOffset_A;

		// Token: 0x04002847 RID: 10311
		internal static int __PropertyOffset_B;

		// Token: 0x04002848 RID: 10312
		internal static int __PropertyOffset_Result;
	}
}
