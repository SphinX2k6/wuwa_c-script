using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200218F RID: 8591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UINiagara")]
	[UnrealStructLayout(3936, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3936)]
	public class UUINiagara : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208F6 RID: 133366 RVA: 0x003035F5 File Offset: 0x003017F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINiagara._ClassPtr;
		}

		// Token: 0x060208F7 RID: 133367 RVA: 0x00303604 File Offset: 0x00301804
		public UUINiagara() : this(BuiltinUtils.AllocNativeUObject(UUINiagara.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208F8 RID: 133368 RVA: 0x0030362C File Offset: 0x0030182C
		public UUINiagara(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F56 RID: 32598
		// (get) Token: 0x060208F9 RID: 133369 RVA: 0x0030365F File Offset: 0x0030185F
		// (set) Token: 0x060208FA RID: 133370 RVA: 0x00303673 File Offset: 0x00301873
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

		// Token: 0x17007F57 RID: 32599
		// (get) Token: 0x060208FB RID: 133371 RVA: 0x00303688 File Offset: 0x00301888
		// (set) Token: 0x060208FC RID: 133372 RVA: 0x00303698 File Offset: 0x00301898
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

		// Token: 0x17007F58 RID: 32600
		// (get) Token: 0x060208FD RID: 133373 RVA: 0x003036A9 File Offset: 0x003018A9
		// (set) Token: 0x060208FE RID: 133374 RVA: 0x003036B9 File Offset: 0x003018B9
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

		// Token: 0x17007F59 RID: 32601
		// (get) Token: 0x060208FF RID: 133375 RVA: 0x003036CA File Offset: 0x003018CA
		// (set) Token: 0x06020900 RID: 133376 RVA: 0x003036DA File Offset: 0x003018DA
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

		// Token: 0x17007F5A RID: 32602
		// (get) Token: 0x06020901 RID: 133377 RVA: 0x003036EB File Offset: 0x003018EB
		// (set) Token: 0x06020902 RID: 133378 RVA: 0x003036FB File Offset: 0x003018FB
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

		// Token: 0x17007F5B RID: 32603
		// (get) Token: 0x06020903 RID: 133379 RVA: 0x0030370C File Offset: 0x0030190C
		// (set) Token: 0x06020904 RID: 133380 RVA: 0x00303745 File Offset: 0x00301945
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

		// Token: 0x17007F5C RID: 32604
		// (get) Token: 0x06020905 RID: 133381 RVA: 0x00303768 File Offset: 0x00301968
		// (set) Token: 0x06020906 RID: 133382 RVA: 0x003037A1 File Offset: 0x003019A1
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

		// Token: 0x17007F5D RID: 32605
		// (get) Token: 0x06020907 RID: 133383 RVA: 0x003037C4 File Offset: 0x003019C4
		// (set) Token: 0x06020908 RID: 133384 RVA: 0x003037FD File Offset: 0x003019FD
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

		// Token: 0x17007F5E RID: 32606
		// (get) Token: 0x06020909 RID: 133385 RVA: 0x00303820 File Offset: 0x00301A20
		// (set) Token: 0x0602090A RID: 133386 RVA: 0x00303859 File Offset: 0x00301A59
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

		// Token: 0x17007F5F RID: 32607
		// (get) Token: 0x0602090B RID: 133387 RVA: 0x00303868 File Offset: 0x00301A68
		// (set) Token: 0x0602090C RID: 133388 RVA: 0x003038A1 File Offset: 0x00301AA1
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

		// Token: 0x17007F60 RID: 32608
		// (get) Token: 0x0602090D RID: 133389 RVA: 0x003038B0 File Offset: 0x00301AB0
		// (set) Token: 0x0602090E RID: 133390 RVA: 0x003038E9 File Offset: 0x00301AE9
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

		// Token: 0x17007F61 RID: 32609
		// (get) Token: 0x0602090F RID: 133391 RVA: 0x003038F8 File Offset: 0x00301AF8
		// (set) Token: 0x06020910 RID: 133392 RVA: 0x00303931 File Offset: 0x00301B31
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

		// Token: 0x17007F62 RID: 32610
		// (get) Token: 0x06020911 RID: 133393 RVA: 0x0030393F File Offset: 0x00301B3F
		// (set) Token: 0x06020912 RID: 133394 RVA: 0x0030394F File Offset: 0x00301B4F
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

		// Token: 0x17007F63 RID: 32611
		// (get) Token: 0x06020913 RID: 133395 RVA: 0x00303960 File Offset: 0x00301B60
		// (set) Token: 0x06020914 RID: 133396 RVA: 0x00303970 File Offset: 0x00301B70
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

		// Token: 0x17007F64 RID: 32612
		// (get) Token: 0x06020915 RID: 133397 RVA: 0x00303984 File Offset: 0x00301B84
		// (set) Token: 0x06020916 RID: 133398 RVA: 0x003039BD File Offset: 0x00301BBD
		public FCircleClipParameters CircleClipParameters
		{
			get
			{
				base.FastCheckIsValid();
				FCircleClipParameters result;
				if ((result = this._CircleClipParameters) == null)
				{
					result = (this._CircleClipParameters = new FCircleClipParameters(base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_CircleClipParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCircleClipParameters.StaticStruct(), base.NativePtr + (IntPtr)UUINiagara.__PropertyOffset_CircleClipParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007F65 RID: 32613
		// (get) Token: 0x06020917 RID: 133399 RVA: 0x003039DE File Offset: 0x00301BDE
		// (set) Token: 0x06020918 RID: 133400 RVA: 0x003039F2 File Offset: 0x00301BF2
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

		// Token: 0x17007F66 RID: 32614
		// (get) Token: 0x06020919 RID: 133401 RVA: 0x00303A07 File Offset: 0x00301C07
		// (set) Token: 0x0602091A RID: 133402 RVA: 0x00303A17 File Offset: 0x00301C17
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

		// Token: 0x17007F67 RID: 32615
		// (get) Token: 0x0602091B RID: 133403 RVA: 0x00303A28 File Offset: 0x00301C28
		// (set) Token: 0x0602091C RID: 133404 RVA: 0x00303A38 File Offset: 0x00301C38
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

		// Token: 0x17007F68 RID: 32616
		// (get) Token: 0x0602091D RID: 133405 RVA: 0x00303A49 File Offset: 0x00301C49
		// (set) Token: 0x0602091E RID: 133406 RVA: 0x00303A59 File Offset: 0x00301C59
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

		// Token: 0x17007F69 RID: 32617
		// (get) Token: 0x0602091F RID: 133407 RVA: 0x00303A6A File Offset: 0x00301C6A
		// (set) Token: 0x06020920 RID: 133408 RVA: 0x00303A7E File Offset: 0x00301C7E
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

		// Token: 0x17007F6A RID: 32618
		// (get) Token: 0x06020921 RID: 133409 RVA: 0x00303A93 File Offset: 0x00301C93
		// (set) Token: 0x06020922 RID: 133410 RVA: 0x00303AA3 File Offset: 0x00301CA3
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

		// Token: 0x17007F6B RID: 32619
		// (get) Token: 0x06020923 RID: 133411 RVA: 0x00303AB4 File Offset: 0x00301CB4
		// (set) Token: 0x06020924 RID: 133412 RVA: 0x00303AC4 File Offset: 0x00301CC4
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

		// Token: 0x06020925 RID: 133413 RVA: 0x00303AD5 File Offset: 0x00301CD5
		public void SwitchToStop()
		{
			UUINiagara.__SwitchToStop_Internal(base.NativePtr);
		}

		// Token: 0x06020926 RID: 133414 RVA: 0x00303AE4 File Offset: 0x00301CE4
		public unsafe void SetNiagaraVarVector(string VarName, FVector Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarVector_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020927 RID: 133415 RVA: 0x00303B10 File Offset: 0x00301D10
		public unsafe void SetNiagaraVarLinearColor(string VarName, FLinearColor Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarLinearColor_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020928 RID: 133416 RVA: 0x00303B3C File Offset: 0x00301D3C
		public unsafe void SetNiagaraVarInt(string VarName, int Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarInt_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020929 RID: 133417 RVA: 0x00303B68 File Offset: 0x00301D68
		public unsafe void SetNiagaraVarFloat(string VarName, float Value)
		{
			FString fstring = FString.AllocTemp(VarName);
			UUINiagara.__SetNiagaraVarFloat_Internal(base.NativePtr, fstring, Value);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602092A RID: 133418 RVA: 0x00303B93 File Offset: 0x00301D93
		public void SetNiagaraUIActive(bool active, bool bInResetNiagara)
		{
			UUINiagara.__SetNiagaraUIActive_Internal(base.NativePtr, active, bInResetNiagara);
		}

		// Token: 0x0602092B RID: 133419 RVA: 0x00303BA2 File Offset: 0x00301DA2
		[NullableContext(2)]
		public void SetNiagaraSystem(UNiagaraSystem InSystem)
		{
			UUINiagara.__SetNiagaraSystem_Internal(base.NativePtr, (InSystem != null) ? InSystem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602092C RID: 133420 RVA: 0x00303BC0 File Offset: 0x00301DC0
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

		// Token: 0x0602092D RID: 133421 RVA: 0x00303C14 File Offset: 0x00301E14
		public unsafe void SetNiagaraEmitterFloatParam(string InEmitterName, string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UUINiagara.__SetNiagaraEmitterFloatParam_Internal(base.NativePtr, fstring, fstring2, InValue);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0602092E RID: 133422 RVA: 0x00303C54 File Offset: 0x00301E54
		public unsafe void SetNiagaraEmitterCustomTexture(string InEmitterName, string InVariableName, [Nullable(2)] UTexture InTexture)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UUINiagara.__SetNiagaraEmitterCustomTexture_Internal(base.NativePtr, fstring, fstring2, (InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0602092F RID: 133423 RVA: 0x00303CA0 File Offset: 0x00301EA0
		[NullableContext(2)]
		public void SetCircleClipParameters(in FCircleClipParameters NewCircleClipParameters)
		{
			UUINiagara.__SetCircleClipParameters_Internal(base.NativePtr, (NewCircleClipParameters ?? new FCircleClipParameters()).NativePtr);
		}

		// Token: 0x06020930 RID: 133424 RVA: 0x00303CBD File Offset: 0x00301EBD
		public void SetCircleClipEnable(bool Enable)
		{
			UUINiagara.__SetCircleClipEnable_Internal(base.NativePtr, Enable);
		}

		// Token: 0x06020931 RID: 133425 RVA: 0x00303CCB File Offset: 0x00301ECB
		public void ResetOverrideParametersAndActivate()
		{
			UUINiagara.__ResetOverrideParametersAndActivate_Internal(base.NativePtr);
		}

		// Token: 0x06020932 RID: 133426 RVA: 0x00303CD8 File Offset: 0x00301ED8
		public void ResetOverrideParameters()
		{
			UUINiagara.__ResetOverrideParameters_Internal(base.NativePtr);
		}

		// Token: 0x06020933 RID: 133427 RVA: 0x00303CE5 File Offset: 0x00301EE5
		public void ReinitializeSystem()
		{
			UUINiagara.__ReinitializeSystem_Internal(base.NativePtr);
		}

		// Token: 0x06020934 RID: 133428 RVA: 0x00303CF2 File Offset: 0x00301EF2
		public bool IsCircleClipEnable()
		{
			return UUINiagara.__IsCircleClipEnable_Internal(base.NativePtr);
		}

		// Token: 0x06020935 RID: 133429 RVA: 0x00303CFF File Offset: 0x00301EFF
		[NullableContext(2)]
		public ULGUINiagaraComponent GetNiagaraComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUINiagaraComponent>(UUINiagara.__GetNiagaraComponent_Internal(base.NativePtr));
		}

		// Token: 0x06020936 RID: 133430 RVA: 0x00303D11 File Offset: 0x00301F11
		public bool GetIsActive()
		{
			return UUINiagara.__GetIsActive_Internal(base.NativePtr);
		}

		// Token: 0x06020937 RID: 133431 RVA: 0x00303D1E File Offset: 0x00301F1E
		public FCircleClipParameters GetCircleClipParameters()
		{
			return new FCircleClipParameters(UUINiagara.__GetCircleClipParameters_Internal(base.NativePtr), null);
		}

		// Token: 0x06020938 RID: 133432 RVA: 0x00303D31 File Offset: 0x00301F31
		public void DeactivateSystem()
		{
			UUINiagara.__DeactivateSystem_Internal(base.NativePtr);
		}

		// Token: 0x06020939 RID: 133433 RVA: 0x00303D3E File Offset: 0x00301F3E
		public void ActivateSystem(bool Reset)
		{
			UUINiagara.__ActivateSystem_Internal(base.NativePtr, Reset);
		}

		// Token: 0x0602093A RID: 133434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchToStop_Internal(IntPtr @this);

		// Token: 0x0602093B RID: 133435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarVector_Internal(IntPtr @this, in FString VarName, FVector Value);

		// Token: 0x0602093C RID: 133436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarLinearColor_Internal(IntPtr @this, in FString VarName, FLinearColor Value);

		// Token: 0x0602093D RID: 133437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarInt_Internal(IntPtr @this, in FString VarName, int Value);

		// Token: 0x0602093E RID: 133438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraVarFloat_Internal(IntPtr @this, in FString VarName, float Value);

		// Token: 0x0602093F RID: 133439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraUIActive_Internal(IntPtr @this, bool active, bool bInResetNiagara);

		// Token: 0x06020940 RID: 133440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSystem_Internal(IntPtr @this, IntPtr InSystem);

		// Token: 0x06020941 RID: 133441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraEmitterVectorParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, in FVector4 InVector);

		// Token: 0x06020942 RID: 133442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraEmitterFloatParam_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, float InValue);

		// Token: 0x06020943 RID: 133443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraEmitterCustomTexture_Internal(IntPtr @this, in FString InEmitterName, in FString InVariableName, IntPtr InTexture);

		// Token: 0x06020944 RID: 133444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCircleClipParameters_Internal(IntPtr @this, IntPtr NewCircleClipParameters);

		// Token: 0x06020945 RID: 133445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCircleClipEnable_Internal(IntPtr @this, bool Enable);

		// Token: 0x06020946 RID: 133446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetOverrideParametersAndActivate_Internal(IntPtr @this);

		// Token: 0x06020947 RID: 133447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetOverrideParameters_Internal(IntPtr @this);

		// Token: 0x06020948 RID: 133448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReinitializeSystem_Internal(IntPtr @this);

		// Token: 0x06020949 RID: 133449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCircleClipEnable_Internal(IntPtr @this);

		// Token: 0x0602094A RID: 133450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraComponent_Internal(IntPtr @this);

		// Token: 0x0602094B RID: 133451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsActive_Internal(IntPtr @this);

		// Token: 0x0602094C RID: 133452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCircleClipParameters_Internal(IntPtr @this);

		// Token: 0x0602094D RID: 133453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateSystem_Internal(IntPtr @this);

		// Token: 0x0602094E RID: 133454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateSystem_Internal(IntPtr @this, bool Reset);

		// Token: 0x0602094F RID: 133455 RVA: 0x00303D4C File Offset: 0x00301F4C
		static UUINiagara()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINiagara");
		}

		// Token: 0x06020950 RID: 133456 RVA: 0x00303D5A File Offset: 0x00301F5A
		protected UUINiagara(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116F7 RID: 71415
		public new const string __ObjectPath = "/Script/LGUI.UINiagara";

		// Token: 0x040116F8 RID: 71416
		private static IntPtr _ClassPtr;

		// Token: 0x040116F9 RID: 71417
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116FA RID: 71418
		internal static int __PropertyOffset_NiagaraSystemReference;

		// Token: 0x040116FB RID: 71419
		internal static int __PropertyOffset_IsNiagaraActive;

		// Token: 0x040116FC RID: 71420
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040116FD RID: 71421
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x040116FE RID: 71422
		internal static int __PropertyOffset_EndTime;

		// Token: 0x040116FF RID: 71423
		internal static int __PropertyOffset_NiagaraLocation;

		// Token: 0x04011700 RID: 71424
		[Nullable(2)]
		private FKuroCurveVector _NiagaraLocation;

		// Token: 0x04011701 RID: 71425
		internal static int __PropertyOffset_NiagaraRotation;

		// Token: 0x04011702 RID: 71426
		[Nullable(2)]
		private FKuroCurveVector _NiagaraRotation;

		// Token: 0x04011703 RID: 71427
		internal static int __PropertyOffset_NiagaraScale;

		// Token: 0x04011704 RID: 71428
		[Nullable(2)]
		private FKuroCurveVector _NiagaraScale;

		// Token: 0x04011705 RID: 71429
		internal static int __PropertyOffset_IntParameter;

		// Token: 0x04011706 RID: 71430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _IntParameter;

		// Token: 0x04011707 RID: 71431
		internal static int __PropertyOffset_FloatParameter;

		// Token: 0x04011708 RID: 71432
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveFloat> _FloatParameter;

		// Token: 0x04011709 RID: 71433
		internal static int __PropertyOffset_VectorParameter;

		// Token: 0x0401170A RID: 71434
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveVector> _VectorParameter;

		// Token: 0x0401170B RID: 71435
		internal static int __PropertyOffset_ColorParameter;

		// Token: 0x0401170C RID: 71436
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveLinearColor> _ColorParameter;

		// Token: 0x0401170D RID: 71437
		internal static int __PropertyOffset_bAdaptPosAndSizeChanged;

		// Token: 0x0401170E RID: 71438
		internal static int __PropertyOffset_bEnableCircleClip;

		// Token: 0x0401170F RID: 71439
		internal static int __PropertyOffset_CircleClipParameters;

		// Token: 0x04011710 RID: 71440
		[Nullable(2)]
		private FCircleClipParameters _CircleClipParameters;

		// Token: 0x04011711 RID: 71441
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x04011712 RID: 71442
		internal static int __PropertyOffset_bResetNiagara;

		// Token: 0x04011713 RID: 71443
		internal static int __PropertyOffset_bIgnoreGlobalUINiagaraPause;

		// Token: 0x04011714 RID: 71444
		internal static int __PropertyOffset_bAdvancedInitNiagaraComp;

		// Token: 0x04011715 RID: 71445
		internal static int __PropertyOffset_StartEvent;

		// Token: 0x04011716 RID: 71446
		internal static int __PropertyOffset_bCanInterupt;

		// Token: 0x04011717 RID: 71447
		internal static int __PropertyOffset_FadeOutMs;
	}
}
