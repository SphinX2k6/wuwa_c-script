using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C5F RID: 3167
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputSettings")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UInputSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A099 RID: 41113 RVA: 0x000E423C File Offset: 0x000E243C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputSettings._ClassPtr;
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x000E4248 File Offset: 0x000E2448
		public UInputSettings() : this(BuiltinUtils.AllocNativeUObject(UInputSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x000E4270 File Offset: 0x000E2470
		public UInputSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x0600A09C RID: 41116 RVA: 0x000E42A4 File Offset: 0x000E24A4
		// (set) Token: 0x0600A09D RID: 41117 RVA: 0x000E42DD File Offset: 0x000E24DD
		public TArray<FInputAxisConfigEntry> AxisConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInputAxisConfigEntry> result;
				if ((result = this._AxisConfig) == null)
				{
					result = (this._AxisConfig = new TArray<FInputAxisConfigEntry>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_AxisConfig, this));
				}
				return result;
			}
			set
			{
				this.AxisConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x0600A09E RID: 41118 RVA: 0x000E42EB File Offset: 0x000E24EB
		// (set) Token: 0x0600A09F RID: 41119 RVA: 0x000E4304 File Offset: 0x000E2504
		public unsafe bool bAltEnterTogglesFullscreen
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bAltEnterTogglesFullscreen) & UInputSettings.__PropertyMask_bAltEnterTogglesFullscreen) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bAltEnterTogglesFullscreen) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bAltEnterTogglesFullscreen) & ~UInputSettings.__PropertyMask_bAltEnterTogglesFullscreen) | (value ? UInputSettings.__PropertyMask_bAltEnterTogglesFullscreen : 0));
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x000E4334 File Offset: 0x000E2534
		// (set) Token: 0x0600A0A1 RID: 41121 RVA: 0x000E434D File Offset: 0x000E254D
		public unsafe bool bF11TogglesFullscreen
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bF11TogglesFullscreen) & UInputSettings.__PropertyMask_bF11TogglesFullscreen) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bF11TogglesFullscreen) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bF11TogglesFullscreen) & ~UInputSettings.__PropertyMask_bF11TogglesFullscreen) | (value ? UInputSettings.__PropertyMask_bF11TogglesFullscreen : 0));
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x000E437D File Offset: 0x000E257D
		// (set) Token: 0x0600A0A3 RID: 41123 RVA: 0x000E4396 File Offset: 0x000E2596
		public unsafe bool bUseMouseForTouch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bUseMouseForTouch) & UInputSettings.__PropertyMask_bUseMouseForTouch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bUseMouseForTouch) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bUseMouseForTouch) & ~UInputSettings.__PropertyMask_bUseMouseForTouch) | (value ? UInputSettings.__PropertyMask_bUseMouseForTouch : 0));
			}
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x000E43C6 File Offset: 0x000E25C6
		// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x000E43DF File Offset: 0x000E25DF
		public unsafe bool bEnableMouseSmoothing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableMouseSmoothing) & UInputSettings.__PropertyMask_bEnableMouseSmoothing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableMouseSmoothing) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableMouseSmoothing) & ~UInputSettings.__PropertyMask_bEnableMouseSmoothing) | (value ? UInputSettings.__PropertyMask_bEnableMouseSmoothing : 0));
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x000E440F File Offset: 0x000E260F
		// (set) Token: 0x0600A0A7 RID: 41127 RVA: 0x000E4428 File Offset: 0x000E2628
		public unsafe bool bEnableFOVScaling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableFOVScaling) & UInputSettings.__PropertyMask_bEnableFOVScaling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableFOVScaling) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableFOVScaling) & ~UInputSettings.__PropertyMask_bEnableFOVScaling) | (value ? UInputSettings.__PropertyMask_bEnableFOVScaling : 0));
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x0600A0A8 RID: 41128 RVA: 0x000E4458 File Offset: 0x000E2658
		// (set) Token: 0x0600A0A9 RID: 41129 RVA: 0x000E4471 File Offset: 0x000E2671
		public unsafe bool bCaptureMouseOnLaunch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bCaptureMouseOnLaunch) & UInputSettings.__PropertyMask_bCaptureMouseOnLaunch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bCaptureMouseOnLaunch) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bCaptureMouseOnLaunch) & ~UInputSettings.__PropertyMask_bCaptureMouseOnLaunch) | (value ? UInputSettings.__PropertyMask_bCaptureMouseOnLaunch : 0));
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x0600A0AA RID: 41130 RVA: 0x000E44A1 File Offset: 0x000E26A1
		// (set) Token: 0x0600A0AB RID: 41131 RVA: 0x000E44BA File Offset: 0x000E26BA
		public unsafe bool bDefaultViewportMouseLock_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bDefaultViewportMouseLock_DEPRECATED) & UInputSettings.__PropertyMask_bDefaultViewportMouseLock_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bDefaultViewportMouseLock_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bDefaultViewportMouseLock_DEPRECATED) & ~UInputSettings.__PropertyMask_bDefaultViewportMouseLock_DEPRECATED) | (value ? UInputSettings.__PropertyMask_bDefaultViewportMouseLock_DEPRECATED : 0));
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x0600A0AC RID: 41132 RVA: 0x000E44EA File Offset: 0x000E26EA
		// (set) Token: 0x0600A0AD RID: 41133 RVA: 0x000E4503 File Offset: 0x000E2703
		public unsafe bool bAlwaysShowTouchInterface
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bAlwaysShowTouchInterface) & UInputSettings.__PropertyMask_bAlwaysShowTouchInterface) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bAlwaysShowTouchInterface) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bAlwaysShowTouchInterface) & ~UInputSettings.__PropertyMask_bAlwaysShowTouchInterface) | (value ? UInputSettings.__PropertyMask_bAlwaysShowTouchInterface : 0));
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x0600A0AE RID: 41134 RVA: 0x000E4533 File Offset: 0x000E2733
		// (set) Token: 0x0600A0AF RID: 41135 RVA: 0x000E454C File Offset: 0x000E274C
		public unsafe bool bShowConsoleOnFourFingerTap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bShowConsoleOnFourFingerTap) & UInputSettings.__PropertyMask_bShowConsoleOnFourFingerTap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bShowConsoleOnFourFingerTap) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bShowConsoleOnFourFingerTap) & ~UInputSettings.__PropertyMask_bShowConsoleOnFourFingerTap) | (value ? UInputSettings.__PropertyMask_bShowConsoleOnFourFingerTap : 0));
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x0600A0B0 RID: 41136 RVA: 0x000E457C File Offset: 0x000E277C
		// (set) Token: 0x0600A0B1 RID: 41137 RVA: 0x000E4595 File Offset: 0x000E2795
		public unsafe bool bEnableGestureRecognizer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableGestureRecognizer) & UInputSettings.__PropertyMask_bEnableGestureRecognizer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableGestureRecognizer) = ((*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bEnableGestureRecognizer) & ~UInputSettings.__PropertyMask_bEnableGestureRecognizer) | (value ? UInputSettings.__PropertyMask_bEnableGestureRecognizer : 0));
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600A0B2 RID: 41138 RVA: 0x000E45C5 File Offset: 0x000E27C5
		// (set) Token: 0x0600A0B3 RID: 41139 RVA: 0x000E45D5 File Offset: 0x000E27D5
		public unsafe bool bUseAutocorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bUseAutocorrect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_bUseAutocorrect) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x000E45E8 File Offset: 0x000E27E8
		// (set) Token: 0x0600A0B5 RID: 41141 RVA: 0x000E4621 File Offset: 0x000E2821
		public TArray<string> ExcludedAutocorrectOS
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExcludedAutocorrectOS) == null)
				{
					result = (this._ExcludedAutocorrectOS = new TArray<string>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_ExcludedAutocorrectOS, this));
				}
				return result;
			}
			set
			{
				this.ExcludedAutocorrectOS.CopyAssign(value);
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x0600A0B6 RID: 41142 RVA: 0x000E4630 File Offset: 0x000E2830
		// (set) Token: 0x0600A0B7 RID: 41143 RVA: 0x000E4669 File Offset: 0x000E2869
		public TArray<string> ExcludedAutocorrectCultures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExcludedAutocorrectCultures) == null)
				{
					result = (this._ExcludedAutocorrectCultures = new TArray<string>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_ExcludedAutocorrectCultures, this));
				}
				return result;
			}
			set
			{
				this.ExcludedAutocorrectCultures.CopyAssign(value);
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x0600A0B8 RID: 41144 RVA: 0x000E4678 File Offset: 0x000E2878
		// (set) Token: 0x0600A0B9 RID: 41145 RVA: 0x000E46B1 File Offset: 0x000E28B1
		public TArray<string> ExcludedAutocorrectDeviceModels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExcludedAutocorrectDeviceModels) == null)
				{
					result = (this._ExcludedAutocorrectDeviceModels = new TArray<string>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_ExcludedAutocorrectDeviceModels, this));
				}
				return result;
			}
			set
			{
				this.ExcludedAutocorrectDeviceModels.CopyAssign(value);
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0600A0BA RID: 41146 RVA: 0x000E46BF File Offset: 0x000E28BF
		// (set) Token: 0x0600A0BB RID: 41147 RVA: 0x000E46CF File Offset: 0x000E28CF
		public unsafe EMouseCaptureMode DefaultViewportMouseCaptureMode
		{
			get
			{
				return (EMouseCaptureMode)(*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultViewportMouseCaptureMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultViewportMouseCaptureMode) = (byte)value;
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x0600A0BC RID: 41148 RVA: 0x000E46E0 File Offset: 0x000E28E0
		// (set) Token: 0x0600A0BD RID: 41149 RVA: 0x000E46F0 File Offset: 0x000E28F0
		public unsafe EMouseLockMode DefaultViewportMouseLockMode
		{
			get
			{
				return (EMouseLockMode)(*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultViewportMouseLockMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultViewportMouseLockMode) = (byte)value;
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x0600A0BE RID: 41150 RVA: 0x000E4701 File Offset: 0x000E2901
		// (set) Token: 0x0600A0BF RID: 41151 RVA: 0x000E4711 File Offset: 0x000E2911
		public unsafe float FOVScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_FOVScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_FOVScale) = value;
			}
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x0600A0C0 RID: 41152 RVA: 0x000E4722 File Offset: 0x000E2922
		// (set) Token: 0x0600A0C1 RID: 41153 RVA: 0x000E4732 File Offset: 0x000E2932
		public unsafe float DoubleClickTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DoubleClickTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DoubleClickTime) = value;
			}
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x0600A0C2 RID: 41154 RVA: 0x000E4744 File Offset: 0x000E2944
		// (set) Token: 0x0600A0C3 RID: 41155 RVA: 0x000E477D File Offset: 0x000E297D
		public TArray<FInputActionKeyMapping> ActionMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInputActionKeyMapping> result;
				if ((result = this._ActionMappings) == null)
				{
					result = (this._ActionMappings = new TArray<FInputActionKeyMapping>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_ActionMappings, this));
				}
				return result;
			}
			set
			{
				this.ActionMappings.CopyAssign(value);
			}
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x0600A0C4 RID: 41156 RVA: 0x000E478C File Offset: 0x000E298C
		// (set) Token: 0x0600A0C5 RID: 41157 RVA: 0x000E47C5 File Offset: 0x000E29C5
		public TArray<FInputAxisKeyMapping> AxisMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInputAxisKeyMapping> result;
				if ((result = this._AxisMappings) == null)
				{
					result = (this._AxisMappings = new TArray<FInputAxisKeyMapping>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_AxisMappings, this));
				}
				return result;
			}
			set
			{
				this.AxisMappings.CopyAssign(value);
			}
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x0600A0C6 RID: 41158 RVA: 0x000E47D4 File Offset: 0x000E29D4
		// (set) Token: 0x0600A0C7 RID: 41159 RVA: 0x000E480D File Offset: 0x000E2A0D
		public TArray<FInputActionSpeechMapping> SpeechMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInputActionSpeechMapping> result;
				if ((result = this._SpeechMappings) == null)
				{
					result = (this._SpeechMappings = new TArray<FInputActionSpeechMapping>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_SpeechMappings, this));
				}
				return result;
			}
			set
			{
				this.SpeechMappings.CopyAssign(value);
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x0600A0C8 RID: 41160 RVA: 0x000E481B File Offset: 0x000E2A1B
		// (set) Token: 0x0600A0C9 RID: 41161 RVA: 0x000E4830 File Offset: 0x000E2A30
		public TSoftClassPtr<UPlayerInput> DefaultPlayerInputClass
		{
			get
			{
				return new TSoftClassPtr<UPlayerInput>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultPlayerInputClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultPlayerInputClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x0600A0CA RID: 41162 RVA: 0x000E4855 File Offset: 0x000E2A55
		// (set) Token: 0x0600A0CB RID: 41163 RVA: 0x000E486A File Offset: 0x000E2A6A
		public TSoftClassPtr<UInputComponent> DefaultInputComponentClass
		{
			get
			{
				return new TSoftClassPtr<UInputComponent>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultInputComponentClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultInputComponentClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x0600A0CC RID: 41164 RVA: 0x000E4890 File Offset: 0x000E2A90
		// (set) Token: 0x0600A0CD RID: 41165 RVA: 0x000E48C9 File Offset: 0x000E2AC9
		public FSoftObjectPath DefaultTouchInterface
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultTouchInterface) == null)
				{
					result = (this._DefaultTouchInterface = new FSoftObjectPath(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultTouchInterface, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_DefaultTouchInterface, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x0600A0CE RID: 41166 RVA: 0x000E48EC File Offset: 0x000E2AEC
		// (set) Token: 0x0600A0CF RID: 41167 RVA: 0x000E4925 File Offset: 0x000E2B25
		public FKey ConsoleKey_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._ConsoleKey_DEPRECATED) == null)
				{
					result = (this._ConsoleKey_DEPRECATED = new FKey(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_ConsoleKey_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_ConsoleKey_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x0600A0D0 RID: 41168 RVA: 0x000E4948 File Offset: 0x000E2B48
		// (set) Token: 0x0600A0D1 RID: 41169 RVA: 0x000E4981 File Offset: 0x000E2B81
		public TArray<FKey> ConsoleKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKey> result;
				if ((result = this._ConsoleKeys) == null)
				{
					result = (this._ConsoleKeys = new TArray<FKey>(base.NativePtr + (IntPtr)UInputSettings.__PropertyOffset_ConsoleKeys, this));
				}
				return result;
			}
			set
			{
				this.ConsoleKeys.CopyAssign(value);
			}
		}

		// Token: 0x0600A0D2 RID: 41170
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGameIsFakingTouchEvents(bool bIsFaking);

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x000E498F File Offset: 0x000E2B8F
		public void SaveKeyMappingsNotSort()
		{
			UInputSettings.__SaveKeyMappingsNotSort_Internal(base.NativePtr);
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x000E499C File Offset: 0x000E2B9C
		public void SaveKeyMappings()
		{
			UInputSettings.__SaveKeyMappings_Internal(base.NativePtr);
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x000E49A9 File Offset: 0x000E2BA9
		public void RemoveAxisMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputAxisKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveAxisMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputAxisKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x000E49C7 File Offset: 0x000E2BC7
		[NullableContext(2)]
		public void RemoveAxisMapping(in FInputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveAxisMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputAxisKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x000E49E5 File Offset: 0x000E2BE5
		public void RemoveActionMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputActionKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveActionMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputActionKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x000E4A03 File Offset: 0x000E2C03
		[NullableContext(2)]
		public void RemoveActionMapping(in FInputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveActionMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputActionKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x000E4A21 File Offset: 0x000E2C21
		public FName GetKeyboardPrimaryLangId()
		{
			return UInputSettings.__GetKeyboardPrimaryLangId_Internal(base.NativePtr);
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x000E4A2E File Offset: 0x000E2C2E
		[NullableContext(2)]
		public static UInputSettings GetInputSettings()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UInputSettings>(UInputSettings.__GetInputSettings_Internal());
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x000E4A3A File Offset: 0x000E2C3A
		[NullableContext(2)]
		public void GetAxisNames(ref TArray<FName> AxisNames)
		{
			UInputSettings.__GetAxisNames_Internal(base.NativePtr, (AxisNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x000E4A57 File Offset: 0x000E2C57
		public void GetAxisMappingByName(FName InAxisName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FInputAxisKeyMapping> OutMappings)
		{
			UInputSettings.__GetAxisMappingByName_Internal(base.NativePtr, InAxisName, (OutMappings ?? new TArray<FInputAxisKeyMapping>()).NativePtr);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x000E4A75 File Offset: 0x000E2C75
		[NullableContext(2)]
		public void GetActionNames(ref TArray<FName> ActionNames)
		{
			UInputSettings.__GetActionNames_Internal(base.NativePtr, (ActionNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x000E4A92 File Offset: 0x000E2C92
		public void GetActionMappingByName(FName InActionName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FInputActionKeyMapping> OutMappings)
		{
			UInputSettings.__GetActionMappingByName_Internal(base.NativePtr, InActionName, (OutMappings ?? new TArray<FInputActionKeyMapping>()).NativePtr);
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x000E4AB0 File Offset: 0x000E2CB0
		public void ForceRebuildKeymaps()
		{
			UInputSettings.__ForceRebuildKeymaps_Internal(base.NativePtr);
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x000E4ABD File Offset: 0x000E2CBD
		public void AddAxisMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputAxisKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddAxisMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputAxisKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x000E4ADB File Offset: 0x000E2CDB
		[NullableContext(2)]
		public void AddAxisMapping(in FInputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddAxisMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputAxisKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x000E4AF9 File Offset: 0x000E2CF9
		public void AddActionMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputActionKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddActionMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputActionKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x000E4B17 File Offset: 0x000E2D17
		[NullableContext(2)]
		public void AddActionMapping(in FInputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddActionMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputActionKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600A0E4 RID: 41188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveKeyMappingsNotSort_Internal(IntPtr @this);

		// Token: 0x0600A0E5 RID: 41189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveKeyMappings_Internal(IntPtr @this);

		// Token: 0x0600A0E6 RID: 41190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAxisMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x0600A0E7 RID: 41191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAxisMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x0600A0E8 RID: 41192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveActionMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x0600A0E9 RID: 41193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveActionMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x0600A0EA RID: 41194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetKeyboardPrimaryLangId_Internal(IntPtr @this);

		// Token: 0x0600A0EB RID: 41195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInputSettings_Internal();

		// Token: 0x0600A0EC RID: 41196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAxisNames_Internal(IntPtr @this, IntPtr AxisNames);

		// Token: 0x0600A0ED RID: 41197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAxisMappingByName_Internal(IntPtr @this, FName InAxisName, IntPtr OutMappings);

		// Token: 0x0600A0EE RID: 41198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActionNames_Internal(IntPtr @this, IntPtr ActionNames);

		// Token: 0x0600A0EF RID: 41199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActionMappingByName_Internal(IntPtr @this, FName InActionName, IntPtr OutMappings);

		// Token: 0x0600A0F0 RID: 41200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceRebuildKeymaps_Internal(IntPtr @this);

		// Token: 0x0600A0F1 RID: 41201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x0600A0F2 RID: 41202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x0600A0F3 RID: 41203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x0600A0F4 RID: 41204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x000E4B35 File Offset: 0x000E2D35
		static UInputSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputSettings");
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x000E4B43 File Offset: 0x000E2D43
		protected UInputSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005849 RID: 22601
		public new const string __ObjectPath = "/Script/Engine.InputSettings";

		// Token: 0x0400584A RID: 22602
		private static IntPtr _ClassPtr;

		// Token: 0x0400584B RID: 22603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400584C RID: 22604
		internal static int __PropertyOffset_AxisConfig;

		// Token: 0x0400584D RID: 22605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputAxisConfigEntry> _AxisConfig;

		// Token: 0x0400584E RID: 22606
		internal static int __PropertyOffset_bAltEnterTogglesFullscreen;

		// Token: 0x0400584F RID: 22607
		internal static byte __PropertyMask_bAltEnterTogglesFullscreen;

		// Token: 0x04005850 RID: 22608
		internal static int __PropertyOffset_bF11TogglesFullscreen;

		// Token: 0x04005851 RID: 22609
		internal static byte __PropertyMask_bF11TogglesFullscreen;

		// Token: 0x04005852 RID: 22610
		internal static int __PropertyOffset_bUseMouseForTouch;

		// Token: 0x04005853 RID: 22611
		internal static byte __PropertyMask_bUseMouseForTouch;

		// Token: 0x04005854 RID: 22612
		internal static int __PropertyOffset_bEnableMouseSmoothing;

		// Token: 0x04005855 RID: 22613
		internal static byte __PropertyMask_bEnableMouseSmoothing;

		// Token: 0x04005856 RID: 22614
		internal static int __PropertyOffset_bEnableFOVScaling;

		// Token: 0x04005857 RID: 22615
		internal static byte __PropertyMask_bEnableFOVScaling;

		// Token: 0x04005858 RID: 22616
		internal static int __PropertyOffset_bCaptureMouseOnLaunch;

		// Token: 0x04005859 RID: 22617
		internal static byte __PropertyMask_bCaptureMouseOnLaunch;

		// Token: 0x0400585A RID: 22618
		internal static int __PropertyOffset_bDefaultViewportMouseLock_DEPRECATED;

		// Token: 0x0400585B RID: 22619
		internal static byte __PropertyMask_bDefaultViewportMouseLock_DEPRECATED;

		// Token: 0x0400585C RID: 22620
		internal static int __PropertyOffset_bAlwaysShowTouchInterface;

		// Token: 0x0400585D RID: 22621
		internal static byte __PropertyMask_bAlwaysShowTouchInterface;

		// Token: 0x0400585E RID: 22622
		internal static int __PropertyOffset_bShowConsoleOnFourFingerTap;

		// Token: 0x0400585F RID: 22623
		internal static byte __PropertyMask_bShowConsoleOnFourFingerTap;

		// Token: 0x04005860 RID: 22624
		internal static int __PropertyOffset_bEnableGestureRecognizer;

		// Token: 0x04005861 RID: 22625
		internal static byte __PropertyMask_bEnableGestureRecognizer;

		// Token: 0x04005862 RID: 22626
		internal static int __PropertyOffset_bUseAutocorrect;

		// Token: 0x04005863 RID: 22627
		internal static int __PropertyOffset_ExcludedAutocorrectOS;

		// Token: 0x04005864 RID: 22628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludedAutocorrectOS;

		// Token: 0x04005865 RID: 22629
		internal static int __PropertyOffset_ExcludedAutocorrectCultures;

		// Token: 0x04005866 RID: 22630
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludedAutocorrectCultures;

		// Token: 0x04005867 RID: 22631
		internal static int __PropertyOffset_ExcludedAutocorrectDeviceModels;

		// Token: 0x04005868 RID: 22632
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludedAutocorrectDeviceModels;

		// Token: 0x04005869 RID: 22633
		internal static int __PropertyOffset_DefaultViewportMouseCaptureMode;

		// Token: 0x0400586A RID: 22634
		internal static int __PropertyOffset_DefaultViewportMouseLockMode;

		// Token: 0x0400586B RID: 22635
		internal static int __PropertyOffset_FOVScale;

		// Token: 0x0400586C RID: 22636
		internal static int __PropertyOffset_DoubleClickTime;

		// Token: 0x0400586D RID: 22637
		internal static int __PropertyOffset_ActionMappings;

		// Token: 0x0400586E RID: 22638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputActionKeyMapping> _ActionMappings;

		// Token: 0x0400586F RID: 22639
		internal static int __PropertyOffset_AxisMappings;

		// Token: 0x04005870 RID: 22640
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputAxisKeyMapping> _AxisMappings;

		// Token: 0x04005871 RID: 22641
		internal static int __PropertyOffset_SpeechMappings;

		// Token: 0x04005872 RID: 22642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputActionSpeechMapping> _SpeechMappings;

		// Token: 0x04005873 RID: 22643
		internal static int __PropertyOffset_DefaultPlayerInputClass;

		// Token: 0x04005874 RID: 22644
		internal static int __PropertyOffset_DefaultInputComponentClass;

		// Token: 0x04005875 RID: 22645
		internal static int __PropertyOffset_DefaultTouchInterface;

		// Token: 0x04005876 RID: 22646
		[Nullable(2)]
		private FSoftObjectPath _DefaultTouchInterface;

		// Token: 0x04005877 RID: 22647
		internal static int __PropertyOffset_ConsoleKey_DEPRECATED;

		// Token: 0x04005878 RID: 22648
		[Nullable(2)]
		private FKey _ConsoleKey_DEPRECATED;

		// Token: 0x04005879 RID: 22649
		internal static int __PropertyOffset_ConsoleKeys;

		// Token: 0x0400587A RID: 22650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKey> _ConsoleKeys;
	}
}
