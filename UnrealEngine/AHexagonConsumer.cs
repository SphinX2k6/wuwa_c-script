using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004AF RID: 1199
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.HexagonConsumer")]
	[UnrealStructLayout(1696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1696)]
	public class AHexagonConsumer : AFSRayCastingActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006EC8 RID: 28360 RVA: 0x000A3FF4 File Offset: 0x000A21F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AHexagonConsumer._ClassPtr;
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x000A4000 File Offset: 0x000A2200
		public AHexagonConsumer() : this(BuiltinUtils.AllocNativeUObject(AHexagonConsumer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x000A4028 File Offset: 0x000A2228
		public AHexagonConsumer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AHexagonConsumer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06006ECB RID: 28363 RVA: 0x000A405B File Offset: 0x000A225B
		// (set) Token: 0x06006ECC RID: 28364 RVA: 0x000A406F File Offset: 0x000A226F
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AHexagonConsumer.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHexagonConsumer.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06006ECD RID: 28365 RVA: 0x000A4084 File Offset: 0x000A2284
		// (set) Token: 0x06006ECE RID: 28366 RVA: 0x000A4098 File Offset: 0x000A2298
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AHexagonConsumer.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHexagonConsumer.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06006ECF RID: 28367 RVA: 0x000A40AD File Offset: 0x000A22AD
		// (set) Token: 0x06006ED0 RID: 28368 RVA: 0x000A40C1 File Offset: 0x000A22C1
		public unsafe FVector2D Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06006ED1 RID: 28369 RVA: 0x000A40D6 File Offset: 0x000A22D6
		// (set) Token: 0x06006ED2 RID: 28370 RVA: 0x000A40EA File Offset: 0x000A22EA
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06006ED3 RID: 28371 RVA: 0x000A40FF File Offset: 0x000A22FF
		// (set) Token: 0x06006ED4 RID: 28372 RVA: 0x000A4113 File Offset: 0x000A2313
		public unsafe FVector ActorCenterWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_ActorCenterWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_ActorCenterWorld) = value;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06006ED5 RID: 28373 RVA: 0x000A4128 File Offset: 0x000A2328
		// (set) Token: 0x06006ED6 RID: 28374 RVA: 0x000A413C File Offset: 0x000A233C
		public unsafe FVector NewPointWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_NewPointWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_NewPointWorld) = value;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06006ED7 RID: 28375 RVA: 0x000A4151 File Offset: 0x000A2351
		// (set) Token: 0x06006ED8 RID: 28376 RVA: 0x000A4161 File Offset: 0x000A2361
		public unsafe int RayCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_RayCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_RayCount) = value;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06006ED9 RID: 28377 RVA: 0x000A4174 File Offset: 0x000A2374
		// (set) Token: 0x06006EDA RID: 28378 RVA: 0x000A41AD File Offset: 0x000A23AD
		public TArray<float> RayLengths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RayLengths) == null)
				{
					result = (this._RayLengths = new TArray<float>(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_RayLengths, this));
				}
				return result;
			}
			set
			{
				this.RayLengths.CopyAssign(value);
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06006EDB RID: 28379 RVA: 0x000A41BB File Offset: 0x000A23BB
		// (set) Token: 0x06006EDC RID: 28380 RVA: 0x000A41CB File Offset: 0x000A23CB
		public unsafe float MaxDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_MaxDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_MaxDis) = value;
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06006EDD RID: 28381 RVA: 0x000A41DC File Offset: 0x000A23DC
		// (set) Token: 0x06006EDE RID: 28382 RVA: 0x000A4215 File Offset: 0x000A2415
		public TArray<FVector> Dirs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Dirs) == null)
				{
					result = (this._Dirs = new TArray<FVector>(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_Dirs, this));
				}
				return result;
			}
			set
			{
				this.Dirs.CopyAssign(value);
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06006EDF RID: 28383 RVA: 0x000A4223 File Offset: 0x000A2423
		// (set) Token: 0x06006EE0 RID: 28384 RVA: 0x000A4233 File Offset: 0x000A2433
		public unsafe int renderOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_renderOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_renderOrder) = value;
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06006EE1 RID: 28385 RVA: 0x000A4244 File Offset: 0x000A2444
		// (set) Token: 0x06006EE2 RID: 28386 RVA: 0x000A4254 File Offset: 0x000A2454
		public unsafe bool bUseDistanceBasedRenderOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_bUseDistanceBasedRenderOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_bUseDistanceBasedRenderOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06006EE3 RID: 28387 RVA: 0x000A4265 File Offset: 0x000A2465
		// (set) Token: 0x06006EE4 RID: 28388 RVA: 0x000A4279 File Offset: 0x000A2479
		public unsafe FLinearColor MaxColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_MaxColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_MaxColor) = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06006EE5 RID: 28389 RVA: 0x000A428E File Offset: 0x000A248E
		// (set) Token: 0x06006EE6 RID: 28390 RVA: 0x000A429E File Offset: 0x000A249E
		public unsafe float FadeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_FadeRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHexagonConsumer.__PropertyOffset_FadeRate) = value;
			}
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x000A42AF File Offset: 0x000A24AF
		[SkipLocalsInit]
		public void afterBeginPlay()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AHexagonConsumer.__afterBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x000A42C3 File Offset: 0x000A24C3
		static AHexagonConsumer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.HexagonConsumer");
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x000A42D1 File Offset: 0x000A24D1
		protected AHexagonConsumer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FED RID: 12269
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.HexagonConsumer";

		// Token: 0x04002FEE RID: 12270
		private static IntPtr _ClassPtr;

		// Token: 0x04002FEF RID: 12271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002FF0 RID: 12272
		internal static int __PropertyOffset_Root;

		// Token: 0x04002FF1 RID: 12273
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x04002FF2 RID: 12274
		internal static int __PropertyOffset_Center;

		// Token: 0x04002FF3 RID: 12275
		internal static int __PropertyOffset_Color;

		// Token: 0x04002FF4 RID: 12276
		internal static int __PropertyOffset_ActorCenterWorld;

		// Token: 0x04002FF5 RID: 12277
		internal static int __PropertyOffset_NewPointWorld;

		// Token: 0x04002FF6 RID: 12278
		internal static int __PropertyOffset_RayCount;

		// Token: 0x04002FF7 RID: 12279
		internal static int __PropertyOffset_RayLengths;

		// Token: 0x04002FF8 RID: 12280
		[Nullable(2)]
		private TArray<float> _RayLengths;

		// Token: 0x04002FF9 RID: 12281
		internal static int __PropertyOffset_MaxDis;

		// Token: 0x04002FFA RID: 12282
		internal static int __PropertyOffset_Dirs;

		// Token: 0x04002FFB RID: 12283
		[Nullable(2)]
		private TArray<FVector> _Dirs;

		// Token: 0x04002FFC RID: 12284
		internal static int __PropertyOffset_renderOrder;

		// Token: 0x04002FFD RID: 12285
		internal static int __PropertyOffset_bUseDistanceBasedRenderOrder;

		// Token: 0x04002FFE RID: 12286
		internal static int __PropertyOffset_MaxColor;

		// Token: 0x04002FFF RID: 12287
		internal static int __PropertyOffset_FadeRate;

		// Token: 0x04003000 RID: 12288
		private static IntPtr __afterBeginPlay_NativeFunctionPtr;
	}
}
