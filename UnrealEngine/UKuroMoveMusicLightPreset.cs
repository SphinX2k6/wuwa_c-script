using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B79 RID: 7033
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMoveMusicLightPreset")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKuroMoveMusicLightPreset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AAF3 RID: 109299 RVA: 0x00275193 File Offset: 0x00273393
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMoveMusicLightPreset._ClassPtr;
		}

		// Token: 0x0601AAF4 RID: 109300 RVA: 0x002751A0 File Offset: 0x002733A0
		public UKuroMoveMusicLightPreset() : this(BuiltinUtils.AllocNativeUObject(UKuroMoveMusicLightPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AAF5 RID: 109301 RVA: 0x002751C8 File Offset: 0x002733C8
		public UKuroMoveMusicLightPreset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMoveMusicLightPreset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B4C RID: 27468
		// (get) Token: 0x0601AAF6 RID: 109302 RVA: 0x002751FB File Offset: 0x002733FB
		// (set) Token: 0x0601AAF7 RID: 109303 RVA: 0x0027520B File Offset: 0x0027340B
		public unsafe int PointComponentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointComponentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointComponentCount) = value;
			}
		}

		// Token: 0x17006B4D RID: 27469
		// (get) Token: 0x0601AAF8 RID: 109304 RVA: 0x0027521C File Offset: 0x0027341C
		// (set) Token: 0x0601AAF9 RID: 109305 RVA: 0x0027522C File Offset: 0x0027342C
		public unsafe bool bApplySplinePositionSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_bApplySplinePositionSample) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_bApplySplinePositionSample) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B4E RID: 27470
		// (get) Token: 0x0601AAFA RID: 109306 RVA: 0x00275240 File Offset: 0x00273440
		// (set) Token: 0x0601AAFB RID: 109307 RVA: 0x00275279 File Offset: 0x00273479
		public FKuroCurveFloat PointCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._PointCurve) == null)
				{
					result = (this._PointCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006B4F RID: 27471
		// (get) Token: 0x0601AAFC RID: 109308 RVA: 0x0027529A File Offset: 0x0027349A
		// (set) Token: 0x0601AAFD RID: 109309 RVA: 0x002752AA File Offset: 0x002734AA
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_MoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_MoveSpeed) = value;
			}
		}

		// Token: 0x17006B50 RID: 27472
		// (get) Token: 0x0601AAFE RID: 109310 RVA: 0x002752BB File Offset: 0x002734BB
		// (set) Token: 0x0601AAFF RID: 109311 RVA: 0x002752CF File Offset: 0x002734CF
		public unsafe FLinearColor PointStartColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointStartColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointStartColor) = value;
			}
		}

		// Token: 0x17006B51 RID: 27473
		// (get) Token: 0x0601AB00 RID: 109312 RVA: 0x002752E4 File Offset: 0x002734E4
		// (set) Token: 0x0601AB01 RID: 109313 RVA: 0x002752F8 File Offset: 0x002734F8
		public unsafe FLinearColor PointEndColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointEndColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_PointEndColor) = value;
			}
		}

		// Token: 0x17006B52 RID: 27474
		// (get) Token: 0x0601AB02 RID: 109314 RVA: 0x0027530D File Offset: 0x0027350D
		// (set) Token: 0x0601AB03 RID: 109315 RVA: 0x0027531D File Offset: 0x0027351D
		public unsafe ESplinePlaneType SplinePlane
		{
			get
			{
				return (ESplinePlaneType)(*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_SplinePlane));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_SplinePlane) = (byte)value;
			}
		}

		// Token: 0x17006B53 RID: 27475
		// (get) Token: 0x0601AB04 RID: 109316 RVA: 0x0027532E File Offset: 0x0027352E
		// (set) Token: 0x0601AB05 RID: 109317 RVA: 0x00275342 File Offset: 0x00273542
		public unsafe FVector SplineEndPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_SplineEndPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_SplineEndPoint) = value;
			}
		}

		// Token: 0x17006B54 RID: 27476
		// (get) Token: 0x0601AB06 RID: 109318 RVA: 0x00275357 File Offset: 0x00273557
		// (set) Token: 0x0601AB07 RID: 109319 RVA: 0x00275367 File Offset: 0x00273567
		public unsafe float CurveOffsetStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_CurveOffsetStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_CurveOffsetStrength) = value;
			}
		}

		// Token: 0x17006B55 RID: 27477
		// (get) Token: 0x0601AB08 RID: 109320 RVA: 0x00275378 File Offset: 0x00273578
		// (set) Token: 0x0601AB09 RID: 109321 RVA: 0x00275388 File Offset: 0x00273588
		public unsafe int SplineSampleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_SplineSampleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_SplineSampleCount) = value;
			}
		}

		// Token: 0x17006B56 RID: 27478
		// (get) Token: 0x0601AB0A RID: 109322 RVA: 0x00275399 File Offset: 0x00273599
		// (set) Token: 0x0601AB0B RID: 109323 RVA: 0x002753A9 File Offset: 0x002735A9
		public unsafe bool bLoopMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_bLoopMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_bLoopMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B57 RID: 27479
		// (get) Token: 0x0601AB0C RID: 109324 RVA: 0x002753BA File Offset: 0x002735BA
		// (set) Token: 0x0601AB0D RID: 109325 RVA: 0x002753CA File Offset: 0x002735CA
		public unsafe bool bUseColorCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_bUseColorCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMoveMusicLightPreset.__PropertyOffset_bUseColorCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B58 RID: 27480
		// (get) Token: 0x0601AB0E RID: 109326 RVA: 0x002753DB File Offset: 0x002735DB
		// (set) Token: 0x0601AB0F RID: 109327 RVA: 0x002753EF File Offset: 0x002735EF
		[Nullable(2)]
		public unsafe UCurveLinearColor ColorGradientCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMoveMusicLightPreset.__PropertyOffset_ColorGradientCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMoveMusicLightPreset.__PropertyOffset_ColorGradientCurve, value);
			}
		}

		// Token: 0x0601AB10 RID: 109328 RVA: 0x00275404 File Offset: 0x00273604
		static UKuroMoveMusicLightPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMoveMusicLightPreset");
		}

		// Token: 0x0601AB11 RID: 109329 RVA: 0x00275412 File Offset: 0x00273612
		protected UKuroMoveMusicLightPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E6F8 RID: 59128
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMoveMusicLightPreset";

		// Token: 0x0400E6F9 RID: 59129
		private static IntPtr _ClassPtr;

		// Token: 0x0400E6FA RID: 59130
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E6FB RID: 59131
		internal static int __PropertyOffset_PointComponentCount;

		// Token: 0x0400E6FC RID: 59132
		internal static int __PropertyOffset_bApplySplinePositionSample;

		// Token: 0x0400E6FD RID: 59133
		internal static int __PropertyOffset_PointCurve;

		// Token: 0x0400E6FE RID: 59134
		[Nullable(2)]
		private FKuroCurveFloat _PointCurve;

		// Token: 0x0400E6FF RID: 59135
		internal static int __PropertyOffset_MoveSpeed;

		// Token: 0x0400E700 RID: 59136
		internal static int __PropertyOffset_PointStartColor;

		// Token: 0x0400E701 RID: 59137
		internal static int __PropertyOffset_PointEndColor;

		// Token: 0x0400E702 RID: 59138
		internal static int __PropertyOffset_SplinePlane;

		// Token: 0x0400E703 RID: 59139
		internal static int __PropertyOffset_SplineEndPoint;

		// Token: 0x0400E704 RID: 59140
		internal static int __PropertyOffset_CurveOffsetStrength;

		// Token: 0x0400E705 RID: 59141
		internal static int __PropertyOffset_SplineSampleCount;

		// Token: 0x0400E706 RID: 59142
		internal static int __PropertyOffset_bLoopMode;

		// Token: 0x0400E707 RID: 59143
		internal static int __PropertyOffset_bUseColorCurve;

		// Token: 0x0400E708 RID: 59144
		internal static int __PropertyOffset_ColorGradientCurve;
	}
}
