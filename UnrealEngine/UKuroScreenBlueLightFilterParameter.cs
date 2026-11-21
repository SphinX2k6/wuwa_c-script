using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E1 RID: 1249
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterParameter")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroScreenBlueLightFilterParameter : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075F0 RID: 30192 RVA: 0x000AC5D5 File Offset: 0x000AA7D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenBlueLightFilterParameter._ClassPtr;
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x000AC5E4 File Offset: 0x000AA7E4
		public UKuroScreenBlueLightFilterParameter() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueLightFilterParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x000AC60C File Offset: 0x000AA80C
		[NullableContext(1)]
		public UKuroScreenBlueLightFilterParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueLightFilterParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x060075F3 RID: 30195 RVA: 0x000AC63F File Offset: 0x000AA83F
		// (set) Token: 0x060075F4 RID: 30196 RVA: 0x000AC64F File Offset: 0x000AA84F
		public unsafe float ScreenBlueLightFilterStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterStrength) = value;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x060075F5 RID: 30197 RVA: 0x000AC660 File Offset: 0x000AA860
		// (set) Token: 0x060075F6 RID: 30198 RVA: 0x000AC670 File Offset: 0x000AA870
		public unsafe float ScreenBlueLightFilterTemperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTemperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTemperature) = value;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x060075F7 RID: 30199 RVA: 0x000AC681 File Offset: 0x000AA881
		// (set) Token: 0x060075F8 RID: 30200 RVA: 0x000AC691 File Offset: 0x000AA891
		public unsafe float ScreenBrightnessClampMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampMax) = value;
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x060075F9 RID: 30201 RVA: 0x000AC6A2 File Offset: 0x000AA8A2
		// (set) Token: 0x060075FA RID: 30202 RVA: 0x000AC6B2 File Offset: 0x000AA8B2
		public unsafe float ScreenBrightnessClampSoftness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampSoftness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampSoftness) = value;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x060075FB RID: 30203 RVA: 0x000AC6C3 File Offset: 0x000AA8C3
		// (set) Token: 0x060075FC RID: 30204 RVA: 0x000AC6D3 File Offset: 0x000AA8D3
		public unsafe float ScreenBlueLightFilterTextureIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTextureIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTextureIntensity) = value;
			}
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x000AC6E4 File Offset: 0x000AA8E4
		static UKuroScreenBlueLightFilterParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterParameter");
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x000AC6F2 File Offset: 0x000AA8F2
		protected UKuroScreenBlueLightFilterParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031BC RID: 12732
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterParameter";

		// Token: 0x040031BD RID: 12733
		private static IntPtr _ClassPtr;

		// Token: 0x040031BE RID: 12734
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031BF RID: 12735
		internal static int __PropertyOffset_ScreenBlueLightFilterStrength;

		// Token: 0x040031C0 RID: 12736
		internal static int __PropertyOffset_ScreenBlueLightFilterTemperature;

		// Token: 0x040031C1 RID: 12737
		internal static int __PropertyOffset_ScreenBrightnessClampMax;

		// Token: 0x040031C2 RID: 12738
		internal static int __PropertyOffset_ScreenBrightnessClampSoftness;

		// Token: 0x040031C3 RID: 12739
		internal static int __PropertyOffset_ScreenBlueLightFilterTextureIntensity;
	}
}
