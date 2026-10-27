using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001252 RID: 4690
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionCaveVolume")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class AWorldPartitionCaveVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011405 RID: 70661 RVA: 0x0019537D File Offset: 0x0019357D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionCaveVolume._ClassPtr;
		}

		// Token: 0x06011406 RID: 70662 RVA: 0x0019538C File Offset: 0x0019358C
		public AWorldPartitionCaveVolume() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionCaveVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011407 RID: 70663 RVA: 0x001953B4 File Offset: 0x001935B4
		public AWorldPartitionCaveVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionCaveVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x06011408 RID: 70664 RVA: 0x001953E7 File Offset: 0x001935E7
		// (set) Token: 0x06011409 RID: 70665 RVA: 0x001953F7 File Offset: 0x001935F7
		public unsafe ECaveOrRoom VolumeType
		{
			get
			{
				return (ECaveOrRoom)(*(base.NativePtr + (IntPtr)AWorldPartitionCaveVolume.__PropertyOffset_VolumeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionCaveVolume.__PropertyOffset_VolumeType) = (byte)value;
			}
		}

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x0601140A RID: 70666 RVA: 0x00195408 File Offset: 0x00193608
		// (set) Token: 0x0601140B RID: 70667 RVA: 0x0019541C File Offset: 0x0019361C
		public unsafe string EnClosetDataLayer
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AWorldPartitionCaveVolume.__PropertyOffset_EnClosetDataLayer)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AWorldPartitionCaveVolume.__PropertyOffset_EnClosetDataLayer)), value);
			}
		}

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x0601140C RID: 70668 RVA: 0x00195431 File Offset: 0x00193631
		// (set) Token: 0x0601140D RID: 70669 RVA: 0x00195445 File Offset: 0x00193645
		public unsafe string EnCloseSubDataLayer
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AWorldPartitionCaveVolume.__PropertyOffset_EnCloseSubDataLayer)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AWorldPartitionCaveVolume.__PropertyOffset_EnCloseSubDataLayer)), value);
			}
		}

		// Token: 0x0601140E RID: 70670 RVA: 0x0019545A File Offset: 0x0019365A
		static AWorldPartitionCaveVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionCaveVolume");
		}

		// Token: 0x0601140F RID: 70671 RVA: 0x00195468 File Offset: 0x00193668
		protected AWorldPartitionCaveVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093A9 RID: 37801
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionCaveVolume";

		// Token: 0x040093AA RID: 37802
		private static IntPtr _ClassPtr;

		// Token: 0x040093AB RID: 37803
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093AC RID: 37804
		internal static int __PropertyOffset_VolumeType;

		// Token: 0x040093AD RID: 37805
		internal static int __PropertyOffset_EnClosetDataLayer;

		// Token: 0x040093AE RID: 37806
		internal static int __PropertyOffset_EnCloseSubDataLayer;
	}
}
