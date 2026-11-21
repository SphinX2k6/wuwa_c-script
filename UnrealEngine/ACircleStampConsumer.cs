using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004A4 RID: 1188
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CircleStampConsumer")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class ACircleStampConsumer : AKuroBPActor, IUnrealUObject, IUnrealObject, IKuroRenderingStampConsumer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006E90 RID: 28304 RVA: 0x000A31B1 File Offset: 0x000A13B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACircleStampConsumer._ClassPtr;
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x000A31BD File Offset: 0x000A13BD
		int IKuroRenderingStampConsumer.InterfaceOffset()
		{
			return ACircleStampConsumer.__InterfaceOffset_IKuroRenderingStampConsumer;
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x000A31C4 File Offset: 0x000A13C4
		public ACircleStampConsumer() : this(BuiltinUtils.AllocNativeUObject(ACircleStampConsumer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x000A31EC File Offset: 0x000A13EC
		[NullableContext(1)]
		public ACircleStampConsumer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACircleStampConsumer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06006E94 RID: 28308 RVA: 0x000A321F File Offset: 0x000A141F
		// (set) Token: 0x06006E95 RID: 28309 RVA: 0x000A3233 File Offset: 0x000A1433
		public unsafe FVectorDouble RTWorldCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldCenter) = value;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06006E96 RID: 28310 RVA: 0x000A3248 File Offset: 0x000A1448
		// (set) Token: 0x06006E97 RID: 28311 RVA: 0x000A3258 File Offset: 0x000A1458
		public unsafe float RTWorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldRadius) = value;
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06006E98 RID: 28312 RVA: 0x000A3269 File Offset: 0x000A1469
		// (set) Token: 0x06006E99 RID: 28313 RVA: 0x000A327D File Offset: 0x000A147D
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x000A3292 File Offset: 0x000A1492
		// (set) Token: 0x06006E9B RID: 28315 RVA: 0x000A32A2 File Offset: 0x000A14A2
		public unsafe int RenderTargetSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeX) = value;
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06006E9C RID: 28316 RVA: 0x000A32B3 File Offset: 0x000A14B3
		// (set) Token: 0x06006E9D RID: 28317 RVA: 0x000A32C3 File Offset: 0x000A14C3
		public unsafe int RenderTargetSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeY) = value;
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x000A32D4 File Offset: 0x000A14D4
		// (set) Token: 0x06006E9F RID: 28319 RVA: 0x000A32E8 File Offset: 0x000A14E8
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x000A32FD File Offset: 0x000A14FD
		// (set) Token: 0x06006EA1 RID: 28321 RVA: 0x000A330D File Offset: 0x000A150D
		public unsafe bool bAutoFadeOnValueChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_bAutoFadeOnValueChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_bAutoFadeOnValueChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x000A331E File Offset: 0x000A151E
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x000A332E File Offset: 0x000A152E
		public unsafe float DefaultFadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_DefaultFadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_DefaultFadeDuration) = value;
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x000A333F File Offset: 0x000A153F
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x000A3353 File Offset: 0x000A1553
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x06006EA6 RID: 28326 RVA: 0x000A3368 File Offset: 0x000A1568
		public void SetRenderTargetWorldRadius(float InRadius)
		{
			ACircleStampConsumer.__SetRenderTargetWorldRadius_Internal(base.NativePtr, InRadius);
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x000A3376 File Offset: 0x000A1576
		public void SetRenderTargetWorldCenter(in FVectorDouble InCenter)
		{
			ACircleStampConsumer.__SetRenderTargetWorldCenter_Internal(base.NativePtr, InCenter);
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x000A3384 File Offset: 0x000A1584
		public void SetRenderTargetSize(int InSizeX, int InSizeY)
		{
			ACircleStampConsumer.__SetRenderTargetSize_Internal(base.NativePtr, InSizeX, InSizeY);
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x000A3393 File Offset: 0x000A1593
		public void SetRenderTarget(UTextureRenderTarget2D InRenderTarget)
		{
			ACircleStampConsumer.__SetRenderTarget_Internal(base.NativePtr, (InRenderTarget != null) ? InRenderTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x000A33B0 File Offset: 0x000A15B0
		public void SetClearColor(in FLinearColor InClearColor)
		{
			ACircleStampConsumer.__SetClearColor_Internal(base.NativePtr, InClearColor);
		}

		// Token: 0x06006EAB RID: 28331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTargetWorldRadius_Internal(IntPtr @this, float InRadius);

		// Token: 0x06006EAC RID: 28332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTargetWorldCenter_Internal(IntPtr @this, in FVectorDouble InCenter);

		// Token: 0x06006EAD RID: 28333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTargetSize_Internal(IntPtr @this, int InSizeX, int InSizeY);

		// Token: 0x06006EAE RID: 28334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTarget_Internal(IntPtr @this, IntPtr InRenderTarget);

		// Token: 0x06006EAF RID: 28335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClearColor_Internal(IntPtr @this, in FLinearColor InClearColor);

		// Token: 0x06006EB0 RID: 28336 RVA: 0x000A33BE File Offset: 0x000A15BE
		static ACircleStampConsumer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.CircleStampConsumer");
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x000A33CC File Offset: 0x000A15CC
		protected ACircleStampConsumer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x000A33D5 File Offset: 0x000A15D5
		void IKuroRenderingStampConsumer.SetRenderTargetWorldCenter(in FVectorDouble InCenter)
		{
			this.SetRenderTargetWorldCenter(InCenter);
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x000A33DE File Offset: 0x000A15DE
		void IKuroRenderingStampConsumer.SetClearColor(in FLinearColor InClearColor)
		{
			this.SetClearColor(InClearColor);
		}

		// Token: 0x04002F77 RID: 12151
		internal static int __InterfaceOffset_IKuroRenderingStampConsumer;

		// Token: 0x04002F78 RID: 12152
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CircleStampConsumer";

		// Token: 0x04002F79 RID: 12153
		private static IntPtr _ClassPtr;

		// Token: 0x04002F7A RID: 12154
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002F7B RID: 12155
		internal static int __PropertyOffset_RTWorldCenter;

		// Token: 0x04002F7C RID: 12156
		internal static int __PropertyOffset_RTWorldRadius;

		// Token: 0x04002F7D RID: 12157
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x04002F7E RID: 12158
		internal static int __PropertyOffset_RenderTargetSizeX;

		// Token: 0x04002F7F RID: 12159
		internal static int __PropertyOffset_RenderTargetSizeY;

		// Token: 0x04002F80 RID: 12160
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x04002F81 RID: 12161
		internal static int __PropertyOffset_bAutoFadeOnValueChange;

		// Token: 0x04002F82 RID: 12162
		internal static int __PropertyOffset_DefaultFadeDuration;

		// Token: 0x04002F83 RID: 12163
		internal static int __PropertyOffset_Root;
	}
}
