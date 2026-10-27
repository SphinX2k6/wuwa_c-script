using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200060B RID: 1547
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatPow")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatPow : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052FE RID: 21246 RVA: 0x00079609 File Offset: 0x00077809
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatPow._ScriptStructPtr != 0) ? FRigUnit_MathFloatPow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatPow", ref FRigUnit_MathFloatPow._ScriptStructPtr);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0007962D File Offset: 0x0007782D
		public FRigUnit_MathFloatPow()
		{
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00079635 File Offset: 0x00077835
		public FRigUnit_MathFloatPow(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00079652 File Offset: 0x00077852
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatPow.StaticStruct();
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x0007965E File Offset: 0x0007785E
		[NullableContext(2)]
		public FRigUnit_MathFloatPow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00079668 File Offset: 0x00077868
		public FRigUnit_MathFloatPow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x00079673 File Offset: 0x00077873
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatPow(Pointer, false, true);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x0007967D File Offset: 0x0007787D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatPow(Pointer, MemoryOwner);
		}

		// Token: 0x040027AA RID: 10154
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatPow";

		// Token: 0x040027AB RID: 10155
		private static IntPtr _ScriptStructPtr;
	}
}
