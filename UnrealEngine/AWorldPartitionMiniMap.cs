using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001267 RID: 4711
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionMiniMap")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class AWorldPartitionMiniMap : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601148F RID: 70799 RVA: 0x00196156 File Offset: 0x00194356
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionMiniMap._ClassPtr;
		}

		// Token: 0x06011490 RID: 70800 RVA: 0x00196164 File Offset: 0x00194364
		public AWorldPartitionMiniMap() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionMiniMap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011491 RID: 70801 RVA: 0x0019618C File Offset: 0x0019438C
		public AWorldPartitionMiniMap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionMiniMap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x06011492 RID: 70802 RVA: 0x001961BF File Offset: 0x001943BF
		// (set) Token: 0x06011493 RID: 70803 RVA: 0x001961CF File Offset: 0x001943CF
		public unsafe int MinX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MinX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MinX) = value;
			}
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x06011494 RID: 70804 RVA: 0x001961E0 File Offset: 0x001943E0
		// (set) Token: 0x06011495 RID: 70805 RVA: 0x001961F0 File Offset: 0x001943F0
		public unsafe int MaxX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MaxX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MaxX) = value;
			}
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x06011496 RID: 70806 RVA: 0x00196201 File Offset: 0x00194401
		// (set) Token: 0x06011497 RID: 70807 RVA: 0x00196211 File Offset: 0x00194411
		public unsafe int MinY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MinY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MinY) = value;
			}
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x06011498 RID: 70808 RVA: 0x00196222 File Offset: 0x00194422
		// (set) Token: 0x06011499 RID: 70809 RVA: 0x00196232 File Offset: 0x00194432
		public unsafe int MaxY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MaxY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MaxY) = value;
			}
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x0601149A RID: 70810 RVA: 0x00196243 File Offset: 0x00194443
		// (set) Token: 0x0601149B RID: 70811 RVA: 0x00196253 File Offset: 0x00194453
		public unsafe int CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x0601149C RID: 70812 RVA: 0x00196264 File Offset: 0x00194464
		// (set) Token: 0x0601149D RID: 70813 RVA: 0x00196278 File Offset: 0x00194478
		public unsafe FBox MiniMapWorldBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MiniMapWorldBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MiniMapWorldBounds) = value;
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x0601149E RID: 70814 RVA: 0x0019628D File Offset: 0x0019448D
		// (set) Token: 0x0601149F RID: 70815 RVA: 0x001962A1 File Offset: 0x001944A1
		[Nullable(2)]
		public unsafe UTexture2D MiniMapTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + AWorldPartitionMiniMap.__PropertyOffset_MiniMapTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AWorldPartitionMiniMap.__PropertyOffset_MiniMapTexture, value);
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x060114A0 RID: 70816 RVA: 0x001962B8 File Offset: 0x001944B8
		// (set) Token: 0x060114A1 RID: 70817 RVA: 0x001962F1 File Offset: 0x001944F1
		public TArray<FActorDataLayer> ExcludedDataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorDataLayer> result;
				if ((result = this._ExcludedDataLayers) == null)
				{
					result = (this._ExcludedDataLayers = new TArray<FActorDataLayer>(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_ExcludedDataLayers, this));
				}
				return result;
			}
			set
			{
				this.ExcludedDataLayers.CopyAssign(value);
			}
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x060114A2 RID: 70818 RVA: 0x001962FF File Offset: 0x001944FF
		// (set) Token: 0x060114A3 RID: 70819 RVA: 0x0019630F File Offset: 0x0019450F
		public unsafe int MiniMapSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MiniMapSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_MiniMapSize) = value;
			}
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x060114A4 RID: 70820 RVA: 0x00196320 File Offset: 0x00194520
		// (set) Token: 0x060114A5 RID: 70821 RVA: 0x00196330 File Offset: 0x00194530
		public unsafe bool bUseMapPNG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_bUseMapPNG) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionMiniMap.__PropertyOffset_bUseMapPNG) = (value ? 1 : 0);
			}
		}

		// Token: 0x060114A6 RID: 70822 RVA: 0x00196341 File Offset: 0x00194541
		static AWorldPartitionMiniMap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionMiniMap");
		}

		// Token: 0x060114A7 RID: 70823 RVA: 0x0019634F File Offset: 0x0019454F
		protected AWorldPartitionMiniMap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009404 RID: 37892
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionMiniMap";

		// Token: 0x04009405 RID: 37893
		private static IntPtr _ClassPtr;

		// Token: 0x04009406 RID: 37894
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009407 RID: 37895
		internal static int __PropertyOffset_MinX;

		// Token: 0x04009408 RID: 37896
		internal static int __PropertyOffset_MaxX;

		// Token: 0x04009409 RID: 37897
		internal static int __PropertyOffset_MinY;

		// Token: 0x0400940A RID: 37898
		internal static int __PropertyOffset_MaxY;

		// Token: 0x0400940B RID: 37899
		internal static int __PropertyOffset_CellSize;

		// Token: 0x0400940C RID: 37900
		internal static int __PropertyOffset_MiniMapWorldBounds;

		// Token: 0x0400940D RID: 37901
		internal static int __PropertyOffset_MiniMapTexture;

		// Token: 0x0400940E RID: 37902
		internal static int __PropertyOffset_ExcludedDataLayers;

		// Token: 0x0400940F RID: 37903
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorDataLayer> _ExcludedDataLayers;

		// Token: 0x04009410 RID: 37904
		internal static int __PropertyOffset_MiniMapSize;

		// Token: 0x04009411 RID: 37905
		internal static int __PropertyOffset_bUseMapPNG;
	}
}
