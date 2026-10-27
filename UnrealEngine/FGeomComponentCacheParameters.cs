using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001426 RID: 5158
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeomComponentCacheParameters")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FGeomComponentCacheParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012D17 RID: 77079 RVA: 0x001BADBE File Offset: 0x001B8FBE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeomComponentCacheParameters._ScriptStructPtr != 0) ? FGeomComponentCacheParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.GeomComponentCacheParameters", ref FGeomComponentCacheParameters._ScriptStructPtr);
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x06012D18 RID: 77080 RVA: 0x001BADE2 File Offset: 0x001B8FE2
		// (set) Token: 0x06012D19 RID: 77081 RVA: 0x001BADF2 File Offset: 0x001B8FF2
		public unsafe EGeometryCollectionCacheType CacheMode
		{
			get
			{
				return (EGeometryCollectionCacheType)(*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_CacheMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_CacheMode) = (byte)value;
			}
		}

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x06012D1A RID: 77082 RVA: 0x001BAE03 File Offset: 0x001B9003
		// (set) Token: 0x06012D1B RID: 77083 RVA: 0x001BAE17 File Offset: 0x001B9017
		[Nullable(2)]
		public unsafe UGeometryCollectionCache TargetCache
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCollectionCache>(base.NativePtr / (IntPtr)sizeof(void*) + FGeomComponentCacheParameters.__PropertyOffset_TargetCache);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGeomComponentCacheParameters.__PropertyOffset_TargetCache, value);
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x06012D1C RID: 77084 RVA: 0x001BAE2C File Offset: 0x001B902C
		// (set) Token: 0x06012D1D RID: 77085 RVA: 0x001BAE3C File Offset: 0x001B903C
		public unsafe float ReverseCacheBeginTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_ReverseCacheBeginTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_ReverseCacheBeginTime) = value;
			}
		}

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x06012D1E RID: 77086 RVA: 0x001BAE4D File Offset: 0x001B904D
		// (set) Token: 0x06012D1F RID: 77087 RVA: 0x001BAE5D File Offset: 0x001B905D
		public unsafe bool SaveCollisionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_SaveCollisionData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_SaveCollisionData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x06012D20 RID: 77088 RVA: 0x001BAE6E File Offset: 0x001B906E
		// (set) Token: 0x06012D21 RID: 77089 RVA: 0x001BAE7E File Offset: 0x001B907E
		public unsafe bool DoGenerateCollisionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoGenerateCollisionData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoGenerateCollisionData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x06012D22 RID: 77090 RVA: 0x001BAE8F File Offset: 0x001B908F
		// (set) Token: 0x06012D23 RID: 77091 RVA: 0x001BAE9F File Offset: 0x001B909F
		public unsafe int CollisionDataSizeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_CollisionDataSizeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_CollisionDataSizeMax) = value;
			}
		}

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x06012D24 RID: 77092 RVA: 0x001BAEB0 File Offset: 0x001B90B0
		// (set) Token: 0x06012D25 RID: 77093 RVA: 0x001BAEC0 File Offset: 0x001B90C0
		public unsafe bool DoCollisionDataSpatialHash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoCollisionDataSpatialHash) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoCollisionDataSpatialHash) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x06012D26 RID: 77094 RVA: 0x001BAED1 File Offset: 0x001B90D1
		// (set) Token: 0x06012D27 RID: 77095 RVA: 0x001BAEE1 File Offset: 0x001B90E1
		public unsafe float CollisionDataSpatialHashRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_CollisionDataSpatialHashRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_CollisionDataSpatialHashRadius) = value;
			}
		}

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x06012D28 RID: 77096 RVA: 0x001BAEF2 File Offset: 0x001B90F2
		// (set) Token: 0x06012D29 RID: 77097 RVA: 0x001BAF02 File Offset: 0x001B9102
		public unsafe int MaxCollisionPerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_MaxCollisionPerCell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_MaxCollisionPerCell) = value;
			}
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x06012D2A RID: 77098 RVA: 0x001BAF13 File Offset: 0x001B9113
		// (set) Token: 0x06012D2B RID: 77099 RVA: 0x001BAF23 File Offset: 0x001B9123
		public unsafe bool SaveBreakingData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_SaveBreakingData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_SaveBreakingData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x06012D2C RID: 77100 RVA: 0x001BAF34 File Offset: 0x001B9134
		// (set) Token: 0x06012D2D RID: 77101 RVA: 0x001BAF44 File Offset: 0x001B9144
		public unsafe bool DoGenerateBreakingData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoGenerateBreakingData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoGenerateBreakingData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x06012D2E RID: 77102 RVA: 0x001BAF55 File Offset: 0x001B9155
		// (set) Token: 0x06012D2F RID: 77103 RVA: 0x001BAF65 File Offset: 0x001B9165
		public unsafe int BreakingDataSizeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_BreakingDataSizeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_BreakingDataSizeMax) = value;
			}
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x06012D30 RID: 77104 RVA: 0x001BAF76 File Offset: 0x001B9176
		// (set) Token: 0x06012D31 RID: 77105 RVA: 0x001BAF86 File Offset: 0x001B9186
		public unsafe bool DoBreakingDataSpatialHash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoBreakingDataSpatialHash) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoBreakingDataSpatialHash) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x06012D32 RID: 77106 RVA: 0x001BAF97 File Offset: 0x001B9197
		// (set) Token: 0x06012D33 RID: 77107 RVA: 0x001BAFA7 File Offset: 0x001B91A7
		public unsafe float BreakingDataSpatialHashRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_BreakingDataSpatialHashRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_BreakingDataSpatialHashRadius) = value;
			}
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x06012D34 RID: 77108 RVA: 0x001BAFB8 File Offset: 0x001B91B8
		// (set) Token: 0x06012D35 RID: 77109 RVA: 0x001BAFC8 File Offset: 0x001B91C8
		public unsafe int MaxBreakingPerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_MaxBreakingPerCell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_MaxBreakingPerCell) = value;
			}
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x06012D36 RID: 77110 RVA: 0x001BAFD9 File Offset: 0x001B91D9
		// (set) Token: 0x06012D37 RID: 77111 RVA: 0x001BAFE9 File Offset: 0x001B91E9
		public unsafe bool SaveTrailingData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_SaveTrailingData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_SaveTrailingData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x06012D38 RID: 77112 RVA: 0x001BAFFA File Offset: 0x001B91FA
		// (set) Token: 0x06012D39 RID: 77113 RVA: 0x001BB00A File Offset: 0x001B920A
		public unsafe bool DoGenerateTrailingData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoGenerateTrailingData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_DoGenerateTrailingData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x06012D3A RID: 77114 RVA: 0x001BB01B File Offset: 0x001B921B
		// (set) Token: 0x06012D3B RID: 77115 RVA: 0x001BB02B File Offset: 0x001B922B
		public unsafe int TrailingDataSizeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_TrailingDataSizeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_TrailingDataSizeMax) = value;
			}
		}

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x06012D3C RID: 77116 RVA: 0x001BB03C File Offset: 0x001B923C
		// (set) Token: 0x06012D3D RID: 77117 RVA: 0x001BB04C File Offset: 0x001B924C
		public unsafe float TrailingMinSpeedThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_TrailingMinSpeedThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_TrailingMinSpeedThreshold) = value;
			}
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x06012D3E RID: 77118 RVA: 0x001BB05D File Offset: 0x001B925D
		// (set) Token: 0x06012D3F RID: 77119 RVA: 0x001BB06D File Offset: 0x001B926D
		public unsafe float TrailingMinVolumeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_TrailingMinVolumeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeomComponentCacheParameters.__PropertyOffset_TrailingMinVolumeThreshold) = value;
			}
		}

		// Token: 0x06012D40 RID: 77120 RVA: 0x001BB07E File Offset: 0x001B927E
		public FGeomComponentCacheParameters()
		{
		}

		// Token: 0x06012D41 RID: 77121 RVA: 0x001BB088 File Offset: 0x001B9288
		[NullableContext(1)]
		public FGeomComponentCacheParameters(EGeometryCollectionCacheType CacheMode, UGeometryCollectionCache TargetCache, float ReverseCacheBeginTime, bool SaveCollisionData, bool DoGenerateCollisionData, int CollisionDataSizeMax, bool DoCollisionDataSpatialHash, float CollisionDataSpatialHashRadius, int MaxCollisionPerCell, bool SaveBreakingData, bool DoGenerateBreakingData, int BreakingDataSizeMax, bool DoBreakingDataSpatialHash, float BreakingDataSpatialHashRadius, int MaxBreakingPerCell, bool SaveTrailingData, bool DoGenerateTrailingData, int TrailingDataSizeMax, float TrailingMinSpeedThreshold, float TrailingMinVolumeThreshold)
		{
			this.CacheMode = CacheMode;
			this.TargetCache = TargetCache;
			this.ReverseCacheBeginTime = ReverseCacheBeginTime;
			this.SaveCollisionData = SaveCollisionData;
			this.DoGenerateCollisionData = DoGenerateCollisionData;
			this.CollisionDataSizeMax = CollisionDataSizeMax;
			this.DoCollisionDataSpatialHash = DoCollisionDataSpatialHash;
			this.CollisionDataSpatialHashRadius = CollisionDataSpatialHashRadius;
			this.MaxCollisionPerCell = MaxCollisionPerCell;
			this.SaveBreakingData = SaveBreakingData;
			this.DoGenerateBreakingData = DoGenerateBreakingData;
			this.BreakingDataSizeMax = BreakingDataSizeMax;
			this.DoBreakingDataSpatialHash = DoBreakingDataSpatialHash;
			this.BreakingDataSpatialHashRadius = BreakingDataSpatialHashRadius;
			this.MaxBreakingPerCell = MaxBreakingPerCell;
			this.SaveTrailingData = SaveTrailingData;
			this.DoGenerateTrailingData = DoGenerateTrailingData;
			this.TrailingDataSizeMax = TrailingDataSizeMax;
			this.TrailingMinSpeedThreshold = TrailingMinSpeedThreshold;
			this.TrailingMinVolumeThreshold = TrailingMinVolumeThreshold;
		}

		// Token: 0x06012D42 RID: 77122 RVA: 0x001BB138 File Offset: 0x001B9338
		protected override IntPtr GetUStructPtr()
		{
			return FGeomComponentCacheParameters.StaticStruct();
		}

		// Token: 0x06012D43 RID: 77123 RVA: 0x001BB144 File Offset: 0x001B9344
		[NullableContext(2)]
		public FGeomComponentCacheParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012D44 RID: 77124 RVA: 0x001BB14E File Offset: 0x001B934E
		public FGeomComponentCacheParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012D45 RID: 77125 RVA: 0x001BB159 File Offset: 0x001B9359
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeomComponentCacheParameters(Pointer, false, true);
		}

		// Token: 0x06012D46 RID: 77126 RVA: 0x001BB163 File Offset: 0x001B9363
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeomComponentCacheParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400A0E8 RID: 41192
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeomComponentCacheParameters";

		// Token: 0x0400A0E9 RID: 41193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A0EA RID: 41194
		internal static int __PropertyOffset_CacheMode;

		// Token: 0x0400A0EB RID: 41195
		internal static int __PropertyOffset_TargetCache;

		// Token: 0x0400A0EC RID: 41196
		internal static int __PropertyOffset_ReverseCacheBeginTime;

		// Token: 0x0400A0ED RID: 41197
		internal static int __PropertyOffset_SaveCollisionData;

		// Token: 0x0400A0EE RID: 41198
		internal static int __PropertyOffset_DoGenerateCollisionData;

		// Token: 0x0400A0EF RID: 41199
		internal static int __PropertyOffset_CollisionDataSizeMax;

		// Token: 0x0400A0F0 RID: 41200
		internal static int __PropertyOffset_DoCollisionDataSpatialHash;

		// Token: 0x0400A0F1 RID: 41201
		internal static int __PropertyOffset_CollisionDataSpatialHashRadius;

		// Token: 0x0400A0F2 RID: 41202
		internal static int __PropertyOffset_MaxCollisionPerCell;

		// Token: 0x0400A0F3 RID: 41203
		internal static int __PropertyOffset_SaveBreakingData;

		// Token: 0x0400A0F4 RID: 41204
		internal static int __PropertyOffset_DoGenerateBreakingData;

		// Token: 0x0400A0F5 RID: 41205
		internal static int __PropertyOffset_BreakingDataSizeMax;

		// Token: 0x0400A0F6 RID: 41206
		internal static int __PropertyOffset_DoBreakingDataSpatialHash;

		// Token: 0x0400A0F7 RID: 41207
		internal static int __PropertyOffset_BreakingDataSpatialHashRadius;

		// Token: 0x0400A0F8 RID: 41208
		internal static int __PropertyOffset_MaxBreakingPerCell;

		// Token: 0x0400A0F9 RID: 41209
		internal static int __PropertyOffset_SaveTrailingData;

		// Token: 0x0400A0FA RID: 41210
		internal static int __PropertyOffset_DoGenerateTrailingData;

		// Token: 0x0400A0FB RID: 41211
		internal static int __PropertyOffset_TrailingDataSizeMax;

		// Token: 0x0400A0FC RID: 41212
		internal static int __PropertyOffset_TrailingMinSpeedThreshold;

		// Token: 0x0400A0FD RID: 41213
		internal static int __PropertyOffset_TrailingMinVolumeThreshold;
	}
}
