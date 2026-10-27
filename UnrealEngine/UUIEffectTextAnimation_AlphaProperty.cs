using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002150 RID: 8528
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_AlphaProperty")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UUIEffectTextAnimation_AlphaProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602027B RID: 131707 RVA: 0x002FC996 File Offset: 0x002FAB96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_AlphaProperty._ClassPtr;
		}

		// Token: 0x0602027C RID: 131708 RVA: 0x002FC9A4 File Offset: 0x002FABA4
		public UUIEffectTextAnimation_AlphaProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_AlphaProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602027D RID: 131709 RVA: 0x002FC9CC File Offset: 0x002FABCC
		[NullableContext(1)]
		public UUIEffectTextAnimation_AlphaProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_AlphaProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E34 RID: 32308
		// (get) Token: 0x0602027E RID: 131710 RVA: 0x002FC9FF File Offset: 0x002FABFF
		// (set) Token: 0x0602027F RID: 131711 RVA: 0x002FCA0F File Offset: 0x002FAC0F
		public unsafe float alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_AlphaProperty.__PropertyOffset_alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_AlphaProperty.__PropertyOffset_alpha) = value;
			}
		}

		// Token: 0x17007E35 RID: 32309
		// (get) Token: 0x06020280 RID: 131712 RVA: 0x002FCA20 File Offset: 0x002FAC20
		// (set) Token: 0x06020281 RID: 131713 RVA: 0x002FCA30 File Offset: 0x002FAC30
		public unsafe float initialAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_AlphaProperty.__PropertyOffset_initialAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_AlphaProperty.__PropertyOffset_initialAlpha) = value;
			}
		}

		// Token: 0x17007E36 RID: 32310
		// (get) Token: 0x06020282 RID: 131714 RVA: 0x002FCA41 File Offset: 0x002FAC41
		// (set) Token: 0x06020283 RID: 131715 RVA: 0x002FCA51 File Offset: 0x002FAC51
		public unsafe bool bUseInitialAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_AlphaProperty.__PropertyOffset_bUseInitialAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_AlphaProperty.__PropertyOffset_bUseInitialAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020284 RID: 131716 RVA: 0x002FCA62 File Offset: 0x002FAC62
		public void SetAlpha(float value)
		{
			UUIEffectTextAnimation_AlphaProperty.__SetAlpha_Internal(base.NativePtr, value);
		}

		// Token: 0x06020285 RID: 131717 RVA: 0x002FCA70 File Offset: 0x002FAC70
		public float GetAlpha()
		{
			return UUIEffectTextAnimation_AlphaProperty.__GetAlpha_Internal(base.NativePtr);
		}

		// Token: 0x06020286 RID: 131718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlpha_Internal(IntPtr @this, float value);

		// Token: 0x06020287 RID: 131719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAlpha_Internal(IntPtr @this);

		// Token: 0x06020288 RID: 131720 RVA: 0x002FCA7D File Offset: 0x002FAC7D
		static UUIEffectTextAnimation_AlphaProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_AlphaProperty");
		}

		// Token: 0x06020289 RID: 131721 RVA: 0x002FCA8B File Offset: 0x002FAC8B
		protected UUIEffectTextAnimation_AlphaProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114B2 RID: 70834
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_AlphaProperty";

		// Token: 0x040114B3 RID: 70835
		private static IntPtr _ClassPtr;

		// Token: 0x040114B4 RID: 70836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114B5 RID: 70837
		internal static int __PropertyOffset_alpha;

		// Token: 0x040114B6 RID: 70838
		internal static int __PropertyOffset_initialAlpha;

		// Token: 0x040114B7 RID: 70839
		internal static int __PropertyOffset_bUseInitialAlpha;
	}
}
