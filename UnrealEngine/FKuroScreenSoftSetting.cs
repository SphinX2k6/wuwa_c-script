using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BB4 RID: 7092
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenSoftSetting")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroScreenSoftSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B205 RID: 111109 RVA: 0x0027F824 File Offset: 0x0027DA24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroScreenSoftSetting._ScriptStructPtr != 0) ? FKuroScreenSoftSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenSoftSetting", ref FKuroScreenSoftSetting._ScriptStructPtr);
		}

		// Token: 0x17006CC2 RID: 27842
		// (get) Token: 0x0601B206 RID: 111110 RVA: 0x0027F848 File Offset: 0x0027DA48
		// (set) Token: 0x0601B207 RID: 111111 RVA: 0x0027F861 File Offset: 0x0027DA61
		public unsafe bool bOverride_ScreenSoftIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftIntensity) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftIntensity) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftIntensity) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftIntensity) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftIntensity : 0));
			}
		}

		// Token: 0x17006CC3 RID: 27843
		// (get) Token: 0x0601B208 RID: 111112 RVA: 0x0027F891 File Offset: 0x0027DA91
		// (set) Token: 0x0601B209 RID: 111113 RVA: 0x0027F8AA File Offset: 0x0027DAAA
		public unsafe bool bOverride_ScreenSoftThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftThreshold) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftThreshold) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftThreshold) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftThreshold) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftThreshold : 0));
			}
		}

		// Token: 0x17006CC4 RID: 27844
		// (get) Token: 0x0601B20A RID: 111114 RVA: 0x0027F8DA File Offset: 0x0027DADA
		// (set) Token: 0x0601B20B RID: 111115 RVA: 0x0027F8F3 File Offset: 0x0027DAF3
		public unsafe bool bOverride_ScreenSoftDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftDistance) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftDistance) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftDistance) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftDistance) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftDistance : 0));
			}
		}

		// Token: 0x17006CC5 RID: 27845
		// (get) Token: 0x0601B20C RID: 111116 RVA: 0x0027F923 File Offset: 0x0027DB23
		// (set) Token: 0x0601B20D RID: 111117 RVA: 0x0027F93C File Offset: 0x0027DB3C
		public unsafe bool bOverride_ScreenSoftSkyBloomCompensation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftSkyBloomCompensation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftSkyBloomCompensation) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftSkyBloomCompensation : 0));
			}
		}

		// Token: 0x17006CC6 RID: 27846
		// (get) Token: 0x0601B20E RID: 111118 RVA: 0x0027F96C File Offset: 0x0027DB6C
		// (set) Token: 0x0601B20F RID: 111119 RVA: 0x0027F985 File Offset: 0x0027DB85
		public unsafe bool bOverride_ScreenSoftRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftRange) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftRange) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftRange) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftRange) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftRange : 0));
			}
		}

		// Token: 0x17006CC7 RID: 27847
		// (get) Token: 0x0601B210 RID: 111120 RVA: 0x0027F9B5 File Offset: 0x0027DBB5
		// (set) Token: 0x0601B211 RID: 111121 RVA: 0x0027F9CE File Offset: 0x0027DBCE
		public unsafe bool bOverride_ScreenSoftOverflowDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftOverflowDistance) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftOverflowDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftOverflowDistance) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftOverflowDistance) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftOverflowDistance) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftOverflowDistance : 0));
			}
		}

		// Token: 0x17006CC8 RID: 27848
		// (get) Token: 0x0601B212 RID: 111122 RVA: 0x0027F9FE File Offset: 0x0027DBFE
		// (set) Token: 0x0601B213 RID: 111123 RVA: 0x0027FA17 File Offset: 0x0027DC17
		public unsafe bool bOverride_ScreenSoftSunExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftSunExposure) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftSunExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftSunExposure) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftSunExposure) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftSunExposure) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftSunExposure : 0));
			}
		}

		// Token: 0x17006CC9 RID: 27849
		// (get) Token: 0x0601B214 RID: 111124 RVA: 0x0027FA47 File Offset: 0x0027DC47
		// (set) Token: 0x0601B215 RID: 111125 RVA: 0x0027FA60 File Offset: 0x0027DC60
		public unsafe bool bOverride_ScreenSoftHighQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftHighQuality) & FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftHighQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftHighQuality) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_ScreenSoftHighQuality) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftHighQuality) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_ScreenSoftHighQuality : 0));
			}
		}

		// Token: 0x17006CCA RID: 27850
		// (get) Token: 0x0601B216 RID: 111126 RVA: 0x0027FA90 File Offset: 0x0027DC90
		// (set) Token: 0x0601B217 RID: 111127 RVA: 0x0027FAA9 File Offset: 0x0027DCA9
		public unsafe bool bOverride_MobileScreenSoftIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftIntensity) & FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftIntensity) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftIntensity) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftIntensity) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftIntensity : 0));
			}
		}

		// Token: 0x17006CCB RID: 27851
		// (get) Token: 0x0601B218 RID: 111128 RVA: 0x0027FAD9 File Offset: 0x0027DCD9
		// (set) Token: 0x0601B219 RID: 111129 RVA: 0x0027FAF2 File Offset: 0x0027DCF2
		public unsafe bool bOverride_MobileScreenSoftThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftThreshold) & FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftThreshold) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftThreshold) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftThreshold) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftThreshold : 0));
			}
		}

		// Token: 0x17006CCC RID: 27852
		// (get) Token: 0x0601B21A RID: 111130 RVA: 0x0027FB22 File Offset: 0x0027DD22
		// (set) Token: 0x0601B21B RID: 111131 RVA: 0x0027FB3B File Offset: 0x0027DD3B
		public unsafe bool bOverride_MobileScreenSoftDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftDistance) & FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftDistance) = ((*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_bOverride_MobileScreenSoftDistance) & ~FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftDistance) | (value ? FKuroScreenSoftSetting.__PropertyMask_bOverride_MobileScreenSoftDistance : 0));
			}
		}

		// Token: 0x17006CCD RID: 27853
		// (get) Token: 0x0601B21C RID: 111132 RVA: 0x0027FB6B File Offset: 0x0027DD6B
		// (set) Token: 0x0601B21D RID: 111133 RVA: 0x0027FB7B File Offset: 0x0027DD7B
		public unsafe float ScreenSoftIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftIntensity) = value;
			}
		}

		// Token: 0x17006CCE RID: 27854
		// (get) Token: 0x0601B21E RID: 111134 RVA: 0x0027FB8C File Offset: 0x0027DD8C
		// (set) Token: 0x0601B21F RID: 111135 RVA: 0x0027FB9C File Offset: 0x0027DD9C
		public unsafe float ScreenSoftThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftThreshold) = value;
			}
		}

		// Token: 0x17006CCF RID: 27855
		// (get) Token: 0x0601B220 RID: 111136 RVA: 0x0027FBAD File Offset: 0x0027DDAD
		// (set) Token: 0x0601B221 RID: 111137 RVA: 0x0027FBBD File Offset: 0x0027DDBD
		public unsafe float ScreenSoftDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftDistance) = value;
			}
		}

		// Token: 0x17006CD0 RID: 27856
		// (get) Token: 0x0601B222 RID: 111138 RVA: 0x0027FBCE File Offset: 0x0027DDCE
		// (set) Token: 0x0601B223 RID: 111139 RVA: 0x0027FBDE File Offset: 0x0027DDDE
		public unsafe float ScreenSoftSkyBloomCompensation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftSkyBloomCompensation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftSkyBloomCompensation) = value;
			}
		}

		// Token: 0x17006CD1 RID: 27857
		// (get) Token: 0x0601B224 RID: 111140 RVA: 0x0027FBEF File Offset: 0x0027DDEF
		// (set) Token: 0x0601B225 RID: 111141 RVA: 0x0027FBFF File Offset: 0x0027DDFF
		public unsafe float ScreenSoftRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftRange) = value;
			}
		}

		// Token: 0x17006CD2 RID: 27858
		// (get) Token: 0x0601B226 RID: 111142 RVA: 0x0027FC10 File Offset: 0x0027DE10
		// (set) Token: 0x0601B227 RID: 111143 RVA: 0x0027FC20 File Offset: 0x0027DE20
		public unsafe float ScreenSoftOverflowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftOverflowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftOverflowDistance) = value;
			}
		}

		// Token: 0x17006CD3 RID: 27859
		// (get) Token: 0x0601B228 RID: 111144 RVA: 0x0027FC31 File Offset: 0x0027DE31
		// (set) Token: 0x0601B229 RID: 111145 RVA: 0x0027FC41 File Offset: 0x0027DE41
		public unsafe float ScreenSoftSunExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftSunExposure);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftSunExposure) = value;
			}
		}

		// Token: 0x17006CD4 RID: 27860
		// (get) Token: 0x0601B22A RID: 111146 RVA: 0x0027FC52 File Offset: 0x0027DE52
		// (set) Token: 0x0601B22B RID: 111147 RVA: 0x0027FC62 File Offset: 0x0027DE62
		public unsafe int ScreenSoftHighQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftHighQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_ScreenSoftHighQuality) = value;
			}
		}

		// Token: 0x17006CD5 RID: 27861
		// (get) Token: 0x0601B22C RID: 111148 RVA: 0x0027FC73 File Offset: 0x0027DE73
		// (set) Token: 0x0601B22D RID: 111149 RVA: 0x0027FC83 File Offset: 0x0027DE83
		public unsafe float MobileScreenSoftIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_MobileScreenSoftIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_MobileScreenSoftIntensity) = value;
			}
		}

		// Token: 0x17006CD6 RID: 27862
		// (get) Token: 0x0601B22E RID: 111150 RVA: 0x0027FC94 File Offset: 0x0027DE94
		// (set) Token: 0x0601B22F RID: 111151 RVA: 0x0027FCA4 File Offset: 0x0027DEA4
		public unsafe float MobileScreenSoftThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_MobileScreenSoftThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_MobileScreenSoftThreshold) = value;
			}
		}

		// Token: 0x17006CD7 RID: 27863
		// (get) Token: 0x0601B230 RID: 111152 RVA: 0x0027FCB5 File Offset: 0x0027DEB5
		// (set) Token: 0x0601B231 RID: 111153 RVA: 0x0027FCC5 File Offset: 0x0027DEC5
		public unsafe float MobileScreenSoftDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_MobileScreenSoftDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroScreenSoftSetting.__PropertyOffset_MobileScreenSoftDistance) = value;
			}
		}

		// Token: 0x0601B232 RID: 111154 RVA: 0x0027FCD6 File Offset: 0x0027DED6
		public FKuroScreenSoftSetting()
		{
		}

		// Token: 0x0601B233 RID: 111155 RVA: 0x0027FCE0 File Offset: 0x0027DEE0
		public FKuroScreenSoftSetting(bool bOverride_ScreenSoftIntensity, bool bOverride_ScreenSoftThreshold, bool bOverride_ScreenSoftDistance, bool bOverride_ScreenSoftSkyBloomCompensation, bool bOverride_ScreenSoftRange, bool bOverride_ScreenSoftOverflowDistance, bool bOverride_ScreenSoftSunExposure, bool bOverride_ScreenSoftHighQuality, bool bOverride_MobileScreenSoftIntensity, bool bOverride_MobileScreenSoftThreshold, bool bOverride_MobileScreenSoftDistance, float ScreenSoftIntensity, float ScreenSoftThreshold, float ScreenSoftDistance, float ScreenSoftSkyBloomCompensation, float ScreenSoftRange, float ScreenSoftOverflowDistance, float ScreenSoftSunExposure, int ScreenSoftHighQuality, float MobileScreenSoftIntensity, float MobileScreenSoftThreshold, float MobileScreenSoftDistance)
		{
			this.bOverride_ScreenSoftIntensity = bOverride_ScreenSoftIntensity;
			this.bOverride_ScreenSoftThreshold = bOverride_ScreenSoftThreshold;
			this.bOverride_ScreenSoftDistance = bOverride_ScreenSoftDistance;
			this.bOverride_ScreenSoftSkyBloomCompensation = bOverride_ScreenSoftSkyBloomCompensation;
			this.bOverride_ScreenSoftRange = bOverride_ScreenSoftRange;
			this.bOverride_ScreenSoftOverflowDistance = bOverride_ScreenSoftOverflowDistance;
			this.bOverride_ScreenSoftSunExposure = bOverride_ScreenSoftSunExposure;
			this.bOverride_ScreenSoftHighQuality = bOverride_ScreenSoftHighQuality;
			this.bOverride_MobileScreenSoftIntensity = bOverride_MobileScreenSoftIntensity;
			this.bOverride_MobileScreenSoftThreshold = bOverride_MobileScreenSoftThreshold;
			this.bOverride_MobileScreenSoftDistance = bOverride_MobileScreenSoftDistance;
			this.ScreenSoftIntensity = ScreenSoftIntensity;
			this.ScreenSoftThreshold = ScreenSoftThreshold;
			this.ScreenSoftDistance = ScreenSoftDistance;
			this.ScreenSoftSkyBloomCompensation = ScreenSoftSkyBloomCompensation;
			this.ScreenSoftRange = ScreenSoftRange;
			this.ScreenSoftOverflowDistance = ScreenSoftOverflowDistance;
			this.ScreenSoftSunExposure = ScreenSoftSunExposure;
			this.ScreenSoftHighQuality = ScreenSoftHighQuality;
			this.MobileScreenSoftIntensity = MobileScreenSoftIntensity;
			this.MobileScreenSoftThreshold = MobileScreenSoftThreshold;
			this.MobileScreenSoftDistance = MobileScreenSoftDistance;
		}

		// Token: 0x0601B234 RID: 111156 RVA: 0x0027FDA0 File Offset: 0x0027DFA0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroScreenSoftSetting.StaticStruct();
		}

		// Token: 0x0601B235 RID: 111157 RVA: 0x0027FDAC File Offset: 0x0027DFAC
		[NullableContext(2)]
		public FKuroScreenSoftSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B236 RID: 111158 RVA: 0x0027FDB6 File Offset: 0x0027DFB6
		public FKuroScreenSoftSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B237 RID: 111159 RVA: 0x0027FDC1 File Offset: 0x0027DFC1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroScreenSoftSetting(Pointer, false, true);
		}

		// Token: 0x0601B238 RID: 111160 RVA: 0x0027FDCB File Offset: 0x0027DFCB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroScreenSoftSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E9B5 RID: 59829
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenSoftSetting";

		// Token: 0x0400E9B6 RID: 59830
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E9B7 RID: 59831
		internal static int __PropertyOffset_bOverride_ScreenSoftIntensity;

		// Token: 0x0400E9B8 RID: 59832
		internal static byte __PropertyMask_bOverride_ScreenSoftIntensity;

		// Token: 0x0400E9B9 RID: 59833
		internal static int __PropertyOffset_bOverride_ScreenSoftThreshold;

		// Token: 0x0400E9BA RID: 59834
		internal static byte __PropertyMask_bOverride_ScreenSoftThreshold;

		// Token: 0x0400E9BB RID: 59835
		internal static int __PropertyOffset_bOverride_ScreenSoftDistance;

		// Token: 0x0400E9BC RID: 59836
		internal static byte __PropertyMask_bOverride_ScreenSoftDistance;

		// Token: 0x0400E9BD RID: 59837
		internal static int __PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation;

		// Token: 0x0400E9BE RID: 59838
		internal static byte __PropertyMask_bOverride_ScreenSoftSkyBloomCompensation;

		// Token: 0x0400E9BF RID: 59839
		internal static int __PropertyOffset_bOverride_ScreenSoftRange;

		// Token: 0x0400E9C0 RID: 59840
		internal static byte __PropertyMask_bOverride_ScreenSoftRange;

		// Token: 0x0400E9C1 RID: 59841
		internal static int __PropertyOffset_bOverride_ScreenSoftOverflowDistance;

		// Token: 0x0400E9C2 RID: 59842
		internal static byte __PropertyMask_bOverride_ScreenSoftOverflowDistance;

		// Token: 0x0400E9C3 RID: 59843
		internal static int __PropertyOffset_bOverride_ScreenSoftSunExposure;

		// Token: 0x0400E9C4 RID: 59844
		internal static byte __PropertyMask_bOverride_ScreenSoftSunExposure;

		// Token: 0x0400E9C5 RID: 59845
		internal static int __PropertyOffset_bOverride_ScreenSoftHighQuality;

		// Token: 0x0400E9C6 RID: 59846
		internal static byte __PropertyMask_bOverride_ScreenSoftHighQuality;

		// Token: 0x0400E9C7 RID: 59847
		internal static int __PropertyOffset_bOverride_MobileScreenSoftIntensity;

		// Token: 0x0400E9C8 RID: 59848
		internal static byte __PropertyMask_bOverride_MobileScreenSoftIntensity;

		// Token: 0x0400E9C9 RID: 59849
		internal static int __PropertyOffset_bOverride_MobileScreenSoftThreshold;

		// Token: 0x0400E9CA RID: 59850
		internal static byte __PropertyMask_bOverride_MobileScreenSoftThreshold;

		// Token: 0x0400E9CB RID: 59851
		internal static int __PropertyOffset_bOverride_MobileScreenSoftDistance;

		// Token: 0x0400E9CC RID: 59852
		internal static byte __PropertyMask_bOverride_MobileScreenSoftDistance;

		// Token: 0x0400E9CD RID: 59853
		internal static int __PropertyOffset_ScreenSoftIntensity;

		// Token: 0x0400E9CE RID: 59854
		internal static int __PropertyOffset_ScreenSoftThreshold;

		// Token: 0x0400E9CF RID: 59855
		internal static int __PropertyOffset_ScreenSoftDistance;

		// Token: 0x0400E9D0 RID: 59856
		internal static int __PropertyOffset_ScreenSoftSkyBloomCompensation;

		// Token: 0x0400E9D1 RID: 59857
		internal static int __PropertyOffset_ScreenSoftRange;

		// Token: 0x0400E9D2 RID: 59858
		internal static int __PropertyOffset_ScreenSoftOverflowDistance;

		// Token: 0x0400E9D3 RID: 59859
		internal static int __PropertyOffset_ScreenSoftSunExposure;

		// Token: 0x0400E9D4 RID: 59860
		internal static int __PropertyOffset_ScreenSoftHighQuality;

		// Token: 0x0400E9D5 RID: 59861
		internal static int __PropertyOffset_MobileScreenSoftIntensity;

		// Token: 0x0400E9D6 RID: 59862
		internal static int __PropertyOffset_MobileScreenSoftThreshold;

		// Token: 0x0400E9D7 RID: 59863
		internal static int __PropertyOffset_MobileScreenSoftDistance;
	}
}
