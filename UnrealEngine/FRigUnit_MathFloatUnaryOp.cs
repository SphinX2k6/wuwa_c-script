using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000616 RID: 1558
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatUnaryOp")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatUnaryOp : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005376 RID: 21366 RVA: 0x00079D76 File Offset: 0x00077F76
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatUnaryOp._ScriptStructPtr != 0) ? FRigUnit_MathFloatUnaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatUnaryOp", ref FRigUnit_MathFloatUnaryOp._ScriptStructPtr);
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06005377 RID: 21367 RVA: 0x00079D9A File Offset: 0x00077F9A
		// (set) Token: 0x06005378 RID: 21368 RVA: 0x00079DAA File Offset: 0x00077FAA
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatUnaryOp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatUnaryOp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x00079DBB File Offset: 0x00077FBB
		// (set) Token: 0x0600537A RID: 21370 RVA: 0x00079DCB File Offset: 0x00077FCB
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatUnaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatUnaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x00079DDC File Offset: 0x00077FDC
		public FRigUnit_MathFloatUnaryOp()
		{
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x00079DE4 File Offset: 0x00077FE4
		public FRigUnit_MathFloatUnaryOp(float Value, float Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00079DFA File Offset: 0x00077FFA
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatUnaryOp.StaticStruct();
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00079E06 File Offset: 0x00078006
		[NullableContext(2)]
		public FRigUnit_MathFloatUnaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00079E10 File Offset: 0x00078010
		public FRigUnit_MathFloatUnaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00079E1B File Offset: 0x0007801B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatUnaryOp(Pointer, false, true);
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00079E25 File Offset: 0x00078025
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatUnaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x040027D0 RID: 10192
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatUnaryOp";

		// Token: 0x040027D1 RID: 10193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027D2 RID: 10194
		internal static int __PropertyOffset_Value;

		// Token: 0x040027D3 RID: 10195
		internal static int __PropertyOffset_Result;
	}
}
