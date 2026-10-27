using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000438 RID: 1080
	[UnrealObjectPath("/Script/ChaosCloth.ChaosClothConfig")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UChaosClothConfig : UClothConfigCommon, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003A3D RID: 14909 RVA: 0x000582A6 File Offset: 0x000564A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosClothConfig._ClassPtr;
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x000582B4 File Offset: 0x000564B4
		public UChaosClothConfig() : this(BuiltinUtils.AllocNativeUObject(UChaosClothConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x000582DC File Offset: 0x000564DC
		[NullableContext(1)]
		public UChaosClothConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosClothConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06003A40 RID: 14912 RVA: 0x0005830F File Offset: 0x0005650F
		// (set) Token: 0x06003A41 RID: 14913 RVA: 0x0005831F File Offset: 0x0005651F
		public unsafe EClothMassMode MassMode
		{
			get
			{
				return (EClothMassMode)(*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_MassMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_MassMode) = (byte)value;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x00058330 File Offset: 0x00056530
		// (set) Token: 0x06003A43 RID: 14915 RVA: 0x00058340 File Offset: 0x00056540
		public unsafe float UniformMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_UniformMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_UniformMass) = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06003A44 RID: 14916 RVA: 0x00058351 File Offset: 0x00056551
		// (set) Token: 0x06003A45 RID: 14917 RVA: 0x00058361 File Offset: 0x00056561
		public unsafe float TotalMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_TotalMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_TotalMass) = value;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06003A46 RID: 14918 RVA: 0x00058372 File Offset: 0x00056572
		// (set) Token: 0x06003A47 RID: 14919 RVA: 0x00058382 File Offset: 0x00056582
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_Density) = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06003A48 RID: 14920 RVA: 0x00058393 File Offset: 0x00056593
		// (set) Token: 0x06003A49 RID: 14921 RVA: 0x000583A3 File Offset: 0x000565A3
		public unsafe float MinPerParticleMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_MinPerParticleMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_MinPerParticleMass) = value;
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06003A4A RID: 14922 RVA: 0x000583B4 File Offset: 0x000565B4
		// (set) Token: 0x06003A4B RID: 14923 RVA: 0x000583C4 File Offset: 0x000565C4
		public unsafe float EdgeStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_EdgeStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_EdgeStiffness) = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x000583D5 File Offset: 0x000565D5
		// (set) Token: 0x06003A4D RID: 14925 RVA: 0x000583E5 File Offset: 0x000565E5
		public unsafe float BendingStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_BendingStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_BendingStiffness) = value;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x000583F6 File Offset: 0x000565F6
		// (set) Token: 0x06003A4F RID: 14927 RVA: 0x00058406 File Offset: 0x00056606
		public unsafe bool bUseBendingElements
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseBendingElements) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseBendingElements) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x00058417 File Offset: 0x00056617
		// (set) Token: 0x06003A51 RID: 14929 RVA: 0x00058427 File Offset: 0x00056627
		public unsafe float AreaStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_AreaStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_AreaStiffness) = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06003A52 RID: 14930 RVA: 0x00058438 File Offset: 0x00056638
		// (set) Token: 0x06003A53 RID: 14931 RVA: 0x00058448 File Offset: 0x00056648
		public unsafe float VolumeStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_VolumeStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_VolumeStiffness) = value;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x00058459 File Offset: 0x00056659
		// (set) Token: 0x06003A55 RID: 14933 RVA: 0x00058469 File Offset: 0x00056669
		public unsafe float StrainLimitingStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_StrainLimitingStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_StrainLimitingStiffness) = value;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x0005847A File Offset: 0x0005667A
		// (set) Token: 0x06003A57 RID: 14935 RVA: 0x0005848A File Offset: 0x0005668A
		public unsafe float LimitScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_LimitScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_LimitScale) = value;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x0005849B File Offset: 0x0005669B
		// (set) Token: 0x06003A59 RID: 14937 RVA: 0x000584AB File Offset: 0x000566AB
		public unsafe EChaosClothTetherMode TetherMode
		{
			get
			{
				return (EChaosClothTetherMode)(*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_TetherMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_TetherMode) = (byte)value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x000584BC File Offset: 0x000566BC
		// (set) Token: 0x06003A5B RID: 14939 RVA: 0x000584CC File Offset: 0x000566CC
		public unsafe bool bUseGeodesicDistance_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseGeodesicDistance_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseGeodesicDistance_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x000584DD File Offset: 0x000566DD
		// (set) Token: 0x06003A5D RID: 14941 RVA: 0x000584ED File Offset: 0x000566ED
		public unsafe float ShapeTargetStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_ShapeTargetStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_ShapeTargetStiffness) = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06003A5E RID: 14942 RVA: 0x000584FE File Offset: 0x000566FE
		// (set) Token: 0x06003A5F RID: 14943 RVA: 0x0005850E File Offset: 0x0005670E
		public unsafe float CollisionThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_CollisionThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_CollisionThickness) = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x0005851F File Offset: 0x0005671F
		// (set) Token: 0x06003A61 RID: 14945 RVA: 0x0005852F File Offset: 0x0005672F
		public unsafe float FrictionCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_FrictionCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_FrictionCoefficient) = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x00058540 File Offset: 0x00056740
		// (set) Token: 0x06003A63 RID: 14947 RVA: 0x00058550 File Offset: 0x00056750
		public unsafe bool bUseSelfCollisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseSelfCollisions) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseSelfCollisions) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x00058561 File Offset: 0x00056761
		// (set) Token: 0x06003A65 RID: 14949 RVA: 0x00058571 File Offset: 0x00056771
		public unsafe float SelfCollisionThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_SelfCollisionThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_SelfCollisionThickness) = value;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x00058582 File Offset: 0x00056782
		// (set) Token: 0x06003A67 RID: 14951 RVA: 0x00058592 File Offset: 0x00056792
		public unsafe bool bUseLegacyBackstop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseLegacyBackstop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseLegacyBackstop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x000585A3 File Offset: 0x000567A3
		// (set) Token: 0x06003A69 RID: 14953 RVA: 0x000585B3 File Offset: 0x000567B3
		public unsafe float DampingCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_DampingCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_DampingCoefficient) = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x000585C4 File Offset: 0x000567C4
		// (set) Token: 0x06003A6B RID: 14955 RVA: 0x000585D4 File Offset: 0x000567D4
		public unsafe bool bUsePointBasedWindModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUsePointBasedWindModel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUsePointBasedWindModel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x000585E5 File Offset: 0x000567E5
		// (set) Token: 0x06003A6D RID: 14957 RVA: 0x000585F5 File Offset: 0x000567F5
		public unsafe float DragCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_DragCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_DragCoefficient) = value;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x00058606 File Offset: 0x00056806
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x00058616 File Offset: 0x00056816
		public unsafe float LiftCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_LiftCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_LiftCoefficient) = value;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x00058627 File Offset: 0x00056827
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x00058637 File Offset: 0x00056837
		public unsafe bool bUseGravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseGravityOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseGravityOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00058648 File Offset: 0x00056848
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x00058658 File Offset: 0x00056858
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x00058669 File Offset: 0x00056869
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x0005867D File Offset: 0x0005687D
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x00058692 File Offset: 0x00056892
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x000586A2 File Offset: 0x000568A2
		public unsafe float AnimDriveSpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_AnimDriveSpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_AnimDriveSpringStiffness) = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x000586B3 File Offset: 0x000568B3
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x000586C7 File Offset: 0x000568C7
		public unsafe FVector LinearVelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_LinearVelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_LinearVelocityScale) = value;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x000586DC File Offset: 0x000568DC
		// (set) Token: 0x06003A7B RID: 14971 RVA: 0x000586EC File Offset: 0x000568EC
		public unsafe float AngularVelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_AngularVelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_AngularVelocityScale) = value;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06003A7C RID: 14972 RVA: 0x000586FD File Offset: 0x000568FD
		// (set) Token: 0x06003A7D RID: 14973 RVA: 0x0005870D File Offset: 0x0005690D
		public unsafe bool bUseTetrahedralConstraints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseTetrahedralConstraints) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseTetrahedralConstraints) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x0005871E File Offset: 0x0005691E
		// (set) Token: 0x06003A7F RID: 14975 RVA: 0x0005872E File Offset: 0x0005692E
		public unsafe bool bUseThinShellVolumeConstraints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseThinShellVolumeConstraints) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseThinShellVolumeConstraints) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x0005873F File Offset: 0x0005693F
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x0005874F File Offset: 0x0005694F
		public unsafe bool bUseContinuousCollisionDetection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseContinuousCollisionDetection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosClothConfig.__PropertyOffset_bUseContinuousCollisionDetection) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00058760 File Offset: 0x00056960
		static UChaosClothConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosCloth.ChaosClothConfig");
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x0005876E File Offset: 0x0005696E
		protected UChaosClothConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001A89 RID: 6793
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosCloth.ChaosClothConfig";

		// Token: 0x04001A8A RID: 6794
		private static IntPtr _ClassPtr;

		// Token: 0x04001A8B RID: 6795
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001A8C RID: 6796
		internal static int __PropertyOffset_MassMode;

		// Token: 0x04001A8D RID: 6797
		internal static int __PropertyOffset_UniformMass;

		// Token: 0x04001A8E RID: 6798
		internal static int __PropertyOffset_TotalMass;

		// Token: 0x04001A8F RID: 6799
		internal static int __PropertyOffset_Density;

		// Token: 0x04001A90 RID: 6800
		internal static int __PropertyOffset_MinPerParticleMass;

		// Token: 0x04001A91 RID: 6801
		internal static int __PropertyOffset_EdgeStiffness;

		// Token: 0x04001A92 RID: 6802
		internal static int __PropertyOffset_BendingStiffness;

		// Token: 0x04001A93 RID: 6803
		internal static int __PropertyOffset_bUseBendingElements;

		// Token: 0x04001A94 RID: 6804
		internal static int __PropertyOffset_AreaStiffness;

		// Token: 0x04001A95 RID: 6805
		internal static int __PropertyOffset_VolumeStiffness;

		// Token: 0x04001A96 RID: 6806
		internal static int __PropertyOffset_StrainLimitingStiffness;

		// Token: 0x04001A97 RID: 6807
		internal static int __PropertyOffset_LimitScale;

		// Token: 0x04001A98 RID: 6808
		internal static int __PropertyOffset_TetherMode;

		// Token: 0x04001A99 RID: 6809
		internal static int __PropertyOffset_bUseGeodesicDistance_DEPRECATED;

		// Token: 0x04001A9A RID: 6810
		internal static int __PropertyOffset_ShapeTargetStiffness;

		// Token: 0x04001A9B RID: 6811
		internal static int __PropertyOffset_CollisionThickness;

		// Token: 0x04001A9C RID: 6812
		internal static int __PropertyOffset_FrictionCoefficient;

		// Token: 0x04001A9D RID: 6813
		internal static int __PropertyOffset_bUseSelfCollisions;

		// Token: 0x04001A9E RID: 6814
		internal static int __PropertyOffset_SelfCollisionThickness;

		// Token: 0x04001A9F RID: 6815
		internal static int __PropertyOffset_bUseLegacyBackstop;

		// Token: 0x04001AA0 RID: 6816
		internal static int __PropertyOffset_DampingCoefficient;

		// Token: 0x04001AA1 RID: 6817
		internal static int __PropertyOffset_bUsePointBasedWindModel;

		// Token: 0x04001AA2 RID: 6818
		internal static int __PropertyOffset_DragCoefficient;

		// Token: 0x04001AA3 RID: 6819
		internal static int __PropertyOffset_LiftCoefficient;

		// Token: 0x04001AA4 RID: 6820
		internal static int __PropertyOffset_bUseGravityOverride;

		// Token: 0x04001AA5 RID: 6821
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04001AA6 RID: 6822
		internal static int __PropertyOffset_Gravity;

		// Token: 0x04001AA7 RID: 6823
		internal static int __PropertyOffset_AnimDriveSpringStiffness;

		// Token: 0x04001AA8 RID: 6824
		internal static int __PropertyOffset_LinearVelocityScale;

		// Token: 0x04001AA9 RID: 6825
		internal static int __PropertyOffset_AngularVelocityScale;

		// Token: 0x04001AAA RID: 6826
		internal static int __PropertyOffset_bUseTetrahedralConstraints;

		// Token: 0x04001AAB RID: 6827
		internal static int __PropertyOffset_bUseThinShellVolumeConstraints;

		// Token: 0x04001AAC RID: 6828
		internal static int __PropertyOffset_bUseContinuousCollisionDetection;
	}
}
