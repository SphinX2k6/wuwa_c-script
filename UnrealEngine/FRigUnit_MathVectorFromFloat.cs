using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000674 RID: 1652
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorFromFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathVectorFromFloat : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057FB RID: 22523 RVA: 0x0007EF32 File Offset: 0x0007D132
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorFromFloat._ScriptStructPtr != 0) ? FRigUnit_MathVectorFromFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorFromFloat", ref FRigUnit_MathVectorFromFloat._ScriptStructPtr);
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060057FC RID: 22524 RVA: 0x0007EF56 File Offset: 0x0007D156
		// (set) Token: 0x060057FD RID: 22525 RVA: 0x0007EF66 File Offset: 0x0007D166
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorFromFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorFromFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060057FE RID: 22526 RVA: 0x0007EF77 File Offset: 0x0007D177
		// (set) Token: 0x060057FF RID: 22527 RVA: 0x0007EF8B File Offset: 0x0007D18B
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorFromFloat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorFromFloat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x0007EFA0 File Offset: 0x0007D1A0
		public FRigUnit_MathVectorFromFloat()
		{
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x0007EFA8 File Offset: 0x0007D1A8
		public FRigUnit_MathVectorFromFloat(float Value, FVector Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x0007EFBE File Offset: 0x0007D1BE
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorFromFloat.StaticStruct();
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x0007EFCA File Offset: 0x0007D1CA
		[NullableContext(2)]
		public FRigUnit_MathVectorFromFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x0007EFD4 File Offset: 0x0007D1D4
		public FRigUnit_MathVectorFromFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x0007EFDF File Offset: 0x0007D1DF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorFromFloat(Pointer, false, true);
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x0007EFE9 File Offset: 0x0007D1E9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorFromFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400296A RID: 10602
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorFromFloat";

		// Token: 0x0400296B RID: 10603
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400296C RID: 10604
		internal static int __PropertyOffset_Value;

		// Token: 0x0400296D RID: 10605
		internal static int __PropertyOffset_Result;
	}
}
