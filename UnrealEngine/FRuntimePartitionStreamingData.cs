using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010C2 RID: 4290
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimePartitionStreamingData")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FRuntimePartitionStreamingData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F4BF RID: 62655 RVA: 0x0016AE76 File Offset: 0x00169076
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimePartitionStreamingData._ScriptStructPtr != 0) ? FRuntimePartitionStreamingData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimePartitionStreamingData", ref FRuntimePartitionStreamingData._ScriptStructPtr);
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0600F4C0 RID: 62656 RVA: 0x0016AE9A File Offset: 0x0016909A
		// (set) Token: 0x0600F4C1 RID: 62657 RVA: 0x0016AEAE File Offset: 0x001690AE
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0600F4C2 RID: 62658 RVA: 0x0016AEC3 File Offset: 0x001690C3
		// (set) Token: 0x0600F4C3 RID: 62659 RVA: 0x0016AED3 File Offset: 0x001690D3
		public unsafe int LoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_LoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_LoadingRange) = value;
			}
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0600F4C4 RID: 62660 RVA: 0x0016AEE4 File Offset: 0x001690E4
		// (set) Token: 0x0600F4C5 RID: 62661 RVA: 0x0016AF27 File Offset: 0x00169127
		public TArray<UWorldPartitionRuntimeCell> SpatiallyLoadedCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._SpatiallyLoadedCells) == null)
				{
					result = (this._SpatiallyLoadedCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_SpatiallyLoadedCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpatiallyLoadedCells.CopyAssign(value);
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x0600F4C6 RID: 62662 RVA: 0x0016AF38 File Offset: 0x00169138
		// (set) Token: 0x0600F4C7 RID: 62663 RVA: 0x0016AF7B File Offset: 0x0016917B
		public TArray<UWorldPartitionRuntimeCell> NonSpatiallyLoadedCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._NonSpatiallyLoadedCells) == null)
				{
					result = (this._NonSpatiallyLoadedCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_NonSpatiallyLoadedCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NonSpatiallyLoadedCells.CopyAssign(value);
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x0600F4C8 RID: 62664 RVA: 0x0016AF89 File Offset: 0x00169189
		// (set) Token: 0x0600F4C9 RID: 62665 RVA: 0x0016AF99 File Offset: 0x00169199
		public unsafe float LoadingRangeScaleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_LoadingRangeScaleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionStreamingData.__PropertyOffset_LoadingRangeScaleFactor) = value;
			}
		}

		// Token: 0x0600F4CA RID: 62666 RVA: 0x0016AFAA File Offset: 0x001691AA
		public FRuntimePartitionStreamingData()
		{
		}

		// Token: 0x0600F4CB RID: 62667 RVA: 0x0016AFB2 File Offset: 0x001691B2
		public FRuntimePartitionStreamingData(FName Name, string DebugName, int LoadingRange, TArray<UWorldPartitionRuntimeCell> SpatiallyLoadedCells, TArray<UWorldPartitionRuntimeCell> NonSpatiallyLoadedCells, float LoadingRangeScaleFactor)
		{
			this.Name = Name;
			this.LoadingRange = LoadingRange;
			this.SpatiallyLoadedCells = SpatiallyLoadedCells;
			this.NonSpatiallyLoadedCells = NonSpatiallyLoadedCells;
			this.LoadingRangeScaleFactor = LoadingRangeScaleFactor;
		}

		// Token: 0x0600F4CC RID: 62668 RVA: 0x0016AFE0 File Offset: 0x001691E0
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimePartitionStreamingData.StaticStruct();
		}

		// Token: 0x0600F4CD RID: 62669 RVA: 0x0016AFEC File Offset: 0x001691EC
		[NullableContext(2)]
		public FRuntimePartitionStreamingData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F4CE RID: 62670 RVA: 0x0016AFF6 File Offset: 0x001691F6
		public FRuntimePartitionStreamingData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F4CF RID: 62671 RVA: 0x0016B001 File Offset: 0x00169201
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimePartitionStreamingData(Pointer, false, true);
		}

		// Token: 0x0600F4D0 RID: 62672 RVA: 0x0016B00B File Offset: 0x0016920B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimePartitionStreamingData(Pointer, MemoryOwner);
		}

		// Token: 0x040084A3 RID: 33955
		public const string __ObjectPath = "/Script/Engine.RuntimePartitionStreamingData";

		// Token: 0x040084A4 RID: 33956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040084A5 RID: 33957
		internal static int __PropertyOffset_Name;

		// Token: 0x040084A6 RID: 33958
		internal static int __PropertyOffset_LoadingRange;

		// Token: 0x040084A7 RID: 33959
		internal static int __PropertyOffset_SpatiallyLoadedCells;

		// Token: 0x040084A8 RID: 33960
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _SpatiallyLoadedCells;

		// Token: 0x040084A9 RID: 33961
		internal static int __PropertyOffset_NonSpatiallyLoadedCells;

		// Token: 0x040084AA RID: 33962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _NonSpatiallyLoadedCells;

		// Token: 0x040084AB RID: 33963
		internal static int __PropertyOffset_LoadingRangeScaleFactor;
	}
}
