using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000684 RID: 1668
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorRad")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorRad : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060058B7 RID: 22711 RVA: 0x0007FB99 File Offset: 0x0007DD99
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorRad._ScriptStructPtr != 0) ? FRigUnit_MathVectorRad._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorRad", ref FRigUnit_MathVectorRad._ScriptStructPtr);
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x0007FBBD File Offset: 0x0007DDBD
		public FRigUnit_MathVectorRad()
		{
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x0007FBC5 File Offset: 0x0007DDC5
		public FRigUnit_MathVectorRad(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x0007FBDB File Offset: 0x0007DDDB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorRad.StaticStruct();
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x0007FBE7 File Offset: 0x0007DDE7
		[NullableContext(2)]
		public FRigUnit_MathVectorRad(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x0007FBF1 File Offset: 0x0007DDF1
		public FRigUnit_MathVectorRad(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x0007FBFC File Offset: 0x0007DDFC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorRad(Pointer, false, true);
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x0007FC06 File Offset: 0x0007DE06
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorRad(Pointer, MemoryOwner);
		}

		// Token: 0x040029A9 RID: 10665
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorRad";

		// Token: 0x040029AA RID: 10666
		private static IntPtr _ScriptStructPtr;
	}
}
