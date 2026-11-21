using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E8 RID: 232
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CineCameraComponent")]
	[UnrealStructLayout(3664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3664)]
	public class UCineCameraComponent : UCameraComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x00019DB7 File Offset: 0x00017FB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCineCameraComponent._ClassPtr;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00019DC4 File Offset: 0x00017FC4
		public UCineCameraComponent() : this(BuiltinUtils.AllocNativeUObject(UCineCameraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00019DEC File Offset: 0x00017FEC
		public UCineCameraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCineCameraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00019E20 File Offset: 0x00018020
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00019E59 File Offset: 0x00018059
		public FCameraFilmbackSettings FilmbackSettings_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFilmbackSettings result;
				if ((result = this._FilmbackSettings_DEPRECATED) == null)
				{
					result = (this._FilmbackSettings_DEPRECATED = new FCameraFilmbackSettings(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_FilmbackSettings_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFilmbackSettings.StaticStruct(), base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_FilmbackSettings_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00019E7C File Offset: 0x0001807C
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00019EB5 File Offset: 0x000180B5
		public FCameraFilmbackSettings Filmback
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFilmbackSettings result;
				if ((result = this._Filmback) == null)
				{
					result = (this._Filmback = new FCameraFilmbackSettings(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_Filmback, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFilmbackSettings.StaticStruct(), base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_Filmback, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00019ED8 File Offset: 0x000180D8
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00019F11 File Offset: 0x00018111
		public FCameraLensSettings LensSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraLensSettings result;
				if ((result = this._LensSettings) == null)
				{
					result = (this._LensSettings = new FCameraLensSettings(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_LensSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraLensSettings.StaticStruct(), base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_LensSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00019F34 File Offset: 0x00018134
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00019F6D File Offset: 0x0001816D
		public FCameraFocusSettings FocusSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraFocusSettings result;
				if ((result = this._FocusSettings) == null)
				{
					result = (this._FocusSettings = new FCameraFocusSettings(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_FocusSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraFocusSettings.StaticStruct(), base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_FocusSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00019F8E File Offset: 0x0001818E
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00019F9E File Offset: 0x0001819E
		public unsafe float CurrentFocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocalLength) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00019FAF File Offset: 0x000181AF
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x00019FBF File Offset: 0x000181BF
		public unsafe float CurrentFocalLengthExtra
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocalLengthExtra);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocalLengthExtra) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00019FD0 File Offset: 0x000181D0
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x00019FE0 File Offset: 0x000181E0
		public unsafe float CurrentAperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentAperture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentAperture) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00019FF1 File Offset: 0x000181F1
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x0001A001 File Offset: 0x00018201
		public unsafe float CurrentFocalRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocalRegion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocalRegion) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0001A012 File Offset: 0x00018212
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x0001A022 File Offset: 0x00018222
		public unsafe float CurrentFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocusDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_CurrentFocusDistance) = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0001A034 File Offset: 0x00018234
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0001A06D File Offset: 0x0001826D
		public TArray<FNamedFilmbackPreset> FilmbackPresets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedFilmbackPreset> result;
				if ((result = this._FilmbackPresets) == null)
				{
					result = (this._FilmbackPresets = new TArray<FNamedFilmbackPreset>(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_FilmbackPresets, this));
				}
				return result;
			}
			set
			{
				this.FilmbackPresets.CopyAssign(value);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0001A07C File Offset: 0x0001827C
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0001A0B5 File Offset: 0x000182B5
		public TArray<FNamedLensPreset> LensPresets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedLensPreset> result;
				if ((result = this._LensPresets) == null)
				{
					result = (this._LensPresets = new TArray<FNamedLensPreset>(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_LensPresets, this));
				}
				return result;
			}
			set
			{
				this.LensPresets.CopyAssign(value);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0001A0C3 File Offset: 0x000182C3
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x0001A0D7 File Offset: 0x000182D7
		public unsafe string DefaultFilmbackPresetName_DEPRECATED
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCineCameraComponent.__PropertyOffset_DefaultFilmbackPresetName_DEPRECATED)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCineCameraComponent.__PropertyOffset_DefaultFilmbackPresetName_DEPRECATED)), value);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0001A0EC File Offset: 0x000182EC
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0001A100 File Offset: 0x00018300
		public unsafe string DefaultFilmbackPreset
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCineCameraComponent.__PropertyOffset_DefaultFilmbackPreset)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCineCameraComponent.__PropertyOffset_DefaultFilmbackPreset)), value);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0001A115 File Offset: 0x00018315
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0001A129 File Offset: 0x00018329
		public unsafe string DefaultLensPresetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCineCameraComponent.__PropertyOffset_DefaultLensPresetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCineCameraComponent.__PropertyOffset_DefaultLensPresetName)), value);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0001A13E File Offset: 0x0001833E
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x0001A14E File Offset: 0x0001834E
		public unsafe float DefaultLensFocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_DefaultLensFocalLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_DefaultLensFocalLength) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0001A15F File Offset: 0x0001835F
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x0001A16F File Offset: 0x0001836F
		public unsafe float DefaultLensFStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_DefaultLensFStop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCineCameraComponent.__PropertyOffset_DefaultLensFStop) = value;
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0001A180 File Offset: 0x00018380
		public unsafe void SetLensPresetByName(string InPresetName)
		{
			FString fstring = FString.AllocTemp(InPresetName);
			UCineCameraComponent.__SetLensPresetByName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0001A1AC File Offset: 0x000183AC
		public unsafe void SetFilmbackPresetByName(string InPresetName)
		{
			FString fstring = FString.AllocTemp(InPresetName);
			UCineCameraComponent.__SetFilmbackPresetByName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0001A1D6 File Offset: 0x000183D6
		public void SetCurrentFocalLengthExtra(float InFocalLength)
		{
			UCineCameraComponent.__SetCurrentFocalLengthExtra_Internal(base.NativePtr, InFocalLength);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0001A1E4 File Offset: 0x000183E4
		public void SetCurrentFocalLength(float InFocalLength)
		{
			UCineCameraComponent.__SetCurrentFocalLength_Internal(base.NativePtr, InFocalLength);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0001A1F2 File Offset: 0x000183F2
		public float GetVerticalFieldOfView()
		{
			return UCineCameraComponent.__GetVerticalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0001A1FF File Offset: 0x000183FF
		public static TArray<FNamedLensPreset> GetLensPresetsCopy()
		{
			return new TArray<FNamedLensPreset>(UCineCameraComponent.__GetLensPresetsCopy_Internal(), null);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0001A20C File Offset: 0x0001840C
		public string GetLensPresetName()
		{
			return FString.ToStringAndDeleteNativePtr(UCineCameraComponent.__GetLensPresetName_Internal(base.NativePtr));
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0001A21E File Offset: 0x0001841E
		public float GetHorizontalFieldOfView()
		{
			return UCineCameraComponent.__GetHorizontalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0001A22B File Offset: 0x0001842B
		public static TArray<FNamedFilmbackPreset> GetFilmbackPresetsCopy()
		{
			return new TArray<FNamedFilmbackPreset>(UCineCameraComponent.__GetFilmbackPresetsCopy_Internal(), null);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0001A238 File Offset: 0x00018438
		public string GetFilmbackPresetName()
		{
			return FString.ToStringAndDeleteNativePtr(UCineCameraComponent.__GetFilmbackPresetName_Internal(base.NativePtr));
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0001A24A File Offset: 0x0001844A
		public string GetDefaultFilmbackPresetName()
		{
			return FString.ToStringAndDeleteNativePtr(UCineCameraComponent.__GetDefaultFilmbackPresetName_Internal(base.NativePtr));
		}

		// Token: 0x0600105F RID: 4191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLensPresetByName_Internal(IntPtr @this, in FString InPresetName);

		// Token: 0x06001060 RID: 4192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFilmbackPresetByName_Internal(IntPtr @this, in FString InPresetName);

		// Token: 0x06001061 RID: 4193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentFocalLengthExtra_Internal(IntPtr @this, float InFocalLength);

		// Token: 0x06001062 RID: 4194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentFocalLength_Internal(IntPtr @this, float InFocalLength);

		// Token: 0x06001063 RID: 4195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVerticalFieldOfView_Internal(IntPtr @this);

		// Token: 0x06001064 RID: 4196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLensPresetsCopy_Internal();

		// Token: 0x06001065 RID: 4197
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLensPresetName_Internal(IntPtr @this);

		// Token: 0x06001066 RID: 4198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalFieldOfView_Internal(IntPtr @this);

		// Token: 0x06001067 RID: 4199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFilmbackPresetsCopy_Internal();

		// Token: 0x06001068 RID: 4200
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFilmbackPresetName_Internal(IntPtr @this);

		// Token: 0x06001069 RID: 4201
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDefaultFilmbackPresetName_Internal(IntPtr @this);

		// Token: 0x0600106A RID: 4202 RVA: 0x0001A25C File Offset: 0x0001845C
		static UCineCameraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CinematicCamera.CineCameraComponent");
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0001A26A File Offset: 0x0001846A
		protected UCineCameraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003CA RID: 970
		public new const string __ObjectPath = "/Script/CinematicCamera.CineCameraComponent";

		// Token: 0x040003CB RID: 971
		private static IntPtr _ClassPtr;

		// Token: 0x040003CC RID: 972
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003CD RID: 973
		internal static int __PropertyOffset_FilmbackSettings_DEPRECATED;

		// Token: 0x040003CE RID: 974
		[Nullable(2)]
		private FCameraFilmbackSettings _FilmbackSettings_DEPRECATED;

		// Token: 0x040003CF RID: 975
		internal static int __PropertyOffset_Filmback;

		// Token: 0x040003D0 RID: 976
		[Nullable(2)]
		private FCameraFilmbackSettings _Filmback;

		// Token: 0x040003D1 RID: 977
		internal static int __PropertyOffset_LensSettings;

		// Token: 0x040003D2 RID: 978
		[Nullable(2)]
		private FCameraLensSettings _LensSettings;

		// Token: 0x040003D3 RID: 979
		internal static int __PropertyOffset_FocusSettings;

		// Token: 0x040003D4 RID: 980
		[Nullable(2)]
		private FCameraFocusSettings _FocusSettings;

		// Token: 0x040003D5 RID: 981
		internal static int __PropertyOffset_CurrentFocalLength;

		// Token: 0x040003D6 RID: 982
		internal static int __PropertyOffset_CurrentFocalLengthExtra;

		// Token: 0x040003D7 RID: 983
		internal static int __PropertyOffset_CurrentAperture;

		// Token: 0x040003D8 RID: 984
		internal static int __PropertyOffset_CurrentFocalRegion;

		// Token: 0x040003D9 RID: 985
		internal static int __PropertyOffset_CurrentFocusDistance;

		// Token: 0x040003DA RID: 986
		internal static int __PropertyOffset_FilmbackPresets;

		// Token: 0x040003DB RID: 987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedFilmbackPreset> _FilmbackPresets;

		// Token: 0x040003DC RID: 988
		internal static int __PropertyOffset_LensPresets;

		// Token: 0x040003DD RID: 989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedLensPreset> _LensPresets;

		// Token: 0x040003DE RID: 990
		internal static int __PropertyOffset_DefaultFilmbackPresetName_DEPRECATED;

		// Token: 0x040003DF RID: 991
		internal static int __PropertyOffset_DefaultFilmbackPreset;

		// Token: 0x040003E0 RID: 992
		internal static int __PropertyOffset_DefaultLensPresetName;

		// Token: 0x040003E1 RID: 993
		internal static int __PropertyOffset_DefaultLensFocalLength;

		// Token: 0x040003E2 RID: 994
		internal static int __PropertyOffset_DefaultLensFStop;
	}
}
