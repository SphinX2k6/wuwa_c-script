using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001283 RID: 4739
	[UnrealObjectPath("/Script/Engine.WorldPartitionStandaloneHLOD")]
	[UnrealStructLayout(1368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1368)]
	public class AWorldPartitionStandaloneHLOD : AActor, IUnrealUObject, IUnrealObject, ILevelInstanceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060115C3 RID: 71107 RVA: 0x00197B4D File Offset: 0x00195D4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionStandaloneHLOD._ClassPtr;
		}

		// Token: 0x060115C4 RID: 71108 RVA: 0x00197B59 File Offset: 0x00195D59
		int ILevelInstanceInterface.InterfaceOffset()
		{
			return AWorldPartitionStandaloneHLOD.__InterfaceOffset_ILevelInstanceInterface;
		}

		// Token: 0x060115C5 RID: 71109 RVA: 0x00197B60 File Offset: 0x00195D60
		public AWorldPartitionStandaloneHLOD() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionStandaloneHLOD.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060115C6 RID: 71110 RVA: 0x00197B88 File Offset: 0x00195D88
		[NullableContext(1)]
		public AWorldPartitionStandaloneHLOD(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionStandaloneHLOD.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x060115C7 RID: 71111 RVA: 0x00197BBB File Offset: 0x00195DBB
		// (set) Token: 0x060115C8 RID: 71112 RVA: 0x00197BD0 File Offset: 0x00195DD0
		[Nullable(1)]
		public TSoftObjectPtr<UWorld> WorldAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UWorld>(base.NativePtr + (IntPtr)AWorldPartitionStandaloneHLOD.__PropertyOffset_WorldAsset, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)AWorldPartitionStandaloneHLOD.__PropertyOffset_WorldAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x060115C9 RID: 71113 RVA: 0x00197BF5 File Offset: 0x00195DF5
		// (set) Token: 0x060115CA RID: 71114 RVA: 0x00197C09 File Offset: 0x00195E09
		public unsafe FGuid LevelInstanceSpawnGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionStandaloneHLOD.__PropertyOffset_LevelInstanceSpawnGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionStandaloneHLOD.__PropertyOffset_LevelInstanceSpawnGuid) = value;
			}
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x060115CB RID: 71115 RVA: 0x00197C1E File Offset: 0x00195E1E
		// (set) Token: 0x060115CC RID: 71116 RVA: 0x00197C32 File Offset: 0x00195E32
		public unsafe FGuid SourceLevelInstanceGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionStandaloneHLOD.__PropertyOffset_SourceLevelInstanceGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionStandaloneHLOD.__PropertyOffset_SourceLevelInstanceGuid) = value;
			}
		}

		// Token: 0x060115CD RID: 71117 RVA: 0x00197C47 File Offset: 0x00195E47
		static AWorldPartitionStandaloneHLOD()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStandaloneHLOD");
		}

		// Token: 0x060115CE RID: 71118 RVA: 0x00197C55 File Offset: 0x00195E55
		protected AWorldPartitionStandaloneHLOD(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094A5 RID: 38053
		internal static int __InterfaceOffset_ILevelInstanceInterface;

		// Token: 0x040094A6 RID: 38054
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStandaloneHLOD";

		// Token: 0x040094A7 RID: 38055
		private static IntPtr _ClassPtr;

		// Token: 0x040094A8 RID: 38056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040094A9 RID: 38057
		internal static int __PropertyOffset_WorldAsset;

		// Token: 0x040094AA RID: 38058
		internal static int __PropertyOffset_LevelInstanceSpawnGuid;

		// Token: 0x040094AB RID: 38059
		internal static int __PropertyOffset_SourceLevelInstanceGuid;
	}
}
