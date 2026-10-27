using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002151 RID: 8529
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_ColorProperty")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UUIEffectTextAnimation_ColorProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602028A RID: 131722 RVA: 0x002FCA94 File Offset: 0x002FAC94
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_ColorProperty._ClassPtr;
		}

		// Token: 0x0602028B RID: 131723 RVA: 0x002FCAA0 File Offset: 0x002FACA0
		public UUIEffectTextAnimation_ColorProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ColorProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602028C RID: 131724 RVA: 0x002FCAC8 File Offset: 0x002FACC8
		[NullableContext(1)]
		public UUIEffectTextAnimation_ColorProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ColorProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E37 RID: 32311
		// (get) Token: 0x0602028D RID: 131725 RVA: 0x002FCAFB File Offset: 0x002FACFB
		// (set) Token: 0x0602028E RID: 131726 RVA: 0x002FCB0F File Offset: 0x002FAD0F
		public unsafe FColor color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorProperty.__PropertyOffset_color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorProperty.__PropertyOffset_color) = value;
			}
		}

		// Token: 0x17007E38 RID: 32312
		// (get) Token: 0x0602028F RID: 131727 RVA: 0x002FCB24 File Offset: 0x002FAD24
		// (set) Token: 0x06020290 RID: 131728 RVA: 0x002FCB34 File Offset: 0x002FAD34
		public unsafe bool useHSV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorProperty.__PropertyOffset_useHSV) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ColorProperty.__PropertyOffset_useHSV) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020291 RID: 131729 RVA: 0x002FCB45 File Offset: 0x002FAD45
		public void SetUseHSV(bool value)
		{
			UUIEffectTextAnimation_ColorProperty.__SetUseHSV_Internal(base.NativePtr, value);
		}

		// Token: 0x06020292 RID: 131730 RVA: 0x002FCB53 File Offset: 0x002FAD53
		public void SetColor(FColor value)
		{
			UUIEffectTextAnimation_ColorProperty.__SetColor_Internal(base.NativePtr, value);
		}

		// Token: 0x06020293 RID: 131731 RVA: 0x002FCB61 File Offset: 0x002FAD61
		public bool GetUseHSV()
		{
			return UUIEffectTextAnimation_ColorProperty.__GetUseHSV_Internal(base.NativePtr);
		}

		// Token: 0x06020294 RID: 131732 RVA: 0x002FCB6E File Offset: 0x002FAD6E
		public FColor GetColor()
		{
			return UUIEffectTextAnimation_ColorProperty.__GetColor_Internal(base.NativePtr);
		}

		// Token: 0x06020295 RID: 131733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseHSV_Internal(IntPtr @this, bool value);

		// Token: 0x06020296 RID: 131734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColor_Internal(IntPtr @this, FColor value);

		// Token: 0x06020297 RID: 131735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUseHSV_Internal(IntPtr @this);

		// Token: 0x06020298 RID: 131736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetColor_Internal(IntPtr @this);

		// Token: 0x06020299 RID: 131737 RVA: 0x002FCB7B File Offset: 0x002FAD7B
		static UUIEffectTextAnimation_ColorProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_ColorProperty");
		}

		// Token: 0x0602029A RID: 131738 RVA: 0x002FCB89 File Offset: 0x002FAD89
		protected UUIEffectTextAnimation_ColorProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114B8 RID: 70840
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_ColorProperty";

		// Token: 0x040114B9 RID: 70841
		private static IntPtr _ClassPtr;

		// Token: 0x040114BA RID: 70842
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114BB RID: 70843
		internal static int __PropertyOffset_color;

		// Token: 0x040114BC RID: 70844
		internal static int __PropertyOffset_useHSV;
	}
}
