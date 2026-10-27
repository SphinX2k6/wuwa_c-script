using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A56 RID: 6742
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CascadeLightingVolumeSettings")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FCascadeLightingVolumeSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018EC9 RID: 102089 RVA: 0x0024D6E8 File Offset: 0x0024B8E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCascadeLightingVolumeSettings._ScriptStructPtr != 0) ? FCascadeLightingVolumeSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CascadeLightingVolumeSettings", ref FCascadeLightingVolumeSettings._ScriptStructPtr);
		}

		// Token: 0x170062AE RID: 25262
		// (get) Token: 0x06018ECA RID: 102090 RVA: 0x0024D70C File Offset: 0x0024B90C
		// (set) Token: 0x06018ECB RID: 102091 RVA: 0x0024D725 File Offset: 0x0024B925
		public unsafe bool bOverride_ClvFadePercent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvFadePercent) & FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvFadePercent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvFadePercent) = ((*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvFadePercent) & ~FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvFadePercent) | (value ? FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvFadePercent : 0));
			}
		}

		// Token: 0x170062AF RID: 25263
		// (get) Token: 0x06018ECC RID: 102092 RVA: 0x0024D755 File Offset: 0x0024B955
		// (set) Token: 0x06018ECD RID: 102093 RVA: 0x0024D76E File Offset: 0x0024B96E
		public unsafe bool bOverride_ClvSkyLightLeakScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvSkyLightLeakScale) & FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvSkyLightLeakScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvSkyLightLeakScale) = ((*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvSkyLightLeakScale) & ~FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvSkyLightLeakScale) | (value ? FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvSkyLightLeakScale : 0));
			}
		}

		// Token: 0x170062B0 RID: 25264
		// (get) Token: 0x06018ECE RID: 102094 RVA: 0x0024D79E File Offset: 0x0024B99E
		// (set) Token: 0x06018ECF RID: 102095 RVA: 0x0024D7B7 File Offset: 0x0024B9B7
		public unsafe bool bOverride_ClvPrtSkyLightIntensityScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtSkyLightIntensityScale) & FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtSkyLightIntensityScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtSkyLightIntensityScale) = ((*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtSkyLightIntensityScale) & ~FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtSkyLightIntensityScale) | (value ? FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtSkyLightIntensityScale : 0));
			}
		}

		// Token: 0x170062B1 RID: 25265
		// (get) Token: 0x06018ED0 RID: 102096 RVA: 0x0024D7E7 File Offset: 0x0024B9E7
		// (set) Token: 0x06018ED1 RID: 102097 RVA: 0x0024D800 File Offset: 0x0024BA00
		public unsafe bool bOverride_ClvPrtDirectionalLightIntensityScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityScale) & FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtDirectionalLightIntensityScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityScale) = ((*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityScale) & ~FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtDirectionalLightIntensityScale) | (value ? FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtDirectionalLightIntensityScale : 0));
			}
		}

		// Token: 0x170062B2 RID: 25266
		// (get) Token: 0x06018ED2 RID: 102098 RVA: 0x0024D830 File Offset: 0x0024BA30
		// (set) Token: 0x06018ED3 RID: 102099 RVA: 0x0024D849 File Offset: 0x0024BA49
		public unsafe bool bOverride_ClvPrtDirectionalLightIntensityMultiplier
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityMultiplier) & FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtDirectionalLightIntensityMultiplier) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityMultiplier) = ((*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityMultiplier) & ~FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtDirectionalLightIntensityMultiplier) | (value ? FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvPrtDirectionalLightIntensityMultiplier : 0));
			}
		}

		// Token: 0x170062B3 RID: 25267
		// (get) Token: 0x06018ED4 RID: 102100 RVA: 0x0024D879 File Offset: 0x0024BA79
		// (set) Token: 0x06018ED5 RID: 102101 RVA: 0x0024D892 File Offset: 0x0024BA92
		public unsafe bool bOverride_ClvIndirectLightingColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvIndirectLightingColor) & FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvIndirectLightingColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvIndirectLightingColor) = ((*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvIndirectLightingColor) & ~FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvIndirectLightingColor) | (value ? FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvIndirectLightingColor : 0));
			}
		}

		// Token: 0x170062B4 RID: 25268
		// (get) Token: 0x06018ED6 RID: 102102 RVA: 0x0024D8C2 File Offset: 0x0024BAC2
		// (set) Token: 0x06018ED7 RID: 102103 RVA: 0x0024D8DB File Offset: 0x0024BADB
		public unsafe bool bOverride_ClvIndirectLightingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvIndirectLightingIntensity) & FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvIndirectLightingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvIndirectLightingIntensity) = ((*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_bOverride_ClvIndirectLightingIntensity) & ~FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvIndirectLightingIntensity) | (value ? FCascadeLightingVolumeSettings.__PropertyMask_bOverride_ClvIndirectLightingIntensity : 0));
			}
		}

		// Token: 0x170062B5 RID: 25269
		// (get) Token: 0x06018ED8 RID: 102104 RVA: 0x0024D90B File Offset: 0x0024BB0B
		// (set) Token: 0x06018ED9 RID: 102105 RVA: 0x0024D91B File Offset: 0x0024BB1B
		public unsafe float ClvFadePercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvFadePercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvFadePercent) = value;
			}
		}

		// Token: 0x170062B6 RID: 25270
		// (get) Token: 0x06018EDA RID: 102106 RVA: 0x0024D92C File Offset: 0x0024BB2C
		// (set) Token: 0x06018EDB RID: 102107 RVA: 0x0024D93C File Offset: 0x0024BB3C
		public unsafe float ClvSkyLightLeakScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvSkyLightLeakScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvSkyLightLeakScale) = value;
			}
		}

		// Token: 0x170062B7 RID: 25271
		// (get) Token: 0x06018EDC RID: 102108 RVA: 0x0024D94D File Offset: 0x0024BB4D
		// (set) Token: 0x06018EDD RID: 102109 RVA: 0x0024D95D File Offset: 0x0024BB5D
		public unsafe float ClvPrtSkyLightIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvPrtSkyLightIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvPrtSkyLightIntensityScale) = value;
			}
		}

		// Token: 0x170062B8 RID: 25272
		// (get) Token: 0x06018EDE RID: 102110 RVA: 0x0024D96E File Offset: 0x0024BB6E
		// (set) Token: 0x06018EDF RID: 102111 RVA: 0x0024D97E File Offset: 0x0024BB7E
		public unsafe float ClvPrtDirectionalLightIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvPrtDirectionalLightIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvPrtDirectionalLightIntensityScale) = value;
			}
		}

		// Token: 0x170062B9 RID: 25273
		// (get) Token: 0x06018EE0 RID: 102112 RVA: 0x0024D98F File Offset: 0x0024BB8F
		// (set) Token: 0x06018EE1 RID: 102113 RVA: 0x0024D99F File Offset: 0x0024BB9F
		public unsafe float ClvPrtDirectionalLightIntensityMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvPrtDirectionalLightIntensityMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvPrtDirectionalLightIntensityMultiplier) = value;
			}
		}

		// Token: 0x170062BA RID: 25274
		// (get) Token: 0x06018EE2 RID: 102114 RVA: 0x0024D9B0 File Offset: 0x0024BBB0
		// (set) Token: 0x06018EE3 RID: 102115 RVA: 0x0024D9C4 File Offset: 0x0024BBC4
		public unsafe FLinearColor ClvIndirectLightingColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvIndirectLightingColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvIndirectLightingColor) = value;
			}
		}

		// Token: 0x170062BB RID: 25275
		// (get) Token: 0x06018EE4 RID: 102116 RVA: 0x0024D9D9 File Offset: 0x0024BBD9
		// (set) Token: 0x06018EE5 RID: 102117 RVA: 0x0024D9E9 File Offset: 0x0024BBE9
		public unsafe float ClvIndirectLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvIndirectLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCascadeLightingVolumeSettings.__PropertyOffset_ClvIndirectLightingIntensity) = value;
			}
		}

		// Token: 0x06018EE6 RID: 102118 RVA: 0x0024D9FA File Offset: 0x0024BBFA
		public FCascadeLightingVolumeSettings()
		{
		}

		// Token: 0x06018EE7 RID: 102119 RVA: 0x0024DA04 File Offset: 0x0024BC04
		public FCascadeLightingVolumeSettings(bool bOverride_ClvFadePercent, bool bOverride_ClvSkyLightLeakScale, bool bOverride_ClvPrtSkyLightIntensityScale, bool bOverride_ClvPrtDirectionalLightIntensityScale, bool bOverride_ClvPrtDirectionalLightIntensityMultiplier, bool bOverride_ClvIndirectLightingColor, bool bOverride_ClvIndirectLightingIntensity, float ClvFadePercent, float ClvSkyLightLeakScale, float ClvPrtSkyLightIntensityScale, float ClvPrtDirectionalLightIntensityScale, float ClvPrtDirectionalLightIntensityMultiplier, FLinearColor ClvIndirectLightingColor, float ClvIndirectLightingIntensity)
		{
			this.bOverride_ClvFadePercent = bOverride_ClvFadePercent;
			this.bOverride_ClvSkyLightLeakScale = bOverride_ClvSkyLightLeakScale;
			this.bOverride_ClvPrtSkyLightIntensityScale = bOverride_ClvPrtSkyLightIntensityScale;
			this.bOverride_ClvPrtDirectionalLightIntensityScale = bOverride_ClvPrtDirectionalLightIntensityScale;
			this.bOverride_ClvPrtDirectionalLightIntensityMultiplier = bOverride_ClvPrtDirectionalLightIntensityMultiplier;
			this.bOverride_ClvIndirectLightingColor = bOverride_ClvIndirectLightingColor;
			this.bOverride_ClvIndirectLightingIntensity = bOverride_ClvIndirectLightingIntensity;
			this.ClvFadePercent = ClvFadePercent;
			this.ClvSkyLightLeakScale = ClvSkyLightLeakScale;
			this.ClvPrtSkyLightIntensityScale = ClvPrtSkyLightIntensityScale;
			this.ClvPrtDirectionalLightIntensityScale = ClvPrtDirectionalLightIntensityScale;
			this.ClvPrtDirectionalLightIntensityMultiplier = ClvPrtDirectionalLightIntensityMultiplier;
			this.ClvIndirectLightingColor = ClvIndirectLightingColor;
			this.ClvIndirectLightingIntensity = ClvIndirectLightingIntensity;
		}

		// Token: 0x06018EE8 RID: 102120 RVA: 0x0024DA84 File Offset: 0x0024BC84
		protected override IntPtr GetUStructPtr()
		{
			return FCascadeLightingVolumeSettings.StaticStruct();
		}

		// Token: 0x06018EE9 RID: 102121 RVA: 0x0024DA90 File Offset: 0x0024BC90
		[NullableContext(2)]
		public FCascadeLightingVolumeSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018EEA RID: 102122 RVA: 0x0024DA9A File Offset: 0x0024BC9A
		public FCascadeLightingVolumeSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018EEB RID: 102123 RVA: 0x0024DAA5 File Offset: 0x0024BCA5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCascadeLightingVolumeSettings(Pointer, false, true);
		}

		// Token: 0x06018EEC RID: 102124 RVA: 0x0024DAAF File Offset: 0x0024BCAF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCascadeLightingVolumeSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400D7BD RID: 55229
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CascadeLightingVolumeSettings";

		// Token: 0x0400D7BE RID: 55230
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D7BF RID: 55231
		internal static int __PropertyOffset_bOverride_ClvFadePercent;

		// Token: 0x0400D7C0 RID: 55232
		internal static byte __PropertyMask_bOverride_ClvFadePercent;

		// Token: 0x0400D7C1 RID: 55233
		internal static int __PropertyOffset_bOverride_ClvSkyLightLeakScale;

		// Token: 0x0400D7C2 RID: 55234
		internal static byte __PropertyMask_bOverride_ClvSkyLightLeakScale;

		// Token: 0x0400D7C3 RID: 55235
		internal static int __PropertyOffset_bOverride_ClvPrtSkyLightIntensityScale;

		// Token: 0x0400D7C4 RID: 55236
		internal static byte __PropertyMask_bOverride_ClvPrtSkyLightIntensityScale;

		// Token: 0x0400D7C5 RID: 55237
		internal static int __PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityScale;

		// Token: 0x0400D7C6 RID: 55238
		internal static byte __PropertyMask_bOverride_ClvPrtDirectionalLightIntensityScale;

		// Token: 0x0400D7C7 RID: 55239
		internal static int __PropertyOffset_bOverride_ClvPrtDirectionalLightIntensityMultiplier;

		// Token: 0x0400D7C8 RID: 55240
		internal static byte __PropertyMask_bOverride_ClvPrtDirectionalLightIntensityMultiplier;

		// Token: 0x0400D7C9 RID: 55241
		internal static int __PropertyOffset_bOverride_ClvIndirectLightingColor;

		// Token: 0x0400D7CA RID: 55242
		internal static byte __PropertyMask_bOverride_ClvIndirectLightingColor;

		// Token: 0x0400D7CB RID: 55243
		internal static int __PropertyOffset_bOverride_ClvIndirectLightingIntensity;

		// Token: 0x0400D7CC RID: 55244
		internal static byte __PropertyMask_bOverride_ClvIndirectLightingIntensity;

		// Token: 0x0400D7CD RID: 55245
		internal static int __PropertyOffset_ClvFadePercent;

		// Token: 0x0400D7CE RID: 55246
		internal static int __PropertyOffset_ClvSkyLightLeakScale;

		// Token: 0x0400D7CF RID: 55247
		internal static int __PropertyOffset_ClvPrtSkyLightIntensityScale;

		// Token: 0x0400D7D0 RID: 55248
		internal static int __PropertyOffset_ClvPrtDirectionalLightIntensityScale;

		// Token: 0x0400D7D1 RID: 55249
		internal static int __PropertyOffset_ClvPrtDirectionalLightIntensityMultiplier;

		// Token: 0x0400D7D2 RID: 55250
		internal static int __PropertyOffset_ClvIndirectLightingColor;

		// Token: 0x0400D7D3 RID: 55251
		internal static int __PropertyOffset_ClvIndirectLightingIntensity;
	}
}
