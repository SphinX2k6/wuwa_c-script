using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200214B RID: 8523
	[UnrealObjectPath("/Script/LGUI.UIEffectOutline")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UUIEffectOutline : UUIGeometryModifierWithRenderableBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020228 RID: 131624 RVA: 0x002FC427 File Offset: 0x002FA627
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectOutline._ClassPtr;
		}

		// Token: 0x06020229 RID: 131625 RVA: 0x002FC434 File Offset: 0x002FA634
		public UUIEffectOutline() : this(BuiltinUtils.AllocNativeUObject(UUIEffectOutline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602022A RID: 131626 RVA: 0x002FC45C File Offset: 0x002FA65C
		[NullableContext(1)]
		public UUIEffectOutline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectOutline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E29 RID: 32297
		// (get) Token: 0x0602022B RID: 131627 RVA: 0x002FC48F File Offset: 0x002FA68F
		// (set) Token: 0x0602022C RID: 131628 RVA: 0x002FC4A3 File Offset: 0x002FA6A3
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

		// Token: 0x17007E2A RID: 32298
		// (get) Token: 0x0602022D RID: 131629 RVA: 0x002FC4B8 File Offset: 0x002FA6B8
		// (set) Token: 0x0602022E RID: 131630 RVA: 0x002FC4CC File Offset: 0x002FA6CC
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

		// Token: 0x17007E2B RID: 32299
		// (get) Token: 0x0602022F RID: 131631 RVA: 0x002FC4E1 File Offset: 0x002FA6E1
		// (set) Token: 0x06020230 RID: 131632 RVA: 0x002FC4F1 File Offset: 0x002FA6F1
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

		// Token: 0x17007E2C RID: 32300
		// (get) Token: 0x06020231 RID: 131633 RVA: 0x002FC502 File Offset: 0x002FA702
		// (set) Token: 0x06020232 RID: 131634 RVA: 0x002FC512 File Offset: 0x002FA712
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

		// Token: 0x06020233 RID: 131635 RVA: 0x002FC523 File Offset: 0x002FA723
		public void SetUse8Direction(bool newValue)
		{
			UUIEffectOutline.__SetUse8Direction_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020234 RID: 131636 RVA: 0x002FC531 File Offset: 0x002FA731
		public void SetOutlineSize(FVector2D newSize)
		{
			UUIEffectOutline.__SetOutlineSize_Internal(base.NativePtr, newSize);
		}

		// Token: 0x06020235 RID: 131637 RVA: 0x002FC53F File Offset: 0x002FA73F
		public void SetOutlineColor(FColor newColor)
		{
			UUIEffectOutline.__SetOutlineColor_Internal(base.NativePtr, newColor);
		}

		// Token: 0x06020236 RID: 131638 RVA: 0x002FC54D File Offset: 0x002FA74D
		public bool GetUse8Direction()
		{
			return UUIEffectOutline.__GetUse8Direction_Internal(base.NativePtr);
		}

		// Token: 0x06020237 RID: 131639 RVA: 0x002FC55A File Offset: 0x002FA75A
		public FVector2D GetOutlineSize()
		{
			return UUIEffectOutline.__GetOutlineSize_Internal(base.NativePtr);
		}

		// Token: 0x06020238 RID: 131640 RVA: 0x002FC567 File Offset: 0x002FA767
		public FColor GetOutlineColor()
		{
			return UUIEffectOutline.__GetOutlineColor_Internal(base.NativePtr);
		}

		// Token: 0x06020239 RID: 131641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUse8Direction_Internal(IntPtr @this, bool newValue);

		// Token: 0x0602023A RID: 131642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutlineSize_Internal(IntPtr @this, FVector2D newSize);

		// Token: 0x0602023B RID: 131643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOutlineColor_Internal(IntPtr @this, FColor newColor);

		// Token: 0x0602023C RID: 131644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUse8Direction_Internal(IntPtr @this);

		// Token: 0x0602023D RID: 131645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetOutlineSize_Internal(IntPtr @this);

		// Token: 0x0602023E RID: 131646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetOutlineColor_Internal(IntPtr @this);

		// Token: 0x0602023F RID: 131647 RVA: 0x002FC574 File Offset: 0x002FA774
		static UUIEffectOutline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectOutline");
		}

		// Token: 0x06020240 RID: 131648 RVA: 0x002FC582 File Offset: 0x002FA782
		protected UUIEffectOutline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011497 RID: 70807
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectOutline";

		// Token: 0x04011498 RID: 70808
		private static IntPtr _ClassPtr;

		// Token: 0x04011499 RID: 70809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401149A RID: 70810
		internal static int __PropertyOffset_outlineColor;

		// Token: 0x0401149B RID: 70811
		internal static int __PropertyOffset_outlineSize;

		// Token: 0x0401149C RID: 70812
		internal static int __PropertyOffset_multiplySourceAlpha;

		// Token: 0x0401149D RID: 70813
		internal static int __PropertyOffset_use8Direction;
	}
}
