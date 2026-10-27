using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001264 RID: 4708
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionKuroCellLayerVolume")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class AWorldPartitionKuroCellLayerVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601146E RID: 70766 RVA: 0x00195D66 File Offset: 0x00193F66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionKuroCellLayerVolume._ClassPtr;
		}

		// Token: 0x0601146F RID: 70767 RVA: 0x00195D74 File Offset: 0x00193F74
		public AWorldPartitionKuroCellLayerVolume() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionKuroCellLayerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011470 RID: 70768 RVA: 0x00195D9C File Offset: 0x00193F9C
		public AWorldPartitionKuroCellLayerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionKuroCellLayerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x06011471 RID: 70769 RVA: 0x00195DD0 File Offset: 0x00193FD0
		// (set) Token: 0x06011472 RID: 70770 RVA: 0x00195E09 File Offset: 0x00194009
		public FKuroCellLayerVolumeData Data
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCellLayerVolumeData result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new FKuroCellLayerVolumeData(base.NativePtr + (IntPtr)AWorldPartitionKuroCellLayerVolume.__PropertyOffset_Data, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCellLayerVolumeData.StaticStruct(), base.NativePtr + (IntPtr)AWorldPartitionKuroCellLayerVolume.__PropertyOffset_Data, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06011473 RID: 70771 RVA: 0x00195E2A File Offset: 0x0019402A
		static AWorldPartitionKuroCellLayerVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionKuroCellLayerVolume");
		}

		// Token: 0x06011474 RID: 70772 RVA: 0x00195E38 File Offset: 0x00194038
		protected AWorldPartitionKuroCellLayerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093EC RID: 37868
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionKuroCellLayerVolume";

		// Token: 0x040093ED RID: 37869
		private static IntPtr _ClassPtr;

		// Token: 0x040093EE RID: 37870
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093EF RID: 37871
		internal static int __PropertyOffset_Data;

		// Token: 0x040093F0 RID: 37872
		[Nullable(2)]
		private FKuroCellLayerVolumeData _Data;
	}
}
