using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002568 RID: 9576
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceAudioPlayer")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UNiagaraDataInterfaceAudioPlayer : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238F6 RID: 145654 RVA: 0x00349095 File Offset: 0x00347295
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceAudioPlayer._ClassPtr;
		}

		// Token: 0x060238F7 RID: 145655 RVA: 0x003490A4 File Offset: 0x003472A4
		public UNiagaraDataInterfaceAudioPlayer() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238F8 RID: 145656 RVA: 0x003490CC File Offset: 0x003472CC
		[NullableContext(1)]
		public UNiagaraDataInterfaceAudioPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700886F RID: 34927
		// (get) Token: 0x060238F9 RID: 145657 RVA: 0x003490FF File Offset: 0x003472FF
		// (set) Token: 0x060238FA RID: 145658 RVA: 0x00349113 File Offset: 0x00347313
		public unsafe USoundBase SoundToPlay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_SoundToPlay);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_SoundToPlay, value);
			}
		}

		// Token: 0x17008870 RID: 34928
		// (get) Token: 0x060238FB RID: 145659 RVA: 0x00349128 File Offset: 0x00347328
		// (set) Token: 0x060238FC RID: 145660 RVA: 0x0034913C File Offset: 0x0034733C
		public unsafe USoundAttenuation Attenuation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_Attenuation);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_Attenuation, value);
			}
		}

		// Token: 0x17008871 RID: 34929
		// (get) Token: 0x060238FD RID: 145661 RVA: 0x00349151 File Offset: 0x00347351
		// (set) Token: 0x060238FE RID: 145662 RVA: 0x00349165 File Offset: 0x00347365
		public unsafe USoundConcurrency Concurrency
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundConcurrency>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_Concurrency);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_Concurrency, value);
			}
		}

		// Token: 0x17008872 RID: 34930
		// (get) Token: 0x060238FF RID: 145663 RVA: 0x0034917C File Offset: 0x0034737C
		// (set) Token: 0x06023900 RID: 145664 RVA: 0x003491B5 File Offset: 0x003473B5
		[Nullable(1)]
		public TArray<FName> ParameterNames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ParameterNames) == null)
				{
					result = (this._ParameterNames = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_ParameterNames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParameterNames.CopyAssign(value);
			}
		}

		// Token: 0x17008873 RID: 34931
		// (get) Token: 0x06023901 RID: 145665 RVA: 0x003491C3 File Offset: 0x003473C3
		// (set) Token: 0x06023902 RID: 145666 RVA: 0x003491D3 File Offset: 0x003473D3
		public unsafe bool bLimitPlaysPerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_bLimitPlaysPerTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_bLimitPlaysPerTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008874 RID: 34932
		// (get) Token: 0x06023903 RID: 145667 RVA: 0x003491E4 File Offset: 0x003473E4
		// (set) Token: 0x06023904 RID: 145668 RVA: 0x003491F4 File Offset: 0x003473F4
		public unsafe int MaxPlaysPerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_MaxPlaysPerTick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_MaxPlaysPerTick) = value;
			}
		}

		// Token: 0x17008875 RID: 34933
		// (get) Token: 0x06023905 RID: 145669 RVA: 0x00349205 File Offset: 0x00347405
		// (set) Token: 0x06023906 RID: 145670 RVA: 0x00349215 File Offset: 0x00347415
		public unsafe bool bStopWhenComponentIsDestroyed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_bStopWhenComponentIsDestroyed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceAudioPlayer.__PropertyOffset_bStopWhenComponentIsDestroyed) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023907 RID: 145671 RVA: 0x00349226 File Offset: 0x00347426
		static UNiagaraDataInterfaceAudioPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceAudioPlayer");
		}

		// Token: 0x06023908 RID: 145672 RVA: 0x00349234 File Offset: 0x00347434
		protected UNiagaraDataInterfaceAudioPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130F6 RID: 78070
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceAudioPlayer";

		// Token: 0x040130F7 RID: 78071
		private static IntPtr _ClassPtr;

		// Token: 0x040130F8 RID: 78072
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130F9 RID: 78073
		internal static int __PropertyOffset_SoundToPlay;

		// Token: 0x040130FA RID: 78074
		internal static int __PropertyOffset_Attenuation;

		// Token: 0x040130FB RID: 78075
		internal static int __PropertyOffset_Concurrency;

		// Token: 0x040130FC RID: 78076
		internal static int __PropertyOffset_ParameterNames;

		// Token: 0x040130FD RID: 78077
		private TArray<FName> _ParameterNames;

		// Token: 0x040130FE RID: 78078
		internal static int __PropertyOffset_bLimitPlaysPerTick;

		// Token: 0x040130FF RID: 78079
		internal static int __PropertyOffset_MaxPlaysPerTick;

		// Token: 0x04013100 RID: 78080
		internal static int __PropertyOffset_bStopWhenComponentIsDestroyed;
	}
}
