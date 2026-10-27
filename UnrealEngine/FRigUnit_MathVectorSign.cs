using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200068A RID: 1674
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorSign")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorSign : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005909 RID: 22793 RVA: 0x0008013A File Offset: 0x0007E33A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorSign._ScriptStructPtr != 0) ? FRigUnit_MathVectorSign._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorSign", ref FRigUnit_MathVectorSign._ScriptStructPtr);
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x0008015E File Offset: 0x0007E35E
		public FRigUnit_MathVectorSign()
		{
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00080166 File Offset: 0x0007E366
		public FRigUnit_MathVectorSign(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x0008017C File Offset: 0x0007E37C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorSign.StaticStruct();
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00080188 File Offset: 0x0007E388
		[NullableContext(2)]
		public FRigUnit_MathVectorSign(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x00080192 File Offset: 0x0007E392
		public FRigUnit_MathVectorSign(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x0008019D File Offset: 0x0007E39D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorSign(Pointer, false, true);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x000801A7 File Offset: 0x0007E3A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorSign(Pointer, MemoryOwner);
		}

		// Token: 0x040029C6 RID: 10694
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorSign";

		// Token: 0x040029C7 RID: 10695
		private static IntPtr _ScriptStructPtr;
	}
}
