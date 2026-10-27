using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000609 RID: 1545
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatNegate")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatNegate : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052E8 RID: 21224 RVA: 0x000794B3 File Offset: 0x000776B3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatNegate._ScriptStructPtr != 0) ? FRigUnit_MathFloatNegate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatNegate", ref FRigUnit_MathFloatNegate._ScriptStructPtr);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x000794D7 File Offset: 0x000776D7
		public FRigUnit_MathFloatNegate()
		{
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x000794DF File Offset: 0x000776DF
		public FRigUnit_MathFloatNegate(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x000794F5 File Offset: 0x000776F5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatNegate.StaticStruct();
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00079501 File Offset: 0x00077701
		[NullableContext(2)]
		public FRigUnit_MathFloatNegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x0007950B File Offset: 0x0007770B
		public FRigUnit_MathFloatNegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00079516 File Offset: 0x00077716
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatNegate(Pointer, false, true);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00079520 File Offset: 0x00077720
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatNegate(Pointer, MemoryOwner);
		}

		// Token: 0x040027A3 RID: 10147
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatNegate";

		// Token: 0x040027A4 RID: 10148
		private static IntPtr _ScriptStructPtr;
	}
}
