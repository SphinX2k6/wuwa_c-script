using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C2A RID: 7210
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SkyAtmosphereSetting")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSkyAtmosphereSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BE3C RID: 114236 RVA: 0x002907F8 File Offset: 0x0028E9F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkyAtmosphereSetting._ScriptStructPtr != 0) ? FSkyAtmosphereSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.SkyAtmosphereSetting", ref FSkyAtmosphereSetting._ScriptStructPtr);
		}

		// Token: 0x1700707B RID: 28795
		// (get) Token: 0x0601BE3D RID: 114237 RVA: 0x0029081C File Offset: 0x0028EA1C
		// (set) Token: 0x0601BE3E RID: 114238 RVA: 0x00290835 File Offset: 0x0028EA35
		public unsafe bool bOverride_LightShaftBloomScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomScale) & FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomScale) = ((*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomScale) & ~FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomScale) | (value ? FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomScale : 0));
			}
		}

		// Token: 0x1700707C RID: 28796
		// (get) Token: 0x0601BE3F RID: 114239 RVA: 0x00290865 File Offset: 0x0028EA65
		// (set) Token: 0x0601BE40 RID: 114240 RVA: 0x0029087E File Offset: 0x0028EA7E
		public unsafe bool bOverride_LightShaftBloomThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomThreshold) & FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomThreshold) = ((*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomThreshold) & ~FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomThreshold) | (value ? FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomThreshold : 0));
			}
		}

		// Token: 0x1700707D RID: 28797
		// (get) Token: 0x0601BE41 RID: 114241 RVA: 0x002908AE File Offset: 0x0028EAAE
		// (set) Token: 0x0601BE42 RID: 114242 RVA: 0x002908C7 File Offset: 0x0028EAC7
		public unsafe bool bOverride_LightShaftBloomMaxBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomMaxBrightness) & FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomMaxBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomMaxBrightness) = ((*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_bOverride_LightShaftBloomMaxBrightness) & ~FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomMaxBrightness) | (value ? FSkyAtmosphereSetting.__PropertyMask_bOverride_LightShaftBloomMaxBrightness : 0));
			}
		}

		// Token: 0x1700707E RID: 28798
		// (get) Token: 0x0601BE43 RID: 114243 RVA: 0x002908F7 File Offset: 0x0028EAF7
		// (set) Token: 0x0601BE44 RID: 114244 RVA: 0x00290907 File Offset: 0x0028EB07
		public unsafe float LightShaftBloomScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_LightShaftBloomScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_LightShaftBloomScale) = value;
			}
		}

		// Token: 0x1700707F RID: 28799
		// (get) Token: 0x0601BE45 RID: 114245 RVA: 0x00290918 File Offset: 0x0028EB18
		// (set) Token: 0x0601BE46 RID: 114246 RVA: 0x00290928 File Offset: 0x0028EB28
		public unsafe float LightShaftBloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_LightShaftBloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_LightShaftBloomThreshold) = value;
			}
		}

		// Token: 0x17007080 RID: 28800
		// (get) Token: 0x0601BE47 RID: 114247 RVA: 0x00290939 File Offset: 0x0028EB39
		// (set) Token: 0x0601BE48 RID: 114248 RVA: 0x00290949 File Offset: 0x0028EB49
		public unsafe float LightShaftBloomMaxBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_LightShaftBloomMaxBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyAtmosphereSetting.__PropertyOffset_LightShaftBloomMaxBrightness) = value;
			}
		}

		// Token: 0x0601BE49 RID: 114249 RVA: 0x0029095A File Offset: 0x0028EB5A
		public FSkyAtmosphereSetting()
		{
		}

		// Token: 0x0601BE4A RID: 114250 RVA: 0x00290962 File Offset: 0x0028EB62
		public FSkyAtmosphereSetting(bool bOverride_LightShaftBloomScale, bool bOverride_LightShaftBloomThreshold, bool bOverride_LightShaftBloomMaxBrightness, float LightShaftBloomScale, float LightShaftBloomThreshold, float LightShaftBloomMaxBrightness)
		{
			this.bOverride_LightShaftBloomScale = bOverride_LightShaftBloomScale;
			this.bOverride_LightShaftBloomThreshold = bOverride_LightShaftBloomThreshold;
			this.bOverride_LightShaftBloomMaxBrightness = bOverride_LightShaftBloomMaxBrightness;
			this.LightShaftBloomScale = LightShaftBloomScale;
			this.LightShaftBloomThreshold = LightShaftBloomThreshold;
			this.LightShaftBloomMaxBrightness = LightShaftBloomMaxBrightness;
		}

		// Token: 0x0601BE4B RID: 114251 RVA: 0x00290997 File Offset: 0x0028EB97
		protected override IntPtr GetUStructPtr()
		{
			return FSkyAtmosphereSetting.StaticStruct();
		}

		// Token: 0x0601BE4C RID: 114252 RVA: 0x002909A3 File Offset: 0x0028EBA3
		[NullableContext(2)]
		public FSkyAtmosphereSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BE4D RID: 114253 RVA: 0x002909AD File Offset: 0x0028EBAD
		public FSkyAtmosphereSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BE4E RID: 114254 RVA: 0x002909B8 File Offset: 0x0028EBB8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkyAtmosphereSetting(Pointer, false, true);
		}

		// Token: 0x0601BE4F RID: 114255 RVA: 0x002909C2 File Offset: 0x0028EBC2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkyAtmosphereSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF95 RID: 61333
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SkyAtmosphereSetting";

		// Token: 0x0400EF96 RID: 61334
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF97 RID: 61335
		internal static int __PropertyOffset_bOverride_LightShaftBloomScale;

		// Token: 0x0400EF98 RID: 61336
		internal static byte __PropertyMask_bOverride_LightShaftBloomScale;

		// Token: 0x0400EF99 RID: 61337
		internal static int __PropertyOffset_bOverride_LightShaftBloomThreshold;

		// Token: 0x0400EF9A RID: 61338
		internal static byte __PropertyMask_bOverride_LightShaftBloomThreshold;

		// Token: 0x0400EF9B RID: 61339
		internal static int __PropertyOffset_bOverride_LightShaftBloomMaxBrightness;

		// Token: 0x0400EF9C RID: 61340
		internal static byte __PropertyMask_bOverride_LightShaftBloomMaxBrightness;

		// Token: 0x0400EF9D RID: 61341
		internal static int __PropertyOffset_LightShaftBloomScale;

		// Token: 0x0400EF9E RID: 61342
		internal static int __PropertyOffset_LightShaftBloomThreshold;

		// Token: 0x0400EF9F RID: 61343
		internal static int __PropertyOffset_LightShaftBloomMaxBrightness;
	}
}
