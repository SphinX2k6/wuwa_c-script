using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000676 RID: 1654
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorIsNearlyZero")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorIsNearlyZero : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005817 RID: 22551 RVA: 0x0007F10B File Offset: 0x0007D30B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorIsNearlyZero._ScriptStructPtr != 0) ? FRigUnit_MathVectorIsNearlyZero._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorIsNearlyZero", ref FRigUnit_MathVectorIsNearlyZero._ScriptStructPtr);
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x0007F12F File Offset: 0x0007D32F
		// (set) Token: 0x06005819 RID: 22553 RVA: 0x0007F143 File Offset: 0x0007D343
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyZero.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyZero.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x0007F158 File Offset: 0x0007D358
		// (set) Token: 0x0600581B RID: 22555 RVA: 0x0007F168 File Offset: 0x0007D368
		public unsafe float Tolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyZero.__PropertyOffset_Tolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyZero.__PropertyOffset_Tolerance) = value;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x0007F179 File Offset: 0x0007D379
		// (set) Token: 0x0600581D RID: 22557 RVA: 0x0007F189 File Offset: 0x0007D389
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyZero.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyZero.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x0007F19A File Offset: 0x0007D39A
		public FRigUnit_MathVectorIsNearlyZero()
		{
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x0007F1A2 File Offset: 0x0007D3A2
		public FRigUnit_MathVectorIsNearlyZero(FVector Value, float Tolerance, bool Result)
		{
			this.Value = Value;
			this.Tolerance = Tolerance;
			this.Result = Result;
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x0007F1BF File Offset: 0x0007D3BF
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorIsNearlyZero.StaticStruct();
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x0007F1CB File Offset: 0x0007D3CB
		[NullableContext(2)]
		public FRigUnit_MathVectorIsNearlyZero(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x0007F1D5 File Offset: 0x0007D3D5
		public FRigUnit_MathVectorIsNearlyZero(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x0007F1E0 File Offset: 0x0007D3E0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorIsNearlyZero(Pointer, false, true);
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x0007F1EA File Offset: 0x0007D3EA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorIsNearlyZero(Pointer, MemoryOwner);
		}

		// Token: 0x04002974 RID: 10612
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorIsNearlyZero";

		// Token: 0x04002975 RID: 10613
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002976 RID: 10614
		internal static int __PropertyOffset_Value;

		// Token: 0x04002977 RID: 10615
		internal static int __PropertyOffset_Tolerance;

		// Token: 0x04002978 RID: 10616
		internal static int __PropertyOffset_Result;
	}
}
