using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F9 RID: 1785
	[UnrealObjectPath("/Script/LGUI.UIEffectOutline")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UUIEffectOutline : UUIGeometryModifierWithRenderableBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600980C RID: 38924 RVA: 0x000E51C3 File Offset: 0x000E33C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectOutline._ClassPtr;
		}

		// Token: 0x0600980D RID: 38925 RVA: 0x000E51D0 File Offset: 0x000E33D0
		public UUIEffectOutline() : this(BuiltinUtils.AllocNativeUObject(UUIEffectOutline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600980E RID: 38926 RVA: 0x000E51F8 File Offset: 0x000E33F8
		[NullableContext(1)]
		public UUIEffectOutline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectOutline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x0600980F RID: 38927 RVA: 0x000E522B File Offset: 0x000E342B
		// (set) Token: 0x06009810 RID: 38928 RVA: 0x000E523F File Offset: 0x000E343F
		public unsafe FColor outlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_outlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_outlineColor) = value;
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06009811 RID: 38929 RVA: 0x000E5254 File Offset: 0x000E3454
		// (set) Token: 0x06009812 RID: 38930 RVA: 0x000E5268 File Offset: 0x000E3468
		public unsafe FVector2D outlineSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_outlineSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_outlineSize) = value;
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06009813 RID: 38931 RVA: 0x000E527D File Offset: 0x000E347D
		// (set) Token: 0x06009814 RID: 38932 RVA: 0x000E528D File Offset: 0x000E348D
		public unsafe bool multiplySourceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_multiplySourceAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_multiplySourceAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06009815 RID: 38933 RVA: 0x000E529E File Offset: 0x000E349E
		// (set) Token: 0x06009816 RID: 38934 RVA: 0x000E52AE File Offset: 0x000E34AE
		public unsafe bool use8Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_use8Direction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectOutline.__PropertyOffset_use8Direction) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x000E52BF File Offset: 0x000E34BF
		public void SetUse8Direction(bool newValue)
		{
			UUIEffectOutline.__SetUse8Direction_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x000E52CD File Offset: 0x000E34CD
		public void SetOutlineSize(FVector2D newSize)
		{
			UUIEffectOutline.__SetOutlineSize_Internal(base.NativePtr, newSize);
		}

		// Token: 0x06009819 RID: 38937 RVA: 0x000E52DB File Offset: 0x000E34DB
		public void SetOutlineColor(FColor newColor)
		{
			UUIEffectOutline.__SetOutlineColor_Internal(base.NativePtr, newColor);
		}

		// Token: 0x0600981A RID: 38938 RVA: 0x000E52E9 File Offset: 0x000E34E9
		public bool GetUse8Direction()
		{
			return UUIEffectOutline.__GetUse8Direction_Internal(base.NativePtr);
		}

		// Token: 0x0600981B RID: 38939 RVA: 0x000E52F6 File Offset: 0x000E34F6
		public FVector2D GetOutlineSize()
		{
			return UUIEffectOutline.__GetOutlineSize_Internal(base.NativePtr);
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x000E5303 File Offset: 0x000E3503
		public FColor GetOutlineColor()
		{
			return UUIEffectOutline.__GetOutlineColor_Internal(base.NativePtr);
		}

		// Token: 0x0600981D RID: 38941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUse8Direction_Internal(IntPtr @this, bool newValue);

		// Token: 0x0600981E RID: 38942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutlineSize_Internal(IntPtr @this, FVector2D newSize);

		// Token: 0x0600981F RID: 38943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutlineColor_Internal(IntPtr @this, FColor newColor);

		// Token: 0x06009820 RID: 38944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUse8Direction_Internal(IntPtr @this);

		// Token: 0x06009821 RID: 38945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetOutlineSize_Internal(IntPtr @this);

		// Token: 0x06009822 RID: 38946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetOutlineColor_Internal(IntPtr @this);

		// Token: 0x06009823 RID: 38947 RVA: 0x000E5310 File Offset: 0x000E3510
		static UUIEffectOutline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectOutline");
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x000E531E File Offset: 0x000E351E
		protected UUIEffectOutline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004215 RID: 16917
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectOutline";

		// Token: 0x04004216 RID: 16918
		private static IntPtr _ClassPtr;

		// Token: 0x04004217 RID: 16919
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004218 RID: 16920
		internal static int __PropertyOffset_outlineColor;

		// Token: 0x04004219 RID: 16921
		internal static int __PropertyOffset_outlineSize;

		// Token: 0x0400421A RID: 16922
		internal static int __PropertyOffset_multiplySourceAlpha;

		// Token: 0x0400421B RID: 16923
		internal static int __PropertyOffset_use8Direction;
	}
}
