using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB0 RID: 4016
	[UnrealObjectPath("/Script/Engine.ParticleModuleTypeDataMesh")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UParticleModuleTypeDataMesh : UParticleModuleTypeDataBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D819 RID: 55321 RVA: 0x0013EBB7 File Offset: 0x0013CDB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTypeDataMesh._ClassPtr;
		}

		// Token: 0x0600D81A RID: 55322 RVA: 0x0013EBC4 File Offset: 0x0013CDC4
		public UParticleModuleTypeDataMesh() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D81B RID: 55323 RVA: 0x0013EBEC File Offset: 0x0013CDEC
		[NullableContext(1)]
		public UParticleModuleTypeDataMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600D81C RID: 55324 RVA: 0x0013EC1F File Offset: 0x0013CE1F
		// (set) Token: 0x0600D81D RID: 55325 RVA: 0x0013EC33 File Offset: 0x0013CE33
		[Nullable(2)]
		public unsafe UStaticMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleTypeDataMesh.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleTypeDataMesh.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600D81E RID: 55326 RVA: 0x0013EC48 File Offset: 0x0013CE48
		// (set) Token: 0x0600D81F RID: 55327 RVA: 0x0013EC58 File Offset: 0x0013CE58
		public unsafe float LODSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_LODSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_LODSizeScale) = value;
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600D820 RID: 55328 RVA: 0x0013EC69 File Offset: 0x0013CE69
		// (set) Token: 0x0600D821 RID: 55329 RVA: 0x0013EC82 File Offset: 0x0013CE82
		public unsafe bool bUseStaticMeshLODs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bUseStaticMeshLODs) & UParticleModuleTypeDataMesh.__PropertyMask_bUseStaticMeshLODs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bUseStaticMeshLODs) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bUseStaticMeshLODs) & ~UParticleModuleTypeDataMesh.__PropertyMask_bUseStaticMeshLODs) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bUseStaticMeshLODs : 0));
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600D822 RID: 55330 RVA: 0x0013ECB2 File Offset: 0x0013CEB2
		// (set) Token: 0x0600D823 RID: 55331 RVA: 0x0013ECCB File Offset: 0x0013CECB
		public unsafe bool CastShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_CastShadows) & UParticleModuleTypeDataMesh.__PropertyMask_CastShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_CastShadows) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_CastShadows) & ~UParticleModuleTypeDataMesh.__PropertyMask_CastShadows) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_CastShadows : 0));
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600D824 RID: 55332 RVA: 0x0013ECFB File Offset: 0x0013CEFB
		// (set) Token: 0x0600D825 RID: 55333 RVA: 0x0013ED14 File Offset: 0x0013CF14
		public unsafe bool DoCollisions
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_DoCollisions) & UParticleModuleTypeDataMesh.__PropertyMask_DoCollisions) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_DoCollisions) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_DoCollisions) & ~UParticleModuleTypeDataMesh.__PropertyMask_DoCollisions) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_DoCollisions : 0));
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600D826 RID: 55334 RVA: 0x0013ED44 File Offset: 0x0013CF44
		// (set) Token: 0x0600D827 RID: 55335 RVA: 0x0013ED58 File Offset: 0x0013CF58
		public unsafe TEnumAsByte<EMeshScreenAlignment> MeshAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_MeshAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_MeshAlignment) = value;
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600D828 RID: 55336 RVA: 0x0013ED6D File Offset: 0x0013CF6D
		// (set) Token: 0x0600D829 RID: 55337 RVA: 0x0013ED86 File Offset: 0x0013CF86
		public unsafe bool bOverrideMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bOverrideMaterial) & UParticleModuleTypeDataMesh.__PropertyMask_bOverrideMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bOverrideMaterial) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bOverrideMaterial) & ~UParticleModuleTypeDataMesh.__PropertyMask_bOverrideMaterial) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bOverrideMaterial : 0));
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600D82A RID: 55338 RVA: 0x0013EDB6 File Offset: 0x0013CFB6
		// (set) Token: 0x0600D82B RID: 55339 RVA: 0x0013EDCF File Offset: 0x0013CFCF
		public unsafe bool bOverrideDefaultMotionBlurSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bOverrideDefaultMotionBlurSettings) & UParticleModuleTypeDataMesh.__PropertyMask_bOverrideDefaultMotionBlurSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bOverrideDefaultMotionBlurSettings) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bOverrideDefaultMotionBlurSettings) & ~UParticleModuleTypeDataMesh.__PropertyMask_bOverrideDefaultMotionBlurSettings) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bOverrideDefaultMotionBlurSettings : 0));
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600D82C RID: 55340 RVA: 0x0013EDFF File Offset: 0x0013CFFF
		// (set) Token: 0x0600D82D RID: 55341 RVA: 0x0013EE18 File Offset: 0x0013D018
		public unsafe bool bEnableMotionBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bEnableMotionBlur) & UParticleModuleTypeDataMesh.__PropertyMask_bEnableMotionBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bEnableMotionBlur) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bEnableMotionBlur) & ~UParticleModuleTypeDataMesh.__PropertyMask_bEnableMotionBlur) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bEnableMotionBlur : 0));
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600D82E RID: 55342 RVA: 0x0013EE48 File Offset: 0x0013D048
		// (set) Token: 0x0600D82F RID: 55343 RVA: 0x0013EE81 File Offset: 0x0013D081
		[Nullable(1)]
		public FRawDistributionVector RollPitchYawRange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._RollPitchYawRange) == null)
				{
					result = (this._RollPitchYawRange = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_RollPitchYawRange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_RollPitchYawRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600D830 RID: 55344 RVA: 0x0013EEA2 File Offset: 0x0013D0A2
		// (set) Token: 0x0600D831 RID: 55345 RVA: 0x0013EEB6 File Offset: 0x0013D0B6
		public unsafe TEnumAsByte<EParticleAxisLock> AxisLockOption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_AxisLockOption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_AxisLockOption) = value;
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600D832 RID: 55346 RVA: 0x0013EECB File Offset: 0x0013D0CB
		// (set) Token: 0x0600D833 RID: 55347 RVA: 0x0013EEE4 File Offset: 0x0013D0E4
		public unsafe bool bCameraFacing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bCameraFacing) & UParticleModuleTypeDataMesh.__PropertyMask_bCameraFacing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bCameraFacing) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bCameraFacing) & ~UParticleModuleTypeDataMesh.__PropertyMask_bCameraFacing) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bCameraFacing : 0));
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600D834 RID: 55348 RVA: 0x0013EF14 File Offset: 0x0013D114
		// (set) Token: 0x0600D835 RID: 55349 RVA: 0x0013EF28 File Offset: 0x0013D128
		public unsafe TEnumAsByte<EMeshCameraFacingUpAxis> CameraFacingUpAxisOption_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_CameraFacingUpAxisOption_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_CameraFacingUpAxisOption_DEPRECATED) = value;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600D836 RID: 55350 RVA: 0x0013EF3D File Offset: 0x0013D13D
		// (set) Token: 0x0600D837 RID: 55351 RVA: 0x0013EF51 File Offset: 0x0013D151
		public unsafe TEnumAsByte<EMeshCameraFacingOptions> CameraFacingOption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_CameraFacingOption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_CameraFacingOption) = value;
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600D838 RID: 55352 RVA: 0x0013EF66 File Offset: 0x0013D166
		// (set) Token: 0x0600D839 RID: 55353 RVA: 0x0013EF7F File Offset: 0x0013D17F
		public unsafe bool bApplyParticleRotationAsSpin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bApplyParticleRotationAsSpin) & UParticleModuleTypeDataMesh.__PropertyMask_bApplyParticleRotationAsSpin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bApplyParticleRotationAsSpin) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bApplyParticleRotationAsSpin) & ~UParticleModuleTypeDataMesh.__PropertyMask_bApplyParticleRotationAsSpin) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bApplyParticleRotationAsSpin : 0));
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600D83A RID: 55354 RVA: 0x0013EFAF File Offset: 0x0013D1AF
		// (set) Token: 0x0600D83B RID: 55355 RVA: 0x0013EFC8 File Offset: 0x0013D1C8
		public unsafe bool bFaceCameraDirectionRatherThanPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bFaceCameraDirectionRatherThanPosition) & UParticleModuleTypeDataMesh.__PropertyMask_bFaceCameraDirectionRatherThanPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bFaceCameraDirectionRatherThanPosition) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bFaceCameraDirectionRatherThanPosition) & ~UParticleModuleTypeDataMesh.__PropertyMask_bFaceCameraDirectionRatherThanPosition) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bFaceCameraDirectionRatherThanPosition : 0));
			}
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600D83C RID: 55356 RVA: 0x0013EFF8 File Offset: 0x0013D1F8
		// (set) Token: 0x0600D83D RID: 55357 RVA: 0x0013F011 File Offset: 0x0013D211
		public unsafe bool bCollisionsConsiderPartilceSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bCollisionsConsiderPartilceSize) & UParticleModuleTypeDataMesh.__PropertyMask_bCollisionsConsiderPartilceSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bCollisionsConsiderPartilceSize) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataMesh.__PropertyOffset_bCollisionsConsiderPartilceSize) & ~UParticleModuleTypeDataMesh.__PropertyMask_bCollisionsConsiderPartilceSize) | (value ? UParticleModuleTypeDataMesh.__PropertyMask_bCollisionsConsiderPartilceSize : 0));
			}
		}

		// Token: 0x0600D83E RID: 55358 RVA: 0x0013F041 File Offset: 0x0013D241
		static UParticleModuleTypeDataMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTypeDataMesh");
		}

		// Token: 0x0600D83F RID: 55359 RVA: 0x0013F04F File Offset: 0x0013D24F
		protected UParticleModuleTypeDataMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007507 RID: 29959
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTypeDataMesh";

		// Token: 0x04007508 RID: 29960
		private static IntPtr _ClassPtr;

		// Token: 0x04007509 RID: 29961
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400750A RID: 29962
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400750B RID: 29963
		internal static int __PropertyOffset_LODSizeScale;

		// Token: 0x0400750C RID: 29964
		internal static int __PropertyOffset_bUseStaticMeshLODs;

		// Token: 0x0400750D RID: 29965
		internal static byte __PropertyMask_bUseStaticMeshLODs;

		// Token: 0x0400750E RID: 29966
		internal static int __PropertyOffset_CastShadows;

		// Token: 0x0400750F RID: 29967
		internal static byte __PropertyMask_CastShadows;

		// Token: 0x04007510 RID: 29968
		internal static int __PropertyOffset_DoCollisions;

		// Token: 0x04007511 RID: 29969
		internal static byte __PropertyMask_DoCollisions;

		// Token: 0x04007512 RID: 29970
		internal static int __PropertyOffset_MeshAlignment;

		// Token: 0x04007513 RID: 29971
		internal static int __PropertyOffset_bOverrideMaterial;

		// Token: 0x04007514 RID: 29972
		internal static byte __PropertyMask_bOverrideMaterial;

		// Token: 0x04007515 RID: 29973
		internal static int __PropertyOffset_bOverrideDefaultMotionBlurSettings;

		// Token: 0x04007516 RID: 29974
		internal static byte __PropertyMask_bOverrideDefaultMotionBlurSettings;

		// Token: 0x04007517 RID: 29975
		internal static int __PropertyOffset_bEnableMotionBlur;

		// Token: 0x04007518 RID: 29976
		internal static byte __PropertyMask_bEnableMotionBlur;

		// Token: 0x04007519 RID: 29977
		internal static int __PropertyOffset_RollPitchYawRange;

		// Token: 0x0400751A RID: 29978
		[Nullable(2)]
		private FRawDistributionVector _RollPitchYawRange;

		// Token: 0x0400751B RID: 29979
		internal static int __PropertyOffset_AxisLockOption;

		// Token: 0x0400751C RID: 29980
		internal static int __PropertyOffset_bCameraFacing;

		// Token: 0x0400751D RID: 29981
		internal static byte __PropertyMask_bCameraFacing;

		// Token: 0x0400751E RID: 29982
		internal static int __PropertyOffset_CameraFacingUpAxisOption_DEPRECATED;

		// Token: 0x0400751F RID: 29983
		internal static int __PropertyOffset_CameraFacingOption;

		// Token: 0x04007520 RID: 29984
		internal static int __PropertyOffset_bApplyParticleRotationAsSpin;

		// Token: 0x04007521 RID: 29985
		internal static byte __PropertyMask_bApplyParticleRotationAsSpin;

		// Token: 0x04007522 RID: 29986
		internal static int __PropertyOffset_bFaceCameraDirectionRatherThanPosition;

		// Token: 0x04007523 RID: 29987
		internal static byte __PropertyMask_bFaceCameraDirectionRatherThanPosition;

		// Token: 0x04007524 RID: 29988
		internal static int __PropertyOffset_bCollisionsConsiderPartilceSize;

		// Token: 0x04007525 RID: 29989
		internal static byte __PropertyMask_bCollisionsConsiderPartilceSize;
	}
}
