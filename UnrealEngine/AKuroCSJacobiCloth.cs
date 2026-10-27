using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017AF RID: 6063
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSJacobiCloth")]
	[UnrealStructLayout(2592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2592)]
	public class AKuroCSJacobiCloth : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015FD3 RID: 90067 RVA: 0x00203B6A File Offset: 0x00201D6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSJacobiCloth._ClassPtr;
		}

		// Token: 0x06015FD4 RID: 90068 RVA: 0x00203B78 File Offset: 0x00201D78
		public AKuroCSJacobiCloth() : this(BuiltinUtils.AllocNativeUObject(AKuroCSJacobiCloth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015FD5 RID: 90069 RVA: 0x00203BA0 File Offset: 0x00201DA0
		public AKuroCSJacobiCloth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSJacobiCloth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700577D RID: 22397
		// (get) Token: 0x06015FD6 RID: 90070 RVA: 0x00203BD3 File Offset: 0x00201DD3
		// (set) Token: 0x06015FD7 RID: 90071 RVA: 0x00203BE7 File Offset: 0x00201DE7
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x1700577E RID: 22398
		// (get) Token: 0x06015FD8 RID: 90072 RVA: 0x00203BFC File Offset: 0x00201DFC
		// (set) Token: 0x06015FD9 RID: 90073 RVA: 0x00203C10 File Offset: 0x00201E10
		[Nullable(2)]
		public unsafe UBoxComponent ManagementBounds
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_ManagementBounds);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_ManagementBounds, value);
			}
		}

		// Token: 0x1700577F RID: 22399
		// (get) Token: 0x06015FDA RID: 90074 RVA: 0x00203C25 File Offset: 0x00201E25
		// (set) Token: 0x06015FDB RID: 90075 RVA: 0x00203C39 File Offset: 0x00201E39
		[Nullable(2)]
		public unsafe UKuroJacobiClothSetDataAsset ClothDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroJacobiClothSetDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_ClothDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_ClothDataAsset, value);
			}
		}

		// Token: 0x17005780 RID: 22400
		// (get) Token: 0x06015FDC RID: 90076 RVA: 0x00203C4E File Offset: 0x00201E4E
		// (set) Token: 0x06015FDD RID: 90077 RVA: 0x00203C5E File Offset: 0x00201E5E
		public unsafe EKuroCSJacobiClothRuntimeBackend RuntimeBackend
		{
			get
			{
				return (EKuroCSJacobiClothRuntimeBackend)(*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_RuntimeBackend));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_RuntimeBackend) = (byte)value;
			}
		}

		// Token: 0x17005781 RID: 22401
		// (get) Token: 0x06015FDE RID: 90078 RVA: 0x00203C6F File Offset: 0x00201E6F
		// (set) Token: 0x06015FDF RID: 90079 RVA: 0x00203C7F File Offset: 0x00201E7F
		public unsafe float InitializationTimeBudgetMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_InitializationTimeBudgetMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_InitializationTimeBudgetMs) = value;
			}
		}

		// Token: 0x17005782 RID: 22402
		// (get) Token: 0x06015FE0 RID: 90080 RVA: 0x00203C90 File Offset: 0x00201E90
		// (set) Token: 0x06015FE1 RID: 90081 RVA: 0x00203CA0 File Offset: 0x00201EA0
		public unsafe bool bJacobiReady
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bJacobiReady) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bJacobiReady) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005783 RID: 22403
		// (get) Token: 0x06015FE2 RID: 90082 RVA: 0x00203CB1 File Offset: 0x00201EB1
		// (set) Token: 0x06015FE3 RID: 90083 RVA: 0x00203CC5 File Offset: 0x00201EC5
		[Nullable(2)]
		public unsafe UKuroCSJacobiClothVertexFactoryComponent VertexFactoryRenderer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCSJacobiClothVertexFactoryComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_VertexFactoryRenderer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_VertexFactoryRenderer, value);
			}
		}

		// Token: 0x17005784 RID: 22404
		// (get) Token: 0x06015FE4 RID: 90084 RVA: 0x00203CDA File Offset: 0x00201EDA
		// (set) Token: 0x06015FE5 RID: 90085 RVA: 0x00203CEA File Offset: 0x00201EEA
		public unsafe bool bHideSourceStaticMeshes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bHideSourceStaticMeshes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bHideSourceStaticMeshes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005785 RID: 22405
		// (get) Token: 0x06015FE6 RID: 90086 RVA: 0x00203CFC File Offset: 0x00201EFC
		// (set) Token: 0x06015FE7 RID: 90087 RVA: 0x00203D35 File Offset: 0x00201F35
		public FCollisionProfileName StaticFallbackCollisionProfile
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._StaticFallbackCollisionProfile) == null)
				{
					result = (this._StaticFallbackCollisionProfile = new FCollisionProfileName(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_StaticFallbackCollisionProfile, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_StaticFallbackCollisionProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005786 RID: 22406
		// (get) Token: 0x06015FE8 RID: 90088 RVA: 0x00203D56 File Offset: 0x00201F56
		// (set) Token: 0x06015FE9 RID: 90089 RVA: 0x00203D6A File Offset: 0x00201F6A
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionEnabled> StaticFallbackCollisionEnabled
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_StaticFallbackCollisionEnabled);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_StaticFallbackCollisionEnabled) = value;
			}
		}

		// Token: 0x17005787 RID: 22407
		// (get) Token: 0x06015FEA RID: 90090 RVA: 0x00203D7F File Offset: 0x00201F7F
		// (set) Token: 0x06015FEB RID: 90091 RVA: 0x00203D8F File Offset: 0x00201F8F
		public unsafe float VertexFactoryMatchTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_VertexFactoryMatchTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_VertexFactoryMatchTolerance) = value;
			}
		}

		// Token: 0x17005788 RID: 22408
		// (get) Token: 0x06015FEC RID: 90092 RVA: 0x00203DA0 File Offset: 0x00201FA0
		// (set) Token: 0x06015FED RID: 90093 RVA: 0x00203DD9 File Offset: 0x00201FD9
		public TArray<FKuroCSParticle_jacobiCloth> ParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_jacobiCloth> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_jacobiCloth>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x17005789 RID: 22409
		// (get) Token: 0x06015FEE RID: 90094 RVA: 0x00203DE7 File Offset: 0x00201FE7
		// (set) Token: 0x06015FEF RID: 90095 RVA: 0x00203DFB File Offset: 0x00201FFB
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x1700578A RID: 22410
		// (get) Token: 0x06015FF0 RID: 90096 RVA: 0x00203E10 File Offset: 0x00202010
		// (set) Token: 0x06015FF1 RID: 90097 RVA: 0x00203E24 File Offset: 0x00202024
		public unsafe FVector CurWeaponPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_CurWeaponPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_CurWeaponPos) = value;
			}
		}

		// Token: 0x1700578B RID: 22411
		// (get) Token: 0x06015FF2 RID: 90098 RVA: 0x00203E39 File Offset: 0x00202039
		// (set) Token: 0x06015FF3 RID: 90099 RVA: 0x00203E4D File Offset: 0x0020204D
		public unsafe FVector LastWeaponPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_LastWeaponPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_LastWeaponPos) = value;
			}
		}

		// Token: 0x1700578C RID: 22412
		// (get) Token: 0x06015FF4 RID: 90100 RVA: 0x00203E62 File Offset: 0x00202062
		// (set) Token: 0x06015FF5 RID: 90101 RVA: 0x00203E72 File Offset: 0x00202072
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x1700578D RID: 22413
		// (get) Token: 0x06015FF6 RID: 90102 RVA: 0x00203E83 File Offset: 0x00202083
		// (set) Token: 0x06015FF7 RID: 90103 RVA: 0x00203E93 File Offset: 0x00202093
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x1700578E RID: 22414
		// (get) Token: 0x06015FF8 RID: 90104 RVA: 0x00203EA4 File Offset: 0x002020A4
		// (set) Token: 0x06015FF9 RID: 90105 RVA: 0x00203EB4 File Offset: 0x002020B4
		public unsafe bool bEnableBeginPlayLogs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableBeginPlayLogs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableBeginPlayLogs) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700578F RID: 22415
		// (get) Token: 0x06015FFA RID: 90106 RVA: 0x00203EC5 File Offset: 0x002020C5
		// (set) Token: 0x06015FFB RID: 90107 RVA: 0x00203ED5 File Offset: 0x002020D5
		public unsafe bool bDrawGpuProxyDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bDrawGpuProxyDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bDrawGpuProxyDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005790 RID: 22416
		// (get) Token: 0x06015FFC RID: 90108 RVA: 0x00203EE6 File Offset: 0x002020E6
		// (set) Token: 0x06015FFD RID: 90109 RVA: 0x00203EF6 File Offset: 0x002020F6
		public unsafe float GpuProxyDebugPointSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_GpuProxyDebugPointSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_GpuProxyDebugPointSize) = value;
			}
		}

		// Token: 0x17005791 RID: 22417
		// (get) Token: 0x06015FFE RID: 90110 RVA: 0x00203F07 File Offset: 0x00202107
		// (set) Token: 0x06015FFF RID: 90111 RVA: 0x00203F17 File Offset: 0x00202117
		public unsafe float GpuProxyDebugLineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_GpuProxyDebugLineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_GpuProxyDebugLineThickness) = value;
			}
		}

		// Token: 0x17005792 RID: 22418
		// (get) Token: 0x06016000 RID: 90112 RVA: 0x00203F28 File Offset: 0x00202128
		// (set) Token: 0x06016001 RID: 90113 RVA: 0x00203F38 File Offset: 0x00202138
		public unsafe bool bEnableGravityPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableGravityPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableGravityPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005793 RID: 22419
		// (get) Token: 0x06016002 RID: 90114 RVA: 0x00203F49 File Offset: 0x00202149
		// (set) Token: 0x06016003 RID: 90115 RVA: 0x00203F59 File Offset: 0x00202159
		public unsafe bool bEnableWeaponPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableWeaponPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableWeaponPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005794 RID: 22420
		// (get) Token: 0x06016004 RID: 90116 RVA: 0x00203F6A File Offset: 0x0020216A
		// (set) Token: 0x06016005 RID: 90117 RVA: 0x00203F7A File Offset: 0x0020217A
		public unsafe bool bEnableDistancePass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableDistancePass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableDistancePass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005795 RID: 22421
		// (get) Token: 0x06016006 RID: 90118 RVA: 0x00203F8B File Offset: 0x0020218B
		// (set) Token: 0x06016007 RID: 90119 RVA: 0x00203F9B File Offset: 0x0020219B
		public unsafe bool bEnableBendingPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableBendingPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableBendingPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005796 RID: 22422
		// (get) Token: 0x06016008 RID: 90120 RVA: 0x00203FAC File Offset: 0x002021AC
		// (set) Token: 0x06016009 RID: 90121 RVA: 0x00203FBC File Offset: 0x002021BC
		public unsafe bool bEnableCollisionPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableCollisionPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableCollisionPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005797 RID: 22423
		// (get) Token: 0x0601600A RID: 90122 RVA: 0x00203FCD File Offset: 0x002021CD
		// (set) Token: 0x0601600B RID: 90123 RVA: 0x00203FDD File Offset: 0x002021DD
		public unsafe bool bEnableVolPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableVolPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableVolPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005798 RID: 22424
		// (get) Token: 0x0601600C RID: 90124 RVA: 0x00203FEE File Offset: 0x002021EE
		// (set) Token: 0x0601600D RID: 90125 RVA: 0x00203FFE File Offset: 0x002021FE
		public unsafe bool bCollectPerformanceDiagnostics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bCollectPerformanceDiagnostics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bCollectPerformanceDiagnostics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005799 RID: 22425
		// (get) Token: 0x0601600E RID: 90126 RVA: 0x0020400F File Offset: 0x0020220F
		// (set) Token: 0x0601600F RID: 90127 RVA: 0x0020401F File Offset: 0x0020221F
		public unsafe bool bEnableGpuTimestampQueries
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableGpuTimestampQueries) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableGpuTimestampQueries) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700579A RID: 22426
		// (get) Token: 0x06016010 RID: 90128 RVA: 0x00204030 File Offset: 0x00202230
		// (set) Token: 0x06016011 RID: 90129 RVA: 0x00204040 File Offset: 0x00202240
		public unsafe bool bDrawPerformancePanel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bDrawPerformancePanel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bDrawPerformancePanel) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700579B RID: 22427
		// (get) Token: 0x06016012 RID: 90130 RVA: 0x00204051 File Offset: 0x00202251
		// (set) Token: 0x06016013 RID: 90131 RVA: 0x00204061 File Offset: 0x00202261
		public unsafe bool bLogPerformanceSummary
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bLogPerformanceSummary) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bLogPerformanceSummary) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700579C RID: 22428
		// (get) Token: 0x06016014 RID: 90132 RVA: 0x00204072 File Offset: 0x00202272
		// (set) Token: 0x06016015 RID: 90133 RVA: 0x00204082 File Offset: 0x00202282
		public unsafe float PerformancePanelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelScale) = value;
			}
		}

		// Token: 0x1700579D RID: 22429
		// (get) Token: 0x06016016 RID: 90134 RVA: 0x00204093 File Offset: 0x00202293
		// (set) Token: 0x06016017 RID: 90135 RVA: 0x002040A3 File Offset: 0x002022A3
		public unsafe float PerformancePanelTextScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelTextScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelTextScale) = value;
			}
		}

		// Token: 0x1700579E RID: 22430
		// (get) Token: 0x06016018 RID: 90136 RVA: 0x002040B4 File Offset: 0x002022B4
		// (set) Token: 0x06016019 RID: 90137 RVA: 0x002040C4 File Offset: 0x002022C4
		public unsafe float PerformancePanelBackgroundOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelBackgroundOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelBackgroundOpacity) = value;
			}
		}

		// Token: 0x1700579F RID: 22431
		// (get) Token: 0x0601601A RID: 90138 RVA: 0x002040D5 File Offset: 0x002022D5
		// (set) Token: 0x0601601B RID: 90139 RVA: 0x002040E5 File Offset: 0x002022E5
		public unsafe int PerformancePanelMaxLegendEntries
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelMaxLegendEntries);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PerformancePanelMaxLegendEntries) = value;
			}
		}

		// Token: 0x170057A0 RID: 22432
		// (get) Token: 0x0601601C RID: 90140 RVA: 0x002040F6 File Offset: 0x002022F6
		// (set) Token: 0x0601601D RID: 90141 RVA: 0x00204106 File Offset: 0x00202306
		public unsafe int BendingConstraintCountBuilt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BendingConstraintCountBuilt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BendingConstraintCountBuilt) = value;
			}
		}

		// Token: 0x170057A1 RID: 22433
		// (get) Token: 0x0601601E RID: 90142 RVA: 0x00204117 File Offset: 0x00202317
		// (set) Token: 0x0601601F RID: 90143 RVA: 0x00204127 File Offset: 0x00202327
		public unsafe float PlayerCapsuleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerCapsuleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerCapsuleRadius) = value;
			}
		}

		// Token: 0x170057A2 RID: 22434
		// (get) Token: 0x06016020 RID: 90144 RVA: 0x00204138 File Offset: 0x00202338
		// (set) Token: 0x06016021 RID: 90145 RVA: 0x00204148 File Offset: 0x00202348
		public unsafe float PlayerCapsuleHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerCapsuleHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerCapsuleHeight) = value;
			}
		}

		// Token: 0x170057A3 RID: 22435
		// (get) Token: 0x06016022 RID: 90146 RVA: 0x00204159 File Offset: 0x00202359
		// (set) Token: 0x06016023 RID: 90147 RVA: 0x00204169 File Offset: 0x00202369
		public unsafe float PlayerCapsuleSkin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerCapsuleSkin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerCapsuleSkin) = value;
			}
		}

		// Token: 0x170057A4 RID: 22436
		// (get) Token: 0x06016024 RID: 90148 RVA: 0x0020417A File Offset: 0x0020237A
		// (set) Token: 0x06016025 RID: 90149 RVA: 0x0020418A File Offset: 0x0020238A
		public unsafe float PlayerFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_PlayerFriction) = value;
			}
		}

		// Token: 0x170057A5 RID: 22437
		// (get) Token: 0x06016026 RID: 90150 RVA: 0x0020419B File Offset: 0x0020239B
		// (set) Token: 0x06016027 RID: 90151 RVA: 0x002041AB File Offset: 0x002023AB
		public unsafe int deadNodeHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_deadNodeHold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_deadNodeHold) = value;
			}
		}

		// Token: 0x170057A6 RID: 22438
		// (get) Token: 0x06016028 RID: 90152 RVA: 0x002041BC File Offset: 0x002023BC
		// (set) Token: 0x06016029 RID: 90153 RVA: 0x002041CC File Offset: 0x002023CC
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x170057A7 RID: 22439
		// (get) Token: 0x0601602A RID: 90154 RVA: 0x002041DD File Offset: 0x002023DD
		// (set) Token: 0x0601602B RID: 90155 RVA: 0x002041ED File Offset: 0x002023ED
		public unsafe bool bWilsonWindEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bWilsonWindEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bWilsonWindEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057A8 RID: 22440
		// (get) Token: 0x0601602C RID: 90156 RVA: 0x002041FE File Offset: 0x002023FE
		// (set) Token: 0x0601602D RID: 90157 RVA: 0x00204212 File Offset: 0x00202412
		public unsafe FVector WilsonWindDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WilsonWindDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WilsonWindDir) = value;
			}
		}

		// Token: 0x170057A9 RID: 22441
		// (get) Token: 0x0601602E RID: 90158 RVA: 0x00204227 File Offset: 0x00202427
		// (set) Token: 0x0601602F RID: 90159 RVA: 0x00204237 File Offset: 0x00202437
		public unsafe bool bUseGlobalWilsonWindDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bUseGlobalWilsonWindDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bUseGlobalWilsonWindDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057AA RID: 22442
		// (get) Token: 0x06016030 RID: 90160 RVA: 0x00204248 File Offset: 0x00202448
		// (set) Token: 0x06016031 RID: 90161 RVA: 0x00204258 File Offset: 0x00202458
		public unsafe float WilsonWindStrengthScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WilsonWindStrengthScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WilsonWindStrengthScale) = value;
			}
		}

		// Token: 0x170057AB RID: 22443
		// (get) Token: 0x06016032 RID: 90162 RVA: 0x00204269 File Offset: 0x00202469
		// (set) Token: 0x06016033 RID: 90163 RVA: 0x00204279 File Offset: 0x00202479
		public unsafe bool bWindFieldEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bWindFieldEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bWindFieldEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057AC RID: 22444
		// (get) Token: 0x06016034 RID: 90164 RVA: 0x0020428A File Offset: 0x0020248A
		// (set) Token: 0x06016035 RID: 90165 RVA: 0x0020429E File Offset: 0x0020249E
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D WindField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_WindField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSJacobiCloth.__PropertyOffset_WindField, value);
			}
		}

		// Token: 0x170057AD RID: 22445
		// (get) Token: 0x06016036 RID: 90166 RVA: 0x002042B3 File Offset: 0x002024B3
		// (set) Token: 0x06016037 RID: 90167 RVA: 0x002042C7 File Offset: 0x002024C7
		public unsafe FVector WindFieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WindFieldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WindFieldSize) = value;
			}
		}

		// Token: 0x170057AE RID: 22446
		// (get) Token: 0x06016038 RID: 90168 RVA: 0x002042DC File Offset: 0x002024DC
		// (set) Token: 0x06016039 RID: 90169 RVA: 0x002042EC File Offset: 0x002024EC
		public unsafe float BottomWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BottomWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BottomWindStrength) = value;
			}
		}

		// Token: 0x170057AF RID: 22447
		// (get) Token: 0x0601603A RID: 90170 RVA: 0x002042FD File Offset: 0x002024FD
		// (set) Token: 0x0601603B RID: 90171 RVA: 0x0020430D File Offset: 0x0020250D
		public unsafe float TopWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_TopWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_TopWindStrength) = value;
			}
		}

		// Token: 0x170057B0 RID: 22448
		// (get) Token: 0x0601603C RID: 90172 RVA: 0x0020431E File Offset: 0x0020251E
		// (set) Token: 0x0601603D RID: 90173 RVA: 0x0020432E File Offset: 0x0020252E
		public unsafe float WindFieldMaxStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WindFieldMaxStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_WindFieldMaxStrength) = value;
			}
		}

		// Token: 0x170057B1 RID: 22449
		// (get) Token: 0x0601603E RID: 90174 RVA: 0x0020433F File Offset: 0x0020253F
		// (set) Token: 0x0601603F RID: 90175 RVA: 0x0020434F File Offset: 0x0020254F
		public unsafe bool bEnableSDFCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableSDFCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bEnableSDFCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057B2 RID: 22450
		// (get) Token: 0x06016040 RID: 90176 RVA: 0x00204360 File Offset: 0x00202560
		// (set) Token: 0x06016041 RID: 90177 RVA: 0x00204370 File Offset: 0x00202570
		public unsafe float SDFMinSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFMinSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFMinSafeDistance) = value;
			}
		}

		// Token: 0x170057B3 RID: 22451
		// (get) Token: 0x06016042 RID: 90178 RVA: 0x00204381 File Offset: 0x00202581
		// (set) Token: 0x06016043 RID: 90179 RVA: 0x00204391 File Offset: 0x00202591
		public unsafe float SDFDynamicSafeDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFDynamicSafeDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFDynamicSafeDistanceFactor) = value;
			}
		}

		// Token: 0x170057B4 RID: 22452
		// (get) Token: 0x06016044 RID: 90180 RVA: 0x002043A2 File Offset: 0x002025A2
		// (set) Token: 0x06016045 RID: 90181 RVA: 0x002043B2 File Offset: 0x002025B2
		public unsafe float SDFCorrectionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFCorrectionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFCorrectionStiffness) = value;
			}
		}

		// Token: 0x170057B5 RID: 22453
		// (get) Token: 0x06016046 RID: 90182 RVA: 0x002043C3 File Offset: 0x002025C3
		// (set) Token: 0x06016047 RID: 90183 RVA: 0x002043D3 File Offset: 0x002025D3
		public unsafe float SDFMaxCorrectionPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFMaxCorrectionPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFMaxCorrectionPerFrame) = value;
			}
		}

		// Token: 0x170057B6 RID: 22454
		// (get) Token: 0x06016048 RID: 90184 RVA: 0x002043E4 File Offset: 0x002025E4
		// (set) Token: 0x06016049 RID: 90185 RVA: 0x002043F4 File Offset: 0x002025F4
		public unsafe float SDFPlayerActivationDistanceMeters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFPlayerActivationDistanceMeters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFPlayerActivationDistanceMeters) = value;
			}
		}

		// Token: 0x170057B7 RID: 22455
		// (get) Token: 0x0601604A RID: 90186 RVA: 0x00204405 File Offset: 0x00202605
		// (set) Token: 0x0601604B RID: 90187 RVA: 0x00204415 File Offset: 0x00202615
		public unsafe float SDFFadeDurationSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFFadeDurationSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_SDFFadeDurationSeconds) = value;
			}
		}

		// Token: 0x170057B8 RID: 22456
		// (get) Token: 0x0601604C RID: 90188 RVA: 0x00204428 File Offset: 0x00202628
		// (set) Token: 0x0601604D RID: 90189 RVA: 0x00204461 File Offset: 0x00202661
		public TArray<AStaticMeshActor> ManagedSourceActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._ManagedSourceActors) == null)
				{
					result = (this._ManagedSourceActors = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_ManagedSourceActors, this));
				}
				return result;
			}
			set
			{
				this.ManagedSourceActors.CopyAssign(value);
			}
		}

		// Token: 0x170057B9 RID: 22457
		// (get) Token: 0x0601604E RID: 90190 RVA: 0x00204470 File Offset: 0x00202670
		// (set) Token: 0x0601604F RID: 90191 RVA: 0x002044A9 File Offset: 0x002026A9
		public TArray<UStaticMeshComponent> ManagedSourceComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._ManagedSourceComponents) == null)
				{
					result = (this._ManagedSourceComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_ManagedSourceComponents, this));
				}
				return result;
			}
			set
			{
				this.ManagedSourceComponents.CopyAssign(value);
			}
		}

		// Token: 0x170057BA RID: 22458
		// (get) Token: 0x06016050 RID: 90192 RVA: 0x002044B8 File Offset: 0x002026B8
		// (set) Token: 0x06016051 RID: 90193 RVA: 0x002044F1 File Offset: 0x002026F1
		public TArray<FKuroCSClothInstance_jacobiCloth> ClothInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSClothInstance_jacobiCloth> result;
				if ((result = this._ClothInstances) == null)
				{
					result = (this._ClothInstances = new TArray<FKuroCSClothInstance_jacobiCloth>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_ClothInstances, this));
				}
				return result;
			}
			set
			{
				this.ClothInstances.CopyAssign(value);
			}
		}

		// Token: 0x170057BB RID: 22459
		// (get) Token: 0x06016052 RID: 90194 RVA: 0x002044FF File Offset: 0x002026FF
		// (set) Token: 0x06016053 RID: 90195 RVA: 0x0020450F File Offset: 0x0020270F
		public unsafe bool bAutoBuildBatchOnConstruction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bAutoBuildBatchOnConstruction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bAutoBuildBatchOnConstruction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057BC RID: 22460
		// (get) Token: 0x06016054 RID: 90196 RVA: 0x00204520 File Offset: 0x00202720
		// (set) Token: 0x06016055 RID: 90197 RVA: 0x00204530 File Offset: 0x00202730
		public unsafe bool bIncludeHiddenSourceMeshes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bIncludeHiddenSourceMeshes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bIncludeHiddenSourceMeshes) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057BD RID: 22461
		// (get) Token: 0x06016056 RID: 90198 RVA: 0x00204541 File Offset: 0x00202741
		// (set) Token: 0x06016057 RID: 90199 RVA: 0x00204551 File Offset: 0x00202751
		public unsafe EKuroCSJacobiClothBakeState BakeState
		{
			get
			{
				return (EKuroCSJacobiClothBakeState)(*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakeState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakeState) = (byte)value;
			}
		}

		// Token: 0x170057BE RID: 22462
		// (get) Token: 0x06016058 RID: 90200 RVA: 0x00204562 File Offset: 0x00202762
		// (set) Token: 0x06016059 RID: 90201 RVA: 0x00204572 File Offset: 0x00202772
		public unsafe int BakedSourceActorCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSourceActorCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSourceActorCount) = value;
			}
		}

		// Token: 0x170057BF RID: 22463
		// (get) Token: 0x0601605A RID: 90202 RVA: 0x00204583 File Offset: 0x00202783
		// (set) Token: 0x0601605B RID: 90203 RVA: 0x00204593 File Offset: 0x00202793
		public unsafe int BakedUnmatchedMeshCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedUnmatchedMeshCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedUnmatchedMeshCount) = value;
			}
		}

		// Token: 0x170057C0 RID: 22464
		// (get) Token: 0x0601605C RID: 90204 RVA: 0x002045A4 File Offset: 0x002027A4
		// (set) Token: 0x0601605D RID: 90205 RVA: 0x002045B4 File Offset: 0x002027B4
		public unsafe bool bUseEditorBakedBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bUseEditorBakedBatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bUseEditorBakedBatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057C1 RID: 22465
		// (get) Token: 0x0601605E RID: 90206 RVA: 0x002045C5 File Offset: 0x002027C5
		// (set) Token: 0x0601605F RID: 90207 RVA: 0x002045D5 File Offset: 0x002027D5
		public unsafe bool bHasEditorBakedBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bHasEditorBakedBatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_bHasEditorBakedBatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057C2 RID: 22466
		// (get) Token: 0x06016060 RID: 90208 RVA: 0x002045E6 File Offset: 0x002027E6
		// (set) Token: 0x06016061 RID: 90209 RVA: 0x002045F6 File Offset: 0x002027F6
		public unsafe int BakedParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedParticleCount) = value;
			}
		}

		// Token: 0x170057C3 RID: 22467
		// (get) Token: 0x06016062 RID: 90210 RVA: 0x00204607 File Offset: 0x00202807
		// (set) Token: 0x06016063 RID: 90211 RVA: 0x00204617 File Offset: 0x00202817
		public unsafe int BakedClothCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedClothCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedClothCount) = value;
			}
		}

		// Token: 0x170057C4 RID: 22468
		// (get) Token: 0x06016064 RID: 90212 RVA: 0x00204628 File Offset: 0x00202828
		// (set) Token: 0x06016065 RID: 90213 RVA: 0x00204638 File Offset: 0x00202838
		public unsafe int BakedBendingConstraintCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedBendingConstraintCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedBendingConstraintCount) = value;
			}
		}

		// Token: 0x170057C5 RID: 22469
		// (get) Token: 0x06016066 RID: 90214 RVA: 0x00204649 File Offset: 0x00202849
		// (set) Token: 0x06016067 RID: 90215 RVA: 0x00204659 File Offset: 0x00202859
		public unsafe int BakedSchemaVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSchemaVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSchemaVersion) = value;
			}
		}

		// Token: 0x170057C6 RID: 22470
		// (get) Token: 0x06016068 RID: 90216 RVA: 0x0020466A File Offset: 0x0020286A
		// (set) Token: 0x06016069 RID: 90217 RVA: 0x0020467E File Offset: 0x0020287E
		public unsafe string BakedInputFingerprint
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedInputFingerprint)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedInputFingerprint)), value);
			}
		}

		// Token: 0x170057C7 RID: 22471
		// (get) Token: 0x0601606A RID: 90218 RVA: 0x00204694 File Offset: 0x00202894
		// (set) Token: 0x0601606B RID: 90219 RVA: 0x002046CD File Offset: 0x002028CD
		public TArray<FKuroCSParticle_jacobiCloth> BakedParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_jacobiCloth> result;
				if ((result = this._BakedParticlesArr) == null)
				{
					result = (this._BakedParticlesArr = new TArray<FKuroCSParticle_jacobiCloth>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.BakedParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x170057C8 RID: 22472
		// (get) Token: 0x0601606C RID: 90220 RVA: 0x002046DC File Offset: 0x002028DC
		// (set) Token: 0x0601606D RID: 90221 RVA: 0x00204715 File Offset: 0x00202915
		public TArray<FKuroCSJacobiClothBakedInstance> BakedClothInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSJacobiClothBakedInstance> result;
				if ((result = this._BakedClothInstances) == null)
				{
					result = (this._BakedClothInstances = new TArray<FKuroCSJacobiClothBakedInstance>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedClothInstances, this));
				}
				return result;
			}
			set
			{
				this.BakedClothInstances.CopyAssign(value);
			}
		}

		// Token: 0x170057C9 RID: 22473
		// (get) Token: 0x0601606E RID: 90222 RVA: 0x00204724 File Offset: 0x00202924
		// (set) Token: 0x0601606F RID: 90223 RVA: 0x0020475D File Offset: 0x0020295D
		public TArray<FKuroCSJacobiClothBakedBendingConstraint> BakedBendingConstraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSJacobiClothBakedBendingConstraint> result;
				if ((result = this._BakedBendingConstraints) == null)
				{
					result = (this._BakedBendingConstraints = new TArray<FKuroCSJacobiClothBakedBendingConstraint>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedBendingConstraints, this));
				}
				return result;
			}
			set
			{
				this.BakedBendingConstraints.CopyAssign(value);
			}
		}

		// Token: 0x170057CA RID: 22474
		// (get) Token: 0x06016070 RID: 90224 RVA: 0x0020476C File Offset: 0x0020296C
		// (set) Token: 0x06016071 RID: 90225 RVA: 0x002047A5 File Offset: 0x002029A5
		public TArray<FKuroCSJacobiClothBakedRenderSource> BakedRenderSources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSJacobiClothBakedRenderSource> result;
				if ((result = this._BakedRenderSources) == null)
				{
					result = (this._BakedRenderSources = new TArray<FKuroCSJacobiClothBakedRenderSource>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedRenderSources, this));
				}
				return result;
			}
			set
			{
				this.BakedRenderSources.CopyAssign(value);
			}
		}

		// Token: 0x170057CB RID: 22475
		// (get) Token: 0x06016072 RID: 90226 RVA: 0x002047B4 File Offset: 0x002029B4
		// (set) Token: 0x06016073 RID: 90227 RVA: 0x002047ED File Offset: 0x002029ED
		public TArray<UStaticMeshComponent> BakedSourceComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._BakedSourceComponents) == null)
				{
					result = (this._BakedSourceComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSourceComponents, this));
				}
				return result;
			}
			set
			{
				this.BakedSourceComponents.CopyAssign(value);
			}
		}

		// Token: 0x170057CC RID: 22476
		// (get) Token: 0x06016074 RID: 90228 RVA: 0x002047FC File Offset: 0x002029FC
		// (set) Token: 0x06016075 RID: 90229 RVA: 0x00204835 File Offset: 0x00202A35
		public TArray<int> BakedBendingColorStart
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BakedBendingColorStart) == null)
				{
					result = (this._BakedBendingColorStart = new TArray<int>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedBendingColorStart, this));
				}
				return result;
			}
			set
			{
				this.BakedBendingColorStart.CopyAssign(value);
			}
		}

		// Token: 0x170057CD RID: 22477
		// (get) Token: 0x06016076 RID: 90230 RVA: 0x00204844 File Offset: 0x00202A44
		// (set) Token: 0x06016077 RID: 90231 RVA: 0x0020487D File Offset: 0x00202A7D
		public TArray<FKuroCSParticleTopologyRange_jacobiCloth> BakedParticleTopologyRanges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticleTopologyRange_jacobiCloth> result;
				if ((result = this._BakedParticleTopologyRanges) == null)
				{
					result = (this._BakedParticleTopologyRanges = new TArray<FKuroCSParticleTopologyRange_jacobiCloth>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedParticleTopologyRanges, this));
				}
				return result;
			}
			set
			{
				this.BakedParticleTopologyRanges.CopyAssign(value);
			}
		}

		// Token: 0x170057CE RID: 22478
		// (get) Token: 0x06016078 RID: 90232 RVA: 0x0020488C File Offset: 0x00202A8C
		// (set) Token: 0x06016079 RID: 90233 RVA: 0x002048C5 File Offset: 0x00202AC5
		public TArray<FKuroCSDistanceAdjacency_jacobiCloth> BakedDistanceAdjacency
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSDistanceAdjacency_jacobiCloth> result;
				if ((result = this._BakedDistanceAdjacency) == null)
				{
					result = (this._BakedDistanceAdjacency = new TArray<FKuroCSDistanceAdjacency_jacobiCloth>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedDistanceAdjacency, this));
				}
				return result;
			}
			set
			{
				this.BakedDistanceAdjacency.CopyAssign(value);
			}
		}

		// Token: 0x170057CF RID: 22479
		// (get) Token: 0x0601607A RID: 90234 RVA: 0x002048D4 File Offset: 0x00202AD4
		// (set) Token: 0x0601607B RID: 90235 RVA: 0x0020490D File Offset: 0x00202B0D
		public TArray<FKuroCSTriangleAdjacency_jacobiCloth> BakedTriangleAdjacency
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSTriangleAdjacency_jacobiCloth> result;
				if ((result = this._BakedTriangleAdjacency) == null)
				{
					result = (this._BakedTriangleAdjacency = new TArray<FKuroCSTriangleAdjacency_jacobiCloth>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedTriangleAdjacency, this));
				}
				return result;
			}
			set
			{
				this.BakedTriangleAdjacency.CopyAssign(value);
			}
		}

		// Token: 0x170057D0 RID: 22480
		// (get) Token: 0x0601607C RID: 90236 RVA: 0x0020491C File Offset: 0x00202B1C
		// (set) Token: 0x0601607D RID: 90237 RVA: 0x00204955 File Offset: 0x00202B55
		public TArray<FKuroCSUnifiedCollider_jacobiCloth> BakedColliders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_jacobiCloth> result;
				if ((result = this._BakedColliders) == null)
				{
					result = (this._BakedColliders = new TArray<FKuroCSUnifiedCollider_jacobiCloth>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedColliders, this));
				}
				return result;
			}
			set
			{
				this.BakedColliders.CopyAssign(value);
			}
		}

		// Token: 0x170057D1 RID: 22481
		// (get) Token: 0x0601607E RID: 90238 RVA: 0x00204964 File Offset: 0x00202B64
		// (set) Token: 0x0601607F RID: 90239 RVA: 0x0020499D File Offset: 0x00202B9D
		public TArray<byte> BakedSimulationCompressedData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._BakedSimulationCompressedData) == null)
				{
					result = (this._BakedSimulationCompressedData = new TArray<byte>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSimulationCompressedData, this));
				}
				return result;
			}
			set
			{
				this.BakedSimulationCompressedData.CopyAssign(value);
			}
		}

		// Token: 0x170057D2 RID: 22482
		// (get) Token: 0x06016080 RID: 90240 RVA: 0x002049AB File Offset: 0x00202BAB
		// (set) Token: 0x06016081 RID: 90241 RVA: 0x002049BB File Offset: 0x00202BBB
		public unsafe int BakedSimulationUncompressedBytes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSimulationUncompressedBytes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSimulationUncompressedBytes) = value;
			}
		}

		// Token: 0x170057D3 RID: 22483
		// (get) Token: 0x06016082 RID: 90242 RVA: 0x002049CC File Offset: 0x00202BCC
		// (set) Token: 0x06016083 RID: 90243 RVA: 0x002049DC File Offset: 0x00202BDC
		public unsafe uint BakedSimulationPayloadCrc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSimulationPayloadCrc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedSimulationPayloadCrc) = (int)value;
			}
		}

		// Token: 0x170057D4 RID: 22484
		// (get) Token: 0x06016084 RID: 90244 RVA: 0x002049F0 File Offset: 0x00202BF0
		// (set) Token: 0x06016085 RID: 90245 RVA: 0x00204A29 File Offset: 0x00202C29
		public TArray<byte> BakedRenderPackedData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._BakedRenderPackedData) == null)
				{
					result = (this._BakedRenderPackedData = new TArray<byte>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedRenderPackedData, this));
				}
				return result;
			}
			set
			{
				this.BakedRenderPackedData.CopyAssign(value);
			}
		}

		// Token: 0x170057D5 RID: 22485
		// (get) Token: 0x06016086 RID: 90246 RVA: 0x00204A37 File Offset: 0x00202C37
		// (set) Token: 0x06016087 RID: 90247 RVA: 0x00204A47 File Offset: 0x00202C47
		public unsafe int BakedRenderVertexCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedRenderVertexCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_BakedRenderVertexCount) = value;
			}
		}

		// Token: 0x170057D6 RID: 22486
		// (get) Token: 0x06016088 RID: 90248 RVA: 0x00204A58 File Offset: 0x00202C58
		// (set) Token: 0x06016089 RID: 90249 RVA: 0x00204A91 File Offset: 0x00202C91
		public TArray<UStaticMeshComponent> RuntimeStaticFallbackComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._RuntimeStaticFallbackComponents) == null)
				{
					result = (this._RuntimeStaticFallbackComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)AKuroCSJacobiCloth.__PropertyOffset_RuntimeStaticFallbackComponents, this));
				}
				return result;
			}
			set
			{
				this.RuntimeStaticFallbackComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601608A RID: 90250 RVA: 0x00204A9F File Offset: 0x00202C9F
		public void StopSimulation()
		{
			AKuroCSJacobiCloth.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x0601608B RID: 90251 RVA: 0x00204AAC File Offset: 0x00202CAC
		public void StartSimulation()
		{
			AKuroCSJacobiCloth.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x0601608C RID: 90252 RVA: 0x00204AB9 File Offset: 0x00202CB9
		public void SetFaDEOUT(float InFadeOut)
		{
			AKuroCSJacobiCloth.__SetFaDEOUT_Internal(base.NativePtr, InFadeOut);
		}

		// Token: 0x0601608D RID: 90253 RVA: 0x00204AC7 File Offset: 0x00202CC7
		public void RemoveBakedCopies()
		{
			AKuroCSJacobiCloth.__RemoveBakedCopies_Internal(base.NativePtr);
		}

		// Token: 0x0601608E RID: 90254 RVA: 0x00204AD4 File Offset: 0x00202CD4
		public void ReleaseShaderManager()
		{
			AKuroCSJacobiCloth.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x0601608F RID: 90255 RVA: 0x00204AE1 File Offset: 0x00202CE1
		public void JacobiClothBeginPlay(EKuroCSJacobiClothRuntimeBackend SelectedRuntimeBackend)
		{
			AKuroCSJacobiCloth.__JacobiClothBeginPlay_Internal(base.NativePtr, SelectedRuntimeBackend);
		}

		// Token: 0x06016090 RID: 90256 RVA: 0x00204AEF File Offset: 0x00202CEF
		public bool IsGpuJacobiSupported()
		{
			return AKuroCSJacobiCloth.__IsGpuJacobiSupported_Internal(base.NativePtr);
		}

		// Token: 0x06016091 RID: 90257 RVA: 0x00204AFC File Offset: 0x00202CFC
		public void InitShaderManager()
		{
			AKuroCSJacobiCloth.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016092 RID: 90258 RVA: 0x00204B09 File Offset: 0x00202D09
		public bool HasValidBake()
		{
			return AKuroCSJacobiCloth.__HasValidBake_Internal(base.NativePtr);
		}

		// Token: 0x06016093 RID: 90259 RVA: 0x00204B16 File Offset: 0x00202D16
		public void Bake()
		{
			AKuroCSJacobiCloth.__Bake_Internal(base.NativePtr);
		}

		// Token: 0x06016094 RID: 90260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06016095 RID: 90261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06016096 RID: 90262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFaDEOUT_Internal(IntPtr @this, float InFadeOut);

		// Token: 0x06016097 RID: 90263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBakedCopies_Internal(IntPtr @this);

		// Token: 0x06016098 RID: 90264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06016099 RID: 90265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __JacobiClothBeginPlay_Internal(IntPtr @this, EKuroCSJacobiClothRuntimeBackend SelectedRuntimeBackend);

		// Token: 0x0601609A RID: 90266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGpuJacobiSupported_Internal(IntPtr @this);

		// Token: 0x0601609B RID: 90267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x0601609C RID: 90268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasValidBake_Internal(IntPtr @this);

		// Token: 0x0601609D RID: 90269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Bake_Internal(IntPtr @this);

		// Token: 0x0601609E RID: 90270 RVA: 0x00204B23 File Offset: 0x00202D23
		static AKuroCSJacobiCloth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSJacobiCloth");
		}

		// Token: 0x0601609F RID: 90271 RVA: 0x00204B31 File Offset: 0x00202D31
		protected AKuroCSJacobiCloth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BFAA RID: 49066
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSJacobiCloth";

		// Token: 0x0400BFAB RID: 49067
		private static IntPtr _ClassPtr;

		// Token: 0x0400BFAC RID: 49068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BFAD RID: 49069
		internal static int __PropertyOffset_Root;

		// Token: 0x0400BFAE RID: 49070
		internal static int __PropertyOffset_ManagementBounds;

		// Token: 0x0400BFAF RID: 49071
		internal static int __PropertyOffset_ClothDataAsset;

		// Token: 0x0400BFB0 RID: 49072
		internal static int __PropertyOffset_RuntimeBackend;

		// Token: 0x0400BFB1 RID: 49073
		internal static int __PropertyOffset_InitializationTimeBudgetMs;

		// Token: 0x0400BFB2 RID: 49074
		internal static int __PropertyOffset_bJacobiReady;

		// Token: 0x0400BFB3 RID: 49075
		internal static int __PropertyOffset_VertexFactoryRenderer;

		// Token: 0x0400BFB4 RID: 49076
		internal static int __PropertyOffset_bHideSourceStaticMeshes;

		// Token: 0x0400BFB5 RID: 49077
		internal static int __PropertyOffset_StaticFallbackCollisionProfile;

		// Token: 0x0400BFB6 RID: 49078
		[Nullable(2)]
		private FCollisionProfileName _StaticFallbackCollisionProfile;

		// Token: 0x0400BFB7 RID: 49079
		internal static int __PropertyOffset_StaticFallbackCollisionEnabled;

		// Token: 0x0400BFB8 RID: 49080
		internal static int __PropertyOffset_VertexFactoryMatchTolerance;

		// Token: 0x0400BFB9 RID: 49081
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400BFBA RID: 49082
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_jacobiCloth> _ParticlesArr;

		// Token: 0x0400BFBB RID: 49083
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BFBC RID: 49084
		internal static int __PropertyOffset_CurWeaponPos;

		// Token: 0x0400BFBD RID: 49085
		internal static int __PropertyOffset_LastWeaponPos;

		// Token: 0x0400BFBE RID: 49086
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BFBF RID: 49087
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BFC0 RID: 49088
		internal static int __PropertyOffset_bEnableBeginPlayLogs;

		// Token: 0x0400BFC1 RID: 49089
		internal static int __PropertyOffset_bDrawGpuProxyDebug;

		// Token: 0x0400BFC2 RID: 49090
		internal static int __PropertyOffset_GpuProxyDebugPointSize;

		// Token: 0x0400BFC3 RID: 49091
		internal static int __PropertyOffset_GpuProxyDebugLineThickness;

		// Token: 0x0400BFC4 RID: 49092
		internal static int __PropertyOffset_bEnableGravityPass;

		// Token: 0x0400BFC5 RID: 49093
		internal static int __PropertyOffset_bEnableWeaponPass;

		// Token: 0x0400BFC6 RID: 49094
		internal static int __PropertyOffset_bEnableDistancePass;

		// Token: 0x0400BFC7 RID: 49095
		internal static int __PropertyOffset_bEnableBendingPass;

		// Token: 0x0400BFC8 RID: 49096
		internal static int __PropertyOffset_bEnableCollisionPass;

		// Token: 0x0400BFC9 RID: 49097
		internal static int __PropertyOffset_bEnableVolPass;

		// Token: 0x0400BFCA RID: 49098
		internal static int __PropertyOffset_bCollectPerformanceDiagnostics;

		// Token: 0x0400BFCB RID: 49099
		internal static int __PropertyOffset_bEnableGpuTimestampQueries;

		// Token: 0x0400BFCC RID: 49100
		internal static int __PropertyOffset_bDrawPerformancePanel;

		// Token: 0x0400BFCD RID: 49101
		internal static int __PropertyOffset_bLogPerformanceSummary;

		// Token: 0x0400BFCE RID: 49102
		internal static int __PropertyOffset_PerformancePanelScale;

		// Token: 0x0400BFCF RID: 49103
		internal static int __PropertyOffset_PerformancePanelTextScale;

		// Token: 0x0400BFD0 RID: 49104
		internal static int __PropertyOffset_PerformancePanelBackgroundOpacity;

		// Token: 0x0400BFD1 RID: 49105
		internal static int __PropertyOffset_PerformancePanelMaxLegendEntries;

		// Token: 0x0400BFD2 RID: 49106
		internal static int __PropertyOffset_BendingConstraintCountBuilt;

		// Token: 0x0400BFD3 RID: 49107
		internal static int __PropertyOffset_PlayerCapsuleRadius;

		// Token: 0x0400BFD4 RID: 49108
		internal static int __PropertyOffset_PlayerCapsuleHeight;

		// Token: 0x0400BFD5 RID: 49109
		internal static int __PropertyOffset_PlayerCapsuleSkin;

		// Token: 0x0400BFD6 RID: 49110
		internal static int __PropertyOffset_PlayerFriction;

		// Token: 0x0400BFD7 RID: 49111
		internal static int __PropertyOffset_deadNodeHold;

		// Token: 0x0400BFD8 RID: 49112
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400BFD9 RID: 49113
		internal static int __PropertyOffset_bWilsonWindEnabled;

		// Token: 0x0400BFDA RID: 49114
		internal static int __PropertyOffset_WilsonWindDir;

		// Token: 0x0400BFDB RID: 49115
		internal static int __PropertyOffset_bUseGlobalWilsonWindDirection;

		// Token: 0x0400BFDC RID: 49116
		internal static int __PropertyOffset_WilsonWindStrengthScale;

		// Token: 0x0400BFDD RID: 49117
		internal static int __PropertyOffset_bWindFieldEnabled;

		// Token: 0x0400BFDE RID: 49118
		internal static int __PropertyOffset_WindField;

		// Token: 0x0400BFDF RID: 49119
		internal static int __PropertyOffset_WindFieldSize;

		// Token: 0x0400BFE0 RID: 49120
		internal static int __PropertyOffset_BottomWindStrength;

		// Token: 0x0400BFE1 RID: 49121
		internal static int __PropertyOffset_TopWindStrength;

		// Token: 0x0400BFE2 RID: 49122
		internal static int __PropertyOffset_WindFieldMaxStrength;

		// Token: 0x0400BFE3 RID: 49123
		internal static int __PropertyOffset_bEnableSDFCollision;

		// Token: 0x0400BFE4 RID: 49124
		internal static int __PropertyOffset_SDFMinSafeDistance;

		// Token: 0x0400BFE5 RID: 49125
		internal static int __PropertyOffset_SDFDynamicSafeDistanceFactor;

		// Token: 0x0400BFE6 RID: 49126
		internal static int __PropertyOffset_SDFCorrectionStiffness;

		// Token: 0x0400BFE7 RID: 49127
		internal static int __PropertyOffset_SDFMaxCorrectionPerFrame;

		// Token: 0x0400BFE8 RID: 49128
		internal static int __PropertyOffset_SDFPlayerActivationDistanceMeters;

		// Token: 0x0400BFE9 RID: 49129
		internal static int __PropertyOffset_SDFFadeDurationSeconds;

		// Token: 0x0400BFEA RID: 49130
		internal static int __PropertyOffset_ManagedSourceActors;

		// Token: 0x0400BFEB RID: 49131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _ManagedSourceActors;

		// Token: 0x0400BFEC RID: 49132
		internal static int __PropertyOffset_ManagedSourceComponents;

		// Token: 0x0400BFED RID: 49133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _ManagedSourceComponents;

		// Token: 0x0400BFEE RID: 49134
		internal static int __PropertyOffset_ClothInstances;

		// Token: 0x0400BFEF RID: 49135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSClothInstance_jacobiCloth> _ClothInstances;

		// Token: 0x0400BFF0 RID: 49136
		internal static int __PropertyOffset_bAutoBuildBatchOnConstruction;

		// Token: 0x0400BFF1 RID: 49137
		internal static int __PropertyOffset_bIncludeHiddenSourceMeshes;

		// Token: 0x0400BFF2 RID: 49138
		internal static int __PropertyOffset_BakeState;

		// Token: 0x0400BFF3 RID: 49139
		internal static int __PropertyOffset_BakedSourceActorCount;

		// Token: 0x0400BFF4 RID: 49140
		internal static int __PropertyOffset_BakedUnmatchedMeshCount;

		// Token: 0x0400BFF5 RID: 49141
		internal static int __PropertyOffset_bUseEditorBakedBatch;

		// Token: 0x0400BFF6 RID: 49142
		internal static int __PropertyOffset_bHasEditorBakedBatch;

		// Token: 0x0400BFF7 RID: 49143
		internal static int __PropertyOffset_BakedParticleCount;

		// Token: 0x0400BFF8 RID: 49144
		internal static int __PropertyOffset_BakedClothCount;

		// Token: 0x0400BFF9 RID: 49145
		internal static int __PropertyOffset_BakedBendingConstraintCount;

		// Token: 0x0400BFFA RID: 49146
		internal static int __PropertyOffset_BakedSchemaVersion;

		// Token: 0x0400BFFB RID: 49147
		internal static int __PropertyOffset_BakedInputFingerprint;

		// Token: 0x0400BFFC RID: 49148
		internal static int __PropertyOffset_BakedParticlesArr;

		// Token: 0x0400BFFD RID: 49149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_jacobiCloth> _BakedParticlesArr;

		// Token: 0x0400BFFE RID: 49150
		internal static int __PropertyOffset_BakedClothInstances;

		// Token: 0x0400BFFF RID: 49151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSJacobiClothBakedInstance> _BakedClothInstances;

		// Token: 0x0400C000 RID: 49152
		internal static int __PropertyOffset_BakedBendingConstraints;

		// Token: 0x0400C001 RID: 49153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSJacobiClothBakedBendingConstraint> _BakedBendingConstraints;

		// Token: 0x0400C002 RID: 49154
		internal static int __PropertyOffset_BakedRenderSources;

		// Token: 0x0400C003 RID: 49155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSJacobiClothBakedRenderSource> _BakedRenderSources;

		// Token: 0x0400C004 RID: 49156
		internal static int __PropertyOffset_BakedSourceComponents;

		// Token: 0x0400C005 RID: 49157
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _BakedSourceComponents;

		// Token: 0x0400C006 RID: 49158
		internal static int __PropertyOffset_BakedBendingColorStart;

		// Token: 0x0400C007 RID: 49159
		[Nullable(2)]
		private TArray<int> _BakedBendingColorStart;

		// Token: 0x0400C008 RID: 49160
		internal static int __PropertyOffset_BakedParticleTopologyRanges;

		// Token: 0x0400C009 RID: 49161
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticleTopologyRange_jacobiCloth> _BakedParticleTopologyRanges;

		// Token: 0x0400C00A RID: 49162
		internal static int __PropertyOffset_BakedDistanceAdjacency;

		// Token: 0x0400C00B RID: 49163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSDistanceAdjacency_jacobiCloth> _BakedDistanceAdjacency;

		// Token: 0x0400C00C RID: 49164
		internal static int __PropertyOffset_BakedTriangleAdjacency;

		// Token: 0x0400C00D RID: 49165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSTriangleAdjacency_jacobiCloth> _BakedTriangleAdjacency;

		// Token: 0x0400C00E RID: 49166
		internal static int __PropertyOffset_BakedColliders;

		// Token: 0x0400C00F RID: 49167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_jacobiCloth> _BakedColliders;

		// Token: 0x0400C010 RID: 49168
		internal static int __PropertyOffset_BakedSimulationCompressedData;

		// Token: 0x0400C011 RID: 49169
		[Nullable(2)]
		private TArray<byte> _BakedSimulationCompressedData;

		// Token: 0x0400C012 RID: 49170
		internal static int __PropertyOffset_BakedSimulationUncompressedBytes;

		// Token: 0x0400C013 RID: 49171
		internal static int __PropertyOffset_BakedSimulationPayloadCrc;

		// Token: 0x0400C014 RID: 49172
		internal static int __PropertyOffset_BakedRenderPackedData;

		// Token: 0x0400C015 RID: 49173
		[Nullable(2)]
		private TArray<byte> _BakedRenderPackedData;

		// Token: 0x0400C016 RID: 49174
		internal static int __PropertyOffset_BakedRenderVertexCount;

		// Token: 0x0400C017 RID: 49175
		internal static int __PropertyOffset_RuntimeStaticFallbackComponents;

		// Token: 0x0400C018 RID: 49176
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _RuntimeStaticFallbackComponents;
	}
}
