using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002128 RID: 8488
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIBackgroundBlur")]
	[UnrealStructLayout(1808, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class UUIBackgroundBlur : UUIPostProcessRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FEED RID: 130797 RVA: 0x002F7F2A File Offset: 0x002F612A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIBackgroundBlur._ClassPtr;
		}

		// Token: 0x0601FEEE RID: 130798 RVA: 0x002F7F38 File Offset: 0x002F6138
		public UUIBackgroundBlur() : this(BuiltinUtils.AllocNativeUObject(UUIBackgroundBlur.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FEEF RID: 130799 RVA: 0x002F7F60 File Offset: 0x002F6160
		[NullableContext(1)]
		public UUIBackgroundBlur(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIBackgroundBlur.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D88 RID: 32136
		// (get) Token: 0x0601FEF0 RID: 130800 RVA: 0x002F7F93 File Offset: 0x002F6193
		// (set) Token: 0x0601FEF1 RID: 130801 RVA: 0x002F7FA3 File Offset: 0x002F61A3
		public unsafe float blurStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBackgroundBlur.__PropertyOffset_blurStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBackgroundBlur.__PropertyOffset_blurStrength) = value;
			}
		}

		// Token: 0x17007D89 RID: 32137
		// (get) Token: 0x0601FEF2 RID: 130802 RVA: 0x002F7FB4 File Offset: 0x002F61B4
		// (set) Token: 0x0601FEF3 RID: 130803 RVA: 0x002F7FC4 File Offset: 0x002F61C4
		public unsafe bool applyAlphaToBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBackgroundBlur.__PropertyOffset_applyAlphaToBlur) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBackgroundBlur.__PropertyOffset_applyAlphaToBlur) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D8A RID: 32138
		// (get) Token: 0x0601FEF4 RID: 130804 RVA: 0x002F7FD5 File Offset: 0x002F61D5
		// (set) Token: 0x0601FEF5 RID: 130805 RVA: 0x002F7FE5 File Offset: 0x002F61E5
		public unsafe int maxDownSampleLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBackgroundBlur.__PropertyOffset_maxDownSampleLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBackgroundBlur.__PropertyOffset_maxDownSampleLevel) = value;
			}
		}

		// Token: 0x17007D8B RID: 32139
		// (get) Token: 0x0601FEF6 RID: 130806 RVA: 0x002F7FF6 File Offset: 0x002F61F6
		// (set) Token: 0x0601FEF7 RID: 130807 RVA: 0x002F800A File Offset: 0x002F620A
		public unsafe UTexture2D strengthTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UUIBackgroundBlur.__PropertyOffset_strengthTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIBackgroundBlur.__PropertyOffset_strengthTexture, value);
			}
		}

		// Token: 0x0601FEF8 RID: 130808 RVA: 0x002F801F File Offset: 0x002F621F
		public void SetStrengthTexture(UTexture2D newValue)
		{
			UUIBackgroundBlur.__SetStrengthTexture_Internal(base.NativePtr, (newValue != null) ? newValue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FEF9 RID: 130809 RVA: 0x002F803C File Offset: 0x002F623C
		public void SetMaxDownSampleLevel(int newValue)
		{
			UUIBackgroundBlur.__SetMaxDownSampleLevel_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FEFA RID: 130810 RVA: 0x002F804A File Offset: 0x002F624A
		public void SetBlurStrength(float newValue)
		{
			UUIBackgroundBlur.__SetBlurStrength_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FEFB RID: 130811 RVA: 0x002F8058 File Offset: 0x002F6258
		public void SetApplyAlphaToBlur(bool newValue)
		{
			UUIBackgroundBlur.__SetApplyAlphaToBlur_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FEFC RID: 130812 RVA: 0x002F8066 File Offset: 0x002F6266
		public UTexture2D GetStrengthTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UUIBackgroundBlur.__GetStrengthTexture_Internal(base.NativePtr));
		}

		// Token: 0x0601FEFD RID: 130813 RVA: 0x002F8078 File Offset: 0x002F6278
		public int GetMaxDownSampleLevel()
		{
			return UUIBackgroundBlur.__GetMaxDownSampleLevel_Internal(base.NativePtr);
		}

		// Token: 0x0601FEFE RID: 130814 RVA: 0x002F8085 File Offset: 0x002F6285
		public float GetBlurStrength()
		{
			return UUIBackgroundBlur.__GetBlurStrength_Internal(base.NativePtr);
		}

		// Token: 0x0601FEFF RID: 130815 RVA: 0x002F8092 File Offset: 0x002F6292
		public bool GetApplyAlphaToBlur()
		{
			return UUIBackgroundBlur.__GetApplyAlphaToBlur_Internal(base.NativePtr);
		}

		// Token: 0x0601FF00 RID: 130816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStrengthTexture_Internal(IntPtr @this, IntPtr newValue);

		// Token: 0x0601FF01 RID: 130817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxDownSampleLevel_Internal(IntPtr @this, int newValue);

		// Token: 0x0601FF02 RID: 130818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlurStrength_Internal(IntPtr @this, float newValue);

		// Token: 0x0601FF03 RID: 130819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetApplyAlphaToBlur_Internal(IntPtr @this, bool newValue);

		// Token: 0x0601FF04 RID: 130820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStrengthTexture_Internal(IntPtr @this);

		// Token: 0x0601FF05 RID: 130821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxDownSampleLevel_Internal(IntPtr @this);

		// Token: 0x0601FF06 RID: 130822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBlurStrength_Internal(IntPtr @this);

		// Token: 0x0601FF07 RID: 130823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetApplyAlphaToBlur_Internal(IntPtr @this);

		// Token: 0x0601FF08 RID: 130824 RVA: 0x002F809F File Offset: 0x002F629F
		static UUIBackgroundBlur()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBackgroundBlur");
		}

		// Token: 0x0601FF09 RID: 130825 RVA: 0x002F80AD File Offset: 0x002F62AD
		protected UUIBackgroundBlur(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401133E RID: 70462
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBackgroundBlur";

		// Token: 0x0401133F RID: 70463
		private static IntPtr _ClassPtr;

		// Token: 0x04011340 RID: 70464
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011341 RID: 70465
		internal static int __PropertyOffset_blurStrength;

		// Token: 0x04011342 RID: 70466
		internal static int __PropertyOffset_applyAlphaToBlur;

		// Token: 0x04011343 RID: 70467
		internal static int __PropertyOffset_maxDownSampleLevel;

		// Token: 0x04011344 RID: 70468
		internal static int __PropertyOffset_strengthTexture;
	}
}
