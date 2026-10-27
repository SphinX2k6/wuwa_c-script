using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001193 RID: 4499
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMeshComponent")]
	[UnrealStructLayout(2016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2016)]
	public class UStaticMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060108D6 RID: 67798 RVA: 0x00184E41 File Offset: 0x00183041
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticMeshComponent._ClassPtr;
		}

		// Token: 0x060108D7 RID: 67799 RVA: 0x00184E50 File Offset: 0x00183050
		public UStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060108D8 RID: 67800 RVA: 0x00184E78 File Offset: 0x00183078
		public UStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x060108D9 RID: 67801 RVA: 0x00184EAB File Offset: 0x001830AB
		// (set) Token: 0x060108DA RID: 67802 RVA: 0x00184EBB File Offset: 0x001830BB
		public unsafe int ForcedLodModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ForcedLodModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ForcedLodModel) = value;
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x060108DB RID: 67803 RVA: 0x00184ECC File Offset: 0x001830CC
		// (set) Token: 0x060108DC RID: 67804 RVA: 0x00184EDC File Offset: 0x001830DC
		public unsafe int PreviousLODLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_PreviousLODLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_PreviousLODLevel) = value;
			}
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x060108DD RID: 67805 RVA: 0x00184EED File Offset: 0x001830ED
		// (set) Token: 0x060108DE RID: 67806 RVA: 0x00184EFD File Offset: 0x001830FD
		public unsafe int MinLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_MinLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_MinLOD) = value;
			}
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x060108DF RID: 67807 RVA: 0x00184F0E File Offset: 0x0018310E
		// (set) Token: 0x060108E0 RID: 67808 RVA: 0x00184F1E File Offset: 0x0018311E
		public unsafe int SubDivisionStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_SubDivisionStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_SubDivisionStepSize) = value;
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x060108E1 RID: 67809 RVA: 0x00184F2F File Offset: 0x0018312F
		// (set) Token: 0x060108E2 RID: 67810 RVA: 0x00184F48 File Offset: 0x00183148
		public unsafe bool bOverrideScreenSizeCullRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideScreenSizeCullRatio) & UStaticMeshComponent.__PropertyMask_bOverrideScreenSizeCullRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideScreenSizeCullRatio) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideScreenSizeCullRatio) & ~UStaticMeshComponent.__PropertyMask_bOverrideScreenSizeCullRatio) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideScreenSizeCullRatio : 0));
			}
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x060108E3 RID: 67811 RVA: 0x00184F78 File Offset: 0x00183178
		// (set) Token: 0x060108E4 RID: 67812 RVA: 0x00184F88 File Offset: 0x00183188
		public unsafe float ScreenSizeCullRatioOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ScreenSizeCullRatioOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ScreenSizeCullRatioOverride) = value;
			}
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x060108E5 RID: 67813 RVA: 0x00184F99 File Offset: 0x00183199
		// (set) Token: 0x060108E6 RID: 67814 RVA: 0x00184FAD File Offset: 0x001831AD
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshComponent.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshComponent.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x060108E7 RID: 67815 RVA: 0x00184FC2 File Offset: 0x001831C2
		// (set) Token: 0x060108E8 RID: 67816 RVA: 0x00184FD6 File Offset: 0x001831D6
		public unsafe FBoxSphereBounds CachedVertexBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_CachedVertexBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_CachedVertexBounds) = value;
			}
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x060108E9 RID: 67817 RVA: 0x00184FEC File Offset: 0x001831EC
		// (set) Token: 0x060108EA RID: 67818 RVA: 0x00185025 File Offset: 0x00183225
		public TArray<FExtraMaterialInfo> ExtraMaterialInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExtraMaterialInfo> result;
				if ((result = this._ExtraMaterialInfos) == null)
				{
					result = (this._ExtraMaterialInfos = new TArray<FExtraMaterialInfo>(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_ExtraMaterialInfos, this));
				}
				return result;
			}
			set
			{
				this.ExtraMaterialInfos.CopyAssign(value);
			}
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x060108EB RID: 67819 RVA: 0x00185033 File Offset: 0x00183233
		// (set) Token: 0x060108EC RID: 67820 RVA: 0x00185047 File Offset: 0x00183247
		public unsafe FColor WireframeColorOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WireframeColorOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WireframeColorOverride) = value;
			}
		}

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x060108ED RID: 67821 RVA: 0x0018505C File Offset: 0x0018325C
		// (set) Token: 0x060108EE RID: 67822 RVA: 0x00185075 File Offset: 0x00183275
		public unsafe bool bEvaluateWorldPositionOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bEvaluateWorldPositionOffset) & UStaticMeshComponent.__PropertyMask_bEvaluateWorldPositionOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bEvaluateWorldPositionOffset) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bEvaluateWorldPositionOffset) & ~UStaticMeshComponent.__PropertyMask_bEvaluateWorldPositionOffset) | (value ? UStaticMeshComponent.__PropertyMask_bEvaluateWorldPositionOffset : 0));
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x060108EF RID: 67823 RVA: 0x001850A5 File Offset: 0x001832A5
		// (set) Token: 0x060108F0 RID: 67824 RVA: 0x001850BE File Offset: 0x001832BE
		public unsafe bool bDisableOpacityMicromap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisableOpacityMicromap) & UStaticMeshComponent.__PropertyMask_bDisableOpacityMicromap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisableOpacityMicromap) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisableOpacityMicromap) & ~UStaticMeshComponent.__PropertyMask_bDisableOpacityMicromap) | (value ? UStaticMeshComponent.__PropertyMask_bDisableOpacityMicromap : 0));
			}
		}

		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x060108F1 RID: 67825 RVA: 0x001850EE File Offset: 0x001832EE
		// (set) Token: 0x060108F2 RID: 67826 RVA: 0x00185107 File Offset: 0x00183307
		public unsafe bool bForceEnableOpacityMicromap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceEnableOpacityMicromap) & UStaticMeshComponent.__PropertyMask_bForceEnableOpacityMicromap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceEnableOpacityMicromap) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceEnableOpacityMicromap) & ~UStaticMeshComponent.__PropertyMask_bForceEnableOpacityMicromap) | (value ? UStaticMeshComponent.__PropertyMask_bForceEnableOpacityMicromap : 0));
			}
		}

		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x060108F3 RID: 67827 RVA: 0x00185137 File Offset: 0x00183337
		// (set) Token: 0x060108F4 RID: 67828 RVA: 0x00185150 File Offset: 0x00183350
		public unsafe bool bOverrideWireframeColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideWireframeColor) & UStaticMeshComponent.__PropertyMask_bOverrideWireframeColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideWireframeColor) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideWireframeColor) & ~UStaticMeshComponent.__PropertyMask_bOverrideWireframeColor) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideWireframeColor : 0));
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x060108F5 RID: 67829 RVA: 0x00185180 File Offset: 0x00183380
		// (set) Token: 0x060108F6 RID: 67830 RVA: 0x00185199 File Offset: 0x00183399
		public unsafe bool bOverrideMinLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideMinLOD) & UStaticMeshComponent.__PropertyMask_bOverrideMinLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideMinLOD) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideMinLOD) & ~UStaticMeshComponent.__PropertyMask_bOverrideMinLOD) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideMinLOD : 0));
			}
		}

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x060108F7 RID: 67831 RVA: 0x001851C9 File Offset: 0x001833C9
		// (set) Token: 0x060108F8 RID: 67832 RVA: 0x001851E2 File Offset: 0x001833E2
		public unsafe bool bOverrideNavigationExport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideNavigationExport) & UStaticMeshComponent.__PropertyMask_bOverrideNavigationExport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideNavigationExport) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideNavigationExport) & ~UStaticMeshComponent.__PropertyMask_bOverrideNavigationExport) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideNavigationExport : 0));
			}
		}

		// Token: 0x1700409F RID: 16543
		// (get) Token: 0x060108F9 RID: 67833 RVA: 0x00185212 File Offset: 0x00183412
		// (set) Token: 0x060108FA RID: 67834 RVA: 0x0018522B File Offset: 0x0018342B
		public unsafe bool bForceNavigationObstacle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceNavigationObstacle) & UStaticMeshComponent.__PropertyMask_bForceNavigationObstacle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceNavigationObstacle) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bForceNavigationObstacle) & ~UStaticMeshComponent.__PropertyMask_bForceNavigationObstacle) | (value ? UStaticMeshComponent.__PropertyMask_bForceNavigationObstacle : 0));
			}
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x060108FB RID: 67835 RVA: 0x0018525B File Offset: 0x0018345B
		// (set) Token: 0x060108FC RID: 67836 RVA: 0x00185274 File Offset: 0x00183474
		public unsafe bool bDisallowMeshPaintPerInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisallowMeshPaintPerInstance) & UStaticMeshComponent.__PropertyMask_bDisallowMeshPaintPerInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisallowMeshPaintPerInstance) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bDisallowMeshPaintPerInstance) & ~UStaticMeshComponent.__PropertyMask_bDisallowMeshPaintPerInstance) | (value ? UStaticMeshComponent.__PropertyMask_bDisallowMeshPaintPerInstance : 0));
			}
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x060108FD RID: 67837 RVA: 0x001852A4 File Offset: 0x001834A4
		// (set) Token: 0x060108FE RID: 67838 RVA: 0x001852BD File Offset: 0x001834BD
		public unsafe bool bIgnoreInstanceForTextureStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bIgnoreInstanceForTextureStreaming) & UStaticMeshComponent.__PropertyMask_bIgnoreInstanceForTextureStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bIgnoreInstanceForTextureStreaming) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bIgnoreInstanceForTextureStreaming) & ~UStaticMeshComponent.__PropertyMask_bIgnoreInstanceForTextureStreaming) | (value ? UStaticMeshComponent.__PropertyMask_bIgnoreInstanceForTextureStreaming : 0));
			}
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x060108FF RID: 67839 RVA: 0x001852ED File Offset: 0x001834ED
		// (set) Token: 0x06010900 RID: 67840 RVA: 0x00185306 File Offset: 0x00183506
		public unsafe bool bOverrideLightMapRes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideLightMapRes) & UStaticMeshComponent.__PropertyMask_bOverrideLightMapRes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideLightMapRes) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideLightMapRes) & ~UStaticMeshComponent.__PropertyMask_bOverrideLightMapRes) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideLightMapRes : 0));
			}
		}

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x06010901 RID: 67841 RVA: 0x00185336 File Offset: 0x00183536
		// (set) Token: 0x06010902 RID: 67842 RVA: 0x0018534F File Offset: 0x0018354F
		public unsafe bool bCastDistanceFieldIndirectShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bCastDistanceFieldIndirectShadow) & UStaticMeshComponent.__PropertyMask_bCastDistanceFieldIndirectShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bCastDistanceFieldIndirectShadow) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bCastDistanceFieldIndirectShadow) & ~UStaticMeshComponent.__PropertyMask_bCastDistanceFieldIndirectShadow) | (value ? UStaticMeshComponent.__PropertyMask_bCastDistanceFieldIndirectShadow : 0));
			}
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x06010903 RID: 67843 RVA: 0x0018537F File Offset: 0x0018357F
		// (set) Token: 0x06010904 RID: 67844 RVA: 0x00185398 File Offset: 0x00183598
		public unsafe bool bOverrideDistanceFieldSelfShadowBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideDistanceFieldSelfShadowBias) & UStaticMeshComponent.__PropertyMask_bOverrideDistanceFieldSelfShadowBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideDistanceFieldSelfShadowBias) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bOverrideDistanceFieldSelfShadowBias) & ~UStaticMeshComponent.__PropertyMask_bOverrideDistanceFieldSelfShadowBias) | (value ? UStaticMeshComponent.__PropertyMask_bOverrideDistanceFieldSelfShadowBias : 0));
			}
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x06010905 RID: 67845 RVA: 0x001853C8 File Offset: 0x001835C8
		// (set) Token: 0x06010906 RID: 67846 RVA: 0x001853E1 File Offset: 0x001835E1
		public unsafe bool bKuroDFISUseDirectionalLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bKuroDFISUseDirectionalLight) & UStaticMeshComponent.__PropertyMask_bKuroDFISUseDirectionalLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bKuroDFISUseDirectionalLight) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bKuroDFISUseDirectionalLight) & ~UStaticMeshComponent.__PropertyMask_bKuroDFISUseDirectionalLight) | (value ? UStaticMeshComponent.__PropertyMask_bKuroDFISUseDirectionalLight : 0));
			}
		}

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x06010907 RID: 67847 RVA: 0x00185411 File Offset: 0x00183611
		// (set) Token: 0x06010908 RID: 67848 RVA: 0x00185421 File Offset: 0x00183621
		public unsafe float KuroDistanceFieldIndirectShadowRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotation) = value;
			}
		}

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x06010909 RID: 67849 RVA: 0x00185432 File Offset: 0x00183632
		// (set) Token: 0x0601090A RID: 67850 RVA: 0x00185442 File Offset: 0x00183642
		public unsafe float KuroDistanceFieldIndirectShadowRotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowRotationAngle) = value;
			}
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x0601090B RID: 67851 RVA: 0x00185453 File Offset: 0x00183653
		// (set) Token: 0x0601090C RID: 67852 RVA: 0x00185463 File Offset: 0x00183663
		public unsafe float KuroDistanceFieldIndirectShadowSoftness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowSoftness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_KuroDistanceFieldIndirectShadowSoftness) = value;
			}
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x0601090D RID: 67853 RVA: 0x00185474 File Offset: 0x00183674
		// (set) Token: 0x0601090E RID: 67854 RVA: 0x0018548D File Offset: 0x0018368D
		public unsafe bool bUseSubDivisions
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseSubDivisions) & UStaticMeshComponent.__PropertyMask_bUseSubDivisions) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseSubDivisions) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseSubDivisions) & ~UStaticMeshComponent.__PropertyMask_bUseSubDivisions) | (value ? UStaticMeshComponent.__PropertyMask_bUseSubDivisions : 0));
			}
		}

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x0601090F RID: 67855 RVA: 0x001854BD File Offset: 0x001836BD
		// (set) Token: 0x06010910 RID: 67856 RVA: 0x001854D6 File Offset: 0x001836D6
		public unsafe bool bUseDefaultCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseDefaultCollision) & UStaticMeshComponent.__PropertyMask_bUseDefaultCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseDefaultCollision) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bUseDefaultCollision) & ~UStaticMeshComponent.__PropertyMask_bUseDefaultCollision) | (value ? UStaticMeshComponent.__PropertyMask_bUseDefaultCollision : 0));
			}
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x06010911 RID: 67857 RVA: 0x00185506 File Offset: 0x00183706
		// (set) Token: 0x06010912 RID: 67858 RVA: 0x0018551F File Offset: 0x0018371F
		public unsafe bool bRuntimeDisableCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bRuntimeDisableCollision) & UStaticMeshComponent.__PropertyMask_bRuntimeDisableCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bRuntimeDisableCollision) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bRuntimeDisableCollision) & ~UStaticMeshComponent.__PropertyMask_bRuntimeDisableCollision) | (value ? UStaticMeshComponent.__PropertyMask_bRuntimeDisableCollision : 0));
			}
		}

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x06010913 RID: 67859 RVA: 0x0018554F File Offset: 0x0018374F
		// (set) Token: 0x06010914 RID: 67860 RVA: 0x00185568 File Offset: 0x00183768
		public unsafe bool bReverseCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bReverseCulling) & UStaticMeshComponent.__PropertyMask_bReverseCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bReverseCulling) = ((*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_bReverseCulling) & ~UStaticMeshComponent.__PropertyMask_bReverseCulling) | (value ? UStaticMeshComponent.__PropertyMask_bReverseCulling : 0));
			}
		}

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x06010915 RID: 67861 RVA: 0x00185598 File Offset: 0x00183798
		// (set) Token: 0x06010916 RID: 67862 RVA: 0x001855A8 File Offset: 0x001837A8
		public unsafe int OverriddenLightMapRes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_OverriddenLightMapRes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_OverriddenLightMapRes) = value;
			}
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x06010917 RID: 67863 RVA: 0x001855B9 File Offset: 0x001837B9
		// (set) Token: 0x06010918 RID: 67864 RVA: 0x001855C9 File Offset: 0x001837C9
		public unsafe float DistanceFieldIndirectShadowMinVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldIndirectShadowMinVisibility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldIndirectShadowMinVisibility) = value;
			}
		}

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x06010919 RID: 67865 RVA: 0x001855DA File Offset: 0x001837DA
		// (set) Token: 0x0601091A RID: 67866 RVA: 0x001855EA File Offset: 0x001837EA
		public unsafe float WPORTDistCullScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WPORTDistCullScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_WPORTDistCullScale) = value;
			}
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x0601091B RID: 67867 RVA: 0x001855FB File Offset: 0x001837FB
		// (set) Token: 0x0601091C RID: 67868 RVA: 0x0018560B File Offset: 0x0018380B
		public unsafe float DistanceFieldSelfShadowBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldSelfShadowBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_DistanceFieldSelfShadowBias) = value;
			}
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x0601091D RID: 67869 RVA: 0x0018561C File Offset: 0x0018381C
		// (set) Token: 0x0601091E RID: 67870 RVA: 0x0018562C File Offset: 0x0018382C
		public unsafe float StreamingDistanceMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_StreamingDistanceMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_StreamingDistanceMultiplier) = value;
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x0601091F RID: 67871 RVA: 0x00185640 File Offset: 0x00183840
		// (set) Token: 0x06010920 RID: 67872 RVA: 0x00185679 File Offset: 0x00183879
		public TArray<FStaticMeshComponentLODInfo> LODData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticMeshComponentLODInfo> result;
				if ((result = this._LODData) == null)
				{
					result = (this._LODData = new TArray<FStaticMeshComponentLODInfo>(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_LODData, this));
				}
				return result;
			}
			set
			{
				this.LODData.CopyAssign(value);
			}
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x06010921 RID: 67873 RVA: 0x00185688 File Offset: 0x00183888
		// (set) Token: 0x06010922 RID: 67874 RVA: 0x001856C1 File Offset: 0x001838C1
		public TArray<FStreamingTextureBuildInfo> StreamingTextureData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStreamingTextureBuildInfo> result;
				if ((result = this._StreamingTextureData) == null)
				{
					result = (this._StreamingTextureData = new TArray<FStreamingTextureBuildInfo>(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_StreamingTextureData, this));
				}
				return result;
			}
			set
			{
				this.StreamingTextureData.CopyAssign(value);
			}
		}

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x06010923 RID: 67875 RVA: 0x001856D0 File Offset: 0x001838D0
		// (set) Token: 0x06010924 RID: 67876 RVA: 0x00185709 File Offset: 0x00183909
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get
			{
				base.FastCheckIsValid();
				FLightmassPrimitiveSettings result;
				if ((result = this._LightmassSettings) == null)
				{
					result = (this._LightmassSettings = new FLightmassPrimitiveSettings(base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_LightmassSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightmassPrimitiveSettings.StaticStruct(), base.NativePtr + (IntPtr)UStaticMeshComponent.__PropertyOffset_LightmassSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010925 RID: 67877 RVA: 0x0018572A File Offset: 0x0018392A
		[NullableContext(2)]
		public bool SetStaticMesh(UStaticMesh NewMesh)
		{
			return UStaticMeshComponent.__SetStaticMesh_Internal(base.NativePtr, (NewMesh != null) ? NewMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010926 RID: 67878 RVA: 0x00185747 File Offset: 0x00183947
		public void SetReverseCulling(bool ReverseCulling)
		{
			UStaticMeshComponent.__SetReverseCulling_Internal(base.NativePtr, ReverseCulling);
		}

		// Token: 0x06010927 RID: 67879 RVA: 0x00185755 File Offset: 0x00183955
		public void SetForceVisibleInKuroRayTracing(bool NewValue)
		{
			UStaticMeshComponent.__SetForceVisibleInKuroRayTracing_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06010928 RID: 67880 RVA: 0x00185763 File Offset: 0x00183963
		public void SetForceEnableOpacityMicromap(bool bForceEnable)
		{
			UStaticMeshComponent.__SetForceEnableOpacityMicromap_Internal(base.NativePtr, bForceEnable);
		}

		// Token: 0x06010929 RID: 67881 RVA: 0x00185771 File Offset: 0x00183971
		public void SetForcedLodModel(int NewForcedLodModel)
		{
			UStaticMeshComponent.__SetForcedLodModel_Internal(base.NativePtr, NewForcedLodModel);
		}

		// Token: 0x0601092A RID: 67882 RVA: 0x0018577F File Offset: 0x0018397F
		public void SetEvaluateWorldPositionOffsetInRayTracing(bool NewValue)
		{
			UStaticMeshComponent.__SetEvaluateWorldPositionOffsetInRayTracing_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0601092B RID: 67883 RVA: 0x0018578D File Offset: 0x0018398D
		public void SetDistanceFieldSelfShadowBias(float NewValue)
		{
			UStaticMeshComponent.__SetDistanceFieldSelfShadowBias_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0601092C RID: 67884 RVA: 0x0018579B File Offset: 0x0018399B
		public void SetDistanceFieldIndirectShadowArgs(float Rotation, float RotationAngle, float Softness)
		{
			UStaticMeshComponent.__SetDistanceFieldIndirectShadowArgs_Internal(base.NativePtr, Rotation, RotationAngle, Softness);
		}

		// Token: 0x0601092D RID: 67885 RVA: 0x001857AB File Offset: 0x001839AB
		public void SetDisableOpacityMicromap(bool bDisable)
		{
			UStaticMeshComponent.__SetDisableOpacityMicromap_Internal(base.NativePtr, bDisable);
		}

		// Token: 0x0601092E RID: 67886 RVA: 0x001857B9 File Offset: 0x001839B9
		[NullableContext(2)]
		public void OnRep_StaticMesh(UStaticMesh OldStaticMesh)
		{
			UStaticMeshComponent.__OnRep_StaticMesh_Internal(base.NativePtr, (OldStaticMesh != null) ? OldStaticMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601092F RID: 67887 RVA: 0x001857D8 File Offset: 0x001839D8
		public unsafe void GetLocalBounds(ref FVector Min, ref FVector Max)
		{
			fixed (FVector* ptr = &Min)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &Max)
				{
					void* ptr4 = (void*)ptr3;
					UStaticMeshComponent.__GetLocalBounds_Internal(base.NativePtr, ref Min, ref Max);
					ptr = null;
				}
			}
		}

		// Token: 0x06010930 RID: 67888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetStaticMesh_Internal(IntPtr @this, IntPtr NewMesh);

		// Token: 0x06010931 RID: 67889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReverseCulling_Internal(IntPtr @this, bool ReverseCulling);

		// Token: 0x06010932 RID: 67890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceVisibleInKuroRayTracing_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06010933 RID: 67891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceEnableOpacityMicromap_Internal(IntPtr @this, bool bForceEnable);

		// Token: 0x06010934 RID: 67892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForcedLodModel_Internal(IntPtr @this, int NewForcedLodModel);

		// Token: 0x06010935 RID: 67893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEvaluateWorldPositionOffsetInRayTracing_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06010936 RID: 67894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceFieldSelfShadowBias_Internal(IntPtr @this, float NewValue);

		// Token: 0x06010937 RID: 67895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceFieldIndirectShadowArgs_Internal(IntPtr @this, float Rotation, float RotationAngle, float Softness);

		// Token: 0x06010938 RID: 67896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableOpacityMicromap_Internal(IntPtr @this, bool bDisable);

		// Token: 0x06010939 RID: 67897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_StaticMesh_Internal(IntPtr @this, IntPtr OldStaticMesh);

		// Token: 0x0601093A RID: 67898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocalBounds_Internal(IntPtr @this, ref FVector Min, ref FVector Max);

		// Token: 0x0601093B RID: 67899 RVA: 0x00185802 File Offset: 0x00183A02
		static UStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticMeshComponent");
		}

		// Token: 0x0601093C RID: 67900 RVA: 0x00185810 File Offset: 0x00183A10
		protected UStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008DA6 RID: 36262
		public new const string __ObjectPath = "/Script/Engine.StaticMeshComponent";

		// Token: 0x04008DA7 RID: 36263
		private static IntPtr _ClassPtr;

		// Token: 0x04008DA8 RID: 36264
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008DA9 RID: 36265
		internal static int __PropertyOffset_ForcedLodModel;

		// Token: 0x04008DAA RID: 36266
		internal static int __PropertyOffset_PreviousLODLevel;

		// Token: 0x04008DAB RID: 36267
		internal static int __PropertyOffset_MinLOD;

		// Token: 0x04008DAC RID: 36268
		internal static int __PropertyOffset_SubDivisionStepSize;

		// Token: 0x04008DAD RID: 36269
		internal static int __PropertyOffset_bOverrideScreenSizeCullRatio;

		// Token: 0x04008DAE RID: 36270
		internal static byte __PropertyMask_bOverrideScreenSizeCullRatio;

		// Token: 0x04008DAF RID: 36271
		internal static int __PropertyOffset_ScreenSizeCullRatioOverride;

		// Token: 0x04008DB0 RID: 36272
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04008DB1 RID: 36273
		internal static int __PropertyOffset_CachedVertexBounds;

		// Token: 0x04008DB2 RID: 36274
		internal static int __PropertyOffset_ExtraMaterialInfos;

		// Token: 0x04008DB3 RID: 36275
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExtraMaterialInfo> _ExtraMaterialInfos;

		// Token: 0x04008DB4 RID: 36276
		internal static int __PropertyOffset_WireframeColorOverride;

		// Token: 0x04008DB5 RID: 36277
		internal static int __PropertyOffset_bEvaluateWorldPositionOffset;

		// Token: 0x04008DB6 RID: 36278
		internal static byte __PropertyMask_bEvaluateWorldPositionOffset;

		// Token: 0x04008DB7 RID: 36279
		internal static int __PropertyOffset_bDisableOpacityMicromap;

		// Token: 0x04008DB8 RID: 36280
		internal static byte __PropertyMask_bDisableOpacityMicromap;

		// Token: 0x04008DB9 RID: 36281
		internal static int __PropertyOffset_bForceEnableOpacityMicromap;

		// Token: 0x04008DBA RID: 36282
		internal static byte __PropertyMask_bForceEnableOpacityMicromap;

		// Token: 0x04008DBB RID: 36283
		internal static int __PropertyOffset_bOverrideWireframeColor;

		// Token: 0x04008DBC RID: 36284
		internal static byte __PropertyMask_bOverrideWireframeColor;

		// Token: 0x04008DBD RID: 36285
		internal static int __PropertyOffset_bOverrideMinLOD;

		// Token: 0x04008DBE RID: 36286
		internal static byte __PropertyMask_bOverrideMinLOD;

		// Token: 0x04008DBF RID: 36287
		internal static int __PropertyOffset_bOverrideNavigationExport;

		// Token: 0x04008DC0 RID: 36288
		internal static byte __PropertyMask_bOverrideNavigationExport;

		// Token: 0x04008DC1 RID: 36289
		internal static int __PropertyOffset_bForceNavigationObstacle;

		// Token: 0x04008DC2 RID: 36290
		internal static byte __PropertyMask_bForceNavigationObstacle;

		// Token: 0x04008DC3 RID: 36291
		internal static int __PropertyOffset_bDisallowMeshPaintPerInstance;

		// Token: 0x04008DC4 RID: 36292
		internal static byte __PropertyMask_bDisallowMeshPaintPerInstance;

		// Token: 0x04008DC5 RID: 36293
		internal static int __PropertyOffset_bIgnoreInstanceForTextureStreaming;

		// Token: 0x04008DC6 RID: 36294
		internal static byte __PropertyMask_bIgnoreInstanceForTextureStreaming;

		// Token: 0x04008DC7 RID: 36295
		internal static int __PropertyOffset_bOverrideLightMapRes;

		// Token: 0x04008DC8 RID: 36296
		internal static byte __PropertyMask_bOverrideLightMapRes;

		// Token: 0x04008DC9 RID: 36297
		internal static int __PropertyOffset_bCastDistanceFieldIndirectShadow;

		// Token: 0x04008DCA RID: 36298
		internal static byte __PropertyMask_bCastDistanceFieldIndirectShadow;

		// Token: 0x04008DCB RID: 36299
		internal static int __PropertyOffset_bOverrideDistanceFieldSelfShadowBias;

		// Token: 0x04008DCC RID: 36300
		internal static byte __PropertyMask_bOverrideDistanceFieldSelfShadowBias;

		// Token: 0x04008DCD RID: 36301
		internal static int __PropertyOffset_bKuroDFISUseDirectionalLight;

		// Token: 0x04008DCE RID: 36302
		internal static byte __PropertyMask_bKuroDFISUseDirectionalLight;

		// Token: 0x04008DCF RID: 36303
		internal static int __PropertyOffset_KuroDistanceFieldIndirectShadowRotation;

		// Token: 0x04008DD0 RID: 36304
		internal static int __PropertyOffset_KuroDistanceFieldIndirectShadowRotationAngle;

		// Token: 0x04008DD1 RID: 36305
		internal static int __PropertyOffset_KuroDistanceFieldIndirectShadowSoftness;

		// Token: 0x04008DD2 RID: 36306
		internal static int __PropertyOffset_bUseSubDivisions;

		// Token: 0x04008DD3 RID: 36307
		internal static byte __PropertyMask_bUseSubDivisions;

		// Token: 0x04008DD4 RID: 36308
		internal static int __PropertyOffset_bUseDefaultCollision;

		// Token: 0x04008DD5 RID: 36309
		internal static byte __PropertyMask_bUseDefaultCollision;

		// Token: 0x04008DD6 RID: 36310
		internal static int __PropertyOffset_bRuntimeDisableCollision;

		// Token: 0x04008DD7 RID: 36311
		internal static byte __PropertyMask_bRuntimeDisableCollision;

		// Token: 0x04008DD8 RID: 36312
		internal static int __PropertyOffset_bReverseCulling;

		// Token: 0x04008DD9 RID: 36313
		internal static byte __PropertyMask_bReverseCulling;

		// Token: 0x04008DDA RID: 36314
		internal static int __PropertyOffset_OverriddenLightMapRes;

		// Token: 0x04008DDB RID: 36315
		internal static int __PropertyOffset_DistanceFieldIndirectShadowMinVisibility;

		// Token: 0x04008DDC RID: 36316
		internal static int __PropertyOffset_WPORTDistCullScale;

		// Token: 0x04008DDD RID: 36317
		internal static int __PropertyOffset_DistanceFieldSelfShadowBias;

		// Token: 0x04008DDE RID: 36318
		internal static int __PropertyOffset_StreamingDistanceMultiplier;

		// Token: 0x04008DDF RID: 36319
		internal static int __PropertyOffset_LODData;

		// Token: 0x04008DE0 RID: 36320
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticMeshComponentLODInfo> _LODData;

		// Token: 0x04008DE1 RID: 36321
		internal static int __PropertyOffset_StreamingTextureData;

		// Token: 0x04008DE2 RID: 36322
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStreamingTextureBuildInfo> _StreamingTextureData;

		// Token: 0x04008DE3 RID: 36323
		internal static int __PropertyOffset_LightmassSettings;

		// Token: 0x04008DE4 RID: 36324
		[Nullable(2)]
		private FLightmassPrimitiveSettings _LightmassSettings;
	}
}
