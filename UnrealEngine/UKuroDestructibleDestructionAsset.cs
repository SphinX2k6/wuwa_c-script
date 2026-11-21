using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C1 RID: 1217
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleDestructionAsset")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKuroDestructibleDestructionAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007003 RID: 28675 RVA: 0x000A597A File Offset: 0x000A3B7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDestructibleDestructionAsset._ClassPtr;
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x000A5988 File Offset: 0x000A3B88
		public UKuroDestructibleDestructionAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleDestructionAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x000A59B0 File Offset: 0x000A3BB0
		public UKuroDestructibleDestructionAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDestructibleDestructionAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x000A59E4 File Offset: 0x000A3BE4
		// (set) Token: 0x06007007 RID: 28679 RVA: 0x000A5A1D File Offset: 0x000A3C1D
		public FCollisionProfileName CollisionProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._CollisionProfileName) == null)
				{
					result = (this._CollisionProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_CollisionProfileName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_CollisionProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06007008 RID: 28680 RVA: 0x000A5A40 File Offset: 0x000A3C40
		// (set) Token: 0x06007009 RID: 28681 RVA: 0x000A5A79 File Offset: 0x000A3C79
		public FCollisionProfileName TriggerCollisionProfileName
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._TriggerCollisionProfileName) == null)
				{
					result = (this._TriggerCollisionProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TriggerCollisionProfileName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TriggerCollisionProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x0600700A RID: 28682 RVA: 0x000A5A9A File Offset: 0x000A3C9A
		// (set) Token: 0x0600700B RID: 28683 RVA: 0x000A5AAA File Offset: 0x000A3CAA
		public unsafe bool bProxyMeshComponentCanHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x000A5ABB File Offset: 0x000A3CBB
		// (set) Token: 0x0600700D RID: 28685 RVA: 0x000A5ACB File Offset: 0x000A3CCB
		public unsafe bool bProxyMeshComponentCanOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bProxyMeshComponentCanOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x0600700E RID: 28686 RVA: 0x000A5ADC File Offset: 0x000A3CDC
		// (set) Token: 0x0600700F RID: 28687 RVA: 0x000A5AEC File Offset: 0x000A3CEC
		public unsafe bool bIgnoreBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06007010 RID: 28688 RVA: 0x000A5AFD File Offset: 0x000A3CFD
		// (set) Token: 0x06007011 RID: 28689 RVA: 0x000A5B0D File Offset: 0x000A3D0D
		public unsafe float BaseForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_BaseForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_BaseForce) = value;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06007012 RID: 28690 RVA: 0x000A5B1E File Offset: 0x000A3D1E
		// (set) Token: 0x06007013 RID: 28691 RVA: 0x000A5B2E File Offset: 0x000A3D2E
		public unsafe float ImpulseFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor) = value;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x000A5B3F File Offset: 0x000A3D3F
		// (set) Token: 0x06007015 RID: 28693 RVA: 0x000A5B4F File Offset: 0x000A3D4F
		public unsafe float ImpulseFactor2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_ImpulseFactor2) = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06007016 RID: 28694 RVA: 0x000A5B60 File Offset: 0x000A3D60
		// (set) Token: 0x06007017 RID: 28695 RVA: 0x000A5B70 File Offset: 0x000A3D70
		public unsafe float DamageThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageThreshold) = value;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x000A5B81 File Offset: 0x000A3D81
		// (set) Token: 0x06007019 RID: 28697 RVA: 0x000A5B91 File Offset: 0x000A3D91
		public unsafe bool bUseDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600701A RID: 28698 RVA: 0x000A5BA2 File Offset: 0x000A3DA2
		// (set) Token: 0x0600701B RID: 28699 RVA: 0x000A5BB2 File Offset: 0x000A3DB2
		public unsafe float TotalDamageAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TotalDamageAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TotalDamageAmount) = value;
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x0600701C RID: 28700 RVA: 0x000A5BC3 File Offset: 0x000A3DC3
		// (set) Token: 0x0600701D RID: 28701 RVA: 0x000A5BD3 File Offset: 0x000A3DD3
		public unsafe bool bUseAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAttenuation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAttenuation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x000A5BE4 File Offset: 0x000A3DE4
		// (set) Token: 0x0600701F RID: 28703 RVA: 0x000A5BF4 File Offset: 0x000A3DF4
		public unsafe bool bUseAutoDamageRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAutoDamageRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseAutoDamageRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06007020 RID: 28704 RVA: 0x000A5C05 File Offset: 0x000A3E05
		// (set) Token: 0x06007021 RID: 28705 RVA: 0x000A5C15 File Offset: 0x000A3E15
		public unsafe float DamageRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DamageRadius) = value;
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06007022 RID: 28706 RVA: 0x000A5C26 File Offset: 0x000A3E26
		// (set) Token: 0x06007023 RID: 28707 RVA: 0x000A5C36 File Offset: 0x000A3E36
		public unsafe bool bAddImpulseAtLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddImpulseAtLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddImpulseAtLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06007024 RID: 28708 RVA: 0x000A5C47 File Offset: 0x000A3E47
		// (set) Token: 0x06007025 RID: 28709 RVA: 0x000A5C57 File Offset: 0x000A3E57
		public unsafe bool bVelChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bVelChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bVelChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06007026 RID: 28710 RVA: 0x000A5C68 File Offset: 0x000A3E68
		// (set) Token: 0x06007027 RID: 28711 RVA: 0x000A5C78 File Offset: 0x000A3E78
		public unsafe bool bAddAngularImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddAngularImpulse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddAngularImpulse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06007028 RID: 28712 RVA: 0x000A5C89 File Offset: 0x000A3E89
		// (set) Token: 0x06007029 RID: 28713 RVA: 0x000A5C99 File Offset: 0x000A3E99
		public unsafe float AngularImpulseFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_AngularImpulseFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_AngularImpulseFactor) = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x0600702A RID: 28714 RVA: 0x000A5CAA File Offset: 0x000A3EAA
		// (set) Token: 0x0600702B RID: 28715 RVA: 0x000A5CBA File Offset: 0x000A3EBA
		public unsafe bool bUseEasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseEasing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseEasing) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x0600702C RID: 28716 RVA: 0x000A5CCB File Offset: 0x000A3ECB
		// (set) Token: 0x0600702D RID: 28717 RVA: 0x000A5CDB File Offset: 0x000A3EDB
		public unsafe float MaxEaseMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_MaxEaseMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_MaxEaseMass) = value;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x0600702E RID: 28718 RVA: 0x000A5CEC File Offset: 0x000A3EEC
		// (set) Token: 0x0600702F RID: 28719 RVA: 0x000A5CFC File Offset: 0x000A3EFC
		public unsafe ECurveSourceType SourceType
		{
			get
			{
				return (ECurveSourceType)(*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_SourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_SourceType) = (byte)value;
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06007030 RID: 28720 RVA: 0x000A5D0D File Offset: 0x000A3F0D
		// (set) Token: 0x06007031 RID: 28721 RVA: 0x000A5D21 File Offset: 0x000A3F21
		[Nullable(2)]
		public unsafe UCurveFloat CurveAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_CurveAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_CurveAsset, value);
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06007032 RID: 28722 RVA: 0x000A5D36 File Offset: 0x000A3F36
		// (set) Token: 0x06007033 RID: 28723 RVA: 0x000A5D46 File Offset: 0x000A3F46
		public unsafe EEasingType EasingType
		{
			get
			{
				return (EEasingType)(*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_EasingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_EasingType) = (byte)value;
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06007034 RID: 28724 RVA: 0x000A5D57 File Offset: 0x000A3F57
		// (set) Token: 0x06007035 RID: 28725 RVA: 0x000A5D67 File Offset: 0x000A3F67
		public unsafe bool bUseLinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseLinearDamping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bUseLinearDamping) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06007036 RID: 28726 RVA: 0x000A5D78 File Offset: 0x000A3F78
		// (set) Token: 0x06007037 RID: 28727 RVA: 0x000A5D88 File Offset: 0x000A3F88
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_LinearDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_LinearDamping) = value;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06007038 RID: 28728 RVA: 0x000A5D99 File Offset: 0x000A3F99
		// (set) Token: 0x06007039 RID: 28729 RVA: 0x000A5DA9 File Offset: 0x000A3FA9
		public unsafe bool bIgnoreUpdateOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreUpdateOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bIgnoreUpdateOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x000A5DBA File Offset: 0x000A3FBA
		// (set) Token: 0x0600703B RID: 28731 RVA: 0x000A5DCA File Offset: 0x000A3FCA
		public unsafe float StaticMeshSimulatePhysicsTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_StaticMeshSimulatePhysicsTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_StaticMeshSimulatePhysicsTime) = value;
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x0600703C RID: 28732 RVA: 0x000A5DDB File Offset: 0x000A3FDB
		// (set) Token: 0x0600703D RID: 28733 RVA: 0x000A5DEB File Offset: 0x000A3FEB
		public unsafe bool bCreateTrunksWhileApplyDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bCreateTrunksWhileApplyDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bCreateTrunksWhileApplyDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x0600703E RID: 28734 RVA: 0x000A5DFC File Offset: 0x000A3FFC
		// (set) Token: 0x0600703F RID: 28735 RVA: 0x000A5E0C File Offset: 0x000A400C
		public unsafe byte TrunksCreateCountPerFrameMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMax) = value;
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06007040 RID: 28736 RVA: 0x000A5E1D File Offset: 0x000A401D
		// (set) Token: 0x06007041 RID: 28737 RVA: 0x000A5E2D File Offset: 0x000A402D
		public unsafe byte TrunksCreateCountPerFrameWindowsRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameWindowsRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameWindowsRatio) = value;
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06007042 RID: 28738 RVA: 0x000A5E3E File Offset: 0x000A403E
		// (set) Token: 0x06007043 RID: 28739 RVA: 0x000A5E4E File Offset: 0x000A404E
		public unsafe byte TrunksCreateCountPerFrameIOSRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameIOSRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameIOSRatio) = value;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06007044 RID: 28740 RVA: 0x000A5E5F File Offset: 0x000A405F
		// (set) Token: 0x06007045 RID: 28741 RVA: 0x000A5E6F File Offset: 0x000A406F
		public unsafe byte TrunksCreateCountPerFrameAndroidRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameAndroidRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameAndroidRatio) = value;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x000A5E80 File Offset: 0x000A4080
		// (set) Token: 0x06007047 RID: 28743 RVA: 0x000A5E90 File Offset: 0x000A4090
		public unsafe byte TrunksCreateCountPerFrameMacRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMacRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFrameMacRatio) = value;
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06007048 RID: 28744 RVA: 0x000A5EA1 File Offset: 0x000A40A1
		// (set) Token: 0x06007049 RID: 28745 RVA: 0x000A5EB1 File Offset: 0x000A40B1
		public unsafe byte TrunksCreateCountPerFramePS5Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFramePS5Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksCreateCountPerFramePS5Ratio) = value;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x0600704A RID: 28746 RVA: 0x000A5EC2 File Offset: 0x000A40C2
		// (set) Token: 0x0600704B RID: 28747 RVA: 0x000A5ED2 File Offset: 0x000A40D2
		public unsafe bool bAutoDestroyAfterStopSimulatePhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAutoDestroyAfterStopSimulatePhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAutoDestroyAfterStopSimulatePhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x0600704C RID: 28748 RVA: 0x000A5EE3 File Offset: 0x000A40E3
		// (set) Token: 0x0600704D RID: 28749 RVA: 0x000A5EF3 File Offset: 0x000A40F3
		public unsafe bool bAddToGamePartition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddToGamePartition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bAddToGamePartition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x0600704E RID: 28750 RVA: 0x000A5F04 File Offset: 0x000A4104
		// (set) Token: 0x0600704F RID: 28751 RVA: 0x000A5F14 File Offset: 0x000A4114
		public unsafe EGamePartitionCellSizeType GamePartitionCellSize
		{
			get
			{
				return (EGamePartitionCellSizeType)(*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_GamePartitionCellSize));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_GamePartitionCellSize) = (byte)value;
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06007050 RID: 28752 RVA: 0x000A5F25 File Offset: 0x000A4125
		// (set) Token: 0x06007051 RID: 28753 RVA: 0x000A5F35 File Offset: 0x000A4135
		public unsafe bool bTrunksKeepLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepLinearVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepLinearVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06007052 RID: 28754 RVA: 0x000A5F46 File Offset: 0x000A4146
		// (set) Token: 0x06007053 RID: 28755 RVA: 0x000A5F56 File Offset: 0x000A4156
		public unsafe bool bTrunksKeepAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepAngularVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksKeepAngularVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06007054 RID: 28756 RVA: 0x000A5F67 File Offset: 0x000A4167
		// (set) Token: 0x06007055 RID: 28757 RVA: 0x000A5F77 File Offset: 0x000A4177
		public unsafe bool bTrunksOverrideLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideLinearVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideLinearVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06007056 RID: 28758 RVA: 0x000A5F88 File Offset: 0x000A4188
		// (set) Token: 0x06007057 RID: 28759 RVA: 0x000A5F98 File Offset: 0x000A4198
		public unsafe bool bTrunksOverrideAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideAngularVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_bTrunksOverrideAngularVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06007058 RID: 28760 RVA: 0x000A5FA9 File Offset: 0x000A41A9
		// (set) Token: 0x06007059 RID: 28761 RVA: 0x000A5FBD File Offset: 0x000A41BD
		public unsafe FVector TrunksLinearVelocityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksLinearVelocityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksLinearVelocityOverride) = value;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x0600705A RID: 28762 RVA: 0x000A5FD2 File Offset: 0x000A41D2
		// (set) Token: 0x0600705B RID: 28763 RVA: 0x000A5FE6 File Offset: 0x000A41E6
		public unsafe FVector TrunksAngularVelocityInDegreesOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksAngularVelocityInDegreesOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_TrunksAngularVelocityInDegreesOverride) = value;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x000A5FFB File Offset: 0x000A41FB
		// (set) Token: 0x0600705D RID: 28765 RVA: 0x000A600F File Offset: 0x000A420F
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterialOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_PhysMaterialOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroDestructibleDestructionAsset.__PropertyOffset_PhysMaterialOverride, value);
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x0600705E RID: 28766 RVA: 0x000A6024 File Offset: 0x000A4224
		// (set) Token: 0x0600705F RID: 28767 RVA: 0x000A605D File Offset: 0x000A425D
		public FKuroDestructibleEffect Effect
		{
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleEffect result;
				if ((result = this._Effect) == null)
				{
					result = (this._Effect = new FKuroDestructibleEffect(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_Effect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroDestructibleEffect.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_Effect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06007060 RID: 28768 RVA: 0x000A6080 File Offset: 0x000A4280
		// (set) Token: 0x06007061 RID: 28769 RVA: 0x000A60B9 File Offset: 0x000A42B9
		public FKuroDestructibleEffect DestructionEffect
		{
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleEffect result;
				if ((result = this._DestructionEffect) == null)
				{
					result = (this._DestructionEffect = new FKuroDestructibleEffect(base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DestructionEffect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroDestructibleEffect.StaticStruct(), base.NativePtr + (IntPtr)UKuroDestructibleDestructionAsset.__PropertyOffset_DestructionEffect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x000A60DA File Offset: 0x000A42DA
		static UKuroDestructibleDestructionAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleDestructionAsset");
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x000A60E8 File Offset: 0x000A42E8
		protected UKuroDestructibleDestructionAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400305E RID: 12382
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleDestructionAsset";

		// Token: 0x0400305F RID: 12383
		private static IntPtr _ClassPtr;

		// Token: 0x04003060 RID: 12384
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003061 RID: 12385
		internal static int __PropertyOffset_CollisionProfileName;

		// Token: 0x04003062 RID: 12386
		[Nullable(2)]
		private FCollisionProfileName _CollisionProfileName;

		// Token: 0x04003063 RID: 12387
		internal static int __PropertyOffset_TriggerCollisionProfileName;

		// Token: 0x04003064 RID: 12388
		[Nullable(2)]
		private FCollisionProfileName _TriggerCollisionProfileName;

		// Token: 0x04003065 RID: 12389
		internal static int __PropertyOffset_bProxyMeshComponentCanHit;

		// Token: 0x04003066 RID: 12390
		internal static int __PropertyOffset_bProxyMeshComponentCanOverlap;

		// Token: 0x04003067 RID: 12391
		internal static int __PropertyOffset_bIgnoreBullet;

		// Token: 0x04003068 RID: 12392
		internal static int __PropertyOffset_BaseForce;

		// Token: 0x04003069 RID: 12393
		internal static int __PropertyOffset_ImpulseFactor;

		// Token: 0x0400306A RID: 12394
		internal static int __PropertyOffset_ImpulseFactor2;

		// Token: 0x0400306B RID: 12395
		internal static int __PropertyOffset_DamageThreshold;

		// Token: 0x0400306C RID: 12396
		internal static int __PropertyOffset_bUseDamage;

		// Token: 0x0400306D RID: 12397
		internal static int __PropertyOffset_TotalDamageAmount;

		// Token: 0x0400306E RID: 12398
		internal static int __PropertyOffset_bUseAttenuation;

		// Token: 0x0400306F RID: 12399
		internal static int __PropertyOffset_bUseAutoDamageRadius;

		// Token: 0x04003070 RID: 12400
		internal static int __PropertyOffset_DamageRadius;

		// Token: 0x04003071 RID: 12401
		internal static int __PropertyOffset_bAddImpulseAtLocation;

		// Token: 0x04003072 RID: 12402
		internal static int __PropertyOffset_bVelChange;

		// Token: 0x04003073 RID: 12403
		internal static int __PropertyOffset_bAddAngularImpulse;

		// Token: 0x04003074 RID: 12404
		internal static int __PropertyOffset_AngularImpulseFactor;

		// Token: 0x04003075 RID: 12405
		internal static int __PropertyOffset_bUseEasing;

		// Token: 0x04003076 RID: 12406
		internal static int __PropertyOffset_MaxEaseMass;

		// Token: 0x04003077 RID: 12407
		internal static int __PropertyOffset_SourceType;

		// Token: 0x04003078 RID: 12408
		internal static int __PropertyOffset_CurveAsset;

		// Token: 0x04003079 RID: 12409
		internal static int __PropertyOffset_EasingType;

		// Token: 0x0400307A RID: 12410
		internal static int __PropertyOffset_bUseLinearDamping;

		// Token: 0x0400307B RID: 12411
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x0400307C RID: 12412
		internal static int __PropertyOffset_bIgnoreUpdateOverlap;

		// Token: 0x0400307D RID: 12413
		internal static int __PropertyOffset_StaticMeshSimulatePhysicsTime;

		// Token: 0x0400307E RID: 12414
		internal static int __PropertyOffset_bCreateTrunksWhileApplyDamage;

		// Token: 0x0400307F RID: 12415
		internal static int __PropertyOffset_TrunksCreateCountPerFrameMax;

		// Token: 0x04003080 RID: 12416
		internal static int __PropertyOffset_TrunksCreateCountPerFrameWindowsRatio;

		// Token: 0x04003081 RID: 12417
		internal static int __PropertyOffset_TrunksCreateCountPerFrameIOSRatio;

		// Token: 0x04003082 RID: 12418
		internal static int __PropertyOffset_TrunksCreateCountPerFrameAndroidRatio;

		// Token: 0x04003083 RID: 12419
		internal static int __PropertyOffset_TrunksCreateCountPerFrameMacRatio;

		// Token: 0x04003084 RID: 12420
		internal static int __PropertyOffset_TrunksCreateCountPerFramePS5Ratio;

		// Token: 0x04003085 RID: 12421
		internal static int __PropertyOffset_bAutoDestroyAfterStopSimulatePhysics;

		// Token: 0x04003086 RID: 12422
		internal static int __PropertyOffset_bAddToGamePartition;

		// Token: 0x04003087 RID: 12423
		internal static int __PropertyOffset_GamePartitionCellSize;

		// Token: 0x04003088 RID: 12424
		internal static int __PropertyOffset_bTrunksKeepLinearVelocity;

		// Token: 0x04003089 RID: 12425
		internal static int __PropertyOffset_bTrunksKeepAngularVelocity;

		// Token: 0x0400308A RID: 12426
		internal static int __PropertyOffset_bTrunksOverrideLinearVelocity;

		// Token: 0x0400308B RID: 12427
		internal static int __PropertyOffset_bTrunksOverrideAngularVelocity;

		// Token: 0x0400308C RID: 12428
		internal static int __PropertyOffset_TrunksLinearVelocityOverride;

		// Token: 0x0400308D RID: 12429
		internal static int __PropertyOffset_TrunksAngularVelocityInDegreesOverride;

		// Token: 0x0400308E RID: 12430
		internal static int __PropertyOffset_PhysMaterialOverride;

		// Token: 0x0400308F RID: 12431
		internal static int __PropertyOffset_Effect;

		// Token: 0x04003090 RID: 12432
		[Nullable(2)]
		private FKuroDestructibleEffect _Effect;

		// Token: 0x04003091 RID: 12433
		internal static int __PropertyOffset_DestructionEffect;

		// Token: 0x04003092 RID: 12434
		[Nullable(2)]
		private FKuroDestructibleEffect _DestructionEffect;
	}
}
