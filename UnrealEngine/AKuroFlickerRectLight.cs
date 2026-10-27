using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AF8 RID: 6904
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerRectLight")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class AKuroFlickerRectLight : AKuroFlickerLightBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019CBE RID: 105662 RVA: 0x002619DB File Offset: 0x0025FBDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFlickerRectLight._ClassPtr;
		}

		// Token: 0x06019CBF RID: 105663 RVA: 0x002619E8 File Offset: 0x0025FBE8
		public AKuroFlickerRectLight() : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerRectLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CC0 RID: 105664 RVA: 0x00261A10 File Offset: 0x0025FC10
		[NullableContext(1)]
		public AKuroFlickerRectLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerRectLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006738 RID: 26424
		// (get) Token: 0x06019CC1 RID: 105665 RVA: 0x00261A43 File Offset: 0x0025FC43
		// (set) Token: 0x06019CC2 RID: 105666 RVA: 0x00261A53 File Offset: 0x0025FC53
		public unsafe float SourceWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerRectLight.__PropertyOffset_SourceWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerRectLight.__PropertyOffset_SourceWidth) = value;
			}
		}

		// Token: 0x17006739 RID: 26425
		// (get) Token: 0x06019CC3 RID: 105667 RVA: 0x00261A64 File Offset: 0x0025FC64
		// (set) Token: 0x06019CC4 RID: 105668 RVA: 0x00261A74 File Offset: 0x0025FC74
		public unsafe float SourceHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerRectLight.__PropertyOffset_SourceHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerRectLight.__PropertyOffset_SourceHeight) = value;
			}
		}

		// Token: 0x1700673A RID: 26426
		// (get) Token: 0x06019CC5 RID: 105669 RVA: 0x00261A85 File Offset: 0x0025FC85
		// (set) Token: 0x06019CC6 RID: 105670 RVA: 0x00261A95 File Offset: 0x0025FC95
		public unsafe bool bSourceTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerRectLight.__PropertyOffset_bSourceTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerRectLight.__PropertyOffset_bSourceTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700673B RID: 26427
		// (get) Token: 0x06019CC7 RID: 105671 RVA: 0x00261AA6 File Offset: 0x0025FCA6
		// (set) Token: 0x06019CC8 RID: 105672 RVA: 0x00261ABA File Offset: 0x0025FCBA
		[Nullable(2)]
		public unsafe URectLightComponent RectLight
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URectLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerRectLight.__PropertyOffset_RectLight);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerRectLight.__PropertyOffset_RectLight, value);
			}
		}

		// Token: 0x06019CC9 RID: 105673 RVA: 0x00261ACF File Offset: 0x0025FCCF
		static AKuroFlickerRectLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerRectLight");
		}

		// Token: 0x06019CCA RID: 105674 RVA: 0x00261ADD File Offset: 0x0025FCDD
		protected AKuroFlickerRectLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E077 RID: 57463
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerRectLight";

		// Token: 0x0400E078 RID: 57464
		private static IntPtr _ClassPtr;

		// Token: 0x0400E079 RID: 57465
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E07A RID: 57466
		internal static int __PropertyOffset_SourceWidth;

		// Token: 0x0400E07B RID: 57467
		internal static int __PropertyOffset_SourceHeight;

		// Token: 0x0400E07C RID: 57468
		internal static int __PropertyOffset_bSourceTexture;

		// Token: 0x0400E07D RID: 57469
		internal static int __PropertyOffset_RectLight;
	}
}
