using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A9F RID: 6815
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.HexagonConsumer")]
	[UnrealStructLayout(1696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1696)]
	public class AHexagonConsumer : AFSRayCastingActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601937E RID: 103294 RVA: 0x00254DDD File Offset: 0x00252FDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AHexagonConsumer._ClassPtr;
		}

		// Token: 0x0601937F RID: 103295 RVA: 0x00254DEC File Offset: 0x00252FEC
		public AHexagonConsumer() : this(BuiltinUtils.AllocNativeUObject(AHexagonConsumer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019380 RID: 103296 RVA: 0x00254E14 File Offset: 0x00253014
		public AHexagonConsumer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AHexagonConsumer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700647B RID: 25723
		// (get) Token: 0x06019381 RID: 103297 RVA: 0x00254E47 File Offset: 0x00253047
		// (set) Token: 0x06019382 RID: 103298 RVA: 0x00254E5B File Offset: 0x0025305B
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

		// Token: 0x1700647C RID: 25724
		// (get) Token: 0x06019383 RID: 103299 RVA: 0x00254E70 File Offset: 0x00253070
		// (set) Token: 0x06019384 RID: 103300 RVA: 0x00254E84 File Offset: 0x00253084
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

		// Token: 0x1700647D RID: 25725
		// (get) Token: 0x06019385 RID: 103301 RVA: 0x00254E99 File Offset: 0x00253099
		// (set) Token: 0x06019386 RID: 103302 RVA: 0x00254EAD File Offset: 0x002530AD
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

		// Token: 0x1700647E RID: 25726
		// (get) Token: 0x06019387 RID: 103303 RVA: 0x00254EC2 File Offset: 0x002530C2
		// (set) Token: 0x06019388 RID: 103304 RVA: 0x00254ED6 File Offset: 0x002530D6
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

		// Token: 0x1700647F RID: 25727
		// (get) Token: 0x06019389 RID: 103305 RVA: 0x00254EEB File Offset: 0x002530EB
		// (set) Token: 0x0601938A RID: 103306 RVA: 0x00254EFF File Offset: 0x002530FF
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

		// Token: 0x17006480 RID: 25728
		// (get) Token: 0x0601938B RID: 103307 RVA: 0x00254F14 File Offset: 0x00253114
		// (set) Token: 0x0601938C RID: 103308 RVA: 0x00254F28 File Offset: 0x00253128
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

		// Token: 0x17006481 RID: 25729
		// (get) Token: 0x0601938D RID: 103309 RVA: 0x00254F3D File Offset: 0x0025313D
		// (set) Token: 0x0601938E RID: 103310 RVA: 0x00254F4D File Offset: 0x0025314D
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

		// Token: 0x17006482 RID: 25730
		// (get) Token: 0x0601938F RID: 103311 RVA: 0x00254F60 File Offset: 0x00253160
		// (set) Token: 0x06019390 RID: 103312 RVA: 0x00254F99 File Offset: 0x00253199
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

		// Token: 0x17006483 RID: 25731
		// (get) Token: 0x06019391 RID: 103313 RVA: 0x00254FA7 File Offset: 0x002531A7
		// (set) Token: 0x06019392 RID: 103314 RVA: 0x00254FB7 File Offset: 0x002531B7
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

		// Token: 0x17006484 RID: 25732
		// (get) Token: 0x06019393 RID: 103315 RVA: 0x00254FC8 File Offset: 0x002531C8
		// (set) Token: 0x06019394 RID: 103316 RVA: 0x00255001 File Offset: 0x00253201
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

		// Token: 0x17006485 RID: 25733
		// (get) Token: 0x06019395 RID: 103317 RVA: 0x0025500F File Offset: 0x0025320F
		// (set) Token: 0x06019396 RID: 103318 RVA: 0x0025501F File Offset: 0x0025321F
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

		// Token: 0x17006486 RID: 25734
		// (get) Token: 0x06019397 RID: 103319 RVA: 0x00255030 File Offset: 0x00253230
		// (set) Token: 0x06019398 RID: 103320 RVA: 0x00255040 File Offset: 0x00253240
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

		// Token: 0x17006487 RID: 25735
		// (get) Token: 0x06019399 RID: 103321 RVA: 0x00255051 File Offset: 0x00253251
		// (set) Token: 0x0601939A RID: 103322 RVA: 0x00255065 File Offset: 0x00253265
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

		// Token: 0x17006488 RID: 25736
		// (get) Token: 0x0601939B RID: 103323 RVA: 0x0025507A File Offset: 0x0025327A
		// (set) Token: 0x0601939C RID: 103324 RVA: 0x0025508A File Offset: 0x0025328A
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

		// Token: 0x0601939D RID: 103325 RVA: 0x0025509B File Offset: 0x0025329B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void afterBeginPlay()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AHexagonConsumer.__afterBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601939E RID: 103326 RVA: 0x002550B0 File Offset: 0x002532B0
		static AHexagonConsumer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.HexagonConsumer");
		}

		// Token: 0x0601939F RID: 103327 RVA: 0x002550BE File Offset: 0x002532BE
		protected AHexagonConsumer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC1A RID: 56346
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.HexagonConsumer";

		// Token: 0x0400DC1B RID: 56347
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC1C RID: 56348
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC1D RID: 56349
		internal static int __PropertyOffset_Root;

		// Token: 0x0400DC1E RID: 56350
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400DC1F RID: 56351
		internal static int __PropertyOffset_Center;

		// Token: 0x0400DC20 RID: 56352
		internal static int __PropertyOffset_Color;

		// Token: 0x0400DC21 RID: 56353
		internal static int __PropertyOffset_ActorCenterWorld;

		// Token: 0x0400DC22 RID: 56354
		internal static int __PropertyOffset_NewPointWorld;

		// Token: 0x0400DC23 RID: 56355
		internal static int __PropertyOffset_RayCount;

		// Token: 0x0400DC24 RID: 56356
		internal static int __PropertyOffset_RayLengths;

		// Token: 0x0400DC25 RID: 56357
		[Nullable(2)]
		private TArray<float> _RayLengths;

		// Token: 0x0400DC26 RID: 56358
		internal static int __PropertyOffset_MaxDis;

		// Token: 0x0400DC27 RID: 56359
		internal static int __PropertyOffset_Dirs;

		// Token: 0x0400DC28 RID: 56360
		[Nullable(2)]
		private TArray<FVector> _Dirs;

		// Token: 0x0400DC29 RID: 56361
		internal static int __PropertyOffset_renderOrder;

		// Token: 0x0400DC2A RID: 56362
		internal static int __PropertyOffset_bUseDistanceBasedRenderOrder;

		// Token: 0x0400DC2B RID: 56363
		internal static int __PropertyOffset_MaxColor;

		// Token: 0x0400DC2C RID: 56364
		internal static int __PropertyOffset_FadeRate;

		// Token: 0x0400DC2D RID: 56365
		private static IntPtr __afterBeginPlay_NativeFunctionPtr;
	}
}
