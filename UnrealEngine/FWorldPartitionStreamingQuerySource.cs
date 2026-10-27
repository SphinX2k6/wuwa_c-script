using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001288 RID: 4744
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingQuerySource")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FWorldPartitionStreamingQuerySource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011604 RID: 71172 RVA: 0x001981CC File Offset: 0x001963CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionStreamingQuerySource._ScriptStructPtr != 0) ? FWorldPartitionStreamingQuerySource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionStreamingQuerySource", ref FWorldPartitionStreamingQuerySource._ScriptStructPtr);
		}

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x06011605 RID: 71173 RVA: 0x001981F0 File Offset: 0x001963F0
		// (set) Token: 0x06011606 RID: 71174 RVA: 0x00198204 File Offset: 0x00196404
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170043B1 RID: 17329
		// (get) Token: 0x06011607 RID: 71175 RVA: 0x00198219 File Offset: 0x00196419
		// (set) Token: 0x06011608 RID: 71176 RVA: 0x00198229 File Offset: 0x00196429
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170043B2 RID: 17330
		// (get) Token: 0x06011609 RID: 71177 RVA: 0x0019823A File Offset: 0x0019643A
		// (set) Token: 0x0601160A RID: 71178 RVA: 0x0019824A File Offset: 0x0019644A
		public unsafe bool bUseGridLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bUseGridLoadingRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bUseGridLoadingRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x0601160B RID: 71179 RVA: 0x0019825B File Offset: 0x0019645B
		// (set) Token: 0x0601160C RID: 71180 RVA: 0x0019826B File Offset: 0x0019646B
		public unsafe bool bEnableDataLayerTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bEnableDataLayerTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bEnableDataLayerTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x0601160D RID: 71181 RVA: 0x0019827C File Offset: 0x0019647C
		// (set) Token: 0x0601160E RID: 71182 RVA: 0x001982BF File Offset: 0x001964BF
		public TSet<FName> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TSet<FName>(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x0601160F RID: 71183 RVA: 0x001982CD File Offset: 0x001964CD
		// (set) Token: 0x06011610 RID: 71184 RVA: 0x001982DD File Offset: 0x001964DD
		public unsafe bool bDataLayersOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bDataLayersOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bDataLayersOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x06011611 RID: 71185 RVA: 0x001982EE File Offset: 0x001964EE
		// (set) Token: 0x06011612 RID: 71186 RVA: 0x001982FE File Offset: 0x001964FE
		public unsafe bool bSpatialQuery
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bSpatialQuery) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_bSpatialQuery) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x06011613 RID: 71187 RVA: 0x00198310 File Offset: 0x00196510
		// (set) Token: 0x06011614 RID: 71188 RVA: 0x00198353 File Offset: 0x00196553
		public TSet<FName> TargetGrids
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._TargetGrids) == null)
				{
					result = (this._TargetGrids = new TSet<FName>(base.NativePtr + (IntPtr)FWorldPartitionStreamingQuerySource.__PropertyOffset_TargetGrids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TargetGrids.CopyAssign(value);
			}
		}

		// Token: 0x06011615 RID: 71189 RVA: 0x00198361 File Offset: 0x00196561
		public FWorldPartitionStreamingQuerySource()
		{
		}

		// Token: 0x06011616 RID: 71190 RVA: 0x0019836C File Offset: 0x0019656C
		public FWorldPartitionStreamingQuerySource(FVector Location, float Radius, bool bUseGridLoadingRange, bool bEnableDataLayerTest, TSet<FName> DataLayers, bool bDataLayersOnly, bool bSpatialQuery, TSet<FName> TargetGrids)
		{
			this.Location = Location;
			this.Radius = Radius;
			this.bUseGridLoadingRange = bUseGridLoadingRange;
			this.bEnableDataLayerTest = bEnableDataLayerTest;
			this.DataLayers = DataLayers;
			this.bDataLayersOnly = bDataLayersOnly;
			this.bSpatialQuery = bSpatialQuery;
			this.TargetGrids = TargetGrids;
		}

		// Token: 0x06011617 RID: 71191 RVA: 0x001983BC File Offset: 0x001965BC
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionStreamingQuerySource.StaticStruct();
		}

		// Token: 0x06011618 RID: 71192 RVA: 0x001983C8 File Offset: 0x001965C8
		[NullableContext(2)]
		public FWorldPartitionStreamingQuerySource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011619 RID: 71193 RVA: 0x001983D2 File Offset: 0x001965D2
		public FWorldPartitionStreamingQuerySource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601161A RID: 71194 RVA: 0x001983DD File Offset: 0x001965DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionStreamingQuerySource(Pointer, false, true);
		}

		// Token: 0x0601161B RID: 71195 RVA: 0x001983E7 File Offset: 0x001965E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionStreamingQuerySource(Pointer, MemoryOwner);
		}

		// Token: 0x040094C8 RID: 38088
		public const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingQuerySource";

		// Token: 0x040094C9 RID: 38089
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040094CA RID: 38090
		internal static int __PropertyOffset_Location;

		// Token: 0x040094CB RID: 38091
		internal static int __PropertyOffset_Radius;

		// Token: 0x040094CC RID: 38092
		internal static int __PropertyOffset_bUseGridLoadingRange;

		// Token: 0x040094CD RID: 38093
		internal static int __PropertyOffset_bEnableDataLayerTest;

		// Token: 0x040094CE RID: 38094
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x040094CF RID: 38095
		[Nullable(2)]
		private TSet<FName> _DataLayers;

		// Token: 0x040094D0 RID: 38096
		internal static int __PropertyOffset_bDataLayersOnly;

		// Token: 0x040094D1 RID: 38097
		internal static int __PropertyOffset_bSpatialQuery;

		// Token: 0x040094D2 RID: 38098
		internal static int __PropertyOffset_TargetGrids;

		// Token: 0x040094D3 RID: 38099
		[Nullable(2)]
		private TSet<FName> _TargetGrids;
	}
}
