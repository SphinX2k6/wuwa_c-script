using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200212A RID: 8490
	[UnrealObjectPath("/Script/LGUI.UIBackgroundPixelate")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public class UUIBackgroundPixelate : UUIPostProcessRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FF11 RID: 130833 RVA: 0x002F815F File Offset: 0x002F635F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIBackgroundPixelate._ClassPtr;
		}

		// Token: 0x0601FF12 RID: 130834 RVA: 0x002F816C File Offset: 0x002F636C
		public UUIBackgroundPixelate() : this(BuiltinUtils.AllocNativeUObject(UUIBackgroundPixelate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FF13 RID: 130835 RVA: 0x002F8194 File Offset: 0x002F6394
		[NullableContext(1)]
		public UUIBackgroundPixelate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIBackgroundPixelate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D8D RID: 32141
		// (get) Token: 0x0601FF14 RID: 130836 RVA: 0x002F81C7 File Offset: 0x002F63C7
		// (set) Token: 0x0601FF15 RID: 130837 RVA: 0x002F81D7 File Offset: 0x002F63D7
		public unsafe float pixelateStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBackgroundPixelate.__PropertyOffset_pixelateStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBackgroundPixelate.__PropertyOffset_pixelateStrength) = value;
			}
		}

		// Token: 0x17007D8E RID: 32142
		// (get) Token: 0x0601FF16 RID: 130838 RVA: 0x002F81E8 File Offset: 0x002F63E8
		// (set) Token: 0x0601FF17 RID: 130839 RVA: 0x002F81F8 File Offset: 0x002F63F8
		public unsafe bool applyAlphaToStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIBackgroundPixelate.__PropertyOffset_applyAlphaToStrength) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIBackgroundPixelate.__PropertyOffset_applyAlphaToStrength) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FF18 RID: 130840 RVA: 0x002F8209 File Offset: 0x002F6409
		public void SetPixelateStrength(float newValue)
		{
			UUIBackgroundPixelate.__SetPixelateStrength_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FF19 RID: 130841 RVA: 0x002F8217 File Offset: 0x002F6417
		public void SetApplyAlphaToStrength(bool newValue)
		{
			UUIBackgroundPixelate.__SetApplyAlphaToStrength_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601FF1A RID: 130842 RVA: 0x002F8225 File Offset: 0x002F6425
		public float GetPixelateStrength()
		{
			return UUIBackgroundPixelate.__GetPixelateStrength_Internal(base.NativePtr);
		}

		// Token: 0x0601FF1B RID: 130843 RVA: 0x002F8232 File Offset: 0x002F6432
		public bool GetApplyAlphaToStrength()
		{
			return UUIBackgroundPixelate.__GetApplyAlphaToStrength_Internal(base.NativePtr);
		}

		// Token: 0x0601FF1C RID: 130844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPixelateStrength_Internal(IntPtr @this, float newValue);

		// Token: 0x0601FF1D RID: 130845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetApplyAlphaToStrength_Internal(IntPtr @this, bool newValue);

		// Token: 0x0601FF1E RID: 130846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPixelateStrength_Internal(IntPtr @this);

		// Token: 0x0601FF1F RID: 130847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetApplyAlphaToStrength_Internal(IntPtr @this);

		// Token: 0x0601FF20 RID: 130848 RVA: 0x002F823F File Offset: 0x002F643F
		static UUIBackgroundPixelate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBackgroundPixelate");
		}

		// Token: 0x0601FF21 RID: 130849 RVA: 0x002F824D File Offset: 0x002F644D
		protected UUIBackgroundPixelate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011349 RID: 70473
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBackgroundPixelate";

		// Token: 0x0401134A RID: 70474
		private static IntPtr _ClassPtr;

		// Token: 0x0401134B RID: 70475
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401134C RID: 70476
		internal static int __PropertyOffset_pixelateStrength;

		// Token: 0x0401134D RID: 70477
		internal static int __PropertyOffset_applyAlphaToStrength;
	}
}
