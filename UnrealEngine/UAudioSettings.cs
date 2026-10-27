using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200086F RID: 2159
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AudioSettings")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 536)]
	public class UAudioSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007528 RID: 29992 RVA: 0x000A7E6D File Offset: 0x000A606D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioSettings._ClassPtr;
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x000A7E7C File Offset: 0x000A607C
		public UAudioSettings() : this(BuiltinUtils.AllocNativeUObject(UAudioSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x000A7EA4 File Offset: 0x000A60A4
		public UAudioSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x0600752B RID: 29995 RVA: 0x000A7ED8 File Offset: 0x000A60D8
		// (set) Token: 0x0600752C RID: 29996 RVA: 0x000A7F11 File Offset: 0x000A6111
		public FSoftObjectPath DefaultSoundClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultSoundClassName) == null)
				{
					result = (this._DefaultSoundClassName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultSoundClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultSoundClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x0600752D RID: 29997 RVA: 0x000A7F34 File Offset: 0x000A6134
		// (set) Token: 0x0600752E RID: 29998 RVA: 0x000A7F6D File Offset: 0x000A616D
		public FSoftObjectPath DefaultMediaSoundClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultMediaSoundClassName) == null)
				{
					result = (this._DefaultMediaSoundClassName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultMediaSoundClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultMediaSoundClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x0600752F RID: 29999 RVA: 0x000A7F90 File Offset: 0x000A6190
		// (set) Token: 0x06007530 RID: 30000 RVA: 0x000A7FC9 File Offset: 0x000A61C9
		public FSoftObjectPath DefaultSoundConcurrencyName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultSoundConcurrencyName) == null)
				{
					result = (this._DefaultSoundConcurrencyName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultSoundConcurrencyName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultSoundConcurrencyName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06007531 RID: 30001 RVA: 0x000A7FEC File Offset: 0x000A61EC
		// (set) Token: 0x06007532 RID: 30002 RVA: 0x000A8025 File Offset: 0x000A6225
		public FSoftObjectPath DefaultBaseSoundMix
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultBaseSoundMix) == null)
				{
					result = (this._DefaultBaseSoundMix = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultBaseSoundMix, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultBaseSoundMix, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06007533 RID: 30003 RVA: 0x000A8048 File Offset: 0x000A6248
		// (set) Token: 0x06007534 RID: 30004 RVA: 0x000A8081 File Offset: 0x000A6281
		public FSoftObjectPath VoiPSoundClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._VoiPSoundClass) == null)
				{
					result = (this._VoiPSoundClass = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_VoiPSoundClass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_VoiPSoundClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06007535 RID: 30005 RVA: 0x000A80A4 File Offset: 0x000A62A4
		// (set) Token: 0x06007536 RID: 30006 RVA: 0x000A80DD File Offset: 0x000A62DD
		public FSoftObjectPath MasterSubmix
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._MasterSubmix) == null)
				{
					result = (this._MasterSubmix = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_MasterSubmix, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_MasterSubmix, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x000A8100 File Offset: 0x000A6300
		// (set) Token: 0x06007538 RID: 30008 RVA: 0x000A8139 File Offset: 0x000A6339
		public FSoftObjectPath ReverbSubmix
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ReverbSubmix) == null)
				{
					result = (this._ReverbSubmix = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_ReverbSubmix, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_ReverbSubmix, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06007539 RID: 30009 RVA: 0x000A815C File Offset: 0x000A635C
		// (set) Token: 0x0600753A RID: 30010 RVA: 0x000A8195 File Offset: 0x000A6395
		public FSoftObjectPath EQSubmix
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EQSubmix) == null)
				{
					result = (this._EQSubmix = new FSoftObjectPath(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_EQSubmix, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_EQSubmix, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x0600753B RID: 30011 RVA: 0x000A81B6 File Offset: 0x000A63B6
		// (set) Token: 0x0600753C RID: 30012 RVA: 0x000A81C6 File Offset: 0x000A63C6
		public unsafe EVoiceSampleRate VoiPSampleRate
		{
			get
			{
				return (EVoiceSampleRate)(*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_VoiPSampleRate));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_VoiPSampleRate) = (int)value;
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x0600753D RID: 30013 RVA: 0x000A81D7 File Offset: 0x000A63D7
		// (set) Token: 0x0600753E RID: 30014 RVA: 0x000A81E7 File Offset: 0x000A63E7
		public unsafe float DefaultReverbSendLevel_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultReverbSendLevel_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_DefaultReverbSendLevel_DEPRECATED) = value;
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x0600753F RID: 30015 RVA: 0x000A81F8 File Offset: 0x000A63F8
		// (set) Token: 0x06007540 RID: 30016 RVA: 0x000A8208 File Offset: 0x000A6408
		public unsafe int MaximumConcurrentStreams
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_MaximumConcurrentStreams);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_MaximumConcurrentStreams) = value;
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06007541 RID: 30017 RVA: 0x000A8219 File Offset: 0x000A6419
		// (set) Token: 0x06007542 RID: 30018 RVA: 0x000A8229 File Offset: 0x000A6429
		public unsafe float GlobalMinPitchScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_GlobalMinPitchScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_GlobalMinPitchScale) = value;
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06007543 RID: 30019 RVA: 0x000A823A File Offset: 0x000A643A
		// (set) Token: 0x06007544 RID: 30020 RVA: 0x000A824A File Offset: 0x000A644A
		public unsafe float GlobalMaxPitchScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_GlobalMaxPitchScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_GlobalMaxPitchScale) = value;
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06007545 RID: 30021 RVA: 0x000A825C File Offset: 0x000A645C
		// (set) Token: 0x06007546 RID: 30022 RVA: 0x000A8295 File Offset: 0x000A6495
		public TArray<FAudioQualitySettings> QualityLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAudioQualitySettings> result;
				if ((result = this._QualityLevels) == null)
				{
					result = (this._QualityLevels = new TArray<FAudioQualitySettings>(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_QualityLevels, this));
				}
				return result;
			}
			set
			{
				this.QualityLevels.CopyAssign(value);
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06007547 RID: 30023 RVA: 0x000A82A3 File Offset: 0x000A64A3
		// (set) Token: 0x06007548 RID: 30024 RVA: 0x000A82BC File Offset: 0x000A64BC
		public unsafe bool bAllowPlayWhenSilent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bAllowPlayWhenSilent) & UAudioSettings.__PropertyMask_bAllowPlayWhenSilent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bAllowPlayWhenSilent) = ((*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bAllowPlayWhenSilent) & ~UAudioSettings.__PropertyMask_bAllowPlayWhenSilent) | (value ? UAudioSettings.__PropertyMask_bAllowPlayWhenSilent : 0));
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06007549 RID: 30025 RVA: 0x000A82EC File Offset: 0x000A64EC
		// (set) Token: 0x0600754A RID: 30026 RVA: 0x000A8305 File Offset: 0x000A6505
		public unsafe bool bDisableMasterEQ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bDisableMasterEQ) & UAudioSettings.__PropertyMask_bDisableMasterEQ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bDisableMasterEQ) = ((*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bDisableMasterEQ) & ~UAudioSettings.__PropertyMask_bDisableMasterEQ) | (value ? UAudioSettings.__PropertyMask_bDisableMasterEQ : 0));
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x0600754B RID: 30027 RVA: 0x000A8335 File Offset: 0x000A6535
		// (set) Token: 0x0600754C RID: 30028 RVA: 0x000A834E File Offset: 0x000A654E
		public unsafe bool bAllowCenterChannel3DPanning
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bAllowCenterChannel3DPanning) & UAudioSettings.__PropertyMask_bAllowCenterChannel3DPanning) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bAllowCenterChannel3DPanning) = ((*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_bAllowCenterChannel3DPanning) & ~UAudioSettings.__PropertyMask_bAllowCenterChannel3DPanning) | (value ? UAudioSettings.__PropertyMask_bAllowCenterChannel3DPanning : 0));
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x0600754D RID: 30029 RVA: 0x000A837E File Offset: 0x000A657E
		// (set) Token: 0x0600754E RID: 30030 RVA: 0x000A838E File Offset: 0x000A658E
		public unsafe uint NumStoppingSources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_NumStoppingSources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_NumStoppingSources) = (int)value;
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x0600754F RID: 30031 RVA: 0x000A839F File Offset: 0x000A659F
		// (set) Token: 0x06007550 RID: 30032 RVA: 0x000A83AF File Offset: 0x000A65AF
		public unsafe EPanningMethod PanningMethod
		{
			get
			{
				return (EPanningMethod)(*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_PanningMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_PanningMethod) = (byte)value;
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06007551 RID: 30033 RVA: 0x000A83C0 File Offset: 0x000A65C0
		// (set) Token: 0x06007552 RID: 30034 RVA: 0x000A83D0 File Offset: 0x000A65D0
		public unsafe EMonoChannelUpmixMethod MonoChannelUpmixMethod
		{
			get
			{
				return (EMonoChannelUpmixMethod)(*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_MonoChannelUpmixMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioSettings.__PropertyOffset_MonoChannelUpmixMethod) = (byte)value;
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06007553 RID: 30035 RVA: 0x000A83E1 File Offset: 0x000A65E1
		// (set) Token: 0x06007554 RID: 30036 RVA: 0x000A83F5 File Offset: 0x000A65F5
		public unsafe string DialogueFilenameFormat
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAudioSettings.__PropertyOffset_DialogueFilenameFormat)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAudioSettings.__PropertyOffset_DialogueFilenameFormat)), value);
			}
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x000A840A File Offset: 0x000A660A
		static UAudioSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AudioSettings");
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x000A8418 File Offset: 0x000A6618
		protected UAudioSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400384F RID: 14415
		public new const string __ObjectPath = "/Script/Engine.AudioSettings";

		// Token: 0x04003850 RID: 14416
		private static IntPtr _ClassPtr;

		// Token: 0x04003851 RID: 14417
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003852 RID: 14418
		internal static int __PropertyOffset_DefaultSoundClassName;

		// Token: 0x04003853 RID: 14419
		[Nullable(2)]
		private FSoftObjectPath _DefaultSoundClassName;

		// Token: 0x04003854 RID: 14420
		internal static int __PropertyOffset_DefaultMediaSoundClassName;

		// Token: 0x04003855 RID: 14421
		[Nullable(2)]
		private FSoftObjectPath _DefaultMediaSoundClassName;

		// Token: 0x04003856 RID: 14422
		internal static int __PropertyOffset_DefaultSoundConcurrencyName;

		// Token: 0x04003857 RID: 14423
		[Nullable(2)]
		private FSoftObjectPath _DefaultSoundConcurrencyName;

		// Token: 0x04003858 RID: 14424
		internal static int __PropertyOffset_DefaultBaseSoundMix;

		// Token: 0x04003859 RID: 14425
		[Nullable(2)]
		private FSoftObjectPath _DefaultBaseSoundMix;

		// Token: 0x0400385A RID: 14426
		internal static int __PropertyOffset_VoiPSoundClass;

		// Token: 0x0400385B RID: 14427
		[Nullable(2)]
		private FSoftObjectPath _VoiPSoundClass;

		// Token: 0x0400385C RID: 14428
		internal static int __PropertyOffset_MasterSubmix;

		// Token: 0x0400385D RID: 14429
		[Nullable(2)]
		private FSoftObjectPath _MasterSubmix;

		// Token: 0x0400385E RID: 14430
		internal static int __PropertyOffset_ReverbSubmix;

		// Token: 0x0400385F RID: 14431
		[Nullable(2)]
		private FSoftObjectPath _ReverbSubmix;

		// Token: 0x04003860 RID: 14432
		internal static int __PropertyOffset_EQSubmix;

		// Token: 0x04003861 RID: 14433
		[Nullable(2)]
		private FSoftObjectPath _EQSubmix;

		// Token: 0x04003862 RID: 14434
		internal static int __PropertyOffset_VoiPSampleRate;

		// Token: 0x04003863 RID: 14435
		internal static int __PropertyOffset_DefaultReverbSendLevel_DEPRECATED;

		// Token: 0x04003864 RID: 14436
		internal static int __PropertyOffset_MaximumConcurrentStreams;

		// Token: 0x04003865 RID: 14437
		internal static int __PropertyOffset_GlobalMinPitchScale;

		// Token: 0x04003866 RID: 14438
		internal static int __PropertyOffset_GlobalMaxPitchScale;

		// Token: 0x04003867 RID: 14439
		internal static int __PropertyOffset_QualityLevels;

		// Token: 0x04003868 RID: 14440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAudioQualitySettings> _QualityLevels;

		// Token: 0x04003869 RID: 14441
		internal static int __PropertyOffset_bAllowPlayWhenSilent;

		// Token: 0x0400386A RID: 14442
		internal static byte __PropertyMask_bAllowPlayWhenSilent;

		// Token: 0x0400386B RID: 14443
		internal static int __PropertyOffset_bDisableMasterEQ;

		// Token: 0x0400386C RID: 14444
		internal static byte __PropertyMask_bDisableMasterEQ;

		// Token: 0x0400386D RID: 14445
		internal static int __PropertyOffset_bAllowCenterChannel3DPanning;

		// Token: 0x0400386E RID: 14446
		internal static byte __PropertyMask_bAllowCenterChannel3DPanning;

		// Token: 0x0400386F RID: 14447
		internal static int __PropertyOffset_NumStoppingSources;

		// Token: 0x04003870 RID: 14448
		internal static int __PropertyOffset_PanningMethod;

		// Token: 0x04003871 RID: 14449
		internal static int __PropertyOffset_MonoChannelUpmixMethod;

		// Token: 0x04003872 RID: 14450
		internal static int __PropertyOffset_DialogueFilenameFormat;
	}
}
