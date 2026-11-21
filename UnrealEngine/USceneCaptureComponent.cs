using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000276 RID: 630
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponent")]
	[UnrealStructLayout(864, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 864)]
	public abstract class USceneCaptureComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004059 RID: 16473 RVA: 0x0005C5E9 File Offset: 0x0005A7E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneCaptureComponent._ClassPtr;
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600405A RID: 16474 RVA: 0x0005C5F5 File Offset: 0x0005A7F5
		// (set) Token: 0x0600405B RID: 16475 RVA: 0x0005C605 File Offset: 0x0005A805
		public unsafe ESceneCapturePrimitiveRenderMode PrimitiveRenderMode
		{
			get
			{
				return (ESceneCapturePrimitiveRenderMode)(*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_PrimitiveRenderMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_PrimitiveRenderMode) = (byte)value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x0005C616 File Offset: 0x0005A816
		// (set) Token: 0x0600405D RID: 16477 RVA: 0x0005C62A File Offset: 0x0005A82A
		[Nullable(0)]
		public unsafe TEnumAsByte<ESceneCaptureSource> CaptureSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_CaptureSource);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_CaptureSource) = value;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x0005C63F File Offset: 0x0005A83F
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x0005C64F File Offset: 0x0005A84F
		public unsafe float CaptureDepthScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_CaptureDepthScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_CaptureDepthScale) = value;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x0005C660 File Offset: 0x0005A860
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x0005C670 File Offset: 0x0005A870
		public unsafe bool bCaptureShadowDepths
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureShadowDepths) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureShadowDepths) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x0005C681 File Offset: 0x0005A881
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x0005C69A File Offset: 0x0005A89A
		public unsafe bool bCaptureEveryFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureEveryFrame) & USceneCaptureComponent.__PropertyMask_bCaptureEveryFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureEveryFrame) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureEveryFrame) & ~USceneCaptureComponent.__PropertyMask_bCaptureEveryFrame) | (value ? USceneCaptureComponent.__PropertyMask_bCaptureEveryFrame : 0));
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x0005C6CA File Offset: 0x0005A8CA
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x0005C6E3 File Offset: 0x0005A8E3
		public unsafe bool bCaptureOnMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureOnMovement) & USceneCaptureComponent.__PropertyMask_bCaptureOnMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureOnMovement) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureOnMovement) & ~USceneCaptureComponent.__PropertyMask_bCaptureOnMovement) | (value ? USceneCaptureComponent.__PropertyMask_bCaptureOnMovement : 0));
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x0005C713 File Offset: 0x0005A913
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x0005C72C File Offset: 0x0005A92C
		public unsafe bool bCaptureUI
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureUI) & USceneCaptureComponent.__PropertyMask_bCaptureUI) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureUI) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureUI) & ~USceneCaptureComponent.__PropertyMask_bCaptureUI) | (value ? USceneCaptureComponent.__PropertyMask_bCaptureUI : 0));
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x0005C75C File Offset: 0x0005A95C
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x0005C775 File Offset: 0x0005A975
		public unsafe bool bCaptureWithTemporalUpscaler
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureWithTemporalUpscaler) & USceneCaptureComponent.__PropertyMask_bCaptureWithTemporalUpscaler) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureWithTemporalUpscaler) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bCaptureWithTemporalUpscaler) & ~USceneCaptureComponent.__PropertyMask_bCaptureWithTemporalUpscaler) | (value ? USceneCaptureComponent.__PropertyMask_bCaptureWithTemporalUpscaler : 0));
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x0005C7A5 File Offset: 0x0005A9A5
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x0005C7B5 File Offset: 0x0005A9B5
		public unsafe bool bAlwaysPersistRenderingState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bAlwaysPersistRenderingState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bAlwaysPersistRenderingState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x0005C7C8 File Offset: 0x0005A9C8
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x0005C801 File Offset: 0x0005AA01
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UPrimitiveComponent>> result;
				if ((result = this._HiddenComponents) == null)
				{
					result = (this._HiddenComponents = new TArray<TWeakObjectPtr<UPrimitiveComponent>>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_HiddenComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.HiddenComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x0005C80F File Offset: 0x0005AA0F
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x0005C828 File Offset: 0x0005AA28
		public unsafe bool bUseSoftHiddenActors
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bUseSoftHiddenActors) & USceneCaptureComponent.__PropertyMask_bUseSoftHiddenActors) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bUseSoftHiddenActors) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bUseSoftHiddenActors) & ~USceneCaptureComponent.__PropertyMask_bUseSoftHiddenActors) | (value ? USceneCaptureComponent.__PropertyMask_bUseSoftHiddenActors : 0));
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x0005C858 File Offset: 0x0005AA58
		// (set) Token: 0x06004071 RID: 16497 RVA: 0x0005C891 File Offset: 0x0005AA91
		public TArray<AActor> HiddenActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HiddenActors) == null)
				{
					result = (this._HiddenActors = new TArray<AActor>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_HiddenActors, this));
				}
				return result;
			}
			set
			{
				this.HiddenActors.CopyAssign(value);
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x0005C8A0 File Offset: 0x0005AAA0
		// (set) Token: 0x06004073 RID: 16499 RVA: 0x0005C8D9 File Offset: 0x0005AAD9
		public TArray<TSoftObjectPtr<AActor>> SoftHiddenActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<AActor>> result;
				if ((result = this._SoftHiddenActors) == null)
				{
					result = (this._SoftHiddenActors = new TArray<TSoftObjectPtr<AActor>>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_SoftHiddenActors, this));
				}
				return result;
			}
			set
			{
				this.SoftHiddenActors.CopyAssign(value);
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x0005C8E8 File Offset: 0x0005AAE8
		// (set) Token: 0x06004075 RID: 16501 RVA: 0x0005C921 File Offset: 0x0005AB21
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UPrimitiveComponent>> ShowOnlyComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UPrimitiveComponent>> result;
				if ((result = this._ShowOnlyComponents) == null)
				{
					result = (this._ShowOnlyComponents = new TArray<TWeakObjectPtr<UPrimitiveComponent>>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_ShowOnlyComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ShowOnlyComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x0005C930 File Offset: 0x0005AB30
		// (set) Token: 0x06004077 RID: 16503 RVA: 0x0005C969 File Offset: 0x0005AB69
		public TArray<AActor> ShowOnlyActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ShowOnlyActors) == null)
				{
					result = (this._ShowOnlyActors = new TArray<AActor>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_ShowOnlyActors, this));
				}
				return result;
			}
			set
			{
				this.ShowOnlyActors.CopyAssign(value);
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x0005C978 File Offset: 0x0005AB78
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x0005C9B1 File Offset: 0x0005ABB1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UPrimitiveComponent>> ForceShowComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UPrimitiveComponent>> result;
				if ((result = this._ForceShowComponents) == null)
				{
					result = (this._ForceShowComponents = new TArray<TWeakObjectPtr<UPrimitiveComponent>>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_ForceShowComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ForceShowComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x0005C9C0 File Offset: 0x0005ABC0
		// (set) Token: 0x0600407B RID: 16507 RVA: 0x0005C9F9 File Offset: 0x0005ABF9
		public TArray<AActor> ForceShowActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ForceShowActors) == null)
				{
					result = (this._ForceShowActors = new TArray<AActor>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_ForceShowActors, this));
				}
				return result;
			}
			set
			{
				this.ForceShowActors.CopyAssign(value);
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x0005CA07 File Offset: 0x0005AC07
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x0005CA17 File Offset: 0x0005AC17
		public unsafe float LODDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_LODDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_LODDistanceFactor) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x0005CA28 File Offset: 0x0005AC28
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x0005CA38 File Offset: 0x0005AC38
		public unsafe float MaxViewDistanceOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_MaxViewDistanceOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_MaxViewDistanceOverride) = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x0005CA49 File Offset: 0x0005AC49
		// (set) Token: 0x06004081 RID: 16513 RVA: 0x0005CA59 File Offset: 0x0005AC59
		public unsafe int CaptureSortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_CaptureSortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_CaptureSortPriority) = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x0005CA6A File Offset: 0x0005AC6A
		// (set) Token: 0x06004083 RID: 16515 RVA: 0x0005CA7A File Offset: 0x0005AC7A
		public unsafe bool bUseRayTracingIfEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bUseRayTracingIfEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bUseRayTracingIfEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x0005CA8B File Offset: 0x0005AC8B
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x0005CA9B File Offset: 0x0005AC9B
		public unsafe bool bIgnoreWorldPostProcessBlendables
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bIgnoreWorldPostProcessBlendables) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_bIgnoreWorldPostProcessBlendables) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x0005CAAC File Offset: 0x0005ACAC
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x0005CAE5 File Offset: 0x0005ACE5
		public TArray<FEngineShowFlagsSetting> ShowFlagSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEngineShowFlagsSetting> result;
				if ((result = this._ShowFlagSettings) == null)
				{
					result = (this._ShowFlagSettings = new TArray<FEngineShowFlagsSetting>(base.NativePtr + (IntPtr)USceneCaptureComponent.__PropertyOffset_ShowFlagSettings, this));
				}
				return result;
			}
			set
			{
				this.ShowFlagSettings.CopyAssign(value);
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x0005CAF3 File Offset: 0x0005ACF3
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x0005CB07 File Offset: 0x0005AD07
		public unsafe string ProfilingEventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USceneCaptureComponent.__PropertyOffset_ProfilingEventName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USceneCaptureComponent.__PropertyOffset_ProfilingEventName)), value);
			}
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0005CB1C File Offset: 0x0005AD1C
		[NullableContext(2)]
		public void ShowOnlyComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__ShowOnlyComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x0005CB39 File Offset: 0x0005AD39
		[NullableContext(2)]
		public void ShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__ShowOnlyActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x0005CB57 File Offset: 0x0005AD57
		public void SetCaptureSortPriority(int NewCaptureSortPriority)
		{
			USceneCaptureComponent.__SetCaptureSortPriority_Internal(base.NativePtr, NewCaptureSortPriority);
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x0005CB65 File Offset: 0x0005AD65
		[NullableContext(2)]
		public void RemoveShowOnlyComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__RemoveShowOnlyComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0005CB82 File Offset: 0x0005AD82
		[NullableContext(2)]
		public void RemoveShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__RemoveShowOnlyActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x0005CBA0 File Offset: 0x0005ADA0
		[NullableContext(2)]
		public void RemoveForceShowComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__RemoveForceShowComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x0005CBBD File Offset: 0x0005ADBD
		[NullableContext(2)]
		public void RemoveForceShowActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__RemoveForceShowActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0005CBDB File Offset: 0x0005ADDB
		[NullableContext(2)]
		public void HideComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__HideComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0005CBF8 File Offset: 0x0005ADF8
		[NullableContext(2)]
		public void HideActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__HideActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x0005CC16 File Offset: 0x0005AE16
		[NullableContext(2)]
		public void ForceShowComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__ForceShowComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0005CC33 File Offset: 0x0005AE33
		[NullableContext(2)]
		public void ForceShowActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__ForceShowActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x0005CC51 File Offset: 0x0005AE51
		public void ClearShowOnlyComponents()
		{
			USceneCaptureComponent.__ClearShowOnlyComponents_Internal(base.NativePtr);
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0005CC5E File Offset: 0x0005AE5E
		public void ClearHiddenComponents()
		{
			USceneCaptureComponent.__ClearHiddenComponents_Internal(base.NativePtr);
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x0005CC6B File Offset: 0x0005AE6B
		public void ClearForceShowComponents()
		{
			USceneCaptureComponent.__ClearForceShowComponents_Internal(base.NativePtr);
		}

		// Token: 0x06004098 RID: 16536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowOnlyComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x06004099 RID: 16537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowOnlyActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600409A RID: 16538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCaptureSortPriority_Internal(IntPtr @this, int NewCaptureSortPriority);

		// Token: 0x0600409B RID: 16539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveShowOnlyComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x0600409C RID: 16540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveShowOnlyActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600409D RID: 16541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveForceShowComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x0600409E RID: 16542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveForceShowActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600409F RID: 16543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x060040A0 RID: 16544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x060040A1 RID: 16545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceShowComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x060040A2 RID: 16546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceShowActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x060040A3 RID: 16547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearShowOnlyComponents_Internal(IntPtr @this);

		// Token: 0x060040A4 RID: 16548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearHiddenComponents_Internal(IntPtr @this);

		// Token: 0x060040A5 RID: 16549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearForceShowComponents_Internal(IntPtr @this);

		// Token: 0x060040A6 RID: 16550 RVA: 0x0005CC78 File Offset: 0x0005AE78
		static USceneCaptureComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCaptureComponent");
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x0005CC88 File Offset: 0x0005AE88
		protected USceneCaptureComponent() : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x0005CCB0 File Offset: 0x0005AEB0
		protected USceneCaptureComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001937 RID: 6455
		public new const string __ObjectPath = "/Script/Engine.SceneCaptureComponent";

		// Token: 0x04001938 RID: 6456
		private static IntPtr _ClassPtr;

		// Token: 0x04001939 RID: 6457
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400193A RID: 6458
		internal static int __PropertyOffset_PrimitiveRenderMode;

		// Token: 0x0400193B RID: 6459
		internal static int __PropertyOffset_CaptureSource;

		// Token: 0x0400193C RID: 6460
		internal static int __PropertyOffset_CaptureDepthScale;

		// Token: 0x0400193D RID: 6461
		internal static int __PropertyOffset_bCaptureShadowDepths;

		// Token: 0x0400193E RID: 6462
		internal static int __PropertyOffset_bCaptureEveryFrame;

		// Token: 0x0400193F RID: 6463
		internal static byte __PropertyMask_bCaptureEveryFrame;

		// Token: 0x04001940 RID: 6464
		internal static int __PropertyOffset_bCaptureOnMovement;

		// Token: 0x04001941 RID: 6465
		internal static byte __PropertyMask_bCaptureOnMovement;

		// Token: 0x04001942 RID: 6466
		internal static int __PropertyOffset_bCaptureUI;

		// Token: 0x04001943 RID: 6467
		internal static byte __PropertyMask_bCaptureUI;

		// Token: 0x04001944 RID: 6468
		internal static int __PropertyOffset_bCaptureWithTemporalUpscaler;

		// Token: 0x04001945 RID: 6469
		internal static byte __PropertyMask_bCaptureWithTemporalUpscaler;

		// Token: 0x04001946 RID: 6470
		internal static int __PropertyOffset_bAlwaysPersistRenderingState;

		// Token: 0x04001947 RID: 6471
		internal static int __PropertyOffset_HiddenComponents;

		// Token: 0x04001948 RID: 6472
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _HiddenComponents;

		// Token: 0x04001949 RID: 6473
		internal static int __PropertyOffset_bUseSoftHiddenActors;

		// Token: 0x0400194A RID: 6474
		internal static byte __PropertyMask_bUseSoftHiddenActors;

		// Token: 0x0400194B RID: 6475
		internal static int __PropertyOffset_HiddenActors;

		// Token: 0x0400194C RID: 6476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HiddenActors;

		// Token: 0x0400194D RID: 6477
		internal static int __PropertyOffset_SoftHiddenActors;

		// Token: 0x0400194E RID: 6478
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<AActor>> _SoftHiddenActors;

		// Token: 0x0400194F RID: 6479
		internal static int __PropertyOffset_ShowOnlyComponents;

		// Token: 0x04001950 RID: 6480
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _ShowOnlyComponents;

		// Token: 0x04001951 RID: 6481
		internal static int __PropertyOffset_ShowOnlyActors;

		// Token: 0x04001952 RID: 6482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ShowOnlyActors;

		// Token: 0x04001953 RID: 6483
		internal static int __PropertyOffset_ForceShowComponents;

		// Token: 0x04001954 RID: 6484
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _ForceShowComponents;

		// Token: 0x04001955 RID: 6485
		internal static int __PropertyOffset_ForceShowActors;

		// Token: 0x04001956 RID: 6486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ForceShowActors;

		// Token: 0x04001957 RID: 6487
		internal static int __PropertyOffset_LODDistanceFactor;

		// Token: 0x04001958 RID: 6488
		internal static int __PropertyOffset_MaxViewDistanceOverride;

		// Token: 0x04001959 RID: 6489
		internal static int __PropertyOffset_CaptureSortPriority;

		// Token: 0x0400195A RID: 6490
		internal static int __PropertyOffset_bUseRayTracingIfEnabled;

		// Token: 0x0400195B RID: 6491
		internal static int __PropertyOffset_bIgnoreWorldPostProcessBlendables;

		// Token: 0x0400195C RID: 6492
		internal static int __PropertyOffset_ShowFlagSettings;

		// Token: 0x0400195D RID: 6493
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEngineShowFlagsSetting> _ShowFlagSettings;

		// Token: 0x0400195E RID: 6494
		internal static int __PropertyOffset_ProfilingEventName;
	}
}
