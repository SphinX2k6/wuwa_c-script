using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A1 RID: 1953
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraComponent")]
	[UnrealStructLayout(2512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2512)]
	public class UNiagaraComponent : UFXSystemComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A91D RID: 43293 RVA: 0x000F9E1B File Offset: 0x000F801B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraComponent._ClassPtr;
		}

		// Token: 0x0600A91E RID: 43294 RVA: 0x000F9E28 File Offset: 0x000F8028
		public UNiagaraComponent() : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x000F9E50 File Offset: 0x000F8050
		public UNiagaraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x0600A920 RID: 43296 RVA: 0x000F9E83 File Offset: 0x000F8083
		// (set) Token: 0x0600A921 RID: 43297 RVA: 0x000F9E97 File Offset: 0x000F8097
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

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x0600A922 RID: 43298 RVA: 0x000F9EAC File Offset: 0x000F80AC
		// (set) Token: 0x0600A923 RID: 43299 RVA: 0x000F9EC5 File Offset: 0x000F80C5
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

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x0600A924 RID: 43300 RVA: 0x000F9EF5 File Offset: 0x000F80F5
		// (set) Token: 0x0600A925 RID: 43301 RVA: 0x000F9F0E File Offset: 0x000F810E
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

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x000F9F3E File Offset: 0x000F813E
		// (set) Token: 0x0600A927 RID: 43303 RVA: 0x000F9F4E File Offset: 0x000F814E
		public unsafe bool bAllowSystemWarmup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAllowSystemWarmup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponent.__PropertyOffset_bAllowSystemWarmup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x0600A928 RID: 43304 RVA: 0x000F9F5F File Offset: 0x000F815F
		// (set) Token: 0x0600A929 RID: 43305 RVA: 0x000F9F6F File Offset: 0x000F816F
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

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600A92A RID: 43306 RVA: 0x000F9F80 File Offset: 0x000F8180
		// (set) Token: 0x0600A92B RID: 43307 RVA: 0x000F9F99 File Offset: 0x000F8199
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

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600A92C RID: 43308 RVA: 0x000F9FC9 File Offset: 0x000F81C9
		// (set) Token: 0x0600A92D RID: 43309 RVA: 0x000F9FE2 File Offset: 0x000F81E2
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

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x0600A92E RID: 43310 RVA: 0x000FA012 File Offset: 0x000F8212
		// (set) Token: 0x0600A92F RID: 43311 RVA: 0x000FA026 File Offset: 0x000F8226
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

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x0600A930 RID: 43312 RVA: 0x000FA03B File Offset: 0x000F823B
		// (set) Token: 0x0600A931 RID: 43313 RVA: 0x000FA054 File Offset: 0x000F8254
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

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x0600A932 RID: 43314 RVA: 0x000FA084 File Offset: 0x000F8284
		// (set) Token: 0x0600A933 RID: 43315 RVA: 0x000FA09D File Offset: 0x000F829D
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

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x0600A934 RID: 43316 RVA: 0x000FA0CD File Offset: 0x000F82CD
		// (set) Token: 0x0600A935 RID: 43317 RVA: 0x000FA0DD File Offset: 0x000F82DD
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

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x0600A936 RID: 43318 RVA: 0x000FA0EE File Offset: 0x000F82EE
		// (set) Token: 0x0600A937 RID: 43319 RVA: 0x000FA0FE File Offset: 0x000F82FE
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

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600A938 RID: 43320 RVA: 0x000FA10F File Offset: 0x000F830F
		// (set) Token: 0x0600A939 RID: 43321 RVA: 0x000FA11F File Offset: 0x000F831F
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

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x0600A93A RID: 43322 RVA: 0x000FA130 File Offset: 0x000F8330
		// (set) Token: 0x0600A93B RID: 43323 RVA: 0x000FA144 File Offset: 0x000F8344
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

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x0600A93C RID: 43324 RVA: 0x000FA159 File Offset: 0x000F8359
		// (set) Token: 0x0600A93D RID: 43325 RVA: 0x000FA169 File Offset: 0x000F8369
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

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x0600A93E RID: 43326 RVA: 0x000FA17A File Offset: 0x000F837A
		// (set) Token: 0x0600A93F RID: 43327 RVA: 0x000FA193 File Offset: 0x000F8393
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

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x0600A940 RID: 43328 RVA: 0x000FA1C4 File Offset: 0x000F83C4
		// (set) Token: 0x0600A941 RID: 43329 RVA: 0x000FA1FD File Offset: 0x000F83FD
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

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x0600A942 RID: 43330 RVA: 0x000FA220 File Offset: 0x000F8420
		// (set) Token: 0x0600A943 RID: 43331 RVA: 0x000FA259 File Offset: 0x000F8459
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

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x0600A944 RID: 43332 RVA: 0x000FA27A File Offset: 0x000F847A
		// (set) Token: 0x0600A945 RID: 43333 RVA: 0x000FA28E File Offset: 0x000F848E
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

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x0600A946 RID: 43334 RVA: 0x000FA2A3 File Offset: 0x000F84A3
		// (set) Token: 0x0600A947 RID: 43335 RVA: 0x000FA2B7 File Offset: 0x000F84B7
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

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x0600A948 RID: 43336 RVA: 0x000FA2CC File Offset: 0x000F84CC
		// (set) Token: 0x0600A949 RID: 43337 RVA: 0x000FA2DC File Offset: 0x000F84DC
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

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x0600A94A RID: 43338 RVA: 0x000FA2ED File Offset: 0x000F84ED
		// (set) Token: 0x0600A94B RID: 43339 RVA: 0x000FA2FD File Offset: 0x000F84FD
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

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x0600A94C RID: 43340 RVA: 0x000FA30E File Offset: 0x000F850E
		// (set) Token: 0x0600A94D RID: 43341 RVA: 0x000FA31E File Offset: 0x000F851E
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

		// Token: 0x0600A94E RID: 43342 RVA: 0x000FA32F File Offset: 0x000F852F
		public void SetVisibleInRayTracing(bool NewValue)
		{
			UNiagaraComponent.__SetVisibleInRayTracing_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600A94F RID: 43343 RVA: 0x000FA340 File Offset: 0x000F8540
		public unsafe void SetVariableVec4(FName InVariableName, in FVector4 InValue)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetVariableVec4_Internal(base.NativePtr, InVariableName, ptr);
		}

		// Token: 0x0600A950 RID: 43344 RVA: 0x000FA376 File Offset: 0x000F8576
		public void SetVariableVec3(FName InVariableName, FVector InValue)
		{
			UNiagaraComponent.__SetVariableVec3_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x0600A951 RID: 43345 RVA: 0x000FA385 File Offset: 0x000F8585
		public void SetVariableVec2(FName InVariableName, FVector2D InValue)
		{
			UNiagaraComponent.__SetVariableVec2_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x0600A952 RID: 43346 RVA: 0x000FA394 File Offset: 0x000F8594
		[NullableContext(2)]
		public void SetVariableTypedObject(FName InVariableName, UClassStackOnlyPtr TypeClass, UObject Object)
		{
			UNiagaraComponent.__SetVariableTypedObject_Internal(base.NativePtr, InVariableName, TypeClass._NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A953 RID: 43347 RVA: 0x000FA3B8 File Offset: 0x000F85B8
		[NullableContext(2)]
		public void SetVariableTextureRenderTarget(FName InVariableName, UTextureRenderTarget TextureRenderTarget)
		{
			UNiagaraComponent.__SetVariableTextureRenderTarget_Internal(base.NativePtr, InVariableName, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A954 RID: 43348 RVA: 0x000FA3D8 File Offset: 0x000F85D8
		public unsafe void SetVariableQuat(FName InVariableName, in FQuat InValue)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetVariableQuat_Internal(base.NativePtr, InVariableName, ptr);
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x000FA40E File Offset: 0x000F860E
		[NullableContext(2)]
		public void SetVariableObject(FName InVariableName, UObject Object)
		{
			UNiagaraComponent.__SetVariableObject_Internal(base.NativePtr, InVariableName, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x000FA42C File Offset: 0x000F862C
		[NullableContext(2)]
		public void SetVariableMaterial(FName InVariableName, UMaterialInterface Object)
		{
			UNiagaraComponent.__SetVariableMaterial_Internal(base.NativePtr, InVariableName, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A957 RID: 43351 RVA: 0x000FA44A File Offset: 0x000F864A
		public void SetVariableLinearColor(FName InVariableName, in FLinearColor InValue)
		{
			UNiagaraComponent.__SetVariableLinearColor_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x0600A958 RID: 43352 RVA: 0x000FA459 File Offset: 0x000F8659
		public void SetVariableInt(FName InVariableName, int InValue)
		{
			UNiagaraComponent.__SetVariableInt_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x0600A959 RID: 43353 RVA: 0x000FA468 File Offset: 0x000F8668
		public void SetVariableFloat(FName InVariableName, float InValue)
		{
			UNiagaraComponent.__SetVariableFloat_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x000FA477 File Offset: 0x000F8677
		public void SetVariableBool(FName InVariableName, bool InValue)
		{
			UNiagaraComponent.__SetVariableBool_Internal(base.NativePtr, InVariableName, InValue);
		}

		// Token: 0x0600A95B RID: 43355 RVA: 0x000FA486 File Offset: 0x000F8686
		[NullableContext(2)]
		public void SetVariableActor(FName InVariableName, AActor Actor)
		{
			UNiagaraComponent.__SetVariableActor_Internal(base.NativePtr, InVariableName, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A95C RID: 43356 RVA: 0x000FA4A4 File Offset: 0x000F86A4
		public void SetTickTimeDilation(float InTimeDilation)
		{
			UNiagaraComponent.__SetTickTimeDilation_Internal(base.NativePtr, InTimeDilation);
		}

		// Token: 0x0600A95D RID: 43357 RVA: 0x000FA4B2 File Offset: 0x000F86B2
		public void SetSeekDelta(float InSeekDelta)
		{
			UNiagaraComponent.__SetSeekDelta_Internal(base.NativePtr, InSeekDelta);
		}

		// Token: 0x0600A95E RID: 43358 RVA: 0x000FA4C0 File Offset: 0x000F86C0
		[NullableContext(2)]
		public void SetRuntimeEffectType(UNiagaraEffectType EffectType)
		{
			UNiagaraComponent.__SetRuntimeEffectType_Internal(base.NativePtr, (EffectType != null) ? EffectType.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A95F RID: 43359 RVA: 0x000FA4DD File Offset: 0x000F86DD
		public void SetRenderingEnabled(bool bInRenderingEnabled)
		{
			UNiagaraComponent.__SetRenderingEnabled_Internal(base.NativePtr, bInRenderingEnabled);
		}

		// Token: 0x0600A960 RID: 43360 RVA: 0x000FA4EB File Offset: 0x000F86EB
		public void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance)
		{
			UNiagaraComponent.__SetPreviewLODDistance_Internal(base.NativePtr, bEnablePreviewLODDistance, PreviewLODDistance);
		}

		// Token: 0x0600A961 RID: 43361 RVA: 0x000FA4FA File Offset: 0x000F86FA
		public void SetPaused(bool bInPaused, bool bNotify = true)
		{
			UNiagaraComponent.__SetPaused_Internal(base.NativePtr, bInPaused, bNotify);
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x000FA50C File Offset: 0x000F870C
		public unsafe void SetNiagaraVariableVec4(string InVariableName, in FVector4 InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetNiagaraVariableVec4_Internal(base.NativePtr, fstring, ptr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x000FA554 File Offset: 0x000F8754
		public unsafe void SetNiagaraVariableVec3(string InVariableName, FVector InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableVec3_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x000FA580 File Offset: 0x000F8780
		public unsafe void SetNiagaraVariableVec2(string InVariableName, FVector2D InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableVec2_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A965 RID: 43365 RVA: 0x000FA5AC File Offset: 0x000F87AC
		public unsafe void SetNiagaraVariableQuat(string InVariableName, in FQuat InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraComponent.__SetNiagaraVariableQuat_Internal(base.NativePtr, fstring, ptr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A966 RID: 43366 RVA: 0x000FA5F4 File Offset: 0x000F87F4
		public unsafe void SetNiagaraVariableObject(string InVariableName, [Nullable(2)] UObject Object)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableObject_Internal(base.NativePtr, fstring, (Object != null) ? Object.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A967 RID: 43367 RVA: 0x000FA630 File Offset: 0x000F8830
		public unsafe void SetNiagaraVariableLinearColor(string InVariableName, in FLinearColor InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableLinearColor_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A968 RID: 43368 RVA: 0x000FA65C File Offset: 0x000F885C
		public unsafe void SetNiagaraVariableInt(string InVariableName, int InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableInt_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x000FA688 File Offset: 0x000F8888
		public unsafe void SetNiagaraVariableFloat(string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableFloat_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x000FA6B4 File Offset: 0x000F88B4
		public unsafe void SetNiagaraVariableBool(string InVariableName, bool InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableBool_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x000FA6E0 File Offset: 0x000F88E0
		public unsafe void SetNiagaraVariableActor(string InVariableName, [Nullable(2)] AActor Actor)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetNiagaraVariableActor_Internal(base.NativePtr, fstring, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x000FA71A File Offset: 0x000F891A
		public void SetMaxSimTime(float InMaxTime)
		{
			UNiagaraComponent.__SetMaxSimTime_Internal(base.NativePtr, InMaxTime);
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x000FA728 File Offset: 0x000F8928
		public void SetMaterialUseLocalTime(bool InUseLocalTime)
		{
			UNiagaraComponent.__SetMaterialUseLocalTime_Internal(base.NativePtr, InUseLocalTime);
		}

		// Token: 0x0600A96E RID: 43374 RVA: 0x000FA736 File Offset: 0x000F8936
		public void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock)
		{
			UNiagaraComponent.__SetLockDesiredAgeDeltaTimeToSeekDelta_Internal(base.NativePtr, bLock);
		}

		// Token: 0x0600A96F RID: 43375 RVA: 0x000FA744 File Offset: 0x000F8944
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

		// Token: 0x0600A970 RID: 43376 RVA: 0x000FA798 File Offset: 0x000F8998
		public unsafe void SetKuroNiagaraEmitterFloatParam(string InEmitterName, string InVariableName, float Value)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetKuroNiagaraEmitterFloatParam_Internal(base.NativePtr, fstring, fstring2, Value);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600A971 RID: 43377 RVA: 0x000FA7D8 File Offset: 0x000F89D8
		public unsafe void SetKuroNiagaraEmitterCustomTexture(string InEmitterName, string InVariableName, [Nullable(2)] UTexture Texture)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UNiagaraComponent.__SetKuroNiagaraEmitterCustomTexture_Internal(base.NativePtr, fstring, fstring2, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600A972 RID: 43378 RVA: 0x000FA824 File Offset: 0x000F8A24
		public unsafe void SetKuroMaterialVectorParametre(FName InVariableName, ref FLinearColor vec)
		{
			fixed (FLinearColor* ptr = &vec)
			{
				void* ptr2 = (void*)ptr;
				UNiagaraComponent.__SetKuroMaterialVectorParametre_Internal(base.NativePtr, InVariableName, ref vec);
			}
		}

		// Token: 0x0600A973 RID: 43379 RVA: 0x000FA846 File Offset: 0x000F8A46
		public void SetKuroMaterialScalarParametre(FName InVariableName, float val)
		{
			UNiagaraComponent.__SetKuroMaterialScalarParametre_Internal(base.NativePtr, InVariableName, val);
		}

		// Token: 0x0600A974 RID: 43380 RVA: 0x000FA855 File Offset: 0x000F8A55
		[NullableContext(2)]
		public void SetKuroMaterial(FName InEmitterName, UMaterialInterface Mat)
		{
			UNiagaraComponent.__SetKuroMaterial_Internal(base.NativePtr, InEmitterName, (Mat != null) ? Mat.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A975 RID: 43381 RVA: 0x000FA873 File Offset: 0x000F8A73
		[NullableContext(2)]
		public void SetKuroCustomTexture(FName InVariableName, UTexture Texture)
		{
			UNiagaraComponent.__SetKuroCustomTexture_Internal(base.NativePtr, InVariableName, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A976 RID: 43382 RVA: 0x000FA891 File Offset: 0x000F8A91
		public void SetGpuComputeDebug(bool bEnableDebug)
		{
			UNiagaraComponent.__SetGpuComputeDebug_Internal(base.NativePtr, bEnableDebug);
		}

		// Token: 0x0600A977 RID: 43383 RVA: 0x000FA89F File Offset: 0x000F8A9F
		public void SetForceSolo(bool bInForceSolo)
		{
			UNiagaraComponent.__SetForceSolo_Internal(base.NativePtr, bInForceSolo);
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x000FA8AD File Offset: 0x000F8AAD
		public void SetEmitterQualityLevelBias(int InBias)
		{
			UNiagaraComponent.__SetEmitterQualityLevelBias_Internal(base.NativePtr, InBias);
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x000FA8BB File Offset: 0x000F8ABB
		public void SetDesiredAgeOverride(float InDesiredAgeOverride)
		{
			UNiagaraComponent.__SetDesiredAgeOverride_Internal(base.NativePtr, InDesiredAgeOverride);
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x000FA8C9 File Offset: 0x000F8AC9
		public void SetDesiredAge(float InDesiredAge)
		{
			UNiagaraComponent.__SetDesiredAge_Internal(base.NativePtr, InDesiredAge);
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x000FA8D7 File Offset: 0x000F8AD7
		public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking)
		{
			UNiagaraComponent.__SetCanRenderWhileSeeking_Internal(base.NativePtr, bInCanRenderWhileSeeking);
		}

		// Token: 0x0600A97C RID: 43388 RVA: 0x000FA8E5 File Offset: 0x000F8AE5
		public void SetAutoDestroy(bool bInAutoDestroy)
		{
			UNiagaraComponent.__SetAutoDestroy_Internal(base.NativePtr, bInAutoDestroy);
		}

		// Token: 0x0600A97D RID: 43389 RVA: 0x000FA8F3 File Offset: 0x000F8AF3
		[NullableContext(2)]
		public void SetAsset(UNiagaraSystem InAsset, bool bResetExistingOverrideParameters = true)
		{
			UNiagaraComponent.__SetAsset_Internal(base.NativePtr, (InAsset != null) ? InAsset.NativePtr : IntPtr.Zero, bResetExistingOverrideParameters);
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x000FA911 File Offset: 0x000F8B11
		public void SetAllowSystemWarmup(bool bAllow)
		{
			UNiagaraComponent.__SetAllowSystemWarmup_Internal(base.NativePtr, bAllow);
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x000FA91F File Offset: 0x000F8B1F
		public void SetAllowScalability(bool bAllow)
		{
			UNiagaraComponent.__SetAllowScalability_Internal(base.NativePtr, bAllow);
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x000FA92D File Offset: 0x000F8B2D
		public void SetAllowOcclusionCulling(bool bInAllowOcclusionCulling)
		{
			UNiagaraComponent.__SetAllowOcclusionCulling_Internal(base.NativePtr, bInAllowOcclusionCulling);
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x000FA93B File Offset: 0x000F8B3B
		public void SeekToDesiredAge(float InDesiredAge)
		{
			UNiagaraComponent.__SeekToDesiredAge_Internal(base.NativePtr, InDesiredAge);
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x000FA949 File Offset: 0x000F8B49
		public void ResetSystem()
		{
			UNiagaraComponent.__ResetSystem_Internal(base.NativePtr);
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x000FA958 File Offset: 0x000F8B58
		public unsafe bool ResetOverrideParametersAndActivate(bool bReset = true, string ExceptOverrideName = "")
		{
			FString fstring = FString.AllocTemp(ExceptOverrideName);
			bool result = UNiagaraComponent.__ResetOverrideParametersAndActivate_Internal(base.NativePtr, bReset, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x000FA983 File Offset: 0x000F8B83
		public void ReinitializeSystem()
		{
			UNiagaraComponent.__ReinitializeSystem_Internal(base.NativePtr);
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x000FA990 File Offset: 0x000F8B90
		public bool IsSystemWarmupAllowed()
		{
			return UNiagaraComponent.__IsSystemWarmupAllowed_Internal(base.NativePtr);
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x000FA99D File Offset: 0x000F8B9D
		public bool IsPaused()
		{
			return UNiagaraComponent.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x000FA9AA File Offset: 0x000F8BAA
		public bool HasSkeletalMeshDataInterface()
		{
			return UNiagaraComponent.__HasSkeletalMeshDataInterface_Internal(base.NativePtr);
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x000FA9B7 File Offset: 0x000F8BB7
		public bool HasDataInterface(UClassStackOnlyPtr DataInterfaceClass)
		{
			return UNiagaraComponent.__HasDataInterface_Internal(base.NativePtr, DataInterfaceClass._NativePtr);
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x000FA9CA File Offset: 0x000F8BCA
		public bool HasAnyEmittersComplete()
		{
			return UNiagaraComponent.__HasAnyEmittersComplete_Internal(base.NativePtr);
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x000FA9D7 File Offset: 0x000F8BD7
		public float GetSeekDelta()
		{
			return UNiagaraComponent.__GetSeekDelta_Internal(base.NativePtr);
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x000FA9E4 File Offset: 0x000F8BE4
		[NullableContext(2)]
		public UNiagaraEffectType GetRuntimeEffectType()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraEffectType>(UNiagaraComponent.__GetRuntimeEffectType_Internal(base.NativePtr));
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x000FA9F6 File Offset: 0x000F8BF6
		public bool GetPreviewLODDistanceEnabled()
		{
			return UNiagaraComponent.__GetPreviewLODDistanceEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x000FAA03 File Offset: 0x000F8C03
		public int GetPreviewLODDistance()
		{
			return UNiagaraComponent.__GetPreviewLODDistance_Internal(base.NativePtr);
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x000FAA10 File Offset: 0x000F8C10
		public unsafe TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(string InEmitterName, string InValueName)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InValueName);
			TArray<FVector> result = new TArray<FVector>(UNiagaraComponent.__GetNiagaraParticleValueVec3_DebugOnly_Internal(base.NativePtr, fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x000FAA54 File Offset: 0x000F8C54
		public unsafe TArray<float> GetNiagaraParticleValues_DebugOnly(string InEmitterName, string InValueName)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InValueName);
			TArray<float> result = new TArray<float>(UNiagaraComponent.__GetNiagaraParticleValues_DebugOnly_Internal(base.NativePtr, fstring, fstring2), null);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x000FAA98 File Offset: 0x000F8C98
		public unsafe TArray<FVector> GetNiagaraParticlePositions_DebugOnly(string InEmitterName)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			TArray<FVector> result = new TArray<FVector>(UNiagaraComponent.__GetNiagaraParticlePositions_DebugOnly_Internal(base.NativePtr, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x000FAAC8 File Offset: 0x000F8CC8
		public float GetMaxSimTime()
		{
			return UNiagaraComponent.__GetMaxSimTime_Internal(base.NativePtr);
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x000FAAD5 File Offset: 0x000F8CD5
		public bool GetLockDesiredAgeDeltaTimeToSeekDelta()
		{
			return UNiagaraComponent.__GetLockDesiredAgeDeltaTimeToSeekDelta_Internal(base.NativePtr);
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x000FAAE2 File Offset: 0x000F8CE2
		public bool GetForceSolo()
		{
			return UNiagaraComponent.__GetForceSolo_Internal(base.NativePtr);
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x000FAAEF File Offset: 0x000F8CEF
		public float GetDesiredAgeOverride()
		{
			return UNiagaraComponent.__GetDesiredAgeOverride_Internal(base.NativePtr);
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x000FAAFC File Offset: 0x000F8CFC
		public float GetDesiredAge()
		{
			return UNiagaraComponent.__GetDesiredAge_Internal(base.NativePtr);
		}

		// Token: 0x0600A996 RID: 43414 RVA: 0x000FAB09 File Offset: 0x000F8D09
		[NullableContext(2)]
		public UNiagaraSystem GetAsset()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraSystem>(UNiagaraComponent.__GetAsset_Internal(base.NativePtr));
		}

		// Token: 0x0600A997 RID: 43415 RVA: 0x000FAB1B File Offset: 0x000F8D1B
		[NullableContext(2)]
		public UNiagaraEffectType GetActualEffectType()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraEffectType>(UNiagaraComponent.__GetActualEffectType_Internal(base.NativePtr));
		}

		// Token: 0x0600A998 RID: 43416 RVA: 0x000FAB2D File Offset: 0x000F8D2D
		public void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds)
		{
			UNiagaraComponent.__AdvanceSimulationByTime_Internal(base.NativePtr, SimulateTime, TickDeltaSeconds);
		}

		// Token: 0x0600A999 RID: 43417 RVA: 0x000FAB3C File Offset: 0x000F8D3C
		public void AdvanceSimulation(int TickCount, float TickDeltaSeconds)
		{
			UNiagaraComponent.__AdvanceSimulation_Internal(base.NativePtr, TickCount, TickDeltaSeconds);
		}

		// Token: 0x0600A99A RID: 43418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisibleInRayTracing_Internal(IntPtr @this, bool NewValue);

		// Token: 0x0600A99B RID: 43419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableVec4_Internal(IntPtr @this, FName InVariableName, in FVector4 InValue);

		// Token: 0x0600A99C RID: 43420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableVec3_Internal(IntPtr @this, FName InVariableName, FVector InValue);

		// Token: 0x0600A99D RID: 43421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableVec2_Internal(IntPtr @this, FName InVariableName, FVector2D InValue);

		// Token: 0x0600A99E RID: 43422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableTypedObject_Internal(IntPtr @this, FName InVariableName, IntPtr TypeClass, IntPtr Object);

		// Token: 0x0600A99F RID: 43423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableTextureRenderTarget_Internal(IntPtr @this, FName InVariableName, IntPtr TextureRenderTarget);

		// Token: 0x0600A9A0 RID: 43424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableQuat_Internal(IntPtr @this, FName InVariableName, in FQuat InValue);

		// Token: 0x0600A9A1 RID: 43425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableObject_Internal(IntPtr @this, FName InVariableName, IntPtr Object);

		// Token: 0x0600A9A2 RID: 43426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableMaterial_Internal(IntPtr @this, FName InVariableName, IntPtr Object);

		// Token: 0x0600A9A3 RID: 43427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableLinearColor_Internal(IntPtr @this, FName InVariableName, in FLinearColor InValue);

		// Token: 0x0600A9A4 RID: 43428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableInt_Internal(IntPtr @this, FName InVariableName, int InValue);

		// Token: 0x0600A9A5 RID: 43429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableFloat_Internal(IntPtr @this, FName InVariableName, float InValue);

		// Token: 0x0600A9A6 RID: 43430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableBool_Internal(IntPtr @this, FName InVariableName, bool InValue);

		// Token: 0x0600A9A7 RID: 43431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVariableActor_Internal(IntPtr @this, FName InVariableName, IntPtr Actor);

		// Token: 0x0600A9A8 RID: 43432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickTimeDilation_Internal(IntPtr @this, float InTimeDilation);

		// Token: 0x0600A9A9 RID: 43433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeekDelta_Internal(IntPtr @this, float InSeekDelta);

		// Token: 0x0600A9AA RID: 43434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRuntimeEffectType_Internal(IntPtr @this, IntPtr EffectType);

		// Token: 0x0600A9AB RID: 43435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderingEnabled_Internal(IntPtr @this, bool bInRenderingEnabled);

		// Token: 0x0600A9AC RID: 43436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPreviewLODDistance_Internal(IntPtr @this, bool bEnablePreviewLODDistance, float PreviewLODDistance);

		// Token: 0x0600A9AD RID: 43437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPaused_Internal(IntPtr @this, bool bInPaused, bool bNotify);

		// Token: 0x0600A9AE RID: 43438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableVec4_Internal(IntPtr @this, in FString InVariableName, in FVector4 InValue);

		// Token: 0x0600A9AF RID: 43439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableVec3_Internal(IntPtr @this, in FString InVariableName, FVector InValue);

		// Token: 0x0600A9B0 RID: 43440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableVec2_Internal(IntPtr @this, in FString InVariableName, FVector2D InValue);

		// Token: 0x0600A9B1 RID: 43441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableQuat_Internal(IntPtr @this, in FString InVariableName, in FQuat InValue);

		// Token: 0x0600A9B2 RID: 43442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableObject_Internal(IntPtr @this, in FString InVariableName, IntPtr Object);

		// Token: 0x0600A9B3 RID: 43443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableLinearColor_Internal(IntPtr @this, in FString InVariableName, in FLinearColor InValue);

		// Token: 0x0600A9B4 RID: 43444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableInt_Internal(IntPtr @this, in FString InVariableName, int InValue);

		// Token: 0x0600A9B5 RID: 43445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableFloat_Internal(IntPtr @this, in FString InVariableName, float InValue);

		// Token: 0x0600A9B6 RID: 43446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableBool_Internal(IntPtr @this, in FString InVariableName, bool InValue);

		// Token: 0x0600A9B7 RID: 43447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVariableActor_Internal(IntPtr @this, in FString InVariableName, IntPtr Actor);

		// Token: 0x0600A9B8 RID: 43448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxSimTime_Internal(IntPtr @this, float InMaxTime);

		// Token: 0x0600A9B9 RID: 43449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialUseLocalTime_Internal(IntPtr @this, bool InUseLocalTime);

		// Token: 0x0600A9BA RID: 43450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLockDesiredAgeDeltaTimeToSeekDelta_Internal(IntPtr @this, bool bLock);

		// Token: 0x0600A9BB RID: 43451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNiagaraEmitterVectorParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, in FVector4 InVector);

		// Token: 0x0600A9BC RID: 43452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNiagaraEmitterFloatParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, float Value);

		// Token: 0x0600A9BD RID: 43453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroNiagaraEmitterCustomTexture_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, IntPtr Texture);

		// Token: 0x0600A9BE RID: 43454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMaterialVectorParametre_Internal(IntPtr @this, FName InVariableName, ref FLinearColor vec);

		// Token: 0x0600A9BF RID: 43455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMaterialScalarParametre_Internal(IntPtr @this, FName InVariableName, float val);

		// Token: 0x0600A9C0 RID: 43456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMaterial_Internal(IntPtr @this, FName InEmitterName, IntPtr Mat);

		// Token: 0x0600A9C1 RID: 43457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCustomTexture_Internal(IntPtr @this, FName InVariableName, IntPtr Texture);

		// Token: 0x0600A9C2 RID: 43458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGpuComputeDebug_Internal(IntPtr @this, bool bEnableDebug);

		// Token: 0x0600A9C3 RID: 43459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceSolo_Internal(IntPtr @this, bool bInForceSolo);

		// Token: 0x0600A9C4 RID: 43460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEmitterQualityLevelBias_Internal(IntPtr @this, int InBias);

		// Token: 0x0600A9C5 RID: 43461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredAgeOverride_Internal(IntPtr @this, float InDesiredAgeOverride);

		// Token: 0x0600A9C6 RID: 43462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredAge_Internal(IntPtr @this, float InDesiredAge);

		// Token: 0x0600A9C7 RID: 43463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanRenderWhileSeeking_Internal(IntPtr @this, bool bInCanRenderWhileSeeking);

		// Token: 0x0600A9C8 RID: 43464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoDestroy_Internal(IntPtr @this, bool bInAutoDestroy);

		// Token: 0x0600A9C9 RID: 43465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAsset_Internal(IntPtr @this, IntPtr InAsset, bool bResetExistingOverrideParameters);

		// Token: 0x0600A9CA RID: 43466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowSystemWarmup_Internal(IntPtr @this, bool bAllow);

		// Token: 0x0600A9CB RID: 43467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowScalability_Internal(IntPtr @this, bool bAllow);

		// Token: 0x0600A9CC RID: 43468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowOcclusionCulling_Internal(IntPtr @this, bool bInAllowOcclusionCulling);

		// Token: 0x0600A9CD RID: 43469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SeekToDesiredAge_Internal(IntPtr @this, float InDesiredAge);

		// Token: 0x0600A9CE RID: 43470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetSystem_Internal(IntPtr @this);

		// Token: 0x0600A9CF RID: 43471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ResetOverrideParametersAndActivate_Internal(IntPtr @this, bool bReset, in FString ExceptOverrideName);

		// Token: 0x0600A9D0 RID: 43472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReinitializeSystem_Internal(IntPtr @this);

		// Token: 0x0600A9D1 RID: 43473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSystemWarmupAllowed_Internal(IntPtr @this);

		// Token: 0x0600A9D2 RID: 43474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x0600A9D3 RID: 43475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasSkeletalMeshDataInterface_Internal(IntPtr @this);

		// Token: 0x0600A9D4 RID: 43476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasDataInterface_Internal(IntPtr @this, IntPtr DataInterfaceClass);

		// Token: 0x0600A9D5 RID: 43477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyEmittersComplete_Internal(IntPtr @this);

		// Token: 0x0600A9D6 RID: 43478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSeekDelta_Internal(IntPtr @this);

		// Token: 0x0600A9D7 RID: 43479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRuntimeEffectType_Internal(IntPtr @this);

		// Token: 0x0600A9D8 RID: 43480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPreviewLODDistanceEnabled_Internal(IntPtr @this);

		// Token: 0x0600A9D9 RID: 43481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPreviewLODDistance_Internal(IntPtr @this);

		// Token: 0x0600A9DA RID: 43482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraParticleValueVec3_DebugOnly_Internal(IntPtr @this, in FString InEmitterName, in FString InValueName);

		// Token: 0x0600A9DB RID: 43483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraParticleValues_DebugOnly_Internal(IntPtr @this, in FString InEmitterName, in FString InValueName);

		// Token: 0x0600A9DC RID: 43484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraParticlePositions_DebugOnly_Internal(IntPtr @this, in FString InEmitterName);

		// Token: 0x0600A9DD RID: 43485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxSimTime_Internal(IntPtr @this);

		// Token: 0x0600A9DE RID: 43486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLockDesiredAgeDeltaTimeToSeekDelta_Internal(IntPtr @this);

		// Token: 0x0600A9DF RID: 43487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetForceSolo_Internal(IntPtr @this);

		// Token: 0x0600A9E0 RID: 43488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDesiredAgeOverride_Internal(IntPtr @this);

		// Token: 0x0600A9E1 RID: 43489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDesiredAge_Internal(IntPtr @this);

		// Token: 0x0600A9E2 RID: 43490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAsset_Internal(IntPtr @this);

		// Token: 0x0600A9E3 RID: 43491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActualEffectType_Internal(IntPtr @this);

		// Token: 0x0600A9E4 RID: 43492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdvanceSimulationByTime_Internal(IntPtr @this, float SimulateTime, float TickDeltaSeconds);

		// Token: 0x0600A9E5 RID: 43493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdvanceSimulation_Internal(IntPtr @this, int TickCount, float TickDeltaSeconds);

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x000FAB4B File Offset: 0x000F8D4B
		static UNiagaraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraComponent");
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x000FAB59 File Offset: 0x000F8D59
		protected UNiagaraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048B6 RID: 18614
		public new const string __ObjectPath = "/Script/Niagara.NiagaraComponent";

		// Token: 0x040048B7 RID: 18615
		private static IntPtr _ClassPtr;

		// Token: 0x040048B8 RID: 18616
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040048B9 RID: 18617
		internal static int __PropertyOffset_Asset;

		// Token: 0x040048BA RID: 18618
		internal static int __PropertyOffset_bForceSolo;

		// Token: 0x040048BB RID: 18619
		internal static byte __PropertyMask_bForceSolo;

		// Token: 0x040048BC RID: 18620
		internal static int __PropertyOffset_bEnableGpuComputeDebug;

		// Token: 0x040048BD RID: 18621
		internal static byte __PropertyMask_bEnableGpuComputeDebug;

		// Token: 0x040048BE RID: 18622
		internal static int __PropertyOffset_bAllowSystemWarmup;

		// Token: 0x040048BF RID: 18623
		internal static int __PropertyOffset_DesiredAgeOverride;

		// Token: 0x040048C0 RID: 18624
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x040048C1 RID: 18625
		internal static byte __PropertyMask_bAutoDestroy;

		// Token: 0x040048C2 RID: 18626
		internal static int __PropertyOffset_bRenderingEnabled;

		// Token: 0x040048C3 RID: 18627
		internal static byte __PropertyMask_bRenderingEnabled;

		// Token: 0x040048C4 RID: 18628
		internal static int __PropertyOffset_RuntimeEffectType;

		// Token: 0x040048C5 RID: 18629
		internal static int __PropertyOffset_bAutoManageAttachment;

		// Token: 0x040048C6 RID: 18630
		internal static byte __PropertyMask_bAutoManageAttachment;

		// Token: 0x040048C7 RID: 18631
		internal static int __PropertyOffset_bAutoAttachWeldSimulatedBodies;

		// Token: 0x040048C8 RID: 18632
		internal static byte __PropertyMask_bAutoAttachWeldSimulatedBodies;

		// Token: 0x040048C9 RID: 18633
		internal static int __PropertyOffset_MaxTimeBeforeForceUpdateTransform;

		// Token: 0x040048CA RID: 18634
		internal static int __PropertyOffset_NiagaraEffectType;

		// Token: 0x040048CB RID: 18635
		internal static int __PropertyOffset_KuroGlobalScale;

		// Token: 0x040048CC RID: 18636
		internal static int __PropertyOffset_KuroGlobalColor;

		// Token: 0x040048CD RID: 18637
		internal static int __PropertyOffset_KuroGlobalAlpha;

		// Token: 0x040048CE RID: 18638
		internal static int __PropertyOffset_bAllowOcclusionCulling;

		// Token: 0x040048CF RID: 18639
		internal static byte __PropertyMask_bAllowOcclusionCulling;

		// Token: 0x040048D0 RID: 18640
		internal static int __PropertyOffset_OnSystemInstancePausedDelegate;

		// Token: 0x040048D1 RID: 18641
		[Nullable(2)]
		private FOnSystemInstancePaused _OnSystemInstancePausedDelegate;

		// Token: 0x040048D2 RID: 18642
		internal static int __PropertyOffset_OnSystemFinished;

		// Token: 0x040048D3 RID: 18643
		[Nullable(2)]
		private FOnNiagaraSystemFinished _OnSystemFinished;

		// Token: 0x040048D4 RID: 18644
		internal static int __PropertyOffset_AutoAttachParent;

		// Token: 0x040048D5 RID: 18645
		internal static int __PropertyOffset_AutoAttachSocketName;

		// Token: 0x040048D6 RID: 18646
		internal static int __PropertyOffset_AutoAttachLocationRule;

		// Token: 0x040048D7 RID: 18647
		internal static int __PropertyOffset_AutoAttachRotationRule;

		// Token: 0x040048D8 RID: 18648
		internal static int __PropertyOffset_AutoAttachScaleRule;
	}
}
