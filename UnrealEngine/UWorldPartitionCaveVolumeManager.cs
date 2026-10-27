using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001253 RID: 4691
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionCaveVolumeManager")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UWorldPartitionCaveVolumeManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011410 RID: 70672 RVA: 0x00195471 File Offset: 0x00193671
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionCaveVolumeManager._ClassPtr;
		}

		// Token: 0x06011411 RID: 70673 RVA: 0x00195480 File Offset: 0x00193680
		public UWorldPartitionCaveVolumeManager() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionCaveVolumeManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011412 RID: 70674 RVA: 0x001954A8 File Offset: 0x001936A8
		public UWorldPartitionCaveVolumeManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionCaveVolumeManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x06011413 RID: 70675 RVA: 0x001954DC File Offset: 0x001936DC
		// (set) Token: 0x06011414 RID: 70676 RVA: 0x00195515 File Offset: 0x00193715
		public TArray<AActor> CaveOrRoomVolumes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._CaveOrRoomVolumes) == null)
				{
					result = (this._CaveOrRoomVolumes = new TArray<AActor>(base.NativePtr + (IntPtr)UWorldPartitionCaveVolumeManager.__PropertyOffset_CaveOrRoomVolumes, this));
				}
				return result;
			}
			set
			{
				this.CaveOrRoomVolumes.CopyAssign(value);
			}
		}

		// Token: 0x06011415 RID: 70677 RVA: 0x00195523 File Offset: 0x00193723
		static UWorldPartitionCaveVolumeManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionCaveVolumeManager");
		}

		// Token: 0x06011416 RID: 70678 RVA: 0x00195531 File Offset: 0x00193731
		protected UWorldPartitionCaveVolumeManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093AF RID: 37807
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionCaveVolumeManager";

		// Token: 0x040093B0 RID: 37808
		private static IntPtr _ClassPtr;

		// Token: 0x040093B1 RID: 37809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093B2 RID: 37810
		internal static int __PropertyOffset_CaveOrRoomVolumes;

		// Token: 0x040093B3 RID: 37811
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _CaveOrRoomVolumes;
	}
}
