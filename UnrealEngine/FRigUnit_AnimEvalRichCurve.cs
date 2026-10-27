using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200054C RID: 1356
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AnimEvalRichCurve")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_AnimEvalRichCurve : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060047A5 RID: 18341 RVA: 0x0006A5E0 File Offset: 0x000687E0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AnimEvalRichCurve._ScriptStructPtr != 0) ? FRigUnit_AnimEvalRichCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AnimEvalRichCurve", ref FRigUnit_AnimEvalRichCurve._ScriptStructPtr);
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x0006A604 File Offset: 0x00068804
		// (set) Token: 0x060047A7 RID: 18343 RVA: 0x0006A614 File Offset: 0x00068814
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x0006A628 File Offset: 0x00068828
		// (set) Token: 0x060047A9 RID: 18345 RVA: 0x0006A66B File Offset: 0x0006886B
		public FRuntimeFloatCurve Curve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x0006A68C File Offset: 0x0006888C
		// (set) Token: 0x060047AB RID: 18347 RVA: 0x0006A69C File Offset: 0x0006889C
		public unsafe float SourceMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_SourceMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_SourceMinimum) = value;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060047AC RID: 18348 RVA: 0x0006A6AD File Offset: 0x000688AD
		// (set) Token: 0x060047AD RID: 18349 RVA: 0x0006A6BD File Offset: 0x000688BD
		public unsafe float SourceMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_SourceMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_SourceMaximum) = value;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x0006A6CE File Offset: 0x000688CE
		// (set) Token: 0x060047AF RID: 18351 RVA: 0x0006A6DE File Offset: 0x000688DE
		public unsafe float TargetMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_TargetMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_TargetMinimum) = value;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060047B0 RID: 18352 RVA: 0x0006A6EF File Offset: 0x000688EF
		// (set) Token: 0x060047B1 RID: 18353 RVA: 0x0006A6FF File Offset: 0x000688FF
		public unsafe float TargetMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_TargetMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_TargetMaximum) = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x0006A710 File Offset: 0x00068910
		// (set) Token: 0x060047B3 RID: 18355 RVA: 0x0006A720 File Offset: 0x00068920
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEvalRichCurve.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x0006A731 File Offset: 0x00068931
		public FRigUnit_AnimEvalRichCurve()
		{
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x0006A739 File Offset: 0x00068939
		public FRigUnit_AnimEvalRichCurve(float Value, FRuntimeFloatCurve Curve, float SourceMinimum, float SourceMaximum, float TargetMinimum, float TargetMaximum, float Result)
		{
			this.Value = Value;
			this.Curve = Curve;
			this.SourceMinimum = SourceMinimum;
			this.SourceMaximum = SourceMaximum;
			this.TargetMinimum = TargetMinimum;
			this.TargetMaximum = TargetMaximum;
			this.Result = Result;
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x0006A776 File Offset: 0x00068976
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AnimEvalRichCurve.StaticStruct();
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x0006A782 File Offset: 0x00068982
		[NullableContext(2)]
		public FRigUnit_AnimEvalRichCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x0006A78C File Offset: 0x0006898C
		public FRigUnit_AnimEvalRichCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x0006A797 File Offset: 0x00068997
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AnimEvalRichCurve(Pointer, false, true);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x0006A7A1 File Offset: 0x000689A1
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AnimEvalRichCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040022CE RID: 8910
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AnimEvalRichCurve";

		// Token: 0x040022CF RID: 8911
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022D0 RID: 8912
		internal static int __PropertyOffset_Value;

		// Token: 0x040022D1 RID: 8913
		internal static int __PropertyOffset_Curve;

		// Token: 0x040022D2 RID: 8914
		[Nullable(2)]
		private FRuntimeFloatCurve _Curve;

		// Token: 0x040022D3 RID: 8915
		internal static int __PropertyOffset_SourceMinimum;

		// Token: 0x040022D4 RID: 8916
		internal static int __PropertyOffset_SourceMaximum;

		// Token: 0x040022D5 RID: 8917
		internal static int __PropertyOffset_TargetMinimum;

		// Token: 0x040022D6 RID: 8918
		internal static int __PropertyOffset_TargetMaximum;

		// Token: 0x040022D7 RID: 8919
		internal static int __PropertyOffset_Result;
	}
}
