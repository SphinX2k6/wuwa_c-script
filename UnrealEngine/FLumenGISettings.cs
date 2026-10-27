using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BFA RID: 7162
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.LumenGISettings")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FLumenGISettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B9ED RID: 113133 RVA: 0x0028A49C File Offset: 0x0028869C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLumenGISettings._ScriptStructPtr != 0) ? FLumenGISettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.LumenGISettings", ref FLumenGISettings._ScriptStructPtr);
		}

		// Token: 0x17006F52 RID: 28498
		// (get) Token: 0x0601B9EE RID: 113134 RVA: 0x0028A4C0 File Offset: 0x002886C0
		// (set) Token: 0x0601B9EF RID: 113135 RVA: 0x0028A4D9 File Offset: 0x002886D9
		public unsafe bool bOverride_LumenDirectionalLightColorSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalLightColorSaturation) & FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalLightColorSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalLightColorSaturation) = ((*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalLightColorSaturation) & ~FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalLightColorSaturation) | (value ? FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalLightColorSaturation : 0));
			}
		}

		// Token: 0x17006F53 RID: 28499
		// (get) Token: 0x0601B9F0 RID: 113136 RVA: 0x0028A509 File Offset: 0x00288709
		// (set) Token: 0x0601B9F1 RID: 113137 RVA: 0x0028A522 File Offset: 0x00288722
		public unsafe bool bOverride_LumenDirectionalLightColorValueMut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalLightColorValueMut) & FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalLightColorValueMut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalLightColorValueMut) = ((*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalLightColorValueMut) & ~FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalLightColorValueMut) | (value ? FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalLightColorValueMut : 0));
			}
		}

		// Token: 0x17006F54 RID: 28500
		// (get) Token: 0x0601B9F2 RID: 113138 RVA: 0x0028A552 File Offset: 0x00288752
		// (set) Token: 0x0601B9F3 RID: 113139 RVA: 0x0028A56B File Offset: 0x0028876B
		public unsafe bool bOverride_LumenSkyLightColorSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkyLightColorSaturation) & FLumenGISettings.__PropertyMask_bOverride_LumenSkyLightColorSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkyLightColorSaturation) = ((*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkyLightColorSaturation) & ~FLumenGISettings.__PropertyMask_bOverride_LumenSkyLightColorSaturation) | (value ? FLumenGISettings.__PropertyMask_bOverride_LumenSkyLightColorSaturation : 0));
			}
		}

		// Token: 0x17006F55 RID: 28501
		// (get) Token: 0x0601B9F4 RID: 113140 RVA: 0x0028A59B File Offset: 0x0028879B
		// (set) Token: 0x0601B9F5 RID: 113141 RVA: 0x0028A5B4 File Offset: 0x002887B4
		public unsafe bool bOverride_LumenSkyLightColorValueMut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkyLightColorValueMut) & FLumenGISettings.__PropertyMask_bOverride_LumenSkyLightColorValueMut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkyLightColorValueMut) = ((*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkyLightColorValueMut) & ~FLumenGISettings.__PropertyMask_bOverride_LumenSkyLightColorValueMut) | (value ? FLumenGISettings.__PropertyMask_bOverride_LumenSkyLightColorValueMut : 0));
			}
		}

		// Token: 0x17006F56 RID: 28502
		// (get) Token: 0x0601B9F6 RID: 113142 RVA: 0x0028A5E4 File Offset: 0x002887E4
		// (set) Token: 0x0601B9F7 RID: 113143 RVA: 0x0028A5FD File Offset: 0x002887FD
		public unsafe bool bOverride_LumenDirectionalIndirectLightingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalIndirectLightingIntensity) & FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalIndirectLightingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalIndirectLightingIntensity) = ((*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenDirectionalIndirectLightingIntensity) & ~FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalIndirectLightingIntensity) | (value ? FLumenGISettings.__PropertyMask_bOverride_LumenDirectionalIndirectLightingIntensity : 0));
			}
		}

		// Token: 0x17006F57 RID: 28503
		// (get) Token: 0x0601B9F8 RID: 113144 RVA: 0x0028A62D File Offset: 0x0028882D
		// (set) Token: 0x0601B9F9 RID: 113145 RVA: 0x0028A646 File Offset: 0x00288846
		public unsafe bool bOverride_LumenSkylightLeaking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkylightLeaking) & FLumenGISettings.__PropertyMask_bOverride_LumenSkylightLeaking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkylightLeaking) = ((*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_bOverride_LumenSkylightLeaking) & ~FLumenGISettings.__PropertyMask_bOverride_LumenSkylightLeaking) | (value ? FLumenGISettings.__PropertyMask_bOverride_LumenSkylightLeaking : 0));
			}
		}

		// Token: 0x17006F58 RID: 28504
		// (get) Token: 0x0601B9FA RID: 113146 RVA: 0x0028A676 File Offset: 0x00288876
		// (set) Token: 0x0601B9FB RID: 113147 RVA: 0x0028A686 File Offset: 0x00288886
		public unsafe float LumenDirectionalLightColorSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenDirectionalLightColorSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenDirectionalLightColorSaturation) = value;
			}
		}

		// Token: 0x17006F59 RID: 28505
		// (get) Token: 0x0601B9FC RID: 113148 RVA: 0x0028A697 File Offset: 0x00288897
		// (set) Token: 0x0601B9FD RID: 113149 RVA: 0x0028A6A7 File Offset: 0x002888A7
		public unsafe float LumenDirectionalLightColorValueMut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenDirectionalLightColorValueMut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenDirectionalLightColorValueMut) = value;
			}
		}

		// Token: 0x17006F5A RID: 28506
		// (get) Token: 0x0601B9FE RID: 113150 RVA: 0x0028A6B8 File Offset: 0x002888B8
		// (set) Token: 0x0601B9FF RID: 113151 RVA: 0x0028A6C8 File Offset: 0x002888C8
		public unsafe float LumenSkyLightColorSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenSkyLightColorSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenSkyLightColorSaturation) = value;
			}
		}

		// Token: 0x17006F5B RID: 28507
		// (get) Token: 0x0601BA00 RID: 113152 RVA: 0x0028A6D9 File Offset: 0x002888D9
		// (set) Token: 0x0601BA01 RID: 113153 RVA: 0x0028A6E9 File Offset: 0x002888E9
		public unsafe float LumenSkyLightColorValueMut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenSkyLightColorValueMut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenSkyLightColorValueMut) = value;
			}
		}

		// Token: 0x17006F5C RID: 28508
		// (get) Token: 0x0601BA02 RID: 113154 RVA: 0x0028A6FA File Offset: 0x002888FA
		// (set) Token: 0x0601BA03 RID: 113155 RVA: 0x0028A70A File Offset: 0x0028890A
		public unsafe float LumenDirectionalIndirectLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenDirectionalIndirectLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenDirectionalIndirectLightingIntensity) = value;
			}
		}

		// Token: 0x17006F5D RID: 28509
		// (get) Token: 0x0601BA04 RID: 113156 RVA: 0x0028A71B File Offset: 0x0028891B
		// (set) Token: 0x0601BA05 RID: 113157 RVA: 0x0028A72B File Offset: 0x0028892B
		public unsafe float LumenSkylightLeaking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenSkylightLeaking);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLumenGISettings.__PropertyOffset_LumenSkylightLeaking) = value;
			}
		}

		// Token: 0x0601BA06 RID: 113158 RVA: 0x0028A73C File Offset: 0x0028893C
		public FLumenGISettings()
		{
		}

		// Token: 0x0601BA07 RID: 113159 RVA: 0x0028A744 File Offset: 0x00288944
		public FLumenGISettings(bool bOverride_LumenDirectionalLightColorSaturation, bool bOverride_LumenDirectionalLightColorValueMut, bool bOverride_LumenSkyLightColorSaturation, bool bOverride_LumenSkyLightColorValueMut, bool bOverride_LumenDirectionalIndirectLightingIntensity, bool bOverride_LumenSkylightLeaking, float LumenDirectionalLightColorSaturation, float LumenDirectionalLightColorValueMut, float LumenSkyLightColorSaturation, float LumenSkyLightColorValueMut, float LumenDirectionalIndirectLightingIntensity, float LumenSkylightLeaking)
		{
			this.bOverride_LumenDirectionalLightColorSaturation = bOverride_LumenDirectionalLightColorSaturation;
			this.bOverride_LumenDirectionalLightColorValueMut = bOverride_LumenDirectionalLightColorValueMut;
			this.bOverride_LumenSkyLightColorSaturation = bOverride_LumenSkyLightColorSaturation;
			this.bOverride_LumenSkyLightColorValueMut = bOverride_LumenSkyLightColorValueMut;
			this.bOverride_LumenDirectionalIndirectLightingIntensity = bOverride_LumenDirectionalIndirectLightingIntensity;
			this.bOverride_LumenSkylightLeaking = bOverride_LumenSkylightLeaking;
			this.LumenDirectionalLightColorSaturation = LumenDirectionalLightColorSaturation;
			this.LumenDirectionalLightColorValueMut = LumenDirectionalLightColorValueMut;
			this.LumenSkyLightColorSaturation = LumenSkyLightColorSaturation;
			this.LumenSkyLightColorValueMut = LumenSkyLightColorValueMut;
			this.LumenDirectionalIndirectLightingIntensity = LumenDirectionalIndirectLightingIntensity;
			this.LumenSkylightLeaking = LumenSkylightLeaking;
		}

		// Token: 0x0601BA08 RID: 113160 RVA: 0x0028A7B4 File Offset: 0x002889B4
		protected override IntPtr GetUStructPtr()
		{
			return FLumenGISettings.StaticStruct();
		}

		// Token: 0x0601BA09 RID: 113161 RVA: 0x0028A7C0 File Offset: 0x002889C0
		[NullableContext(2)]
		public FLumenGISettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BA0A RID: 113162 RVA: 0x0028A7CA File Offset: 0x002889CA
		public FLumenGISettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BA0B RID: 113163 RVA: 0x0028A7D5 File Offset: 0x002889D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLumenGISettings(Pointer, false, true);
		}

		// Token: 0x0601BA0C RID: 113164 RVA: 0x0028A7DF File Offset: 0x002889DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLumenGISettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED9C RID: 60828
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.LumenGISettings";

		// Token: 0x0400ED9D RID: 60829
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED9E RID: 60830
		internal static int __PropertyOffset_bOverride_LumenDirectionalLightColorSaturation;

		// Token: 0x0400ED9F RID: 60831
		internal static byte __PropertyMask_bOverride_LumenDirectionalLightColorSaturation;

		// Token: 0x0400EDA0 RID: 60832
		internal static int __PropertyOffset_bOverride_LumenDirectionalLightColorValueMut;

		// Token: 0x0400EDA1 RID: 60833
		internal static byte __PropertyMask_bOverride_LumenDirectionalLightColorValueMut;

		// Token: 0x0400EDA2 RID: 60834
		internal static int __PropertyOffset_bOverride_LumenSkyLightColorSaturation;

		// Token: 0x0400EDA3 RID: 60835
		internal static byte __PropertyMask_bOverride_LumenSkyLightColorSaturation;

		// Token: 0x0400EDA4 RID: 60836
		internal static int __PropertyOffset_bOverride_LumenSkyLightColorValueMut;

		// Token: 0x0400EDA5 RID: 60837
		internal static byte __PropertyMask_bOverride_LumenSkyLightColorValueMut;

		// Token: 0x0400EDA6 RID: 60838
		internal static int __PropertyOffset_bOverride_LumenDirectionalIndirectLightingIntensity;

		// Token: 0x0400EDA7 RID: 60839
		internal static byte __PropertyMask_bOverride_LumenDirectionalIndirectLightingIntensity;

		// Token: 0x0400EDA8 RID: 60840
		internal static int __PropertyOffset_bOverride_LumenSkylightLeaking;

		// Token: 0x0400EDA9 RID: 60841
		internal static byte __PropertyMask_bOverride_LumenSkylightLeaking;

		// Token: 0x0400EDAA RID: 60842
		internal static int __PropertyOffset_LumenDirectionalLightColorSaturation;

		// Token: 0x0400EDAB RID: 60843
		internal static int __PropertyOffset_LumenDirectionalLightColorValueMut;

		// Token: 0x0400EDAC RID: 60844
		internal static int __PropertyOffset_LumenSkyLightColorSaturation;

		// Token: 0x0400EDAD RID: 60845
		internal static int __PropertyOffset_LumenSkyLightColorValueMut;

		// Token: 0x0400EDAE RID: 60846
		internal static int __PropertyOffset_LumenDirectionalIndirectLightingIntensity;

		// Token: 0x0400EDAF RID: 60847
		internal static int __PropertyOffset_LumenSkylightLeaking;
	}
}
