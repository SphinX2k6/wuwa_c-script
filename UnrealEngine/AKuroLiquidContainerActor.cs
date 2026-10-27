using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B35 RID: 6965
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLiquidContainerActor")]
	[UnrealStructLayout(1824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1824)]
	public class AKuroLiquidContainerActor : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A49B RID: 107675 RVA: 0x0026CA26 File Offset: 0x0026AC26
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroLiquidContainerActor._ClassPtr;
		}

		// Token: 0x0601A49C RID: 107676 RVA: 0x0026CA34 File Offset: 0x0026AC34
		public AKuroLiquidContainerActor() : this(BuiltinUtils.AllocNativeUObject(AKuroLiquidContainerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A49D RID: 107677 RVA: 0x0026CA5C File Offset: 0x0026AC5C
		[NullableContext(1)]
		public AKuroLiquidContainerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroLiquidContainerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069B2 RID: 27058
		// (get) Token: 0x0601A49E RID: 107678 RVA: 0x0026CA8F File Offset: 0x0026AC8F
		// (set) Token: 0x0601A49F RID: 107679 RVA: 0x0026CAA3 File Offset: 0x0026ACA3
		public unsafe USceneComponent RootScene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_RootScene);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_RootScene, value);
			}
		}

		// Token: 0x170069B3 RID: 27059
		// (get) Token: 0x0601A4A0 RID: 107680 RVA: 0x0026CAB8 File Offset: 0x0026ACB8
		// (set) Token: 0x0601A4A1 RID: 107681 RVA: 0x0026CACC File Offset: 0x0026ACCC
		public unsafe UStaticMeshComponent LiquidMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_LiquidMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_LiquidMesh, value);
			}
		}

		// Token: 0x170069B4 RID: 27060
		// (get) Token: 0x0601A4A2 RID: 107682 RVA: 0x0026CAE1 File Offset: 0x0026ACE1
		// (set) Token: 0x0601A4A3 RID: 107683 RVA: 0x0026CAF5 File Offset: 0x0026ACF5
		public unsafe FVector CapsulePointALocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_CapsulePointALocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_CapsulePointALocal) = value;
			}
		}

		// Token: 0x170069B5 RID: 27061
		// (get) Token: 0x0601A4A4 RID: 107684 RVA: 0x0026CB0A File Offset: 0x0026AD0A
		// (set) Token: 0x0601A4A5 RID: 107685 RVA: 0x0026CB1E File Offset: 0x0026AD1E
		public unsafe FVector CapsulePointBLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_CapsulePointBLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_CapsulePointBLocal) = value;
			}
		}

		// Token: 0x170069B6 RID: 27062
		// (get) Token: 0x0601A4A6 RID: 107686 RVA: 0x0026CB33 File Offset: 0x0026AD33
		// (set) Token: 0x0601A4A7 RID: 107687 RVA: 0x0026CB43 File Offset: 0x0026AD43
		public unsafe float CapsuleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_CapsuleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_CapsuleRadius) = value;
			}
		}

		// Token: 0x170069B7 RID: 27063
		// (get) Token: 0x0601A4A8 RID: 107688 RVA: 0x0026CB54 File Offset: 0x0026AD54
		// (set) Token: 0x0601A4A9 RID: 107689 RVA: 0x0026CB68 File Offset: 0x0026AD68
		public unsafe UMaterialInterface LiquidBaseMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_LiquidBaseMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_LiquidBaseMaterial, value);
			}
		}

		// Token: 0x170069B8 RID: 27064
		// (get) Token: 0x0601A4AA RID: 107690 RVA: 0x0026CB7D File Offset: 0x0026AD7D
		// (set) Token: 0x0601A4AB RID: 107691 RVA: 0x0026CB8D File Offset: 0x0026AD8D
		public unsafe float LiquidDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidDensity) = value;
			}
		}

		// Token: 0x170069B9 RID: 27065
		// (get) Token: 0x0601A4AC RID: 107692 RVA: 0x0026CB9E File Offset: 0x0026AD9E
		// (set) Token: 0x0601A4AD RID: 107693 RVA: 0x0026CBB2 File Offset: 0x0026ADB2
		public unsafe FLinearColor LiquidBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidBaseColor) = value;
			}
		}

		// Token: 0x170069BA RID: 27066
		// (get) Token: 0x0601A4AE RID: 107694 RVA: 0x0026CBC7 File Offset: 0x0026ADC7
		// (set) Token: 0x0601A4AF RID: 107695 RVA: 0x0026CBDB File Offset: 0x0026ADDB
		public unsafe FLinearColor LiquidSubsurfaceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidSubsurfaceColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidSubsurfaceColor) = value;
			}
		}

		// Token: 0x170069BB RID: 27067
		// (get) Token: 0x0601A4B0 RID: 107696 RVA: 0x0026CBF0 File Offset: 0x0026ADF0
		// (set) Token: 0x0601A4B1 RID: 107697 RVA: 0x0026CC00 File Offset: 0x0026AE00
		public unsafe float LiquidFillHeightRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidFillHeightRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidFillHeightRatio) = value;
			}
		}

		// Token: 0x170069BC RID: 27068
		// (get) Token: 0x0601A4B2 RID: 107698 RVA: 0x0026CC11 File Offset: 0x0026AE11
		// (set) Token: 0x0601A4B3 RID: 107699 RVA: 0x0026CC21 File Offset: 0x0026AE21
		public unsafe bool bDrawContainerDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_bDrawContainerDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_bDrawContainerDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069BD RID: 27069
		// (get) Token: 0x0601A4B4 RID: 107700 RVA: 0x0026CC32 File Offset: 0x0026AE32
		// (set) Token: 0x0601A4B5 RID: 107701 RVA: 0x0026CC46 File Offset: 0x0026AE46
		public unsafe FLinearColor ContainerDebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_ContainerDebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_ContainerDebugColor) = value;
			}
		}

		// Token: 0x170069BE RID: 27070
		// (get) Token: 0x0601A4B6 RID: 107702 RVA: 0x0026CC5B File Offset: 0x0026AE5B
		// (set) Token: 0x0601A4B7 RID: 107703 RVA: 0x0026CC6B File Offset: 0x0026AE6B
		public unsafe float ContainerDebugThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_ContainerDebugThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_ContainerDebugThickness) = value;
			}
		}

		// Token: 0x170069BF RID: 27071
		// (get) Token: 0x0601A4B8 RID: 107704 RVA: 0x0026CC7C File Offset: 0x0026AE7C
		// (set) Token: 0x0601A4B9 RID: 107705 RVA: 0x0026CC90 File Offset: 0x0026AE90
		public unsafe FVectorDouble LiquidPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidPosition) = value;
			}
		}

		// Token: 0x170069C0 RID: 27072
		// (get) Token: 0x0601A4BA RID: 107706 RVA: 0x0026CCA5 File Offset: 0x0026AEA5
		// (set) Token: 0x0601A4BB RID: 107707 RVA: 0x0026CCB9 File Offset: 0x0026AEB9
		public unsafe FVectorDouble LiquidVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidVelocity) = value;
			}
		}

		// Token: 0x170069C1 RID: 27073
		// (get) Token: 0x0601A4BC RID: 107708 RVA: 0x0026CCCE File Offset: 0x0026AECE
		// (set) Token: 0x0601A4BD RID: 107709 RVA: 0x0026CCE2 File Offset: 0x0026AEE2
		public unsafe FVectorDouble PreviousLiquidVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_PreviousLiquidVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_PreviousLiquidVelocity) = value;
			}
		}

		// Token: 0x170069C2 RID: 27074
		// (get) Token: 0x0601A4BE RID: 107710 RVA: 0x0026CCF7 File Offset: 0x0026AEF7
		// (set) Token: 0x0601A4BF RID: 107711 RVA: 0x0026CD0B File Offset: 0x0026AF0B
		public unsafe FVectorDouble LiquidAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidAcceleration) = value;
			}
		}

		// Token: 0x170069C3 RID: 27075
		// (get) Token: 0x0601A4C0 RID: 107712 RVA: 0x0026CD20 File Offset: 0x0026AF20
		// (set) Token: 0x0601A4C1 RID: 107713 RVA: 0x0026CD34 File Offset: 0x0026AF34
		public unsafe UMaterialInstanceDynamic LiquidMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_LiquidMaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_LiquidMaterialInstance, value);
			}
		}

		// Token: 0x170069C4 RID: 27076
		// (get) Token: 0x0601A4C2 RID: 107714 RVA: 0x0026CD49 File Offset: 0x0026AF49
		// (set) Token: 0x0601A4C3 RID: 107715 RVA: 0x0026CD5D File Offset: 0x0026AF5D
		public unsafe FVectorDouble LiquidSurfaceNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidSurfaceNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidSurfaceNormal) = value;
			}
		}

		// Token: 0x170069C5 RID: 27077
		// (get) Token: 0x0601A4C4 RID: 107716 RVA: 0x0026CD72 File Offset: 0x0026AF72
		// (set) Token: 0x0601A4C5 RID: 107717 RVA: 0x0026CD86 File Offset: 0x0026AF86
		public unsafe FVectorDouble MassPointPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointPosition) = value;
			}
		}

		// Token: 0x170069C6 RID: 27078
		// (get) Token: 0x0601A4C6 RID: 107718 RVA: 0x0026CD9B File Offset: 0x0026AF9B
		// (set) Token: 0x0601A4C7 RID: 107719 RVA: 0x0026CDAF File Offset: 0x0026AFAF
		public unsafe FVectorDouble MassPointVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointVelocity) = value;
			}
		}

		// Token: 0x170069C7 RID: 27079
		// (get) Token: 0x0601A4C8 RID: 107720 RVA: 0x0026CDC4 File Offset: 0x0026AFC4
		// (set) Token: 0x0601A4C9 RID: 107721 RVA: 0x0026CDD8 File Offset: 0x0026AFD8
		public unsafe FVectorDouble MassPointAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointAcceleration) = value;
			}
		}

		// Token: 0x170069C8 RID: 27080
		// (get) Token: 0x0601A4CA RID: 107722 RVA: 0x0026CDED File Offset: 0x0026AFED
		// (set) Token: 0x0601A4CB RID: 107723 RVA: 0x0026CDFD File Offset: 0x0026AFFD
		public unsafe double MaxMassPointOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MaxMassPointOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MaxMassPointOffset) = value;
			}
		}

		// Token: 0x170069C9 RID: 27081
		// (get) Token: 0x0601A4CC RID: 107724 RVA: 0x0026CE0E File Offset: 0x0026B00E
		// (set) Token: 0x0601A4CD RID: 107725 RVA: 0x0026CE1E File Offset: 0x0026B01E
		public unsafe float SpringStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_SpringStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_SpringStrength) = value;
			}
		}

		// Token: 0x170069CA RID: 27082
		// (get) Token: 0x0601A4CE RID: 107726 RVA: 0x0026CE2F File Offset: 0x0026B02F
		// (set) Token: 0x0601A4CF RID: 107727 RVA: 0x0026CE3F File Offset: 0x0026B03F
		public unsafe float MassPointVelocityDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointVelocityDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_MassPointVelocityDamping) = value;
			}
		}

		// Token: 0x170069CB RID: 27083
		// (get) Token: 0x0601A4D0 RID: 107728 RVA: 0x0026CE50 File Offset: 0x0026B050
		// (set) Token: 0x0601A4D1 RID: 107729 RVA: 0x0026CE60 File Offset: 0x0026B060
		public unsafe float SurfaceTiltSensitivity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_SurfaceTiltSensitivity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_SurfaceTiltSensitivity) = value;
			}
		}

		// Token: 0x170069CC RID: 27084
		// (get) Token: 0x0601A4D2 RID: 107730 RVA: 0x0026CE71 File Offset: 0x0026B071
		// (set) Token: 0x0601A4D3 RID: 107731 RVA: 0x0026CE81 File Offset: 0x0026B081
		public unsafe bool bSimulateLiquidMeshPhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_bSimulateLiquidMeshPhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_bSimulateLiquidMeshPhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069CD RID: 27085
		// (get) Token: 0x0601A4D4 RID: 107732 RVA: 0x0026CE92 File Offset: 0x0026B092
		// (set) Token: 0x0601A4D5 RID: 107733 RVA: 0x0026CEA2 File Offset: 0x0026B0A2
		public unsafe bool bEnableLiquidMeshGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_bEnableLiquidMeshGravity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_bEnableLiquidMeshGravity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069CE RID: 27086
		// (get) Token: 0x0601A4D6 RID: 107734 RVA: 0x0026CEB3 File Offset: 0x0026B0B3
		// (set) Token: 0x0601A4D7 RID: 107735 RVA: 0x0026CEC7 File Offset: 0x0026B0C7
		public unsafe FName LiquidMeshCollisionProfile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidMeshCollisionProfile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidMeshCollisionProfile) = value;
			}
		}

		// Token: 0x170069CF RID: 27087
		// (get) Token: 0x0601A4D8 RID: 107736 RVA: 0x0026CEDC File Offset: 0x0026B0DC
		// (set) Token: 0x0601A4D9 RID: 107737 RVA: 0x0026CEEC File Offset: 0x0026B0EC
		public unsafe float LiquidMeshLinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidMeshLinearDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidMeshLinearDamping) = value;
			}
		}

		// Token: 0x170069D0 RID: 27088
		// (get) Token: 0x0601A4DA RID: 107738 RVA: 0x0026CEFD File Offset: 0x0026B0FD
		// (set) Token: 0x0601A4DB RID: 107739 RVA: 0x0026CF0D File Offset: 0x0026B10D
		public unsafe float LiquidMeshAngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidMeshAngularDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLiquidContainerActor.__PropertyOffset_LiquidMeshAngularDamping) = value;
			}
		}

		// Token: 0x170069D1 RID: 27089
		// (get) Token: 0x0601A4DC RID: 107740 RVA: 0x0026CF1E File Offset: 0x0026B11E
		// (set) Token: 0x0601A4DD RID: 107741 RVA: 0x0026CF32 File Offset: 0x0026B132
		public unsafe UMaterialInterface CachedMIDSourceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_CachedMIDSourceMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroLiquidContainerActor.__PropertyOffset_CachedMIDSourceMaterial, value);
			}
		}

		// Token: 0x0601A4DE RID: 107742 RVA: 0x0026CF47 File Offset: 0x0026B147
		public void UpdateMaterialPreviewInEditor()
		{
			AKuroLiquidContainerActor.__UpdateMaterialPreviewInEditor_Internal(base.NativePtr);
		}

		// Token: 0x0601A4DF RID: 107743 RVA: 0x0026CF54 File Offset: 0x0026B154
		public void StepLiquidSimulation(float DeltaSeconds)
		{
			AKuroLiquidContainerActor.__StepLiquidSimulation_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0601A4E0 RID: 107744 RVA: 0x0026CF62 File Offset: 0x0026B162
		public void InitializeLiquidState()
		{
			AKuroLiquidContainerActor.__InitializeLiquidState_Internal(base.NativePtr);
		}

		// Token: 0x0601A4E1 RID: 107745 RVA: 0x0026CF6F File Offset: 0x0026B16F
		public void EnableLiquidMeshPhysics()
		{
			AKuroLiquidContainerActor.__EnableLiquidMeshPhysics_Internal(base.NativePtr);
		}

		// Token: 0x0601A4E2 RID: 107746 RVA: 0x0026CF7C File Offset: 0x0026B17C
		public void DisableLiquidMeshPhysics()
		{
			AKuroLiquidContainerActor.__DisableLiquidMeshPhysics_Internal(base.NativePtr);
		}

		// Token: 0x0601A4E3 RID: 107747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMaterialPreviewInEditor_Internal(IntPtr @this);

		// Token: 0x0601A4E4 RID: 107748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StepLiquidSimulation_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601A4E5 RID: 107749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeLiquidState_Internal(IntPtr @this);

		// Token: 0x0601A4E6 RID: 107750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableLiquidMeshPhysics_Internal(IntPtr @this);

		// Token: 0x0601A4E7 RID: 107751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableLiquidMeshPhysics_Internal(IntPtr @this);

		// Token: 0x0601A4E8 RID: 107752 RVA: 0x0026CF89 File Offset: 0x0026B189
		static AKuroLiquidContainerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLiquidContainerActor");
		}

		// Token: 0x0601A4E9 RID: 107753 RVA: 0x0026CF97 File Offset: 0x0026B197
		protected AKuroLiquidContainerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E440 RID: 58432
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLiquidContainerActor";

		// Token: 0x0400E441 RID: 58433
		private static IntPtr _ClassPtr;

		// Token: 0x0400E442 RID: 58434
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E443 RID: 58435
		internal static int __PropertyOffset_RootScene;

		// Token: 0x0400E444 RID: 58436
		internal static int __PropertyOffset_LiquidMesh;

		// Token: 0x0400E445 RID: 58437
		internal static int __PropertyOffset_CapsulePointALocal;

		// Token: 0x0400E446 RID: 58438
		internal static int __PropertyOffset_CapsulePointBLocal;

		// Token: 0x0400E447 RID: 58439
		internal static int __PropertyOffset_CapsuleRadius;

		// Token: 0x0400E448 RID: 58440
		internal static int __PropertyOffset_LiquidBaseMaterial;

		// Token: 0x0400E449 RID: 58441
		internal static int __PropertyOffset_LiquidDensity;

		// Token: 0x0400E44A RID: 58442
		internal static int __PropertyOffset_LiquidBaseColor;

		// Token: 0x0400E44B RID: 58443
		internal static int __PropertyOffset_LiquidSubsurfaceColor;

		// Token: 0x0400E44C RID: 58444
		internal static int __PropertyOffset_LiquidFillHeightRatio;

		// Token: 0x0400E44D RID: 58445
		internal static int __PropertyOffset_bDrawContainerDebug;

		// Token: 0x0400E44E RID: 58446
		internal static int __PropertyOffset_ContainerDebugColor;

		// Token: 0x0400E44F RID: 58447
		internal static int __PropertyOffset_ContainerDebugThickness;

		// Token: 0x0400E450 RID: 58448
		internal static int __PropertyOffset_LiquidPosition;

		// Token: 0x0400E451 RID: 58449
		internal static int __PropertyOffset_LiquidVelocity;

		// Token: 0x0400E452 RID: 58450
		internal static int __PropertyOffset_PreviousLiquidVelocity;

		// Token: 0x0400E453 RID: 58451
		internal static int __PropertyOffset_LiquidAcceleration;

		// Token: 0x0400E454 RID: 58452
		internal static int __PropertyOffset_LiquidMaterialInstance;

		// Token: 0x0400E455 RID: 58453
		internal static int __PropertyOffset_LiquidSurfaceNormal;

		// Token: 0x0400E456 RID: 58454
		internal static int __PropertyOffset_MassPointPosition;

		// Token: 0x0400E457 RID: 58455
		internal static int __PropertyOffset_MassPointVelocity;

		// Token: 0x0400E458 RID: 58456
		internal static int __PropertyOffset_MassPointAcceleration;

		// Token: 0x0400E459 RID: 58457
		internal static int __PropertyOffset_MaxMassPointOffset;

		// Token: 0x0400E45A RID: 58458
		internal static int __PropertyOffset_SpringStrength;

		// Token: 0x0400E45B RID: 58459
		internal static int __PropertyOffset_MassPointVelocityDamping;

		// Token: 0x0400E45C RID: 58460
		internal static int __PropertyOffset_SurfaceTiltSensitivity;

		// Token: 0x0400E45D RID: 58461
		internal static int __PropertyOffset_bSimulateLiquidMeshPhysics;

		// Token: 0x0400E45E RID: 58462
		internal static int __PropertyOffset_bEnableLiquidMeshGravity;

		// Token: 0x0400E45F RID: 58463
		internal static int __PropertyOffset_LiquidMeshCollisionProfile;

		// Token: 0x0400E460 RID: 58464
		internal static int __PropertyOffset_LiquidMeshLinearDamping;

		// Token: 0x0400E461 RID: 58465
		internal static int __PropertyOffset_LiquidMeshAngularDamping;

		// Token: 0x0400E462 RID: 58466
		internal static int __PropertyOffset_CachedMIDSourceMaterial;
	}
}
