using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000548 RID: 1352
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AlphaInterpVector")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FRigUnit_AlphaInterpVector : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600475A RID: 18266 RVA: 0x00069FE4 File Offset: 0x000681E4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AlphaInterpVector._ScriptStructPtr != 0) ? FRigUnit_AlphaInterpVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AlphaInterpVector", ref FRigUnit_AlphaInterpVector._ScriptStructPtr);
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x0006A008 File Offset: 0x00068208
		// (set) Token: 0x0600475C RID: 18268 RVA: 0x0006A01C File Offset: 0x0006821C
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x0006A031 File Offset: 0x00068231
		// (set) Token: 0x0600475E RID: 18270 RVA: 0x0006A041 File Offset: 0x00068241
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x0006A052 File Offset: 0x00068252
		// (set) Token: 0x06004760 RID: 18272 RVA: 0x0006A062 File Offset: 0x00068262
		public unsafe float Bias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Bias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Bias) = value;
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x0006A073 File Offset: 0x00068273
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x0006A083 File Offset: 0x00068283
		public unsafe bool bMapRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_bMapRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_bMapRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x0006A094 File Offset: 0x00068294
		// (set) Token: 0x06004764 RID: 18276 RVA: 0x0006A0D7 File Offset: 0x000682D7
		public FInputRange InRange
		{
			get
			{
				base.FastCheckIsValid();
				FInputRange result;
				if ((result = this._InRange) == null)
				{
					result = (this._InRange = new FInputRange(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_InRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputRange.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_InRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x0006A0F8 File Offset: 0x000682F8
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x0006A13B File Offset: 0x0006833B
		public FInputRange OutRange
		{
			get
			{
				base.FastCheckIsValid();
				FInputRange result;
				if ((result = this._OutRange) == null)
				{
					result = (this._OutRange = new FInputRange(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_OutRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputRange.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_OutRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x0006A15C File Offset: 0x0006835C
		// (set) Token: 0x06004768 RID: 18280 RVA: 0x0006A16C File Offset: 0x0006836C
		public unsafe bool bClampResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_bClampResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_bClampResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x0006A17D File Offset: 0x0006837D
		// (set) Token: 0x0600476A RID: 18282 RVA: 0x0006A18D File Offset: 0x0006838D
		public unsafe float ClampMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_ClampMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_ClampMin) = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x0006A19E File Offset: 0x0006839E
		// (set) Token: 0x0600476C RID: 18284 RVA: 0x0006A1AE File Offset: 0x000683AE
		public unsafe float ClampMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_ClampMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_ClampMax) = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x0006A1BF File Offset: 0x000683BF
		// (set) Token: 0x0600476E RID: 18286 RVA: 0x0006A1CF File Offset: 0x000683CF
		public unsafe bool bInterpResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_bInterpResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_bInterpResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x0006A1E0 File Offset: 0x000683E0
		// (set) Token: 0x06004770 RID: 18288 RVA: 0x0006A1F0 File Offset: 0x000683F0
		public unsafe float InterpSpeedIncreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_InterpSpeedIncreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_InterpSpeedIncreasing) = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06004771 RID: 18289 RVA: 0x0006A201 File Offset: 0x00068401
		// (set) Token: 0x06004772 RID: 18290 RVA: 0x0006A211 File Offset: 0x00068411
		public unsafe float InterpSpeedDecreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_InterpSpeedDecreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_InterpSpeedDecreasing) = value;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x0006A222 File Offset: 0x00068422
		// (set) Token: 0x06004774 RID: 18292 RVA: 0x0006A236 File Offset: 0x00068436
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x0006A24C File Offset: 0x0006844C
		// (set) Token: 0x06004776 RID: 18294 RVA: 0x0006A28F File Offset: 0x0006848F
		public FInputScaleBiasClamp ScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._ScaleBiasClamp) == null)
				{
					result = (this._ScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_ScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AlphaInterpVector.__PropertyOffset_ScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x0006A2B0 File Offset: 0x000684B0
		public FRigUnit_AlphaInterpVector()
		{
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x0006A2B8 File Offset: 0x000684B8
		public FRigUnit_AlphaInterpVector(FVector Value, float Scale, float Bias, bool bMapRange, FInputRange InRange, FInputRange OutRange, bool bClampResult, float ClampMin, float ClampMax, bool bInterpResult, float InterpSpeedIncreasing, float InterpSpeedDecreasing, FVector Result, FInputScaleBiasClamp ScaleBiasClamp)
		{
			this.Value = Value;
			this.Scale = Scale;
			this.Bias = Bias;
			this.bMapRange = bMapRange;
			this.InRange = InRange;
			this.OutRange = OutRange;
			this.bClampResult = bClampResult;
			this.ClampMin = ClampMin;
			this.ClampMax = ClampMax;
			this.bInterpResult = bInterpResult;
			this.InterpSpeedIncreasing = InterpSpeedIncreasing;
			this.InterpSpeedDecreasing = InterpSpeedDecreasing;
			this.Result = Result;
			this.ScaleBiasClamp = ScaleBiasClamp;
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x0006A338 File Offset: 0x00068538
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AlphaInterpVector.StaticStruct();
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x0006A344 File Offset: 0x00068544
		[NullableContext(2)]
		public FRigUnit_AlphaInterpVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x0006A34E File Offset: 0x0006854E
		public FRigUnit_AlphaInterpVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x0006A359 File Offset: 0x00068559
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AlphaInterpVector(Pointer, false, true);
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x0006A363 File Offset: 0x00068563
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AlphaInterpVector(Pointer, MemoryOwner);
		}

		// Token: 0x040022AD RID: 8877
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AlphaInterpVector";

		// Token: 0x040022AE RID: 8878
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022AF RID: 8879
		internal static int __PropertyOffset_Value;

		// Token: 0x040022B0 RID: 8880
		internal static int __PropertyOffset_Scale;

		// Token: 0x040022B1 RID: 8881
		internal static int __PropertyOffset_Bias;

		// Token: 0x040022B2 RID: 8882
		internal static int __PropertyOffset_bMapRange;

		// Token: 0x040022B3 RID: 8883
		internal static int __PropertyOffset_InRange;

		// Token: 0x040022B4 RID: 8884
		[Nullable(2)]
		private FInputRange _InRange;

		// Token: 0x040022B5 RID: 8885
		internal static int __PropertyOffset_OutRange;

		// Token: 0x040022B6 RID: 8886
		[Nullable(2)]
		private FInputRange _OutRange;

		// Token: 0x040022B7 RID: 8887
		internal static int __PropertyOffset_bClampResult;

		// Token: 0x040022B8 RID: 8888
		internal static int __PropertyOffset_ClampMin;

		// Token: 0x040022B9 RID: 8889
		internal static int __PropertyOffset_ClampMax;

		// Token: 0x040022BA RID: 8890
		internal static int __PropertyOffset_bInterpResult;

		// Token: 0x040022BB RID: 8891
		internal static int __PropertyOffset_InterpSpeedIncreasing;

		// Token: 0x040022BC RID: 8892
		internal static int __PropertyOffset_InterpSpeedDecreasing;

		// Token: 0x040022BD RID: 8893
		internal static int __PropertyOffset_Result;

		// Token: 0x040022BE RID: 8894
		internal static int __PropertyOffset_ScaleBiasClamp;

		// Token: 0x040022BF RID: 8895
		[Nullable(2)]
		private FInputScaleBiasClamp _ScaleBiasClamp;
	}
}
