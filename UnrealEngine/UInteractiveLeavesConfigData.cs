using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA1 RID: 6817
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.InteractiveLeavesConfigData")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UInteractiveLeavesConfigData : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060193AB RID: 103339 RVA: 0x002551C1 File Offset: 0x002533C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveLeavesConfigData._ClassPtr;
		}

		// Token: 0x060193AC RID: 103340 RVA: 0x002551D0 File Offset: 0x002533D0
		public UInteractiveLeavesConfigData() : this(BuiltinUtils.AllocNativeUObject(UInteractiveLeavesConfigData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060193AD RID: 103341 RVA: 0x002551F8 File Offset: 0x002533F8
		[NullableContext(1)]
		public UInteractiveLeavesConfigData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveLeavesConfigData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700648C RID: 25740
		// (get) Token: 0x060193AE RID: 103342 RVA: 0x0025522B File Offset: 0x0025342B
		// (set) Token: 0x060193AF RID: 103343 RVA: 0x0025523F File Offset: 0x0025343F
		public unsafe UKuroPointCloudCache PointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_PointCache);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_PointCache, value);
			}
		}

		// Token: 0x1700648D RID: 25741
		// (get) Token: 0x060193B0 RID: 103344 RVA: 0x00255254 File Offset: 0x00253454
		// (set) Token: 0x060193B1 RID: 103345 RVA: 0x00255268 File Offset: 0x00253468
		public unsafe UKuroPointCloudCache PointCacheMobile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_PointCacheMobile);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_PointCacheMobile, value);
			}
		}

		// Token: 0x1700648E RID: 25742
		// (get) Token: 0x060193B2 RID: 103346 RVA: 0x0025527D File Offset: 0x0025347D
		// (set) Token: 0x060193B3 RID: 103347 RVA: 0x00255291 File Offset: 0x00253491
		public unsafe UStaticMesh InstanceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_InstanceMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_InstanceMesh, value);
			}
		}

		// Token: 0x1700648F RID: 25743
		// (get) Token: 0x060193B4 RID: 103348 RVA: 0x002552A6 File Offset: 0x002534A6
		// (set) Token: 0x060193B5 RID: 103349 RVA: 0x002552BA File Offset: 0x002534BA
		public unsafe UMaterialInterface InstanceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_InstanceMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_InstanceMaterial, value);
			}
		}

		// Token: 0x17006490 RID: 25744
		// (get) Token: 0x060193B6 RID: 103350 RVA: 0x002552CF File Offset: 0x002534CF
		// (set) Token: 0x060193B7 RID: 103351 RVA: 0x002552E3 File Offset: 0x002534E3
		public unsafe UStaticMesh WholeMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_WholeMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_WholeMesh, value);
			}
		}

		// Token: 0x17006491 RID: 25745
		// (get) Token: 0x060193B8 RID: 103352 RVA: 0x002552F8 File Offset: 0x002534F8
		// (set) Token: 0x060193B9 RID: 103353 RVA: 0x0025530C File Offset: 0x0025350C
		public unsafe UStaticMesh WholeMeshMobile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_WholeMeshMobile);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_WholeMeshMobile, value);
			}
		}

		// Token: 0x17006492 RID: 25746
		// (get) Token: 0x060193BA RID: 103354 RVA: 0x00255321 File Offset: 0x00253521
		// (set) Token: 0x060193BB RID: 103355 RVA: 0x00255335 File Offset: 0x00253535
		public unsafe UMaterialInterface WholeMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_WholeMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveLeavesConfigData.__PropertyOffset_WholeMaterial, value);
			}
		}

		// Token: 0x17006493 RID: 25747
		// (get) Token: 0x060193BC RID: 103356 RVA: 0x0025534A File Offset: 0x0025354A
		// (set) Token: 0x060193BD RID: 103357 RVA: 0x0025535A File Offset: 0x0025355A
		public unsafe float PlayerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_PlayerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_PlayerRadius) = value;
			}
		}

		// Token: 0x17006494 RID: 25748
		// (get) Token: 0x060193BE RID: 103358 RVA: 0x0025536B File Offset: 0x0025356B
		// (set) Token: 0x060193BF RID: 103359 RVA: 0x0025537B File Offset: 0x0025357B
		public unsafe float ReviveRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_ReviveRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_ReviveRadius) = value;
			}
		}

		// Token: 0x17006495 RID: 25749
		// (get) Token: 0x060193C0 RID: 103360 RVA: 0x0025538C File Offset: 0x0025358C
		// (set) Token: 0x060193C1 RID: 103361 RVA: 0x0025539C File Offset: 0x0025359C
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_LifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_LifeTime) = value;
			}
		}

		// Token: 0x17006496 RID: 25750
		// (get) Token: 0x060193C2 RID: 103362 RVA: 0x002553AD File Offset: 0x002535AD
		// (set) Token: 0x060193C3 RID: 103363 RVA: 0x002553BD File Offset: 0x002535BD
		public unsafe float InitialAgeRandom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitialAgeRandom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitialAgeRandom) = value;
			}
		}

		// Token: 0x17006497 RID: 25751
		// (get) Token: 0x060193C4 RID: 103364 RVA: 0x002553CE File Offset: 0x002535CE
		// (set) Token: 0x060193C5 RID: 103365 RVA: 0x002553DE File Offset: 0x002535DE
		public unsafe float DisappearTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_DisappearTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_DisappearTime) = value;
			}
		}

		// Token: 0x17006498 RID: 25752
		// (get) Token: 0x060193C6 RID: 103366 RVA: 0x002553EF File Offset: 0x002535EF
		// (set) Token: 0x060193C7 RID: 103367 RVA: 0x002553FF File Offset: 0x002535FF
		public unsafe float ReviveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_ReviveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_ReviveTime) = value;
			}
		}

		// Token: 0x17006499 RID: 25753
		// (get) Token: 0x060193C8 RID: 103368 RVA: 0x00255410 File Offset: 0x00253610
		// (set) Token: 0x060193C9 RID: 103369 RVA: 0x00255420 File Offset: 0x00253620
		public unsafe float Drag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_Drag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_Drag) = value;
			}
		}

		// Token: 0x1700649A RID: 25754
		// (get) Token: 0x060193CA RID: 103370 RVA: 0x00255431 File Offset: 0x00253631
		// (set) Token: 0x060193CB RID: 103371 RVA: 0x00255441 File Offset: 0x00253641
		public unsafe float PlayerForceSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_PlayerForceSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_PlayerForceSize) = value;
			}
		}

		// Token: 0x1700649B RID: 25755
		// (get) Token: 0x060193CC RID: 103372 RVA: 0x00255452 File Offset: 0x00253652
		// (set) Token: 0x060193CD RID: 103373 RVA: 0x00255462 File Offset: 0x00253662
		public unsafe float PlayerForceExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_PlayerForceExp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_PlayerForceExp) = value;
			}
		}

		// Token: 0x1700649C RID: 25756
		// (get) Token: 0x060193CE RID: 103374 RVA: 0x00255473 File Offset: 0x00253673
		// (set) Token: 0x060193CF RID: 103375 RVA: 0x00255483 File Offset: 0x00253683
		public unsafe float InitVelocitySizeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitVelocitySizeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitVelocitySizeMin) = value;
			}
		}

		// Token: 0x1700649D RID: 25757
		// (get) Token: 0x060193D0 RID: 103376 RVA: 0x00255494 File Offset: 0x00253694
		// (set) Token: 0x060193D1 RID: 103377 RVA: 0x002554A4 File Offset: 0x002536A4
		public unsafe float InitVelocitySizeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitVelocitySizeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitVelocitySizeMax) = value;
			}
		}

		// Token: 0x1700649E RID: 25758
		// (get) Token: 0x060193D2 RID: 103378 RVA: 0x002554B5 File Offset: 0x002536B5
		// (set) Token: 0x060193D3 RID: 103379 RVA: 0x002554C5 File Offset: 0x002536C5
		public unsafe float InitFloatVelocitySizeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitFloatVelocitySizeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitFloatVelocitySizeMin) = value;
			}
		}

		// Token: 0x1700649F RID: 25759
		// (get) Token: 0x060193D4 RID: 103380 RVA: 0x002554D6 File Offset: 0x002536D6
		// (set) Token: 0x060193D5 RID: 103381 RVA: 0x002554E6 File Offset: 0x002536E6
		public unsafe float InitFloatVelocitySizeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitFloatVelocitySizeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_InitFloatVelocitySizeMax) = value;
			}
		}

		// Token: 0x170064A0 RID: 25760
		// (get) Token: 0x060193D6 RID: 103382 RVA: 0x002554F7 File Offset: 0x002536F7
		// (set) Token: 0x060193D7 RID: 103383 RVA: 0x0025550B File Offset: 0x0025370B
		public unsafe FVector ConstForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_ConstForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_ConstForce) = value;
			}
		}

		// Token: 0x170064A1 RID: 25761
		// (get) Token: 0x060193D8 RID: 103384 RVA: 0x00255520 File Offset: 0x00253720
		// (set) Token: 0x060193D9 RID: 103385 RVA: 0x00255559 File Offset: 0x00253759
		[Nullable(1)]
		public FKuroPointKdTree SpatialTree
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroPointKdTree result;
				if ((result = this._SpatialTree) == null)
				{
					result = (this._SpatialTree = new FKuroPointKdTree(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_SpatialTree, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroPointKdTree.StaticStruct(), base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_SpatialTree, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170064A2 RID: 25762
		// (get) Token: 0x060193DA RID: 103386 RVA: 0x0025557C File Offset: 0x0025377C
		// (set) Token: 0x060193DB RID: 103387 RVA: 0x002555B5 File Offset: 0x002537B5
		[Nullable(1)]
		public FKuroPointKdTree SpatialTreeMobile
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroPointKdTree result;
				if ((result = this._SpatialTreeMobile) == null)
				{
					result = (this._SpatialTreeMobile = new FKuroPointKdTree(base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_SpatialTreeMobile, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroPointKdTree.StaticStruct(), base.NativePtr + (IntPtr)UInteractiveLeavesConfigData.__PropertyOffset_SpatialTreeMobile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060193DC RID: 103388 RVA: 0x002555D6 File Offset: 0x002537D6
		static UInteractiveLeavesConfigData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.InteractiveLeavesConfigData");
		}

		// Token: 0x060193DD RID: 103389 RVA: 0x002555E4 File Offset: 0x002537E4
		protected UInteractiveLeavesConfigData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC34 RID: 56372
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.InteractiveLeavesConfigData";

		// Token: 0x0400DC35 RID: 56373
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC36 RID: 56374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC37 RID: 56375
		internal static int __PropertyOffset_PointCache;

		// Token: 0x0400DC38 RID: 56376
		internal static int __PropertyOffset_PointCacheMobile;

		// Token: 0x0400DC39 RID: 56377
		internal static int __PropertyOffset_InstanceMesh;

		// Token: 0x0400DC3A RID: 56378
		internal static int __PropertyOffset_InstanceMaterial;

		// Token: 0x0400DC3B RID: 56379
		internal static int __PropertyOffset_WholeMesh;

		// Token: 0x0400DC3C RID: 56380
		internal static int __PropertyOffset_WholeMeshMobile;

		// Token: 0x0400DC3D RID: 56381
		internal static int __PropertyOffset_WholeMaterial;

		// Token: 0x0400DC3E RID: 56382
		internal static int __PropertyOffset_PlayerRadius;

		// Token: 0x0400DC3F RID: 56383
		internal static int __PropertyOffset_ReviveRadius;

		// Token: 0x0400DC40 RID: 56384
		internal static int __PropertyOffset_LifeTime;

		// Token: 0x0400DC41 RID: 56385
		internal static int __PropertyOffset_InitialAgeRandom;

		// Token: 0x0400DC42 RID: 56386
		internal static int __PropertyOffset_DisappearTime;

		// Token: 0x0400DC43 RID: 56387
		internal static int __PropertyOffset_ReviveTime;

		// Token: 0x0400DC44 RID: 56388
		internal static int __PropertyOffset_Drag;

		// Token: 0x0400DC45 RID: 56389
		internal static int __PropertyOffset_PlayerForceSize;

		// Token: 0x0400DC46 RID: 56390
		internal static int __PropertyOffset_PlayerForceExp;

		// Token: 0x0400DC47 RID: 56391
		internal static int __PropertyOffset_InitVelocitySizeMin;

		// Token: 0x0400DC48 RID: 56392
		internal static int __PropertyOffset_InitVelocitySizeMax;

		// Token: 0x0400DC49 RID: 56393
		internal static int __PropertyOffset_InitFloatVelocitySizeMin;

		// Token: 0x0400DC4A RID: 56394
		internal static int __PropertyOffset_InitFloatVelocitySizeMax;

		// Token: 0x0400DC4B RID: 56395
		internal static int __PropertyOffset_ConstForce;

		// Token: 0x0400DC4C RID: 56396
		internal static int __PropertyOffset_SpatialTree;

		// Token: 0x0400DC4D RID: 56397
		private FKuroPointKdTree _SpatialTree;

		// Token: 0x0400DC4E RID: 56398
		internal static int __PropertyOffset_SpatialTreeMobile;

		// Token: 0x0400DC4F RID: 56399
		private FKuroPointKdTree _SpatialTreeMobile;
	}
}
