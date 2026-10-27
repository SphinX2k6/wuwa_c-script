using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010FE RID: 4350
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshLODSettings")]
	[UnrealStructLayout(624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class USkeletalMeshLODSettings : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FC73 RID: 64627 RVA: 0x00174C74 File Offset: 0x00172E74
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMeshLODSettings._ClassPtr;
		}

		// Token: 0x0600FC74 RID: 64628 RVA: 0x00174C80 File Offset: 0x00172E80
		public USkeletalMeshLODSettings() : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshLODSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FC75 RID: 64629 RVA: 0x00174CA8 File Offset: 0x00172EA8
		public USkeletalMeshLODSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshLODSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0600FC76 RID: 64630 RVA: 0x00174CDC File Offset: 0x00172EDC
		// (set) Token: 0x0600FC77 RID: 64631 RVA: 0x00174D15 File Offset: 0x00172F15
		public FPerPlatformInt MinLod
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MinLod) == null)
				{
					result = (this._MinLod = new FPerPlatformInt(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MinLod, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MinLod, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0600FC78 RID: 64632 RVA: 0x00174D38 File Offset: 0x00172F38
		// (set) Token: 0x0600FC79 RID: 64633 RVA: 0x00174D71 File Offset: 0x00172F71
		public FPerPlatformInt MaxOutlineLod
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxOutlineLod) == null)
				{
					result = (this._MaxOutlineLod = new FPerPlatformInt(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MaxOutlineLod, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MaxOutlineLod, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0600FC7A RID: 64634 RVA: 0x00174D94 File Offset: 0x00172F94
		// (set) Token: 0x0600FC7B RID: 64635 RVA: 0x00174DCD File Offset: 0x00172FCD
		public FPerPlatformBool DisableBelowMinLodStripping
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformBool result;
				if ((result = this._DisableBelowMinLodStripping) == null)
				{
					result = (this._DisableBelowMinLodStripping = new FPerPlatformBool(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_DisableBelowMinLodStripping, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformBool.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_DisableBelowMinLodStripping, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0600FC7C RID: 64636 RVA: 0x00174DEE File Offset: 0x00172FEE
		// (set) Token: 0x0600FC7D RID: 64637 RVA: 0x00174DFE File Offset: 0x00172FFE
		public unsafe bool bOverrideLODStreamingSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_bOverrideLODStreamingSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_bOverrideLODStreamingSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0600FC7E RID: 64638 RVA: 0x00174E10 File Offset: 0x00173010
		// (set) Token: 0x0600FC7F RID: 64639 RVA: 0x00174E49 File Offset: 0x00173049
		public FPerPlatformBool bSupportLODStreaming
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformBool result;
				if ((result = this._bSupportLODStreaming) == null)
				{
					result = (this._bSupportLODStreaming = new FPerPlatformBool(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_bSupportLODStreaming, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformBool.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_bSupportLODStreaming, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0600FC80 RID: 64640 RVA: 0x00174E6C File Offset: 0x0017306C
		// (set) Token: 0x0600FC81 RID: 64641 RVA: 0x00174EA5 File Offset: 0x001730A5
		public FPerPlatformInt MaxNumStreamedLODs
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxNumStreamedLODs) == null)
				{
					result = (this._MaxNumStreamedLODs = new FPerPlatformInt(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MaxNumStreamedLODs, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MaxNumStreamedLODs, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0600FC82 RID: 64642 RVA: 0x00174EC8 File Offset: 0x001730C8
		// (set) Token: 0x0600FC83 RID: 64643 RVA: 0x00174F01 File Offset: 0x00173101
		public FPerPlatformInt MaxNumOptionalLODs
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxNumOptionalLODs) == null)
				{
					result = (this._MaxNumOptionalLODs = new FPerPlatformInt(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MaxNumOptionalLODs, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_MaxNumOptionalLODs, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x0600FC84 RID: 64644 RVA: 0x00174F22 File Offset: 0x00173122
		// (set) Token: 0x0600FC85 RID: 64645 RVA: 0x00174F32 File Offset: 0x00173132
		public unsafe bool bUseKuroLODDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_bUseKuroLODDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_bUseKuroLODDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0600FC86 RID: 64646 RVA: 0x00174F44 File Offset: 0x00173144
		// (set) Token: 0x0600FC87 RID: 64647 RVA: 0x00174F7D File Offset: 0x0017317D
		public TArray<FSkeletalMeshLODGroupSettings> LODGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMeshLODGroupSettings> result;
				if ((result = this._LODGroups) == null)
				{
					result = (this._LODGroups = new TArray<FSkeletalMeshLODGroupSettings>(base.NativePtr + (IntPtr)USkeletalMeshLODSettings.__PropertyOffset_LODGroups, this));
				}
				return result;
			}
			set
			{
				this.LODGroups.CopyAssign(value);
			}
		}

		// Token: 0x0600FC88 RID: 64648 RVA: 0x00174F8B File Offset: 0x0017318B
		public int GetNumberOfSettings()
		{
			return USkeletalMeshLODSettings.__GetNumberOfSettings_Internal(base.NativePtr);
		}

		// Token: 0x0600FC89 RID: 64649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfSettings_Internal(IntPtr @this);

		// Token: 0x0600FC8A RID: 64650 RVA: 0x00174F98 File Offset: 0x00173198
		static USkeletalMeshLODSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshLODSettings");
		}

		// Token: 0x0600FC8B RID: 64651 RVA: 0x00174FA6 File Offset: 0x001731A6
		protected USkeletalMeshLODSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008804 RID: 34820
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshLODSettings";

		// Token: 0x04008805 RID: 34821
		private static IntPtr _ClassPtr;

		// Token: 0x04008806 RID: 34822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008807 RID: 34823
		internal static int __PropertyOffset_MinLod;

		// Token: 0x04008808 RID: 34824
		[Nullable(2)]
		private FPerPlatformInt _MinLod;

		// Token: 0x04008809 RID: 34825
		internal static int __PropertyOffset_MaxOutlineLod;

		// Token: 0x0400880A RID: 34826
		[Nullable(2)]
		private FPerPlatformInt _MaxOutlineLod;

		// Token: 0x0400880B RID: 34827
		internal static int __PropertyOffset_DisableBelowMinLodStripping;

		// Token: 0x0400880C RID: 34828
		[Nullable(2)]
		private FPerPlatformBool _DisableBelowMinLodStripping;

		// Token: 0x0400880D RID: 34829
		internal static int __PropertyOffset_bOverrideLODStreamingSettings;

		// Token: 0x0400880E RID: 34830
		internal static int __PropertyOffset_bSupportLODStreaming;

		// Token: 0x0400880F RID: 34831
		[Nullable(2)]
		private FPerPlatformBool _bSupportLODStreaming;

		// Token: 0x04008810 RID: 34832
		internal static int __PropertyOffset_MaxNumStreamedLODs;

		// Token: 0x04008811 RID: 34833
		[Nullable(2)]
		private FPerPlatformInt _MaxNumStreamedLODs;

		// Token: 0x04008812 RID: 34834
		internal static int __PropertyOffset_MaxNumOptionalLODs;

		// Token: 0x04008813 RID: 34835
		[Nullable(2)]
		private FPerPlatformInt _MaxNumOptionalLODs;

		// Token: 0x04008814 RID: 34836
		internal static int __PropertyOffset_bUseKuroLODDistance;

		// Token: 0x04008815 RID: 34837
		internal static int __PropertyOffset_LODGroups;

		// Token: 0x04008816 RID: 34838
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMeshLODGroupSettings> _LODGroups;
	}
}
