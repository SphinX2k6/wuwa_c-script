using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200282A RID: 10282
	[UnrealObjectPath("/Script/SlateCore.SlateBrush")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FSlateBrush : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026355 RID: 156501 RVA: 0x0039FE84 File Offset: 0x0039E084
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateBrush._ScriptStructPtr != 0) ? FSlateBrush._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SlateBrush", ref FSlateBrush._ScriptStructPtr);
		}

		// Token: 0x1700937B RID: 37755
		// (get) Token: 0x06026356 RID: 156502 RVA: 0x0039FEA8 File Offset: 0x0039E0A8
		// (set) Token: 0x06026357 RID: 156503 RVA: 0x0039FEBC File Offset: 0x0039E0BC
		public unsafe FVector2D ImageSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_ImageSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_ImageSize) = value;
			}
		}

		// Token: 0x1700937C RID: 37756
		// (get) Token: 0x06026358 RID: 156504 RVA: 0x0039FED1 File Offset: 0x0039E0D1
		// (set) Token: 0x06026359 RID: 156505 RVA: 0x0039FEE5 File Offset: 0x0039E0E5
		public unsafe FMargin Margin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_Margin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_Margin) = value;
			}
		}

		// Token: 0x1700937D RID: 37757
		// (get) Token: 0x0602635A RID: 156506 RVA: 0x0039FEFC File Offset: 0x0039E0FC
		// (set) Token: 0x0602635B RID: 156507 RVA: 0x0039FF3F File Offset: 0x0039E13F
		[Nullable(1)]
		public FSlateColor TintColor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._TintColor) == null)
				{
					result = (this._TintColor = new FSlateColor(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_TintColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_TintColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700937E RID: 37758
		// (get) Token: 0x0602635C RID: 156508 RVA: 0x0039FF60 File Offset: 0x0039E160
		// (set) Token: 0x0602635D RID: 156509 RVA: 0x0039FF74 File Offset: 0x0039E174
		[Nullable(2)]
		public unsafe UObject ResourceObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSlateBrush.__PropertyOffset_ResourceObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSlateBrush.__PropertyOffset_ResourceObject, value);
			}
		}

		// Token: 0x1700937F RID: 37759
		// (get) Token: 0x0602635E RID: 156510 RVA: 0x0039FF89 File Offset: 0x0039E189
		// (set) Token: 0x0602635F RID: 156511 RVA: 0x0039FF9D File Offset: 0x0039E19D
		public unsafe FName ResourceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_ResourceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_ResourceName) = value;
			}
		}

		// Token: 0x17009380 RID: 37760
		// (get) Token: 0x06026360 RID: 156512 RVA: 0x0039FFB2 File Offset: 0x0039E1B2
		// (set) Token: 0x06026361 RID: 156513 RVA: 0x0039FFC6 File Offset: 0x0039E1C6
		public unsafe FBox2D UVRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_UVRegion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_UVRegion) = value;
			}
		}

		// Token: 0x17009381 RID: 37761
		// (get) Token: 0x06026362 RID: 156514 RVA: 0x0039FFDB File Offset: 0x0039E1DB
		// (set) Token: 0x06026363 RID: 156515 RVA: 0x0039FFEF File Offset: 0x0039E1EF
		public unsafe TEnumAsByte<ESlateBrushDrawType> DrawAs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_DrawAs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_DrawAs) = value;
			}
		}

		// Token: 0x17009382 RID: 37762
		// (get) Token: 0x06026364 RID: 156516 RVA: 0x003A0004 File Offset: 0x0039E204
		// (set) Token: 0x06026365 RID: 156517 RVA: 0x003A0018 File Offset: 0x0039E218
		public unsafe TEnumAsByte<ESlateBrushTileType> Tiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_Tiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_Tiling) = value;
			}
		}

		// Token: 0x17009383 RID: 37763
		// (get) Token: 0x06026366 RID: 156518 RVA: 0x003A002D File Offset: 0x0039E22D
		// (set) Token: 0x06026367 RID: 156519 RVA: 0x003A0041 File Offset: 0x0039E241
		public unsafe TEnumAsByte<ESlateBrushMirrorType> Mirroring
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_Mirroring);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_Mirroring) = value;
			}
		}

		// Token: 0x17009384 RID: 37764
		// (get) Token: 0x06026368 RID: 156520 RVA: 0x003A0056 File Offset: 0x0039E256
		// (set) Token: 0x06026369 RID: 156521 RVA: 0x003A006A File Offset: 0x0039E26A
		public unsafe TEnumAsByte<ESlateBrushImageType> ImageType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_ImageType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_ImageType) = value;
			}
		}

		// Token: 0x17009385 RID: 37765
		// (get) Token: 0x0602636A RID: 156522 RVA: 0x003A007F File Offset: 0x0039E27F
		// (set) Token: 0x0602636B RID: 156523 RVA: 0x003A0098 File Offset: 0x0039E298
		public unsafe bool bIsDynamicallyLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_bIsDynamicallyLoaded) & FSlateBrush.__PropertyMask_bIsDynamicallyLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_bIsDynamicallyLoaded) = ((*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_bIsDynamicallyLoaded) & ~FSlateBrush.__PropertyMask_bIsDynamicallyLoaded) | (value ? FSlateBrush.__PropertyMask_bIsDynamicallyLoaded : 0));
			}
		}

		// Token: 0x17009386 RID: 37766
		// (get) Token: 0x0602636C RID: 156524 RVA: 0x003A00C8 File Offset: 0x0039E2C8
		// (set) Token: 0x0602636D RID: 156525 RVA: 0x003A00E1 File Offset: 0x0039E2E1
		public unsafe bool bHasUObject_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_bHasUObject_DEPRECATED) & FSlateBrush.__PropertyMask_bHasUObject_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_bHasUObject_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FSlateBrush.__PropertyOffset_bHasUObject_DEPRECATED) & ~FSlateBrush.__PropertyMask_bHasUObject_DEPRECATED) | (value ? FSlateBrush.__PropertyMask_bHasUObject_DEPRECATED : 0));
			}
		}

		// Token: 0x0602636E RID: 156526 RVA: 0x003A0111 File Offset: 0x0039E311
		public FSlateBrush()
		{
		}

		// Token: 0x0602636F RID: 156527 RVA: 0x003A011C File Offset: 0x0039E31C
		public FSlateBrush(FVector2D ImageSize, FMargin Margin, FLinearColor Tint_DEPRECATED, [Nullable(1)] FSlateColor TintColor, [Nullable(1)] UObject ResourceObject, FName ResourceName, FBox2D UVRegion, TEnumAsByte<ESlateBrushDrawType> DrawAs, TEnumAsByte<ESlateBrushTileType> Tiling, TEnumAsByte<ESlateBrushMirrorType> Mirroring, TEnumAsByte<ESlateBrushImageType> ImageType, bool bIsDynamicallyLoaded, bool bHasUObject_DEPRECATED)
		{
			this.ImageSize = ImageSize;
			this.Margin = Margin;
			this.TintColor = TintColor;
			this.ResourceObject = ResourceObject;
			this.ResourceName = ResourceName;
			this.UVRegion = UVRegion;
			this.DrawAs = DrawAs;
			this.Tiling = Tiling;
			this.Mirroring = Mirroring;
			this.ImageType = ImageType;
			this.bIsDynamicallyLoaded = bIsDynamicallyLoaded;
			this.bHasUObject_DEPRECATED = bHasUObject_DEPRECATED;
		}

		// Token: 0x06026370 RID: 156528 RVA: 0x003A018D File Offset: 0x0039E38D
		protected override IntPtr GetUStructPtr()
		{
			return FSlateBrush.StaticStruct();
		}

		// Token: 0x06026371 RID: 156529 RVA: 0x003A0199 File Offset: 0x0039E399
		[NullableContext(2)]
		public FSlateBrush(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026372 RID: 156530 RVA: 0x003A01A3 File Offset: 0x0039E3A3
		public FSlateBrush(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026373 RID: 156531 RVA: 0x003A01AE File Offset: 0x0039E3AE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateBrush(Pointer, false, true);
		}

		// Token: 0x06026374 RID: 156532 RVA: 0x003A01B8 File Offset: 0x0039E3B8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateBrush(Pointer, MemoryOwner);
		}

		// Token: 0x04014EA0 RID: 85664
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.SlateBrush";

		// Token: 0x04014EA1 RID: 85665
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EA2 RID: 85666
		internal static int __PropertyOffset_ImageSize;

		// Token: 0x04014EA3 RID: 85667
		internal static int __PropertyOffset_Margin;

		// Token: 0x04014EA4 RID: 85668
		internal static int __PropertyOffset_TintColor;

		// Token: 0x04014EA5 RID: 85669
		[Nullable(2)]
		private FSlateColor _TintColor;

		// Token: 0x04014EA6 RID: 85670
		internal static int __PropertyOffset_ResourceObject;

		// Token: 0x04014EA7 RID: 85671
		internal static int __PropertyOffset_ResourceName;

		// Token: 0x04014EA8 RID: 85672
		internal static int __PropertyOffset_UVRegion;

		// Token: 0x04014EA9 RID: 85673
		internal static int __PropertyOffset_DrawAs;

		// Token: 0x04014EAA RID: 85674
		internal static int __PropertyOffset_Tiling;

		// Token: 0x04014EAB RID: 85675
		internal static int __PropertyOffset_Mirroring;

		// Token: 0x04014EAC RID: 85676
		internal static int __PropertyOffset_ImageType;

		// Token: 0x04014EAD RID: 85677
		internal static int __PropertyOffset_bIsDynamicallyLoaded;

		// Token: 0x04014EAE RID: 85678
		internal static byte __PropertyMask_bIsDynamicallyLoaded;

		// Token: 0x04014EAF RID: 85679
		internal static int __PropertyOffset_bHasUObject_DEPRECATED;

		// Token: 0x04014EB0 RID: 85680
		internal static byte __PropertyMask_bHasUObject_DEPRECATED;
	}
}
