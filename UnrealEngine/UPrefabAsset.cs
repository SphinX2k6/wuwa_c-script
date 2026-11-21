using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B7 RID: 1975
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.PrefabAsset")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UPrefabAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AB6C RID: 43884 RVA: 0x000FCC92 File Offset: 0x000FAE92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrefabAsset._ClassPtr;
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x000FCCA0 File Offset: 0x000FAEA0
		public UPrefabAsset() : this(BuiltinUtils.AllocNativeUObject(UPrefabAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AB6E RID: 43886 RVA: 0x000FCCC8 File Offset: 0x000FAEC8
		public UPrefabAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrefabAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x0600AB6F RID: 43887 RVA: 0x000FCCFB File Offset: 0x000FAEFB
		// (set) Token: 0x0600AB70 RID: 43888 RVA: 0x000FCD0B File Offset: 0x000FAF0B
		public unsafe int NextFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_NextFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_NextFileID) = value;
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x000FCD1C File Offset: 0x000FAF1C
		// (set) Token: 0x0600AB72 RID: 43890 RVA: 0x000FCD2C File Offset: 0x000FAF2C
		public unsafe ushort Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Version) = (short)value;
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x0600AB73 RID: 43891 RVA: 0x000FCD3D File Offset: 0x000FAF3D
		// (set) Token: 0x0600AB74 RID: 43892 RVA: 0x000FCD51 File Offset: 0x000FAF51
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x0600AB75 RID: 43893 RVA: 0x000FCD68 File Offset: 0x000FAF68
		// (set) Token: 0x0600AB76 RID: 43894 RVA: 0x000FCDA1 File Offset: 0x000FAFA1
		public TArray<UObject> ReferenceAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferenceAssets) == null)
				{
					result = (this._ReferenceAssets = new TArray<UObject>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ReferenceAssets, this));
				}
				return result;
			}
			set
			{
				this.ReferenceAssets.CopyAssign(value);
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x0600AB77 RID: 43895 RVA: 0x000FCDB0 File Offset: 0x000FAFB0
		// (set) Token: 0x0600AB78 RID: 43896 RVA: 0x000FCDE9 File Offset: 0x000FAFE9
		public TArray<FName> ReferenceFNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ReferenceFNames) == null)
				{
					result = (this._ReferenceFNames = new TArray<FName>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ReferenceFNames, this));
				}
				return result;
			}
			set
			{
				this.ReferenceFNames.CopyAssign(value);
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x0600AB79 RID: 43897 RVA: 0x000FCDF8 File Offset: 0x000FAFF8
		// (set) Token: 0x0600AB7A RID: 43898 RVA: 0x000FCE31 File Offset: 0x000FB031
		public TArray<UClass> ReferenceClasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UClass> result;
				if ((result = this._ReferenceClasses) == null)
				{
					result = (this._ReferenceClasses = new TArray<UClass>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_ReferenceClasses, this));
				}
				return result;
			}
			set
			{
				this.ReferenceClasses.CopyAssign(value);
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x0600AB7B RID: 43899 RVA: 0x000FCE40 File Offset: 0x000FB040
		// (set) Token: 0x0600AB7C RID: 43900 RVA: 0x000FCE79 File Offset: 0x000FB079
		public TArray<FSoftObjectPath> SoftReferenceData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._SoftReferenceData) == null)
				{
					result = (this._SoftReferenceData = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UPrefabAsset.__PropertyOffset_SoftReferenceData, this));
				}
				return result;
			}
			set
			{
				this.SoftReferenceData.CopyAssign(value);
			}
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x000FCE87 File Offset: 0x000FB087
		static UPrefabAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PrefabSystem.PrefabAsset");
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x000FCE95 File Offset: 0x000FB095
		protected UPrefabAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400499E RID: 18846
		public new const string __ObjectPath = "/Script/PrefabSystem.PrefabAsset";

		// Token: 0x0400499F RID: 18847
		private static IntPtr _ClassPtr;

		// Token: 0x040049A0 RID: 18848
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040049A1 RID: 18849
		internal static int __PropertyOffset_NextFileID;

		// Token: 0x040049A2 RID: 18850
		internal static int __PropertyOffset_Version;

		// Token: 0x040049A3 RID: 18851
		internal static int __PropertyOffset_Guid;

		// Token: 0x040049A4 RID: 18852
		internal static int __PropertyOffset_ReferenceAssets;

		// Token: 0x040049A5 RID: 18853
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferenceAssets;

		// Token: 0x040049A6 RID: 18854
		internal static int __PropertyOffset_ReferenceFNames;

		// Token: 0x040049A7 RID: 18855
		[Nullable(2)]
		private TArray<FName> _ReferenceFNames;

		// Token: 0x040049A8 RID: 18856
		internal static int __PropertyOffset_ReferenceClasses;

		// Token: 0x040049A9 RID: 18857
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _ReferenceClasses;

		// Token: 0x040049AA RID: 18858
		internal static int __PropertyOffset_SoftReferenceData;

		// Token: 0x040049AB RID: 18859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _SoftReferenceData;
	}
}
