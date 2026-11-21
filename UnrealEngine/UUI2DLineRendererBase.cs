using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006E5 RID: 1765
	[UnrealObjectPath("/Script/LGUI.UI2DLineRendererBase")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public abstract class UUI2DLineRendererBase : UUISpriteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060095CA RID: 38346 RVA: 0x000E2346 File Offset: 0x000E0546
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUI2DLineRendererBase._ClassPtr;
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x000E2352 File Offset: 0x000E0552
		// (set) Token: 0x060095CC RID: 38348 RVA: 0x000E2362 File Offset: 0x000E0562
		public unsafe float LineWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_LineWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_LineWidth) = value;
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060095CD RID: 38349 RVA: 0x000E2373 File Offset: 0x000E0573
		// (set) Token: 0x060095CE RID: 38350 RVA: 0x000E2383 File Offset: 0x000E0583
		public unsafe EUI2DLineRenderer_EndType EndType
		{
			get
			{
				return (EUI2DLineRenderer_EndType)(*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_EndType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_EndType) = (byte)value;
			}
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x000E2394 File Offset: 0x000E0594
		// (set) Token: 0x060095D0 RID: 38352 RVA: 0x000E23A4 File Offset: 0x000E05A4
		public unsafe float LineWidthOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_LineWidthOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_LineWidthOffset) = value;
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x060095D1 RID: 38353 RVA: 0x000E23B5 File Offset: 0x000E05B5
		// (set) Token: 0x060095D2 RID: 38354 RVA: 0x000E23C5 File Offset: 0x000E05C5
		public unsafe bool bFixedThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_bFixedThickness) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_bFixedThickness) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x060095D3 RID: 38355 RVA: 0x000E23D6 File Offset: 0x000E05D6
		// (set) Token: 0x060095D4 RID: 38356 RVA: 0x000E23E6 File Offset: 0x000E05E6
		public unsafe bool bEnableDash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_bEnableDash) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_bEnableDash) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x060095D5 RID: 38357 RVA: 0x000E23F7 File Offset: 0x000E05F7
		// (set) Token: 0x060095D6 RID: 38358 RVA: 0x000E2407 File Offset: 0x000E0607
		public unsafe float DashLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_DashLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_DashLength) = value;
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x060095D7 RID: 38359 RVA: 0x000E2418 File Offset: 0x000E0618
		// (set) Token: 0x060095D8 RID: 38360 RVA: 0x000E2428 File Offset: 0x000E0628
		public unsafe float DashGapRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_DashGapRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUI2DLineRendererBase.__PropertyOffset_DashGapRatio) = value;
			}
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x000E2439 File Offset: 0x000E0639
		public void SetLineWidthOffset(float newValue)
		{
			UUI2DLineRendererBase.__SetLineWidthOffset_Internal(base.NativePtr, newValue);
		}

		// Token: 0x060095DA RID: 38362 RVA: 0x000E2447 File Offset: 0x000E0647
		public void SetLineWidth(float newValue)
		{
			UUI2DLineRendererBase.__SetLineWidth_Internal(base.NativePtr, newValue);
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x000E2455 File Offset: 0x000E0655
		public void SetEndType(EUI2DLineRenderer_EndType newValue)
		{
			UUI2DLineRendererBase.__SetEndType_Internal(base.NativePtr, newValue);
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x000E2463 File Offset: 0x000E0663
		public void SetDashLength(float newValue)
		{
			UUI2DLineRendererBase.__SetDashLength_Internal(base.NativePtr, newValue);
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x000E2471 File Offset: 0x000E0671
		public void SetDashGapRatio(float newValue)
		{
			UUI2DLineRendererBase.__SetDashGapRatio_Internal(base.NativePtr, newValue);
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x000E247F File Offset: 0x000E067F
		public void SetDashEnabled(bool bNewValue)
		{
			UUI2DLineRendererBase.__SetDashEnabled_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x060095DF RID: 38367 RVA: 0x000E248D File Offset: 0x000E068D
		[NullableContext(2)]
		public ULTweener LineWidthTo(float endValue, float duration, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUI2DLineRendererBase.__LineWidthTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x000E24A4 File Offset: 0x000E06A4
		public float GetLineWidthOffset()
		{
			return UUI2DLineRendererBase.__GetLineWidthOffset_Internal(base.NativePtr);
		}

		// Token: 0x060095E1 RID: 38369 RVA: 0x000E24B1 File Offset: 0x000E06B1
		public float GetLineWidth()
		{
			return UUI2DLineRendererBase.__GetLineWidth_Internal(base.NativePtr);
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x000E24BE File Offset: 0x000E06BE
		public EUI2DLineRenderer_EndType GetEndType()
		{
			return UUI2DLineRendererBase.__GetEndType_Internal(base.NativePtr);
		}

		// Token: 0x060095E3 RID: 38371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLineWidthOffset_Internal(IntPtr @this, float newValue);

		// Token: 0x060095E4 RID: 38372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLineWidth_Internal(IntPtr @this, float newValue);

		// Token: 0x060095E5 RID: 38373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndType_Internal(IntPtr @this, EUI2DLineRenderer_EndType newValue);

		// Token: 0x060095E6 RID: 38374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDashLength_Internal(IntPtr @this, float newValue);

		// Token: 0x060095E7 RID: 38375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDashGapRatio_Internal(IntPtr @this, float newValue);

		// Token: 0x060095E8 RID: 38376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDashEnabled_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x060095E9 RID: 38377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LineWidthTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x060095EA RID: 38378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineWidthOffset_Internal(IntPtr @this);

		// Token: 0x060095EB RID: 38379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineWidth_Internal(IntPtr @this);

		// Token: 0x060095EC RID: 38380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUI2DLineRenderer_EndType __GetEndType_Internal(IntPtr @this);

		// Token: 0x060095ED RID: 38381 RVA: 0x000E24CB File Offset: 0x000E06CB
		static UUI2DLineRendererBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UI2DLineRendererBase");
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x000E24DC File Offset: 0x000E06DC
		protected UUI2DLineRendererBase() : this(BuiltinUtils.AllocNativeUObject(UUI2DLineRendererBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x000E2504 File Offset: 0x000E0704
		protected UUI2DLineRendererBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400412E RID: 16686
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UI2DLineRendererBase";

		// Token: 0x0400412F RID: 16687
		private static IntPtr _ClassPtr;

		// Token: 0x04004130 RID: 16688
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004131 RID: 16689
		internal static int __PropertyOffset_LineWidth;

		// Token: 0x04004132 RID: 16690
		internal static int __PropertyOffset_EndType;

		// Token: 0x04004133 RID: 16691
		internal static int __PropertyOffset_LineWidthOffset;

		// Token: 0x04004134 RID: 16692
		internal static int __PropertyOffset_bFixedThickness;

		// Token: 0x04004135 RID: 16693
		internal static int __PropertyOffset_bEnableDash;

		// Token: 0x04004136 RID: 16694
		internal static int __PropertyOffset_DashLength;

		// Token: 0x04004137 RID: 16695
		internal static int __PropertyOffset_DashGapRatio;
	}
}
