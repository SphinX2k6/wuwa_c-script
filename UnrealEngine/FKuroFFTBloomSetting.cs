using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AF1 RID: 6897
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFFTBloomSetting")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroFFTBloomSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019BD3 RID: 105427 RVA: 0x00260636 File Offset: 0x0025E836
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFFTBloomSetting._ScriptStructPtr != 0) ? FKuroFFTBloomSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroFFTBloomSetting", ref FKuroFFTBloomSetting._ScriptStructPtr);
		}

		// Token: 0x170066DE RID: 26334
		// (get) Token: 0x06019BD4 RID: 105428 RVA: 0x0026065A File Offset: 0x0025E85A
		// (set) Token: 0x06019BD5 RID: 105429 RVA: 0x00260673 File Offset: 0x0025E873
		public unsafe bool bOverride_FFTIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTIntensity) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTIntensity) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTIntensity) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTIntensity) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTIntensity : 0));
			}
		}

		// Token: 0x170066DF RID: 26335
		// (get) Token: 0x06019BD6 RID: 105430 RVA: 0x002606A3 File Offset: 0x0025E8A3
		// (set) Token: 0x06019BD7 RID: 105431 RVA: 0x002606BC File Offset: 0x0025E8BC
		public unsafe bool bOverride_FFTThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTThreshold) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTThreshold) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTThreshold) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTThreshold) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTThreshold : 0));
			}
		}

		// Token: 0x170066E0 RID: 26336
		// (get) Token: 0x06019BD8 RID: 105432 RVA: 0x002606EC File Offset: 0x0025E8EC
		// (set) Token: 0x06019BD9 RID: 105433 RVA: 0x00260705 File Offset: 0x0025E905
		public unsafe bool bOverride_FFTTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTTexture) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTTexture) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTTexture) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTTexture) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTTexture : 0));
			}
		}

		// Token: 0x170066E1 RID: 26337
		// (get) Token: 0x06019BDA RID: 105434 RVA: 0x00260735 File Offset: 0x0025E935
		// (set) Token: 0x06019BDB RID: 105435 RVA: 0x0026074E File Offset: 0x0025E94E
		public unsafe bool bOverride_FFTScatterDispersion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTScatterDispersion) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTScatterDispersion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTScatterDispersion) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTScatterDispersion) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTScatterDispersion) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTScatterDispersion : 0));
			}
		}

		// Token: 0x170066E2 RID: 26338
		// (get) Token: 0x06019BDC RID: 105436 RVA: 0x0026077E File Offset: 0x0025E97E
		// (set) Token: 0x06019BDD RID: 105437 RVA: 0x00260797 File Offset: 0x0025E997
		public unsafe bool bOverride_FFTSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTSize) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTSize) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTSize) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTSize) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTSize : 0));
			}
		}

		// Token: 0x170066E3 RID: 26339
		// (get) Token: 0x06019BDE RID: 105438 RVA: 0x002607C7 File Offset: 0x0025E9C7
		// (set) Token: 0x06019BDF RID: 105439 RVA: 0x002607E0 File Offset: 0x0025E9E0
		public unsafe bool bOverride_FFTPreFilterMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMin) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMin) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMin) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMin) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMin : 0));
			}
		}

		// Token: 0x170066E4 RID: 26340
		// (get) Token: 0x06019BE0 RID: 105440 RVA: 0x00260810 File Offset: 0x0025EA10
		// (set) Token: 0x06019BE1 RID: 105441 RVA: 0x00260829 File Offset: 0x0025EA29
		public unsafe bool bOverride_FFTPreFilterMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMax) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMax) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMax) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMax) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMax : 0));
			}
		}

		// Token: 0x170066E5 RID: 26341
		// (get) Token: 0x06019BE2 RID: 105442 RVA: 0x00260859 File Offset: 0x0025EA59
		// (set) Token: 0x06019BE3 RID: 105443 RVA: 0x00260872 File Offset: 0x0025EA72
		public unsafe bool bOverride_FFTPreFilterMult
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMult) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMult) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMult) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTPreFilterMult) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMult) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTPreFilterMult : 0));
			}
		}

		// Token: 0x170066E6 RID: 26342
		// (get) Token: 0x06019BE4 RID: 105444 RVA: 0x002608A2 File Offset: 0x0025EAA2
		// (set) Token: 0x06019BE5 RID: 105445 RVA: 0x002608BB File Offset: 0x0025EABB
		public unsafe bool bOverride_FFTBufferScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTBufferScale) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTBufferScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTBufferScale) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTBufferScale) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTBufferScale) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTBufferScale : 0));
			}
		}

		// Token: 0x170066E7 RID: 26343
		// (get) Token: 0x06019BE6 RID: 105446 RVA: 0x002608EB File Offset: 0x0025EAEB
		// (set) Token: 0x06019BE7 RID: 105447 RVA: 0x00260904 File Offset: 0x0025EB04
		public unsafe bool bOverride_FFTDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTDistance) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTDistance) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTDistance) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTDistance) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTDistance : 0));
			}
		}

		// Token: 0x170066E8 RID: 26344
		// (get) Token: 0x06019BE8 RID: 105448 RVA: 0x00260934 File Offset: 0x0025EB34
		// (set) Token: 0x06019BE9 RID: 105449 RVA: 0x0026094D File Offset: 0x0025EB4D
		public unsafe bool bOverride_FFTHidenSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTHidenSky) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTHidenSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTHidenSky) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTHidenSky) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTHidenSky) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTHidenSky : 0));
			}
		}

		// Token: 0x170066E9 RID: 26345
		// (get) Token: 0x06019BEA RID: 105450 RVA: 0x0026097D File Offset: 0x0025EB7D
		// (set) Token: 0x06019BEB RID: 105451 RVA: 0x00260996 File Offset: 0x0025EB96
		public unsafe bool bOverride_FFTHidenTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTHidenTranslucent) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTHidenTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTHidenTranslucent) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTHidenTranslucent) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTHidenTranslucent) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTHidenTranslucent : 0));
			}
		}

		// Token: 0x170066EA RID: 26346
		// (get) Token: 0x06019BEC RID: 105452 RVA: 0x002609C6 File Offset: 0x0025EBC6
		// (set) Token: 0x06019BED RID: 105453 RVA: 0x002609DF File Offset: 0x0025EBDF
		public unsafe bool bOverride_FFTBeforeTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTBeforeTranslucency) & FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTBeforeTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTBeforeTranslucency) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_bOverride_FFTBeforeTranslucency) & ~FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTBeforeTranslucency) | (value ? FKuroFFTBloomSetting.__PropertyMask_bOverride_FFTBeforeTranslucency : 0));
			}
		}

		// Token: 0x170066EB RID: 26347
		// (get) Token: 0x06019BEE RID: 105454 RVA: 0x00260A0F File Offset: 0x0025EC0F
		// (set) Token: 0x06019BEF RID: 105455 RVA: 0x00260A1F File Offset: 0x0025EC1F
		public unsafe float FFTIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTIntensity) = value;
			}
		}

		// Token: 0x170066EC RID: 26348
		// (get) Token: 0x06019BF0 RID: 105456 RVA: 0x00260A30 File Offset: 0x0025EC30
		// (set) Token: 0x06019BF1 RID: 105457 RVA: 0x00260A40 File Offset: 0x0025EC40
		public unsafe float FFTThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTThreshold) = value;
			}
		}

		// Token: 0x170066ED RID: 26349
		// (get) Token: 0x06019BF2 RID: 105458 RVA: 0x00260A51 File Offset: 0x0025EC51
		// (set) Token: 0x06019BF3 RID: 105459 RVA: 0x00260A65 File Offset: 0x0025EC65
		[Nullable(2)]
		public unsafe UTexture2D FFTTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroFFTBloomSetting.__PropertyOffset_FFTTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroFFTBloomSetting.__PropertyOffset_FFTTexture, value);
			}
		}

		// Token: 0x170066EE RID: 26350
		// (get) Token: 0x06019BF4 RID: 105460 RVA: 0x00260A7A File Offset: 0x0025EC7A
		// (set) Token: 0x06019BF5 RID: 105461 RVA: 0x00260A8A File Offset: 0x0025EC8A
		public unsafe float FFTScatterDispersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTScatterDispersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTScatterDispersion) = value;
			}
		}

		// Token: 0x170066EF RID: 26351
		// (get) Token: 0x06019BF6 RID: 105462 RVA: 0x00260A9B File Offset: 0x0025EC9B
		// (set) Token: 0x06019BF7 RID: 105463 RVA: 0x00260AAB File Offset: 0x0025ECAB
		public unsafe float FFTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTSize) = value;
			}
		}

		// Token: 0x170066F0 RID: 26352
		// (get) Token: 0x06019BF8 RID: 105464 RVA: 0x00260ABC File Offset: 0x0025ECBC
		// (set) Token: 0x06019BF9 RID: 105465 RVA: 0x00260ACC File Offset: 0x0025ECCC
		public unsafe float FFTPreFilterMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTPreFilterMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTPreFilterMin) = value;
			}
		}

		// Token: 0x170066F1 RID: 26353
		// (get) Token: 0x06019BFA RID: 105466 RVA: 0x00260ADD File Offset: 0x0025ECDD
		// (set) Token: 0x06019BFB RID: 105467 RVA: 0x00260AED File Offset: 0x0025ECED
		public unsafe float FFTPreFilterMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTPreFilterMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTPreFilterMax) = value;
			}
		}

		// Token: 0x170066F2 RID: 26354
		// (get) Token: 0x06019BFC RID: 105468 RVA: 0x00260AFE File Offset: 0x0025ECFE
		// (set) Token: 0x06019BFD RID: 105469 RVA: 0x00260B0E File Offset: 0x0025ED0E
		public unsafe float FFTPreFilterMult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTPreFilterMult);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTPreFilterMult) = value;
			}
		}

		// Token: 0x170066F3 RID: 26355
		// (get) Token: 0x06019BFE RID: 105470 RVA: 0x00260B1F File Offset: 0x0025ED1F
		// (set) Token: 0x06019BFF RID: 105471 RVA: 0x00260B2F File Offset: 0x0025ED2F
		public unsafe float FFTBufferScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTBufferScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTBufferScale) = value;
			}
		}

		// Token: 0x170066F4 RID: 26356
		// (get) Token: 0x06019C00 RID: 105472 RVA: 0x00260B40 File Offset: 0x0025ED40
		// (set) Token: 0x06019C01 RID: 105473 RVA: 0x00260B50 File Offset: 0x0025ED50
		public unsafe float FFTDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTDistance) = value;
			}
		}

		// Token: 0x170066F5 RID: 26357
		// (get) Token: 0x06019C02 RID: 105474 RVA: 0x00260B61 File Offset: 0x0025ED61
		// (set) Token: 0x06019C03 RID: 105475 RVA: 0x00260B7A File Offset: 0x0025ED7A
		public unsafe bool FFTHidenSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTHidenSky) & FKuroFFTBloomSetting.__PropertyMask_FFTHidenSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTHidenSky) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTHidenSky) & ~FKuroFFTBloomSetting.__PropertyMask_FFTHidenSky) | (value ? FKuroFFTBloomSetting.__PropertyMask_FFTHidenSky : 0));
			}
		}

		// Token: 0x170066F6 RID: 26358
		// (get) Token: 0x06019C04 RID: 105476 RVA: 0x00260BAA File Offset: 0x0025EDAA
		// (set) Token: 0x06019C05 RID: 105477 RVA: 0x00260BC3 File Offset: 0x0025EDC3
		public unsafe bool FFTHidenTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTHidenTranslucent) & FKuroFFTBloomSetting.__PropertyMask_FFTHidenTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTHidenTranslucent) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTHidenTranslucent) & ~FKuroFFTBloomSetting.__PropertyMask_FFTHidenTranslucent) | (value ? FKuroFFTBloomSetting.__PropertyMask_FFTHidenTranslucent : 0));
			}
		}

		// Token: 0x170066F7 RID: 26359
		// (get) Token: 0x06019C06 RID: 105478 RVA: 0x00260BF3 File Offset: 0x0025EDF3
		// (set) Token: 0x06019C07 RID: 105479 RVA: 0x00260C0C File Offset: 0x0025EE0C
		public unsafe bool FFTBeforeTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTBeforeTranslucency) & FKuroFFTBloomSetting.__PropertyMask_FFTBeforeTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTBeforeTranslucency) = ((*(base.NativePtr + (IntPtr)FKuroFFTBloomSetting.__PropertyOffset_FFTBeforeTranslucency) & ~FKuroFFTBloomSetting.__PropertyMask_FFTBeforeTranslucency) | (value ? FKuroFFTBloomSetting.__PropertyMask_FFTBeforeTranslucency : 0));
			}
		}

		// Token: 0x06019C08 RID: 105480 RVA: 0x00260C3C File Offset: 0x0025EE3C
		public FKuroFFTBloomSetting()
		{
		}

		// Token: 0x06019C09 RID: 105481 RVA: 0x00260C44 File Offset: 0x0025EE44
		[NullableContext(1)]
		public FKuroFFTBloomSetting(bool bOverride_FFTIntensity, bool bOverride_FFTThreshold, bool bOverride_FFTTexture, bool bOverride_FFTScatterDispersion, bool bOverride_FFTSize, bool bOverride_FFTPreFilterMin, bool bOverride_FFTPreFilterMax, bool bOverride_FFTPreFilterMult, bool bOverride_FFTBufferScale, bool bOverride_FFTDistance, bool bOverride_FFTHidenSky, bool bOverride_FFTHidenTranslucent, bool bOverride_FFTBeforeTranslucency, float FFTIntensity, float FFTThreshold, UTexture2D FFTTexture, float FFTScatterDispersion, float FFTSize, float FFTPreFilterMin, float FFTPreFilterMax, float FFTPreFilterMult, float FFTBufferScale, float FFTDistance, bool FFTHidenSky, bool FFTHidenTranslucent, bool FFTBeforeTranslucency)
		{
			this.bOverride_FFTIntensity = bOverride_FFTIntensity;
			this.bOverride_FFTThreshold = bOverride_FFTThreshold;
			this.bOverride_FFTTexture = bOverride_FFTTexture;
			this.bOverride_FFTScatterDispersion = bOverride_FFTScatterDispersion;
			this.bOverride_FFTSize = bOverride_FFTSize;
			this.bOverride_FFTPreFilterMin = bOverride_FFTPreFilterMin;
			this.bOverride_FFTPreFilterMax = bOverride_FFTPreFilterMax;
			this.bOverride_FFTPreFilterMult = bOverride_FFTPreFilterMult;
			this.bOverride_FFTBufferScale = bOverride_FFTBufferScale;
			this.bOverride_FFTDistance = bOverride_FFTDistance;
			this.bOverride_FFTHidenSky = bOverride_FFTHidenSky;
			this.bOverride_FFTHidenTranslucent = bOverride_FFTHidenTranslucent;
			this.bOverride_FFTBeforeTranslucency = bOverride_FFTBeforeTranslucency;
			this.FFTIntensity = FFTIntensity;
			this.FFTThreshold = FFTThreshold;
			this.FFTTexture = FFTTexture;
			this.FFTScatterDispersion = FFTScatterDispersion;
			this.FFTSize = FFTSize;
			this.FFTPreFilterMin = FFTPreFilterMin;
			this.FFTPreFilterMax = FFTPreFilterMax;
			this.FFTPreFilterMult = FFTPreFilterMult;
			this.FFTBufferScale = FFTBufferScale;
			this.FFTDistance = FFTDistance;
			this.FFTHidenSky = FFTHidenSky;
			this.FFTHidenTranslucent = FFTHidenTranslucent;
			this.FFTBeforeTranslucency = FFTBeforeTranslucency;
		}

		// Token: 0x06019C0A RID: 105482 RVA: 0x00260D24 File Offset: 0x0025EF24
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFFTBloomSetting.StaticStruct();
		}

		// Token: 0x06019C0B RID: 105483 RVA: 0x00260D30 File Offset: 0x0025EF30
		[NullableContext(2)]
		public FKuroFFTBloomSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019C0C RID: 105484 RVA: 0x00260D3A File Offset: 0x0025EF3A
		public FKuroFFTBloomSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019C0D RID: 105485 RVA: 0x00260D45 File Offset: 0x0025EF45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFFTBloomSetting(Pointer, false, true);
		}

		// Token: 0x06019C0E RID: 105486 RVA: 0x00260D4F File Offset: 0x0025EF4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFFTBloomSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400DFFA RID: 57338
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFFTBloomSetting";

		// Token: 0x0400DFFB RID: 57339
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DFFC RID: 57340
		internal static int __PropertyOffset_bOverride_FFTIntensity;

		// Token: 0x0400DFFD RID: 57341
		internal static byte __PropertyMask_bOverride_FFTIntensity;

		// Token: 0x0400DFFE RID: 57342
		internal static int __PropertyOffset_bOverride_FFTThreshold;

		// Token: 0x0400DFFF RID: 57343
		internal static byte __PropertyMask_bOverride_FFTThreshold;

		// Token: 0x0400E000 RID: 57344
		internal static int __PropertyOffset_bOverride_FFTTexture;

		// Token: 0x0400E001 RID: 57345
		internal static byte __PropertyMask_bOverride_FFTTexture;

		// Token: 0x0400E002 RID: 57346
		internal static int __PropertyOffset_bOverride_FFTScatterDispersion;

		// Token: 0x0400E003 RID: 57347
		internal static byte __PropertyMask_bOverride_FFTScatterDispersion;

		// Token: 0x0400E004 RID: 57348
		internal static int __PropertyOffset_bOverride_FFTSize;

		// Token: 0x0400E005 RID: 57349
		internal static byte __PropertyMask_bOverride_FFTSize;

		// Token: 0x0400E006 RID: 57350
		internal static int __PropertyOffset_bOverride_FFTPreFilterMin;

		// Token: 0x0400E007 RID: 57351
		internal static byte __PropertyMask_bOverride_FFTPreFilterMin;

		// Token: 0x0400E008 RID: 57352
		internal static int __PropertyOffset_bOverride_FFTPreFilterMax;

		// Token: 0x0400E009 RID: 57353
		internal static byte __PropertyMask_bOverride_FFTPreFilterMax;

		// Token: 0x0400E00A RID: 57354
		internal static int __PropertyOffset_bOverride_FFTPreFilterMult;

		// Token: 0x0400E00B RID: 57355
		internal static byte __PropertyMask_bOverride_FFTPreFilterMult;

		// Token: 0x0400E00C RID: 57356
		internal static int __PropertyOffset_bOverride_FFTBufferScale;

		// Token: 0x0400E00D RID: 57357
		internal static byte __PropertyMask_bOverride_FFTBufferScale;

		// Token: 0x0400E00E RID: 57358
		internal static int __PropertyOffset_bOverride_FFTDistance;

		// Token: 0x0400E00F RID: 57359
		internal static byte __PropertyMask_bOverride_FFTDistance;

		// Token: 0x0400E010 RID: 57360
		internal static int __PropertyOffset_bOverride_FFTHidenSky;

		// Token: 0x0400E011 RID: 57361
		internal static byte __PropertyMask_bOverride_FFTHidenSky;

		// Token: 0x0400E012 RID: 57362
		internal static int __PropertyOffset_bOverride_FFTHidenTranslucent;

		// Token: 0x0400E013 RID: 57363
		internal static byte __PropertyMask_bOverride_FFTHidenTranslucent;

		// Token: 0x0400E014 RID: 57364
		internal static int __PropertyOffset_bOverride_FFTBeforeTranslucency;

		// Token: 0x0400E015 RID: 57365
		internal static byte __PropertyMask_bOverride_FFTBeforeTranslucency;

		// Token: 0x0400E016 RID: 57366
		internal static int __PropertyOffset_FFTIntensity;

		// Token: 0x0400E017 RID: 57367
		internal static int __PropertyOffset_FFTThreshold;

		// Token: 0x0400E018 RID: 57368
		internal static int __PropertyOffset_FFTTexture;

		// Token: 0x0400E019 RID: 57369
		internal static int __PropertyOffset_FFTScatterDispersion;

		// Token: 0x0400E01A RID: 57370
		internal static int __PropertyOffset_FFTSize;

		// Token: 0x0400E01B RID: 57371
		internal static int __PropertyOffset_FFTPreFilterMin;

		// Token: 0x0400E01C RID: 57372
		internal static int __PropertyOffset_FFTPreFilterMax;

		// Token: 0x0400E01D RID: 57373
		internal static int __PropertyOffset_FFTPreFilterMult;

		// Token: 0x0400E01E RID: 57374
		internal static int __PropertyOffset_FFTBufferScale;

		// Token: 0x0400E01F RID: 57375
		internal static int __PropertyOffset_FFTDistance;

		// Token: 0x0400E020 RID: 57376
		internal static int __PropertyOffset_FFTHidenSky;

		// Token: 0x0400E021 RID: 57377
		internal static byte __PropertyMask_FFTHidenSky;

		// Token: 0x0400E022 RID: 57378
		internal static int __PropertyOffset_FFTHidenTranslucent;

		// Token: 0x0400E023 RID: 57379
		internal static byte __PropertyMask_FFTHidenTranslucent;

		// Token: 0x0400E024 RID: 57380
		internal static int __PropertyOffset_FFTBeforeTranslucency;

		// Token: 0x0400E025 RID: 57381
		internal static byte __PropertyMask_FFTBeforeTranslucency;
	}
}
