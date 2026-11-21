using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003F0 RID: 1008
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006328 RID: 25384 RVA: 0x0008DCF0 File Offset: 0x0008BEF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset._ClassPtr;
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x0008DCFC File Offset: 0x0008BEFC
		public UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x0008DD24 File Offset: 0x0008BF24
		[NullableContext(1)]
		public UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x0600632B RID: 25387 RVA: 0x0008DD57 File Offset: 0x0008BF57
		// (set) Token: 0x0600632C RID: 25388 RVA: 0x0008DD67 File Offset: 0x0008BF67
		public unsafe bool bEnableAutoFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_bEnableAutoFade) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_bEnableAutoFade) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x0600632D RID: 25389 RVA: 0x0008DD78 File Offset: 0x0008BF78
		// (set) Token: 0x0600632E RID: 25390 RVA: 0x0008DD88 File Offset: 0x0008BF88
		public unsafe float AutoFadeDurating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_AutoFadeDurating);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_AutoFadeDurating) = value;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x0600632F RID: 25391 RVA: 0x0008DD99 File Offset: 0x0008BF99
		// (set) Token: 0x06006330 RID: 25392 RVA: 0x0008DDA9 File Offset: 0x0008BFA9
		public unsafe float SoftEdgeWidthWorldRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_SoftEdgeWidthWorldRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_SoftEdgeWidthWorldRatio) = value;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06006331 RID: 25393 RVA: 0x0008DDBA File Offset: 0x0008BFBA
		// (set) Token: 0x06006332 RID: 25394 RVA: 0x0008DDCE File Offset: 0x0008BFCE
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06006333 RID: 25395 RVA: 0x0008DDE3 File Offset: 0x0008BFE3
		// (set) Token: 0x06006334 RID: 25396 RVA: 0x0008DDF3 File Offset: 0x0008BFF3
		public unsafe float RenderTargetWorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTargetWorldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTargetWorldRadius) = value;
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06006335 RID: 25397 RVA: 0x0008DE04 File Offset: 0x0008C004
		// (set) Token: 0x06006336 RID: 25398 RVA: 0x0008DE14 File Offset: 0x0008C014
		public unsafe float RenderTargetSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTargetSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTargetSizeX) = value;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x0008DE25 File Offset: 0x0008C025
		// (set) Token: 0x06006338 RID: 25400 RVA: 0x0008DE35 File Offset: 0x0008C035
		public unsafe float RenderTargetSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTargetSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_RenderTargetSizeY) = value;
			}
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x0008DE46 File Offset: 0x0008C046
		[NullableContext(1)]
		public TArray<string> GetInstancedFoliageTypeOptions()
		{
			return new TArray<string>(UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__GetInstancedFoliageTypeOptions_Internal(base.NativePtr), null);
		}

		// Token: 0x0600633A RID: 25402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstancedFoliageTypeOptions_Internal(IntPtr @this);

		// Token: 0x0600633B RID: 25403 RVA: 0x0008DE59 File Offset: 0x0008C059
		static UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset");
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x0008DE67 File Offset: 0x0008C067
		protected UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040029EA RID: 10730
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset";

		// Token: 0x040029EB RID: 10731
		private static IntPtr _ClassPtr;

		// Token: 0x040029EC RID: 10732
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040029ED RID: 10733
		internal static int __PropertyOffset_bEnableAutoFade;

		// Token: 0x040029EE RID: 10734
		internal static int __PropertyOffset_AutoFadeDurating;

		// Token: 0x040029EF RID: 10735
		internal static int __PropertyOffset_SoftEdgeWidthWorldRatio;

		// Token: 0x040029F0 RID: 10736
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x040029F1 RID: 10737
		internal static int __PropertyOffset_RenderTargetWorldRadius;

		// Token: 0x040029F2 RID: 10738
		internal static int __PropertyOffset_RenderTargetSizeX;

		// Token: 0x040029F3 RID: 10739
		internal static int __PropertyOffset_RenderTargetSizeY;
	}
}
