using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000430 RID: 1072
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/BuildPatchServices.BuildPatchManifest")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UBuildPatchManifest : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600398A RID: 14730 RVA: 0x0005744B File Offset: 0x0005564B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBuildPatchManifest._ClassPtr;
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00057458 File Offset: 0x00055658
		public UBuildPatchManifest() : this(BuiltinUtils.AllocNativeUObject(UBuildPatchManifest.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00057480 File Offset: 0x00055680
		public UBuildPatchManifest(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBuildPatchManifest.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x000574B3 File Offset: 0x000556B3
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x000574C3 File Offset: 0x000556C3
		public unsafe byte ManifestFileVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_ManifestFileVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_ManifestFileVersion) = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x000574D4 File Offset: 0x000556D4
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x000574E4 File Offset: 0x000556E4
		public unsafe bool bIsFileData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_bIsFileData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_bIsFileData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x000574F5 File Offset: 0x000556F5
		// (set) Token: 0x06003992 RID: 14738 RVA: 0x00057505 File Offset: 0x00055705
		public unsafe uint AppID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_AppID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_AppID) = (int)value;
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x00057516 File Offset: 0x00055716
		// (set) Token: 0x06003994 RID: 14740 RVA: 0x0005752A File Offset: 0x0005572A
		public unsafe string AppName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_AppName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_AppName)), value);
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x0005753F File Offset: 0x0005573F
		// (set) Token: 0x06003996 RID: 14742 RVA: 0x00057553 File Offset: 0x00055753
		public unsafe string BuildVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_BuildVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_BuildVersion)), value);
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x00057568 File Offset: 0x00055768
		// (set) Token: 0x06003998 RID: 14744 RVA: 0x0005757C File Offset: 0x0005577C
		public unsafe string LaunchExe
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_LaunchExe)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_LaunchExe)), value);
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x00057591 File Offset: 0x00055791
		// (set) Token: 0x0600399A RID: 14746 RVA: 0x000575A5 File Offset: 0x000557A5
		public unsafe string LaunchCommand
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_LaunchCommand)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_LaunchCommand)), value);
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x000575BC File Offset: 0x000557BC
		// (set) Token: 0x0600399C RID: 14748 RVA: 0x000575F5 File Offset: 0x000557F5
		public TSet<string> PrereqIds
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._PrereqIds) == null)
				{
					result = (this._PrereqIds = new TSet<string>(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_PrereqIds, this));
				}
				return result;
			}
			set
			{
				this.PrereqIds.CopyAssign(value);
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x00057603 File Offset: 0x00055803
		// (set) Token: 0x0600399E RID: 14750 RVA: 0x00057617 File Offset: 0x00055817
		public unsafe string PrereqName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_PrereqName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_PrereqName)), value);
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x0600399F RID: 14751 RVA: 0x0005762C File Offset: 0x0005582C
		// (set) Token: 0x060039A0 RID: 14752 RVA: 0x00057640 File Offset: 0x00055840
		public unsafe string PrereqPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_PrereqPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_PrereqPath)), value);
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x060039A1 RID: 14753 RVA: 0x00057655 File Offset: 0x00055855
		// (set) Token: 0x060039A2 RID: 14754 RVA: 0x00057669 File Offset: 0x00055869
		public unsafe string PrereqArgs
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_PrereqArgs)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBuildPatchManifest.__PropertyOffset_PrereqArgs)), value);
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x060039A3 RID: 14755 RVA: 0x00057680 File Offset: 0x00055880
		// (set) Token: 0x060039A4 RID: 14756 RVA: 0x000576B9 File Offset: 0x000558B9
		public TArray<FFileManifestData> FileManifestList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFileManifestData> result;
				if ((result = this._FileManifestList) == null)
				{
					result = (this._FileManifestList = new TArray<FFileManifestData>(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_FileManifestList, this));
				}
				return result;
			}
			set
			{
				this.FileManifestList.CopyAssign(value);
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x000576C8 File Offset: 0x000558C8
		// (set) Token: 0x060039A6 RID: 14758 RVA: 0x00057701 File Offset: 0x00055901
		public TArray<FChunkInfoData> ChunkList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FChunkInfoData> result;
				if ((result = this._ChunkList) == null)
				{
					result = (this._ChunkList = new TArray<FChunkInfoData>(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_ChunkList, this));
				}
				return result;
			}
			set
			{
				this.ChunkList.CopyAssign(value);
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x060039A7 RID: 14759 RVA: 0x00057710 File Offset: 0x00055910
		// (set) Token: 0x060039A8 RID: 14760 RVA: 0x00057749 File Offset: 0x00055949
		public TArray<FCustomFieldData> CustomFields
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomFieldData> result;
				if ((result = this._CustomFields) == null)
				{
					result = (this._CustomFields = new TArray<FCustomFieldData>(base.NativePtr + (IntPtr)UBuildPatchManifest.__PropertyOffset_CustomFields, this));
				}
				return result;
			}
			set
			{
				this.CustomFields.CopyAssign(value);
			}
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x00057757 File Offset: 0x00055957
		static UBuildPatchManifest()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/BuildPatchServices.BuildPatchManifest");
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x00057765 File Offset: 0x00055965
		protected UBuildPatchManifest(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001A35 RID: 6709
		public new const string __ObjectPath = "/Script/BuildPatchServices.BuildPatchManifest";

		// Token: 0x04001A36 RID: 6710
		private static IntPtr _ClassPtr;

		// Token: 0x04001A37 RID: 6711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001A38 RID: 6712
		internal static int __PropertyOffset_ManifestFileVersion;

		// Token: 0x04001A39 RID: 6713
		internal static int __PropertyOffset_bIsFileData;

		// Token: 0x04001A3A RID: 6714
		internal static int __PropertyOffset_AppID;

		// Token: 0x04001A3B RID: 6715
		internal static int __PropertyOffset_AppName;

		// Token: 0x04001A3C RID: 6716
		internal static int __PropertyOffset_BuildVersion;

		// Token: 0x04001A3D RID: 6717
		internal static int __PropertyOffset_LaunchExe;

		// Token: 0x04001A3E RID: 6718
		internal static int __PropertyOffset_LaunchCommand;

		// Token: 0x04001A3F RID: 6719
		internal static int __PropertyOffset_PrereqIds;

		// Token: 0x04001A40 RID: 6720
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _PrereqIds;

		// Token: 0x04001A41 RID: 6721
		internal static int __PropertyOffset_PrereqName;

		// Token: 0x04001A42 RID: 6722
		internal static int __PropertyOffset_PrereqPath;

		// Token: 0x04001A43 RID: 6723
		internal static int __PropertyOffset_PrereqArgs;

		// Token: 0x04001A44 RID: 6724
		internal static int __PropertyOffset_FileManifestList;

		// Token: 0x04001A45 RID: 6725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFileManifestData> _FileManifestList;

		// Token: 0x04001A46 RID: 6726
		internal static int __PropertyOffset_ChunkList;

		// Token: 0x04001A47 RID: 6727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FChunkInfoData> _ChunkList;

		// Token: 0x04001A48 RID: 6728
		internal static int __PropertyOffset_CustomFields;

		// Token: 0x04001A49 RID: 6729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomFieldData> _CustomFields;
	}
}
