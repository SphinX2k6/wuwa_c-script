using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002979 RID: 10617
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Image")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class UImage : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027441 RID: 160833 RVA: 0x003BE09B File Offset: 0x003BC29B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImage._ClassPtr;
		}

		// Token: 0x06027442 RID: 160834 RVA: 0x003BE0A8 File Offset: 0x003BC2A8
		public UImage() : this(BuiltinUtils.AllocNativeUObject(UImage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027443 RID: 160835 RVA: 0x003BE0D0 File Offset: 0x003BC2D0
		public UImage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096F7 RID: 38647
		// (get) Token: 0x06027444 RID: 160836 RVA: 0x003BE104 File Offset: 0x003BC304
		// (set) Token: 0x06027445 RID: 160837 RVA: 0x003BE13D File Offset: 0x003BC33D
		public FSlateBrush Brush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Brush) == null)
				{
					result = (this._Brush = new FSlateBrush(base.NativePtr + (IntPtr)UImage.__PropertyOffset_Brush, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)UImage.__PropertyOffset_Brush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096F8 RID: 38648
		// (get) Token: 0x06027446 RID: 160838 RVA: 0x003BE160 File Offset: 0x003BC360
		// (set) Token: 0x06027447 RID: 160839 RVA: 0x003BE199 File Offset: 0x003BC399
		public FGetSlateBrush BrushDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetSlateBrush result;
				if ((result = this._BrushDelegate) == null)
				{
					result = (this._BrushDelegate = new FGetSlateBrush(base.NativePtr + (IntPtr)UImage.__PropertyOffset_BrushDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UImage.__PropertyOffset_BrushDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096F9 RID: 38649
		// (get) Token: 0x06027448 RID: 160840 RVA: 0x003BE1BA File Offset: 0x003BC3BA
		// (set) Token: 0x06027449 RID: 160841 RVA: 0x003BE1CE File Offset: 0x003BC3CE
		public unsafe FLinearColor ColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImage.__PropertyOffset_ColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImage.__PropertyOffset_ColorAndOpacity) = value;
			}
		}

		// Token: 0x170096FA RID: 38650
		// (get) Token: 0x0602744A RID: 160842 RVA: 0x003BE1E4 File Offset: 0x003BC3E4
		// (set) Token: 0x0602744B RID: 160843 RVA: 0x003BE21D File Offset: 0x003BC41D
		public FGetLinearColor ColorAndOpacityDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetLinearColor result;
				if ((result = this._ColorAndOpacityDelegate) == null)
				{
					result = (this._ColorAndOpacityDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UImage.__PropertyOffset_ColorAndOpacityDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UImage.__PropertyOffset_ColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170096FB RID: 38651
		// (get) Token: 0x0602744C RID: 160844 RVA: 0x003BE23E File Offset: 0x003BC43E
		// (set) Token: 0x0602744D RID: 160845 RVA: 0x003BE24E File Offset: 0x003BC44E
		public unsafe bool bFlipForRightToLeftFlowDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UImage.__PropertyOffset_bFlipForRightToLeftFlowDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UImage.__PropertyOffset_bFlipForRightToLeftFlowDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x170096FC RID: 38652
		// (get) Token: 0x0602744E RID: 160846 RVA: 0x003BE260 File Offset: 0x003BC460
		// (set) Token: 0x0602744F RID: 160847 RVA: 0x003BE299 File Offset: 0x003BC499
		public FOnPointerEvent OnMouseButtonDownEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnPointerEvent result;
				if ((result = this._OnMouseButtonDownEvent) == null)
				{
					result = (this._OnMouseButtonDownEvent = new FOnPointerEvent(base.NativePtr + (IntPtr)UImage.__PropertyOffset_OnMouseButtonDownEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UImage.__PropertyOffset_OnMouseButtonDownEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027450 RID: 160848 RVA: 0x003BE2BA File Offset: 0x003BC4BA
		public void SetOpacity(float InOpacity)
		{
			UImage.__SetOpacity_Internal(base.NativePtr, InOpacity);
		}

		// Token: 0x06027451 RID: 160849 RVA: 0x003BE2C8 File Offset: 0x003BC4C8
		public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
		{
			UImage.__SetColorAndOpacity_Internal(base.NativePtr, InColorAndOpacity);
		}

		// Token: 0x06027452 RID: 160850 RVA: 0x003BE2D6 File Offset: 0x003BC4D6
		[NullableContext(2)]
		public void SetBrushTintColor(FSlateColor TintColor)
		{
			UImage.__SetBrushTintColor_Internal(base.NativePtr, (TintColor ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x06027453 RID: 160851 RVA: 0x003BE2F2 File Offset: 0x003BC4F2
		public void SetBrushSize(FVector2D DesiredSize)
		{
			UImage.__SetBrushSize_Internal(base.NativePtr, DesiredSize);
		}

		// Token: 0x06027454 RID: 160852 RVA: 0x003BE300 File Offset: 0x003BC500
		[NullableContext(2)]
		public void SetBrushResourceObject(UObject ResourceObject)
		{
			UImage.__SetBrushResourceObject_Internal(base.NativePtr, (ResourceObject != null) ? ResourceObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027455 RID: 160853 RVA: 0x003BE31D File Offset: 0x003BC51D
		[NullableContext(2)]
		public void SetBrushFromTextureDynamic(UTexture2DDynamic Texture, bool bMatchSize = false)
		{
			UImage.__SetBrushFromTextureDynamic_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, bMatchSize);
		}

		// Token: 0x06027456 RID: 160854 RVA: 0x003BE33B File Offset: 0x003BC53B
		[NullableContext(2)]
		public void SetBrushFromTexture(UTexture2D Texture, bool bMatchSize = false)
		{
			UImage.__SetBrushFromTexture_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, bMatchSize);
		}

		// Token: 0x06027457 RID: 160855 RVA: 0x003BE359 File Offset: 0x003BC559
		public void SetBrushFromSoftTexture(TSoftObjectPtr<UTexture2D> SoftTexture, bool bMatchSize = false)
		{
			UImage.__SetBrushFromSoftTexture_Internal(base.NativePtr, (SoftTexture ?? new TSoftObjectPtr<UTexture2D>()).NativePtr, bMatchSize);
		}

		// Token: 0x06027458 RID: 160856 RVA: 0x003BE376 File Offset: 0x003BC576
		public void SetBrushFromSoftMaterial(TSoftObjectPtr<UMaterialInterface> SoftMaterial)
		{
			UImage.__SetBrushFromSoftMaterial_Internal(base.NativePtr, (SoftMaterial ?? new TSoftObjectPtr<UMaterialInterface>()).NativePtr);
		}

		// Token: 0x06027459 RID: 160857 RVA: 0x003BE392 File Offset: 0x003BC592
		[NullableContext(2)]
		public void SetBrushFromMaterial(UMaterialInterface Material)
		{
			UImage.__SetBrushFromMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602745A RID: 160858 RVA: 0x003BE3B0 File Offset: 0x003BC5B0
		[NullableContext(2)]
		public void SetBrushFromAtlasInterface(ISlateTextureAtlasInterface AtlasRegion, bool bMatchSize = false)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(AtlasRegion, (AtlasRegion != null) ? AtlasRegion.InterfaceOffset() : 0);
			UImage.__SetBrushFromAtlasInterface_Internal(base.NativePtr, fscriptInterface, bMatchSize);
		}

		// Token: 0x0602745B RID: 160859 RVA: 0x003BE3DF File Offset: 0x003BC5DF
		[NullableContext(2)]
		public void SetBrushFromAsset(USlateBrushAsset Asset)
		{
			UImage.__SetBrushFromAsset_Internal(base.NativePtr, (Asset != null) ? Asset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602745C RID: 160860 RVA: 0x003BE3FC File Offset: 0x003BC5FC
		[NullableContext(2)]
		public void SetBrush(in FSlateBrush InBrush)
		{
			UImage.__SetBrush_Internal(base.NativePtr, (InBrush ?? new FSlateBrush()).NativePtr);
		}

		// Token: 0x0602745D RID: 160861 RVA: 0x003BE419 File Offset: 0x003BC619
		[NullableContext(2)]
		public UMaterialInstanceDynamic GetDynamicMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UImage.__GetDynamicMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0602745E RID: 160862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOpacity_Internal(IntPtr @this, float InOpacity);

		// Token: 0x0602745F RID: 160863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorAndOpacity_Internal(IntPtr @this, FLinearColor InColorAndOpacity);

		// Token: 0x06027460 RID: 160864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushTintColor_Internal(IntPtr @this, IntPtr TintColor);

		// Token: 0x06027461 RID: 160865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushSize_Internal(IntPtr @this, FVector2D DesiredSize);

		// Token: 0x06027462 RID: 160866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushResourceObject_Internal(IntPtr @this, IntPtr ResourceObject);

		// Token: 0x06027463 RID: 160867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromTextureDynamic_Internal(IntPtr @this, IntPtr Texture, bool bMatchSize);

		// Token: 0x06027464 RID: 160868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromTexture_Internal(IntPtr @this, IntPtr Texture, bool bMatchSize);

		// Token: 0x06027465 RID: 160869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromSoftTexture_Internal(IntPtr @this, IntPtr SoftTexture, bool bMatchSize);

		// Token: 0x06027466 RID: 160870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromSoftMaterial_Internal(IntPtr @this, IntPtr SoftMaterial);

		// Token: 0x06027467 RID: 160871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromMaterial_Internal(IntPtr @this, IntPtr Material);

		// Token: 0x06027468 RID: 160872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromAtlasInterface_Internal(IntPtr @this, in FScriptInterface AtlasRegion, bool bMatchSize);

		// Token: 0x06027469 RID: 160873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromAsset_Internal(IntPtr @this, IntPtr Asset);

		// Token: 0x0602746A RID: 160874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrush_Internal(IntPtr @this, IntPtr InBrush);

		// Token: 0x0602746B RID: 160875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicMaterial_Internal(IntPtr @this);

		// Token: 0x0602746C RID: 160876 RVA: 0x003BE42B File Offset: 0x003BC62B
		static UImage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Image");
		}

		// Token: 0x0602746D RID: 160877 RVA: 0x003BE439 File Offset: 0x003BC639
		protected UImage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015923 RID: 88355
		public new const string __ObjectPath = "/Script/UMG.Image";

		// Token: 0x04015924 RID: 88356
		private static IntPtr _ClassPtr;

		// Token: 0x04015925 RID: 88357
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015926 RID: 88358
		internal static int __PropertyOffset_Brush;

		// Token: 0x04015927 RID: 88359
		[Nullable(2)]
		private FSlateBrush _Brush;

		// Token: 0x04015928 RID: 88360
		internal static int __PropertyOffset_BrushDelegate;

		// Token: 0x04015929 RID: 88361
		[Nullable(2)]
		private FGetSlateBrush _BrushDelegate;

		// Token: 0x0401592A RID: 88362
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x0401592B RID: 88363
		internal static int __PropertyOffset_ColorAndOpacityDelegate;

		// Token: 0x0401592C RID: 88364
		[Nullable(2)]
		private FGetLinearColor _ColorAndOpacityDelegate;

		// Token: 0x0401592D RID: 88365
		internal static int __PropertyOffset_bFlipForRightToLeftFlowDirection;

		// Token: 0x0401592E RID: 88366
		internal static int __PropertyOffset_OnMouseButtonDownEvent;

		// Token: 0x0401592F RID: 88367
		[Nullable(2)]
		private FOnPointerEvent _OnMouseButtonDownEvent;
	}
}
