using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200126E RID: 4718
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCell")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public abstract class UWorldPartitionRuntimeCell : UObject, IUnrealUObject, IUnrealObject, IWorldPartitionCell, IUnrealNativeInterface, IUnrealInterface, IWorldPartitionCookPackageObject
	{
		// Token: 0x060114CD RID: 70861 RVA: 0x00196692 File Offset: 0x00194892
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeCell._ClassPtr;
		}

		// Token: 0x060114CE RID: 70862 RVA: 0x0019669E File Offset: 0x0019489E
		int IWorldPartitionCell.InterfaceOffset()
		{
			return UWorldPartitionRuntimeCell.__InterfaceOffset_IWorldPartitionCell;
		}

		// Token: 0x060114CF RID: 70863 RVA: 0x001966A5 File Offset: 0x001948A5
		int IWorldPartitionCookPackageObject.InterfaceOffset()
		{
			return UWorldPartitionRuntimeCell.__InterfaceOffset_IWorldPartitionCookPackageObject;
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x060114D0 RID: 70864 RVA: 0x001966AC File Offset: 0x001948AC
		// (set) Token: 0x060114D1 RID: 70865 RVA: 0x001966BC File Offset: 0x001948BC
		public unsafe bool bIsAlwaysLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bIsAlwaysLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bIsAlwaysLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x060114D2 RID: 70866 RVA: 0x001966CD File Offset: 0x001948CD
		// (set) Token: 0x060114D3 RID: 70867 RVA: 0x001966DD File Offset: 0x001948DD
		public unsafe bool bClientOnlyVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bClientOnlyVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bClientOnlyVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x060114D4 RID: 70868 RVA: 0x001966EE File Offset: 0x001948EE
		// (set) Token: 0x060114D5 RID: 70869 RVA: 0x001966FE File Offset: 0x001948FE
		public unsafe bool bIsHLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bIsHLOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bIsHLOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x060114D6 RID: 70870 RVA: 0x0019670F File Offset: 0x0019490F
		// (set) Token: 0x060114D7 RID: 70871 RVA: 0x0019671F File Offset: 0x0019491F
		public unsafe bool bBlockOnSlowLoading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bBlockOnSlowLoading) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_bBlockOnSlowLoading) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x060114D8 RID: 70872 RVA: 0x00196730 File Offset: 0x00194930
		// (set) Token: 0x060114D9 RID: 70873 RVA: 0x00196744 File Offset: 0x00194944
		public unsafe FGuid ContentBundleID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_ContentBundleID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_ContentBundleID) = value;
			}
		}

		// Token: 0x17004374 RID: 17268
		// (get) Token: 0x060114DA RID: 70874 RVA: 0x00196759 File Offset: 0x00194959
		// (set) Token: 0x060114DB RID: 70875 RVA: 0x0019676D File Offset: 0x0019496D
		public unsafe FLinearColor CellDebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_CellDebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_CellDebugColor) = value;
			}
		}

		// Token: 0x17004375 RID: 17269
		// (get) Token: 0x060114DC RID: 70876 RVA: 0x00196784 File Offset: 0x00194984
		// (set) Token: 0x060114DD RID: 70877 RVA: 0x001967BD File Offset: 0x001949BD
		[Nullable(1)]
		public TArray<FName> DataLayers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<FName>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_DataLayers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x17004376 RID: 17270
		// (get) Token: 0x060114DE RID: 70878 RVA: 0x001967CB File Offset: 0x001949CB
		// (set) Token: 0x060114DF RID: 70879 RVA: 0x001967DF File Offset: 0x001949DF
		public unsafe FGuid CellGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_CellGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_CellGuid) = value;
			}
		}

		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x060114E0 RID: 70880 RVA: 0x001967F4 File Offset: 0x001949F4
		// (set) Token: 0x060114E1 RID: 70881 RVA: 0x00196808 File Offset: 0x00194A08
		public unsafe FGuid SourceCellGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_SourceCellGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_SourceCellGuid) = value;
			}
		}

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x060114E2 RID: 70882 RVA: 0x00196820 File Offset: 0x00194A20
		// (set) Token: 0x060114E3 RID: 70883 RVA: 0x00196859 File Offset: 0x00194A59
		[Nullable(1)]
		public TArray<FGuid> HLODActorSourceCellGuids
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._HLODActorSourceCellGuids) == null)
				{
					result = (this._HLODActorSourceCellGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCell.__PropertyOffset_HLODActorSourceCellGuids, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HLODActorSourceCellGuids.CopyAssign(value);
			}
		}

		// Token: 0x060114E4 RID: 70884 RVA: 0x00196867 File Offset: 0x00194A67
		static UWorldPartitionRuntimeCell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeCell");
		}

		// Token: 0x060114E5 RID: 70885 RVA: 0x00196878 File Offset: 0x00194A78
		protected UWorldPartitionRuntimeCell() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeCell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060114E6 RID: 70886 RVA: 0x001968A0 File Offset: 0x00194AA0
		protected UWorldPartitionRuntimeCell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009426 RID: 37926
		internal static int __InterfaceOffset_IWorldPartitionCell;

		// Token: 0x04009427 RID: 37927
		internal static int __InterfaceOffset_IWorldPartitionCookPackageObject;

		// Token: 0x04009428 RID: 37928
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCell";

		// Token: 0x04009429 RID: 37929
		private static IntPtr _ClassPtr;

		// Token: 0x0400942A RID: 37930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400942B RID: 37931
		internal static int __PropertyOffset_bIsAlwaysLoaded;

		// Token: 0x0400942C RID: 37932
		internal static int __PropertyOffset_bClientOnlyVisible;

		// Token: 0x0400942D RID: 37933
		internal static int __PropertyOffset_bIsHLOD;

		// Token: 0x0400942E RID: 37934
		internal static int __PropertyOffset_bBlockOnSlowLoading;

		// Token: 0x0400942F RID: 37935
		internal static int __PropertyOffset_ContentBundleID;

		// Token: 0x04009430 RID: 37936
		internal static int __PropertyOffset_CellDebugColor;

		// Token: 0x04009431 RID: 37937
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x04009432 RID: 37938
		[Nullable(2)]
		private TArray<FName> _DataLayers;

		// Token: 0x04009433 RID: 37939
		internal static int __PropertyOffset_CellGuid;

		// Token: 0x04009434 RID: 37940
		internal static int __PropertyOffset_SourceCellGuid;

		// Token: 0x04009435 RID: 37941
		internal static int __PropertyOffset_HLODActorSourceCellGuids;

		// Token: 0x04009436 RID: 37942
		[Nullable(2)]
		private TArray<FGuid> _HLODActorSourceCellGuids;
	}
}
