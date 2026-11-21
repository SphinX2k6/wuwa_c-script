using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000719 RID: 1817
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UINiagara")]
	[UnrealStructLayout(3936, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3936)]
	public class UUINiagara : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C27 RID: 39975 RVA: 0x000E92FD File Offset: 0x000E74FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINiagara._ClassPtr;
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x000E930C File Offset: 0x000E750C
		public UUINiagara() : this(BuiltinUtils.AllocNativeUObject(UUINiagara.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x000E9334 File Offset: 0x000E7534
		public UUINiagara(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06009C2A RID: 39978 RVA: 0x000E9367 File Offset: 0x000E7567
		// (set) Token: 0x06009C2B RID: 39979 RVA: 0x000E937B File Offset: 0x000E757B
		[Nullable(2)]
		public unsafe UNiagaraSystem NiagaraSystemReference
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagara.__PropertyOffset_NiagaraSystemReference);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagara.__PropertyOffset_NiagaraSystemReference, value);
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06009C2C RID: 39980 RVA: 0x000E9390 File Offset: 0x000E7590
		// (set) Token: 0x06009C2D RID: 39981 RVA: 0x000E93A0 File Offset: 0x000E75A0
		public unsafe bool IsNiagaraActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_IsNiagaraActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_IsNiagaraActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06009C2E RID: 39982 RVA: 0x000E93B1 File Offset: 0x000E75B1
		// (set) Token: 0x06009C2F RID: 39983 RVA: 0x000E93C1 File Offset: 0x000E75C1
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06009C30 RID: 39984 RVA: 0x000E93D2 File Offset: 0x000E75D2
		// (set) Token: 0x06009C31 RID: 39985 RVA: 0x000E93E2 File Offset: 0x000E75E2
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_LoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_LoopTime) = value;
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06009C32 RID: 39986 RVA: 0x000E93F3 File Offset: 0x000E75F3
		// (set) Token: 0x06009C33 RID: 39987 RVA: 0x000E9403 File Offset: 0x000E7603
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_EndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_EndTime) = value;
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x06009C34 RID: 39988 RVA: 0x000E9414 File Offset: 0x000E7614
		// (set) Token: 0x06009C35 RID: 39989 RVA: 0x000E944D File Offset: 0x000E764D
		public FKuroCurveVector NiagaraLocation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._NiagaraLocation) == null)
				{
					result = (this._NiagaraLocation = new FKuroCurveVector(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_NiagaraLocation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_NiagaraLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x000E9470 File Offset: 0x000E7670
		// (set) Token: 0x06009C37 RID: 39991 RVA: 0x000E94A9 File Offset: 0x000E76A9
		public FKuroCurveVector NiagaraRotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._NiagaraRotation) == null)
				{
					result = (this._NiagaraRotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_NiagaraRotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_NiagaraRotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x06009C38 RID: 39992 RVA: 0x000E94CC File Offset: 0x000E76CC
		// (set) Token: 0x06009C39 RID: 39993 RVA: 0x000E9505 File Offset: 0x000E7705
		public FKuroCurveVector NiagaraScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._NiagaraScale) == null)
				{
					result = (this._NiagaraScale = new FKuroCurveVector(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_NiagaraScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_NiagaraScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x000E9528 File Offset: 0x000E7728
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x000E9561 File Offset: 0x000E7761
		public TMap<string, int> IntParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._IntParameter) == null)
				{
					result = (this._IntParameter = new TMap<string, int>(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_IntParameter, this));
				}
				return result;
			}
			set
			{
				this.IntParameter.CopyAssign(value);
			}
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x000E9570 File Offset: 0x000E7770
		// (set) Token: 0x06009C3D RID: 39997 RVA: 0x000E95A9 File Offset: 0x000E77A9
		public TMap<string, FKuroCurveFloat> FloatParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroCurveFloat> result;
				if ((result = this._FloatParameter) == null)
				{
					result = (this._FloatParameter = new TMap<string, FKuroCurveFloat>(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_FloatParameter, this));
				}
				return result;
			}
			set
			{
				this.FloatParameter.CopyAssign(value);
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x06009C3E RID: 39998 RVA: 0x000E95B8 File Offset: 0x000E77B8
		// (set) Token: 0x06009C3F RID: 39999 RVA: 0x000E95F1 File Offset: 0x000E77F1
		public TMap<string, FKuroCurveVector> VectorParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroCurveVector> result;
				if ((result = this._VectorParameter) == null)
				{
					result = (this._VectorParameter = new TMap<string, FKuroCurveVector>(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_VectorParameter, this));
				}
				return result;
			}
			set
			{
				this.VectorParameter.CopyAssign(value);
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06009C40 RID: 40000 RVA: 0x000E9600 File Offset: 0x000E7800
		// (set) Token: 0x06009C41 RID: 40001 RVA: 0x000E9639 File Offset: 0x000E7839
		public TMap<string, FKuroCurveLinearColor> ColorParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameter) == null)
				{
					result = (this._ColorParameter = new TMap<string, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_ColorParameter, this));
				}
				return result;
			}
			set
			{
				this.ColorParameter.CopyAssign(value);
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06009C42 RID: 40002 RVA: 0x000E9647 File Offset: 0x000E7847
		// (set) Token: 0x06009C43 RID: 40003 RVA: 0x000E9657 File Offset: 0x000E7857
		public unsafe bool bAdaptPosAndSizeChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bAdaptPosAndSizeChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bAdaptPosAndSizeChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06009C44 RID: 40004 RVA: 0x000E9668 File Offset: 0x000E7868
		// (set) Token: 0x06009C45 RID: 40005 RVA: 0x000E9678 File Offset: 0x000E7878
		public unsafe bool bEnableCircleClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bEnableCircleClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bEnableCircleClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06009C46 RID: 40006 RVA: 0x000E9689 File Offset: 0x000E7889
		// (set) Token: 0x06009C47 RID: 40007 RVA: 0x000E969D File Offset: 0x000E789D
		[Nullable(2)]
		public unsafe ULGUINiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUINiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagara.__PropertyOffset_NiagaraComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagara.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06009C48 RID: 40008 RVA: 0x000E96B2 File Offset: 0x000E78B2
		// (set) Token: 0x06009C49 RID: 40009 RVA: 0x000E96C2 File Offset: 0x000E78C2
		public unsafe bool bResetNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bResetNiagara) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bResetNiagara) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06009C4A RID: 40010 RVA: 0x000E96D3 File Offset: 0x000E78D3
		// (set) Token: 0x06009C4B RID: 40011 RVA: 0x000E96E3 File Offset: 0x000E78E3
		public unsafe bool bIgnoreGlobalUINiagaraPause
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bIgnoreGlobalUINiagaraPause) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bIgnoreGlobalUINiagaraPause) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06009C4C RID: 40012 RVA: 0x000E96F4 File Offset: 0x000E78F4
		// (set) Token: 0x06009C4D RID: 40013 RVA: 0x000E9704 File Offset: 0x000E7904
		public unsafe bool bAdvancedInitNiagaraComp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bAdvancedInitNiagaraComp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bAdvancedInitNiagaraComp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06009C4E RID: 40014 RVA: 0x000E9715 File Offset: 0x000E7915
		// (set) Token: 0x06009C4F RID: 40015 RVA: 0x000E9729 File Offset: 0x000E7929
		[Nullable(2)]
		public unsafe UAkAudioEvent StartEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagara.__PropertyOffset_StartEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUINiagara.__PropertyOffset_StartEvent, value);
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06009C50 RID: 40016 RVA: 0x000E973E File Offset: 0x000E793E
		// (set) Token: 0x06009C51 RID: 40017 RVA: 0x000E974E File Offset: 0x000E794E
		public unsafe bool bCanInterupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bCanInterupt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_bCanInterupt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06009C52 RID: 40018 RVA: 0x000E975F File Offset: 0x000E795F
		// (set) Token: 0x06009C53 RID: 40019 RVA: 0x000E976F File Offset: 0x000E796F
		public unsafe int FadeOutMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_FadeOutMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_FadeOutMs) = value;
			}
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x000E9780 File Offset: 0x000E7980
		public void SwitchToStop()
		{
			UUINiagara.__SwitchToStop_Internal(base.NativePtr);
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x000E9790 File Offset: 0x000E7990
		public unsafe void SetNiagaraVarVector(string VarName, FVector Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarVector_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x000E97BC File Offset: 0x000E79BC
		public unsafe void SetNiagaraVarLinearColor(string VarName, FLinearColor Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarLinearColor_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x000E97E8 File Offset: 0x000E79E8
		public unsafe void SetNiagaraVarInt(string VarName, int Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarInt_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009C58 RID: 40024 RVA: 0x000E9814 File Offset: 0x000E7A14
		public unsafe void SetNiagaraVarFloat(string VarName, float Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarFloat_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009C59 RID: 40025 RVA: 0x000E983F File Offset: 0x000E7A3F
		public void SetNiagaraUIActive(bool active, bool bInResetNiagara)
		{
			UUINiagara.__SetNiagaraUIActive_Internal(base.NativePtr, active, bInResetNiagara);
		}

		// Token: 0x06009C5A RID: 40026 RVA: 0x000E984E File Offset: 0x000E7A4E
		[NullableContext(2)]
		public void SetNiagaraSystem(UNiagaraSystem InSystem)
		{
			UUINiagara.__SetNiagaraSystem_Internal(base.NativePtr, (InSystem != null) ? InSystem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x000E986C File Offset: 0x000E7A6C
		public unsafe void SetNiagaraEmitterVectorParam(string InEmitterName, string InVariableName, FVector4 InVector)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InVector;
			UUINiagara.__SetNiagaraEmitterVectorParam_Internal(base.NativePtr, fstring, fstring2, ptr);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x000E98C0 File Offset: 0x000E7AC0
		public unsafe void SetNiagaraEmitterFloatParam(string InEmitterName, string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UUINiagara.__SetNiagaraEmitterFloatParam_Internal(base.NativePtr, fstring, fstring2, InValue);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x000E9900 File Offset: 0x000E7B00
		public unsafe void SetNiagaraEmitterCustomTexture(string InEmitterName, string InVariableName, [Nullable(2)] UTexture InTexture)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UUINiagara.__SetNiagaraEmitterCustomTexture_Internal(base.NativePtr, fstring, fstring2, (InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x000E994C File Offset: 0x000E7B4C
		public void SetCircleClipEnable(bool Enable)
		{
			UUINiagara.__SetCircleClipEnable_Internal(base.NativePtr, Enable);
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x000E995A File Offset: 0x000E7B5A
		public void ResetOverrideParametersAndActivate()
		{
			UUINiagara.__ResetOverrideParametersAndActivate_Internal(base.NativePtr);
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x000E9967 File Offset: 0x000E7B67
		public void ResetOverrideParameters()
		{
			UUINiagara.__ResetOverrideParameters_Internal(base.NativePtr);
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x000E9974 File Offset: 0x000E7B74
		public void ReinitializeSystem()
		{
			UUINiagara.__ReinitializeSystem_Internal(base.NativePtr);
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x000E9981 File Offset: 0x000E7B81
		public bool IsCircleClipEnable()
		{
			return UUINiagara.__IsCircleClipEnable_Internal(base.NativePtr);
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x000E998E File Offset: 0x000E7B8E
		[NullableContext(2)]
		public ULGUINiagaraComponent GetNiagaraComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUINiagaraComponent>(UUINiagara.__GetNiagaraComponent_Internal(base.NativePtr));
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x000E99A0 File Offset: 0x000E7BA0
		public bool GetIsActive()
		{
			return UUINiagara.__GetIsActive_Internal(base.NativePtr);
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x000E99AD File Offset: 0x000E7BAD
		public void DeactivateSystem()
		{
			UUINiagara.__DeactivateSystem_Internal(base.NativePtr);
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x000E99BA File Offset: 0x000E7BBA
		public void ActivateSystem(bool Reset)
		{
			UUINiagara.__ActivateSystem_Internal(base.NativePtr, Reset);
		}

		// Token: 0x06009C67 RID: 40039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchToStop_Internal(IntPtr @this);

		// Token: 0x06009C68 RID: 40040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarVector_Internal(IntPtr @this, in FString VarName, FVector Value);

		// Token: 0x06009C69 RID: 40041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarLinearColor_Internal(IntPtr @this, in FString VarName, FLinearColor Value);

		// Token: 0x06009C6A RID: 40042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarInt_Internal(IntPtr @this, in FString VarName, int Value);

		// Token: 0x06009C6B RID: 40043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarFloat_Internal(IntPtr @this, in FString VarName, float Value);

		// Token: 0x06009C6C RID: 40044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraUIActive_Internal(IntPtr @this, bool active, bool bInResetNiagara);

		// Token: 0x06009C6D RID: 40045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSystem_Internal(IntPtr @this, IntPtr InSystem);

		// Token: 0x06009C6E RID: 40046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraEmitterVectorParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, in FVector4 InVector);

		// Token: 0x06009C6F RID: 40047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraEmitterFloatParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, float InValue);

		// Token: 0x06009C70 RID: 40048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraEmitterCustomTexture_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, IntPtr InTexture);

		// Token: 0x06009C71 RID: 40049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCircleClipEnable_Internal(IntPtr @this, bool Enable);

		// Token: 0x06009C72 RID: 40050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetOverrideParametersAndActivate_Internal(IntPtr @this);

		// Token: 0x06009C73 RID: 40051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetOverrideParameters_Internal(IntPtr @this);

		// Token: 0x06009C74 RID: 40052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReinitializeSystem_Internal(IntPtr @this);

		// Token: 0x06009C75 RID: 40053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCircleClipEnable_Internal(IntPtr @this);

		// Token: 0x06009C76 RID: 40054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraComponent_Internal(IntPtr @this);

		// Token: 0x06009C77 RID: 40055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsActive_Internal(IntPtr @this);

		// Token: 0x06009C78 RID: 40056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateSystem_Internal(IntPtr @this);

		// Token: 0x06009C79 RID: 40057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateSystem_Internal(IntPtr @this, bool Reset);

		// Token: 0x06009C7A RID: 40058 RVA: 0x000E99C8 File Offset: 0x000E7BC8
		static UUINiagara()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINiagara");
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x000E99D6 File Offset: 0x000E7BD6
		protected UUINiagara(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004354 RID: 17236
		public new const string __ObjectPath = "/Script/LGUI.UINiagara";

		// Token: 0x04004355 RID: 17237
		private static IntPtr _ClassPtr;

		// Token: 0x04004356 RID: 17238
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004357 RID: 17239
		internal static int __PropertyOffset_NiagaraSystemReference;

		// Token: 0x04004358 RID: 17240
		internal static int __PropertyOffset_IsNiagaraActive;

		// Token: 0x04004359 RID: 17241
		internal static int __PropertyOffset_StartTime;

		// Token: 0x0400435A RID: 17242
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x0400435B RID: 17243
		internal static int __PropertyOffset_EndTime;

		// Token: 0x0400435C RID: 17244
		internal static int __PropertyOffset_NiagaraLocation;

		// Token: 0x0400435D RID: 17245
		[Nullable(2)]
		private FKuroCurveVector _NiagaraLocation;

		// Token: 0x0400435E RID: 17246
		internal static int __PropertyOffset_NiagaraRotation;

		// Token: 0x0400435F RID: 17247
		[Nullable(2)]
		private FKuroCurveVector _NiagaraRotation;

		// Token: 0x04004360 RID: 17248
		internal static int __PropertyOffset_NiagaraScale;

		// Token: 0x04004361 RID: 17249
		[Nullable(2)]
		private FKuroCurveVector _NiagaraScale;

		// Token: 0x04004362 RID: 17250
		internal static int __PropertyOffset_IntParameter;

		// Token: 0x04004363 RID: 17251
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _IntParameter;

		// Token: 0x04004364 RID: 17252
		internal static int __PropertyOffset_FloatParameter;

		// Token: 0x04004365 RID: 17253
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveFloat> _FloatParameter;

		// Token: 0x04004366 RID: 17254
		internal static int __PropertyOffset_VectorParameter;

		// Token: 0x04004367 RID: 17255
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveVector> _VectorParameter;

		// Token: 0x04004368 RID: 17256
		internal static int __PropertyOffset_ColorParameter;

		// Token: 0x04004369 RID: 17257
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveLinearColor> _ColorParameter;

		// Token: 0x0400436A RID: 17258
		internal static int __PropertyOffset_bAdaptPosAndSizeChanged;

		// Token: 0x0400436B RID: 17259
		internal static int __PropertyOffset_bEnableCircleClip;

		// Token: 0x0400436C RID: 17260
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x0400436D RID: 17261
		internal static int __PropertyOffset_bResetNiagara;

		// Token: 0x0400436E RID: 17262
		internal static int __PropertyOffset_bIgnoreGlobalUINiagaraPause;

		// Token: 0x0400436F RID: 17263
		internal static int __PropertyOffset_bAdvancedInitNiagaraComp;

		// Token: 0x04004370 RID: 17264
		internal static int __PropertyOffset_StartEvent;

		// Token: 0x04004371 RID: 17265
		internal static int __PropertyOffset_bCanInterupt;

		// Token: 0x04004372 RID: 17266
		internal static int __PropertyOffset_FadeOutMs;
	}
}
