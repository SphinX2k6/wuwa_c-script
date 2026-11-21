using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000860 RID: 2144
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Image")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class UImage : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BA4E RID: 47694 RVA: 0x0012A78F File Offset: 0x0012898F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImage._ClassPtr;
		}

		// Token: 0x0600BA4F RID: 47695 RVA: 0x0012A79C File Offset: 0x0012899C
		public UImage() : this(BuiltinUtils.AllocNativeUObject(UImage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x0012A7C4 File Offset: 0x001289C4
		public UImage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x0600BA51 RID: 47697 RVA: 0x0012A7F7 File Offset: 0x001289F7
		// (set) Token: 0x0600BA52 RID: 47698 RVA: 0x0012A80B File Offset: 0x00128A0B
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

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x0600BA53 RID: 47699 RVA: 0x0012A820 File Offset: 0x00128A20
		// (set) Token: 0x0600BA54 RID: 47700 RVA: 0x0012A859 File Offset: 0x00128A59
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

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600BA55 RID: 47701 RVA: 0x0012A87A File Offset: 0x00128A7A
		// (set) Token: 0x0600BA56 RID: 47702 RVA: 0x0012A88A File Offset: 0x00128A8A
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

		// Token: 0x0600BA57 RID: 47703 RVA: 0x0012A89B File Offset: 0x00128A9B
		public void SetOpacity(float InOpacity)
		{
			UImage.__SetOpacity_Internal(base.NativePtr, InOpacity);
		}

		// Token: 0x0600BA58 RID: 47704 RVA: 0x0012A8A9 File Offset: 0x00128AA9
		public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
		{
			UImage.__SetColorAndOpacity_Internal(base.NativePtr, InColorAndOpacity);
		}

		// Token: 0x0600BA59 RID: 47705 RVA: 0x0012A8B7 File Offset: 0x00128AB7
		[NullableContext(2)]
		public void SetBrushTintColor(FSlateColor TintColor)
		{
			UImage.__SetBrushTintColor_Internal(base.NativePtr, (TintColor ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x0600BA5A RID: 47706 RVA: 0x0012A8D3 File Offset: 0x00128AD3
		public void SetBrushSize(FVector2D DesiredSize)
		{
			UImage.__SetBrushSize_Internal(base.NativePtr, DesiredSize);
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x0012A8E1 File Offset: 0x00128AE1
		[NullableContext(2)]
		public void SetBrushResourceObject(UObject ResourceObject)
		{
			UImage.__SetBrushResourceObject_Internal(base.NativePtr, (ResourceObject != null) ? ResourceObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA5C RID: 47708 RVA: 0x0012A8FE File Offset: 0x00128AFE
		[NullableContext(2)]
		public void SetBrushFromTexture(UTexture2D Texture, bool bMatchSize = false)
		{
			UImage.__SetBrushFromTexture_Internal(base.NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, bMatchSize);
		}

		// Token: 0x0600BA5D RID: 47709 RVA: 0x0012A91C File Offset: 0x00128B1C
		public void SetBrushFromSoftTexture(TSoftObjectPtr<UTexture2D> SoftTexture, bool bMatchSize = false)
		{
			UImage.__SetBrushFromSoftTexture_Internal(base.NativePtr, (SoftTexture ?? new TSoftObjectPtr<UTexture2D>()).NativePtr, bMatchSize);
		}

		// Token: 0x0600BA5E RID: 47710 RVA: 0x0012A939 File Offset: 0x00128B39
		public void SetBrushFromSoftMaterial(TSoftObjectPtr<UMaterialInterface> SoftMaterial)
		{
			UImage.__SetBrushFromSoftMaterial_Internal(base.NativePtr, (SoftMaterial ?? new TSoftObjectPtr<UMaterialInterface>()).NativePtr);
		}

		// Token: 0x0600BA5F RID: 47711 RVA: 0x0012A955 File Offset: 0x00128B55
		[NullableContext(2)]
		public void SetBrushFromMaterial(UMaterialInterface Material)
		{
			UImage.__SetBrushFromMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA60 RID: 47712 RVA: 0x0012A972 File Offset: 0x00128B72
		[NullableContext(2)]
		public UMaterialInstanceDynamic GetDynamicMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UImage.__GetDynamicMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0600BA61 RID: 47713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOpacity_Internal(IntPtr @this, float InOpacity);

		// Token: 0x0600BA62 RID: 47714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorAndOpacity_Internal(IntPtr @this, FLinearColor InColorAndOpacity);

		// Token: 0x0600BA63 RID: 47715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushTintColor_Internal(IntPtr @this, IntPtr TintColor);

		// Token: 0x0600BA64 RID: 47716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushSize_Internal(IntPtr @this, FVector2D DesiredSize);

		// Token: 0x0600BA65 RID: 47717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushResourceObject_Internal(IntPtr @this, IntPtr ResourceObject);

		// Token: 0x0600BA66 RID: 47718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromTexture_Internal(IntPtr @this, IntPtr Texture, bool bMatchSize);

		// Token: 0x0600BA67 RID: 47719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromSoftTexture_Internal(IntPtr @this, IntPtr SoftTexture, bool bMatchSize);

		// Token: 0x0600BA68 RID: 47720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromSoftMaterial_Internal(IntPtr @this, IntPtr SoftMaterial);

		// Token: 0x0600BA69 RID: 47721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushFromMaterial_Internal(IntPtr @this, IntPtr Material);

		// Token: 0x0600BA6A RID: 47722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicMaterial_Internal(IntPtr @this);

		// Token: 0x0600BA6B RID: 47723 RVA: 0x0012A984 File Offset: 0x00128B84
		static UImage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Image");
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x0012A992 File Offset: 0x00128B92
		protected UImage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400548C RID: 21644
		public new const string __ObjectPath = "/Script/UMG.Image";

		// Token: 0x0400548D RID: 21645
		private static IntPtr _ClassPtr;

		// Token: 0x0400548E RID: 21646
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400548F RID: 21647
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x04005490 RID: 21648
		internal static int __PropertyOffset_ColorAndOpacityDelegate;

		// Token: 0x04005491 RID: 21649
		[Nullable(2)]
		private FGetLinearColor _ColorAndOpacityDelegate;

		// Token: 0x04005492 RID: 21650
		internal static int __PropertyOffset_bFlipForRightToLeftFlowDirection;
	}
}
