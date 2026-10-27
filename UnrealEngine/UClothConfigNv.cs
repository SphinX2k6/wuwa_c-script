using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000495 RID: 1173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeNv.ClothConfigNv")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UClothConfigNv : UClothConfigCommon, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003EFB RID: 16123 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothConfigNv._ClassPtr;
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0005E9EC File Offset: 0x0005CBEC
		public UClothConfigNv() : this(BuiltinUtils.AllocNativeUObject(UClothConfigNv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0005EA14 File Offset: 0x0005CC14
		public UClothConfigNv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClothConfigNv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06003EFE RID: 16126 RVA: 0x0005EA47 File Offset: 0x0005CC47
		// (set) Token: 0x06003EFF RID: 16127 RVA: 0x0005EA57 File Offset: 0x0005CC57
		public unsafe EClothingWindMethodNv ClothingWindMethod
		{
			get
			{
				return (EClothingWindMethodNv)(*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_ClothingWindMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_ClothingWindMethod) = (byte)value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06003F00 RID: 16128 RVA: 0x0005EA68 File Offset: 0x0005CC68
		// (set) Token: 0x06003F01 RID: 16129 RVA: 0x0005EAA1 File Offset: 0x0005CCA1
		public FClothConstraintSetupNv VerticalConstraint
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetupNv result;
				if ((result = this._VerticalConstraint) == null)
				{
					result = (this._VerticalConstraint = new FClothConstraintSetupNv(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_VerticalConstraint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetupNv.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_VerticalConstraint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x0005EAC4 File Offset: 0x0005CCC4
		// (set) Token: 0x06003F03 RID: 16131 RVA: 0x0005EAFD File Offset: 0x0005CCFD
		public FClothConstraintSetupNv HorizontalConstraint
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetupNv result;
				if ((result = this._HorizontalConstraint) == null)
				{
					result = (this._HorizontalConstraint = new FClothConstraintSetupNv(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_HorizontalConstraint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetupNv.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_HorizontalConstraint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x0005EB20 File Offset: 0x0005CD20
		// (set) Token: 0x06003F05 RID: 16133 RVA: 0x0005EB59 File Offset: 0x0005CD59
		public FClothConstraintSetupNv BendConstraint
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetupNv result;
				if ((result = this._BendConstraint) == null)
				{
					result = (this._BendConstraint = new FClothConstraintSetupNv(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_BendConstraint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetupNv.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_BendConstraint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06003F06 RID: 16134 RVA: 0x0005EB7C File Offset: 0x0005CD7C
		// (set) Token: 0x06003F07 RID: 16135 RVA: 0x0005EBB5 File Offset: 0x0005CDB5
		public FClothConstraintSetupNv ShearConstraint
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetupNv result;
				if ((result = this._ShearConstraint) == null)
				{
					result = (this._ShearConstraint = new FClothConstraintSetupNv(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_ShearConstraint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetupNv.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_ShearConstraint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x0005EBD6 File Offset: 0x0005CDD6
		// (set) Token: 0x06003F09 RID: 16137 RVA: 0x0005EBE6 File Offset: 0x0005CDE6
		public unsafe float SelfCollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SelfCollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SelfCollisionRadius) = value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x0005EBF7 File Offset: 0x0005CDF7
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x0005EC07 File Offset: 0x0005CE07
		public unsafe float SelfCollisionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SelfCollisionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SelfCollisionStiffness) = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x0005EC18 File Offset: 0x0005CE18
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x0005EC28 File Offset: 0x0005CE28
		public unsafe float SelfCollisionCullScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SelfCollisionCullScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SelfCollisionCullScale) = value;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x0005EC39 File Offset: 0x0005CE39
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x0005EC4D File Offset: 0x0005CE4D
		public unsafe FVector Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x0005EC62 File Offset: 0x0005CE62
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x0005EC72 File Offset: 0x0005CE72
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x0005EC83 File Offset: 0x0005CE83
		// (set) Token: 0x06003F13 RID: 16147 RVA: 0x0005EC93 File Offset: 0x0005CE93
		public unsafe float WindDragCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_WindDragCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_WindDragCoefficient) = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x0005ECA4 File Offset: 0x0005CEA4
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x0005ECB4 File Offset: 0x0005CEB4
		public unsafe float WindLiftCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_WindLiftCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_WindLiftCoefficient) = value;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x0005ECC5 File Offset: 0x0005CEC5
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x0005ECD9 File Offset: 0x0005CED9
		public unsafe FVector LinearDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_LinearDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_LinearDrag) = value;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x0005ECEE File Offset: 0x0005CEEE
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x0005ED02 File Offset: 0x0005CF02
		public unsafe FVector AngularDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AngularDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AngularDrag) = value;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x0005ED17 File Offset: 0x0005CF17
		// (set) Token: 0x06003F1B RID: 16155 RVA: 0x0005ED2B File Offset: 0x0005CF2B
		public unsafe FVector LinearInertiaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_LinearInertiaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_LinearInertiaScale) = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x0005ED40 File Offset: 0x0005CF40
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x0005ED54 File Offset: 0x0005CF54
		public unsafe FVector AngularInertiaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AngularInertiaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AngularInertiaScale) = value;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x0005ED69 File Offset: 0x0005CF69
		// (set) Token: 0x06003F1F RID: 16159 RVA: 0x0005ED7D File Offset: 0x0005CF7D
		public unsafe FVector CentrifugalInertiaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_CentrifugalInertiaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_CentrifugalInertiaScale) = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x0005ED92 File Offset: 0x0005CF92
		// (set) Token: 0x06003F21 RID: 16161 RVA: 0x0005EDA2 File Offset: 0x0005CFA2
		public unsafe float SolverFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SolverFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_SolverFrequency) = value;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003F22 RID: 16162 RVA: 0x0005EDB3 File Offset: 0x0005CFB3
		// (set) Token: 0x06003F23 RID: 16163 RVA: 0x0005EDC3 File Offset: 0x0005CFC3
		public unsafe float StiffnessFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_StiffnessFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_StiffnessFrequency) = value;
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06003F24 RID: 16164 RVA: 0x0005EDD4 File Offset: 0x0005CFD4
		// (set) Token: 0x06003F25 RID: 16165 RVA: 0x0005EDE4 File Offset: 0x0005CFE4
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x0005EDF5 File Offset: 0x0005CFF5
		// (set) Token: 0x06003F27 RID: 16167 RVA: 0x0005EE09 File Offset: 0x0005D009
		public unsafe FVector GravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_GravityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_GravityOverride) = value;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x0005EE1E File Offset: 0x0005D01E
		// (set) Token: 0x06003F29 RID: 16169 RVA: 0x0005EE2E File Offset: 0x0005D02E
		public unsafe bool bUseGravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_bUseGravityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_bUseGravityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x0005EE3F File Offset: 0x0005D03F
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x0005EE4F File Offset: 0x0005D04F
		public unsafe float TetherStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_TetherStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_TetherStiffness) = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06003F2C RID: 16172 RVA: 0x0005EE60 File Offset: 0x0005D060
		// (set) Token: 0x06003F2D RID: 16173 RVA: 0x0005EE70 File Offset: 0x0005D070
		public unsafe float TetherLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_TetherLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_TetherLimit) = value;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x0005EE81 File Offset: 0x0005D081
		// (set) Token: 0x06003F2F RID: 16175 RVA: 0x0005EE91 File Offset: 0x0005D091
		public unsafe float CollisionThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_CollisionThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_CollisionThickness) = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x0005EEA2 File Offset: 0x0005D0A2
		// (set) Token: 0x06003F31 RID: 16177 RVA: 0x0005EEB2 File Offset: 0x0005D0B2
		public unsafe float AnimDriveSpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AnimDriveSpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AnimDriveSpringStiffness) = value;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x0005EEC3 File Offset: 0x0005D0C3
		// (set) Token: 0x06003F33 RID: 16179 RVA: 0x0005EED3 File Offset: 0x0005D0D3
		public unsafe float AnimDriveDamperStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AnimDriveDamperStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_AnimDriveDamperStiffness) = value;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06003F34 RID: 16180 RVA: 0x0005EEE4 File Offset: 0x0005D0E4
		// (set) Token: 0x06003F35 RID: 16181 RVA: 0x0005EEF4 File Offset: 0x0005D0F4
		public unsafe EClothingWindMethod_Legacy WindMethod_DEPRECATED
		{
			get
			{
				return (EClothingWindMethod_Legacy)(*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_WindMethod_DEPRECATED));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_WindMethod_DEPRECATED) = (byte)value;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06003F36 RID: 16182 RVA: 0x0005EF08 File Offset: 0x0005D108
		// (set) Token: 0x06003F37 RID: 16183 RVA: 0x0005EF41 File Offset: 0x0005D141
		public FClothConstraintSetup_Legacy VerticalConstraintConfig_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._VerticalConstraintConfig_DEPRECATED) == null)
				{
					result = (this._VerticalConstraintConfig_DEPRECATED = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_VerticalConstraintConfig_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_VerticalConstraintConfig_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06003F38 RID: 16184 RVA: 0x0005EF64 File Offset: 0x0005D164
		// (set) Token: 0x06003F39 RID: 16185 RVA: 0x0005EF9D File Offset: 0x0005D19D
		public FClothConstraintSetup_Legacy HorizontalConstraintConfig_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._HorizontalConstraintConfig_DEPRECATED) == null)
				{
					result = (this._HorizontalConstraintConfig_DEPRECATED = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_HorizontalConstraintConfig_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_HorizontalConstraintConfig_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06003F3A RID: 16186 RVA: 0x0005EFC0 File Offset: 0x0005D1C0
		// (set) Token: 0x06003F3B RID: 16187 RVA: 0x0005EFF9 File Offset: 0x0005D1F9
		public FClothConstraintSetup_Legacy BendConstraintConfig_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._BendConstraintConfig_DEPRECATED) == null)
				{
					result = (this._BendConstraintConfig_DEPRECATED = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_BendConstraintConfig_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_BendConstraintConfig_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x0005F01C File Offset: 0x0005D21C
		// (set) Token: 0x06003F3D RID: 16189 RVA: 0x0005F055 File Offset: 0x0005D255
		public FClothConstraintSetup_Legacy ShearConstraintConfig_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._ShearConstraintConfig_DEPRECATED) == null)
				{
					result = (this._ShearConstraintConfig_DEPRECATED = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_ShearConstraintConfig_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)UClothConfigNv.__PropertyOffset_ShearConstraintConfig_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x0005F076 File Offset: 0x0005D276
		static UClothConfigNv()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeNv.ClothConfigNv");
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0005F084 File Offset: 0x0005D284
		protected UClothConfigNv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001DB4 RID: 7604
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeNv.ClothConfigNv";

		// Token: 0x04001DB5 RID: 7605
		private static IntPtr _ClassPtr;

		// Token: 0x04001DB6 RID: 7606
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001DB7 RID: 7607
		internal static int __PropertyOffset_ClothingWindMethod;

		// Token: 0x04001DB8 RID: 7608
		internal static int __PropertyOffset_VerticalConstraint;

		// Token: 0x04001DB9 RID: 7609
		[Nullable(2)]
		private FClothConstraintSetupNv _VerticalConstraint;

		// Token: 0x04001DBA RID: 7610
		internal static int __PropertyOffset_HorizontalConstraint;

		// Token: 0x04001DBB RID: 7611
		[Nullable(2)]
		private FClothConstraintSetupNv _HorizontalConstraint;

		// Token: 0x04001DBC RID: 7612
		internal static int __PropertyOffset_BendConstraint;

		// Token: 0x04001DBD RID: 7613
		[Nullable(2)]
		private FClothConstraintSetupNv _BendConstraint;

		// Token: 0x04001DBE RID: 7614
		internal static int __PropertyOffset_ShearConstraint;

		// Token: 0x04001DBF RID: 7615
		[Nullable(2)]
		private FClothConstraintSetupNv _ShearConstraint;

		// Token: 0x04001DC0 RID: 7616
		internal static int __PropertyOffset_SelfCollisionRadius;

		// Token: 0x04001DC1 RID: 7617
		internal static int __PropertyOffset_SelfCollisionStiffness;

		// Token: 0x04001DC2 RID: 7618
		internal static int __PropertyOffset_SelfCollisionCullScale;

		// Token: 0x04001DC3 RID: 7619
		internal static int __PropertyOffset_Damping;

		// Token: 0x04001DC4 RID: 7620
		internal static int __PropertyOffset_Friction;

		// Token: 0x04001DC5 RID: 7621
		internal static int __PropertyOffset_WindDragCoefficient;

		// Token: 0x04001DC6 RID: 7622
		internal static int __PropertyOffset_WindLiftCoefficient;

		// Token: 0x04001DC7 RID: 7623
		internal static int __PropertyOffset_LinearDrag;

		// Token: 0x04001DC8 RID: 7624
		internal static int __PropertyOffset_AngularDrag;

		// Token: 0x04001DC9 RID: 7625
		internal static int __PropertyOffset_LinearInertiaScale;

		// Token: 0x04001DCA RID: 7626
		internal static int __PropertyOffset_AngularInertiaScale;

		// Token: 0x04001DCB RID: 7627
		internal static int __PropertyOffset_CentrifugalInertiaScale;

		// Token: 0x04001DCC RID: 7628
		internal static int __PropertyOffset_SolverFrequency;

		// Token: 0x04001DCD RID: 7629
		internal static int __PropertyOffset_StiffnessFrequency;

		// Token: 0x04001DCE RID: 7630
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04001DCF RID: 7631
		internal static int __PropertyOffset_GravityOverride;

		// Token: 0x04001DD0 RID: 7632
		internal static int __PropertyOffset_bUseGravityOverride;

		// Token: 0x04001DD1 RID: 7633
		internal static int __PropertyOffset_TetherStiffness;

		// Token: 0x04001DD2 RID: 7634
		internal static int __PropertyOffset_TetherLimit;

		// Token: 0x04001DD3 RID: 7635
		internal static int __PropertyOffset_CollisionThickness;

		// Token: 0x04001DD4 RID: 7636
		internal static int __PropertyOffset_AnimDriveSpringStiffness;

		// Token: 0x04001DD5 RID: 7637
		internal static int __PropertyOffset_AnimDriveDamperStiffness;

		// Token: 0x04001DD6 RID: 7638
		internal static int __PropertyOffset_WindMethod_DEPRECATED;

		// Token: 0x04001DD7 RID: 7639
		internal static int __PropertyOffset_VerticalConstraintConfig_DEPRECATED;

		// Token: 0x04001DD8 RID: 7640
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _VerticalConstraintConfig_DEPRECATED;

		// Token: 0x04001DD9 RID: 7641
		internal static int __PropertyOffset_HorizontalConstraintConfig_DEPRECATED;

		// Token: 0x04001DDA RID: 7642
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _HorizontalConstraintConfig_DEPRECATED;

		// Token: 0x04001DDB RID: 7643
		internal static int __PropertyOffset_BendConstraintConfig_DEPRECATED;

		// Token: 0x04001DDC RID: 7644
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _BendConstraintConfig_DEPRECATED;

		// Token: 0x04001DDD RID: 7645
		internal static int __PropertyOffset_ShearConstraintConfig_DEPRECATED;

		// Token: 0x04001DDE RID: 7646
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _ShearConstraintConfig_DEPRECATED;
	}
}
