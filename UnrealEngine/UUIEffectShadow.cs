using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200214E RID: 8526
	[UnrealObjectPath("/Script/LGUI.UIEffectShadow")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UUIEffectShadow : UUIGeometryModifierWithRenderableBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602024D RID: 131661 RVA: 0x002FC6AA File Offset: 0x002FA8AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectShadow._ClassPtr;
		}

		// Token: 0x0602024E RID: 131662 RVA: 0x002FC6B8 File Offset: 0x002FA8B8
		public UUIEffectShadow() : this(BuiltinUtils.AllocNativeUObject(UUIEffectShadow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602024F RID: 131663 RVA: 0x002FC6E0 File Offset: 0x002FA8E0
		[NullableContext(1)]
		public UUIEffectShadow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectShadow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E2E RID: 32302
		// (get) Token: 0x06020250 RID: 131664 RVA: 0x002FC713 File Offset: 0x002FA913
		// (set) Token: 0x06020251 RID: 131665 RVA: 0x002FC727 File Offset: 0x002FA927
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

		// Token: 0x17007E2F RID: 32303
		// (get) Token: 0x06020252 RID: 131666 RVA: 0x002FC73C File Offset: 0x002FA93C
		// (set) Token: 0x06020253 RID: 131667 RVA: 0x002FC74C File Offset: 0x002FA94C
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

		// Token: 0x17007E30 RID: 32304
		// (get) Token: 0x06020254 RID: 131668 RVA: 0x002FC75D File Offset: 0x002FA95D
		// (set) Token: 0x06020255 RID: 131669 RVA: 0x002FC771 File Offset: 0x002FA971
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

		// Token: 0x06020256 RID: 131670 RVA: 0x002FC786 File Offset: 0x002FA986
		public void SetShadowOffset(FVector2D newOffset)
		{
			UUIEffectShadow.__SetShadowOffset_Internal(base.NativePtr, newOffset);
		}

		// Token: 0x06020257 RID: 131671 RVA: 0x002FC794 File Offset: 0x002FA994
		public void SetShadowColor(FColor newColor)
		{
			UUIEffectShadow.__SetShadowColor_Internal(base.NativePtr, newColor);
		}

		// Token: 0x06020258 RID: 131672 RVA: 0x002FC7A2 File Offset: 0x002FA9A2
		public FVector2D GetShadowOffset()
		{
			return UUIEffectShadow.__GetShadowOffset_Internal(base.NativePtr);
		}

		// Token: 0x06020259 RID: 131673 RVA: 0x002FC7AF File Offset: 0x002FA9AF
		public FColor GetShadowColor()
		{
			return UUIEffectShadow.__GetShadowColor_Internal(base.NativePtr);
		}

		// Token: 0x0602025A RID: 131674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowOffset_Internal(IntPtr @this, FVector2D newOffset);

		// Token: 0x0602025B RID: 131675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowColor_Internal(IntPtr @this, FColor newColor);

		// Token: 0x0602025C RID: 131676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetShadowOffset_Internal(IntPtr @this);

		// Token: 0x0602025D RID: 131677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetShadowColor_Internal(IntPtr @this);

		// Token: 0x0602025E RID: 131678 RVA: 0x002FC7BC File Offset: 0x002FA9BC
		static UUIEffectShadow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectShadow");
		}

		// Token: 0x0602025F RID: 131679 RVA: 0x002FC7CA File Offset: 0x002FA9CA
		protected UUIEffectShadow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114A5 RID: 70821
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectShadow";

		// Token: 0x040114A6 RID: 70822
		private static IntPtr _ClassPtr;

		// Token: 0x040114A7 RID: 70823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114A8 RID: 70824
		internal static int __PropertyOffset_shadowColor;

		// Token: 0x040114A9 RID: 70825
		internal static int __PropertyOffset_multiplySourceAlpha;

		// Token: 0x040114AA RID: 70826
		internal static int __PropertyOffset_shadowOffset;
	}
}
