using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200110C RID: 4364
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Skeleton")]
	[UnrealStructLayout(1248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1248)]
	public class USkeleton : UObject, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface, IInterface_PreviewMeshProvider
	{
		// Token: 0x0600FD2A RID: 64810 RVA: 0x00175D68 File Offset: 0x00173F68
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeleton._ClassPtr;
		}

		// Token: 0x0600FD2B RID: 64811 RVA: 0x00175D74 File Offset: 0x00173F74
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return USkeleton.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x0600FD2C RID: 64812 RVA: 0x00175D7B File Offset: 0x00173F7B
		int IInterface_PreviewMeshProvider.InterfaceOffset()
		{
			return USkeleton.__InterfaceOffset_IInterface_PreviewMeshProvider;
		}

		// Token: 0x0600FD2D RID: 64813 RVA: 0x00175D84 File Offset: 0x00173F84
		public USkeleton() : this(BuiltinUtils.AllocNativeUObject(USkeleton.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FD2E RID: 64814 RVA: 0x00175DAC File Offset: 0x00173FAC
		public USkeleton(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeleton.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600FD2F RID: 64815 RVA: 0x00175DE0 File Offset: 0x00173FE0
		// (set) Token: 0x0600FD30 RID: 64816 RVA: 0x00175E19 File Offset: 0x00174019
		public TArray<FBoneNode> BoneTree
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneNode> result;
				if ((result = this._BoneTree) == null)
				{
					result = (this._BoneTree = new TArray<FBoneNode>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_BoneTree, this));
				}
				return result;
			}
			set
			{
				this.BoneTree.CopyAssign(value);
			}
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600FD31 RID: 64817 RVA: 0x00175E28 File Offset: 0x00174028
		// (set) Token: 0x0600FD32 RID: 64818 RVA: 0x00175E61 File Offset: 0x00174061
		public TArray<FTransform> RefLocalPoses_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._RefLocalPoses_DEPRECATED) == null)
				{
					result = (this._RefLocalPoses_DEPRECATED = new TArray<FTransform>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_RefLocalPoses_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.RefLocalPoses_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x0600FD33 RID: 64819 RVA: 0x00175E6F File Offset: 0x0017406F
		// (set) Token: 0x0600FD34 RID: 64820 RVA: 0x00175E83 File Offset: 0x00174083
		public unsafe FGuid VirtualBoneGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_VirtualBoneGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_VirtualBoneGuid) = value;
			}
		}

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0600FD35 RID: 64821 RVA: 0x00175E98 File Offset: 0x00174098
		// (set) Token: 0x0600FD36 RID: 64822 RVA: 0x00175ED1 File Offset: 0x001740D1
		public TArray<FVirtualBone> VirtualBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVirtualBone> result;
				if ((result = this._VirtualBones) == null)
				{
					result = (this._VirtualBones = new TArray<FVirtualBone>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_VirtualBones, this));
				}
				return result;
			}
			set
			{
				this.VirtualBones.CopyAssign(value);
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0600FD37 RID: 64823 RVA: 0x00175EE0 File Offset: 0x001740E0
		// (set) Token: 0x0600FD38 RID: 64824 RVA: 0x00175F19 File Offset: 0x00174119
		public TArray<USkeletalMeshSocket> Sockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshSocket> result;
				if ((result = this._Sockets) == null)
				{
					result = (this._Sockets = new TArray<USkeletalMeshSocket>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_Sockets, this));
				}
				return result;
			}
			set
			{
				this.Sockets.CopyAssign(value);
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0600FD39 RID: 64825 RVA: 0x00175F27 File Offset: 0x00174127
		// (set) Token: 0x0600FD3A RID: 64826 RVA: 0x00175F3B File Offset: 0x0017413B
		[Nullable(2)]
		public unsafe UBoneFoldSettings BoneFoldSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoneFoldSettings>(base.NativePtr / (IntPtr)sizeof(void*) + USkeleton.__PropertyOffset_BoneFoldSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeleton.__PropertyOffset_BoneFoldSettings, value);
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x0600FD3B RID: 64827 RVA: 0x00175F50 File Offset: 0x00174150
		// (set) Token: 0x0600FD3C RID: 64828 RVA: 0x00175F89 File Offset: 0x00174189
		public TArray<FBoneConstraint> BoneConstraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneConstraint> result;
				if ((result = this._BoneConstraints) == null)
				{
					result = (this._BoneConstraints = new TArray<FBoneConstraint>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_BoneConstraints, this));
				}
				return result;
			}
			set
			{
				this.BoneConstraints.CopyAssign(value);
			}
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x0600FD3D RID: 64829 RVA: 0x00175F98 File Offset: 0x00174198
		// (set) Token: 0x0600FD3E RID: 64830 RVA: 0x00175FD1 File Offset: 0x001741D1
		public TArray<URBFDriver> RBFDrivers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URBFDriver> result;
				if ((result = this._RBFDrivers) == null)
				{
					result = (this._RBFDrivers = new TArray<URBFDriver>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_RBFDrivers, this));
				}
				return result;
			}
			set
			{
				this.RBFDrivers.CopyAssign(value);
			}
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600FD3F RID: 64831 RVA: 0x00175FDF File Offset: 0x001741DF
		// (set) Token: 0x0600FD40 RID: 64832 RVA: 0x00175FF3 File Offset: 0x001741F3
		[Nullable(2)]
		public unsafe URBFPrecomputations Precomputations
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URBFPrecomputations>(base.NativePtr / (IntPtr)sizeof(void*) + USkeleton.__PropertyOffset_Precomputations);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeleton.__PropertyOffset_Precomputations, value);
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x0600FD41 RID: 64833 RVA: 0x00176008 File Offset: 0x00174208
		// (set) Token: 0x0600FD42 RID: 64834 RVA: 0x00176041 File Offset: 0x00174241
		public FSmartNameContainer SmartNames
		{
			get
			{
				base.FastCheckIsValid();
				FSmartNameContainer result;
				if ((result = this._SmartNames) == null)
				{
					result = (this._SmartNames = new FSmartNameContainer(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_SmartNames, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSmartNameContainer.StaticStruct(), base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_SmartNames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600FD43 RID: 64835 RVA: 0x00176064 File Offset: 0x00174264
		// (set) Token: 0x0600FD44 RID: 64836 RVA: 0x0017609D File Offset: 0x0017429D
		public TArray<UBlendProfile> BlendProfiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBlendProfile> result;
				if ((result = this._BlendProfiles) == null)
				{
					result = (this._BlendProfiles = new TArray<UBlendProfile>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_BlendProfiles, this));
				}
				return result;
			}
			set
			{
				this.BlendProfiles.CopyAssign(value);
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0600FD45 RID: 64837 RVA: 0x001760AC File Offset: 0x001742AC
		// (set) Token: 0x0600FD46 RID: 64838 RVA: 0x001760E5 File Offset: 0x001742E5
		public TArray<FAnimSlotGroup> SlotGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimSlotGroup> result;
				if ((result = this._SlotGroups) == null)
				{
					result = (this._SlotGroups = new TArray<FAnimSlotGroup>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_SlotGroups, this));
				}
				return result;
			}
			set
			{
				this.SlotGroups.CopyAssign(value);
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0600FD47 RID: 64839 RVA: 0x001760F3 File Offset: 0x001742F3
		// (set) Token: 0x0600FD48 RID: 64840 RVA: 0x00176103 File Offset: 0x00174303
		public unsafe bool bAllBoneInheritScaleXYZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_bAllBoneInheritScaleXYZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_bAllBoneInheritScaleXYZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0600FD49 RID: 64841 RVA: 0x00176114 File Offset: 0x00174314
		// (set) Token: 0x0600FD4A RID: 64842 RVA: 0x0017614D File Offset: 0x0017434D
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)USkeleton.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x0600FD4B RID: 64843 RVA: 0x0017615B File Offset: 0x0017435B
		static USkeleton()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Skeleton");
		}

		// Token: 0x0600FD4C RID: 64844 RVA: 0x00176169 File Offset: 0x00174369
		protected USkeleton(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008879 RID: 34937
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x0400887A RID: 34938
		internal static int __InterfaceOffset_IInterface_PreviewMeshProvider;

		// Token: 0x0400887B RID: 34939
		public new const string __ObjectPath = "/Script/Engine.Skeleton";

		// Token: 0x0400887C RID: 34940
		private static IntPtr _ClassPtr;

		// Token: 0x0400887D RID: 34941
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400887E RID: 34942
		internal static int __PropertyOffset_BoneTree;

		// Token: 0x0400887F RID: 34943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneNode> _BoneTree;

		// Token: 0x04008880 RID: 34944
		internal static int __PropertyOffset_RefLocalPoses_DEPRECATED;

		// Token: 0x04008881 RID: 34945
		[Nullable(2)]
		private TArray<FTransform> _RefLocalPoses_DEPRECATED;

		// Token: 0x04008882 RID: 34946
		internal static int __PropertyOffset_VirtualBoneGuid;

		// Token: 0x04008883 RID: 34947
		internal static int __PropertyOffset_VirtualBones;

		// Token: 0x04008884 RID: 34948
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVirtualBone> _VirtualBones;

		// Token: 0x04008885 RID: 34949
		internal static int __PropertyOffset_Sockets;

		// Token: 0x04008886 RID: 34950
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshSocket> _Sockets;

		// Token: 0x04008887 RID: 34951
		internal static int __PropertyOffset_BoneFoldSettings;

		// Token: 0x04008888 RID: 34952
		internal static int __PropertyOffset_BoneConstraints;

		// Token: 0x04008889 RID: 34953
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneConstraint> _BoneConstraints;

		// Token: 0x0400888A RID: 34954
		internal static int __PropertyOffset_RBFDrivers;

		// Token: 0x0400888B RID: 34955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URBFDriver> _RBFDrivers;

		// Token: 0x0400888C RID: 34956
		internal static int __PropertyOffset_Precomputations;

		// Token: 0x0400888D RID: 34957
		internal static int __PropertyOffset_SmartNames;

		// Token: 0x0400888E RID: 34958
		[Nullable(2)]
		private FSmartNameContainer _SmartNames;

		// Token: 0x0400888F RID: 34959
		internal static int __PropertyOffset_BlendProfiles;

		// Token: 0x04008890 RID: 34960
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBlendProfile> _BlendProfiles;

		// Token: 0x04008891 RID: 34961
		internal static int __PropertyOffset_SlotGroups;

		// Token: 0x04008892 RID: 34962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimSlotGroup> _SlotGroups;

		// Token: 0x04008893 RID: 34963
		internal static int __PropertyOffset_bAllBoneInheritScaleXYZ;

		// Token: 0x04008894 RID: 34964
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04008895 RID: 34965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;
	}
}
