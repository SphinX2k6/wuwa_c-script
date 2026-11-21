using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021F RID: 543
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputSettings")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UInputSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060024CB RID: 9419 RVA: 0x00034FEC File Offset: 0x000331EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputSettings._ClassPtr;
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00034FF8 File Offset: 0x000331F8
		public UInputSettings() : this(BuiltinUtils.AllocNativeUObject(UInputSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00035020 File Offset: 0x00033220
		public UInputSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x00035053 File Offset: 0x00033253
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0003506C File Offset: 0x0003326C
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

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0003509C File Offset: 0x0003329C
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x000350B5 File Offset: 0x000332B5
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

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000350E5 File Offset: 0x000332E5
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x000350FE File Offset: 0x000332FE
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0003512E File Offset: 0x0003332E
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x00035147 File Offset: 0x00033347
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

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00035177 File Offset: 0x00033377
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00035190 File Offset: 0x00033390
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

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x000351C0 File Offset: 0x000333C0
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x000351D9 File Offset: 0x000333D9
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

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x00035209 File Offset: 0x00033409
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x00035222 File Offset: 0x00033422
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

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x00035252 File Offset: 0x00033452
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x0003526B File Offset: 0x0003346B
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

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x0003529B File Offset: 0x0003349B
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x000352B4 File Offset: 0x000334B4
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

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x000352E4 File Offset: 0x000334E4
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x000352FD File Offset: 0x000334FD
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

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x0003532D File Offset: 0x0003352D
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x0003533D File Offset: 0x0003353D
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x00035350 File Offset: 0x00033550
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x00035389 File Offset: 0x00033589
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x00035398 File Offset: 0x00033598
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000353D1 File Offset: 0x000335D1
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000353E0 File Offset: 0x000335E0
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x00035419 File Offset: 0x00033619
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x00035427 File Offset: 0x00033627
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00035437 File Offset: 0x00033637
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

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x00035448 File Offset: 0x00033648
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x00035458 File Offset: 0x00033658
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x0003546C File Offset: 0x0003366C
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x000354A5 File Offset: 0x000336A5
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000354B4 File Offset: 0x000336B4
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x000354ED File Offset: 0x000336ED
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000354FC File Offset: 0x000336FC
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00035535 File Offset: 0x00033735
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

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00035558 File Offset: 0x00033758
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x00035591 File Offset: 0x00033791
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000355B4 File Offset: 0x000337B4
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x000355ED File Offset: 0x000337ED
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

		// Token: 0x060024F8 RID: 9464
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGameIsFakingTouchEvents(bool bIsFaking);

		// Token: 0x060024F9 RID: 9465 RVA: 0x000355FB File Offset: 0x000337FB
		public void SaveKeyMappingsNotSort()
		{
			UInputSettings.__SaveKeyMappingsNotSort_Internal(base.NativePtr);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00035608 File Offset: 0x00033808
		public void SaveKeyMappings()
		{
			UInputSettings.__SaveKeyMappings_Internal(base.NativePtr);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00035615 File Offset: 0x00033815
		public void RemoveAxisMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputAxisKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveAxisMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputAxisKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00035633 File Offset: 0x00033833
		[NullableContext(2)]
		public void RemoveAxisMapping(in FInputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveAxisMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputAxisKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00035651 File Offset: 0x00033851
		public void RemoveActionMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputActionKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveActionMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputActionKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0003566F File Offset: 0x0003386F
		[NullableContext(2)]
		public void RemoveActionMapping(in FInputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__RemoveActionMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputActionKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x0003568D File Offset: 0x0003388D
		public FName GetKeyboardPrimaryLangId()
		{
			return UInputSettings.__GetKeyboardPrimaryLangId_Internal(base.NativePtr);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0003569A File Offset: 0x0003389A
		[NullableContext(2)]
		public static UInputSettings GetInputSettings()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UInputSettings>(UInputSettings.__GetInputSettings_Internal());
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000356A6 File Offset: 0x000338A6
		[NullableContext(2)]
		public void GetAxisNames(ref TArray<FName> AxisNames)
		{
			UInputSettings.__GetAxisNames_Internal(base.NativePtr, (AxisNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000356C3 File Offset: 0x000338C3
		public void GetAxisMappingByName(FName InAxisName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FInputAxisKeyMapping> OutMappings)
		{
			UInputSettings.__GetAxisMappingByName_Internal(base.NativePtr, InAxisName, (OutMappings ?? new TArray<FInputAxisKeyMapping>()).NativePtr);
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000356E1 File Offset: 0x000338E1
		[NullableContext(2)]
		public void GetActionNames(ref TArray<FName> ActionNames)
		{
			UInputSettings.__GetActionNames_Internal(base.NativePtr, (ActionNames ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000356FE File Offset: 0x000338FE
		public void GetActionMappingByName(FName InActionName, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FInputActionKeyMapping> OutMappings)
		{
			UInputSettings.__GetActionMappingByName_Internal(base.NativePtr, InActionName, (OutMappings ?? new TArray<FInputActionKeyMapping>()).NativePtr);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x0003571C File Offset: 0x0003391C
		public void ForceRebuildKeymaps()
		{
			UInputSettings.__ForceRebuildKeymaps_Internal(base.NativePtr);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00035729 File Offset: 0x00033929
		public void AddAxisMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputAxisKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddAxisMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputAxisKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00035747 File Offset: 0x00033947
		[NullableContext(2)]
		public void AddAxisMapping(in FInputAxisKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddAxisMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputAxisKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00035765 File Offset: 0x00033965
		public void AddActionMappings([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FInputActionKeyMapping> KeyMappings, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddActionMappings_Internal(base.NativePtr, (KeyMappings ?? new TArray<FInputActionKeyMapping>()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00035783 File Offset: 0x00033983
		[NullableContext(2)]
		public void AddActionMapping(in FInputActionKeyMapping KeyMapping, bool bForceRebuildKeymaps = true)
		{
			UInputSettings.__AddActionMapping_Internal(base.NativePtr, (KeyMapping ?? new FInputActionKeyMapping()).NativePtr, bForceRebuildKeymaps);
		}

		// Token: 0x0600250A RID: 9482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveKeyMappingsNotSort_Internal(IntPtr @this);

		// Token: 0x0600250B RID: 9483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveKeyMappings_Internal(IntPtr @this);

		// Token: 0x0600250C RID: 9484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAxisMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x0600250D RID: 9485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAxisMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x0600250E RID: 9486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveActionMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x0600250F RID: 9487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveActionMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x06002510 RID: 9488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetKeyboardPrimaryLangId_Internal(IntPtr @this);

		// Token: 0x06002511 RID: 9489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInputSettings_Internal();

		// Token: 0x06002512 RID: 9490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAxisNames_Internal(IntPtr @this, IntPtr AxisNames);

		// Token: 0x06002513 RID: 9491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAxisMappingByName_Internal(IntPtr @this, FName InAxisName, IntPtr OutMappings);

		// Token: 0x06002514 RID: 9492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActionNames_Internal(IntPtr @this, IntPtr ActionNames);

		// Token: 0x06002515 RID: 9493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActionMappingByName_Internal(IntPtr @this, FName InActionName, IntPtr OutMappings);

		// Token: 0x06002516 RID: 9494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceRebuildKeymaps_Internal(IntPtr @this);

		// Token: 0x06002517 RID: 9495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x06002518 RID: 9496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x06002519 RID: 9497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionMappings_Internal(IntPtr @this, IntPtr KeyMappings, bool bForceRebuildKeymaps);

		// Token: 0x0600251A RID: 9498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionMapping_Internal(IntPtr @this, IntPtr KeyMapping, bool bForceRebuildKeymaps);

		// Token: 0x0600251B RID: 9499 RVA: 0x000357A1 File Offset: 0x000339A1
		static UInputSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputSettings");
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000357AF File Offset: 0x000339AF
		protected UInputSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000DDA RID: 3546
		public new const string __ObjectPath = "/Script/Engine.InputSettings";

		// Token: 0x04000DDB RID: 3547
		private static IntPtr _ClassPtr;

		// Token: 0x04000DDC RID: 3548
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000DDD RID: 3549
		internal static int __PropertyOffset_bAltEnterTogglesFullscreen;

		// Token: 0x04000DDE RID: 3550
		internal static byte __PropertyMask_bAltEnterTogglesFullscreen;

		// Token: 0x04000DDF RID: 3551
		internal static int __PropertyOffset_bF11TogglesFullscreen;

		// Token: 0x04000DE0 RID: 3552
		internal static byte __PropertyMask_bF11TogglesFullscreen;

		// Token: 0x04000DE1 RID: 3553
		internal static int __PropertyOffset_bUseMouseForTouch;

		// Token: 0x04000DE2 RID: 3554
		internal static byte __PropertyMask_bUseMouseForTouch;

		// Token: 0x04000DE3 RID: 3555
		internal static int __PropertyOffset_bEnableMouseSmoothing;

		// Token: 0x04000DE4 RID: 3556
		internal static byte __PropertyMask_bEnableMouseSmoothing;

		// Token: 0x04000DE5 RID: 3557
		internal static int __PropertyOffset_bEnableFOVScaling;

		// Token: 0x04000DE6 RID: 3558
		internal static byte __PropertyMask_bEnableFOVScaling;

		// Token: 0x04000DE7 RID: 3559
		internal static int __PropertyOffset_bCaptureMouseOnLaunch;

		// Token: 0x04000DE8 RID: 3560
		internal static byte __PropertyMask_bCaptureMouseOnLaunch;

		// Token: 0x04000DE9 RID: 3561
		internal static int __PropertyOffset_bDefaultViewportMouseLock_DEPRECATED;

		// Token: 0x04000DEA RID: 3562
		internal static byte __PropertyMask_bDefaultViewportMouseLock_DEPRECATED;

		// Token: 0x04000DEB RID: 3563
		internal static int __PropertyOffset_bAlwaysShowTouchInterface;

		// Token: 0x04000DEC RID: 3564
		internal static byte __PropertyMask_bAlwaysShowTouchInterface;

		// Token: 0x04000DED RID: 3565
		internal static int __PropertyOffset_bShowConsoleOnFourFingerTap;

		// Token: 0x04000DEE RID: 3566
		internal static byte __PropertyMask_bShowConsoleOnFourFingerTap;

		// Token: 0x04000DEF RID: 3567
		internal static int __PropertyOffset_bEnableGestureRecognizer;

		// Token: 0x04000DF0 RID: 3568
		internal static byte __PropertyMask_bEnableGestureRecognizer;

		// Token: 0x04000DF1 RID: 3569
		internal static int __PropertyOffset_bUseAutocorrect;

		// Token: 0x04000DF2 RID: 3570
		internal static int __PropertyOffset_ExcludedAutocorrectOS;

		// Token: 0x04000DF3 RID: 3571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludedAutocorrectOS;

		// Token: 0x04000DF4 RID: 3572
		internal static int __PropertyOffset_ExcludedAutocorrectCultures;

		// Token: 0x04000DF5 RID: 3573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludedAutocorrectCultures;

		// Token: 0x04000DF6 RID: 3574
		internal static int __PropertyOffset_ExcludedAutocorrectDeviceModels;

		// Token: 0x04000DF7 RID: 3575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludedAutocorrectDeviceModels;

		// Token: 0x04000DF8 RID: 3576
		internal static int __PropertyOffset_FOVScale;

		// Token: 0x04000DF9 RID: 3577
		internal static int __PropertyOffset_DoubleClickTime;

		// Token: 0x04000DFA RID: 3578
		internal static int __PropertyOffset_ActionMappings;

		// Token: 0x04000DFB RID: 3579
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputActionKeyMapping> _ActionMappings;

		// Token: 0x04000DFC RID: 3580
		internal static int __PropertyOffset_AxisMappings;

		// Token: 0x04000DFD RID: 3581
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInputAxisKeyMapping> _AxisMappings;

		// Token: 0x04000DFE RID: 3582
		internal static int __PropertyOffset_DefaultTouchInterface;

		// Token: 0x04000DFF RID: 3583
		[Nullable(2)]
		private FSoftObjectPath _DefaultTouchInterface;

		// Token: 0x04000E00 RID: 3584
		internal static int __PropertyOffset_ConsoleKey_DEPRECATED;

		// Token: 0x04000E01 RID: 3585
		[Nullable(2)]
		private FKey _ConsoleKey_DEPRECATED;

		// Token: 0x04000E02 RID: 3586
		internal static int __PropertyOffset_ConsoleKeys;

		// Token: 0x04000E03 RID: 3587
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKey> _ConsoleKeys;
	}
}
