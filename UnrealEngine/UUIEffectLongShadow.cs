using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200214A RID: 8522
	[UnrealObjectPath("/Script/LGUI.UIEffectLongShadow")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUIEffectLongShadow : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020203 RID: 131587 RVA: 0x002FC244 File Offset: 0x002FA444
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectLongShadow._ClassPtr;
		}

		// Token: 0x06020204 RID: 131588 RVA: 0x002FC250 File Offset: 0x002FA450
		public UUIEffectLongShadow() : this(BuiltinUtils.AllocNativeUObject(UUIEffectLongShadow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020205 RID: 131589 RVA: 0x002FC278 File Offset: 0x002FA478
		[NullableContext(1)]
		public UUIEffectLongShadow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectLongShadow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E23 RID: 32291
		// (get) Token: 0x06020206 RID: 131590 RVA: 0x002FC2AB File Offset: 0x002FA4AB
		// (set) Token: 0x06020207 RID: 131591 RVA: 0x002FC2BF File Offset: 0x002FA4BF
		public unsafe FColor shadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_shadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_shadowColor) = value;
			}
		}

		// Token: 0x17007E24 RID: 32292
		// (get) Token: 0x06020208 RID: 131592 RVA: 0x002FC2D4 File Offset: 0x002FA4D4
		// (set) Token: 0x06020209 RID: 131593 RVA: 0x002FC2E8 File Offset: 0x002FA4E8
		public unsafe FVector shadowSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_shadowSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_shadowSize) = value;
			}
		}

		// Token: 0x17007E25 RID: 32293
		// (get) Token: 0x0602020A RID: 131594 RVA: 0x002FC2FD File Offset: 0x002FA4FD
		// (set) Token: 0x0602020B RID: 131595 RVA: 0x002FC30D File Offset: 0x002FA50D
		public unsafe byte shadowSegment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_shadowSegment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_shadowSegment) = value;
			}
		}

		// Token: 0x17007E26 RID: 32294
		// (get) Token: 0x0602020C RID: 131596 RVA: 0x002FC31E File Offset: 0x002FA51E
		// (set) Token: 0x0602020D RID: 131597 RVA: 0x002FC32E File Offset: 0x002FA52E
		public unsafe bool useGradientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_useGradientColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_useGradientColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007E27 RID: 32295
		// (get) Token: 0x0602020E RID: 131598 RVA: 0x002FC33F File Offset: 0x002FA53F
		// (set) Token: 0x0602020F RID: 131599 RVA: 0x002FC353 File Offset: 0x002FA553
		public unsafe FColor gradientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_gradientColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_gradientColor) = value;
			}
		}

		// Token: 0x17007E28 RID: 32296
		// (get) Token: 0x06020210 RID: 131600 RVA: 0x002FC368 File Offset: 0x002FA568
		// (set) Token: 0x06020211 RID: 131601 RVA: 0x002FC378 File Offset: 0x002FA578
		public unsafe bool multiplySourceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_multiplySourceAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectLongShadow.__PropertyOffset_multiplySourceAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020212 RID: 131602 RVA: 0x002FC389 File Offset: 0x002FA589
		public void SetUseGradientColor(bool newBool)
		{
			UUIEffectLongShadow.__SetUseGradientColor_Internal(base.NativePtr, newBool);
		}

		// Token: 0x06020213 RID: 131603 RVA: 0x002FC397 File Offset: 0x002FA597
		public void SetShadowSize(FVector newSize)
		{
			UUIEffectLongShadow.__SetShadowSize_Internal(base.NativePtr, newSize);
		}

		// Token: 0x06020214 RID: 131604 RVA: 0x002FC3A5 File Offset: 0x002FA5A5
		public void SetShadowSegment(byte newSegment)
		{
			UUIEffectLongShadow.__SetShadowSegment_Internal(base.NativePtr, newSegment);
		}

		// Token: 0x06020215 RID: 131605 RVA: 0x002FC3B3 File Offset: 0x002FA5B3
		public void SetShadowColor(FColor newColor)
		{
			UUIEffectLongShadow.__SetShadowColor_Internal(base.NativePtr, newColor);
		}

		// Token: 0x06020216 RID: 131606 RVA: 0x002FC3C1 File Offset: 0x002FA5C1
		public void SetGradientColor(FColor newColor)
		{
			UUIEffectLongShadow.__SetGradientColor_Internal(base.NativePtr, newColor);
		}

		// Token: 0x06020217 RID: 131607 RVA: 0x002FC3CF File Offset: 0x002FA5CF
		public bool GetUseGradientColor()
		{
			return UUIEffectLongShadow.__GetUseGradientColor_Internal(base.NativePtr);
		}

		// Token: 0x06020218 RID: 131608 RVA: 0x002FC3DC File Offset: 0x002FA5DC
		public FVector GetShadowSize()
		{
			return UUIEffectLongShadow.__GetShadowSize_Internal(base.NativePtr);
		}

		// Token: 0x06020219 RID: 131609 RVA: 0x002FC3E9 File Offset: 0x002FA5E9
		public byte GetShadowSegments()
		{
			return UUIEffectLongShadow.__GetShadowSegments_Internal(base.NativePtr);
		}

		// Token: 0x0602021A RID: 131610 RVA: 0x002FC3F6 File Offset: 0x002FA5F6
		public FColor GetShadowColor()
		{
			return UUIEffectLongShadow.__GetShadowColor_Internal(base.NativePtr);
		}

		// Token: 0x0602021B RID: 131611 RVA: 0x002FC403 File Offset: 0x002FA603
		public FColor GetGradientColor()
		{
			return UUIEffectLongShadow.__GetGradientColor_Internal(base.NativePtr);
		}

		// Token: 0x0602021C RID: 131612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseGradientColor_Internal(IntPtr @this, bool newBool);

		// Token: 0x0602021D RID: 131613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowSize_Internal(IntPtr @this, FVector newSize);

		// Token: 0x0602021E RID: 131614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowSegment_Internal(IntPtr @this, byte newSegment);

		// Token: 0x0602021F RID: 131615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowColor_Internal(IntPtr @this, FColor newColor);

		// Token: 0x06020220 RID: 131616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGradientColor_Internal(IntPtr @this, FColor newColor);

		// Token: 0x06020221 RID: 131617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUseGradientColor_Internal(IntPtr @this);

		// Token: 0x06020222 RID: 131618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetShadowSize_Internal(IntPtr @this);

		// Token: 0x06020223 RID: 131619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetShadowSegments_Internal(IntPtr @this);

		// Token: 0x06020224 RID: 131620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetShadowColor_Internal(IntPtr @this);

		// Token: 0x06020225 RID: 131621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetGradientColor_Internal(IntPtr @this);

		// Token: 0x06020226 RID: 131622 RVA: 0x002FC410 File Offset: 0x002FA610
		static UUIEffectLongShadow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectLongShadow");
		}

		// Token: 0x06020227 RID: 131623 RVA: 0x002FC41E File Offset: 0x002FA61E
		protected UUIEffectLongShadow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401148E RID: 70798
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectLongShadow";

		// Token: 0x0401148F RID: 70799
		private static IntPtr _ClassPtr;

		// Token: 0x04011490 RID: 70800
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011491 RID: 70801
		internal static int __PropertyOffset_shadowColor;

		// Token: 0x04011492 RID: 70802
		internal static int __PropertyOffset_shadowSize;

		// Token: 0x04011493 RID: 70803
		internal static int __PropertyOffset_shadowSegment;

		// Token: 0x04011494 RID: 70804
		internal static int __PropertyOffset_useGradientColor;

		// Token: 0x04011495 RID: 70805
		internal static int __PropertyOffset_gradientColor;

		// Token: 0x04011496 RID: 70806
		internal static int __PropertyOffset_multiplySourceAlpha;
	}
}
