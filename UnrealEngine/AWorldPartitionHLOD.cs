using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200125B RID: 4699
	[UnrealObjectPath("/Script/Engine.WorldPartitionHLOD")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class AWorldPartitionHLOD : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011431 RID: 70705 RVA: 0x00195786 File Offset: 0x00193986
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionHLOD._ClassPtr;
		}

		// Token: 0x06011432 RID: 70706 RVA: 0x00195794 File Offset: 0x00193994
		public AWorldPartitionHLOD() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionHLOD.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011433 RID: 70707 RVA: 0x001957BC File Offset: 0x001939BC
		[NullableContext(1)]
		public AWorldPartitionHLOD(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionHLOD.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x06011434 RID: 70708 RVA: 0x001957EF File Offset: 0x001939EF
		// (set) Token: 0x06011435 RID: 70709 RVA: 0x001957FF File Offset: 0x001939FF
		public unsafe uint LODLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_LODLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_LODLevel) = (int)value;
			}
		}

		// Token: 0x17004351 RID: 17233
		// (get) Token: 0x06011436 RID: 70710 RVA: 0x00195810 File Offset: 0x00193A10
		// (set) Token: 0x06011437 RID: 70711 RVA: 0x00195820 File Offset: 0x00193A20
		public unsafe bool bRequireWarmup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_bRequireWarmup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_bRequireWarmup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004352 RID: 17234
		// (get) Token: 0x06011438 RID: 70712 RVA: 0x00195831 File Offset: 0x00193A31
		// (set) Token: 0x06011439 RID: 70713 RVA: 0x00195845 File Offset: 0x00193A45
		public unsafe FGuid SourceCellGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_SourceCellGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_SourceCellGuid) = value;
			}
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x0601143A RID: 70714 RVA: 0x0019585A File Offset: 0x00193A5A
		// (set) Token: 0x0601143B RID: 70715 RVA: 0x0019586E File Offset: 0x00193A6E
		public unsafe FGuid StandaloneHLODGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_StandaloneHLODGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionHLOD.__PropertyOffset_StandaloneHLODGuid) = value;
			}
		}

		// Token: 0x0601143C RID: 70716 RVA: 0x00195883 File Offset: 0x00193A83
		static AWorldPartitionHLOD()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionHLOD");
		}

		// Token: 0x0601143D RID: 70717 RVA: 0x00195891 File Offset: 0x00193A91
		protected AWorldPartitionHLOD(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093C5 RID: 37829
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionHLOD";

		// Token: 0x040093C6 RID: 37830
		private static IntPtr _ClassPtr;

		// Token: 0x040093C7 RID: 37831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093C8 RID: 37832
		internal static int __PropertyOffset_LODLevel;

		// Token: 0x040093C9 RID: 37833
		internal static int __PropertyOffset_bRequireWarmup;

		// Token: 0x040093CA RID: 37834
		internal static int __PropertyOffset_SourceCellGuid;

		// Token: 0x040093CB RID: 37835
		internal static int __PropertyOffset_StandaloneHLODGuid;
	}
}
