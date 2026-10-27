using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D73 RID: 3443
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MarchingCubesComponent")]
	[UnrealStructLayout(1984, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1984)]
	public class UMarchingCubesComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B9EA RID: 47594 RVA: 0x0010871D File Offset: 0x0010691D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMarchingCubesComponent._ClassPtr;
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x0010872C File Offset: 0x0010692C
		public UMarchingCubesComponent() : this(BuiltinUtils.AllocNativeUObject(UMarchingCubesComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x00108754 File Offset: 0x00106954
		[NullableContext(1)]
		public UMarchingCubesComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMarchingCubesComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0600B9ED RID: 47597 RVA: 0x00108787 File Offset: 0x00106987
		// (set) Token: 0x0600B9EE RID: 47598 RVA: 0x00108797 File Offset: 0x00106997
		public unsafe bool bRenderingEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bRenderingEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bRenderingEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x001087A8 File Offset: 0x001069A8
		// (set) Token: 0x0600B9F0 RID: 47600 RVA: 0x001087BC File Offset: 0x001069BC
		public unsafe FIntVector NumPointsPerAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_NumPointsPerAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_NumPointsPerAxis) = value;
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0600B9F1 RID: 47601 RVA: 0x001087D1 File Offset: 0x001069D1
		// (set) Token: 0x0600B9F2 RID: 47602 RVA: 0x001087E5 File Offset: 0x001069E5
		public unsafe FVector BoundsSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_BoundsSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_BoundsSize) = value;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0600B9F3 RID: 47603 RVA: 0x001087FA File Offset: 0x001069FA
		// (set) Token: 0x0600B9F4 RID: 47604 RVA: 0x0010880A File Offset: 0x00106A0A
		public unsafe float IsoLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_IsoLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_IsoLevel) = value;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0600B9F5 RID: 47605 RVA: 0x0010881B File Offset: 0x00106A1B
		// (set) Token: 0x0600B9F6 RID: 47606 RVA: 0x0010882B File Offset: 0x00106A2B
		public unsafe int TriangleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_TriangleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_TriangleCount) = value;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0600B9F7 RID: 47607 RVA: 0x0010883C File Offset: 0x00106A3C
		// (set) Token: 0x0600B9F8 RID: 47608 RVA: 0x00108850 File Offset: 0x00106A50
		public unsafe UTexture2D InputTexture2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UMarchingCubesComponent.__PropertyOffset_InputTexture2D);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMarchingCubesComponent.__PropertyOffset_InputTexture2D, value);
			}
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0600B9F9 RID: 47609 RVA: 0x00108865 File Offset: 0x00106A65
		// (set) Token: 0x0600B9FA RID: 47610 RVA: 0x00108875 File Offset: 0x00106A75
		public unsafe int CubeStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CubeStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CubeStepSize) = value;
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x0600B9FB RID: 47611 RVA: 0x00108886 File Offset: 0x00106A86
		// (set) Token: 0x0600B9FC RID: 47612 RVA: 0x0010889A File Offset: 0x00106A9A
		public unsafe FVector CharacterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CharacterPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CharacterPos) = value;
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x0600B9FD RID: 47613 RVA: 0x001088AF File Offset: 0x00106AAF
		// (set) Token: 0x0600B9FE RID: 47614 RVA: 0x001088BF File Offset: 0x00106ABF
		public unsafe float CharacterCollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CharacterCollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CharacterCollisionRadius) = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x0600B9FF RID: 47615 RVA: 0x001088D0 File Offset: 0x00106AD0
		// (set) Token: 0x0600BA00 RID: 47616 RVA: 0x001088E0 File Offset: 0x00106AE0
		public unsafe bool bEnableCharacterInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableCharacterInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableCharacterInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0600BA01 RID: 47617 RVA: 0x001088F1 File Offset: 0x00106AF1
		// (set) Token: 0x0600BA02 RID: 47618 RVA: 0x00108905 File Offset: 0x00106B05
		public unsafe FVector FrontWheelPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_FrontWheelPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_FrontWheelPos) = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600BA03 RID: 47619 RVA: 0x0010891A File Offset: 0x00106B1A
		// (set) Token: 0x0600BA04 RID: 47620 RVA: 0x0010892A File Offset: 0x00106B2A
		public unsafe float FrontWheelRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_FrontWheelRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_FrontWheelRadius) = value;
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600BA05 RID: 47621 RVA: 0x0010893B File Offset: 0x00106B3B
		// (set) Token: 0x0600BA06 RID: 47622 RVA: 0x0010894F File Offset: 0x00106B4F
		public unsafe FVector RearWheelPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_RearWheelPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_RearWheelPos) = value;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600BA07 RID: 47623 RVA: 0x00108964 File Offset: 0x00106B64
		// (set) Token: 0x0600BA08 RID: 47624 RVA: 0x00108974 File Offset: 0x00106B74
		public unsafe float RearWheelRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_RearWheelRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_RearWheelRadius) = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0600BA09 RID: 47625 RVA: 0x00108985 File Offset: 0x00106B85
		// (set) Token: 0x0600BA0A RID: 47626 RVA: 0x00108999 File Offset: 0x00106B99
		public unsafe FVector WeaponPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponPos) = value;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0600BA0B RID: 47627 RVA: 0x001089AE File Offset: 0x00106BAE
		// (set) Token: 0x0600BA0C RID: 47628 RVA: 0x001089C2 File Offset: 0x00106BC2
		public unsafe FVector WeaponPrevPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponPrevPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponPrevPos) = value;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0600BA0D RID: 47629 RVA: 0x001089D7 File Offset: 0x00106BD7
		// (set) Token: 0x0600BA0E RID: 47630 RVA: 0x001089EB File Offset: 0x00106BEB
		public unsafe FVector WeaponRootPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponRootPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponRootPos) = value;
			}
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600BA0F RID: 47631 RVA: 0x00108A00 File Offset: 0x00106C00
		// (set) Token: 0x0600BA10 RID: 47632 RVA: 0x00108A10 File Offset: 0x00106C10
		public unsafe float WeaponRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponRadius) = value;
			}
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x0600BA11 RID: 47633 RVA: 0x00108A21 File Offset: 0x00106C21
		// (set) Token: 0x0600BA12 RID: 47634 RVA: 0x00108A31 File Offset: 0x00106C31
		public unsafe float WeaponHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponHeight) = value;
			}
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x0600BA13 RID: 47635 RVA: 0x00108A42 File Offset: 0x00106C42
		// (set) Token: 0x0600BA14 RID: 47636 RVA: 0x00108A52 File Offset: 0x00106C52
		public unsafe float WeaponUpHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponUpHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_WeaponUpHeight) = value;
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600BA15 RID: 47637 RVA: 0x00108A63 File Offset: 0x00106C63
		// (set) Token: 0x0600BA16 RID: 47638 RVA: 0x00108A73 File Offset: 0x00106C73
		public unsafe bool bEnableWeaponInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableWeaponInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableWeaponInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600BA17 RID: 47639 RVA: 0x00108A84 File Offset: 0x00106C84
		// (set) Token: 0x0600BA18 RID: 47640 RVA: 0x00108A94 File Offset: 0x00106C94
		public unsafe bool bUseWeaponSweepInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bUseWeaponSweepInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bUseWeaponSweepInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0600BA19 RID: 47641 RVA: 0x00108AA8 File Offset: 0x00106CA8
		// (set) Token: 0x0600BA1A RID: 47642 RVA: 0x00108AE1 File Offset: 0x00106CE1
		[Nullable(1)]
		public FMarchingCubesParticleProperties ParticlePropertiesA
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMarchingCubesParticleProperties result;
				if ((result = this._ParticlePropertiesA) == null)
				{
					result = (this._ParticlePropertiesA = new FMarchingCubesParticleProperties(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_ParticlePropertiesA, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMarchingCubesParticleProperties.StaticStruct(), base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_ParticlePropertiesA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x0600BA1B RID: 47643 RVA: 0x00108B04 File Offset: 0x00106D04
		// (set) Token: 0x0600BA1C RID: 47644 RVA: 0x00108B3D File Offset: 0x00106D3D
		[Nullable(1)]
		public FMarchingCubesParticleProperties ParticlePropertiesB
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMarchingCubesParticleProperties result;
				if ((result = this._ParticlePropertiesB) == null)
				{
					result = (this._ParticlePropertiesB = new FMarchingCubesParticleProperties(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_ParticlePropertiesB, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMarchingCubesParticleProperties.StaticStruct(), base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_ParticlePropertiesB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x0600BA1D RID: 47645 RVA: 0x00108B5E File Offset: 0x00106D5E
		// (set) Token: 0x0600BA1E RID: 47646 RVA: 0x00108B6E File Offset: 0x00106D6E
		public unsafe float TypeBRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_TypeBRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_TypeBRatio) = value;
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x0600BA1F RID: 47647 RVA: 0x00108B7F File Offset: 0x00106D7F
		// (set) Token: 0x0600BA20 RID: 47648 RVA: 0x00108B8F File Offset: 0x00106D8F
		public unsafe bool bEnableDistanceLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableDistanceLOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableDistanceLOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x0600BA21 RID: 47649 RVA: 0x00108BA0 File Offset: 0x00106DA0
		// (set) Token: 0x0600BA22 RID: 47650 RVA: 0x00108BB0 File Offset: 0x00106DB0
		public unsafe int MinLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_MinLod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_MinLod) = value;
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x0600BA23 RID: 47651 RVA: 0x00108BC4 File Offset: 0x00106DC4
		// (set) Token: 0x0600BA24 RID: 47652 RVA: 0x00108BFD File Offset: 0x00106DFD
		[Nullable(1)]
		public TArray<FMarchingCubeLODInfo> LODInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMarchingCubeLODInfo> result;
				if ((result = this._LODInfo) == null)
				{
					result = (this._LODInfo = new TArray<FMarchingCubeLODInfo>(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_LODInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LODInfo.CopyAssign(value);
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x0600BA25 RID: 47653 RVA: 0x00108C0B File Offset: 0x00106E0B
		// (set) Token: 0x0600BA26 RID: 47654 RVA: 0x00108C1B File Offset: 0x00106E1B
		public unsafe bool bEnableStaticMeshLODSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableStaticMeshLODSwitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_bEnableStaticMeshLODSwitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0600BA27 RID: 47655 RVA: 0x00108C2C File Offset: 0x00106E2C
		// (set) Token: 0x0600BA28 RID: 47656 RVA: 0x00108C40 File Offset: 0x00106E40
		public unsafe FVector CameraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CameraPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_CameraPosition) = value;
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0600BA29 RID: 47657 RVA: 0x00108C55 File Offset: 0x00106E55
		// (set) Token: 0x0600BA2A RID: 47658 RVA: 0x00108C69 File Offset: 0x00106E69
		public unsafe AActor CharacterActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UMarchingCubesComponent.__PropertyOffset_CharacterActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMarchingCubesComponent.__PropertyOffset_CharacterActor, value);
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0600BA2B RID: 47659 RVA: 0x00108C7E File Offset: 0x00106E7E
		// (set) Token: 0x0600BA2C RID: 47660 RVA: 0x00108C8E File Offset: 0x00106E8E
		public unsafe float StaticMeshSwitchDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_StaticMeshSwitchDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMarchingCubesComponent.__PropertyOffset_StaticMeshSwitchDistance) = value;
			}
		}

		// Token: 0x0600BA2D RID: 47661 RVA: 0x00108C9F File Offset: 0x00106E9F
		public void SetWeaponSweepInteractionParams(FVector WeaponRootPosition, FVector PreviousWeaponPosition, FVector CurrentWeaponPosition, float Radius, float UpHeight, float DownDepth)
		{
			UMarchingCubesComponent.__SetWeaponSweepInteractionParams_Internal(base.NativePtr, WeaponRootPosition, PreviousWeaponPosition, CurrentWeaponPosition, Radius, UpHeight, DownDepth);
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x00108CB5 File Offset: 0x00106EB5
		public void SetWeaponInteractionParams(FVector WeaponPosition, float Radius, float Height)
		{
			UMarchingCubesComponent.__SetWeaponInteractionParams_Internal(base.NativePtr, WeaponPosition, Radius, Height);
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x00108CC5 File Offset: 0x00106EC5
		public void SetWeaponInteractionEnabled(bool bEnable)
		{
			UMarchingCubesComponent.__SetWeaponInteractionEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x00108CD3 File Offset: 0x00106ED3
		public void SetVehicleWheelInteractionParams(FVector FrontWheelPosition, float FrontRadius, FVector RearWheelPosition, float RearRadius)
		{
			UMarchingCubesComponent.__SetVehicleWheelInteractionParams_Internal(base.NativePtr, FrontWheelPosition, FrontRadius, RearWheelPosition, RearRadius);
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x00108CE5 File Offset: 0x00106EE5
		public void SetTypeBRatio(float NewRatio)
		{
			UMarchingCubesComponent.__SetTypeBRatio_Internal(base.NativePtr, NewRatio);
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x00108CF3 File Offset: 0x00106EF3
		public void SetStaticMeshSwitchDistance(float NewDistance)
		{
			UMarchingCubesComponent.__SetStaticMeshSwitchDistance_Internal(base.NativePtr, NewDistance);
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x00108D01 File Offset: 0x00106F01
		public void SetParticlePropertiesB(in FMarchingCubesParticleProperties NewProps)
		{
			UMarchingCubesComponent.__SetParticlePropertiesB_Internal(base.NativePtr, (NewProps ?? new FMarchingCubesParticleProperties()).NativePtr);
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x00108D1E File Offset: 0x00106F1E
		public void SetParticlePropertiesA(in FMarchingCubesParticleProperties NewProps)
		{
			UMarchingCubesComponent.__SetParticlePropertiesA_Internal(base.NativePtr, (NewProps ?? new FMarchingCubesParticleProperties()).NativePtr);
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x00108D3B File Offset: 0x00106F3B
		public void SetNumPointsPerAxis(FIntVector NewNumPointsPerAxis)
		{
			UMarchingCubesComponent.__SetNumPointsPerAxis_Internal(base.NativePtr, NewNumPointsPerAxis);
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x00108D49 File Offset: 0x00106F49
		public void SetIsoLevel(float NewIsoLevel)
		{
			UMarchingCubesComponent.__SetIsoLevel_Internal(base.NativePtr, NewIsoLevel);
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x00108D57 File Offset: 0x00106F57
		public void SetInputTexture2D(UTexture2D NewTexture)
		{
			UMarchingCubesComponent.__SetInputTexture2D_Internal(base.NativePtr, (NewTexture != null) ? NewTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x00108D74 File Offset: 0x00106F74
		public void SetCubeStepSize(int NewCubeStepSize)
		{
			UMarchingCubesComponent.__SetCubeStepSize_Internal(base.NativePtr, NewCubeStepSize);
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x00108D82 File Offset: 0x00106F82
		public void SetCharacterInteractionParams(FVector CharacterInteractionPos, float InteractionRadius)
		{
			UMarchingCubesComponent.__SetCharacterInteractionParams_Internal(base.NativePtr, CharacterInteractionPos, InteractionRadius);
		}

		// Token: 0x0600BA3A RID: 47674 RVA: 0x00108D91 File Offset: 0x00106F91
		public void SetCharacterInteractionEnabled(bool bEnable)
		{
			UMarchingCubesComponent.__SetCharacterInteractionEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x00108D9F File Offset: 0x00106F9F
		public void SetCharacterActor(AActor NewCharacterActor)
		{
			UMarchingCubesComponent.__SetCharacterActor_Internal(base.NativePtr, (NewCharacterActor != null) ? NewCharacterActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA3C RID: 47676 RVA: 0x00108DBC File Offset: 0x00106FBC
		public void SetCameraPosition(FVector NewCameraPosition)
		{
			UMarchingCubesComponent.__SetCameraPosition_Internal(base.NativePtr, NewCameraPosition);
		}

		// Token: 0x0600BA3D RID: 47677 RVA: 0x00108DCA File Offset: 0x00106FCA
		public void SetBoundsSize(FVector NewBoundsSize)
		{
			UMarchingCubesComponent.__SetBoundsSize_Internal(base.NativePtr, NewBoundsSize);
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x00108DD8 File Offset: 0x00106FD8
		public int GetLODNum()
		{
			return UMarchingCubesComponent.__GetLODNum_Internal(base.NativePtr);
		}

		// Token: 0x0600BA3F RID: 47679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWeaponSweepInteractionParams_Internal(IntPtr @this, FVector WeaponRootPosition, FVector PreviousWeaponPosition, FVector CurrentWeaponPosition, float Radius, float UpHeight, float DownDepth);

		// Token: 0x0600BA40 RID: 47680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWeaponInteractionParams_Internal(IntPtr @this, FVector WeaponPosition, float Radius, float Height);

		// Token: 0x0600BA41 RID: 47681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWeaponInteractionEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x0600BA42 RID: 47682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVehicleWheelInteractionParams_Internal(IntPtr @this, FVector FrontWheelPosition, float FrontRadius, FVector RearWheelPosition, float RearRadius);

		// Token: 0x0600BA43 RID: 47683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTypeBRatio_Internal(IntPtr @this, float NewRatio);

		// Token: 0x0600BA44 RID: 47684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStaticMeshSwitchDistance_Internal(IntPtr @this, float NewDistance);

		// Token: 0x0600BA45 RID: 47685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParticlePropertiesB_Internal(IntPtr @this, IntPtr NewProps);

		// Token: 0x0600BA46 RID: 47686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParticlePropertiesA_Internal(IntPtr @this, IntPtr NewProps);

		// Token: 0x0600BA47 RID: 47687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNumPointsPerAxis_Internal(IntPtr @this, FIntVector NewNumPointsPerAxis);

		// Token: 0x0600BA48 RID: 47688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsoLevel_Internal(IntPtr @this, float NewIsoLevel);

		// Token: 0x0600BA49 RID: 47689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputTexture2D_Internal(IntPtr @this, IntPtr NewTexture);

		// Token: 0x0600BA4A RID: 47690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCubeStepSize_Internal(IntPtr @this, int NewCubeStepSize);

		// Token: 0x0600BA4B RID: 47691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharacterInteractionParams_Internal(IntPtr @this, FVector CharacterInteractionPos, float InteractionRadius);

		// Token: 0x0600BA4C RID: 47692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharacterInteractionEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x0600BA4D RID: 47693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharacterActor_Internal(IntPtr @this, IntPtr NewCharacterActor);

		// Token: 0x0600BA4E RID: 47694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCameraPosition_Internal(IntPtr @this, FVector NewCameraPosition);

		// Token: 0x0600BA4F RID: 47695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundsSize_Internal(IntPtr @this, FVector NewBoundsSize);

		// Token: 0x0600BA50 RID: 47696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLODNum_Internal(IntPtr @this);

		// Token: 0x0600BA51 RID: 47697 RVA: 0x00108DE5 File Offset: 0x00106FE5
		static UMarchingCubesComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MarchingCubesComponent");
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x00108DF3 File Offset: 0x00106FF3
		protected UMarchingCubesComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006160 RID: 24928
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MarchingCubesComponent";

		// Token: 0x04006161 RID: 24929
		private static IntPtr _ClassPtr;

		// Token: 0x04006162 RID: 24930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006163 RID: 24931
		internal static int __PropertyOffset_bRenderingEnabled;

		// Token: 0x04006164 RID: 24932
		internal static int __PropertyOffset_NumPointsPerAxis;

		// Token: 0x04006165 RID: 24933
		internal static int __PropertyOffset_BoundsSize;

		// Token: 0x04006166 RID: 24934
		internal static int __PropertyOffset_IsoLevel;

		// Token: 0x04006167 RID: 24935
		internal static int __PropertyOffset_TriangleCount;

		// Token: 0x04006168 RID: 24936
		internal static int __PropertyOffset_InputTexture2D;

		// Token: 0x04006169 RID: 24937
		internal static int __PropertyOffset_CubeStepSize;

		// Token: 0x0400616A RID: 24938
		internal static int __PropertyOffset_CharacterPos;

		// Token: 0x0400616B RID: 24939
		internal static int __PropertyOffset_CharacterCollisionRadius;

		// Token: 0x0400616C RID: 24940
		internal static int __PropertyOffset_bEnableCharacterInteraction;

		// Token: 0x0400616D RID: 24941
		internal static int __PropertyOffset_FrontWheelPos;

		// Token: 0x0400616E RID: 24942
		internal static int __PropertyOffset_FrontWheelRadius;

		// Token: 0x0400616F RID: 24943
		internal static int __PropertyOffset_RearWheelPos;

		// Token: 0x04006170 RID: 24944
		internal static int __PropertyOffset_RearWheelRadius;

		// Token: 0x04006171 RID: 24945
		internal static int __PropertyOffset_WeaponPos;

		// Token: 0x04006172 RID: 24946
		internal static int __PropertyOffset_WeaponPrevPos;

		// Token: 0x04006173 RID: 24947
		internal static int __PropertyOffset_WeaponRootPos;

		// Token: 0x04006174 RID: 24948
		internal static int __PropertyOffset_WeaponRadius;

		// Token: 0x04006175 RID: 24949
		internal static int __PropertyOffset_WeaponHeight;

		// Token: 0x04006176 RID: 24950
		internal static int __PropertyOffset_WeaponUpHeight;

		// Token: 0x04006177 RID: 24951
		internal static int __PropertyOffset_bEnableWeaponInteraction;

		// Token: 0x04006178 RID: 24952
		internal static int __PropertyOffset_bUseWeaponSweepInteraction;

		// Token: 0x04006179 RID: 24953
		internal static int __PropertyOffset_ParticlePropertiesA;

		// Token: 0x0400617A RID: 24954
		private FMarchingCubesParticleProperties _ParticlePropertiesA;

		// Token: 0x0400617B RID: 24955
		internal static int __PropertyOffset_ParticlePropertiesB;

		// Token: 0x0400617C RID: 24956
		private FMarchingCubesParticleProperties _ParticlePropertiesB;

		// Token: 0x0400617D RID: 24957
		internal static int __PropertyOffset_TypeBRatio;

		// Token: 0x0400617E RID: 24958
		internal static int __PropertyOffset_bEnableDistanceLOD;

		// Token: 0x0400617F RID: 24959
		internal static int __PropertyOffset_MinLod;

		// Token: 0x04006180 RID: 24960
		internal static int __PropertyOffset_LODInfo;

		// Token: 0x04006181 RID: 24961
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMarchingCubeLODInfo> _LODInfo;

		// Token: 0x04006182 RID: 24962
		internal static int __PropertyOffset_bEnableStaticMeshLODSwitch;

		// Token: 0x04006183 RID: 24963
		internal static int __PropertyOffset_CameraPosition;

		// Token: 0x04006184 RID: 24964
		internal static int __PropertyOffset_CharacterActor;

		// Token: 0x04006185 RID: 24965
		internal static int __PropertyOffset_StaticMeshSwitchDistance;
	}
}
