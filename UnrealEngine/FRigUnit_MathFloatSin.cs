using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000611 RID: 1553
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatSin")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatSin : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600534A RID: 21322 RVA: 0x00079ADF File Offset: 0x00077CDF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatSin._ScriptStructPtr != 0) ? FRigUnit_MathFloatSin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatSin", ref FRigUnit_MathFloatSin._ScriptStructPtr);
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x00079B03 File Offset: 0x00077D03
		public FRigUnit_MathFloatSin()
		{
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00079B0B File Offset: 0x00077D0B
		public FRigUnit_MathFloatSin(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x00079B21 File Offset: 0x00077D21
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatSin.StaticStruct();
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00079B2D File Offset: 0x00077D2D
		[NullableContext(2)]
		public FRigUnit_MathFloatSin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00079B37 File Offset: 0x00077D37
		public FRigUnit_MathFloatSin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x00079B42 File Offset: 0x00077D42
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatSin(Pointer, false, true);
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00079B4C File Offset: 0x00077D4C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatSin(Pointer, MemoryOwner);
		}

		// Token: 0x040027C4 RID: 10180
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatSin";

		// Token: 0x040027C5 RID: 10181
		private static IntPtr _ScriptStructPtr;
	}
}
