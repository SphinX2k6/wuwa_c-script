using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000614 RID: 1556
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatTan")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatTan : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005362 RID: 21346 RVA: 0x00079C48 File Offset: 0x00077E48
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatTan._ScriptStructPtr != 0) ? FRigUnit_MathFloatTan._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatTan", ref FRigUnit_MathFloatTan._ScriptStructPtr);
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00079C6C File Offset: 0x00077E6C
		public FRigUnit_MathFloatTan()
		{
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00079C74 File Offset: 0x00077E74
		public FRigUnit_MathFloatTan(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00079C8A File Offset: 0x00077E8A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatTan.StaticStruct();
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00079C96 File Offset: 0x00077E96
		[NullableContext(2)]
		public FRigUnit_MathFloatTan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x00079CA0 File Offset: 0x00077EA0
		public FRigUnit_MathFloatTan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00079CAB File Offset: 0x00077EAB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatTan(Pointer, false, true);
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00079CB5 File Offset: 0x00077EB5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatTan(Pointer, MemoryOwner);
		}

		// Token: 0x040027CA RID: 10186
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatTan";

		// Token: 0x040027CB RID: 10187
		private static IntPtr _ScriptStructPtr;
	}
}
