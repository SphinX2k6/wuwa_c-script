using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001281 RID: 4737
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionSettingAsset")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UWorldPartitionSettingAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060115A3 RID: 71075 RVA: 0x0019780F File Offset: 0x00195A0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionSettingAsset._ClassPtr;
		}

		// Token: 0x060115A4 RID: 71076 RVA: 0x0019781C File Offset: 0x00195A1C
		public UWorldPartitionSettingAsset() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSettingAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060115A5 RID: 71077 RVA: 0x00197844 File Offset: 0x00195A44
		public UWorldPartitionSettingAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSettingAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x060115A6 RID: 71078 RVA: 0x00197878 File Offset: 0x00195A78
		// (set) Token: 0x060115A7 RID: 71079 RVA: 0x001978B1 File Offset: 0x00195AB1
		public TArray<FRuntimePartitionDesc> RuntimePartitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimePartitionDesc> result;
				if ((result = this._RuntimePartitions) == null)
				{
					result = (this._RuntimePartitions = new TArray<FRuntimePartitionDesc>(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_RuntimePartitions, this));
				}
				return result;
			}
			set
			{
				this.RuntimePartitions.CopyAssign(value);
			}
		}

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x060115A8 RID: 71080 RVA: 0x001978BF File Offset: 0x00195ABF
		// (set) Token: 0x060115A9 RID: 71081 RVA: 0x001978CF File Offset: 0x00195ACF
		public unsafe float HFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_HFov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_HFov) = value;
			}
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x060115AA RID: 71082 RVA: 0x001978E0 File Offset: 0x00195AE0
		// (set) Token: 0x060115AB RID: 71083 RVA: 0x001978F0 File Offset: 0x00195AF0
		public unsafe int VisibleScreenRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_VisibleScreenRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_VisibleScreenRatio) = value;
			}
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x060115AC RID: 71084 RVA: 0x00197901 File Offset: 0x00195B01
		// (set) Token: 0x060115AD RID: 71085 RVA: 0x00197911 File Offset: 0x00195B11
		public unsafe float MaxCellNumInLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_MaxCellNumInLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_MaxCellNumInLoadingRange) = value;
			}
		}

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x060115AE RID: 71086 RVA: 0x00197924 File Offset: 0x00195B24
		// (set) Token: 0x060115AF RID: 71087 RVA: 0x0019795D File Offset: 0x00195B5D
		public TArray<int> HLODSizeThreshold
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._HLODSizeThreshold) == null)
				{
					result = (this._HLODSizeThreshold = new TArray<int>(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_HLODSizeThreshold, this));
				}
				return result;
			}
			set
			{
				this.HLODSizeThreshold.CopyAssign(value);
			}
		}

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x060115B0 RID: 71088 RVA: 0x0019796C File Offset: 0x00195B6C
		// (set) Token: 0x060115B1 RID: 71089 RVA: 0x001979A5 File Offset: 0x00195BA5
		public TArray<FRuntimePartitionPolicyDesc> RuntimePartitionDividDescs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimePartitionPolicyDesc> result;
				if ((result = this._RuntimePartitionDividDescs) == null)
				{
					result = (this._RuntimePartitionDividDescs = new TArray<FRuntimePartitionPolicyDesc>(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_RuntimePartitionDividDescs, this));
				}
				return result;
			}
			set
			{
				this.RuntimePartitionDividDescs.CopyAssign(value);
			}
		}

		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x060115B2 RID: 71090 RVA: 0x001979B4 File Offset: 0x00195BB4
		// (set) Token: 0x060115B3 RID: 71091 RVA: 0x001979ED File Offset: 0x00195BED
		public TSet<UDataLayer> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UDataLayer> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TSet<UDataLayer>(base.NativePtr + (IntPtr)UWorldPartitionSettingAsset.__PropertyOffset_DataLayers, this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x060115B4 RID: 71092 RVA: 0x001979FB File Offset: 0x00195BFB
		static UWorldPartitionSettingAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionSettingAsset");
		}

		// Token: 0x060115B5 RID: 71093 RVA: 0x00197A09 File Offset: 0x00195C09
		protected UWorldPartitionSettingAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400948F RID: 38031
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionSettingAsset";

		// Token: 0x04009490 RID: 38032
		private static IntPtr _ClassPtr;

		// Token: 0x04009491 RID: 38033
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009492 RID: 38034
		internal static int __PropertyOffset_RuntimePartitions;

		// Token: 0x04009493 RID: 38035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimePartitionDesc> _RuntimePartitions;

		// Token: 0x04009494 RID: 38036
		internal static int __PropertyOffset_HFov;

		// Token: 0x04009495 RID: 38037
		internal static int __PropertyOffset_VisibleScreenRatio;

		// Token: 0x04009496 RID: 38038
		internal static int __PropertyOffset_MaxCellNumInLoadingRange;

		// Token: 0x04009497 RID: 38039
		internal static int __PropertyOffset_HLODSizeThreshold;

		// Token: 0x04009498 RID: 38040
		[Nullable(2)]
		private TArray<int> _HLODSizeThreshold;

		// Token: 0x04009499 RID: 38041
		internal static int __PropertyOffset_RuntimePartitionDividDescs;

		// Token: 0x0400949A RID: 38042
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimePartitionPolicyDesc> _RuntimePartitionDividDescs;

		// Token: 0x0400949B RID: 38043
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x0400949C RID: 38044
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UDataLayer> _DataLayers;
	}
}
