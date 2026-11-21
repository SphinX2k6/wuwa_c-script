using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FA RID: 1786
	[UnrealObjectPath("/Script/LGUI.UIEffectShadow")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UUIEffectShadow : UUIGeometryModifierWithRenderableBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009825 RID: 38949 RVA: 0x000E5327 File Offset: 0x000E3527
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectShadow._ClassPtr;
		}

		// Token: 0x06009826 RID: 38950 RVA: 0x000E5334 File Offset: 0x000E3534
		public UUIEffectShadow() : this(BuiltinUtils.AllocNativeUObject(UUIEffectShadow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009827 RID: 38951 RVA: 0x000E535C File Offset: 0x000E355C
		[NullableContext(1)]
		public UUIEffectShadow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectShadow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x000E538F File Offset: 0x000E358F
		// (set) Token: 0x06009829 RID: 38953 RVA: 0x000E53A3 File Offset: 0x000E35A3
		public unsafe FColor shadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectShadow.__PropertyOffset_shadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectShadow.__PropertyOffset_shadowColor) = value;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x0600982A RID: 38954 RVA: 0x000E53B8 File Offset: 0x000E35B8
		// (set) Token: 0x0600982B RID: 38955 RVA: 0x000E53C8 File Offset: 0x000E35C8
		public unsafe bool multiplySourceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectShadow.__PropertyOffset_multiplySourceAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectShadow.__PropertyOffset_multiplySourceAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x0600982C RID: 38956 RVA: 0x000E53D9 File Offset: 0x000E35D9
		// (set) Token: 0x0600982D RID: 38957 RVA: 0x000E53ED File Offset: 0x000E35ED
		public unsafe FVector2D shadowOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectShadow.__PropertyOffset_shadowOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectShadow.__PropertyOffset_shadowOffset) = value;
			}
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x000E5402 File Offset: 0x000E3602
		public void SetShadowOffset(FVector2D newOffset)
		{
			UUIEffectShadow.__SetShadowOffset_Internal(base.NativePtr, newOffset);
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x000E5410 File Offset: 0x000E3610
		public void SetShadowColor(FColor newColor)
		{
			UUIEffectShadow.__SetShadowColor_Internal(base.NativePtr, newColor);
		}

		// Token: 0x06009830 RID: 38960 RVA: 0x000E541E File Offset: 0x000E361E
		public FVector2D GetShadowOffset()
		{
			return UUIEffectShadow.__GetShadowOffset_Internal(base.NativePtr);
		}

		// Token: 0x06009831 RID: 38961 RVA: 0x000E542B File Offset: 0x000E362B
		public FColor GetShadowColor()
		{
			return UUIEffectShadow.__GetShadowColor_Internal(base.NativePtr);
		}

		// Token: 0x06009832 RID: 38962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowOffset_Internal(IntPtr @this, FVector2D newOffset);

		// Token: 0x06009833 RID: 38963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowColor_Internal(IntPtr @this, FColor newColor);

		// Token: 0x06009834 RID: 38964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetShadowOffset_Internal(IntPtr @this);

		// Token: 0x06009835 RID: 38965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetShadowColor_Internal(IntPtr @this);

		// Token: 0x06009836 RID: 38966 RVA: 0x000E5438 File Offset: 0x000E3638
		static UUIEffectShadow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectShadow");
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x000E5446 File Offset: 0x000E3646
		protected UUIEffectShadow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400421C RID: 16924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectShadow";

		// Token: 0x0400421D RID: 16925
		private static IntPtr _ClassPtr;

		// Token: 0x0400421E RID: 16926
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400421F RID: 16927
		internal static int __PropertyOffset_shadowColor;

		// Token: 0x04004220 RID: 16928
		internal static int __PropertyOffset_multiplySourceAlpha;

		// Token: 0x04004221 RID: 16929
		internal static int __PropertyOffset_shadowOffset;
	}
}
