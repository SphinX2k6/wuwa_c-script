using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000414 RID: 1044
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationScreenshotMetadata")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class FAutomationScreenshotMetadata : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060037E0 RID: 14304 RVA: 0x00055251 File Offset: 0x00053451
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationScreenshotMetadata._ScriptStructPtr != 0) ? FAutomationScreenshotMetadata._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationScreenshotMetadata", ref FAutomationScreenshotMetadata._ScriptStructPtr);
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x00055275 File Offset: 0x00053475
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x00055289 File Offset: 0x00053489
		public unsafe string ScreenShotName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ScreenShotName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ScreenShotName)), value);
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x0005529E File Offset: 0x0005349E
		// (set) Token: 0x060037E4 RID: 14308 RVA: 0x000552B2 File Offset: 0x000534B2
		public unsafe string Context
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Context)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Context)), value);
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x000552C7 File Offset: 0x000534C7
		// (set) Token: 0x060037E6 RID: 14310 RVA: 0x000552DB File Offset: 0x000534DB
		public unsafe string TestName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_TestName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_TestName)), value);
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x000552F0 File Offset: 0x000534F0
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x00055304 File Offset: 0x00053504
		public unsafe string Notes
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Notes)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Notes)), value);
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x00055319 File Offset: 0x00053519
		// (set) Token: 0x060037EA RID: 14314 RVA: 0x0005532D File Offset: 0x0005352D
		public unsafe FGuid Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x00055342 File Offset: 0x00053542
		// (set) Token: 0x060037EC RID: 14316 RVA: 0x00055356 File Offset: 0x00053556
		public unsafe string Commit
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Commit)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Commit)), value);
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x0005536B File Offset: 0x0005356B
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x0005537B File Offset: 0x0005357B
		public unsafe int Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x0005538C File Offset: 0x0005358C
		// (set) Token: 0x060037F0 RID: 14320 RVA: 0x0005539C File Offset: 0x0005359C
		public unsafe int Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x000553AD File Offset: 0x000535AD
		// (set) Token: 0x060037F2 RID: 14322 RVA: 0x000553C1 File Offset: 0x000535C1
		public unsafe string Rhi
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Rhi)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Rhi)), value);
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x000553D6 File Offset: 0x000535D6
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x000553EA File Offset: 0x000535EA
		public unsafe string Platform
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Platform)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Platform)), value);
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x000553FF File Offset: 0x000535FF
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x00055413 File Offset: 0x00053613
		public unsafe string FeatureLevel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_FeatureLevel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_FeatureLevel)), value);
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x00055428 File Offset: 0x00053628
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x00055438 File Offset: 0x00053638
		public unsafe bool bIsStereo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bIsStereo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bIsStereo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x00055449 File Offset: 0x00053649
		// (set) Token: 0x060037FA RID: 14330 RVA: 0x0005545D File Offset: 0x0005365D
		public unsafe string Vendor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Vendor)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_Vendor)), value);
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x00055472 File Offset: 0x00053672
		// (set) Token: 0x060037FC RID: 14332 RVA: 0x00055486 File Offset: 0x00053686
		public unsafe string AdapterName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AdapterName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AdapterName)), value);
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x0005549B File Offset: 0x0005369B
		// (set) Token: 0x060037FE RID: 14334 RVA: 0x000554AF File Offset: 0x000536AF
		public unsafe string AdapterInternalDriverVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AdapterInternalDriverVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AdapterInternalDriverVersion)), value);
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x000554C4 File Offset: 0x000536C4
		// (set) Token: 0x06003800 RID: 14336 RVA: 0x000554D8 File Offset: 0x000536D8
		public unsafe string AdapterUserDriverVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AdapterUserDriverVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AdapterUserDriverVersion)), value);
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x000554ED File Offset: 0x000536ED
		// (set) Token: 0x06003802 RID: 14338 RVA: 0x00055501 File Offset: 0x00053701
		public unsafe string UniqueDeviceId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_UniqueDeviceId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_UniqueDeviceId)), value);
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06003803 RID: 14339 RVA: 0x00055516 File Offset: 0x00053716
		// (set) Token: 0x06003804 RID: 14340 RVA: 0x00055526 File Offset: 0x00053726
		public unsafe float ResolutionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ResolutionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ResolutionQuality) = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x00055537 File Offset: 0x00053737
		// (set) Token: 0x06003806 RID: 14342 RVA: 0x00055547 File Offset: 0x00053747
		public unsafe int ViewDistanceQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ViewDistanceQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ViewDistanceQuality) = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x00055558 File Offset: 0x00053758
		// (set) Token: 0x06003808 RID: 14344 RVA: 0x00055568 File Offset: 0x00053768
		public unsafe int AntiAliasingQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AntiAliasingQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_AntiAliasingQuality) = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x00055579 File Offset: 0x00053779
		// (set) Token: 0x0600380A RID: 14346 RVA: 0x00055589 File Offset: 0x00053789
		public unsafe int ShadowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ShadowQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ShadowQuality) = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x0005559A File Offset: 0x0005379A
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x000555AA File Offset: 0x000537AA
		public unsafe int PostProcessQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_PostProcessQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_PostProcessQuality) = value;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x000555BB File Offset: 0x000537BB
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x000555CB File Offset: 0x000537CB
		public unsafe int TextureQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_TextureQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_TextureQuality) = value;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x000555DC File Offset: 0x000537DC
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x000555EC File Offset: 0x000537EC
		public unsafe int EffectsQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_EffectsQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_EffectsQuality) = value;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x000555FD File Offset: 0x000537FD
		// (set) Token: 0x06003812 RID: 14354 RVA: 0x0005560D File Offset: 0x0005380D
		public unsafe int FoliageQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_FoliageQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_FoliageQuality) = value;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x0005561E File Offset: 0x0005381E
		// (set) Token: 0x06003814 RID: 14356 RVA: 0x0005562E File Offset: 0x0005382E
		public unsafe int ShadingQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ShadingQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ShadingQuality) = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x0005563F File Offset: 0x0005383F
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x0005564F File Offset: 0x0005384F
		public unsafe bool bHasComparisonRules
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bHasComparisonRules) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bHasComparisonRules) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x00055660 File Offset: 0x00053860
		// (set) Token: 0x06003818 RID: 14360 RVA: 0x00055670 File Offset: 0x00053870
		public unsafe byte ToleranceRed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceRed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceRed) = value;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x00055681 File Offset: 0x00053881
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x00055691 File Offset: 0x00053891
		public unsafe byte ToleranceGreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceGreen);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceGreen) = value;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x000556A2 File Offset: 0x000538A2
		// (set) Token: 0x0600381C RID: 14364 RVA: 0x000556B2 File Offset: 0x000538B2
		public unsafe byte ToleranceBlue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceBlue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceBlue) = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x000556C3 File Offset: 0x000538C3
		// (set) Token: 0x0600381E RID: 14366 RVA: 0x000556D3 File Offset: 0x000538D3
		public unsafe byte ToleranceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceAlpha) = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x000556E4 File Offset: 0x000538E4
		// (set) Token: 0x06003820 RID: 14368 RVA: 0x000556F4 File Offset: 0x000538F4
		public unsafe byte ToleranceMinBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceMinBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceMinBrightness) = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x00055705 File Offset: 0x00053905
		// (set) Token: 0x06003822 RID: 14370 RVA: 0x00055715 File Offset: 0x00053915
		public unsafe byte ToleranceMaxBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceMaxBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_ToleranceMaxBrightness) = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x00055726 File Offset: 0x00053926
		// (set) Token: 0x06003824 RID: 14372 RVA: 0x00055736 File Offset: 0x00053936
		public unsafe float MaximumLocalError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_MaximumLocalError);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_MaximumLocalError) = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x00055747 File Offset: 0x00053947
		// (set) Token: 0x06003826 RID: 14374 RVA: 0x00055757 File Offset: 0x00053957
		public unsafe float MaximumGlobalError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_MaximumGlobalError);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_MaximumGlobalError) = value;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x00055768 File Offset: 0x00053968
		// (set) Token: 0x06003828 RID: 14376 RVA: 0x00055778 File Offset: 0x00053978
		public unsafe bool bIgnoreAntiAliasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bIgnoreAntiAliasing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bIgnoreAntiAliasing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x00055789 File Offset: 0x00053989
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x00055799 File Offset: 0x00053999
		public unsafe bool bIgnoreColors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bIgnoreColors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationScreenshotMetadata.__PropertyOffset_bIgnoreColors) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x000557AA File Offset: 0x000539AA
		public FAutomationScreenshotMetadata()
		{
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x000557B4 File Offset: 0x000539B4
		public FAutomationScreenshotMetadata(string ScreenShotName, string Context, string TestName, string Notes, FGuid Id, string Commit, int Width, int Height, string Rhi, string Platform, string FeatureLevel, bool bIsStereo, string Vendor, string AdapterName, string AdapterInternalDriverVersion, string AdapterUserDriverVersion, string UniqueDeviceId, float ResolutionQuality, int ViewDistanceQuality, int AntiAliasingQuality, int ShadowQuality, int PostProcessQuality, int TextureQuality, int EffectsQuality, int FoliageQuality, int ShadingQuality, bool bHasComparisonRules, byte ToleranceRed, byte ToleranceGreen, byte ToleranceBlue, byte ToleranceAlpha, byte ToleranceMinBrightness, byte ToleranceMaxBrightness, float MaximumLocalError, float MaximumGlobalError, bool bIgnoreAntiAliasing, bool bIgnoreColors)
		{
			this.ScreenShotName = ScreenShotName;
			this.Context = Context;
			this.TestName = TestName;
			this.Notes = Notes;
			this.Id = Id;
			this.Commit = Commit;
			this.Width = Width;
			this.Height = Height;
			this.Rhi = Rhi;
			this.Platform = Platform;
			this.FeatureLevel = FeatureLevel;
			this.bIsStereo = bIsStereo;
			this.Vendor = Vendor;
			this.AdapterName = AdapterName;
			this.AdapterInternalDriverVersion = AdapterInternalDriverVersion;
			this.AdapterUserDriverVersion = AdapterUserDriverVersion;
			this.UniqueDeviceId = UniqueDeviceId;
			this.ResolutionQuality = ResolutionQuality;
			this.ViewDistanceQuality = ViewDistanceQuality;
			this.AntiAliasingQuality = AntiAliasingQuality;
			this.ShadowQuality = ShadowQuality;
			this.PostProcessQuality = PostProcessQuality;
			this.TextureQuality = TextureQuality;
			this.EffectsQuality = EffectsQuality;
			this.FoliageQuality = FoliageQuality;
			this.ShadingQuality = ShadingQuality;
			this.bHasComparisonRules = bHasComparisonRules;
			this.ToleranceRed = ToleranceRed;
			this.ToleranceGreen = ToleranceGreen;
			this.ToleranceBlue = ToleranceBlue;
			this.ToleranceAlpha = ToleranceAlpha;
			this.ToleranceMinBrightness = ToleranceMinBrightness;
			this.ToleranceMaxBrightness = ToleranceMaxBrightness;
			this.MaximumLocalError = MaximumLocalError;
			this.MaximumGlobalError = MaximumGlobalError;
			this.bIgnoreAntiAliasing = bIgnoreAntiAliasing;
			this.bIgnoreColors = bIgnoreColors;
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x000558EC File Offset: 0x00053AEC
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationScreenshotMetadata.StaticStruct();
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x000558F8 File Offset: 0x00053AF8
		[NullableContext(2)]
		public FAutomationScreenshotMetadata(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00055902 File Offset: 0x00053B02
		public FAutomationScreenshotMetadata(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0005590D File Offset: 0x00053B0D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationScreenshotMetadata(Pointer, false, true);
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00055917 File Offset: 0x00053B17
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationScreenshotMetadata(Pointer, MemoryOwner);
		}

		// Token: 0x04001962 RID: 6498
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationScreenshotMetadata";

		// Token: 0x04001963 RID: 6499
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001964 RID: 6500
		internal static int __PropertyOffset_ScreenShotName;

		// Token: 0x04001965 RID: 6501
		internal static int __PropertyOffset_Context;

		// Token: 0x04001966 RID: 6502
		internal static int __PropertyOffset_TestName;

		// Token: 0x04001967 RID: 6503
		internal static int __PropertyOffset_Notes;

		// Token: 0x04001968 RID: 6504
		internal static int __PropertyOffset_Id;

		// Token: 0x04001969 RID: 6505
		internal static int __PropertyOffset_Commit;

		// Token: 0x0400196A RID: 6506
		internal static int __PropertyOffset_Width;

		// Token: 0x0400196B RID: 6507
		internal static int __PropertyOffset_Height;

		// Token: 0x0400196C RID: 6508
		internal static int __PropertyOffset_Rhi;

		// Token: 0x0400196D RID: 6509
		internal static int __PropertyOffset_Platform;

		// Token: 0x0400196E RID: 6510
		internal static int __PropertyOffset_FeatureLevel;

		// Token: 0x0400196F RID: 6511
		internal static int __PropertyOffset_bIsStereo;

		// Token: 0x04001970 RID: 6512
		internal static int __PropertyOffset_Vendor;

		// Token: 0x04001971 RID: 6513
		internal static int __PropertyOffset_AdapterName;

		// Token: 0x04001972 RID: 6514
		internal static int __PropertyOffset_AdapterInternalDriverVersion;

		// Token: 0x04001973 RID: 6515
		internal static int __PropertyOffset_AdapterUserDriverVersion;

		// Token: 0x04001974 RID: 6516
		internal static int __PropertyOffset_UniqueDeviceId;

		// Token: 0x04001975 RID: 6517
		internal static int __PropertyOffset_ResolutionQuality;

		// Token: 0x04001976 RID: 6518
		internal static int __PropertyOffset_ViewDistanceQuality;

		// Token: 0x04001977 RID: 6519
		internal static int __PropertyOffset_AntiAliasingQuality;

		// Token: 0x04001978 RID: 6520
		internal static int __PropertyOffset_ShadowQuality;

		// Token: 0x04001979 RID: 6521
		internal static int __PropertyOffset_PostProcessQuality;

		// Token: 0x0400197A RID: 6522
		internal static int __PropertyOffset_TextureQuality;

		// Token: 0x0400197B RID: 6523
		internal static int __PropertyOffset_EffectsQuality;

		// Token: 0x0400197C RID: 6524
		internal static int __PropertyOffset_FoliageQuality;

		// Token: 0x0400197D RID: 6525
		internal static int __PropertyOffset_ShadingQuality;

		// Token: 0x0400197E RID: 6526
		internal static int __PropertyOffset_bHasComparisonRules;

		// Token: 0x0400197F RID: 6527
		internal static int __PropertyOffset_ToleranceRed;

		// Token: 0x04001980 RID: 6528
		internal static int __PropertyOffset_ToleranceGreen;

		// Token: 0x04001981 RID: 6529
		internal static int __PropertyOffset_ToleranceBlue;

		// Token: 0x04001982 RID: 6530
		internal static int __PropertyOffset_ToleranceAlpha;

		// Token: 0x04001983 RID: 6531
		internal static int __PropertyOffset_ToleranceMinBrightness;

		// Token: 0x04001984 RID: 6532
		internal static int __PropertyOffset_ToleranceMaxBrightness;

		// Token: 0x04001985 RID: 6533
		internal static int __PropertyOffset_MaximumLocalError;

		// Token: 0x04001986 RID: 6534
		internal static int __PropertyOffset_MaximumGlobalError;

		// Token: 0x04001987 RID: 6535
		internal static int __PropertyOffset_bIgnoreAntiAliasing;

		// Token: 0x04001988 RID: 6536
		internal static int __PropertyOffset_bIgnoreColors;
	}
}
