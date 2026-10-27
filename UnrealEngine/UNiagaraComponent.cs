using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002543 RID: 9539
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraComponent")]
	[UnrealStructLayout(2512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2512)]
	public class UNiagaraComponent : UFXSystemComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023674 RID: 145012 RVA: 0x00345A3A File Offset: 0x00343C3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraComponent._ClassPtr;
		}

		// Token: 0x06023675 RID: 145013 RVA: 0x00345A48 File Offset: 0x00343C48
		public UNiagaraComponent() : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023676 RID: 145014 RVA: 0x00345A70 File Offset: 0x00343C70
		public UNiagaraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008810 RID: 34832
		// (get) Token: 0x06023677 RID: 145015 RVA: 0x00345AA3 File Offset: 0x00343CA3
		// (set) Token: 0x06023678 RID: 145016 RVA: 0x00345AB7 File Offset: 0x00343CB7
		[Nullable(2)]
		public unsafe UNiagaraSystem Asset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraComponent.__PropertyOffset_Asset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraComponent.__PropertyOffset_Asset, value);
			}
		}

		// Token: 0x17008811 RID: 34833
		// (get) Token: 0x06023679 RID: 145017 RVA: 0x00345ACC File Offset: 0x00343CCC
		// (set) Token: 0x0602367A RID: 145018 RVA: 0x00345ADC File Offset: 0x00343CDC
		public unsafe ENiagaraTickBehavior TickBehavior
		{
			get
			{
				return (ENiagaraTickBehavior)(*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_TickBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_TickBehavior) = (byte)value;
			}
		}

		// Token: 0x17008812 RID: 34834
		// (get) Token: 0x0602367B RID: 145019 RVA: 0x00345AF0 File Offset: 0x00343CF0
		// (set) Token: 0x0602367C RID: 145020 RVA: 0x00345B29 File Offset: 0x00343D29
		public FNiagaraUserRedirectionParameterStore OverrideParameters
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserRedirectionParameterStore result;
				if ((result = this._OverrideParameters) == null)
				{
					result = (this._OverrideParameters = new FNiagaraUserRedirectionParameterStore(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_OverrideParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserRedirectionParameterStore.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_OverrideParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008813 RID: 34835
		// (get) Token: 0x0602367D RID: 145021 RVA: 0x00345B4A File Offset: 0x00343D4A
		// (set) Token: 0x0602367E RID: 145022 RVA: 0x00345B63 File Offset: 0x00343D63
		public unsafe bool bForceSolo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bForceSolo) & UNiagaraComponent.__PropertyMask_bForceSolo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bForceSolo) = ((*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bForceSolo) & ~UNiagaraComponent.__PropertyMask_bForceSolo) | (value ? UNiagaraComponent.__PropertyMask_bForceSolo : 0));
			}
		}

		// Token: 0x17008814 RID: 34836
		// (get) Token: 0x0602367F RID: 145023 RVA: 0x00345B93 File Offset: 0x00343D93
		// (set) Token: 0x06023680 RID: 145024 RVA: 0x00345BAC File Offset: 0x00343DAC
		public unsafe bool bEnableGpuComputeDebug
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bEnableGpuComputeDebug) & UNiagaraComponent.__PropertyMask_bEnableGpuComputeDebug) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bEnableGpuComputeDebug) = ((*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bEnableGpuComputeDebug) & ~UNiagaraComponent.__PropertyMask_bEnableGpuComputeDebug) | (value ? UNiagaraComponent.__PropertyMask_bEnableGpuComputeDebug : 0));
			}
		}

		// Token: 0x17008815 RID: 34837
		// (get) Token: 0x06023681 RID: 145025 RVA: 0x00345BDC File Offset: 0x00343DDC
		// (set) Token: 0x06023682 RID: 145026 RVA: 0x00345BEC File Offset: 0x00343DEC
		public unsafe float DesiredAgeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_DesiredAgeOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_DesiredAgeOverride) = value;
			}
		}

		// Token: 0x17008816 RID: 34838
		// (get) Token: 0x06023683 RID: 145027 RVA: 0x00345BFD File Offset: 0x00343DFD
		// (set) Token: 0x06023684 RID: 145028 RVA: 0x00345C16 File Offset: 0x00343E16
		public unsafe bool bAutoDestroy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoDestroy) & UNiagaraComponent.__PropertyMask_bAutoDestroy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoDestroy) = ((*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoDestroy) & ~UNiagaraComponent.__PropertyMask_bAutoDestroy) | (value ? UNiagaraComponent.__PropertyMask_bAutoDestroy : 0));
			}
		}

		// Token: 0x17008817 RID: 34839
		// (get) Token: 0x06023685 RID: 145029 RVA: 0x00345C46 File Offset: 0x00343E46
		// (set) Token: 0x06023686 RID: 145030 RVA: 0x00345C5F File Offset: 0x00343E5F
		public unsafe bool bRenderingEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bRenderingEnabled) & UNiagaraComponent.__PropertyMask_bRenderingEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bRenderingEnabled) = ((*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bRenderingEnabled) & ~UNiagaraComponent.__PropertyMask_bRenderingEnabled) | (value ? UNiagaraComponent.__PropertyMask_bRenderingEnabled : 0));
			}
		}

		// Token: 0x17008818 RID: 34840
		// (get) Token: 0x06023687 RID: 145031 RVA: 0x00345C8F File Offset: 0x00343E8F
		// (set) Token: 0x06023688 RID: 145032 RVA: 0x00345CA3 File Offset: 0x00343EA3
		[Nullable(2)]
		public unsafe UNiagaraEffectType RuntimeEffectType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEffectType>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraComponent.__PropertyOffset_RuntimeEffectType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraComponent.__PropertyOffset_RuntimeEffectType, value);
			}
		}

		// Token: 0x17008819 RID: 34841
		// (get) Token: 0x06023689 RID: 145033 RVA: 0x00345CB8 File Offset: 0x00343EB8
		// (set) Token: 0x0602368A RID: 145034 RVA: 0x00345CD1 File Offset: 0x00343ED1
		public unsafe bool bAutoManageAttachment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoManageAttachment) & UNiagaraComponent.__PropertyMask_bAutoManageAttachment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoManageAttachment) = ((*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoManageAttachment) & ~UNiagaraComponent.__PropertyMask_bAutoManageAttachment) | (value ? UNiagaraComponent.__PropertyMask_bAutoManageAttachment : 0));
			}
		}

		// Token: 0x1700881A RID: 34842
		// (get) Token: 0x0602368B RID: 145035 RVA: 0x00345D01 File Offset: 0x00343F01
		// (set) Token: 0x0602368C RID: 145036 RVA: 0x00345D1A File Offset: 0x00343F1A
		public unsafe bool bAutoAttachWeldSimulatedBodies
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoAttachWeldSimulatedBodies) & UNiagaraComponent.__PropertyMask_bAutoAttachWeldSimulatedBodies) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoAttachWeldSimulatedBodies) = ((*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAutoAttachWeldSimulatedBodies) & ~UNiagaraComponent.__PropertyMask_bAutoAttachWeldSimulatedBodies) | (value ? UNiagaraComponent.__PropertyMask_bAutoAttachWeldSimulatedBodies : 0));
			}
		}

		// Token: 0x1700881B RID: 34843
		// (get) Token: 0x0602368D RID: 145037 RVA: 0x00345D4A File Offset: 0x00343F4A
		// (set) Token: 0x0602368E RID: 145038 RVA: 0x00345D5A File Offset: 0x00343F5A
		public unsafe float MaxTimeBeforeForceUpdateTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_MaxTimeBeforeForceUpdateTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_MaxTimeBeforeForceUpdateTransform) = value;
			}
		}

		// Token: 0x1700881C RID: 34844
		// (get) Token: 0x0602368F RID: 145039 RVA: 0x00345D6B File Offset: 0x00343F6B
		// (set) Token: 0x06023690 RID: 145040 RVA: 0x00345D7B File Offset: 0x00343F7B
		public unsafe int NiagaraEffectType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_NiagaraEffectType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_NiagaraEffectType) = value;
			}
		}

		// Token: 0x1700881D RID: 34845
		// (get) Token: 0x06023691 RID: 145041 RVA: 0x00345D8C File Offset: 0x00343F8C
		// (set) Token: 0x06023692 RID: 145042 RVA: 0x00345DC5 File Offset: 0x00343FC5
		public TArray<FNiagaraMaterialOverride> EmitterMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraMaterialOverride> result;
				if ((result = this._EmitterMaterials) == null)
				{
					result = (this._EmitterMaterials = new TArray<FNiagaraMaterialOverride>(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_EmitterMaterials, this));
				}
				return result;
			}
			set
			{
				this.EmitterMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700881E RID: 34846
		// (get) Token: 0x06023693 RID: 145043 RVA: 0x00345DD3 File Offset: 0x00343FD3
		// (set) Token: 0x06023694 RID: 145044 RVA: 0x00345DE3 File Offset: 0x00343FE3
		public unsafe float KuroGlobalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_KuroGlobalScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_KuroGlobalScale) = value;
			}
		}

		// Token: 0x1700881F RID: 34847
		// (get) Token: 0x06023695 RID: 145045 RVA: 0x00345DF4 File Offset: 0x00343FF4
		// (set) Token: 0x06023696 RID: 145046 RVA: 0x00345E08 File Offset: 0x00344008
		public unsafe FLinearColor KuroGlobalColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_KuroGlobalColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_KuroGlobalColor) = value;
			}
		}

		// Token: 0x17008820 RID: 34848
		// (get) Token: 0x06023697 RID: 145047 RVA: 0x00345E1D File Offset: 0x0034401D
		// (set) Token: 0x06023698 RID: 145048 RVA: 0x00345E2D File Offset: 0x0034402D
		public unsafe float KuroGlobalAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_KuroGlobalAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_KuroGlobalAlpha) = value;
			}
		}

		// Token: 0x17008821 RID: 34849
		// (get) Token: 0x06023699 RID: 145049 RVA: 0x00345E3E File Offset: 0x0034403E
		// (set) Token: 0x0602369A RID: 145050 RVA: 0x00345E57 File Offset: 0x00344057
		public unsafe bool bAllowOcclusionCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAllowOcclusionCulling) & UNiagaraComponent.__PropertyMask_bAllowOcclusionCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAllowOcclusionCulling) = ((*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAllowOcclusionCulling) & ~UNiagaraComponent.__PropertyMask_bAllowOcclusionCulling) | (value ? UNiagaraComponent.__PropertyMask_bAllowOcclusionCulling : 0));
			}
		}

		// Token: 0x17008822 RID: 34850
		// (get) Token: 0x0602369B RID: 145051 RVA: 0x00345E88 File Offset: 0x00344088
		// (set) Token: 0x0602369C RID: 145052 RVA: 0x00345EC1 File Offset: 0x003440C1
		public FOnSystemInstancePaused OnSystemInstancePausedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnSystemInstancePaused result;
				if ((result = this._OnSystemInstancePausedDelegate) == null)
				{
					result = (this._OnSystemInstancePausedDelegate = new FOnSystemInstancePaused(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_OnSystemInstancePausedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_OnSystemInstancePausedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008823 RID: 34851
		// (get) Token: 0x0602369D RID: 145053 RVA: 0x00345EE4 File Offset: 0x003440E4
		// (set) Token: 0x0602369E RID: 145054 RVA: 0x00345F1D File Offset: 0x0034411D
		public FOnNiagaraSystemFinished OnSystemFinished
		{
			get
			{
				base.FastCheckIsValid();
				FOnNiagaraSystemFinished result;
				if ((result = this._OnSystemFinished) == null)
				{
					result = (this._OnSystemFinished = new FOnNiagaraSystemFinished(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_OnSystemFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_OnSystemFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008824 RID: 34852
		// (get) Token: 0x0602369F RID: 145055 RVA: 0x00345F3E File Offset: 0x0034413E
		// (set) Token: 0x060236A0 RID: 145056 RVA: 0x00345F52 File Offset: 0x00344152
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USceneComponent> AutoAttachParent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachParent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachParent) = value;
			}
		}

		// Token: 0x17008825 RID: 34853
		// (get) Token: 0x060236A1 RID: 145057 RVA: 0x00345F67 File Offset: 0x00344167
		// (set) Token: 0x060236A2 RID: 145058 RVA: 0x00345F7B File Offset: 0x0034417B
		public unsafe FName AutoAttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachSocketName) = value;
			}
		}

		// Token: 0x17008826 RID: 34854
		// (get) Token: 0x060236A3 RID: 145059 RVA: 0x00345F90 File Offset: 0x00344190
		// (set) Token: 0x060236A4 RID: 145060 RVA: 0x00345FA0 File Offset: 0x003441A0
		public unsafe EAttachmentRule AutoAttachLocationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachLocationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachLocationRule) = (byte)value;
			}
		}

		// Token: 0x17008827 RID: 34855
		// (get) Token: 0x060236A5 RID: 145061 RVA: 0x00345FB1 File Offset: 0x003441B1
		// (set) Token: 0x060236A6 RID: 145062 RVA: 0x00345FC1 File Offset: 0x003441C1
		public unsafe EAttachmentRule AutoAttachRotationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachRotationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachRotationRule) = (byte)value;
			}
		}

		// Token: 0x17008828 RID: 34856
		// (get) Token: 0x060236A7 RID: 145063 RVA: 0x00345FD2 File Offset: 0x003441D2
		// (set) Token: 0x060236A8 RID: 145064 RVA: 0x00345FE2 File Offset: 0x003441E2
		public unsafe EAttachmentRule AutoAttachScaleRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachScaleRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_AutoAttachScaleRule) = (byte)value;
			}
		}

		// Token: 0x060236A9 RID: 145065 RVA: 0x00345FF3 File Offset: 0x003441F3
		public void SetVisibleInRayTracing(bool NewValue)
		{
			UNiagaraComponent.__SetVisibleInRayTracing_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060236AA RID: 145066 RVA: 0x00346004 File Offset: 0x00344204
		public unsafe void SetVariableVec4(FName InVariableName, in FVector4 InValue)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetVariableVec4_Internal(base.NativePtr, InVariableName, ptr);
		}

		// Token: 0x060236AB RID: 145067 RVA: 0x0034603A File Offset: 0x0034423A
		public void SetVariableVec3(FName InVariableName, FVector InValue)
		{
			UNiagaraComponent.__SetVariableVec3_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x060236AC RID: 145068 RVA: 0x00346049 File Offset: 0x00344249
		public void SetVariableVec2(FName InVariableName, FVector2D InValue)
		{
			UNiagaraComponent.__SetVariableVec2_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x060236AD RID: 145069 RVA: 0x00346058 File Offset: 0x00344258
		[NullableContext(2)]
		public void SetVariableTypedObject(FName InVariableName, UClassStackOnlyPtr TypeClass, UObject Object)
		{
			UNiagaraComponent.__SetVariableTypedObject_Internal(base.NativePtr, InVariableName, TypeClass._NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236AE RID: 145070 RVA: 0x0034607C File Offset: 0x0034427C
		[NullableContext(2)]
		public void SetVariableTextureRenderTarget(FName InVariableName, UTextureRenderTarget TextureRenderTarget)
		{
			UNiagaraComponent.__SetVariableTextureRenderTarget_Internal(base.NativePtr, InVariableName, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236AF RID: 145071 RVA: 0x0034609C File Offset: 0x0034429C
		public unsafe void SetVariableQuat(FName InVariableName, in FQuat InValue)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetVariableQuat_Internal(base.NativePtr, InVariableName, ptr);
		}

		// Token: 0x060236B0 RID: 145072 RVA: 0x003460D2 File Offset: 0x003442D2
		[NullableContext(2)]
		public void SetVariableObject(FName InVariableName, UObject Object)
		{
			UNiagaraComponent.__SetVariableObject_Internal(base.NativePtr, InVariableName, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236B1 RID: 145073 RVA: 0x003460F0 File Offset: 0x003442F0
		[NullableContext(2)]
		public void SetVariableMaterial(FName InVariableName, UMaterialInterface Object)
		{
			UNiagaraComponent.__SetVariableMaterial_Internal(base.NativePtr, InVariableName, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236B2 RID: 145074 RVA: 0x0034610E File Offset: 0x0034430E
		public void SetVariableLinearColor(FName InVariableName, in FLinearColor InValue)
		{
			UNiagaraComponent.__SetVariableLinearColor_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x060236B3 RID: 145075 RVA: 0x0034611D File Offset: 0x0034431D
		public void SetVariableInt(FName InVariableName, int InValue)
		{
			UNiagaraComponent.__SetVariableInt_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x060236B4 RID: 145076 RVA: 0x0034612C File Offset: 0x0034432C
		public void SetVariableFloat(FName InVariableName, float InValue)
		{
			UNiagaraComponent.__SetVariableFloat_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x060236B5 RID: 145077 RVA: 0x0034613B File Offset: 0x0034433B
		public void SetVariableBool(FName InVariableName, bool InValue)
		{
			UNiagaraComponent.__SetVariableBool_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x060236B6 RID: 145078 RVA: 0x0034614A File Offset: 0x0034434A
		[NullableContext(2)]
		public void SetVariableActor(FName InVariableName, AActor Actor)
		{
			UNiagaraComponent.__SetVariableActor_Internal(base.NativePtr, InVariableName, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236B7 RID: 145079 RVA: 0x00346168 File Offset: 0x00344368
		public void SetTickTimeDilation(float InTimeDilation)
		{
			UNiagaraComponent.__SetTickTimeDilation_Internal(base.NativePtr, InTimeDilation);
		}

		// Token: 0x060236B8 RID: 145080 RVA: 0x00346176 File Offset: 0x00344376
		public void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior)
		{
			UNiagaraComponent.__SetTickBehavior_Internal(base.NativePtr, NewTickBehavior);
		}

		// Token: 0x060236B9 RID: 145081 RVA: 0x00346184 File Offset: 0x00344384
		public void SetSeekDelta(float InSeekDelta)
		{
			UNiagaraComponent.__SetSeekDelta_Internal(base.NativePtr, InSeekDelta);
		}

		// Token: 0x060236BA RID: 145082 RVA: 0x00346192 File Offset: 0x00344392
		[NullableContext(2)]
		public void SetRuntimeEffectType(UNiagaraEffectType EffectType)
		{
			UNiagaraComponent.__SetRuntimeEffectType_Internal(base.NativePtr, (EffectType != null) ? EffectType.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236BB RID: 145083 RVA: 0x003461AF File Offset: 0x003443AF
		public void SetRenderingEnabled(bool bInRenderingEnabled)
		{
			UNiagaraComponent.__SetRenderingEnabled_Internal(base.NativePtr, bInRenderingEnabled);
		}

		// Token: 0x060236BC RID: 145084 RVA: 0x003461BD File Offset: 0x003443BD
		public void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance)
		{
			UNiagaraComponent.__SetPreviewLODDistance_Internal(base.NativePtr, bEnablePreviewLODDistance, PreviewLODDistance);
		}

		// Token: 0x060236BD RID: 145085 RVA: 0x003461CC File Offset: 0x003443CC
		public void SetPaused(bool bInPaused, bool bNotify = true)
		{
			UNiagaraComponent.__SetPaused_Internal(base.NativePtr, bInPaused, bNotify);
		}

		// Token: 0x060236BE RID: 145086 RVA: 0x003461DC File Offset: 0x003443DC
		public unsafe void SetNiagaraVariableVec4(string InVariableName, in FVector4 InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetNiagaraVariableVec4_Internal(base.NativePtr, fstring, ptr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236BF RID: 145087 RVA: 0x00346224 File Offset: 0x00344424
		public unsafe void SetNiagaraVariableVec3(string InVariableName, FVector InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableVec3_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C0 RID: 145088 RVA: 0x00346250 File Offset: 0x00344450
		public unsafe void SetNiagaraVariableVec2(string InVariableName, FVector2D InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableVec2_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C1 RID: 145089 RVA: 0x0034627C File Offset: 0x0034447C
		public unsafe void SetNiagaraVariableQuat(string InVariableName, in FQuat InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetNiagaraVariableQuat_Internal(base.NativePtr, fstring, ptr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C2 RID: 145090 RVA: 0x003462C4 File Offset: 0x003444C4
		public unsafe void SetNiagaraVariableObject(string InVariableName, [Nullable(2)] UObject Object)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableObject_Internal(base.NativePtr, fstring, (Object != null) ? Object.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C3 RID: 145091 RVA: 0x00346300 File Offset: 0x00344500
		public unsafe void SetNiagaraVariableLinearColor(string InVariableName, in FLinearColor InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableLinearColor_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C4 RID: 145092 RVA: 0x0034632C File Offset: 0x0034452C
		public unsafe void SetNiagaraVariableInt(string InVariableName, int InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableInt_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C5 RID: 145093 RVA: 0x00346358 File Offset: 0x00344558
		public unsafe void SetNiagaraVariableFloat(string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableFloat_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C6 RID: 145094 RVA: 0x00346384 File Offset: 0x00344584
		public unsafe void SetNiagaraVariableBool(string InVariableName, bool InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableBool_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C7 RID: 145095 RVA: 0x003463B0 File Offset: 0x003445B0
		public unsafe void SetNiagaraVariableActor(string InVariableName, [Nullable(2)] AActor Actor)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableActor_Internal(base.NativePtr, fstring, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060236C8 RID: 145096 RVA: 0x003463EA File Offset: 0x003445EA
		public void SetMaxSimTime(float InMaxTime)
		{
			UNiagaraComponent.__SetMaxSimTime_Internal(base.NativePtr, InMaxTime);
		}

		// Token: 0x060236C9 RID: 145097 RVA: 0x003463F8 File Offset: 0x003445F8
		public void SetMaterialUseLocalTime(bool InUseLocalTime)
		{
			UNiagaraComponent.__SetMaterialUseLocalTime_Internal(base.NativePtr, InUseLocalTime);
		}

		// Token: 0x060236CA RID: 145098 RVA: 0x00346406 File Offset: 0x00344606
		public void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock)
		{
			UNiagaraComponent.__SetLockDesiredAgeDeltaTimeToSeekDelta_Internal(base.NativePtr, bLock);
		}

		// Token: 0x060236CB RID: 145099 RVA: 0x00346414 File Offset: 0x00344614
		public unsafe void SetKuroNiagaraEmitterVectorParam(string InEmitterName, string InVariableName, FVector4 InVector)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InVector;
			UNiagaraComponent.__SetKuroNiagaraEmitterVectorParam_Internal(base.NativePtr, fstring, fstring2, ptr);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060236CC RID: 145100 RVA: 0x00346468 File Offset: 0x00344668
		public unsafe void SetKuroNiagaraEmitterFloatParam(string InEmitterName, string InVariableName, float Value)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetKuroNiagaraEmitterFloatParam_Internal(base.NativePtr, fstring, fstring2, Value);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060236CD RID: 145101 RVA: 0x003464A8 File Offset: 0x003446A8
		public unsafe void SetKuroNiagaraEmitterCustomTexture(string InEmitterName, string InVariableName, [Nullable(2)] UTexture Texture)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetKuroNiagaraEmitterCustomTexture_Internal(base.NativePtr, fstring, fstring2, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060236CE RID: 145102 RVA: 0x003464F4 File Offset: 0x003446F4
		public unsafe void SetKuroMaterialVectorParametre(FName InVariableName, ref FLinearColor vec)
		{
			fixed (FLinearColor* ptr = &vec)
			{
				void* ptr2 = (void*)ptr;
				UNiagaraComponent.__SetKuroMaterialVectorParametre_Internal(base.NativePtr, InVariableName, ref vec);
			}
		}

		// Token: 0x060236CF RID: 145103 RVA: 0x00346516 File Offset: 0x00344716
		public void SetKuroMaterialScalarParametre(FName InVariableName, float val)
		{
			UNiagaraComponent.__SetKuroMaterialScalarParametre_Internal(base.NativePtr, InVariableName, val);
		}

		// Token: 0x060236D0 RID: 145104 RVA: 0x00346525 File Offset: 0x00344725
		[NullableContext(2)]
		public void SetKuroMaterial(FName InEmitterName, UMaterialInterface Mat)
		{
			UNiagaraComponent.__SetKuroMaterial_Internal(base.NativePtr, InEmitterName, (Mat != null) ? Mat.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236D1 RID: 145105 RVA: 0x00346543 File Offset: 0x00344743
		[NullableContext(2)]
		public void SetKuroCustomTexture(FName InVariableName, UTexture Texture)
		{
			UNiagaraComponent.__SetKuroCustomTexture_Internal(base.NativePtr, InVariableName, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060236D2 RID: 145106 RVA: 0x00346561 File Offset: 0x00344761
		public void SetGpuComputeDebug(bool bEnableDebug)
		{
			UNiagaraComponent.__SetGpuComputeDebug_Internal(base.NativePtr, bEnableDebug);
		}

		// Token: 0x060236D3 RID: 145107 RVA: 0x0034656F File Offset: 0x0034476F
		public void SetForceSolo(bool bInForceSolo)
		{
			UNiagaraComponent.__SetForceSolo_Internal(base.NativePtr, bInForceSolo);
		}

		// Token: 0x060236D4 RID: 145108 RVA: 0x0034657D File Offset: 0x0034477D
		public void SetEmitterQualityLevelBias(int InBias)
		{
			UNiagaraComponent.__SetEmitterQualityLevelBias_Internal(base.NativePtr, InBias);
		}

		// Token: 0x060236D5 RID: 145109 RVA: 0x0034658B File Offset: 0x0034478B
		public void SetDesiredAgeOverride(float InDesiredAgeOverride)
		{
			UNiagaraComponent.__SetDesiredAgeOverride_Internal(base.NativePtr, InDesiredAgeOverride);
		}

		// Token: 0x060236D6 RID: 145110 RVA: 0x00346599 File Offset: 0x00344799
		public void SetDesiredAge(float InDesiredAge)
		{
			UNiagaraComponent.__SetDesiredAge_Internal(base.NativePtr, InDesiredAge);
		}

		// Token: 0x060236D7 RID: 145111 RVA: 0x003465A7 File Offset: 0x003447A7
		public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking)
		{
			UNiagaraComponent.__SetCanRenderWhileSeeking_Internal(base.NativePtr, bInCanRenderWhileSeeking);
		}

		// Token: 0x060236D8 RID: 145112 RVA: 0x003465B5 File Offset: 0x003447B5
		public void SetAutoDestroy(bool bInAutoDestroy)
		{
			UNiagaraComponent.__SetAutoDestroy_Internal(base.NativePtr, bInAutoDestroy);
		}

		// Token: 0x060236D9 RID: 145113 RVA: 0x003465C3 File Offset: 0x003447C3
		[NullableContext(2)]
		public void SetAsset(UNiagaraSystem InAsset, bool bResetExistingOverrideParameters = true)
		{
			UNiagaraComponent.__SetAsset_Internal(base.NativePtr, (InAsset != null) ? InAsset.NativePtr : IntPtr.Zero, bResetExistingOverrideParameters);
		}

		// Token: 0x060236DA RID: 145114 RVA: 0x003465E1 File Offset: 0x003447E1
		public void SetAllowScalability(bool bAllow)
		{
			UNiagaraComponent.__SetAllowScalability_Internal(base.NativePtr, bAllow);
		}

		// Token: 0x060236DB RID: 145115 RVA: 0x003465EF File Offset: 0x003447EF
		public void SetAllowOcclusionCulling(bool bInAllowOcclusionCulling)
		{
			UNiagaraComponent.__SetAllowOcclusionCulling_Internal(base.NativePtr, bInAllowOcclusionCulling);
		}

		// Token: 0x060236DC RID: 145116 RVA: 0x003465FD File Offset: 0x003447FD
		public void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode)
		{
			UNiagaraComponent.__SetAgeUpdateMode_Internal(base.NativePtr, InAgeUpdateMode);
		}

		// Token: 0x060236DD RID: 145117 RVA: 0x0034660B File Offset: 0x0034480B
		public void SeekToDesiredAge(float InDesiredAge)
		{
			UNiagaraComponent.__SeekToDesiredAge_Internal(base.NativePtr, InDesiredAge);
		}

		// Token: 0x060236DE RID: 145118 RVA: 0x00346619 File Offset: 0x00344819
		public void ResetSystem()
		{
			UNiagaraComponent.__ResetSystem_Internal(base.NativePtr);
		}

		// Token: 0x060236DF RID: 145119 RVA: 0x00346628 File Offset: 0x00344828
		public unsafe bool ResetOverrideParametersAndActivate(bool bReset = true, string ExceptOverrideName = "")
		{
			FString fstring = FString.AllocTemp(ExceptOverrideName);
			bool result = UNiagaraComponent.__ResetOverrideParametersAndActivate_Internal(base.NativePtr, bReset, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060236E0 RID: 145120 RVA: 0x00346653 File Offset: 0x00344853
		public void ReinitializeSystem()
		{
			UNiagaraComponent.__ReinitializeSystem_Internal(base.NativePtr);
		}

		// Token: 0x060236E1 RID: 145121 RVA: 0x00346660 File Offset: 0x00344860
		public bool IsPaused()
		{
			return UNiagaraComponent.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x060236E2 RID: 145122 RVA: 0x0034666D File Offset: 0x0034486D
		public bool HasSkeletalMeshDataInterface()
		{
			return UNiagaraComponent.__HasSkeletalMeshDataInterface_Internal(base.NativePtr);
		}

		// Token: 0x060236E3 RID: 145123 RVA: 0x0034667A File Offset: 0x0034487A
		public bool HasDataInterface(UClassStackOnlyPtr DataInterfaceClass)
		{
			return UNiagaraComponent.__HasDataInterface_Internal(base.NativePtr, DataInterfaceClass._NativePtr);
		}

		// Token: 0x060236E4 RID: 145124 RVA: 0x0034668D File Offset: 0x0034488D
		public bool HasAnyEmittersComplete()
		{
			return UNiagaraComponent.__HasAnyEmittersComplete_Internal(base.NativePtr);
		}

		// Token: 0x060236E5 RID: 145125 RVA: 0x0034669A File Offset: 0x0034489A
		public ENiagaraTickBehavior GetTickBehavior()
		{
			return UNiagaraComponent.__GetTickBehavior_Internal(base.NativePtr);
		}

		// Token: 0x060236E6 RID: 145126 RVA: 0x003466A7 File Offset: 0x003448A7
		public float GetSeekDelta()
		{
			return UNiagaraComponent.__GetSeekDelta_Internal(base.NativePtr);
		}

		// Token: 0x060236E7 RID: 145127 RVA: 0x003466B4 File Offset: 0x003448B4
		[NullableContext(2)]
		public UNiagaraEffectType GetRuntimeEffectType()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraEffectType>(UNiagaraComponent.__GetRuntimeEffectType_Internal(base.NativePtr));
		}

		// Token: 0x060236E8 RID: 145128 RVA: 0x003466C6 File Offset: 0x003448C6
		public bool GetPreviewLODDistanceEnabled()
		{
			return UNiagaraComponent.__GetPreviewLODDistanceEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060236E9 RID: 145129 RVA: 0x003466D3 File Offset: 0x003448D3
		public int GetPreviewLODDistance()
		{
			return UNiagaraComponent.__GetPreviewLODDistance_Internal(base.NativePtr);
		}

		// Token: 0x060236EA RID: 145130 RVA: 0x003466E0 File Offset: 0x003448E0
		public unsafe TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(string InEmitterName, string InValueName)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InValueName);
			TArray<FVector> result = new TArray<FVector>(UNiagaraComponent.__GetNiagaraParticleValueVec3_DebugOnly_Internal(base.NativePtr, fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060236EB RID: 145131 RVA: 0x00346724 File Offset: 0x00344924
		public unsafe TArray<float> GetNiagaraParticleValues_DebugOnly(string InEmitterName, string InValueName)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InValueName);
			TArray<float> result = new TArray<float>(UNiagaraComponent.__GetNiagaraParticleValues_DebugOnly_Internal(base.NativePtr, fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060236EC RID: 145132 RVA: 0x00346768 File Offset: 0x00344968
		public unsafe TArray<FVector> GetNiagaraParticlePositions_DebugOnly(string InEmitterName)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			TArray<FVector> result = new TArray<FVector>(UNiagaraComponent.__GetNiagaraParticlePositions_DebugOnly_Internal(base.NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060236ED RID: 145133 RVA: 0x00346798 File Offset: 0x00344998
		public float GetMaxSimTime()
		{
			return UNiagaraComponent.__GetMaxSimTime_Internal(base.NativePtr);
		}

		// Token: 0x060236EE RID: 145134 RVA: 0x003467A5 File Offset: 0x003449A5
		public bool GetLockDesiredAgeDeltaTimeToSeekDelta()
		{
			return UNiagaraComponent.__GetLockDesiredAgeDeltaTimeToSeekDelta_Internal(base.NativePtr);
		}

		// Token: 0x060236EF RID: 145135 RVA: 0x003467B2 File Offset: 0x003449B2
		public bool GetForceSolo()
		{
			return UNiagaraComponent.__GetForceSolo_Internal(base.NativePtr);
		}

		// Token: 0x060236F0 RID: 145136 RVA: 0x003467BF File Offset: 0x003449BF
		public float GetDesiredAgeOverride()
		{
			return UNiagaraComponent.__GetDesiredAgeOverride_Internal(base.NativePtr);
		}

		// Token: 0x060236F1 RID: 145137 RVA: 0x003467CC File Offset: 0x003449CC
		public float GetDesiredAge()
		{
			return UNiagaraComponent.__GetDesiredAge_Internal(base.NativePtr);
		}

		// Token: 0x060236F2 RID: 145138 RVA: 0x003467DC File Offset: 0x003449DC
		[return: Nullable(2)]
		public unsafe UNiagaraDataInterface GetDataInterface(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			UNiagaraDataInterface orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraDataInterface>(UNiagaraComponent.__GetDataInterface_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060236F3 RID: 145139 RVA: 0x0034680B File Offset: 0x00344A0B
		[NullableContext(2)]
		public UNiagaraSystem GetAsset()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraSystem>(UNiagaraComponent.__GetAsset_Internal(base.NativePtr));
		}

		// Token: 0x060236F4 RID: 145140 RVA: 0x0034681D File Offset: 0x00344A1D
		public ENiagaraAgeUpdateMode GetAgeUpdateMode()
		{
			return UNiagaraComponent.__GetAgeUpdateMode_Internal(base.NativePtr);
		}

		// Token: 0x060236F5 RID: 145141 RVA: 0x0034682A File Offset: 0x00344A2A
		[NullableContext(2)]
		public UNiagaraEffectType GetActualEffectType()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraEffectType>(UNiagaraComponent.__GetActualEffectType_Internal(base.NativePtr));
		}

		// Token: 0x060236F6 RID: 145142 RVA: 0x0034683C File Offset: 0x00344A3C
		public void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds)
		{
			UNiagaraComponent.__AdvanceSimulationByTime_Internal(base.NativePtr, SimulateTime, TickDeltaSeconds);
		}

		// Token: 0x060236F7 RID: 145143 RVA: 0x0034684B File Offset: 0x00344A4B
		public void AdvanceSimulation(int TickCount, float TickDeltaSeconds)
		{
			UNiagaraComponent.__AdvanceSimulation_Internal(base.NativePtr, TickCount, TickDeltaSeconds);
		}

		// Token: 0x060236F8 RID: 145144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisibleInRayTracing_Internal(IntPtr @this, bool NewValue);

		// Token: 0x060236F9 RID: 145145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableVec4_Internal(IntPtr @this, FName InVariableName, in FVector4 InValue);

		// Token: 0x060236FA RID: 145146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableVec3_Internal(IntPtr @this, FName InVariableName, FVector InValue);

		// Token: 0x060236FB RID: 145147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableVec2_Internal(IntPtr @this, FName InVariableName, FVector2D InValue);

		// Token: 0x060236FC RID: 145148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableTypedObject_Internal(IntPtr @this, FName InVariableName, IntPtr TypeClass, IntPtr Object);

		// Token: 0x060236FD RID: 145149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableTextureRenderTarget_Internal(IntPtr @this, FName InVariableName, IntPtr TextureRenderTarget);

		// Token: 0x060236FE RID: 145150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableQuat_Internal(IntPtr @this, FName InVariableName, in FQuat InValue);

		// Token: 0x060236FF RID: 145151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableObject_Internal(IntPtr @this, FName InVariableName, IntPtr Object);

		// Token: 0x06023700 RID: 145152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableMaterial_Internal(IntPtr @this, FName InVariableName, IntPtr Object);

		// Token: 0x06023701 RID: 145153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableLinearColor_Internal(IntPtr @this, FName InVariableName, in FLinearColor InValue);

		// Token: 0x06023702 RID: 145154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableInt_Internal(IntPtr @this, FName InVariableName, int InValue);

		// Token: 0x06023703 RID: 145155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableFloat_Internal(IntPtr @this, FName InVariableName, float InValue);

		// Token: 0x06023704 RID: 145156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableBool_Internal(IntPtr @this, FName InVariableName, bool InValue);

		// Token: 0x06023705 RID: 145157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableActor_Internal(IntPtr @this, FName InVariableName, IntPtr Actor);

		// Token: 0x06023706 RID: 145158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickTimeDilation_Internal(IntPtr @this, float InTimeDilation);

		// Token: 0x06023707 RID: 145159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickBehavior_Internal(IntPtr @this, ENiagaraTickBehavior NewTickBehavior);

		// Token: 0x06023708 RID: 145160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeekDelta_Internal(IntPtr @this, float InSeekDelta);

		// Token: 0x06023709 RID: 145161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRuntimeEffectType_Internal(IntPtr @this, IntPtr EffectType);

		// Token: 0x0602370A RID: 145162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderingEnabled_Internal(IntPtr @this, bool bInRenderingEnabled);

		// Token: 0x0602370B RID: 145163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreviewLODDistance_Internal(IntPtr @this, bool bEnablePreviewLODDistance, float PreviewLODDistance);

		// Token: 0x0602370C RID: 145164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPaused_Internal(IntPtr @this, bool bInPaused, bool bNotify);

		// Token: 0x0602370D RID: 145165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableVec4_Internal(IntPtr @this, in FString InVariableName, in FVector4 InValue);

		// Token: 0x0602370E RID: 145166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableVec3_Internal(IntPtr @this, in FString InVariableName, FVector InValue);

		// Token: 0x0602370F RID: 145167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableVec2_Internal(IntPtr @this, in FString InVariableName, FVector2D InValue);

		// Token: 0x06023710 RID: 145168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableQuat_Internal(IntPtr @this, in FString InVariableName, in FQuat InValue);

		// Token: 0x06023711 RID: 145169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableObject_Internal(IntPtr @this, in FString InVariableName, IntPtr Object);

		// Token: 0x06023712 RID: 145170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableLinearColor_Internal(IntPtr @this, in FString InVariableName, in FLinearColor InValue);

		// Token: 0x06023713 RID: 145171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableInt_Internal(IntPtr @this, in FString InVariableName, int InValue);

		// Token: 0x06023714 RID: 145172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableFloat_Internal(IntPtr @this, in FString InVariableName, float InValue);

		// Token: 0x06023715 RID: 145173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableBool_Internal(IntPtr @this, in FString InVariableName, bool InValue);

		// Token: 0x06023716 RID: 145174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableActor_Internal(IntPtr @this, in FString InVariableName, IntPtr Actor);

		// Token: 0x06023717 RID: 145175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxSimTime_Internal(IntPtr @this, float InMaxTime);

		// Token: 0x06023718 RID: 145176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialUseLocalTime_Internal(IntPtr @this, bool InUseLocalTime);

		// Token: 0x06023719 RID: 145177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLockDesiredAgeDeltaTimeToSeekDelta_Internal(IntPtr @this, bool bLock);

		// Token: 0x0602371A RID: 145178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNiagaraEmitterVectorParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, in FVector4 InVector);

		// Token: 0x0602371B RID: 145179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNiagaraEmitterFloatParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, float Value);

		// Token: 0x0602371C RID: 145180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNiagaraEmitterCustomTexture_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, IntPtr Texture);

		// Token: 0x0602371D RID: 145181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMaterialVectorParametre_Internal(IntPtr @this, FName InVariableName, ref FLinearColor vec);

		// Token: 0x0602371E RID: 145182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMaterialScalarParametre_Internal(IntPtr @this, FName InVariableName, float val);

		// Token: 0x0602371F RID: 145183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMaterial_Internal(IntPtr @this, FName InEmitterName, IntPtr Mat);

		// Token: 0x06023720 RID: 145184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCustomTexture_Internal(IntPtr @this, FName InVariableName, IntPtr Texture);

		// Token: 0x06023721 RID: 145185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGpuComputeDebug_Internal(IntPtr @this, bool bEnableDebug);

		// Token: 0x06023722 RID: 145186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceSolo_Internal(IntPtr @this, bool bInForceSolo);

		// Token: 0x06023723 RID: 145187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEmitterQualityLevelBias_Internal(IntPtr @this, int InBias);

		// Token: 0x06023724 RID: 145188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredAgeOverride_Internal(IntPtr @this, float InDesiredAgeOverride);

		// Token: 0x06023725 RID: 145189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredAge_Internal(IntPtr @this, float InDesiredAge);

		// Token: 0x06023726 RID: 145190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanRenderWhileSeeking_Internal(IntPtr @this, bool bInCanRenderWhileSeeking);

		// Token: 0x06023727 RID: 145191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoDestroy_Internal(IntPtr @this, bool bInAutoDestroy);

		// Token: 0x06023728 RID: 145192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAsset_Internal(IntPtr @this, IntPtr InAsset, bool bResetExistingOverrideParameters);

		// Token: 0x06023729 RID: 145193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowScalability_Internal(IntPtr @this, bool bAllow);

		// Token: 0x0602372A RID: 145194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowOcclusionCulling_Internal(IntPtr @this, bool bInAllowOcclusionCulling);

		// Token: 0x0602372B RID: 145195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAgeUpdateMode_Internal(IntPtr @this, ENiagaraAgeUpdateMode InAgeUpdateMode);

		// Token: 0x0602372C RID: 145196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekToDesiredAge_Internal(IntPtr @this, float InDesiredAge);

		// Token: 0x0602372D RID: 145197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetSystem_Internal(IntPtr @this);

		// Token: 0x0602372E RID: 145198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ResetOverrideParametersAndActivate_Internal(IntPtr @this, bool bReset, in FString ExceptOverrideName);

		// Token: 0x0602372F RID: 145199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReinitializeSystem_Internal(IntPtr @this);

		// Token: 0x06023730 RID: 145200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x06023731 RID: 145201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkeletalMeshDataInterface_Internal(IntPtr @this);

		// Token: 0x06023732 RID: 145202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasDataInterface_Internal(IntPtr @this, IntPtr DataInterfaceClass);

		// Token: 0x06023733 RID: 145203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyEmittersComplete_Internal(IntPtr @this);

		// Token: 0x06023734 RID: 145204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ENiagaraTickBehavior __GetTickBehavior_Internal(IntPtr @this);

		// Token: 0x06023735 RID: 145205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSeekDelta_Internal(IntPtr @this);

		// Token: 0x06023736 RID: 145206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRuntimeEffectType_Internal(IntPtr @this);

		// Token: 0x06023737 RID: 145207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPreviewLODDistanceEnabled_Internal(IntPtr @this);

		// Token: 0x06023738 RID: 145208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPreviewLODDistance_Internal(IntPtr @this);

		// Token: 0x06023739 RID: 145209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraParticleValueVec3_DebugOnly_Internal(IntPtr @this, in FString InEmitterName, in FString InValueName);

		// Token: 0x0602373A RID: 145210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraParticleValues_DebugOnly_Internal(IntPtr @this, in FString InEmitterName, in FString InValueName);

		// Token: 0x0602373B RID: 145211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraParticlePositions_DebugOnly_Internal(IntPtr @this, in FString InEmitterName);

		// Token: 0x0602373C RID: 145212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxSimTime_Internal(IntPtr @this);

		// Token: 0x0602373D RID: 145213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLockDesiredAgeDeltaTimeToSeekDelta_Internal(IntPtr @this);

		// Token: 0x0602373E RID: 145214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetForceSolo_Internal(IntPtr @this);

		// Token: 0x0602373F RID: 145215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDesiredAgeOverride_Internal(IntPtr @this);

		// Token: 0x06023740 RID: 145216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDesiredAge_Internal(IntPtr @this);

		// Token: 0x06023741 RID: 145217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDataInterface_Internal(IntPtr @this, in FString Name);

		// Token: 0x06023742 RID: 145218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAsset_Internal(IntPtr @this);

		// Token: 0x06023743 RID: 145219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ENiagaraAgeUpdateMode __GetAgeUpdateMode_Internal(IntPtr @this);

		// Token: 0x06023744 RID: 145220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActualEffectType_Internal(IntPtr @this);

		// Token: 0x06023745 RID: 145221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdvanceSimulationByTime_Internal(IntPtr @this, float SimulateTime, float TickDeltaSeconds);

		// Token: 0x06023746 RID: 145222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdvanceSimulation_Internal(IntPtr @this, int TickCount, float TickDeltaSeconds);

		// Token: 0x06023747 RID: 145223 RVA: 0x0034685A File Offset: 0x00344A5A
		static UNiagaraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraComponent");
		}

		// Token: 0x06023748 RID: 145224 RVA: 0x00346868 File Offset: 0x00344A68
		protected UNiagaraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012FFE RID: 77822
		public new const string __ObjectPath = "/Script/Niagara.NiagaraComponent";

		// Token: 0x04012FFF RID: 77823
		private static IntPtr _ClassPtr;

		// Token: 0x04013000 RID: 77824
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013001 RID: 77825
		internal static int __PropertyOffset_Asset;

		// Token: 0x04013002 RID: 77826
		internal static int __PropertyOffset_TickBehavior;

		// Token: 0x04013003 RID: 77827
		internal static int __PropertyOffset_OverrideParameters;

		// Token: 0x04013004 RID: 77828
		[Nullable(2)]
		private FNiagaraUserRedirectionParameterStore _OverrideParameters;

		// Token: 0x04013005 RID: 77829
		internal static int __PropertyOffset_bForceSolo;

		// Token: 0x04013006 RID: 77830
		internal static byte __PropertyMask_bForceSolo;

		// Token: 0x04013007 RID: 77831
		internal static int __PropertyOffset_bEnableGpuComputeDebug;

		// Token: 0x04013008 RID: 77832
		internal static byte __PropertyMask_bEnableGpuComputeDebug;

		// Token: 0x04013009 RID: 77833
		internal static int __PropertyOffset_DesiredAgeOverride;

		// Token: 0x0401300A RID: 77834
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x0401300B RID: 77835
		internal static byte __PropertyMask_bAutoDestroy;

		// Token: 0x0401300C RID: 77836
		internal static int __PropertyOffset_bRenderingEnabled;

		// Token: 0x0401300D RID: 77837
		internal static byte __PropertyMask_bRenderingEnabled;

		// Token: 0x0401300E RID: 77838
		internal static int __PropertyOffset_RuntimeEffectType;

		// Token: 0x0401300F RID: 77839
		internal static int __PropertyOffset_bAutoManageAttachment;

		// Token: 0x04013010 RID: 77840
		internal static byte __PropertyMask_bAutoManageAttachment;

		// Token: 0x04013011 RID: 77841
		internal static int __PropertyOffset_bAutoAttachWeldSimulatedBodies;

		// Token: 0x04013012 RID: 77842
		internal static byte __PropertyMask_bAutoAttachWeldSimulatedBodies;

		// Token: 0x04013013 RID: 77843
		internal static int __PropertyOffset_MaxTimeBeforeForceUpdateTransform;

		// Token: 0x04013014 RID: 77844
		internal static int __PropertyOffset_NiagaraEffectType;

		// Token: 0x04013015 RID: 77845
		internal static int __PropertyOffset_EmitterMaterials;

		// Token: 0x04013016 RID: 77846
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraMaterialOverride> _EmitterMaterials;

		// Token: 0x04013017 RID: 77847
		internal static int __PropertyOffset_KuroGlobalScale;

		// Token: 0x04013018 RID: 77848
		internal static int __PropertyOffset_KuroGlobalColor;

		// Token: 0x04013019 RID: 77849
		internal static int __PropertyOffset_KuroGlobalAlpha;

		// Token: 0x0401301A RID: 77850
		internal static int __PropertyOffset_bAllowOcclusionCulling;

		// Token: 0x0401301B RID: 77851
		internal static byte __PropertyMask_bAllowOcclusionCulling;

		// Token: 0x0401301C RID: 77852
		internal static int __PropertyOffset_OnSystemInstancePausedDelegate;

		// Token: 0x0401301D RID: 77853
		[Nullable(2)]
		private FOnSystemInstancePaused _OnSystemInstancePausedDelegate;

		// Token: 0x0401301E RID: 77854
		internal static int __PropertyOffset_OnSystemFinished;

		// Token: 0x0401301F RID: 77855
		[Nullable(2)]
		private FOnNiagaraSystemFinished _OnSystemFinished;

		// Token: 0x04013020 RID: 77856
		internal static int __PropertyOffset_AutoAttachParent;

		// Token: 0x04013021 RID: 77857
		internal static int __PropertyOffset_AutoAttachSocketName;

		// Token: 0x04013022 RID: 77858
		internal static int __PropertyOffset_AutoAttachLocationRule;

		// Token: 0x04013023 RID: 77859
		internal static int __PropertyOffset_AutoAttachRotationRule;

		// Token: 0x04013024 RID: 77860
		internal static int __PropertyOffset_AutoAttachScaleRule;
	}
}
