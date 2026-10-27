using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002149 RID: 8521
	[UnrealObjectPath("/Script/LGUI.UIEffectGradientColor")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UUIEffectGradientColor : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060201F2 RID: 131570 RVA: 0x002FC0E0 File Offset: 0x002FA2E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectGradientColor._ClassPtr;
		}

		// Token: 0x060201F3 RID: 131571 RVA: 0x002FC0EC File Offset: 0x002FA2EC
		public UUIEffectGradientColor() : this(BuiltinUtils.AllocNativeUObject(UUIEffectGradientColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201F4 RID: 131572 RVA: 0x002FC114 File Offset: 0x002FA314
		[NullableContext(1)]
		public UUIEffectGradientColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectGradientColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E1D RID: 32285
		// (get) Token: 0x060201F5 RID: 131573 RVA: 0x002FC147 File Offset: 0x002FA347
		// (set) Token: 0x060201F6 RID: 131574 RVA: 0x002FC157 File Offset: 0x002FA357
		public unsafe EUIEffectGradientColorDirection directionType
		{
			get
			{
				return (EUIEffectGradientColorDirection)(*(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_directionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_directionType) = (byte)value;
			}
		}

		// Token: 0x17007E1E RID: 32286
		// (get) Token: 0x060201F7 RID: 131575 RVA: 0x002FC168 File Offset: 0x002FA368
		// (set) Token: 0x060201F8 RID: 131576 RVA: 0x002FC178 File Offset: 0x002FA378
		public unsafe bool multiplySourceAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_multiplySourceAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_multiplySourceAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007E1F RID: 32287
		// (get) Token: 0x060201F9 RID: 131577 RVA: 0x002FC189 File Offset: 0x002FA389
		// (set) Token: 0x060201FA RID: 131578 RVA: 0x002FC19D File Offset: 0x002FA39D
		public unsafe FColor color1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color1) = value;
			}
		}

		// Token: 0x17007E20 RID: 32288
		// (get) Token: 0x060201FB RID: 131579 RVA: 0x002FC1B2 File Offset: 0x002FA3B2
		// (set) Token: 0x060201FC RID: 131580 RVA: 0x002FC1C6 File Offset: 0x002FA3C6
		public unsafe FColor color2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color2) = value;
			}
		}

		// Token: 0x17007E21 RID: 32289
		// (get) Token: 0x060201FD RID: 131581 RVA: 0x002FC1DB File Offset: 0x002FA3DB
		// (set) Token: 0x060201FE RID: 131582 RVA: 0x002FC1EF File Offset: 0x002FA3EF
		public unsafe FColor color3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color3) = value;
			}
		}

		// Token: 0x17007E22 RID: 32290
		// (get) Token: 0x060201FF RID: 131583 RVA: 0x002FC204 File Offset: 0x002FA404
		// (set) Token: 0x06020200 RID: 131584 RVA: 0x002FC218 File Offset: 0x002FA418
		public unsafe FColor color4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectGradientColor.__PropertyOffset_color4) = value;
			}
		}

		// Token: 0x06020201 RID: 131585 RVA: 0x002FC22D File Offset: 0x002FA42D
		static UUIEffectGradientColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectGradientColor");
		}

		// Token: 0x06020202 RID: 131586 RVA: 0x002FC23B File Offset: 0x002FA43B
		protected UUIEffectGradientColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011485 RID: 70789
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectGradientColor";

		// Token: 0x04011486 RID: 70790
		private static IntPtr _ClassPtr;

		// Token: 0x04011487 RID: 70791
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011488 RID: 70792
		internal static int __PropertyOffset_directionType;

		// Token: 0x04011489 RID: 70793
		internal static int __PropertyOffset_multiplySourceAlpha;

		// Token: 0x0401148A RID: 70794
		internal static int __PropertyOffset_color1;

		// Token: 0x0401148B RID: 70795
		internal static int __PropertyOffset_color2;

		// Token: 0x0401148C RID: 70796
		internal static int __PropertyOffset_color3;

		// Token: 0x0401148D RID: 70797
		internal static int __PropertyOffset_color4;
	}
}
