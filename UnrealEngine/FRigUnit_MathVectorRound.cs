using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000686 RID: 1670
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorRound")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorRound : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060058D5 RID: 22741 RVA: 0x0007FDC3 File Offset: 0x0007DFC3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorRound._ScriptStructPtr != 0) ? FRigUnit_MathVectorRound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorRound", ref FRigUnit_MathVectorRound._ScriptStructPtr);
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x0007FDE7 File Offset: 0x0007DFE7
		public FRigUnit_MathVectorRound()
		{
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x0007FDEF File Offset: 0x0007DFEF
		public FRigUnit_MathVectorRound(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x0007FE05 File Offset: 0x0007E005
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorRound.StaticStruct();
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x0007FE11 File Offset: 0x0007E011
		[NullableContext(2)]
		public FRigUnit_MathVectorRound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x0007FE1B File Offset: 0x0007E01B
		public FRigUnit_MathVectorRound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x0007FE26 File Offset: 0x0007E026
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorRound(Pointer, false, true);
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x0007FE30 File Offset: 0x0007E030
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorRound(Pointer, MemoryOwner);
		}

		// Token: 0x040029B4 RID: 10676
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorRound";

		// Token: 0x040029B5 RID: 10677
		private static IntPtr _ScriptStructPtr;
	}
}
