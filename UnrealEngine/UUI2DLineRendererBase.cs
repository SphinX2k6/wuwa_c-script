using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200211D RID: 8477
	[UnrealObjectPath("/Script/LGUI.UI2DLineRendererBase")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public abstract class UUI2DLineRendererBase : UUISpriteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE3D RID: 130621 RVA: 0x002F728E File Offset: 0x002F548E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUI2DLineRendererBase._ClassPtr;
		}

		// Token: 0x17007D69 RID: 32105
		// (get) Token: 0x0601FE3E RID: 130622 RVA: 0x002F729A File Offset: 0x002F549A
		// (set) Token: 0x0601FE3F RID: 130623 RVA: 0x002F72AA File Offset: 0x002F54AA
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

		// Token: 0x17007D6A RID: 32106
		// (get) Token: 0x0601FE40 RID: 130624 RVA: 0x002F72BB File Offset: 0x002F54BB
		// (set) Token: 0x0601FE41 RID: 130625 RVA: 0x002F72CB File Offset: 0x002F54CB
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

		// Token: 0x17007D6B RID: 32107
		// (get) Token: 0x0601FE42 RID: 130626 RVA: 0x002F72DC File Offset: 0x002F54DC
		// (set) Token: 0x0601FE43 RID: 130627 RVA: 0x002F72EC File Offset: 0x002F54EC
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

		// Token: 0x17007D6C RID: 32108
		// (get) Token: 0x0601FE44 RID: 130628 RVA: 0x002F72FD File Offset: 0x002F54FD
		// (set) Token: 0x0601FE45 RID: 130629 RVA: 0x002F730D File Offset: 0x002F550D
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

		// Token: 0x17007D6D RID: 32109
		// (get) Token: 0x0601FE46 RID: 130630 RVA: 0x002F731E File Offset: 0x002F551E
		// (set) Token: 0x0601FE47 RID: 130631 RVA: 0x002F732E File Offset: 0x002F552E
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

		// Token: 0x17007D6E RID: 32110
		// (get) Token: 0x0601FE48 RID: 130632 RVA: 0x002F733F File Offset: 0x002F553F
		// (set) Token: 0x0601FE49 RID: 130633 RVA: 0x002F734F File Offset: 0x002F554F
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

		// Token: 0x17007D6F RID: 32111
		// (get) Token: 0x0601FE4A RID: 130634 RVA: 0x002F7360 File Offset: 0x002F5560
		// (set) Token: 0x0601FE4B RID: 130635 RVA: 0x002F7370 File Offset: 0x002F5570
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

		// Token: 0x0601FE4C RID: 130636 RVA: 0x002F7381 File Offset: 0x002F5581
		public void SetLineWidthOffset(float newValue)
		{
			UUI2DLineRendererBase.__SetLineWidthOffset_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FE4D RID: 130637 RVA: 0x002F738F File Offset: 0x002F558F
		public void SetLineWidth(float newValue)
		{
			UUI2DLineRendererBase.__SetLineWidth_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FE4E RID: 130638 RVA: 0x002F739D File Offset: 0x002F559D
		public void SetEndType(EUI2DLineRenderer_EndType newValue)
		{
			UUI2DLineRendererBase.__SetEndType_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FE4F RID: 130639 RVA: 0x002F73AB File Offset: 0x002F55AB
		public void SetDashLength(float newValue)
		{
			UUI2DLineRendererBase.__SetDashLength_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FE50 RID: 130640 RVA: 0x002F73B9 File Offset: 0x002F55B9
		public void SetDashGapRatio(float newValue)
		{
			UUI2DLineRendererBase.__SetDashGapRatio_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FE51 RID: 130641 RVA: 0x002F73C7 File Offset: 0x002F55C7
		public void SetDashEnabled(bool bNewValue)
		{
			UUI2DLineRendererBase.__SetDashEnabled_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0601FE52 RID: 130642 RVA: 0x002F73D5 File Offset: 0x002F55D5
		[NullableContext(2)]
		public ULTweener LineWidthTo(float endValue, float duration, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUI2DLineRendererBase.__LineWidthTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x0601FE53 RID: 130643 RVA: 0x002F73EC File Offset: 0x002F55EC
		public float GetLineWidthOffset()
		{
			return UUI2DLineRendererBase.__GetLineWidthOffset_Internal(base.NativePtr);
		}

		// Token: 0x0601FE54 RID: 130644 RVA: 0x002F73F9 File Offset: 0x002F55F9
		public float GetLineWidth()
		{
			return UUI2DLineRendererBase.__GetLineWidth_Internal(base.NativePtr);
		}

		// Token: 0x0601FE55 RID: 130645 RVA: 0x002F7406 File Offset: 0x002F5606
		public EUI2DLineRenderer_EndType GetEndType()
		{
			return UUI2DLineRendererBase.__GetEndType_Internal(base.NativePtr);
		}

		// Token: 0x0601FE56 RID: 130646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLineWidthOffset_Internal(IntPtr @this, float newValue);

		// Token: 0x0601FE57 RID: 130647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLineWidth_Internal(IntPtr @this, float newValue);

		// Token: 0x0601FE58 RID: 130648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndType_Internal(IntPtr @this, EUI2DLineRenderer_EndType newValue);

		// Token: 0x0601FE59 RID: 130649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDashLength_Internal(IntPtr @this, float newValue);

		// Token: 0x0601FE5A RID: 130650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDashGapRatio_Internal(IntPtr @this, float newValue);

		// Token: 0x0601FE5B RID: 130651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDashEnabled_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0601FE5C RID: 130652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LineWidthTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x0601FE5D RID: 130653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineWidthOffset_Internal(IntPtr @this);

		// Token: 0x0601FE5E RID: 130654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineWidth_Internal(IntPtr @this);

		// Token: 0x0601FE5F RID: 130655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUI2DLineRenderer_EndType __GetEndType_Internal(IntPtr @this);

		// Token: 0x0601FE60 RID: 130656 RVA: 0x002F7413 File Offset: 0x002F5613
		static UUI2DLineRendererBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UI2DLineRendererBase");
		}

		// Token: 0x0601FE61 RID: 130657 RVA: 0x002F7424 File Offset: 0x002F5624
		protected UUI2DLineRendererBase() : this(BuiltinUtils.AllocNativeUObject(UUI2DLineRendererBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE62 RID: 130658 RVA: 0x002F744C File Offset: 0x002F564C
		protected UUI2DLineRendererBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112ED RID: 70381
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UI2DLineRendererBase";

		// Token: 0x040112EE RID: 70382
		private static IntPtr _ClassPtr;

		// Token: 0x040112EF RID: 70383
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112F0 RID: 70384
		internal static int __PropertyOffset_LineWidth;

		// Token: 0x040112F1 RID: 70385
		internal static int __PropertyOffset_EndType;

		// Token: 0x040112F2 RID: 70386
		internal static int __PropertyOffset_LineWidthOffset;

		// Token: 0x040112F3 RID: 70387
		internal static int __PropertyOffset_bFixedThickness;

		// Token: 0x040112F4 RID: 70388
		internal static int __PropertyOffset_bEnableDash;

		// Token: 0x040112F5 RID: 70389
		internal static int __PropertyOffset_DashLength;

		// Token: 0x040112F6 RID: 70390
		internal static int __PropertyOffset_DashGapRatio;
	}
}
