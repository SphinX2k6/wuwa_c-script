using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DD RID: 477
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.PawnSensingComponent")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UPawnSensingComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C21 RID: 7201 RVA: 0x00029ECF File Offset: 0x000280CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnSensingComponent._ClassPtr;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00029EDC File Offset: 0x000280DC
		public UPawnSensingComponent() : this(BuiltinUtils.AllocNativeUObject(UPawnSensingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00029F04 File Offset: 0x00028104
		public UPawnSensingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPawnSensingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00029F37 File Offset: 0x00028137
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00029F47 File Offset: 0x00028147
		public unsafe float HearingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_HearingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_HearingThreshold) = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00029F58 File Offset: 0x00028158
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00029F68 File Offset: 0x00028168
		public unsafe float LOSHearingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_LOSHearingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_LOSHearingThreshold) = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00029F79 File Offset: 0x00028179
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00029F89 File Offset: 0x00028189
		public unsafe float SightRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_SightRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_SightRadius) = value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00029F9A File Offset: 0x0002819A
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00029FAA File Offset: 0x000281AA
		public unsafe float SensingInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_SensingInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_SensingInterval) = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00029FBB File Offset: 0x000281BB
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00029FCB File Offset: 0x000281CB
		public unsafe float HearingMaxSoundAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_HearingMaxSoundAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_HearingMaxSoundAge) = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00029FDC File Offset: 0x000281DC
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00029FF5 File Offset: 0x000281F5
		public unsafe bool bEnableSensingUpdates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bEnableSensingUpdates) & UPawnSensingComponent.__PropertyMask_bEnableSensingUpdates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bEnableSensingUpdates) = ((*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bEnableSensingUpdates) & ~UPawnSensingComponent.__PropertyMask_bEnableSensingUpdates) | (value ? UPawnSensingComponent.__PropertyMask_bEnableSensingUpdates : 0));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0002A025 File Offset: 0x00028225
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x0002A03E File Offset: 0x0002823E
		public unsafe bool bOnlySensePlayers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bOnlySensePlayers) & UPawnSensingComponent.__PropertyMask_bOnlySensePlayers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bOnlySensePlayers) = ((*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bOnlySensePlayers) & ~UPawnSensingComponent.__PropertyMask_bOnlySensePlayers) | (value ? UPawnSensingComponent.__PropertyMask_bOnlySensePlayers : 0));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0002A06E File Offset: 0x0002826E
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x0002A087 File Offset: 0x00028287
		public unsafe bool bSeePawns
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bSeePawns) & UPawnSensingComponent.__PropertyMask_bSeePawns) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bSeePawns) = ((*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bSeePawns) & ~UPawnSensingComponent.__PropertyMask_bSeePawns) | (value ? UPawnSensingComponent.__PropertyMask_bSeePawns : 0));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0002A0B7 File Offset: 0x000282B7
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x0002A0D0 File Offset: 0x000282D0
		public unsafe bool bHearNoises
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bHearNoises) & UPawnSensingComponent.__PropertyMask_bHearNoises) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bHearNoises) = ((*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_bHearNoises) & ~UPawnSensingComponent.__PropertyMask_bHearNoises) | (value ? UPawnSensingComponent.__PropertyMask_bHearNoises : 0));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x0002A100 File Offset: 0x00028300
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x0002A139 File Offset: 0x00028339
		public FSeePawnDelegate OnSeePawn
		{
			get
			{
				base.FastCheckIsValid();
				FSeePawnDelegate result;
				if ((result = this._OnSeePawn) == null)
				{
					result = (this._OnSeePawn = new FSeePawnDelegate(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_OnSeePawn, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_OnSeePawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x0002A15C File Offset: 0x0002835C
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x0002A195 File Offset: 0x00028395
		public FHearNoiseDelegate OnHearNoise
		{
			get
			{
				base.FastCheckIsValid();
				FHearNoiseDelegate result;
				if ((result = this._OnHearNoise) == null)
				{
					result = (this._OnHearNoise = new FHearNoiseDelegate(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_OnHearNoise, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_OnHearNoise, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0002A1B6 File Offset: 0x000283B6
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x0002A1C6 File Offset: 0x000283C6
		public unsafe float PeripheralVisionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_PeripheralVisionAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_PeripheralVisionAngle) = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0002A1D7 File Offset: 0x000283D7
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x0002A1E7 File Offset: 0x000283E7
		public unsafe float PeripheralVisionCosine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_PeripheralVisionCosine);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnSensingComponent.__PropertyOffset_PeripheralVisionCosine) = value;
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0002A1F8 File Offset: 0x000283F8
		public void SetSensingUpdatesEnabled(bool bEnabled)
		{
			UPawnSensingComponent.__SetSensingUpdatesEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0002A206 File Offset: 0x00028406
		public void SetSensingInterval(float NewSensingInterval)
		{
			UPawnSensingComponent.__SetSensingInterval_Internal(base.NativePtr, NewSensingInterval);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0002A214 File Offset: 0x00028414
		public void SetPeripheralVisionAngle(float NewPeripheralVisionAngle)
		{
			UPawnSensingComponent.__SetPeripheralVisionAngle_Internal(base.NativePtr, NewPeripheralVisionAngle);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0002A222 File Offset: 0x00028422
		public float GetPeripheralVisionCosine()
		{
			return UPawnSensingComponent.__GetPeripheralVisionCosine_Internal(base.NativePtr);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0002A22F File Offset: 0x0002842F
		public float GetPeripheralVisionAngle()
		{
			return UPawnSensingComponent.__GetPeripheralVisionAngle_Internal(base.NativePtr);
		}

		// Token: 0x06001C43 RID: 7235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSensingUpdatesEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06001C44 RID: 7236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSensingInterval_Internal(IntPtr @this, float NewSensingInterval);

		// Token: 0x06001C45 RID: 7237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPeripheralVisionAngle_Internal(IntPtr @this, float NewPeripheralVisionAngle);

		// Token: 0x06001C46 RID: 7238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPeripheralVisionCosine_Internal(IntPtr @this);

		// Token: 0x06001C47 RID: 7239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPeripheralVisionAngle_Internal(IntPtr @this);

		// Token: 0x06001C48 RID: 7240 RVA: 0x0002A23C File Offset: 0x0002843C
		static UPawnSensingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnSensingComponent");
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0002A24A File Offset: 0x0002844A
		protected UPawnSensingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000920 RID: 2336
		public new const string __ObjectPath = "/Script/AIModule.PawnSensingComponent";

		// Token: 0x04000921 RID: 2337
		private static IntPtr _ClassPtr;

		// Token: 0x04000922 RID: 2338
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000923 RID: 2339
		public static IntPtr __SeePawnDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000924 RID: 2340
		public static IntPtr __HearNoiseDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000925 RID: 2341
		internal static int __PropertyOffset_HearingThreshold;

		// Token: 0x04000926 RID: 2342
		internal static int __PropertyOffset_LOSHearingThreshold;

		// Token: 0x04000927 RID: 2343
		internal static int __PropertyOffset_SightRadius;

		// Token: 0x04000928 RID: 2344
		internal static int __PropertyOffset_SensingInterval;

		// Token: 0x04000929 RID: 2345
		internal static int __PropertyOffset_HearingMaxSoundAge;

		// Token: 0x0400092A RID: 2346
		internal static int __PropertyOffset_bEnableSensingUpdates;

		// Token: 0x0400092B RID: 2347
		internal static byte __PropertyMask_bEnableSensingUpdates;

		// Token: 0x0400092C RID: 2348
		internal static int __PropertyOffset_bOnlySensePlayers;

		// Token: 0x0400092D RID: 2349
		internal static byte __PropertyMask_bOnlySensePlayers;

		// Token: 0x0400092E RID: 2350
		internal static int __PropertyOffset_bSeePawns;

		// Token: 0x0400092F RID: 2351
		internal static byte __PropertyMask_bSeePawns;

		// Token: 0x04000930 RID: 2352
		internal static int __PropertyOffset_bHearNoises;

		// Token: 0x04000931 RID: 2353
		internal static byte __PropertyMask_bHearNoises;

		// Token: 0x04000932 RID: 2354
		internal static int __PropertyOffset_OnSeePawn;

		// Token: 0x04000933 RID: 2355
		[Nullable(2)]
		private FSeePawnDelegate _OnSeePawn;

		// Token: 0x04000934 RID: 2356
		internal static int __PropertyOffset_OnHearNoise;

		// Token: 0x04000935 RID: 2357
		[Nullable(2)]
		private FHearNoiseDelegate _OnHearNoise;

		// Token: 0x04000936 RID: 2358
		internal static int __PropertyOffset_PeripheralVisionAngle;

		// Token: 0x04000937 RID: 2359
		internal static int __PropertyOffset_PeripheralVisionCosine;
	}
}
