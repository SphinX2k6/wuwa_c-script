using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B75 RID: 7029
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMilkyWaySetting")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FKuroMilkyWaySetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A9E3 RID: 109027 RVA: 0x00273C6A File Offset: 0x00271E6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMilkyWaySetting._ScriptStructPtr != 0) ? FKuroMilkyWaySetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMilkyWaySetting", ref FKuroMilkyWaySetting._ScriptStructPtr);
		}

		// Token: 0x17006AE7 RID: 27367
		// (get) Token: 0x0601A9E4 RID: 109028 RVA: 0x00273C8E File Offset: 0x00271E8E
		// (set) Token: 0x0601A9E5 RID: 109029 RVA: 0x00273CA7 File Offset: 0x00271EA7
		public unsafe bool bOverride_MilkWayTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkWayTexture) & FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkWayTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkWayTexture) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkWayTexture) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkWayTexture) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkWayTexture : 0));
			}
		}

		// Token: 0x17006AE8 RID: 27368
		// (get) Token: 0x0601A9E6 RID: 109030 RVA: 0x00273CD7 File Offset: 0x00271ED7
		// (set) Token: 0x0601A9E7 RID: 109031 RVA: 0x00273CF0 File Offset: 0x00271EF0
		public unsafe bool bOverride_MilkWayStarTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkWayStarTexture) & FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkWayStarTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkWayStarTexture) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkWayStarTexture) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkWayStarTexture) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkWayStarTexture : 0));
			}
		}

		// Token: 0x17006AE9 RID: 27369
		// (get) Token: 0x0601A9E8 RID: 109032 RVA: 0x00273D20 File Offset: 0x00271F20
		// (set) Token: 0x0601A9E9 RID: 109033 RVA: 0x00273D39 File Offset: 0x00271F39
		public unsafe bool bOverride_DisortionTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionTexture) & FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionTexture) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionTexture) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionTexture) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionTexture : 0));
			}
		}

		// Token: 0x17006AEA RID: 27370
		// (get) Token: 0x0601A9EA RID: 109034 RVA: 0x00273D69 File Offset: 0x00271F69
		// (set) Token: 0x0601A9EB RID: 109035 RVA: 0x00273D82 File Offset: 0x00271F82
		public unsafe bool bOverride_MilkyWayTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayTint) & FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayTint) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayTint) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayTint) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayTint : 0));
			}
		}

		// Token: 0x17006AEB RID: 27371
		// (get) Token: 0x0601A9EC RID: 109036 RVA: 0x00273DB2 File Offset: 0x00271FB2
		// (set) Token: 0x0601A9ED RID: 109037 RVA: 0x00273DCB File Offset: 0x00271FCB
		public unsafe bool bOverride_MilkyWayBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayBrightness) & FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayBrightness) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayBrightness) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayBrightness) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayBrightness : 0));
			}
		}

		// Token: 0x17006AEC RID: 27372
		// (get) Token: 0x0601A9EE RID: 109038 RVA: 0x00273DFB File Offset: 0x00271FFB
		// (set) Token: 0x0601A9EF RID: 109039 RVA: 0x00273E14 File Offset: 0x00272014
		public unsafe bool bOverride_MilkyWayUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayUV) & FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayUV) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayUV) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayUV) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayUV : 0));
			}
		}

		// Token: 0x17006AED RID: 27373
		// (get) Token: 0x0601A9F0 RID: 109040 RVA: 0x00273E44 File Offset: 0x00272044
		// (set) Token: 0x0601A9F1 RID: 109041 RVA: 0x00273E5D File Offset: 0x0027205D
		public unsafe bool bOverride_StarTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarTint) & FKuroMilkyWaySetting.__PropertyMask_bOverride_StarTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarTint) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarTint) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_StarTint) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_StarTint : 0));
			}
		}

		// Token: 0x17006AEE RID: 27374
		// (get) Token: 0x0601A9F2 RID: 109042 RVA: 0x00273E8D File Offset: 0x0027208D
		// (set) Token: 0x0601A9F3 RID: 109043 RVA: 0x00273EA6 File Offset: 0x002720A6
		public unsafe bool bOverride_StarBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarBrightness) & FKuroMilkyWaySetting.__PropertyMask_bOverride_StarBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarBrightness) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarBrightness) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_StarBrightness) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_StarBrightness : 0));
			}
		}

		// Token: 0x17006AEF RID: 27375
		// (get) Token: 0x0601A9F4 RID: 109044 RVA: 0x00273ED6 File Offset: 0x002720D6
		// (set) Token: 0x0601A9F5 RID: 109045 RVA: 0x00273EEF File Offset: 0x002720EF
		public unsafe bool bOverride_StarUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarUV) & FKuroMilkyWaySetting.__PropertyMask_bOverride_StarUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarUV) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_StarUV) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_StarUV) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_StarUV : 0));
			}
		}

		// Token: 0x17006AF0 RID: 27376
		// (get) Token: 0x0601A9F6 RID: 109046 RVA: 0x00273F1F File Offset: 0x0027211F
		// (set) Token: 0x0601A9F7 RID: 109047 RVA: 0x00273F38 File Offset: 0x00272138
		public unsafe bool bOverride_DisortionStrength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionStrength) & FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionStrength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionStrength) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionStrength) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionStrength) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionStrength : 0));
			}
		}

		// Token: 0x17006AF1 RID: 27377
		// (get) Token: 0x0601A9F8 RID: 109048 RVA: 0x00273F68 File Offset: 0x00272168
		// (set) Token: 0x0601A9F9 RID: 109049 RVA: 0x00273F81 File Offset: 0x00272181
		public unsafe bool bOverride_DisortionUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionUV) & FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionUV) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_DisortionUV) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionUV) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_DisortionUV : 0));
			}
		}

		// Token: 0x17006AF2 RID: 27378
		// (get) Token: 0x0601A9FA RID: 109050 RVA: 0x00273FB1 File Offset: 0x002721B1
		// (set) Token: 0x0601A9FB RID: 109051 RVA: 0x00273FCA File Offset: 0x002721CA
		public unsafe bool bOverride_MilkyWayPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayPosition) & FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayPosition) = ((*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_bOverride_MilkyWayPosition) & ~FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayPosition) | (value ? FKuroMilkyWaySetting.__PropertyMask_bOverride_MilkyWayPosition : 0));
			}
		}

		// Token: 0x17006AF3 RID: 27379
		// (get) Token: 0x0601A9FC RID: 109052 RVA: 0x00273FFA File Offset: 0x002721FA
		// (set) Token: 0x0601A9FD RID: 109053 RVA: 0x0027400E File Offset: 0x0027220E
		public unsafe UTexture2D MilkWayTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMilkyWaySetting.__PropertyOffset_MilkWayTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMilkyWaySetting.__PropertyOffset_MilkWayTexture, value);
			}
		}

		// Token: 0x17006AF4 RID: 27380
		// (get) Token: 0x0601A9FE RID: 109054 RVA: 0x00274023 File Offset: 0x00272223
		// (set) Token: 0x0601A9FF RID: 109055 RVA: 0x00274037 File Offset: 0x00272237
		public unsafe UTexture2D MilkWayStarTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMilkyWaySetting.__PropertyOffset_MilkWayStarTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMilkyWaySetting.__PropertyOffset_MilkWayStarTexture, value);
			}
		}

		// Token: 0x17006AF5 RID: 27381
		// (get) Token: 0x0601AA00 RID: 109056 RVA: 0x0027404C File Offset: 0x0027224C
		// (set) Token: 0x0601AA01 RID: 109057 RVA: 0x00274060 File Offset: 0x00272260
		public unsafe UTexture2D DisortionTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMilkyWaySetting.__PropertyOffset_DisortionTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMilkyWaySetting.__PropertyOffset_DisortionTexture, value);
			}
		}

		// Token: 0x17006AF6 RID: 27382
		// (get) Token: 0x0601AA02 RID: 109058 RVA: 0x00274075 File Offset: 0x00272275
		// (set) Token: 0x0601AA03 RID: 109059 RVA: 0x00274089 File Offset: 0x00272289
		public unsafe FLinearColor MilkyWayTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayTint) = value;
			}
		}

		// Token: 0x17006AF7 RID: 27383
		// (get) Token: 0x0601AA04 RID: 109060 RVA: 0x0027409E File Offset: 0x0027229E
		// (set) Token: 0x0601AA05 RID: 109061 RVA: 0x002740AE File Offset: 0x002722AE
		public unsafe float MilkyWayBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayBrightness) = value;
			}
		}

		// Token: 0x17006AF8 RID: 27384
		// (get) Token: 0x0601AA06 RID: 109062 RVA: 0x002740BF File Offset: 0x002722BF
		// (set) Token: 0x0601AA07 RID: 109063 RVA: 0x002740D3 File Offset: 0x002722D3
		public unsafe FLinearColor MilkyWayUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayUV) = value;
			}
		}

		// Token: 0x17006AF9 RID: 27385
		// (get) Token: 0x0601AA08 RID: 109064 RVA: 0x002740E8 File Offset: 0x002722E8
		// (set) Token: 0x0601AA09 RID: 109065 RVA: 0x002740FC File Offset: 0x002722FC
		public unsafe FLinearColor StarTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_StarTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_StarTint) = value;
			}
		}

		// Token: 0x17006AFA RID: 27386
		// (get) Token: 0x0601AA0A RID: 109066 RVA: 0x00274111 File Offset: 0x00272311
		// (set) Token: 0x0601AA0B RID: 109067 RVA: 0x00274121 File Offset: 0x00272321
		public unsafe float StarBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_StarBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_StarBrightness) = value;
			}
		}

		// Token: 0x17006AFB RID: 27387
		// (get) Token: 0x0601AA0C RID: 109068 RVA: 0x00274132 File Offset: 0x00272332
		// (set) Token: 0x0601AA0D RID: 109069 RVA: 0x00274146 File Offset: 0x00272346
		public unsafe FLinearColor StarUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_StarUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_StarUV) = value;
			}
		}

		// Token: 0x17006AFC RID: 27388
		// (get) Token: 0x0601AA0E RID: 109070 RVA: 0x0027415B File Offset: 0x0027235B
		// (set) Token: 0x0601AA0F RID: 109071 RVA: 0x0027416B File Offset: 0x0027236B
		public unsafe float DisortionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_DisortionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_DisortionStrength) = value;
			}
		}

		// Token: 0x17006AFD RID: 27389
		// (get) Token: 0x0601AA10 RID: 109072 RVA: 0x0027417C File Offset: 0x0027237C
		// (set) Token: 0x0601AA11 RID: 109073 RVA: 0x00274190 File Offset: 0x00272390
		public unsafe FLinearColor DisortionUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_DisortionUV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_DisortionUV) = value;
			}
		}

		// Token: 0x17006AFE RID: 27390
		// (get) Token: 0x0601AA12 RID: 109074 RVA: 0x002741A5 File Offset: 0x002723A5
		// (set) Token: 0x0601AA13 RID: 109075 RVA: 0x002741B9 File Offset: 0x002723B9
		public unsafe FVector MilkyWayPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMilkyWaySetting.__PropertyOffset_MilkyWayPosition) = value;
			}
		}

		// Token: 0x0601AA14 RID: 109076 RVA: 0x002741CE File Offset: 0x002723CE
		public FKuroMilkyWaySetting()
		{
		}

		// Token: 0x0601AA15 RID: 109077 RVA: 0x002741D8 File Offset: 0x002723D8
		[NullableContext(1)]
		public FKuroMilkyWaySetting(bool bOverride_MilkWayTexture, bool bOverride_MilkWayStarTexture, bool bOverride_DisortionTexture, bool bOverride_MilkyWayTint, bool bOverride_MilkyWayBrightness, bool bOverride_MilkyWayUV, bool bOverride_StarTint, bool bOverride_StarBrightness, bool bOverride_StarUV, bool bOverride_DisortionStrength, bool bOverride_DisortionUV, bool bOverride_MilkyWayPosition, UTexture2D MilkWayTexture, UTexture2D MilkWayStarTexture, UTexture2D DisortionTexture, FLinearColor MilkyWayTint, float MilkyWayBrightness, FLinearColor MilkyWayUV, FLinearColor StarTint, float StarBrightness, FLinearColor StarUV, float DisortionStrength, FLinearColor DisortionUV, FVector MilkyWayPosition)
		{
			this.bOverride_MilkWayTexture = bOverride_MilkWayTexture;
			this.bOverride_MilkWayStarTexture = bOverride_MilkWayStarTexture;
			this.bOverride_DisortionTexture = bOverride_DisortionTexture;
			this.bOverride_MilkyWayTint = bOverride_MilkyWayTint;
			this.bOverride_MilkyWayBrightness = bOverride_MilkyWayBrightness;
			this.bOverride_MilkyWayUV = bOverride_MilkyWayUV;
			this.bOverride_StarTint = bOverride_StarTint;
			this.bOverride_StarBrightness = bOverride_StarBrightness;
			this.bOverride_StarUV = bOverride_StarUV;
			this.bOverride_DisortionStrength = bOverride_DisortionStrength;
			this.bOverride_DisortionUV = bOverride_DisortionUV;
			this.bOverride_MilkyWayPosition = bOverride_MilkyWayPosition;
			this.MilkWayTexture = MilkWayTexture;
			this.MilkWayStarTexture = MilkWayStarTexture;
			this.DisortionTexture = DisortionTexture;
			this.MilkyWayTint = MilkyWayTint;
			this.MilkyWayBrightness = MilkyWayBrightness;
			this.MilkyWayUV = MilkyWayUV;
			this.StarTint = StarTint;
			this.StarBrightness = StarBrightness;
			this.StarUV = StarUV;
			this.DisortionStrength = DisortionStrength;
			this.DisortionUV = DisortionUV;
			this.MilkyWayPosition = MilkyWayPosition;
		}

		// Token: 0x0601AA16 RID: 109078 RVA: 0x002742A8 File Offset: 0x002724A8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMilkyWaySetting.StaticStruct();
		}

		// Token: 0x0601AA17 RID: 109079 RVA: 0x002742B4 File Offset: 0x002724B4
		public FKuroMilkyWaySetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AA18 RID: 109080 RVA: 0x002742BE File Offset: 0x002724BE
		public FKuroMilkyWaySetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AA19 RID: 109081 RVA: 0x002742C9 File Offset: 0x002724C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMilkyWaySetting(Pointer, false, true);
		}

		// Token: 0x0601AA1A RID: 109082 RVA: 0x002742D3 File Offset: 0x002724D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMilkyWaySetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E675 RID: 58997
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMilkyWaySetting";

		// Token: 0x0400E676 RID: 58998
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E677 RID: 58999
		internal static int __PropertyOffset_bOverride_MilkWayTexture;

		// Token: 0x0400E678 RID: 59000
		internal static byte __PropertyMask_bOverride_MilkWayTexture;

		// Token: 0x0400E679 RID: 59001
		internal static int __PropertyOffset_bOverride_MilkWayStarTexture;

		// Token: 0x0400E67A RID: 59002
		internal static byte __PropertyMask_bOverride_MilkWayStarTexture;

		// Token: 0x0400E67B RID: 59003
		internal static int __PropertyOffset_bOverride_DisortionTexture;

		// Token: 0x0400E67C RID: 59004
		internal static byte __PropertyMask_bOverride_DisortionTexture;

		// Token: 0x0400E67D RID: 59005
		internal static int __PropertyOffset_bOverride_MilkyWayTint;

		// Token: 0x0400E67E RID: 59006
		internal static byte __PropertyMask_bOverride_MilkyWayTint;

		// Token: 0x0400E67F RID: 59007
		internal static int __PropertyOffset_bOverride_MilkyWayBrightness;

		// Token: 0x0400E680 RID: 59008
		internal static byte __PropertyMask_bOverride_MilkyWayBrightness;

		// Token: 0x0400E681 RID: 59009
		internal static int __PropertyOffset_bOverride_MilkyWayUV;

		// Token: 0x0400E682 RID: 59010
		internal static byte __PropertyMask_bOverride_MilkyWayUV;

		// Token: 0x0400E683 RID: 59011
		internal static int __PropertyOffset_bOverride_StarTint;

		// Token: 0x0400E684 RID: 59012
		internal static byte __PropertyMask_bOverride_StarTint;

		// Token: 0x0400E685 RID: 59013
		internal static int __PropertyOffset_bOverride_StarBrightness;

		// Token: 0x0400E686 RID: 59014
		internal static byte __PropertyMask_bOverride_StarBrightness;

		// Token: 0x0400E687 RID: 59015
		internal static int __PropertyOffset_bOverride_StarUV;

		// Token: 0x0400E688 RID: 59016
		internal static byte __PropertyMask_bOverride_StarUV;

		// Token: 0x0400E689 RID: 59017
		internal static int __PropertyOffset_bOverride_DisortionStrength;

		// Token: 0x0400E68A RID: 59018
		internal static byte __PropertyMask_bOverride_DisortionStrength;

		// Token: 0x0400E68B RID: 59019
		internal static int __PropertyOffset_bOverride_DisortionUV;

		// Token: 0x0400E68C RID: 59020
		internal static byte __PropertyMask_bOverride_DisortionUV;

		// Token: 0x0400E68D RID: 59021
		internal static int __PropertyOffset_bOverride_MilkyWayPosition;

		// Token: 0x0400E68E RID: 59022
		internal static byte __PropertyMask_bOverride_MilkyWayPosition;

		// Token: 0x0400E68F RID: 59023
		internal static int __PropertyOffset_MilkWayTexture;

		// Token: 0x0400E690 RID: 59024
		internal static int __PropertyOffset_MilkWayStarTexture;

		// Token: 0x0400E691 RID: 59025
		internal static int __PropertyOffset_DisortionTexture;

		// Token: 0x0400E692 RID: 59026
		internal static int __PropertyOffset_MilkyWayTint;

		// Token: 0x0400E693 RID: 59027
		internal static int __PropertyOffset_MilkyWayBrightness;

		// Token: 0x0400E694 RID: 59028
		internal static int __PropertyOffset_MilkyWayUV;

		// Token: 0x0400E695 RID: 59029
		internal static int __PropertyOffset_StarTint;

		// Token: 0x0400E696 RID: 59030
		internal static int __PropertyOffset_StarBrightness;

		// Token: 0x0400E697 RID: 59031
		internal static int __PropertyOffset_StarUV;

		// Token: 0x0400E698 RID: 59032
		internal static int __PropertyOffset_DisortionStrength;

		// Token: 0x0400E699 RID: 59033
		internal static int __PropertyOffset_DisortionUV;

		// Token: 0x0400E69A RID: 59034
		internal static int __PropertyOffset_MilkyWayPosition;
	}
}
