using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C3F RID: 3135
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HUD")]
	[UnrealStructLayout(1280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class AHUD : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009ECC RID: 40652 RVA: 0x000E1AE7 File Offset: 0x000DFCE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AHUD._ClassPtr;
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x000E1AF4 File Offset: 0x000DFCF4
		public AHUD() : this(BuiltinUtils.AllocNativeUObject(AHUD.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x000E1B1C File Offset: 0x000DFD1C
		[NullableContext(1)]
		public AHUD(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AHUD.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06009ECF RID: 40655 RVA: 0x000E1B4F File Offset: 0x000DFD4F
		// (set) Token: 0x06009ED0 RID: 40656 RVA: 0x000E1B63 File Offset: 0x000DFD63
		public unsafe APlayerController PlayerOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_PlayerOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_PlayerOwner, value);
			}
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x000E1B78 File Offset: 0x000DFD78
		// (set) Token: 0x06009ED2 RID: 40658 RVA: 0x000E1B91 File Offset: 0x000DFD91
		public unsafe bool bLostFocusPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bLostFocusPaused) & AHUD.__PropertyMask_bLostFocusPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AHUD.__PropertyOffset_bLostFocusPaused) = ((*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bLostFocusPaused) & ~AHUD.__PropertyMask_bLostFocusPaused) | (value ? AHUD.__PropertyMask_bLostFocusPaused : 0));
			}
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x06009ED3 RID: 40659 RVA: 0x000E1BC1 File Offset: 0x000DFDC1
		// (set) Token: 0x06009ED4 RID: 40660 RVA: 0x000E1BDA File Offset: 0x000DFDDA
		public unsafe bool bShowHUD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowHUD) & AHUD.__PropertyMask_bShowHUD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowHUD) = ((*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowHUD) & ~AHUD.__PropertyMask_bShowHUD) | (value ? AHUD.__PropertyMask_bShowHUD : 0));
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x000E1C0A File Offset: 0x000DFE0A
		// (set) Token: 0x06009ED6 RID: 40662 RVA: 0x000E1C23 File Offset: 0x000DFE23
		public unsafe bool bShowDebugInfo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowDebugInfo) & AHUD.__PropertyMask_bShowDebugInfo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowDebugInfo) = ((*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowDebugInfo) & ~AHUD.__PropertyMask_bShowDebugInfo) | (value ? AHUD.__PropertyMask_bShowDebugInfo : 0));
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x06009ED7 RID: 40663 RVA: 0x000E1C53 File Offset: 0x000DFE53
		// (set) Token: 0x06009ED8 RID: 40664 RVA: 0x000E1C63 File Offset: 0x000DFE63
		public unsafe int CurrentTargetIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_CurrentTargetIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_CurrentTargetIndex) = value;
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x06009ED9 RID: 40665 RVA: 0x000E1C74 File Offset: 0x000DFE74
		// (set) Token: 0x06009EDA RID: 40666 RVA: 0x000E1C8D File Offset: 0x000DFE8D
		public unsafe bool bShowHitBoxDebugInfo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowHitBoxDebugInfo) & AHUD.__PropertyMask_bShowHitBoxDebugInfo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowHitBoxDebugInfo) = ((*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowHitBoxDebugInfo) & ~AHUD.__PropertyMask_bShowHitBoxDebugInfo) | (value ? AHUD.__PropertyMask_bShowHitBoxDebugInfo : 0));
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06009EDB RID: 40667 RVA: 0x000E1CBD File Offset: 0x000DFEBD
		// (set) Token: 0x06009EDC RID: 40668 RVA: 0x000E1CD6 File Offset: 0x000DFED6
		public unsafe bool bShowOverlays
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowOverlays) & AHUD.__PropertyMask_bShowOverlays) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowOverlays) = ((*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bShowOverlays) & ~AHUD.__PropertyMask_bShowOverlays) | (value ? AHUD.__PropertyMask_bShowOverlays : 0));
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x06009EDD RID: 40669 RVA: 0x000E1D06 File Offset: 0x000DFF06
		// (set) Token: 0x06009EDE RID: 40670 RVA: 0x000E1D1F File Offset: 0x000DFF1F
		public unsafe bool bEnableDebugTextShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bEnableDebugTextShadow) & AHUD.__PropertyMask_bEnableDebugTextShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AHUD.__PropertyOffset_bEnableDebugTextShadow) = ((*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_bEnableDebugTextShadow) & ~AHUD.__PropertyMask_bEnableDebugTextShadow) | (value ? AHUD.__PropertyMask_bEnableDebugTextShadow : 0));
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06009EDF RID: 40671 RVA: 0x000E1D50 File Offset: 0x000DFF50
		// (set) Token: 0x06009EE0 RID: 40672 RVA: 0x000E1D89 File Offset: 0x000DFF89
		[Nullable(1)]
		public TArray<AActor> PostRenderedActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._PostRenderedActors) == null)
				{
					result = (this._PostRenderedActors = new TArray<AActor>(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_PostRenderedActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PostRenderedActors.CopyAssign(value);
			}
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06009EE1 RID: 40673 RVA: 0x000E1D98 File Offset: 0x000DFF98
		// (set) Token: 0x06009EE2 RID: 40674 RVA: 0x000E1DD1 File Offset: 0x000DFFD1
		[Nullable(1)]
		public TArray<FName> DebugDisplay
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DebugDisplay) == null)
				{
					result = (this._DebugDisplay = new TArray<FName>(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_DebugDisplay, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugDisplay.CopyAssign(value);
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x000E1DE0 File Offset: 0x000DFFE0
		// (set) Token: 0x06009EE4 RID: 40676 RVA: 0x000E1E19 File Offset: 0x000E0019
		[Nullable(1)]
		public TArray<FName> ToggledDebugCategories
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ToggledDebugCategories) == null)
				{
					result = (this._ToggledDebugCategories = new TArray<FName>(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_ToggledDebugCategories, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ToggledDebugCategories.CopyAssign(value);
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06009EE5 RID: 40677 RVA: 0x000E1E27 File Offset: 0x000E0027
		// (set) Token: 0x06009EE6 RID: 40678 RVA: 0x000E1E3B File Offset: 0x000E003B
		public unsafe UCanvas Canvas
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCanvas>(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_Canvas);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_Canvas, value);
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x000E1E50 File Offset: 0x000E0050
		// (set) Token: 0x06009EE8 RID: 40680 RVA: 0x000E1E64 File Offset: 0x000E0064
		public unsafe UCanvas DebugCanvas
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCanvas>(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_DebugCanvas);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_DebugCanvas, value);
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x000E1E7C File Offset: 0x000E007C
		// (set) Token: 0x06009EEA RID: 40682 RVA: 0x000E1EB5 File Offset: 0x000E00B5
		[Nullable(1)]
		public TArray<FDebugTextInfo> DebugTextList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FDebugTextInfo> result;
				if ((result = this._DebugTextList) == null)
				{
					result = (this._DebugTextList = new TArray<FDebugTextInfo>(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_DebugTextList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugTextList.CopyAssign(value);
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x000E1EC3 File Offset: 0x000E00C3
		// (set) Token: 0x06009EEC RID: 40684 RVA: 0x000E1ED7 File Offset: 0x000E00D7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> ShowDebugTargetDesiredClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_ShowDebugTargetDesiredClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AHUD.__PropertyOffset_ShowDebugTargetDesiredClass) = value;
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x06009EED RID: 40685 RVA: 0x000E1EEC File Offset: 0x000E00EC
		// (set) Token: 0x06009EEE RID: 40686 RVA: 0x000E1F00 File Offset: 0x000E0100
		public unsafe AActor ShowDebugTargetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_ShowDebugTargetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHUD.__PropertyOffset_ShowDebugTargetActor, value);
			}
		}

		// Token: 0x06009EEF RID: 40687 RVA: 0x000E1F15 File Offset: 0x000E0115
		public void ShowHUD()
		{
			AHUD.__ShowHUD_Internal(base.NativePtr);
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x000E1F22 File Offset: 0x000E0122
		public void ShowDebugToggleSubCategory(FName Category)
		{
			AHUD.__ShowDebugToggleSubCategory_Internal(base.NativePtr, Category);
		}

		// Token: 0x06009EF1 RID: 40689 RVA: 0x000E1F30 File Offset: 0x000E0130
		public void ShowDebugForReticleTargetToggle([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> DesiredClass)
		{
			AHUD.__ShowDebugForReticleTargetToggle_Internal(base.NativePtr, DesiredClass._NativePtr);
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x000E1F43 File Offset: 0x000E0143
		public void ShowDebug(FName DebugType = default(FName))
		{
			AHUD.__ShowDebug_Internal(base.NativePtr, DebugType);
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x000E1F51 File Offset: 0x000E0151
		public void RemoveDebugText(AActor SrcActor, bool bLeaveDurationText)
		{
			AHUD.__RemoveDebugText_Internal(base.NativePtr, (SrcActor != null) ? SrcActor.NativePtr : IntPtr.Zero, bLeaveDurationText);
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x000E1F6F File Offset: 0x000E016F
		public void RemoveAllDebugStrings()
		{
			AHUD.__RemoveAllDebugStrings_Internal(base.NativePtr);
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x000E1F7C File Offset: 0x000E017C
		public virtual void ReceiveHitBoxRelease(FName BoxName)
		{
			AHUD.__ReceiveHitBoxRelease_Internal(base.NativePtr, BoxName);
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x000E1F8A File Offset: 0x000E018A
		public virtual void ReceiveHitBoxEndCursorOver(FName BoxName)
		{
			AHUD.__ReceiveHitBoxEndCursorOver_Internal(base.NativePtr, BoxName);
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x000E1F98 File Offset: 0x000E0198
		public virtual void ReceiveHitBoxClick(FName BoxName)
		{
			AHUD.__ReceiveHitBoxClick_Internal(base.NativePtr, BoxName);
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x000E1FA6 File Offset: 0x000E01A6
		public virtual void ReceiveHitBoxBeginCursorOver(FName BoxName)
		{
			AHUD.__ReceiveHitBoxBeginCursorOver_Internal(base.NativePtr, BoxName);
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x000E1FB4 File Offset: 0x000E01B4
		public virtual void ReceiveDrawHUD(int SizeX, int SizeY)
		{
			AHUD.__ReceiveDrawHUD_Internal(base.NativePtr, SizeX, SizeY);
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x000E1FC3 File Offset: 0x000E01C3
		public FVector Project(FVector Location)
		{
			return AHUD.__Project_Internal(base.NativePtr, Location);
		}

		// Token: 0x06009EFB RID: 40699 RVA: 0x000E1FD1 File Offset: 0x000E01D1
		public void PreviousDebugTarget()
		{
			AHUD.__PreviousDebugTarget_Internal(base.NativePtr);
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x000E1FDE File Offset: 0x000E01DE
		public void NextDebugTarget()
		{
			AHUD.__NextDebugTarget_Internal(base.NativePtr);
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x000E1FEC File Offset: 0x000E01EC
		[NullableContext(1)]
		public unsafe void GetTextSize(string Text, ref float OutWidth, ref float OutHeight, [Nullable(2)] UFont Font = null, float Scale = 1f)
		{
			FString fstring = FString.AllocTemp(Text);
			fixed (float* ptr = &OutWidth)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutHeight)
				{
					void* ptr4 = (void*)ptr3;
					AHUD.__GetTextSize_Internal(base.NativePtr, fstring, ref OutWidth, ref OutHeight, (Font != null) ? Font.NativePtr : IntPtr.Zero, Scale);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x000E203F File Offset: 0x000E023F
		public APlayerController GetOwningPlayerController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(AHUD.__GetOwningPlayerController_Internal(base.NativePtr));
		}

		// Token: 0x06009EFF RID: 40703 RVA: 0x000E2051 File Offset: 0x000E0251
		public APawn GetOwningPawn()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AHUD.__GetOwningPawn_Internal(base.NativePtr));
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x000E2063 File Offset: 0x000E0263
		public void GetActorsInSelectionRectangle([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ClassFilter, in FVector2D FirstPoint, in FVector2D SecondPoint, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors, bool bIncludeNonCollidingComponents = true, bool bActorMustBeFullyEnclosed = false)
		{
			AHUD.__GetActorsInSelectionRectangle_Internal(base.NativePtr, ClassFilter._NativePtr, FirstPoint, SecondPoint, (OutActors ?? new TArray<AActor>()).NativePtr, bIncludeNonCollidingComponents, bActorMustBeFullyEnclosed);
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x000E208D File Offset: 0x000E028D
		public void DrawTextureSimple(UTexture Texture, float ScreenX, float ScreenY, float Scale = 1f, bool bScalePosition = false)
		{
			AHUD.__DrawTextureSimple_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, ScreenX, ScreenY, Scale, bScalePosition);
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x000E20B0 File Offset: 0x000E02B0
		public void DrawTexture(UTexture Texture, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float TextureU, float TextureV, float TextureUWidth, float TextureVHeight, FLinearColor? TintColor = null, EBlendMode BlendMode = EBlendMode.BLEND_Translucent, float Scale = 1f, bool bScalePosition = false, float Rotation = 0f, FVector2D RotPivot = default(FVector2D))
		{
			AHUD.__DrawTexture_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, ScreenX, ScreenY, ScreenW, ScreenH, TextureU, TextureV, TextureUWidth, TextureVHeight, TintColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, BlendMode, Scale, bScalePosition, Rotation, RotPivot);
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x000E2144 File Offset: 0x000E0344
		[NullableContext(1)]
		public unsafe void DrawText(string Text, FLinearColor TextColor, float ScreenX, float ScreenY, [Nullable(2)] UFont Font = null, float Scale = 1f, bool bScalePosition = false)
		{
			FString fstring = FString.AllocTemp(Text);
			AHUD.__DrawText_Internal(base.NativePtr, fstring, TextColor, ScreenX, ScreenY, (Font != null) ? Font.NativePtr : IntPtr.Zero, Scale, bScalePosition);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x000E2188 File Offset: 0x000E0388
		public void DrawRect(FLinearColor RectColor, float ScreenX, float ScreenY, float ScreenW, float ScreenH)
		{
			AHUD.__DrawRect_Internal(base.NativePtr, RectColor, ScreenX, ScreenY, ScreenW, ScreenH);
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x000E219C File Offset: 0x000E039C
		public void DrawMaterialTriangle(UMaterialInterface Material, FVector2D V0_Pos, FVector2D V1_Pos, FVector2D V2_Pos, FVector2D V0_UV, FVector2D V1_UV, FVector2D V2_UV, FLinearColor? V0_Color = null, FLinearColor? V1_Color = null, FLinearColor? V2_Color = null)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr material = (Material != null) ? Material.NativePtr : IntPtr.Zero;
			FLinearColor? flinearColor = V0_Color;
			FLinearColor v0_Color;
			if (flinearColor == null)
			{
				FLinearColor flinearColor2 = new FLinearColor
				{
					R = 1f,
					G = 1f,
					B = 1f,
					A = 1f
				};
				v0_Color = flinearColor2;
			}
			else
			{
				v0_Color = flinearColor.GetValueOrDefault();
			}
			flinearColor = V1_Color;
			FLinearColor v1_Color;
			if (flinearColor == null)
			{
				FLinearColor flinearColor2 = new FLinearColor
				{
					R = 1f,
					G = 1f,
					B = 1f,
					A = 1f
				};
				v1_Color = flinearColor2;
			}
			else
			{
				v1_Color = flinearColor.GetValueOrDefault();
			}
			flinearColor = V2_Color;
			FLinearColor v2_Color;
			if (flinearColor == null)
			{
				FLinearColor flinearColor2 = new FLinearColor
				{
					R = 1f,
					G = 1f,
					B = 1f,
					A = 1f
				};
				v2_Color = flinearColor2;
			}
			else
			{
				v2_Color = flinearColor.GetValueOrDefault();
			}
			AHUD.__DrawMaterialTriangle_Internal(nativePtr, material, V0_Pos, V1_Pos, V2_Pos, V0_UV, V1_UV, V2_UV, v0_Color, v1_Color, v2_Color);
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x000E22B5 File Offset: 0x000E04B5
		public void DrawMaterialSimple(UMaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float Scale = 1f, bool bScalePosition = false)
		{
			AHUD.__DrawMaterialSimple_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero, ScreenX, ScreenY, ScreenW, ScreenH, Scale, bScalePosition);
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x000E22DC File Offset: 0x000E04DC
		public void DrawMaterial(UMaterialInterface Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float MaterialU, float MaterialV, float MaterialUWidth, float MaterialVHeight, float Scale = 1f, bool bScalePosition = false, float Rotation = 0f, FVector2D RotPivot = default(FVector2D))
		{
			AHUD.__DrawMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero, ScreenX, ScreenY, ScreenW, ScreenH, MaterialU, MaterialV, MaterialUWidth, MaterialVHeight, Scale, bScalePosition, Rotation, RotPivot);
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x000E231A File Offset: 0x000E051A
		public void DrawLine(float StartScreenX, float StartScreenY, float EndScreenX, float EndScreenY, FLinearColor LineColor, float LineThickness = 0f)
		{
			AHUD.__DrawLine_Internal(base.NativePtr, StartScreenX, StartScreenY, EndScreenX, EndScreenY, LineColor, LineThickness);
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x000E2330 File Offset: 0x000E0530
		public unsafe void Deproject(float ScreenX, float ScreenY, ref FVector WorldPosition, ref FVector WorldDirection)
		{
			fixed (FVector* ptr = &WorldPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					AHUD.__Deproject_Internal(base.NativePtr, ScreenX, ScreenY, ref WorldPosition, ref WorldDirection);
					ptr = null;
				}
			}
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x000E235E File Offset: 0x000E055E
		public void AddHitBox(FVector2D Position, FVector2D Size, FName InName, bool bConsumesInput, int Priority = 0)
		{
			AHUD.__AddHitBox_Internal(base.NativePtr, Position, Size, InName, bConsumesInput, Priority);
		}

		// Token: 0x06009F0B RID: 40715 RVA: 0x000E2374 File Offset: 0x000E0574
		public unsafe void AddDebugText([Nullable(1)] string DebugText, AActor SrcActor, float Duration, FVector Offset, FVector DesiredOffset, FColor TextColor, bool bSkipOverwriteCheck, bool bAbsoluteLocation, bool bKeepAttachedToActor, UFont InFont, float FontScale, bool bDrawShadow)
		{
			FString fstring = FString.AllocTemp(DebugText);
			AHUD.__AddDebugText_Internal(base.NativePtr, fstring, (SrcActor != null) ? SrcActor.NativePtr : IntPtr.Zero, Duration, Offset, DesiredOffset, TextColor, bSkipOverwriteCheck, bAbsoluteLocation, bKeepAttachedToActor, (InFont != null) ? InFont.NativePtr : IntPtr.Zero, FontScale, bDrawShadow);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009F0C RID: 40716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowHUD_Internal(IntPtr @this);

		// Token: 0x06009F0D RID: 40717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowDebugToggleSubCategory_Internal(IntPtr @this, FName Category);

		// Token: 0x06009F0E RID: 40718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowDebugForReticleTargetToggle_Internal(IntPtr @this, IntPtr DesiredClass);

		// Token: 0x06009F0F RID: 40719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowDebug_Internal(IntPtr @this, FName DebugType);

		// Token: 0x06009F10 RID: 40720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveDebugText_Internal(IntPtr @this, IntPtr SrcActor, bool bLeaveDurationText);

		// Token: 0x06009F11 RID: 40721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllDebugStrings_Internal(IntPtr @this);

		// Token: 0x06009F12 RID: 40722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveHitBoxRelease_Internal(IntPtr @this, FName BoxName);

		// Token: 0x06009F13 RID: 40723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveHitBoxEndCursorOver_Internal(IntPtr @this, FName BoxName);

		// Token: 0x06009F14 RID: 40724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveHitBoxClick_Internal(IntPtr @this, FName BoxName);

		// Token: 0x06009F15 RID: 40725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveHitBoxBeginCursorOver_Internal(IntPtr @this, FName BoxName);

		// Token: 0x06009F16 RID: 40726
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveDrawHUD_Internal(IntPtr @this, int SizeX, int SizeY);

		// Token: 0x06009F17 RID: 40727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Project_Internal(IntPtr @this, FVector Location);

		// Token: 0x06009F18 RID: 40728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreviousDebugTarget_Internal(IntPtr @this);

		// Token: 0x06009F19 RID: 40729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NextDebugTarget_Internal(IntPtr @this);

		// Token: 0x06009F1A RID: 40730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTextSize_Internal(IntPtr @this, in FString Text, ref float OutWidth, ref float OutHeight, IntPtr Font, float Scale);

		// Token: 0x06009F1B RID: 40731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayerController_Internal(IntPtr @this);

		// Token: 0x06009F1C RID: 40732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPawn_Internal(IntPtr @this);

		// Token: 0x06009F1D RID: 40733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorsInSelectionRectangle_Internal(IntPtr @this, IntPtr ClassFilter, in FVector2D FirstPoint, in FVector2D SecondPoint, IntPtr OutActors, bool bIncludeNonCollidingComponents, bool bActorMustBeFullyEnclosed);

		// Token: 0x06009F1E RID: 40734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawTextureSimple_Internal(IntPtr @this, IntPtr Texture, float ScreenX, float ScreenY, float Scale, bool bScalePosition);

		// Token: 0x06009F1F RID: 40735
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawTexture_Internal(IntPtr @this, IntPtr Texture, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float TextureU, float TextureV, float TextureUWidth, float TextureVHeight, FLinearColor TintColor, TEnumAsByte<EBlendMode> BlendMode, float Scale, bool bScalePosition, float Rotation, FVector2D RotPivot);

		// Token: 0x06009F20 RID: 40736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawText_Internal(IntPtr @this, in FString Text, FLinearColor TextColor, float ScreenX, float ScreenY, IntPtr Font, float Scale, bool bScalePosition);

		// Token: 0x06009F21 RID: 40737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawRect_Internal(IntPtr @this, FLinearColor RectColor, float ScreenX, float ScreenY, float ScreenW, float ScreenH);

		// Token: 0x06009F22 RID: 40738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawMaterialTriangle_Internal(IntPtr @this, IntPtr Material, FVector2D V0_Pos, FVector2D V1_Pos, FVector2D V2_Pos, FVector2D V0_UV, FVector2D V1_UV, FVector2D V2_UV, FLinearColor V0_Color, FLinearColor V1_Color, FLinearColor V2_Color);

		// Token: 0x06009F23 RID: 40739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawMaterialSimple_Internal(IntPtr @this, IntPtr Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float Scale, bool bScalePosition);

		// Token: 0x06009F24 RID: 40740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawMaterial_Internal(IntPtr @this, IntPtr Material, float ScreenX, float ScreenY, float ScreenW, float ScreenH, float MaterialU, float MaterialV, float MaterialUWidth, float MaterialVHeight, float Scale, bool bScalePosition, float Rotation, FVector2D RotPivot);

		// Token: 0x06009F25 RID: 40741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawLine_Internal(IntPtr @this, float StartScreenX, float StartScreenY, float EndScreenX, float EndScreenY, FLinearColor LineColor, float LineThickness);

		// Token: 0x06009F26 RID: 40742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Deproject_Internal(IntPtr @this, float ScreenX, float ScreenY, ref FVector WorldPosition, ref FVector WorldDirection);

		// Token: 0x06009F27 RID: 40743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddHitBox_Internal(IntPtr @this, FVector2D Position, FVector2D Size, FName InName, bool bConsumesInput, int Priority);

		// Token: 0x06009F28 RID: 40744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDebugText_Internal(IntPtr @this, in FString DebugText, IntPtr SrcActor, float Duration, FVector Offset, FVector DesiredOffset, FColor TextColor, bool bSkipOverwriteCheck, bool bAbsoluteLocation, bool bKeepAttachedToActor, IntPtr InFont, float FontScale, bool bDrawShadow);

		// Token: 0x06009F29 RID: 40745 RVA: 0x000E23D1 File Offset: 0x000E05D1
		static AHUD()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HUD");
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x000E23DF File Offset: 0x000E05DF
		protected AHUD(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005788 RID: 22408
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HUD";

		// Token: 0x04005789 RID: 22409
		private static IntPtr _ClassPtr;

		// Token: 0x0400578A RID: 22410
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400578B RID: 22411
		internal static int __PropertyOffset_PlayerOwner;

		// Token: 0x0400578C RID: 22412
		internal static int __PropertyOffset_bLostFocusPaused;

		// Token: 0x0400578D RID: 22413
		internal static byte __PropertyMask_bLostFocusPaused;

		// Token: 0x0400578E RID: 22414
		internal static int __PropertyOffset_bShowHUD;

		// Token: 0x0400578F RID: 22415
		internal static byte __PropertyMask_bShowHUD;

		// Token: 0x04005790 RID: 22416
		internal static int __PropertyOffset_bShowDebugInfo;

		// Token: 0x04005791 RID: 22417
		internal static byte __PropertyMask_bShowDebugInfo;

		// Token: 0x04005792 RID: 22418
		internal static int __PropertyOffset_CurrentTargetIndex;

		// Token: 0x04005793 RID: 22419
		internal static int __PropertyOffset_bShowHitBoxDebugInfo;

		// Token: 0x04005794 RID: 22420
		internal static byte __PropertyMask_bShowHitBoxDebugInfo;

		// Token: 0x04005795 RID: 22421
		internal static int __PropertyOffset_bShowOverlays;

		// Token: 0x04005796 RID: 22422
		internal static byte __PropertyMask_bShowOverlays;

		// Token: 0x04005797 RID: 22423
		internal static int __PropertyOffset_bEnableDebugTextShadow;

		// Token: 0x04005798 RID: 22424
		internal static byte __PropertyMask_bEnableDebugTextShadow;

		// Token: 0x04005799 RID: 22425
		internal static int __PropertyOffset_PostRenderedActors;

		// Token: 0x0400579A RID: 22426
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _PostRenderedActors;

		// Token: 0x0400579B RID: 22427
		internal static int __PropertyOffset_DebugDisplay;

		// Token: 0x0400579C RID: 22428
		private TArray<FName> _DebugDisplay;

		// Token: 0x0400579D RID: 22429
		internal static int __PropertyOffset_ToggledDebugCategories;

		// Token: 0x0400579E RID: 22430
		private TArray<FName> _ToggledDebugCategories;

		// Token: 0x0400579F RID: 22431
		internal static int __PropertyOffset_Canvas;

		// Token: 0x040057A0 RID: 22432
		internal static int __PropertyOffset_DebugCanvas;

		// Token: 0x040057A1 RID: 22433
		internal static int __PropertyOffset_DebugTextList;

		// Token: 0x040057A2 RID: 22434
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDebugTextInfo> _DebugTextList;

		// Token: 0x040057A3 RID: 22435
		internal static int __PropertyOffset_ShowDebugTargetDesiredClass;

		// Token: 0x040057A4 RID: 22436
		internal static int __PropertyOffset_ShowDebugTargetActor;

		// Token: 0x02002D12 RID: 11538
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ReceiveHitBoxRelease_FunctionParams
		{
			// Token: 0x040166DD RID: 91869
			[FieldOffset(0)]
			public FName BoxName;
		}

		// Token: 0x02002D13 RID: 11539
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ReceiveHitBoxEndCursorOver_FunctionParams
		{
			// Token: 0x040166DE RID: 91870
			[FieldOffset(0)]
			public FName BoxName;
		}

		// Token: 0x02002D14 RID: 11540
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ReceiveHitBoxClick_FunctionParams
		{
			// Token: 0x040166DF RID: 91871
			[FieldOffset(0)]
			public FName BoxName;
		}

		// Token: 0x02002D15 RID: 11541
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ReceiveHitBoxBeginCursorOver_FunctionParams
		{
			// Token: 0x040166E0 RID: 91872
			[FieldOffset(0)]
			public FName BoxName;
		}

		// Token: 0x02002D16 RID: 11542
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveDrawHUD_FunctionParams
		{
			// Token: 0x040166E1 RID: 91873
			[FieldOffset(0)]
			public int SizeX;

			// Token: 0x040166E2 RID: 91874
			[FieldOffset(4)]
			public int SizeY;
		}
	}
}
