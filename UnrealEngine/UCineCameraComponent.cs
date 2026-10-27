using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000478 RID: 1144
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CineCameraComponent")]
	[UnrealStructLayout(3616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3616)]
	public class UCineCameraComponent : UCameraComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003D3D RID: 15677 RVA: 0x0005C1AF File Offset: 0x0005A3AF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCineCameraComponent._ClassPtr;
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x0005C1BC File Offset: 0x0005A3BC
		public UCineCameraComponent() : this(BuiltinUtils.AllocNativeUObject(UCineCameraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x0005C1E4 File Offset: 0x0005A3E4
		public UCineCameraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCineCameraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x0005C218 File Offset: 0x0005A418
		// (set) Token: 0x06003D41 RID: 15681 RVA: 0x0005C251 File Offset: 0x0005A451
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

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x0005C274 File Offset: 0x0005A474
		// (set) Token: 0x06003D43 RID: 15683 RVA: 0x0005C2AD File Offset: 0x0005A4AD
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

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06003D44 RID: 15684 RVA: 0x0005C2D0 File Offset: 0x0005A4D0
		// (set) Token: 0x06003D45 RID: 15685 RVA: 0x0005C309 File Offset: 0x0005A509
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

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06003D46 RID: 15686 RVA: 0x0005C32C File Offset: 0x0005A52C
		// (set) Token: 0x06003D47 RID: 15687 RVA: 0x0005C365 File Offset: 0x0005A565
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

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06003D48 RID: 15688 RVA: 0x0005C386 File Offset: 0x0005A586
		// (set) Token: 0x06003D49 RID: 15689 RVA: 0x0005C396 File Offset: 0x0005A596
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

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x0005C3A7 File Offset: 0x0005A5A7
		// (set) Token: 0x06003D4B RID: 15691 RVA: 0x0005C3B7 File Offset: 0x0005A5B7
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

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		// (set) Token: 0x06003D4D RID: 15693 RVA: 0x0005C3D8 File Offset: 0x0005A5D8
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

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x0005C3E9 File Offset: 0x0005A5E9
		// (set) Token: 0x06003D4F RID: 15695 RVA: 0x0005C3F9 File Offset: 0x0005A5F9
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

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x0005C40A File Offset: 0x0005A60A
		// (set) Token: 0x06003D51 RID: 15697 RVA: 0x0005C41A File Offset: 0x0005A61A
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

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06003D52 RID: 15698 RVA: 0x0005C42C File Offset: 0x0005A62C
		// (set) Token: 0x06003D53 RID: 15699 RVA: 0x0005C465 File Offset: 0x0005A665
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

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06003D54 RID: 15700 RVA: 0x0005C474 File Offset: 0x0005A674
		// (set) Token: 0x06003D55 RID: 15701 RVA: 0x0005C4AD File Offset: 0x0005A6AD
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

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x0005C4BB File Offset: 0x0005A6BB
		// (set) Token: 0x06003D57 RID: 15703 RVA: 0x0005C4CF File Offset: 0x0005A6CF
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x0005C4E4 File Offset: 0x0005A6E4
		// (set) Token: 0x06003D59 RID: 15705 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
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

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x0005C50D File Offset: 0x0005A70D
		// (set) Token: 0x06003D5B RID: 15707 RVA: 0x0005C521 File Offset: 0x0005A721
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

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x0005C536 File Offset: 0x0005A736
		// (set) Token: 0x06003D5D RID: 15709 RVA: 0x0005C546 File Offset: 0x0005A746
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

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x0005C557 File Offset: 0x0005A757
		// (set) Token: 0x06003D5F RID: 15711 RVA: 0x0005C567 File Offset: 0x0005A767
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

		// Token: 0x06003D60 RID: 15712 RVA: 0x0005C578 File Offset: 0x0005A778
		public unsafe void SetLensPresetByName(string InPresetName)
		{
			FString fstring = FString.AllocTemp(InPresetName);
			UCineCameraComponent.__SetLensPresetByName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x0005C5A4 File Offset: 0x0005A7A4
		public unsafe void SetFilmbackPresetByName(string InPresetName)
		{
			FString fstring = FString.AllocTemp(InPresetName);
			UCineCameraComponent.__SetFilmbackPresetByName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x0005C5CE File Offset: 0x0005A7CE
		public void SetCurrentFocalLengthExtra(float InFocalLength)
		{
			UCineCameraComponent.__SetCurrentFocalLengthExtra_Internal(base.NativePtr, InFocalLength);
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x0005C5DC File Offset: 0x0005A7DC
		public void SetCurrentFocalLength(float InFocalLength)
		{
			UCineCameraComponent.__SetCurrentFocalLength_Internal(base.NativePtr, InFocalLength);
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x0005C5EA File Offset: 0x0005A7EA
		public float GetVerticalFieldOfView()
		{
			return UCineCameraComponent.__GetVerticalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x0005C5F7 File Offset: 0x0005A7F7
		public static TArray<FNamedLensPreset> GetLensPresetsCopy()
		{
			return new TArray<FNamedLensPreset>(UCineCameraComponent.__GetLensPresetsCopy_Internal(), null);
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x0005C604 File Offset: 0x0005A804
		public string GetLensPresetName()
		{
			return FString.ToStringAndDeleteNativePtr(UCineCameraComponent.__GetLensPresetName_Internal(base.NativePtr));
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x0005C616 File Offset: 0x0005A816
		public float GetHorizontalFieldOfView()
		{
			return UCineCameraComponent.__GetHorizontalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x0005C623 File Offset: 0x0005A823
		public static TArray<FNamedFilmbackPreset> GetFilmbackPresetsCopy()
		{
			return new TArray<FNamedFilmbackPreset>(UCineCameraComponent.__GetFilmbackPresetsCopy_Internal(), null);
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x0005C630 File Offset: 0x0005A830
		public string GetFilmbackPresetName()
		{
			return FString.ToStringAndDeleteNativePtr(UCineCameraComponent.__GetFilmbackPresetName_Internal(base.NativePtr));
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x0005C642 File Offset: 0x0005A842
		public string GetDefaultFilmbackPresetName()
		{
			return FString.ToStringAndDeleteNativePtr(UCineCameraComponent.__GetDefaultFilmbackPresetName_Internal(base.NativePtr));
		}

		// Token: 0x06003D6B RID: 15723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLensPresetByName_Internal(IntPtr @this, in FString InPresetName);

		// Token: 0x06003D6C RID: 15724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFilmbackPresetByName_Internal(IntPtr @this, in FString InPresetName);

		// Token: 0x06003D6D RID: 15725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentFocalLengthExtra_Internal(IntPtr @this, float InFocalLength);

		// Token: 0x06003D6E RID: 15726
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentFocalLength_Internal(IntPtr @this, float InFocalLength);

		// Token: 0x06003D6F RID: 15727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVerticalFieldOfView_Internal(IntPtr @this);

		// Token: 0x06003D70 RID: 15728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLensPresetsCopy_Internal();

		// Token: 0x06003D71 RID: 15729
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLensPresetName_Internal(IntPtr @this);

		// Token: 0x06003D72 RID: 15730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalFieldOfView_Internal(IntPtr @this);

		// Token: 0x06003D73 RID: 15731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFilmbackPresetsCopy_Internal();

		// Token: 0x06003D74 RID: 15732
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFilmbackPresetName_Internal(IntPtr @this);

		// Token: 0x06003D75 RID: 15733
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDefaultFilmbackPresetName_Internal(IntPtr @this);

		// Token: 0x06003D76 RID: 15734 RVA: 0x0005C654 File Offset: 0x0005A854
		static UCineCameraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CinematicCamera.CineCameraComponent");
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0005C662 File Offset: 0x0005A862
		protected UCineCameraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001CB9 RID: 7353
		public new const string __ObjectPath = "/Script/CinematicCamera.CineCameraComponent";

		// Token: 0x04001CBA RID: 7354
		private static IntPtr _ClassPtr;

		// Token: 0x04001CBB RID: 7355
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001CBC RID: 7356
		internal static int __PropertyOffset_FilmbackSettings_DEPRECATED;

		// Token: 0x04001CBD RID: 7357
		[Nullable(2)]
		private FCameraFilmbackSettings _FilmbackSettings_DEPRECATED;

		// Token: 0x04001CBE RID: 7358
		internal static int __PropertyOffset_Filmback;

		// Token: 0x04001CBF RID: 7359
		[Nullable(2)]
		private FCameraFilmbackSettings _Filmback;

		// Token: 0x04001CC0 RID: 7360
		internal static int __PropertyOffset_LensSettings;

		// Token: 0x04001CC1 RID: 7361
		[Nullable(2)]
		private FCameraLensSettings _LensSettings;

		// Token: 0x04001CC2 RID: 7362
		internal static int __PropertyOffset_FocusSettings;

		// Token: 0x04001CC3 RID: 7363
		[Nullable(2)]
		private FCameraFocusSettings _FocusSettings;

		// Token: 0x04001CC4 RID: 7364
		internal static int __PropertyOffset_CurrentFocalLength;

		// Token: 0x04001CC5 RID: 7365
		internal static int __PropertyOffset_CurrentFocalLengthExtra;

		// Token: 0x04001CC6 RID: 7366
		internal static int __PropertyOffset_CurrentAperture;

		// Token: 0x04001CC7 RID: 7367
		internal static int __PropertyOffset_CurrentFocalRegion;

		// Token: 0x04001CC8 RID: 7368
		internal static int __PropertyOffset_CurrentFocusDistance;

		// Token: 0x04001CC9 RID: 7369
		internal static int __PropertyOffset_FilmbackPresets;

		// Token: 0x04001CCA RID: 7370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedFilmbackPreset> _FilmbackPresets;

		// Token: 0x04001CCB RID: 7371
		internal static int __PropertyOffset_LensPresets;

		// Token: 0x04001CCC RID: 7372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedLensPreset> _LensPresets;

		// Token: 0x04001CCD RID: 7373
		internal static int __PropertyOffset_DefaultFilmbackPresetName_DEPRECATED;

		// Token: 0x04001CCE RID: 7374
		internal static int __PropertyOffset_DefaultFilmbackPreset;

		// Token: 0x04001CCF RID: 7375
		internal static int __PropertyOffset_DefaultLensPresetName;

		// Token: 0x04001CD0 RID: 7376
		internal static int __PropertyOffset_DefaultLensFocalLength;

		// Token: 0x04001CD1 RID: 7377
		internal static int __PropertyOffset_DefaultLensFStop;
	}
}
