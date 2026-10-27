using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047D RID: 1149
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothConfig_Legacy")]
	[UnrealStructLayout(212, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 212)]
	public class FClothConfig_Legacy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003D94 RID: 15764 RVA: 0x0005C8BD File Offset: 0x0005AABD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothConfig_Legacy._ScriptStructPtr != 0) ? FClothConfig_Legacy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeCommon.ClothConfig_Legacy", ref FClothConfig_Legacy._ScriptStructPtr);
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x0005C8E1 File Offset: 0x0005AAE1
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x0005C8F1 File Offset: 0x0005AAF1
		public unsafe EClothingWindMethod_Legacy WindMethod
		{
			get
			{
				return (EClothingWindMethod_Legacy)(*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_WindMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_WindMethod) = (byte)value;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06003D97 RID: 15767 RVA: 0x0005C904 File Offset: 0x0005AB04
		// (set) Token: 0x06003D98 RID: 15768 RVA: 0x0005C947 File Offset: 0x0005AB47
		public FClothConstraintSetup_Legacy VerticalConstraintConfig
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._VerticalConstraintConfig) == null)
				{
					result = (this._VerticalConstraintConfig = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_VerticalConstraintConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_VerticalConstraintConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06003D99 RID: 15769 RVA: 0x0005C968 File Offset: 0x0005AB68
		// (set) Token: 0x06003D9A RID: 15770 RVA: 0x0005C9AB File Offset: 0x0005ABAB
		public FClothConstraintSetup_Legacy HorizontalConstraintConfig
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._HorizontalConstraintConfig) == null)
				{
					result = (this._HorizontalConstraintConfig = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_HorizontalConstraintConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_HorizontalConstraintConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06003D9B RID: 15771 RVA: 0x0005C9CC File Offset: 0x0005ABCC
		// (set) Token: 0x06003D9C RID: 15772 RVA: 0x0005CA0F File Offset: 0x0005AC0F
		public FClothConstraintSetup_Legacy BendConstraintConfig
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._BendConstraintConfig) == null)
				{
					result = (this._BendConstraintConfig = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_BendConstraintConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_BendConstraintConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06003D9D RID: 15773 RVA: 0x0005CA30 File Offset: 0x0005AC30
		// (set) Token: 0x06003D9E RID: 15774 RVA: 0x0005CA73 File Offset: 0x0005AC73
		public FClothConstraintSetup_Legacy ShearConstraintConfig
		{
			get
			{
				base.FastCheckIsValid();
				FClothConstraintSetup_Legacy result;
				if ((result = this._ShearConstraintConfig) == null)
				{
					result = (this._ShearConstraintConfig = new FClothConstraintSetup_Legacy(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_ShearConstraintConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothConstraintSetup_Legacy.StaticStruct(), base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_ShearConstraintConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x0005CA94 File Offset: 0x0005AC94
		// (set) Token: 0x06003DA0 RID: 15776 RVA: 0x0005CAA4 File Offset: 0x0005ACA4
		public unsafe float SelfCollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SelfCollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SelfCollisionRadius) = value;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x0005CAB5 File Offset: 0x0005ACB5
		// (set) Token: 0x06003DA2 RID: 15778 RVA: 0x0005CAC5 File Offset: 0x0005ACC5
		public unsafe float SelfCollisionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SelfCollisionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SelfCollisionStiffness) = value;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x0005CAD6 File Offset: 0x0005ACD6
		// (set) Token: 0x06003DA4 RID: 15780 RVA: 0x0005CAE6 File Offset: 0x0005ACE6
		public unsafe float SelfCollisionCullScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SelfCollisionCullScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SelfCollisionCullScale) = value;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x0005CAF7 File Offset: 0x0005ACF7
		// (set) Token: 0x06003DA6 RID: 15782 RVA: 0x0005CB0B File Offset: 0x0005AD0B
		public unsafe FVector Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06003DA7 RID: 15783 RVA: 0x0005CB20 File Offset: 0x0005AD20
		// (set) Token: 0x06003DA8 RID: 15784 RVA: 0x0005CB30 File Offset: 0x0005AD30
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06003DA9 RID: 15785 RVA: 0x0005CB41 File Offset: 0x0005AD41
		// (set) Token: 0x06003DAA RID: 15786 RVA: 0x0005CB51 File Offset: 0x0005AD51
		public unsafe float WindDragCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_WindDragCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_WindDragCoefficient) = value;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x0005CB62 File Offset: 0x0005AD62
		// (set) Token: 0x06003DAC RID: 15788 RVA: 0x0005CB72 File Offset: 0x0005AD72
		public unsafe float WindLiftCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_WindLiftCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_WindLiftCoefficient) = value;
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x0005CB83 File Offset: 0x0005AD83
		// (set) Token: 0x06003DAE RID: 15790 RVA: 0x0005CB97 File Offset: 0x0005AD97
		public unsafe FVector LinearDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_LinearDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_LinearDrag) = value;
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x0005CBAC File Offset: 0x0005ADAC
		// (set) Token: 0x06003DB0 RID: 15792 RVA: 0x0005CBC0 File Offset: 0x0005ADC0
		public unsafe FVector AngularDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AngularDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AngularDrag) = value;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x0005CBD5 File Offset: 0x0005ADD5
		// (set) Token: 0x06003DB2 RID: 15794 RVA: 0x0005CBE9 File Offset: 0x0005ADE9
		public unsafe FVector LinearInertiaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_LinearInertiaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_LinearInertiaScale) = value;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x0005CBFE File Offset: 0x0005ADFE
		// (set) Token: 0x06003DB4 RID: 15796 RVA: 0x0005CC12 File Offset: 0x0005AE12
		public unsafe FVector AngularInertiaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AngularInertiaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AngularInertiaScale) = value;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x0005CC27 File Offset: 0x0005AE27
		// (set) Token: 0x06003DB6 RID: 15798 RVA: 0x0005CC3B File Offset: 0x0005AE3B
		public unsafe FVector CentrifugalInertiaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_CentrifugalInertiaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_CentrifugalInertiaScale) = value;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x0005CC50 File Offset: 0x0005AE50
		// (set) Token: 0x06003DB8 RID: 15800 RVA: 0x0005CC60 File Offset: 0x0005AE60
		public unsafe float SolverFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SolverFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_SolverFrequency) = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x0005CC71 File Offset: 0x0005AE71
		// (set) Token: 0x06003DBA RID: 15802 RVA: 0x0005CC81 File Offset: 0x0005AE81
		public unsafe float StiffnessFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_StiffnessFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_StiffnessFrequency) = value;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x0005CC92 File Offset: 0x0005AE92
		// (set) Token: 0x06003DBC RID: 15804 RVA: 0x0005CCA2 File Offset: 0x0005AEA2
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x0005CCB3 File Offset: 0x0005AEB3
		// (set) Token: 0x06003DBE RID: 15806 RVA: 0x0005CCC7 File Offset: 0x0005AEC7
		public unsafe FVector GravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_GravityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_GravityOverride) = value;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06003DBF RID: 15807 RVA: 0x0005CCDC File Offset: 0x0005AEDC
		// (set) Token: 0x06003DC0 RID: 15808 RVA: 0x0005CCEC File Offset: 0x0005AEEC
		public unsafe bool bUseGravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_bUseGravityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_bUseGravityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06003DC1 RID: 15809 RVA: 0x0005CCFD File Offset: 0x0005AEFD
		// (set) Token: 0x06003DC2 RID: 15810 RVA: 0x0005CD0D File Offset: 0x0005AF0D
		public unsafe float TetherStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_TetherStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_TetherStiffness) = value;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x0005CD1E File Offset: 0x0005AF1E
		// (set) Token: 0x06003DC4 RID: 15812 RVA: 0x0005CD2E File Offset: 0x0005AF2E
		public unsafe float TetherLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_TetherLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_TetherLimit) = value;
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x0005CD3F File Offset: 0x0005AF3F
		// (set) Token: 0x06003DC6 RID: 15814 RVA: 0x0005CD4F File Offset: 0x0005AF4F
		public unsafe float CollisionThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_CollisionThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_CollisionThickness) = value;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x0005CD60 File Offset: 0x0005AF60
		// (set) Token: 0x06003DC8 RID: 15816 RVA: 0x0005CD70 File Offset: 0x0005AF70
		public unsafe float AnimDriveSpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AnimDriveSpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AnimDriveSpringStiffness) = value;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x0005CD81 File Offset: 0x0005AF81
		// (set) Token: 0x06003DCA RID: 15818 RVA: 0x0005CD91 File Offset: 0x0005AF91
		public unsafe float AnimDriveDamperStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AnimDriveDamperStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothConfig_Legacy.__PropertyOffset_AnimDriveDamperStiffness) = value;
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x0005CDA2 File Offset: 0x0005AFA2
		public FClothConfig_Legacy()
		{
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x0005CDAC File Offset: 0x0005AFAC
		public FClothConfig_Legacy(EClothingWindMethod_Legacy WindMethod, FClothConstraintSetup_Legacy VerticalConstraintConfig, FClothConstraintSetup_Legacy HorizontalConstraintConfig, FClothConstraintSetup_Legacy BendConstraintConfig, FClothConstraintSetup_Legacy ShearConstraintConfig, float SelfCollisionRadius, float SelfCollisionStiffness, float SelfCollisionCullScale, FVector Damping, float Friction, float WindDragCoefficient, float WindLiftCoefficient, FVector LinearDrag, FVector AngularDrag, FVector LinearInertiaScale, FVector AngularInertiaScale, FVector CentrifugalInertiaScale, float SolverFrequency, float StiffnessFrequency, float GravityScale, FVector GravityOverride, bool bUseGravityOverride, float TetherStiffness, float TetherLimit, float CollisionThickness, float AnimDriveSpringStiffness, float AnimDriveDamperStiffness)
		{
			this.WindMethod = WindMethod;
			this.VerticalConstraintConfig = VerticalConstraintConfig;
			this.HorizontalConstraintConfig = HorizontalConstraintConfig;
			this.BendConstraintConfig = BendConstraintConfig;
			this.ShearConstraintConfig = ShearConstraintConfig;
			this.SelfCollisionRadius = SelfCollisionRadius;
			this.SelfCollisionStiffness = SelfCollisionStiffness;
			this.SelfCollisionCullScale = SelfCollisionCullScale;
			this.Damping = Damping;
			this.Friction = Friction;
			this.WindDragCoefficient = WindDragCoefficient;
			this.WindLiftCoefficient = WindLiftCoefficient;
			this.LinearDrag = LinearDrag;
			this.AngularDrag = AngularDrag;
			this.LinearInertiaScale = LinearInertiaScale;
			this.AngularInertiaScale = AngularInertiaScale;
			this.CentrifugalInertiaScale = CentrifugalInertiaScale;
			this.SolverFrequency = SolverFrequency;
			this.StiffnessFrequency = StiffnessFrequency;
			this.GravityScale = GravityScale;
			this.GravityOverride = GravityOverride;
			this.bUseGravityOverride = bUseGravityOverride;
			this.TetherStiffness = TetherStiffness;
			this.TetherLimit = TetherLimit;
			this.CollisionThickness = CollisionThickness;
			this.AnimDriveSpringStiffness = AnimDriveSpringStiffness;
			this.AnimDriveDamperStiffness = AnimDriveDamperStiffness;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x0005CE94 File Offset: 0x0005B094
		protected override IntPtr GetUStructPtr()
		{
			return FClothConfig_Legacy.StaticStruct();
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x0005CEA0 File Offset: 0x0005B0A0
		[NullableContext(2)]
		public FClothConfig_Legacy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x0005CEAA File Offset: 0x0005B0AA
		public FClothConfig_Legacy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x0005CEB5 File Offset: 0x0005B0B5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothConfig_Legacy(Pointer, false, true);
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x0005CEBF File Offset: 0x0005B0BF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothConfig_Legacy(Pointer, MemoryOwner);
		}

		// Token: 0x04001CE5 RID: 7397
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothConfig_Legacy";

		// Token: 0x04001CE6 RID: 7398
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001CE7 RID: 7399
		internal static int __PropertyOffset_WindMethod;

		// Token: 0x04001CE8 RID: 7400
		internal static int __PropertyOffset_VerticalConstraintConfig;

		// Token: 0x04001CE9 RID: 7401
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _VerticalConstraintConfig;

		// Token: 0x04001CEA RID: 7402
		internal static int __PropertyOffset_HorizontalConstraintConfig;

		// Token: 0x04001CEB RID: 7403
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _HorizontalConstraintConfig;

		// Token: 0x04001CEC RID: 7404
		internal static int __PropertyOffset_BendConstraintConfig;

		// Token: 0x04001CED RID: 7405
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _BendConstraintConfig;

		// Token: 0x04001CEE RID: 7406
		internal static int __PropertyOffset_ShearConstraintConfig;

		// Token: 0x04001CEF RID: 7407
		[Nullable(2)]
		private FClothConstraintSetup_Legacy _ShearConstraintConfig;

		// Token: 0x04001CF0 RID: 7408
		internal static int __PropertyOffset_SelfCollisionRadius;

		// Token: 0x04001CF1 RID: 7409
		internal static int __PropertyOffset_SelfCollisionStiffness;

		// Token: 0x04001CF2 RID: 7410
		internal static int __PropertyOffset_SelfCollisionCullScale;

		// Token: 0x04001CF3 RID: 7411
		internal static int __PropertyOffset_Damping;

		// Token: 0x04001CF4 RID: 7412
		internal static int __PropertyOffset_Friction;

		// Token: 0x04001CF5 RID: 7413
		internal static int __PropertyOffset_WindDragCoefficient;

		// Token: 0x04001CF6 RID: 7414
		internal static int __PropertyOffset_WindLiftCoefficient;

		// Token: 0x04001CF7 RID: 7415
		internal static int __PropertyOffset_LinearDrag;

		// Token: 0x04001CF8 RID: 7416
		internal static int __PropertyOffset_AngularDrag;

		// Token: 0x04001CF9 RID: 7417
		internal static int __PropertyOffset_LinearInertiaScale;

		// Token: 0x04001CFA RID: 7418
		internal static int __PropertyOffset_AngularInertiaScale;

		// Token: 0x04001CFB RID: 7419
		internal static int __PropertyOffset_CentrifugalInertiaScale;

		// Token: 0x04001CFC RID: 7420
		internal static int __PropertyOffset_SolverFrequency;

		// Token: 0x04001CFD RID: 7421
		internal static int __PropertyOffset_StiffnessFrequency;

		// Token: 0x04001CFE RID: 7422
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04001CFF RID: 7423
		internal static int __PropertyOffset_GravityOverride;

		// Token: 0x04001D00 RID: 7424
		internal static int __PropertyOffset_bUseGravityOverride;

		// Token: 0x04001D01 RID: 7425
		internal static int __PropertyOffset_TetherStiffness;

		// Token: 0x04001D02 RID: 7426
		internal static int __PropertyOffset_TetherLimit;

		// Token: 0x04001D03 RID: 7427
		internal static int __PropertyOffset_CollisionThickness;

		// Token: 0x04001D04 RID: 7428
		internal static int __PropertyOffset_AnimDriveSpringStiffness;

		// Token: 0x04001D05 RID: 7429
		internal static int __PropertyOffset_AnimDriveDamperStiffness;
	}
}
