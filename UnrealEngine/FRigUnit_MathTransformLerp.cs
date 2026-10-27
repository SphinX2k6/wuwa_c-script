using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200065A RID: 1626
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformLerp")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_MathTransformLerp : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056B2 RID: 22194 RVA: 0x0007D883 File Offset: 0x0007BA83
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformLerp._ScriptStructPtr != 0) ? FRigUnit_MathTransformLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformLerp", ref FRigUnit_MathTransformLerp._ScriptStructPtr);
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060056B3 RID: 22195 RVA: 0x0007D8A7 File Offset: 0x0007BAA7
		// (set) Token: 0x060056B4 RID: 22196 RVA: 0x0007D8BB File Offset: 0x0007BABB
		public unsafe FTransform A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060056B5 RID: 22197 RVA: 0x0007D8D0 File Offset: 0x0007BAD0
		// (set) Token: 0x060056B6 RID: 22198 RVA: 0x0007D8E4 File Offset: 0x0007BAE4
		public unsafe FTransform B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060056B7 RID: 22199 RVA: 0x0007D8F9 File Offset: 0x0007BAF9
		// (set) Token: 0x060056B8 RID: 22200 RVA: 0x0007D909 File Offset: 0x0007BB09
		public unsafe float T
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_T);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_T) = value;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060056B9 RID: 22201 RVA: 0x0007D91A File Offset: 0x0007BB1A
		// (set) Token: 0x060056BA RID: 22202 RVA: 0x0007D92E File Offset: 0x0007BB2E
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x0007D943 File Offset: 0x0007BB43
		public FRigUnit_MathTransformLerp()
		{
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x0007D94B File Offset: 0x0007BB4B
		public FRigUnit_MathTransformLerp(FTransform A, FTransform B, float T, FTransform Result)
		{
			this.A = A;
			this.B = B;
			this.T = T;
			this.Result = Result;
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x0007D970 File Offset: 0x0007BB70
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformLerp.StaticStruct();
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x0007D97C File Offset: 0x0007BB7C
		[NullableContext(2)]
		public FRigUnit_MathTransformLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x0007D986 File Offset: 0x0007BB86
		public FRigUnit_MathTransformLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x0007D991 File Offset: 0x0007BB91
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformLerp(Pointer, false, true);
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x0007D99B File Offset: 0x0007BB9B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformLerp(Pointer, MemoryOwner);
		}

		// Token: 0x040028F7 RID: 10487
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformLerp";

		// Token: 0x040028F8 RID: 10488
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028F9 RID: 10489
		internal static int __PropertyOffset_A;

		// Token: 0x040028FA RID: 10490
		internal static int __PropertyOffset_B;

		// Token: 0x040028FB RID: 10491
		internal static int __PropertyOffset_T;

		// Token: 0x040028FC RID: 10492
		internal static int __PropertyOffset_Result;
	}
}
