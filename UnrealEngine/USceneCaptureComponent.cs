using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D3 RID: 4307
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponent")]
	[UnrealStructLayout(864, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 864)]
	public abstract class USceneCaptureComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F5A4 RID: 62884 RVA: 0x0016C0A6 File Offset: 0x0016A2A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneCaptureComponent._ClassPtr;
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0600F5A5 RID: 62885 RVA: 0x0016C0B2 File Offset: 0x0016A2B2
		// (set) Token: 0x0600F5A6 RID: 62886 RVA: 0x0016C0C2 File Offset: 0x0016A2C2
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

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0600F5A7 RID: 62887 RVA: 0x0016C0D3 File Offset: 0x0016A2D3
		// (set) Token: 0x0600F5A8 RID: 62888 RVA: 0x0016C0E7 File Offset: 0x0016A2E7
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

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0600F5A9 RID: 62889 RVA: 0x0016C0FC File Offset: 0x0016A2FC
		// (set) Token: 0x0600F5AA RID: 62890 RVA: 0x0016C10C File Offset: 0x0016A30C
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

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0600F5AB RID: 62891 RVA: 0x0016C11D File Offset: 0x0016A31D
		// (set) Token: 0x0600F5AC RID: 62892 RVA: 0x0016C12D File Offset: 0x0016A32D
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

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600F5AD RID: 62893 RVA: 0x0016C13E File Offset: 0x0016A33E
		// (set) Token: 0x0600F5AE RID: 62894 RVA: 0x0016C157 File Offset: 0x0016A357
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

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600F5AF RID: 62895 RVA: 0x0016C187 File Offset: 0x0016A387
		// (set) Token: 0x0600F5B0 RID: 62896 RVA: 0x0016C1A0 File Offset: 0x0016A3A0
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

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600F5B1 RID: 62897 RVA: 0x0016C1D0 File Offset: 0x0016A3D0
		// (set) Token: 0x0600F5B2 RID: 62898 RVA: 0x0016C1E9 File Offset: 0x0016A3E9
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

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0600F5B3 RID: 62899 RVA: 0x0016C219 File Offset: 0x0016A419
		// (set) Token: 0x0600F5B4 RID: 62900 RVA: 0x0016C229 File Offset: 0x0016A429
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

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0600F5B5 RID: 62901 RVA: 0x0016C23C File Offset: 0x0016A43C
		// (set) Token: 0x0600F5B6 RID: 62902 RVA: 0x0016C275 File Offset: 0x0016A475
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

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0600F5B7 RID: 62903 RVA: 0x0016C283 File Offset: 0x0016A483
		// (set) Token: 0x0600F5B8 RID: 62904 RVA: 0x0016C29C File Offset: 0x0016A49C
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

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0600F5B9 RID: 62905 RVA: 0x0016C2CC File Offset: 0x0016A4CC
		// (set) Token: 0x0600F5BA RID: 62906 RVA: 0x0016C305 File Offset: 0x0016A505
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

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0600F5BB RID: 62907 RVA: 0x0016C314 File Offset: 0x0016A514
		// (set) Token: 0x0600F5BC RID: 62908 RVA: 0x0016C34D File Offset: 0x0016A54D
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

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0600F5BD RID: 62909 RVA: 0x0016C35C File Offset: 0x0016A55C
		// (set) Token: 0x0600F5BE RID: 62910 RVA: 0x0016C395 File Offset: 0x0016A595
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

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600F5BF RID: 62911 RVA: 0x0016C3A4 File Offset: 0x0016A5A4
		// (set) Token: 0x0600F5C0 RID: 62912 RVA: 0x0016C3DD File Offset: 0x0016A5DD
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

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600F5C1 RID: 62913 RVA: 0x0016C3EC File Offset: 0x0016A5EC
		// (set) Token: 0x0600F5C2 RID: 62914 RVA: 0x0016C425 File Offset: 0x0016A625
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

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600F5C3 RID: 62915 RVA: 0x0016C434 File Offset: 0x0016A634
		// (set) Token: 0x0600F5C4 RID: 62916 RVA: 0x0016C46D File Offset: 0x0016A66D
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

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0600F5C5 RID: 62917 RVA: 0x0016C47B File Offset: 0x0016A67B
		// (set) Token: 0x0600F5C6 RID: 62918 RVA: 0x0016C48B File Offset: 0x0016A68B
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

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x0600F5C7 RID: 62919 RVA: 0x0016C49C File Offset: 0x0016A69C
		// (set) Token: 0x0600F5C8 RID: 62920 RVA: 0x0016C4AC File Offset: 0x0016A6AC
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

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0600F5C9 RID: 62921 RVA: 0x0016C4BD File Offset: 0x0016A6BD
		// (set) Token: 0x0600F5CA RID: 62922 RVA: 0x0016C4CD File Offset: 0x0016A6CD
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

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0600F5CB RID: 62923 RVA: 0x0016C4DE File Offset: 0x0016A6DE
		// (set) Token: 0x0600F5CC RID: 62924 RVA: 0x0016C4EE File Offset: 0x0016A6EE
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

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0600F5CD RID: 62925 RVA: 0x0016C4FF File Offset: 0x0016A6FF
		// (set) Token: 0x0600F5CE RID: 62926 RVA: 0x0016C50F File Offset: 0x0016A70F
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

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0600F5CF RID: 62927 RVA: 0x0016C520 File Offset: 0x0016A720
		// (set) Token: 0x0600F5D0 RID: 62928 RVA: 0x0016C559 File Offset: 0x0016A759
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

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600F5D1 RID: 62929 RVA: 0x0016C567 File Offset: 0x0016A767
		// (set) Token: 0x0600F5D2 RID: 62930 RVA: 0x0016C57B File Offset: 0x0016A77B
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

		// Token: 0x0600F5D3 RID: 62931 RVA: 0x0016C590 File Offset: 0x0016A790
		[NullableContext(2)]
		public void ShowOnlyComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__ShowOnlyComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600F5D4 RID: 62932 RVA: 0x0016C5AD File Offset: 0x0016A7AD
		[NullableContext(2)]
		public void ShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__ShowOnlyActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x0600F5D5 RID: 62933 RVA: 0x0016C5CB File Offset: 0x0016A7CB
		public void SetCaptureSortPriority(int NewCaptureSortPriority)
		{
			USceneCaptureComponent.__SetCaptureSortPriority_Internal(base.NativePtr, NewCaptureSortPriority);
		}

		// Token: 0x0600F5D6 RID: 62934 RVA: 0x0016C5D9 File Offset: 0x0016A7D9
		[NullableContext(2)]
		public void RemoveShowOnlyComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__RemoveShowOnlyComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600F5D7 RID: 62935 RVA: 0x0016C5F6 File Offset: 0x0016A7F6
		[NullableContext(2)]
		public void RemoveShowOnlyActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__RemoveShowOnlyActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x0600F5D8 RID: 62936 RVA: 0x0016C614 File Offset: 0x0016A814
		[NullableContext(2)]
		public void RemoveForceShowComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__RemoveForceShowComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600F5D9 RID: 62937 RVA: 0x0016C631 File Offset: 0x0016A831
		[NullableContext(2)]
		public void RemoveForceShowActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__RemoveForceShowActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x0600F5DA RID: 62938 RVA: 0x0016C64F File Offset: 0x0016A84F
		[NullableContext(2)]
		public void HideComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__HideComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600F5DB RID: 62939 RVA: 0x0016C66C File Offset: 0x0016A86C
		[NullableContext(2)]
		public void HideActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__HideActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x0600F5DC RID: 62940 RVA: 0x0016C68A File Offset: 0x0016A88A
		[NullableContext(2)]
		public void ForceShowComponent(UPrimitiveComponent InComponent)
		{
			USceneCaptureComponent.__ForceShowComponent_Internal(base.NativePtr, (InComponent != null) ? InComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600F5DD RID: 62941 RVA: 0x0016C6A7 File Offset: 0x0016A8A7
		[NullableContext(2)]
		public void ForceShowActorComponents(AActor InActor, bool bIncludeFromChildActors = false)
		{
			USceneCaptureComponent.__ForceShowActorComponents_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero, bIncludeFromChildActors);
		}

		// Token: 0x0600F5DE RID: 62942 RVA: 0x0016C6C5 File Offset: 0x0016A8C5
		public void ClearShowOnlyComponents()
		{
			USceneCaptureComponent.__ClearShowOnlyComponents_Internal(base.NativePtr);
		}

		// Token: 0x0600F5DF RID: 62943 RVA: 0x0016C6D2 File Offset: 0x0016A8D2
		public void ClearHiddenComponents()
		{
			USceneCaptureComponent.__ClearHiddenComponents_Internal(base.NativePtr);
		}

		// Token: 0x0600F5E0 RID: 62944 RVA: 0x0016C6DF File Offset: 0x0016A8DF
		public void ClearForceShowComponents()
		{
			USceneCaptureComponent.__ClearForceShowComponents_Internal(base.NativePtr);
		}

		// Token: 0x0600F5E1 RID: 62945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowOnlyComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x0600F5E2 RID: 62946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowOnlyActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600F5E3 RID: 62947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCaptureSortPriority_Internal(IntPtr @this, int NewCaptureSortPriority);

		// Token: 0x0600F5E4 RID: 62948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveShowOnlyComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x0600F5E5 RID: 62949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveShowOnlyActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600F5E6 RID: 62950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveForceShowComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x0600F5E7 RID: 62951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveForceShowActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600F5E8 RID: 62952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x0600F5E9 RID: 62953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600F5EA RID: 62954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceShowComponent_Internal(IntPtr @this, IntPtr InComponent);

		// Token: 0x0600F5EB RID: 62955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceShowActorComponents_Internal(IntPtr @this, IntPtr InActor, bool bIncludeFromChildActors);

		// Token: 0x0600F5EC RID: 62956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearShowOnlyComponents_Internal(IntPtr @this);

		// Token: 0x0600F5ED RID: 62957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearHiddenComponents_Internal(IntPtr @this);

		// Token: 0x0600F5EE RID: 62958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearForceShowComponents_Internal(IntPtr @this);

		// Token: 0x0600F5EF RID: 62959 RVA: 0x0016C6EC File Offset: 0x0016A8EC
		static USceneCaptureComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCaptureComponent");
		}

		// Token: 0x0600F5F0 RID: 62960 RVA: 0x0016C6FC File Offset: 0x0016A8FC
		protected USceneCaptureComponent() : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F5F1 RID: 62961 RVA: 0x0016C724 File Offset: 0x0016A924
		protected USceneCaptureComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008513 RID: 34067
		public new const string __ObjectPath = "/Script/Engine.SceneCaptureComponent";

		// Token: 0x04008514 RID: 34068
		private static IntPtr _ClassPtr;

		// Token: 0x04008515 RID: 34069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008516 RID: 34070
		internal static int __PropertyOffset_PrimitiveRenderMode;

		// Token: 0x04008517 RID: 34071
		internal static int __PropertyOffset_CaptureSource;

		// Token: 0x04008518 RID: 34072
		internal static int __PropertyOffset_CaptureDepthScale;

		// Token: 0x04008519 RID: 34073
		internal static int __PropertyOffset_bCaptureShadowDepths;

		// Token: 0x0400851A RID: 34074
		internal static int __PropertyOffset_bCaptureEveryFrame;

		// Token: 0x0400851B RID: 34075
		internal static byte __PropertyMask_bCaptureEveryFrame;

		// Token: 0x0400851C RID: 34076
		internal static int __PropertyOffset_bCaptureOnMovement;

		// Token: 0x0400851D RID: 34077
		internal static byte __PropertyMask_bCaptureOnMovement;

		// Token: 0x0400851E RID: 34078
		internal static int __PropertyOffset_bCaptureUI;

		// Token: 0x0400851F RID: 34079
		internal static byte __PropertyMask_bCaptureUI;

		// Token: 0x04008520 RID: 34080
		internal static int __PropertyOffset_bAlwaysPersistRenderingState;

		// Token: 0x04008521 RID: 34081
		internal static int __PropertyOffset_HiddenComponents;

		// Token: 0x04008522 RID: 34082
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _HiddenComponents;

		// Token: 0x04008523 RID: 34083
		internal static int __PropertyOffset_bUseSoftHiddenActors;

		// Token: 0x04008524 RID: 34084
		internal static byte __PropertyMask_bUseSoftHiddenActors;

		// Token: 0x04008525 RID: 34085
		internal static int __PropertyOffset_HiddenActors;

		// Token: 0x04008526 RID: 34086
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HiddenActors;

		// Token: 0x04008527 RID: 34087
		internal static int __PropertyOffset_SoftHiddenActors;

		// Token: 0x04008528 RID: 34088
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<AActor>> _SoftHiddenActors;

		// Token: 0x04008529 RID: 34089
		internal static int __PropertyOffset_ShowOnlyComponents;

		// Token: 0x0400852A RID: 34090
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _ShowOnlyComponents;

		// Token: 0x0400852B RID: 34091
		internal static int __PropertyOffset_ShowOnlyActors;

		// Token: 0x0400852C RID: 34092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ShowOnlyActors;

		// Token: 0x0400852D RID: 34093
		internal static int __PropertyOffset_ForceShowComponents;

		// Token: 0x0400852E RID: 34094
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _ForceShowComponents;

		// Token: 0x0400852F RID: 34095
		internal static int __PropertyOffset_ForceShowActors;

		// Token: 0x04008530 RID: 34096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ForceShowActors;

		// Token: 0x04008531 RID: 34097
		internal static int __PropertyOffset_LODDistanceFactor;

		// Token: 0x04008532 RID: 34098
		internal static int __PropertyOffset_MaxViewDistanceOverride;

		// Token: 0x04008533 RID: 34099
		internal static int __PropertyOffset_CaptureSortPriority;

		// Token: 0x04008534 RID: 34100
		internal static int __PropertyOffset_bUseRayTracingIfEnabled;

		// Token: 0x04008535 RID: 34101
		internal static int __PropertyOffset_bIgnoreWorldPostProcessBlendables;

		// Token: 0x04008536 RID: 34102
		internal static int __PropertyOffset_ShowFlagSettings;

		// Token: 0x04008537 RID: 34103
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEngineShowFlagsSetting> _ShowFlagSettings;

		// Token: 0x04008538 RID: 34104
		internal static int __PropertyOffset_ProfilingEventName;
	}
}
