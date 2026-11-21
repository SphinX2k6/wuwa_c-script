using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002B2 RID: 690
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingQuerySource")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FWorldPartitionStreamingQuerySource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004AAE RID: 19118 RVA: 0x00068883 File Offset: 0x00066A83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionStreamingQuerySource._ScriptStructPtr != 0) ? FWorldPartitionStreamingQuerySource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionStreamingQuerySource", ref FWorldPartitionStreamingQuerySource._ScriptStructPtr);
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06004AAF RID: 19119 RVA: 0x000688A7 File Offset: 0x00066AA7
		// (set) Token: 0x06004AB0 RID: 19120 RVA: 0x000688BB File Offset: 0x00066ABB
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

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x000688D0 File Offset: 0x00066AD0
		// (set) Token: 0x06004AB2 RID: 19122 RVA: 0x000688E0 File Offset: 0x00066AE0
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

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x000688F1 File Offset: 0x00066AF1
		// (set) Token: 0x06004AB4 RID: 19124 RVA: 0x00068901 File Offset: 0x00066B01
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06004AB5 RID: 19125 RVA: 0x00068912 File Offset: 0x00066B12
		// (set) Token: 0x06004AB6 RID: 19126 RVA: 0x00068922 File Offset: 0x00066B22
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x00068934 File Offset: 0x00066B34
		// (set) Token: 0x06004AB8 RID: 19128 RVA: 0x00068977 File Offset: 0x00066B77
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

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06004AB9 RID: 19129 RVA: 0x00068985 File Offset: 0x00066B85
		// (set) Token: 0x06004ABA RID: 19130 RVA: 0x00068995 File Offset: 0x00066B95
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x000689A6 File Offset: 0x00066BA6
		// (set) Token: 0x06004ABC RID: 19132 RVA: 0x000689B6 File Offset: 0x00066BB6
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x000689C8 File Offset: 0x00066BC8
		// (set) Token: 0x06004ABE RID: 19134 RVA: 0x00068A0B File Offset: 0x00066C0B
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

		// Token: 0x06004ABF RID: 19135 RVA: 0x00068A19 File Offset: 0x00066C19
		public FWorldPartitionStreamingQuerySource()
		{
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x00068A21 File Offset: 0x00066C21
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionStreamingQuerySource.StaticStruct();
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00068A2D File Offset: 0x00066C2D
		[NullableContext(2)]
		public FWorldPartitionStreamingQuerySource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00068A37 File Offset: 0x00066C37
		public FWorldPartitionStreamingQuerySource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x00068A42 File Offset: 0x00066C42
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionStreamingQuerySource(Pointer, false, true);
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00068A4C File Offset: 0x00066C4C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionStreamingQuerySource(Pointer, MemoryOwner);
		}

		// Token: 0x04001D75 RID: 7541
		public const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingQuerySource";

		// Token: 0x04001D76 RID: 7542
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D77 RID: 7543
		internal static int __PropertyOffset_Location;

		// Token: 0x04001D78 RID: 7544
		internal static int __PropertyOffset_Radius;

		// Token: 0x04001D79 RID: 7545
		internal static int __PropertyOffset_bUseGridLoadingRange;

		// Token: 0x04001D7A RID: 7546
		internal static int __PropertyOffset_bEnableDataLayerTest;

		// Token: 0x04001D7B RID: 7547
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x04001D7C RID: 7548
		[Nullable(2)]
		private TSet<FName> _DataLayers;

		// Token: 0x04001D7D RID: 7549
		internal static int __PropertyOffset_bDataLayersOnly;

		// Token: 0x04001D7E RID: 7550
		internal static int __PropertyOffset_bSpatialQuery;

		// Token: 0x04001D7F RID: 7551
		internal static int __PropertyOffset_TargetGrids;

		// Token: 0x04001D80 RID: 7552
		[Nullable(2)]
		private TSet<FName> _TargetGrids;
	}
}
