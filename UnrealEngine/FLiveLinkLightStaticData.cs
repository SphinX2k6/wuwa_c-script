using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200220B RID: 8715
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkLightStaticData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FLiveLinkLightStaticData : FLiveLinkTransformStaticData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021328 RID: 135976 RVA: 0x0030F146 File Offset: 0x0030D346
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkLightStaticData._ScriptStructPtr != 0) ? FLiveLinkLightStaticData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkLightStaticData", ref FLiveLinkLightStaticData._ScriptStructPtr);
		}

		// Token: 0x17008193 RID: 33171
		// (get) Token: 0x06021329 RID: 135977 RVA: 0x0030F16A File Offset: 0x0030D36A
		// (set) Token: 0x0602132A RID: 135978 RVA: 0x0030F17A File Offset: 0x0030D37A
		public unsafe bool bIsTemperatureSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsTemperatureSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsTemperatureSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008194 RID: 33172
		// (get) Token: 0x0602132B RID: 135979 RVA: 0x0030F18B File Offset: 0x0030D38B
		// (set) Token: 0x0602132C RID: 135980 RVA: 0x0030F19B File Offset: 0x0030D39B
		public unsafe bool bIsIntensitySupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsIntensitySupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsIntensitySupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008195 RID: 33173
		// (get) Token: 0x0602132D RID: 135981 RVA: 0x0030F1AC File Offset: 0x0030D3AC
		// (set) Token: 0x0602132E RID: 135982 RVA: 0x0030F1BC File Offset: 0x0030D3BC
		public unsafe bool bIsLightColorSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsLightColorSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsLightColorSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008196 RID: 33174
		// (get) Token: 0x0602132F RID: 135983 RVA: 0x0030F1CD File Offset: 0x0030D3CD
		// (set) Token: 0x06021330 RID: 135984 RVA: 0x0030F1DD File Offset: 0x0030D3DD
		public unsafe bool bIsInnerConeAngleSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsInnerConeAngleSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsInnerConeAngleSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008197 RID: 33175
		// (get) Token: 0x06021331 RID: 135985 RVA: 0x0030F1EE File Offset: 0x0030D3EE
		// (set) Token: 0x06021332 RID: 135986 RVA: 0x0030F1FE File Offset: 0x0030D3FE
		public unsafe bool bIsOuterConeAngleSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsOuterConeAngleSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsOuterConeAngleSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008198 RID: 33176
		// (get) Token: 0x06021333 RID: 135987 RVA: 0x0030F20F File Offset: 0x0030D40F
		// (set) Token: 0x06021334 RID: 135988 RVA: 0x0030F21F File Offset: 0x0030D41F
		public unsafe bool bIsAttenuationRadiusSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsAttenuationRadiusSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsAttenuationRadiusSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008199 RID: 33177
		// (get) Token: 0x06021335 RID: 135989 RVA: 0x0030F230 File Offset: 0x0030D430
		// (set) Token: 0x06021336 RID: 135990 RVA: 0x0030F240 File Offset: 0x0030D440
		public unsafe bool bIsSourceLenghtSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsSourceLenghtSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsSourceLenghtSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700819A RID: 33178
		// (get) Token: 0x06021337 RID: 135991 RVA: 0x0030F251 File Offset: 0x0030D451
		// (set) Token: 0x06021338 RID: 135992 RVA: 0x0030F261 File Offset: 0x0030D461
		public unsafe bool bIsSourceRadiusSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsSourceRadiusSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsSourceRadiusSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700819B RID: 33179
		// (get) Token: 0x06021339 RID: 135993 RVA: 0x0030F272 File Offset: 0x0030D472
		// (set) Token: 0x0602133A RID: 135994 RVA: 0x0030F282 File Offset: 0x0030D482
		public unsafe bool bIsSoftSourceRadiusSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsSoftSourceRadiusSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightStaticData.__PropertyOffset_bIsSoftSourceRadiusSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602133B RID: 135995 RVA: 0x0030F293 File Offset: 0x0030D493
		public FLiveLinkLightStaticData()
		{
		}

		// Token: 0x0602133C RID: 135996 RVA: 0x0030F29C File Offset: 0x0030D49C
		[NullableContext(1)]
		public FLiveLinkLightStaticData(bool bIsTemperatureSupported, bool bIsIntensitySupported, bool bIsLightColorSupported, bool bIsInnerConeAngleSupported, bool bIsOuterConeAngleSupported, bool bIsAttenuationRadiusSupported, bool bIsSourceLenghtSupported, bool bIsSourceRadiusSupported, bool bIsSoftSourceRadiusSupported, bool bIsLocationSupported, bool bIsRotationSupported, bool bIsScaleSupported, TArray<FName> PropertyNames)
		{
			this.bIsTemperatureSupported = bIsTemperatureSupported;
			this.bIsIntensitySupported = bIsIntensitySupported;
			this.bIsLightColorSupported = bIsLightColorSupported;
			this.bIsInnerConeAngleSupported = bIsInnerConeAngleSupported;
			this.bIsOuterConeAngleSupported = bIsOuterConeAngleSupported;
			this.bIsAttenuationRadiusSupported = bIsAttenuationRadiusSupported;
			this.bIsSourceLenghtSupported = bIsSourceLenghtSupported;
			this.bIsSourceRadiusSupported = bIsSourceRadiusSupported;
			this.bIsSoftSourceRadiusSupported = bIsSoftSourceRadiusSupported;
			base.bIsLocationSupported = bIsLocationSupported;
			base.bIsRotationSupported = bIsRotationSupported;
			base.bIsScaleSupported = bIsScaleSupported;
			base.PropertyNames = PropertyNames;
		}

		// Token: 0x0602133D RID: 135997 RVA: 0x0030F314 File Offset: 0x0030D514
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkLightStaticData.StaticStruct();
		}

		// Token: 0x0602133E RID: 135998 RVA: 0x0030F320 File Offset: 0x0030D520
		[NullableContext(2)]
		public FLiveLinkLightStaticData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602133F RID: 135999 RVA: 0x0030F32A File Offset: 0x0030D52A
		public FLiveLinkLightStaticData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021340 RID: 136000 RVA: 0x0030F335 File Offset: 0x0030D535
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkLightStaticData(Pointer, false, true);
		}

		// Token: 0x06021341 RID: 136001 RVA: 0x0030F33F File Offset: 0x0030D53F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkLightStaticData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B5D RID: 72541
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkLightStaticData";

		// Token: 0x04011B5E RID: 72542
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B5F RID: 72543
		internal static int __PropertyOffset_bIsTemperatureSupported;

		// Token: 0x04011B60 RID: 72544
		internal static int __PropertyOffset_bIsIntensitySupported;

		// Token: 0x04011B61 RID: 72545
		internal static int __PropertyOffset_bIsLightColorSupported;

		// Token: 0x04011B62 RID: 72546
		internal static int __PropertyOffset_bIsInnerConeAngleSupported;

		// Token: 0x04011B63 RID: 72547
		internal static int __PropertyOffset_bIsOuterConeAngleSupported;

		// Token: 0x04011B64 RID: 72548
		internal static int __PropertyOffset_bIsAttenuationRadiusSupported;

		// Token: 0x04011B65 RID: 72549
		internal static int __PropertyOffset_bIsSourceLenghtSupported;

		// Token: 0x04011B66 RID: 72550
		internal static int __PropertyOffset_bIsSourceRadiusSupported;

		// Token: 0x04011B67 RID: 72551
		internal static int __PropertyOffset_bIsSoftSourceRadiusSupported;
	}
}
