using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C0F RID: 3087
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GPUSpriteResourceData")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 352)]
	public class FGPUSpriteResourceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009BC6 RID: 39878 RVA: 0x000DD818 File Offset: 0x000DBA18
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGPUSpriteResourceData._ScriptStructPtr != 0) ? FGPUSpriteResourceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.GPUSpriteResourceData", ref FGPUSpriteResourceData._ScriptStructPtr);
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06009BC7 RID: 39879 RVA: 0x000DD83C File Offset: 0x000DBA3C
		// (set) Token: 0x06009BC8 RID: 39880 RVA: 0x000DD87F File Offset: 0x000DBA7F
		public TArray<FColor> QuantizedColorSamples
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._QuantizedColorSamples) == null)
				{
					result = (this._QuantizedColorSamples = new TArray<FColor>(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_QuantizedColorSamples, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QuantizedColorSamples.CopyAssign(value);
			}
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x06009BC9 RID: 39881 RVA: 0x000DD890 File Offset: 0x000DBA90
		// (set) Token: 0x06009BCA RID: 39882 RVA: 0x000DD8D3 File Offset: 0x000DBAD3
		public TArray<FColor> QuantizedMiscSamples
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._QuantizedMiscSamples) == null)
				{
					result = (this._QuantizedMiscSamples = new TArray<FColor>(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_QuantizedMiscSamples, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QuantizedMiscSamples.CopyAssign(value);
			}
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x06009BCB RID: 39883 RVA: 0x000DD8E4 File Offset: 0x000DBAE4
		// (set) Token: 0x06009BCC RID: 39884 RVA: 0x000DD927 File Offset: 0x000DBB27
		public TArray<FColor> QuantizedSimulationAttrSamples
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._QuantizedSimulationAttrSamples) == null)
				{
					result = (this._QuantizedSimulationAttrSamples = new TArray<FColor>(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_QuantizedSimulationAttrSamples, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QuantizedSimulationAttrSamples.CopyAssign(value);
			}
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x06009BCD RID: 39885 RVA: 0x000DD935 File Offset: 0x000DBB35
		// (set) Token: 0x06009BCE RID: 39886 RVA: 0x000DD949 File Offset: 0x000DBB49
		public unsafe FVector4 ColorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ColorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ColorScale) = value;
			}
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x000DD95E File Offset: 0x000DBB5E
		// (set) Token: 0x06009BD0 RID: 39888 RVA: 0x000DD972 File Offset: 0x000DBB72
		public unsafe FVector4 ColorBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ColorBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ColorBias) = value;
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x000DD987 File Offset: 0x000DBB87
		// (set) Token: 0x06009BD2 RID: 39890 RVA: 0x000DD99B File Offset: 0x000DBB9B
		public unsafe FVector4 MiscScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MiscScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MiscScale) = value;
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x06009BD3 RID: 39891 RVA: 0x000DD9B0 File Offset: 0x000DBBB0
		// (set) Token: 0x06009BD4 RID: 39892 RVA: 0x000DD9C4 File Offset: 0x000DBBC4
		public unsafe FVector4 MiscBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MiscBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MiscBias) = value;
			}
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x000DD9D9 File Offset: 0x000DBBD9
		// (set) Token: 0x06009BD6 RID: 39894 RVA: 0x000DD9ED File Offset: 0x000DBBED
		public unsafe FVector4 SimulationAttrCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SimulationAttrCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SimulationAttrCurveScale) = value;
			}
		}

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x06009BD7 RID: 39895 RVA: 0x000DDA02 File Offset: 0x000DBC02
		// (set) Token: 0x06009BD8 RID: 39896 RVA: 0x000DDA16 File Offset: 0x000DBC16
		public unsafe FVector4 SimulationAttrCurveBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SimulationAttrCurveBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SimulationAttrCurveBias) = value;
			}
		}

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x06009BD9 RID: 39897 RVA: 0x000DDA2B File Offset: 0x000DBC2B
		// (set) Token: 0x06009BDA RID: 39898 RVA: 0x000DDA3F File Offset: 0x000DBC3F
		public unsafe FVector4 SubImageSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SubImageSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SubImageSize) = value;
			}
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x06009BDB RID: 39899 RVA: 0x000DDA54 File Offset: 0x000DBC54
		// (set) Token: 0x06009BDC RID: 39900 RVA: 0x000DDA68 File Offset: 0x000DBC68
		public unsafe FVector4 SizeBySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SizeBySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_SizeBySpeed) = value;
			}
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x06009BDD RID: 39901 RVA: 0x000DDA7D File Offset: 0x000DBC7D
		// (set) Token: 0x06009BDE RID: 39902 RVA: 0x000DDA91 File Offset: 0x000DBC91
		public unsafe FVector ConstantAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ConstantAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ConstantAcceleration) = value;
			}
		}

		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x06009BDF RID: 39903 RVA: 0x000DDAA6 File Offset: 0x000DBCA6
		// (set) Token: 0x06009BE0 RID: 39904 RVA: 0x000DDABA File Offset: 0x000DBCBA
		public unsafe FVector OrbitOffsetBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitOffsetBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitOffsetBase) = value;
			}
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x06009BE1 RID: 39905 RVA: 0x000DDACF File Offset: 0x000DBCCF
		// (set) Token: 0x06009BE2 RID: 39906 RVA: 0x000DDAE3 File Offset: 0x000DBCE3
		public unsafe FVector OrbitOffsetRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitOffsetRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitOffsetRange) = value;
			}
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x06009BE3 RID: 39907 RVA: 0x000DDAF8 File Offset: 0x000DBCF8
		// (set) Token: 0x06009BE4 RID: 39908 RVA: 0x000DDB0C File Offset: 0x000DBD0C
		public unsafe FVector OrbitFrequencyBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitFrequencyBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitFrequencyBase) = value;
			}
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x06009BE5 RID: 39909 RVA: 0x000DDB21 File Offset: 0x000DBD21
		// (set) Token: 0x06009BE6 RID: 39910 RVA: 0x000DDB35 File Offset: 0x000DBD35
		public unsafe FVector OrbitFrequencyRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitFrequencyRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitFrequencyRange) = value;
			}
		}

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x06009BE7 RID: 39911 RVA: 0x000DDB4A File Offset: 0x000DBD4A
		// (set) Token: 0x06009BE8 RID: 39912 RVA: 0x000DDB5E File Offset: 0x000DBD5E
		public unsafe FVector OrbitPhaseBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitPhaseBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitPhaseBase) = value;
			}
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x06009BE9 RID: 39913 RVA: 0x000DDB73 File Offset: 0x000DBD73
		// (set) Token: 0x06009BEA RID: 39914 RVA: 0x000DDB87 File Offset: 0x000DBD87
		public unsafe FVector OrbitPhaseRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitPhaseRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OrbitPhaseRange) = value;
			}
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x000DDB9C File Offset: 0x000DBD9C
		// (set) Token: 0x06009BEC RID: 39916 RVA: 0x000DDBAC File Offset: 0x000DBDAC
		public unsafe float GlobalVectorFieldScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_GlobalVectorFieldScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_GlobalVectorFieldScale) = value;
			}
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x06009BED RID: 39917 RVA: 0x000DDBBD File Offset: 0x000DBDBD
		// (set) Token: 0x06009BEE RID: 39918 RVA: 0x000DDBCD File Offset: 0x000DBDCD
		public unsafe float GlobalVectorFieldTightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_GlobalVectorFieldTightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_GlobalVectorFieldTightness) = value;
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x06009BEF RID: 39919 RVA: 0x000DDBDE File Offset: 0x000DBDDE
		// (set) Token: 0x06009BF0 RID: 39920 RVA: 0x000DDBEE File Offset: 0x000DBDEE
		public unsafe float PerParticleVectorFieldScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_PerParticleVectorFieldScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_PerParticleVectorFieldScale) = value;
			}
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x06009BF1 RID: 39921 RVA: 0x000DDBFF File Offset: 0x000DBDFF
		// (set) Token: 0x06009BF2 RID: 39922 RVA: 0x000DDC0F File Offset: 0x000DBE0F
		public unsafe float PerParticleVectorFieldBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_PerParticleVectorFieldBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_PerParticleVectorFieldBias) = value;
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x06009BF3 RID: 39923 RVA: 0x000DDC20 File Offset: 0x000DBE20
		// (set) Token: 0x06009BF4 RID: 39924 RVA: 0x000DDC30 File Offset: 0x000DBE30
		public unsafe float DragCoefficientScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_DragCoefficientScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_DragCoefficientScale) = value;
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x06009BF5 RID: 39925 RVA: 0x000DDC41 File Offset: 0x000DBE41
		// (set) Token: 0x06009BF6 RID: 39926 RVA: 0x000DDC51 File Offset: 0x000DBE51
		public unsafe float DragCoefficientBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_DragCoefficientBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_DragCoefficientBias) = value;
			}
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x06009BF7 RID: 39927 RVA: 0x000DDC62 File Offset: 0x000DBE62
		// (set) Token: 0x06009BF8 RID: 39928 RVA: 0x000DDC72 File Offset: 0x000DBE72
		public unsafe float ResilienceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ResilienceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ResilienceScale) = value;
			}
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x06009BF9 RID: 39929 RVA: 0x000DDC83 File Offset: 0x000DBE83
		// (set) Token: 0x06009BFA RID: 39930 RVA: 0x000DDC93 File Offset: 0x000DBE93
		public unsafe float ResilienceBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ResilienceBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ResilienceBias) = value;
			}
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x06009BFB RID: 39931 RVA: 0x000DDCA4 File Offset: 0x000DBEA4
		// (set) Token: 0x06009BFC RID: 39932 RVA: 0x000DDCB4 File Offset: 0x000DBEB4
		public unsafe float CollisionRadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRadiusScale) = value;
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x06009BFD RID: 39933 RVA: 0x000DDCC5 File Offset: 0x000DBEC5
		// (set) Token: 0x06009BFE RID: 39934 RVA: 0x000DDCD5 File Offset: 0x000DBED5
		public unsafe float CollisionRadiusBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRadiusBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRadiusBias) = value;
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x06009BFF RID: 39935 RVA: 0x000DDCE6 File Offset: 0x000DBEE6
		// (set) Token: 0x06009C00 RID: 39936 RVA: 0x000DDCF6 File Offset: 0x000DBEF6
		public unsafe float CollisionTimeBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionTimeBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionTimeBias) = value;
			}
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x06009C01 RID: 39937 RVA: 0x000DDD07 File Offset: 0x000DBF07
		// (set) Token: 0x06009C02 RID: 39938 RVA: 0x000DDD17 File Offset: 0x000DBF17
		public unsafe float CollisionRandomSpread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRandomSpread);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRandomSpread) = value;
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x06009C03 RID: 39939 RVA: 0x000DDD28 File Offset: 0x000DBF28
		// (set) Token: 0x06009C04 RID: 39940 RVA: 0x000DDD38 File Offset: 0x000DBF38
		public unsafe float CollisionRandomDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRandomDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CollisionRandomDistribution) = value;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x06009C05 RID: 39941 RVA: 0x000DDD49 File Offset: 0x000DBF49
		// (set) Token: 0x06009C06 RID: 39942 RVA: 0x000DDD59 File Offset: 0x000DBF59
		public unsafe float OneMinusFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OneMinusFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_OneMinusFriction) = value;
			}
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x06009C07 RID: 39943 RVA: 0x000DDD6A File Offset: 0x000DBF6A
		// (set) Token: 0x06009C08 RID: 39944 RVA: 0x000DDD7A File Offset: 0x000DBF7A
		public unsafe float RotationRateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_RotationRateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_RotationRateScale) = value;
			}
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x06009C09 RID: 39945 RVA: 0x000DDD8B File Offset: 0x000DBF8B
		// (set) Token: 0x06009C0A RID: 39946 RVA: 0x000DDD9B File Offset: 0x000DBF9B
		public unsafe float CameraMotionBlurAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CameraMotionBlurAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_CameraMotionBlurAmount) = value;
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x06009C0B RID: 39947 RVA: 0x000DDDAC File Offset: 0x000DBFAC
		// (set) Token: 0x06009C0C RID: 39948 RVA: 0x000DDDC0 File Offset: 0x000DBFC0
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleScreenAlignment> ScreenAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ScreenAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_ScreenAlignment) = value;
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x06009C0D RID: 39949 RVA: 0x000DDDD5 File Offset: 0x000DBFD5
		// (set) Token: 0x06009C0E RID: 39950 RVA: 0x000DDDE9 File Offset: 0x000DBFE9
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleAxisLock> LockAxisFlag
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_LockAxisFlag);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_LockAxisFlag) = value;
			}
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x06009C0F RID: 39951 RVA: 0x000DDDFE File Offset: 0x000DBFFE
		// (set) Token: 0x06009C10 RID: 39952 RVA: 0x000DDE12 File Offset: 0x000DC012
		public unsafe FVector2D PivotOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_PivotOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_PivotOffset) = value;
			}
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x06009C11 RID: 39953 RVA: 0x000DDE27 File Offset: 0x000DC027
		// (set) Token: 0x06009C12 RID: 39954 RVA: 0x000DDE40 File Offset: 0x000DC040
		public unsafe bool bRemoveHMDRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_bRemoveHMDRoll) & FGPUSpriteResourceData.__PropertyMask_bRemoveHMDRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_bRemoveHMDRoll) = ((*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_bRemoveHMDRoll) & ~FGPUSpriteResourceData.__PropertyMask_bRemoveHMDRoll) | (value ? FGPUSpriteResourceData.__PropertyMask_bRemoveHMDRoll : 0));
			}
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x06009C13 RID: 39955 RVA: 0x000DDE70 File Offset: 0x000DC070
		// (set) Token: 0x06009C14 RID: 39956 RVA: 0x000DDE80 File Offset: 0x000DC080
		public unsafe float MinFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MinFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MinFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x06009C15 RID: 39957 RVA: 0x000DDE91 File Offset: 0x000DC091
		// (set) Token: 0x06009C16 RID: 39958 RVA: 0x000DDEA1 File Offset: 0x000DC0A1
		public unsafe float MaxFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MaxFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGPUSpriteResourceData.__PropertyOffset_MaxFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x000DDEB2 File Offset: 0x000DC0B2
		public FGPUSpriteResourceData()
		{
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x000DDEBC File Offset: 0x000DC0BC
		public FGPUSpriteResourceData(TArray<FColor> QuantizedColorSamples, TArray<FColor> QuantizedMiscSamples, TArray<FColor> QuantizedSimulationAttrSamples, FVector4 ColorScale, FVector4 ColorBias, FVector4 MiscScale, FVector4 MiscBias, FVector4 SimulationAttrCurveScale, FVector4 SimulationAttrCurveBias, FVector4 SubImageSize, FVector4 SizeBySpeed, FVector ConstantAcceleration, FVector OrbitOffsetBase, FVector OrbitOffsetRange, FVector OrbitFrequencyBase, FVector OrbitFrequencyRange, FVector OrbitPhaseBase, FVector OrbitPhaseRange, float GlobalVectorFieldScale, float GlobalVectorFieldTightness, float PerParticleVectorFieldScale, float PerParticleVectorFieldBias, float DragCoefficientScale, float DragCoefficientBias, float ResilienceScale, float ResilienceBias, float CollisionRadiusScale, float CollisionRadiusBias, float CollisionTimeBias, float CollisionRandomSpread, float CollisionRandomDistribution, float OneMinusFriction, float RotationRateScale, float CameraMotionBlurAmount, [Nullable(0)] TEnumAsByte<EParticleScreenAlignment> ScreenAlignment, [Nullable(0)] TEnumAsByte<EParticleAxisLock> LockAxisFlag, FVector2D PivotOffset, bool bRemoveHMDRoll, float MinFacingCameraBlendDistance, float MaxFacingCameraBlendDistance)
		{
			this.QuantizedColorSamples = QuantizedColorSamples;
			this.QuantizedMiscSamples = QuantizedMiscSamples;
			this.QuantizedSimulationAttrSamples = QuantizedSimulationAttrSamples;
			this.ColorScale = ColorScale;
			this.ColorBias = ColorBias;
			this.MiscScale = MiscScale;
			this.MiscBias = MiscBias;
			this.SimulationAttrCurveScale = SimulationAttrCurveScale;
			this.SimulationAttrCurveBias = SimulationAttrCurveBias;
			this.SubImageSize = SubImageSize;
			this.SizeBySpeed = SizeBySpeed;
			this.ConstantAcceleration = ConstantAcceleration;
			this.OrbitOffsetBase = OrbitOffsetBase;
			this.OrbitOffsetRange = OrbitOffsetRange;
			this.OrbitFrequencyBase = OrbitFrequencyBase;
			this.OrbitFrequencyRange = OrbitFrequencyRange;
			this.OrbitPhaseBase = OrbitPhaseBase;
			this.OrbitPhaseRange = OrbitPhaseRange;
			this.GlobalVectorFieldScale = GlobalVectorFieldScale;
			this.GlobalVectorFieldTightness = GlobalVectorFieldTightness;
			this.PerParticleVectorFieldScale = PerParticleVectorFieldScale;
			this.PerParticleVectorFieldBias = PerParticleVectorFieldBias;
			this.DragCoefficientScale = DragCoefficientScale;
			this.DragCoefficientBias = DragCoefficientBias;
			this.ResilienceScale = ResilienceScale;
			this.ResilienceBias = ResilienceBias;
			this.CollisionRadiusScale = CollisionRadiusScale;
			this.CollisionRadiusBias = CollisionRadiusBias;
			this.CollisionTimeBias = CollisionTimeBias;
			this.CollisionRandomSpread = CollisionRandomSpread;
			this.CollisionRandomDistribution = CollisionRandomDistribution;
			this.OneMinusFriction = OneMinusFriction;
			this.RotationRateScale = RotationRateScale;
			this.CameraMotionBlurAmount = CameraMotionBlurAmount;
			this.ScreenAlignment = ScreenAlignment;
			this.LockAxisFlag = LockAxisFlag;
			this.PivotOffset = PivotOffset;
			this.bRemoveHMDRoll = bRemoveHMDRoll;
			this.MinFacingCameraBlendDistance = MinFacingCameraBlendDistance;
			this.MaxFacingCameraBlendDistance = MaxFacingCameraBlendDistance;
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x000DE00C File Offset: 0x000DC20C
		protected override IntPtr GetUStructPtr()
		{
			return FGPUSpriteResourceData.StaticStruct();
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x000DE018 File Offset: 0x000DC218
		[NullableContext(2)]
		public FGPUSpriteResourceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009C1B RID: 39963 RVA: 0x000DE022 File Offset: 0x000DC222
		public FGPUSpriteResourceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009C1C RID: 39964 RVA: 0x000DE02D File Offset: 0x000DC22D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGPUSpriteResourceData(Pointer, false, true);
		}

		// Token: 0x06009C1D RID: 39965 RVA: 0x000DE037 File Offset: 0x000DC237
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGPUSpriteResourceData(Pointer, MemoryOwner);
		}

		// Token: 0x04005602 RID: 22018
		public const string __ObjectPath = "/Script/Engine.GPUSpriteResourceData";

		// Token: 0x04005603 RID: 22019
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005604 RID: 22020
		internal static int __PropertyOffset_QuantizedColorSamples;

		// Token: 0x04005605 RID: 22021
		[Nullable(2)]
		private TArray<FColor> _QuantizedColorSamples;

		// Token: 0x04005606 RID: 22022
		internal static int __PropertyOffset_QuantizedMiscSamples;

		// Token: 0x04005607 RID: 22023
		[Nullable(2)]
		private TArray<FColor> _QuantizedMiscSamples;

		// Token: 0x04005608 RID: 22024
		internal static int __PropertyOffset_QuantizedSimulationAttrSamples;

		// Token: 0x04005609 RID: 22025
		[Nullable(2)]
		private TArray<FColor> _QuantizedSimulationAttrSamples;

		// Token: 0x0400560A RID: 22026
		internal static int __PropertyOffset_ColorScale;

		// Token: 0x0400560B RID: 22027
		internal static int __PropertyOffset_ColorBias;

		// Token: 0x0400560C RID: 22028
		internal static int __PropertyOffset_MiscScale;

		// Token: 0x0400560D RID: 22029
		internal static int __PropertyOffset_MiscBias;

		// Token: 0x0400560E RID: 22030
		internal static int __PropertyOffset_SimulationAttrCurveScale;

		// Token: 0x0400560F RID: 22031
		internal static int __PropertyOffset_SimulationAttrCurveBias;

		// Token: 0x04005610 RID: 22032
		internal static int __PropertyOffset_SubImageSize;

		// Token: 0x04005611 RID: 22033
		internal static int __PropertyOffset_SizeBySpeed;

		// Token: 0x04005612 RID: 22034
		internal static int __PropertyOffset_ConstantAcceleration;

		// Token: 0x04005613 RID: 22035
		internal static int __PropertyOffset_OrbitOffsetBase;

		// Token: 0x04005614 RID: 22036
		internal static int __PropertyOffset_OrbitOffsetRange;

		// Token: 0x04005615 RID: 22037
		internal static int __PropertyOffset_OrbitFrequencyBase;

		// Token: 0x04005616 RID: 22038
		internal static int __PropertyOffset_OrbitFrequencyRange;

		// Token: 0x04005617 RID: 22039
		internal static int __PropertyOffset_OrbitPhaseBase;

		// Token: 0x04005618 RID: 22040
		internal static int __PropertyOffset_OrbitPhaseRange;

		// Token: 0x04005619 RID: 22041
		internal static int __PropertyOffset_GlobalVectorFieldScale;

		// Token: 0x0400561A RID: 22042
		internal static int __PropertyOffset_GlobalVectorFieldTightness;

		// Token: 0x0400561B RID: 22043
		internal static int __PropertyOffset_PerParticleVectorFieldScale;

		// Token: 0x0400561C RID: 22044
		internal static int __PropertyOffset_PerParticleVectorFieldBias;

		// Token: 0x0400561D RID: 22045
		internal static int __PropertyOffset_DragCoefficientScale;

		// Token: 0x0400561E RID: 22046
		internal static int __PropertyOffset_DragCoefficientBias;

		// Token: 0x0400561F RID: 22047
		internal static int __PropertyOffset_ResilienceScale;

		// Token: 0x04005620 RID: 22048
		internal static int __PropertyOffset_ResilienceBias;

		// Token: 0x04005621 RID: 22049
		internal static int __PropertyOffset_CollisionRadiusScale;

		// Token: 0x04005622 RID: 22050
		internal static int __PropertyOffset_CollisionRadiusBias;

		// Token: 0x04005623 RID: 22051
		internal static int __PropertyOffset_CollisionTimeBias;

		// Token: 0x04005624 RID: 22052
		internal static int __PropertyOffset_CollisionRandomSpread;

		// Token: 0x04005625 RID: 22053
		internal static int __PropertyOffset_CollisionRandomDistribution;

		// Token: 0x04005626 RID: 22054
		internal static int __PropertyOffset_OneMinusFriction;

		// Token: 0x04005627 RID: 22055
		internal static int __PropertyOffset_RotationRateScale;

		// Token: 0x04005628 RID: 22056
		internal static int __PropertyOffset_CameraMotionBlurAmount;

		// Token: 0x04005629 RID: 22057
		internal static int __PropertyOffset_ScreenAlignment;

		// Token: 0x0400562A RID: 22058
		internal static int __PropertyOffset_LockAxisFlag;

		// Token: 0x0400562B RID: 22059
		internal static int __PropertyOffset_PivotOffset;

		// Token: 0x0400562C RID: 22060
		internal static int __PropertyOffset_bRemoveHMDRoll;

		// Token: 0x0400562D RID: 22061
		internal static byte __PropertyMask_bRemoveHMDRoll;

		// Token: 0x0400562E RID: 22062
		internal static int __PropertyOffset_MinFacingCameraBlendDistance;

		// Token: 0x0400562F RID: 22063
		internal static int __PropertyOffset_MaxFacingCameraBlendDistance;
	}
}
