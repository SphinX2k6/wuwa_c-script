using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000877 RID: 2167
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetComponent")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UWidgetComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BCAF RID: 48303 RVA: 0x0012D7EE File Offset: 0x0012B9EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetComponent._ClassPtr;
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x0012D7FC File Offset: 0x0012B9FC
		public UWidgetComponent() : this(BuiltinUtils.AllocNativeUObject(UWidgetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x0012D824 File Offset: 0x0012BA24
		[NullableContext(1)]
		public UWidgetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600BCB2 RID: 48306 RVA: 0x0012D857 File Offset: 0x0012BA57
		// (set) Token: 0x0600BCB3 RID: 48307 RVA: 0x0012D86B File Offset: 0x0012BA6B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserWidget> WidgetClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_WidgetClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_WidgetClass) = value;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600BCB4 RID: 48308 RVA: 0x0012D880 File Offset: 0x0012BA80
		// (set) Token: 0x0600BCB5 RID: 48309 RVA: 0x0012D894 File Offset: 0x0012BA94
		public unsafe FIntPoint DrawSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_DrawSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_DrawSize) = value;
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600BCB6 RID: 48310 RVA: 0x0012D8A9 File Offset: 0x0012BAA9
		// (set) Token: 0x0600BCB7 RID: 48311 RVA: 0x0012D8B9 File Offset: 0x0012BAB9
		public unsafe bool bManuallyRedraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bManuallyRedraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bManuallyRedraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600BCB8 RID: 48312 RVA: 0x0012D8CA File Offset: 0x0012BACA
		// (set) Token: 0x0600BCB9 RID: 48313 RVA: 0x0012D8DA File Offset: 0x0012BADA
		public unsafe bool bRedrawRequested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bRedrawRequested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bRedrawRequested) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600BCBA RID: 48314 RVA: 0x0012D8EB File Offset: 0x0012BAEB
		// (set) Token: 0x0600BCBB RID: 48315 RVA: 0x0012D8FB File Offset: 0x0012BAFB
		public unsafe float RedrawTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_RedrawTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_RedrawTime) = value;
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x0600BCBC RID: 48316 RVA: 0x0012D90C File Offset: 0x0012BB0C
		// (set) Token: 0x0600BCBD RID: 48317 RVA: 0x0012D920 File Offset: 0x0012BB20
		public unsafe FIntPoint CurrentDrawSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CurrentDrawSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CurrentDrawSize) = value;
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x0012D935 File Offset: 0x0012BB35
		// (set) Token: 0x0600BCBF RID: 48319 RVA: 0x0012D945 File Offset: 0x0012BB45
		public unsafe bool bDrawAtDesiredSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bDrawAtDesiredSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bDrawAtDesiredSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600BCC0 RID: 48320 RVA: 0x0012D956 File Offset: 0x0012BB56
		// (set) Token: 0x0600BCC1 RID: 48321 RVA: 0x0012D96A File Offset: 0x0012BB6A
		public unsafe FVector2D Pivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_Pivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_Pivot) = value;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600BCC2 RID: 48322 RVA: 0x0012D97F File Offset: 0x0012BB7F
		// (set) Token: 0x0600BCC3 RID: 48323 RVA: 0x0012D98F File Offset: 0x0012BB8F
		public unsafe bool bReceiveHardwareInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bReceiveHardwareInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bReceiveHardwareInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x0600BCC4 RID: 48324 RVA: 0x0012D9A0 File Offset: 0x0012BBA0
		// (set) Token: 0x0600BCC5 RID: 48325 RVA: 0x0012D9B0 File Offset: 0x0012BBB0
		public unsafe bool bWindowFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bWindowFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bWindowFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x0600BCC6 RID: 48326 RVA: 0x0012D9C1 File Offset: 0x0012BBC1
		// (set) Token: 0x0600BCC7 RID: 48327 RVA: 0x0012D9D1 File Offset: 0x0012BBD1
		public unsafe bool bApplyGammaCorrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bApplyGammaCorrection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bApplyGammaCorrection) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x0600BCC8 RID: 48328 RVA: 0x0012D9E2 File Offset: 0x0012BBE2
		// (set) Token: 0x0600BCC9 RID: 48329 RVA: 0x0012D9F6 File Offset: 0x0012BBF6
		public unsafe FLinearColor BackgroundColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_BackgroundColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_BackgroundColor) = value;
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0600BCCA RID: 48330 RVA: 0x0012DA0B File Offset: 0x0012BC0B
		// (set) Token: 0x0600BCCB RID: 48331 RVA: 0x0012DA1F File Offset: 0x0012BC1F
		public unsafe FLinearColor TintColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TintColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TintColorAndOpacity) = value;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x0012DA34 File Offset: 0x0012BC34
		// (set) Token: 0x0600BCCD RID: 48333 RVA: 0x0012DA44 File Offset: 0x0012BC44
		public unsafe float OpacityFromTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_OpacityFromTexture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_OpacityFromTexture) = value;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600BCCE RID: 48334 RVA: 0x0012DA55 File Offset: 0x0012BC55
		// (set) Token: 0x0600BCCF RID: 48335 RVA: 0x0012DA65 File Offset: 0x0012BC65
		public unsafe bool bIsTwoSided
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bIsTwoSided) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bIsTwoSided) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x0012DA76 File Offset: 0x0012BC76
		// (set) Token: 0x0600BCD1 RID: 48337 RVA: 0x0012DA86 File Offset: 0x0012BC86
		public unsafe bool TickWhenOffscreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TickWhenOffscreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TickWhenOffscreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600BCD2 RID: 48338 RVA: 0x0012DA97 File Offset: 0x0012BC97
		// (set) Token: 0x0600BCD3 RID: 48339 RVA: 0x0012DAAB File Offset: 0x0012BCAB
		public unsafe UBodySetup BodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_BodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600BCD4 RID: 48340 RVA: 0x0012DAC0 File Offset: 0x0012BCC0
		// (set) Token: 0x0600BCD5 RID: 48341 RVA: 0x0012DAD4 File Offset: 0x0012BCD4
		public unsafe UMaterialInterface TranslucentMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial, value);
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x0012DAE9 File Offset: 0x0012BCE9
		// (set) Token: 0x0600BCD7 RID: 48343 RVA: 0x0012DAFD File Offset: 0x0012BCFD
		public unsafe UMaterialInterface TranslucentMaterial_OneSided
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial_OneSided);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial_OneSided, value);
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x0600BCD8 RID: 48344 RVA: 0x0012DB12 File Offset: 0x0012BD12
		// (set) Token: 0x0600BCD9 RID: 48345 RVA: 0x0012DB26 File Offset: 0x0012BD26
		public unsafe UMaterialInterface OpaqueMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial, value);
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x0600BCDA RID: 48346 RVA: 0x0012DB3B File Offset: 0x0012BD3B
		// (set) Token: 0x0600BCDB RID: 48347 RVA: 0x0012DB4F File Offset: 0x0012BD4F
		public unsafe UMaterialInterface OpaqueMaterial_OneSided
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial_OneSided);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial_OneSided, value);
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x0600BCDC RID: 48348 RVA: 0x0012DB64 File Offset: 0x0012BD64
		// (set) Token: 0x0600BCDD RID: 48349 RVA: 0x0012DB78 File Offset: 0x0012BD78
		public unsafe UMaterialInterface MaskedMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial, value);
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600BCDE RID: 48350 RVA: 0x0012DB8D File Offset: 0x0012BD8D
		// (set) Token: 0x0600BCDF RID: 48351 RVA: 0x0012DBA1 File Offset: 0x0012BDA1
		public unsafe UMaterialInterface MaskedMaterial_OneSided
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial_OneSided);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial_OneSided, value);
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600BCE0 RID: 48352 RVA: 0x0012DBB6 File Offset: 0x0012BDB6
		// (set) Token: 0x0600BCE1 RID: 48353 RVA: 0x0012DBCA File Offset: 0x0012BDCA
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600BCE2 RID: 48354 RVA: 0x0012DBDF File Offset: 0x0012BDDF
		// (set) Token: 0x0600BCE3 RID: 48355 RVA: 0x0012DBF3 File Offset: 0x0012BDF3
		public unsafe UMaterialInstanceDynamic MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaterialInstance, value);
			}
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x0600BCE4 RID: 48356 RVA: 0x0012DC08 File Offset: 0x0012BE08
		// (set) Token: 0x0600BCE5 RID: 48357 RVA: 0x0012DC18 File Offset: 0x0012BE18
		public unsafe bool bAddedToScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bAddedToScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bAddedToScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x0012DC29 File Offset: 0x0012BE29
		// (set) Token: 0x0600BCE7 RID: 48359 RVA: 0x0012DC39 File Offset: 0x0012BE39
		public unsafe bool bEditTimeUsable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bEditTimeUsable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bEditTimeUsable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x0600BCE8 RID: 48360 RVA: 0x0012DC4A File Offset: 0x0012BE4A
		// (set) Token: 0x0600BCE9 RID: 48361 RVA: 0x0012DC5E File Offset: 0x0012BE5E
		public unsafe FName SharedLayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_SharedLayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_SharedLayerName) = value;
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0600BCEA RID: 48362 RVA: 0x0012DC73 File Offset: 0x0012BE73
		// (set) Token: 0x0600BCEB RID: 48363 RVA: 0x0012DC83 File Offset: 0x0012BE83
		public unsafe int LayerZOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_LayerZOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_LayerZOrder) = value;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0600BCEC RID: 48364 RVA: 0x0012DC94 File Offset: 0x0012BE94
		// (set) Token: 0x0600BCED RID: 48365 RVA: 0x0012DCA4 File Offset: 0x0012BEA4
		public unsafe float CylinderArcAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CylinderArcAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CylinderArcAngle) = value;
			}
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600BCEE RID: 48366 RVA: 0x0012DCB5 File Offset: 0x0012BEB5
		// (set) Token: 0x0600BCEF RID: 48367 RVA: 0x0012DCC9 File Offset: 0x0012BEC9
		public unsafe UUserWidget Widget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUserWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_Widget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_Widget, value);
			}
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x0012DCDE File Offset: 0x0012BEDE
		public void SetWindowFocusable(bool bInWindowFocusable)
		{
			UWidgetComponent.__SetWindowFocusable_Internal(base.NativePtr, bInWindowFocusable);
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x0012DCEC File Offset: 0x0012BEEC
		public void SetWidget(UUserWidget Widget)
		{
			UWidgetComponent.__SetWidget_Internal(base.NativePtr, (Widget != null) ? Widget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BCF2 RID: 48370 RVA: 0x0012DD09 File Offset: 0x0012BF09
		public void SetTwoSided(bool bWantTwoSided)
		{
			UWidgetComponent.__SetTwoSided_Internal(base.NativePtr, bWantTwoSided);
		}

		// Token: 0x0600BCF3 RID: 48371 RVA: 0x0012DD17 File Offset: 0x0012BF17
		public void SetTintColorAndOpacity(FLinearColor NewTintColorAndOpacity)
		{
			UWidgetComponent.__SetTintColorAndOpacity_Internal(base.NativePtr, NewTintColorAndOpacity);
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x0012DD25 File Offset: 0x0012BF25
		public void SetTickWhenOffscreen(bool bWantTickWhenOffscreen)
		{
			UWidgetComponent.__SetTickWhenOffscreen_Internal(base.NativePtr, bWantTickWhenOffscreen);
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x0012DD33 File Offset: 0x0012BF33
		public void SetRedrawTime(float InRedrawTime)
		{
			UWidgetComponent.__SetRedrawTime_Internal(base.NativePtr, InRedrawTime);
		}

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x0012DD41 File Offset: 0x0012BF41
		public void SetPivot(in FVector2D InPivot)
		{
			UWidgetComponent.__SetPivot_Internal(base.NativePtr, InPivot);
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x0012DD4F File Offset: 0x0012BF4F
		public void SetManuallyRedraw(bool bUseManualRedraw)
		{
			UWidgetComponent.__SetManuallyRedraw_Internal(base.NativePtr, bUseManualRedraw);
		}

		// Token: 0x0600BCF8 RID: 48376 RVA: 0x0012DD5D File Offset: 0x0012BF5D
		public void SetDrawSize(FVector2D Size)
		{
			UWidgetComponent.__SetDrawSize_Internal(base.NativePtr, Size);
		}

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x0012DD6B File Offset: 0x0012BF6B
		public void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize)
		{
			UWidgetComponent.__SetDrawAtDesiredSize_Internal(base.NativePtr, bInDrawAtDesiredSize);
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x0012DD79 File Offset: 0x0012BF79
		public void SetCylinderArcAngle(float InCylinderArcAngle)
		{
			UWidgetComponent.__SetCylinderArcAngle_Internal(base.NativePtr, InCylinderArcAngle);
		}

		// Token: 0x0600BCFB RID: 48379 RVA: 0x0012DD87 File Offset: 0x0012BF87
		public void SetBackgroundColor(FLinearColor NewBackgroundColor)
		{
			UWidgetComponent.__SetBackgroundColor_Internal(base.NativePtr, NewBackgroundColor);
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x0012DD95 File Offset: 0x0012BF95
		public void RequestRedraw()
		{
			UWidgetComponent.__RequestRedraw_Internal(base.NativePtr);
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x0012DDA2 File Offset: 0x0012BFA2
		public bool IsWidgetVisible()
		{
			return UWidgetComponent.__IsWidgetVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x0012DDAF File Offset: 0x0012BFAF
		public bool GetWindowFocusable()
		{
			return UWidgetComponent.__GetWindowFocusable_Internal(base.NativePtr);
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x0012DDBC File Offset: 0x0012BFBC
		public UUserWidget GetWidget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UWidgetComponent.__GetWidget_Internal(base.NativePtr));
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x0012DDCE File Offset: 0x0012BFCE
		public UUserWidget GetUserWidgetObject()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UWidgetComponent.__GetUserWidgetObject_Internal(base.NativePtr));
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x0012DDE0 File Offset: 0x0012BFE0
		public bool GetTwoSided()
		{
			return UWidgetComponent.__GetTwoSided_Internal(base.NativePtr);
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x0012DDED File Offset: 0x0012BFED
		public bool GetTickWhenOffscreen()
		{
			return UWidgetComponent.__GetTickWhenOffscreen_Internal(base.NativePtr);
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x0012DDFA File Offset: 0x0012BFFA
		public UTextureRenderTarget2D GetRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(UWidgetComponent.__GetRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x0012DE0C File Offset: 0x0012C00C
		public float GetRedrawTime()
		{
			return UWidgetComponent.__GetRedrawTime_Internal(base.NativePtr);
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x0012DE19 File Offset: 0x0012C019
		public FVector2D GetPivot()
		{
			return UWidgetComponent.__GetPivot_Internal(base.NativePtr);
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x0012DE26 File Offset: 0x0012C026
		public UMaterialInstanceDynamic GetMaterialInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UWidgetComponent.__GetMaterialInstance_Internal(base.NativePtr));
		}

		// Token: 0x0600BD07 RID: 48391 RVA: 0x0012DE38 File Offset: 0x0012C038
		public bool GetManuallyRedraw()
		{
			return UWidgetComponent.__GetManuallyRedraw_Internal(base.NativePtr);
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x0012DE45 File Offset: 0x0012C045
		public FVector2D GetDrawSize()
		{
			return UWidgetComponent.__GetDrawSize_Internal(base.NativePtr);
		}

		// Token: 0x0600BD09 RID: 48393 RVA: 0x0012DE52 File Offset: 0x0012C052
		public bool GetDrawAtDesiredSize()
		{
			return UWidgetComponent.__GetDrawAtDesiredSize_Internal(base.NativePtr);
		}

		// Token: 0x0600BD0A RID: 48394 RVA: 0x0012DE5F File Offset: 0x0012C05F
		public float GetCylinderArcAngle()
		{
			return UWidgetComponent.__GetCylinderArcAngle_Internal(base.NativePtr);
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x0012DE6C File Offset: 0x0012C06C
		public FVector2D GetCurrentDrawSize()
		{
			return UWidgetComponent.__GetCurrentDrawSize_Internal(base.NativePtr);
		}

		// Token: 0x0600BD0C RID: 48396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowFocusable_Internal(IntPtr @this, bool bInWindowFocusable);

		// Token: 0x0600BD0D RID: 48397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidget_Internal(IntPtr @this, IntPtr Widget);

		// Token: 0x0600BD0E RID: 48398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTwoSided_Internal(IntPtr @this, bool bWantTwoSided);

		// Token: 0x0600BD0F RID: 48399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTintColorAndOpacity_Internal(IntPtr @this, FLinearColor NewTintColorAndOpacity);

		// Token: 0x0600BD10 RID: 48400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickWhenOffscreen_Internal(IntPtr @this, bool bWantTickWhenOffscreen);

		// Token: 0x0600BD11 RID: 48401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRedrawTime_Internal(IntPtr @this, float InRedrawTime);

		// Token: 0x0600BD12 RID: 48402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPivot_Internal(IntPtr @this, in FVector2D InPivot);

		// Token: 0x0600BD13 RID: 48403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetManuallyRedraw_Internal(IntPtr @this, bool bUseManualRedraw);

		// Token: 0x0600BD14 RID: 48404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawSize_Internal(IntPtr @this, FVector2D Size);

		// Token: 0x0600BD15 RID: 48405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawAtDesiredSize_Internal(IntPtr @this, bool bInDrawAtDesiredSize);

		// Token: 0x0600BD16 RID: 48406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCylinderArcAngle_Internal(IntPtr @this, float InCylinderArcAngle);

		// Token: 0x0600BD17 RID: 48407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBackgroundColor_Internal(IntPtr @this, FLinearColor NewBackgroundColor);

		// Token: 0x0600BD18 RID: 48408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestRedraw_Internal(IntPtr @this);

		// Token: 0x0600BD19 RID: 48409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWidgetVisible_Internal(IntPtr @this);

		// Token: 0x0600BD1A RID: 48410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWindowFocusable_Internal(IntPtr @this);

		// Token: 0x0600BD1B RID: 48411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWidget_Internal(IntPtr @this);

		// Token: 0x0600BD1C RID: 48412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUserWidgetObject_Internal(IntPtr @this);

		// Token: 0x0600BD1D RID: 48413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTwoSided_Internal(IntPtr @this);

		// Token: 0x0600BD1E RID: 48414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTickWhenOffscreen_Internal(IntPtr @this);

		// Token: 0x0600BD1F RID: 48415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderTarget_Internal(IntPtr @this);

		// Token: 0x0600BD20 RID: 48416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRedrawTime_Internal(IntPtr @this);

		// Token: 0x0600BD21 RID: 48417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPivot_Internal(IntPtr @this);

		// Token: 0x0600BD22 RID: 48418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialInstance_Internal(IntPtr @this);

		// Token: 0x0600BD23 RID: 48419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetManuallyRedraw_Internal(IntPtr @this);

		// Token: 0x0600BD24 RID: 48420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetDrawSize_Internal(IntPtr @this);

		// Token: 0x0600BD25 RID: 48421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDrawAtDesiredSize_Internal(IntPtr @this);

		// Token: 0x0600BD26 RID: 48422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCylinderArcAngle_Internal(IntPtr @this);

		// Token: 0x0600BD27 RID: 48423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetCurrentDrawSize_Internal(IntPtr @this);

		// Token: 0x0600BD28 RID: 48424 RVA: 0x0012DE79 File Offset: 0x0012C079
		static UWidgetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetComponent");
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x0012DE87 File Offset: 0x0012C087
		protected UWidgetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400554A RID: 21834
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetComponent";

		// Token: 0x0400554B RID: 21835
		private static IntPtr _ClassPtr;

		// Token: 0x0400554C RID: 21836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400554D RID: 21837
		internal static int __PropertyOffset_WidgetClass;

		// Token: 0x0400554E RID: 21838
		internal static int __PropertyOffset_DrawSize;

		// Token: 0x0400554F RID: 21839
		internal static int __PropertyOffset_bManuallyRedraw;

		// Token: 0x04005550 RID: 21840
		internal static int __PropertyOffset_bRedrawRequested;

		// Token: 0x04005551 RID: 21841
		internal static int __PropertyOffset_RedrawTime;

		// Token: 0x04005552 RID: 21842
		internal static int __PropertyOffset_CurrentDrawSize;

		// Token: 0x04005553 RID: 21843
		internal static int __PropertyOffset_bDrawAtDesiredSize;

		// Token: 0x04005554 RID: 21844
		internal static int __PropertyOffset_Pivot;

		// Token: 0x04005555 RID: 21845
		internal static int __PropertyOffset_bReceiveHardwareInput;

		// Token: 0x04005556 RID: 21846
		internal static int __PropertyOffset_bWindowFocusable;

		// Token: 0x04005557 RID: 21847
		internal static int __PropertyOffset_bApplyGammaCorrection;

		// Token: 0x04005558 RID: 21848
		internal static int __PropertyOffset_BackgroundColor;

		// Token: 0x04005559 RID: 21849
		internal static int __PropertyOffset_TintColorAndOpacity;

		// Token: 0x0400555A RID: 21850
		internal static int __PropertyOffset_OpacityFromTexture;

		// Token: 0x0400555B RID: 21851
		internal static int __PropertyOffset_bIsTwoSided;

		// Token: 0x0400555C RID: 21852
		internal static int __PropertyOffset_TickWhenOffscreen;

		// Token: 0x0400555D RID: 21853
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x0400555E RID: 21854
		internal static int __PropertyOffset_TranslucentMaterial;

		// Token: 0x0400555F RID: 21855
		internal static int __PropertyOffset_TranslucentMaterial_OneSided;

		// Token: 0x04005560 RID: 21856
		internal static int __PropertyOffset_OpaqueMaterial;

		// Token: 0x04005561 RID: 21857
		internal static int __PropertyOffset_OpaqueMaterial_OneSided;

		// Token: 0x04005562 RID: 21858
		internal static int __PropertyOffset_MaskedMaterial;

		// Token: 0x04005563 RID: 21859
		internal static int __PropertyOffset_MaskedMaterial_OneSided;

		// Token: 0x04005564 RID: 21860
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x04005565 RID: 21861
		internal static int __PropertyOffset_MaterialInstance;

		// Token: 0x04005566 RID: 21862
		internal static int __PropertyOffset_bAddedToScreen;

		// Token: 0x04005567 RID: 21863
		internal static int __PropertyOffset_bEditTimeUsable;

		// Token: 0x04005568 RID: 21864
		internal static int __PropertyOffset_SharedLayerName;

		// Token: 0x04005569 RID: 21865
		internal static int __PropertyOffset_LayerZOrder;

		// Token: 0x0400556A RID: 21866
		internal static int __PropertyOffset_CylinderArcAngle;

		// Token: 0x0400556B RID: 21867
		internal static int __PropertyOffset_Widget;
	}
}
