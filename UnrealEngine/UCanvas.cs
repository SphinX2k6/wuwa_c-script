using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000919 RID: 2329
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Canvas")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class UCanvas : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600801C RID: 32796 RVA: 0x000B77CD File Offset: 0x000B59CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCanvas._ClassPtr;
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x000B77DC File Offset: 0x000B59DC
		public UCanvas() : this(BuiltinUtils.AllocNativeUObject(UCanvas.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x000B7804 File Offset: 0x000B5A04
		[NullableContext(1)]
		public UCanvas(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCanvas.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x0600801F RID: 32799 RVA: 0x000B7837 File Offset: 0x000B5A37
		// (set) Token: 0x06008020 RID: 32800 RVA: 0x000B7847 File Offset: 0x000B5A47
		public unsafe float OrgX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_OrgX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_OrgX) = value;
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06008021 RID: 32801 RVA: 0x000B7858 File Offset: 0x000B5A58
		// (set) Token: 0x06008022 RID: 32802 RVA: 0x000B7868 File Offset: 0x000B5A68
		public unsafe float OrgY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_OrgY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_OrgY) = value;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06008023 RID: 32803 RVA: 0x000B7879 File Offset: 0x000B5A79
		// (set) Token: 0x06008024 RID: 32804 RVA: 0x000B7889 File Offset: 0x000B5A89
		public unsafe float ClipX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_ClipX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_ClipX) = value;
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x000B789A File Offset: 0x000B5A9A
		// (set) Token: 0x06008026 RID: 32806 RVA: 0x000B78AA File Offset: 0x000B5AAA
		public unsafe float ClipY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_ClipY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_ClipY) = value;
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06008027 RID: 32807 RVA: 0x000B78BB File Offset: 0x000B5ABB
		// (set) Token: 0x06008028 RID: 32808 RVA: 0x000B78CF File Offset: 0x000B5ACF
		public unsafe FColor DrawColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_DrawColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_DrawColor) = value;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06008029 RID: 32809 RVA: 0x000B78E4 File Offset: 0x000B5AE4
		// (set) Token: 0x0600802A RID: 32810 RVA: 0x000B78FD File Offset: 0x000B5AFD
		public unsafe bool bCenterX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_bCenterX) & UCanvas.__PropertyMask_bCenterX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCanvas.__PropertyOffset_bCenterX) = ((*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_bCenterX) & ~UCanvas.__PropertyMask_bCenterX) | (value ? UCanvas.__PropertyMask_bCenterX : 0));
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600802B RID: 32811 RVA: 0x000B792D File Offset: 0x000B5B2D
		// (set) Token: 0x0600802C RID: 32812 RVA: 0x000B7946 File Offset: 0x000B5B46
		public unsafe bool bCenterY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_bCenterY) & UCanvas.__PropertyMask_bCenterY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCanvas.__PropertyOffset_bCenterY) = ((*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_bCenterY) & ~UCanvas.__PropertyMask_bCenterY) | (value ? UCanvas.__PropertyMask_bCenterY : 0));
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600802D RID: 32813 RVA: 0x000B7976 File Offset: 0x000B5B76
		// (set) Token: 0x0600802E RID: 32814 RVA: 0x000B798F File Offset: 0x000B5B8F
		public unsafe bool bNoSmooth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_bNoSmooth) & UCanvas.__PropertyMask_bNoSmooth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCanvas.__PropertyOffset_bNoSmooth) = ((*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_bNoSmooth) & ~UCanvas.__PropertyMask_bNoSmooth) | (value ? UCanvas.__PropertyMask_bNoSmooth : 0));
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x0600802F RID: 32815 RVA: 0x000B79BF File Offset: 0x000B5BBF
		// (set) Token: 0x06008030 RID: 32816 RVA: 0x000B79CF File Offset: 0x000B5BCF
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06008031 RID: 32817 RVA: 0x000B79E0 File Offset: 0x000B5BE0
		// (set) Token: 0x06008032 RID: 32818 RVA: 0x000B79F0 File Offset: 0x000B5BF0
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06008033 RID: 32819 RVA: 0x000B7A01 File Offset: 0x000B5C01
		// (set) Token: 0x06008034 RID: 32820 RVA: 0x000B7A15 File Offset: 0x000B5C15
		public unsafe FPlane ColorModulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_ColorModulate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCanvas.__PropertyOffset_ColorModulate) = value;
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06008035 RID: 32821 RVA: 0x000B7A2A File Offset: 0x000B5C2A
		// (set) Token: 0x06008036 RID: 32822 RVA: 0x000B7A3E File Offset: 0x000B5C3E
		public unsafe UTexture2D DefaultTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UCanvas.__PropertyOffset_DefaultTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCanvas.__PropertyOffset_DefaultTexture, value);
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x000B7A53 File Offset: 0x000B5C53
		// (set) Token: 0x06008038 RID: 32824 RVA: 0x000B7A67 File Offset: 0x000B5C67
		public unsafe UTexture2D GradientTexture0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UCanvas.__PropertyOffset_GradientTexture0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCanvas.__PropertyOffset_GradientTexture0, value);
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06008039 RID: 32825 RVA: 0x000B7A7C File Offset: 0x000B5C7C
		// (set) Token: 0x0600803A RID: 32826 RVA: 0x000B7A90 File Offset: 0x000B5C90
		public unsafe UReporterGraph ReporterGraph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UReporterGraph>(base.NativePtr / (IntPtr)sizeof(void*) + UCanvas.__PropertyOffset_ReporterGraph);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCanvas.__PropertyOffset_ReporterGraph, value);
			}
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x000B7AA8 File Offset: 0x000B5CA8
		[NullableContext(1)]
		public unsafe FVector2D K2_TextSize([Nullable(2)] UFont RenderFont, string RenderText, FVector2D? Scale = null)
		{
			FString fstring = FString.AllocTemp(RenderText);
			FVector2D result = UCanvas.__K2_TextSize_Internal(base.NativePtr, (RenderFont != null) ? RenderFont.NativePtr : IntPtr.Zero, fstring, Scale ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			});
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x000B7B18 File Offset: 0x000B5D18
		[NullableContext(1)]
		public unsafe FVector2D K2_StrLen([Nullable(2)] UFont RenderFont, string RenderText)
		{
			FString fstring = FString.AllocTemp(RenderText);
			FVector2D result = UCanvas.__K2_StrLen_Internal(base.NativePtr, (RenderFont != null) ? RenderFont.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x000B7B52 File Offset: 0x000B5D52
		public FVector K2_Project(FVector WorldLocation)
		{
			return UCanvas.__K2_Project_Internal(base.NativePtr, WorldLocation);
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x000B7B60 File Offset: 0x000B5D60
		public void K2_DrawTriangle(UTexture RenderTexture, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FCanvasUVTri> Triangles)
		{
			UCanvas.__K2_DrawTriangle_Internal(base.NativePtr, (RenderTexture != null) ? RenderTexture.NativePtr : IntPtr.Zero, (Triangles ?? new TArray<FCanvasUVTri>()).NativePtr);
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x000B7B8C File Offset: 0x000B5D8C
		public void K2_DrawTexture(UTexture RenderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D? CoordinateSize = null, FLinearColor? RenderColor = null, EBlendMode BlendMode = EBlendMode.BLEND_Translucent, float Rotation = 0f, FVector2D? PivotPoint = null)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr renderTexture = (RenderTexture != null) ? RenderTexture.NativePtr : IntPtr.Zero;
			FVector2D? fvector2D = CoordinateSize;
			FVector2D coordinateSize;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 1f,
					Y = 1f
				};
				coordinateSize = fvector2D2;
			}
			else
			{
				coordinateSize = fvector2D.GetValueOrDefault();
			}
			FLinearColor renderColor = RenderColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			};
			TEnumAsByte<EBlendMode> blendMode = BlendMode;
			fvector2D = PivotPoint;
			FVector2D pivotPoint;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 0.5f,
					Y = 0.5f
				};
				pivotPoint = fvector2D2;
			}
			else
			{
				pivotPoint = fvector2D.GetValueOrDefault();
			}
			UCanvas.__K2_DrawTexture_Internal(nativePtr, renderTexture, ScreenPosition, ScreenSize, CoordinatePosition, coordinateSize, renderColor, blendMode, Rotation, pivotPoint);
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x000B7C78 File Offset: 0x000B5E78
		[NullableContext(1)]
		public unsafe void K2_DrawText([Nullable(2)] UFont RenderFont, string RenderText, FVector2D ScreenPosition, FVector2D? Scale = null, FLinearColor? RenderColor = null, float Kerning = 0f, FLinearColor? ShadowColor = null, FVector2D? ShadowOffset = null, bool bCentreX = false, bool bCentreY = false, bool bOutlined = false, FLinearColor? OutlineColor = null)
		{
			FString fstring = FString.AllocTemp(RenderText);
			IntPtr nativePtr = base.NativePtr;
			IntPtr renderFont = (RenderFont != null) ? RenderFont.NativePtr : IntPtr.Zero;
			FVector2D? fvector2D = Scale;
			FVector2D scale;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 1f,
					Y = 1f
				};
				scale = fvector2D2;
			}
			else
			{
				scale = fvector2D.GetValueOrDefault();
			}
			FLinearColor? flinearColor = RenderColor;
			FLinearColor renderColor;
			if (flinearColor == null)
			{
				FLinearColor flinearColor2 = new FLinearColor
				{
					R = 1f,
					G = 1f,
					B = 1f,
					A = 1f
				};
				renderColor = flinearColor2;
			}
			else
			{
				renderColor = flinearColor.GetValueOrDefault();
			}
			flinearColor = ShadowColor;
			FLinearColor shadowColor;
			if (flinearColor == null)
			{
				FLinearColor flinearColor2 = new FLinearColor
				{
					R = 0f,
					G = 0f,
					B = 0f,
					A = 1f
				};
				shadowColor = flinearColor2;
			}
			else
			{
				shadowColor = flinearColor.GetValueOrDefault();
			}
			fvector2D = ShadowOffset;
			FVector2D shadowOffset;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 1f,
					Y = 1f
				};
				shadowOffset = fvector2D2;
			}
			else
			{
				shadowOffset = fvector2D.GetValueOrDefault();
			}
			flinearColor = OutlineColor;
			FLinearColor outlineColor;
			if (flinearColor == null)
			{
				FLinearColor flinearColor2 = new FLinearColor
				{
					R = 0f,
					G = 0f,
					B = 0f,
					A = 1f
				};
				outlineColor = flinearColor2;
			}
			else
			{
				outlineColor = flinearColor.GetValueOrDefault();
			}
			UCanvas.__K2_DrawText_Internal(nativePtr, renderFont, fstring, ScreenPosition, scale, renderColor, Kerning, shadowColor, shadowOffset, bCentreX, bCentreY, bOutlined, outlineColor);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x000B7E10 File Offset: 0x000B6010
		public void K2_DrawPolygon(UTexture RenderTexture, FVector2D ScreenPosition, FVector2D? Radius = null, int NumberOfSides = 3, FLinearColor? RenderColor = null)
		{
			UCanvas.__K2_DrawPolygon_Internal(base.NativePtr, (RenderTexture != null) ? RenderTexture.NativePtr : IntPtr.Zero, ScreenPosition, Radius ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, NumberOfSides, RenderColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x000B7EBC File Offset: 0x000B60BC
		public void K2_DrawMaterialTriangle(UMaterialInterface RenderMaterial, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FCanvasUVTri> Triangles)
		{
			UCanvas.__K2_DrawMaterialTriangle_Internal(base.NativePtr, (RenderMaterial != null) ? RenderMaterial.NativePtr : IntPtr.Zero, (Triangles ?? new TArray<FCanvasUVTri>()).NativePtr);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x000B7EE8 File Offset: 0x000B60E8
		public void K2_DrawMaterial(UMaterialInterface RenderMaterial, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D? CoordinateSize = null, float Rotation = 0f, FVector2D? PivotPoint = null)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr renderMaterial = (RenderMaterial != null) ? RenderMaterial.NativePtr : IntPtr.Zero;
			FVector2D? fvector2D = CoordinateSize;
			FVector2D coordinateSize;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 1f,
					Y = 1f
				};
				coordinateSize = fvector2D2;
			}
			else
			{
				coordinateSize = fvector2D.GetValueOrDefault();
			}
			fvector2D = PivotPoint;
			FVector2D pivotPoint;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 0.5f,
					Y = 0.5f
				};
				pivotPoint = fvector2D2;
			}
			else
			{
				pivotPoint = fvector2D.GetValueOrDefault();
			}
			UCanvas.__K2_DrawMaterial_Internal(nativePtr, renderMaterial, ScreenPosition, ScreenSize, CoordinatePosition, coordinateSize, Rotation, pivotPoint);
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x000B7F80 File Offset: 0x000B6180
		public void K2_DrawLine(FVector2D ScreenPositionA = default(FVector2D), FVector2D ScreenPositionB = default(FVector2D), float Thickness = 1f, FLinearColor? RenderColor = null)
		{
			UCanvas.__K2_DrawLine_Internal(base.NativePtr, ScreenPositionA, ScreenPositionB, Thickness, RenderColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x000B7FE8 File Offset: 0x000B61E8
		public void K2_DrawBox(FVector2D ScreenPosition, FVector2D ScreenSize, float Thickness = 1f, FLinearColor? RenderColor = null)
		{
			UCanvas.__K2_DrawBox_Internal(base.NativePtr, ScreenPosition, ScreenSize, Thickness, RenderColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x000B8050 File Offset: 0x000B6250
		public void K2_DrawBorder(UTexture BorderTexture, UTexture BackgroundTexture, UTexture LeftBorderTexture, UTexture RightBorderTexture, UTexture TopBorderTexture, UTexture BottomBorderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D? CoordinateSize = null, FLinearColor? RenderColor = null, FVector2D? BorderScale = null, FVector2D? BackgroundScale = null, float Rotation = 0f, FVector2D? PivotPoint = null, FVector2D CornerSize = default(FVector2D))
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr borderTexture = (BorderTexture != null) ? BorderTexture.NativePtr : IntPtr.Zero;
			IntPtr backgroundTexture = (BackgroundTexture != null) ? BackgroundTexture.NativePtr : IntPtr.Zero;
			IntPtr leftBorderTexture = (LeftBorderTexture != null) ? LeftBorderTexture.NativePtr : IntPtr.Zero;
			IntPtr rightBorderTexture = (RightBorderTexture != null) ? RightBorderTexture.NativePtr : IntPtr.Zero;
			IntPtr topBorderTexture = (TopBorderTexture != null) ? TopBorderTexture.NativePtr : IntPtr.Zero;
			IntPtr bottomBorderTexture = (BottomBorderTexture != null) ? BottomBorderTexture.NativePtr : IntPtr.Zero;
			FVector2D? fvector2D = CoordinateSize;
			FVector2D coordinateSize;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 1f,
					Y = 1f
				};
				coordinateSize = fvector2D2;
			}
			else
			{
				coordinateSize = fvector2D.GetValueOrDefault();
			}
			FLinearColor renderColor = RenderColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			};
			fvector2D = BorderScale;
			FVector2D borderScale;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 0.1f,
					Y = 0.1f
				};
				borderScale = fvector2D2;
			}
			else
			{
				borderScale = fvector2D.GetValueOrDefault();
			}
			fvector2D = BackgroundScale;
			FVector2D backgroundScale;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 0.1f,
					Y = 0.1f
				};
				backgroundScale = fvector2D2;
			}
			else
			{
				backgroundScale = fvector2D.GetValueOrDefault();
			}
			fvector2D = PivotPoint;
			FVector2D pivotPoint;
			if (fvector2D == null)
			{
				FVector2D fvector2D2 = new FVector2D
				{
					X = 0.5f,
					Y = 0.5f
				};
				pivotPoint = fvector2D2;
			}
			else
			{
				pivotPoint = fvector2D.GetValueOrDefault();
			}
			UCanvas.__K2_DrawBorder_Internal(nativePtr, borderTexture, backgroundTexture, leftBorderTexture, rightBorderTexture, topBorderTexture, bottomBorderTexture, ScreenPosition, ScreenSize, CoordinatePosition, coordinateSize, renderColor, borderScale, backgroundScale, Rotation, pivotPoint, CornerSize);
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x000B81FC File Offset: 0x000B63FC
		public unsafe void K2_Deproject(FVector2D ScreenPosition, ref FVector WorldOrigin, ref FVector WorldDirection)
		{
			fixed (FVector* ptr = &WorldOrigin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					UCanvas.__K2_Deproject_Internal(base.NativePtr, ScreenPosition, ref WorldOrigin, ref WorldDirection);
					ptr = null;
				}
			}
		}

		// Token: 0x06008048 RID: 32840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __K2_TextSize_Internal(IntPtr @this, IntPtr RenderFont, in FString RenderText, FVector2D Scale);

		// Token: 0x06008049 RID: 32841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __K2_StrLen_Internal(IntPtr @this, IntPtr RenderFont, in FString RenderText);

		// Token: 0x0600804A RID: 32842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_Project_Internal(IntPtr @this, FVector WorldLocation);

		// Token: 0x0600804B RID: 32843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawTriangle_Internal(IntPtr @this, IntPtr RenderTexture, IntPtr Triangles);

		// Token: 0x0600804C RID: 32844
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawTexture_Internal(IntPtr @this, IntPtr RenderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize, FLinearColor RenderColor, TEnumAsByte<EBlendMode> BlendMode, float Rotation, FVector2D PivotPoint);

		// Token: 0x0600804D RID: 32845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawText_Internal(IntPtr @this, IntPtr RenderFont, in FString RenderText, FVector2D ScreenPosition, FVector2D Scale, FLinearColor RenderColor, float Kerning, FLinearColor ShadowColor, FVector2D ShadowOffset, bool bCentreX, bool bCentreY, bool bOutlined, FLinearColor OutlineColor);

		// Token: 0x0600804E RID: 32846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawPolygon_Internal(IntPtr @this, IntPtr RenderTexture, FVector2D ScreenPosition, FVector2D Radius, int NumberOfSides, FLinearColor RenderColor);

		// Token: 0x0600804F RID: 32847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawMaterialTriangle_Internal(IntPtr @this, IntPtr RenderMaterial, IntPtr Triangles);

		// Token: 0x06008050 RID: 32848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawMaterial_Internal(IntPtr @this, IntPtr RenderMaterial, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize, float Rotation, FVector2D PivotPoint);

		// Token: 0x06008051 RID: 32849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawLine_Internal(IntPtr @this, FVector2D ScreenPositionA, FVector2D ScreenPositionB, float Thickness, FLinearColor RenderColor);

		// Token: 0x06008052 RID: 32850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawBox_Internal(IntPtr @this, FVector2D ScreenPosition, FVector2D ScreenSize, float Thickness, FLinearColor RenderColor);

		// Token: 0x06008053 RID: 32851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DrawBorder_Internal(IntPtr @this, IntPtr BorderTexture, IntPtr BackgroundTexture, IntPtr LeftBorderTexture, IntPtr RightBorderTexture, IntPtr TopBorderTexture, IntPtr BottomBorderTexture, FVector2D ScreenPosition, FVector2D ScreenSize, FVector2D CoordinatePosition, FVector2D CoordinateSize, FLinearColor RenderColor, FVector2D BorderScale, FVector2D BackgroundScale, float Rotation, FVector2D PivotPoint, FVector2D CornerSize);

		// Token: 0x06008054 RID: 32852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_Deproject_Internal(IntPtr @this, FVector2D ScreenPosition, ref FVector WorldOrigin, ref FVector WorldDirection);

		// Token: 0x06008055 RID: 32853 RVA: 0x000B8227 File Offset: 0x000B6427
		static UCanvas()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Canvas");
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x000B8235 File Offset: 0x000B6435
		protected UCanvas(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D62 RID: 15714
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Canvas";

		// Token: 0x04003D63 RID: 15715
		private static IntPtr _ClassPtr;

		// Token: 0x04003D64 RID: 15716
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D65 RID: 15717
		internal static int __PropertyOffset_OrgX;

		// Token: 0x04003D66 RID: 15718
		internal static int __PropertyOffset_OrgY;

		// Token: 0x04003D67 RID: 15719
		internal static int __PropertyOffset_ClipX;

		// Token: 0x04003D68 RID: 15720
		internal static int __PropertyOffset_ClipY;

		// Token: 0x04003D69 RID: 15721
		internal static int __PropertyOffset_DrawColor;

		// Token: 0x04003D6A RID: 15722
		internal static int __PropertyOffset_bCenterX;

		// Token: 0x04003D6B RID: 15723
		internal static byte __PropertyMask_bCenterX;

		// Token: 0x04003D6C RID: 15724
		internal static int __PropertyOffset_bCenterY;

		// Token: 0x04003D6D RID: 15725
		internal static byte __PropertyMask_bCenterY;

		// Token: 0x04003D6E RID: 15726
		internal static int __PropertyOffset_bNoSmooth;

		// Token: 0x04003D6F RID: 15727
		internal static byte __PropertyMask_bNoSmooth;

		// Token: 0x04003D70 RID: 15728
		internal static int __PropertyOffset_SizeX;

		// Token: 0x04003D71 RID: 15729
		internal static int __PropertyOffset_SizeY;

		// Token: 0x04003D72 RID: 15730
		internal static int __PropertyOffset_ColorModulate;

		// Token: 0x04003D73 RID: 15731
		internal static int __PropertyOffset_DefaultTexture;

		// Token: 0x04003D74 RID: 15732
		internal static int __PropertyOffset_GradientTexture0;

		// Token: 0x04003D75 RID: 15733
		internal static int __PropertyOffset_ReporterGraph;
	}
}
