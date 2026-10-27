using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000612 RID: 1554
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatSqrt")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatSqrt : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005352 RID: 21330 RVA: 0x00079B55 File Offset: 0x00077D55
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatSqrt._ScriptStructPtr != 0) ? FRigUnit_MathFloatSqrt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatSqrt", ref FRigUnit_MathFloatSqrt._ScriptStructPtr);
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00079B79 File Offset: 0x00077D79
		public FRigUnit_MathFloatSqrt()
		{
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00079B81 File Offset: 0x00077D81
		public FRigUnit_MathFloatSqrt(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00079B97 File Offset: 0x00077D97
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatSqrt.StaticStruct();
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00079BA3 File Offset: 0x00077DA3
		[NullableContext(2)]
		public FRigUnit_MathFloatSqrt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x00079BAD File Offset: 0x00077DAD
		public FRigUnit_MathFloatSqrt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x00079BB8 File Offset: 0x00077DB8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatSqrt(Pointer, false, true);
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00079BC2 File Offset: 0x00077DC2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatSqrt(Pointer, MemoryOwner);
		}

		// Token: 0x040027C6 RID: 10182
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatSqrt";

		// Token: 0x040027C7 RID: 10183
		private static IntPtr _ScriptStructPtr;
	}
}
