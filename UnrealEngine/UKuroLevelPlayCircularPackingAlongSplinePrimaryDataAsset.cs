using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E5 RID: 6373
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060179FD RID: 96765 RVA: 0x00229EC1 File Offset: 0x002280C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset._ClassPtr;
		}

		// Token: 0x060179FE RID: 96766 RVA: 0x00229ED0 File Offset: 0x002280D0
		public UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060179FF RID: 96767 RVA: 0x00229EF8 File Offset: 0x002280F8
		public UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x06017A00 RID: 96768 RVA: 0x00229F2C File Offset: 0x0022812C
		// (set) Token: 0x06017A01 RID: 96769 RVA: 0x00229F65 File Offset: 0x00228165
		public TMap<int, UKuroLevelPlaySplineCircularCluster> SplineClusters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroLevelPlaySplineCircularCluster> result;
				if ((result = this._SplineClusters) == null)
				{
					result = (this._SplineClusters = new TMap<int, UKuroLevelPlaySplineCircularCluster>(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_SplineClusters, this));
				}
				return result;
			}
			set
			{
				this.SplineClusters.CopyAssign(value);
			}
		}

		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x06017A02 RID: 96770 RVA: 0x00229F74 File Offset: 0x00228174
		// (set) Token: 0x06017A03 RID: 96771 RVA: 0x00229FAD File Offset: 0x002281AD
		public TMap<int, UKuroLevelPlayObstacleConvexHull> ConvexHulls
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroLevelPlayObstacleConvexHull> result;
				if ((result = this._ConvexHulls) == null)
				{
					result = (this._ConvexHulls = new TMap<int, UKuroLevelPlayObstacleConvexHull>(base.NativePtr + (IntPtr)UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__PropertyOffset_ConvexHulls, this));
				}
				return result;
			}
			set
			{
				this.ConvexHulls.CopyAssign(value);
			}
		}

		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x06017A04 RID: 96772 RVA: 0x00229FBB File Offset: 0x002281BB
		// (set) Token: 0x06017A05 RID: 96773 RVA: 0x00229FCB File Offset: 0x002281CB
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

		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x06017A06 RID: 96774 RVA: 0x00229FDC File Offset: 0x002281DC
		// (set) Token: 0x06017A07 RID: 96775 RVA: 0x00229FEC File Offset: 0x002281EC
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

		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x06017A08 RID: 96776 RVA: 0x00229FFD File Offset: 0x002281FD
		// (set) Token: 0x06017A09 RID: 96777 RVA: 0x0022A00D File Offset: 0x0022820D
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

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x06017A0A RID: 96778 RVA: 0x0022A01E File Offset: 0x0022821E
		// (set) Token: 0x06017A0B RID: 96779 RVA: 0x0022A032 File Offset: 0x00228232
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

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x06017A0C RID: 96780 RVA: 0x0022A047 File Offset: 0x00228247
		// (set) Token: 0x06017A0D RID: 96781 RVA: 0x0022A057 File Offset: 0x00228257
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

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x06017A0E RID: 96782 RVA: 0x0022A068 File Offset: 0x00228268
		// (set) Token: 0x06017A0F RID: 96783 RVA: 0x0022A078 File Offset: 0x00228278
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

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x06017A10 RID: 96784 RVA: 0x0022A089 File Offset: 0x00228289
		// (set) Token: 0x06017A11 RID: 96785 RVA: 0x0022A099 File Offset: 0x00228299
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

		// Token: 0x06017A12 RID: 96786 RVA: 0x0022A0AA File Offset: 0x002282AA
		public TArray<string> GetInstancedFoliageTypeOptions()
		{
			return new TArray<string>(UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset.__GetInstancedFoliageTypeOptions_Internal(base.NativePtr), null);
		}

		// Token: 0x06017A13 RID: 96787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstancedFoliageTypeOptions_Internal(IntPtr @this);

		// Token: 0x06017A14 RID: 96788 RVA: 0x0022A0BD File Offset: 0x002282BD
		static UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset");
		}

		// Token: 0x06017A15 RID: 96789 RVA: 0x0022A0CB File Offset: 0x002282CB
		protected UKuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CD4D RID: 52557
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayCircularPackingAlongSplinePrimaryDataAsset";

		// Token: 0x0400CD4E RID: 52558
		private static IntPtr _ClassPtr;

		// Token: 0x0400CD4F RID: 52559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CD50 RID: 52560
		internal static int __PropertyOffset_SplineClusters;

		// Token: 0x0400CD51 RID: 52561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroLevelPlaySplineCircularCluster> _SplineClusters;

		// Token: 0x0400CD52 RID: 52562
		internal static int __PropertyOffset_ConvexHulls;

		// Token: 0x0400CD53 RID: 52563
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroLevelPlayObstacleConvexHull> _ConvexHulls;

		// Token: 0x0400CD54 RID: 52564
		internal static int __PropertyOffset_bEnableAutoFade;

		// Token: 0x0400CD55 RID: 52565
		internal static int __PropertyOffset_AutoFadeDurating;

		// Token: 0x0400CD56 RID: 52566
		internal static int __PropertyOffset_SoftEdgeWidthWorldRatio;

		// Token: 0x0400CD57 RID: 52567
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400CD58 RID: 52568
		internal static int __PropertyOffset_RenderTargetWorldRadius;

		// Token: 0x0400CD59 RID: 52569
		internal static int __PropertyOffset_RenderTargetSizeX;

		// Token: 0x0400CD5A RID: 52570
		internal static int __PropertyOffset_RenderTargetSizeY;
	}
}
