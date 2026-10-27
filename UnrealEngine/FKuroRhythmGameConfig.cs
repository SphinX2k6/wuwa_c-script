using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C4C RID: 7244
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameConfig")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FKuroRhythmGameConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C0E0 RID: 114912 RVA: 0x002949B6 File Offset: 0x00292BB6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameConfig._ScriptStructPtr != 0) ? FKuroRhythmGameConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameConfig", ref FKuroRhythmGameConfig._ScriptStructPtr);
		}

		// Token: 0x17007166 RID: 29030
		// (get) Token: 0x0601C0E1 RID: 114913 RVA: 0x002949DA File Offset: 0x00292BDA
		// (set) Token: 0x0601C0E2 RID: 114914 RVA: 0x002949EA File Offset: 0x00292BEA
		public unsafe float GlobalTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_GlobalTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_GlobalTimeOffset) = value;
			}
		}

		// Token: 0x17007167 RID: 29031
		// (get) Token: 0x0601C0E3 RID: 114915 RVA: 0x002949FB File Offset: 0x00292BFB
		// (set) Token: 0x0601C0E4 RID: 114916 RVA: 0x00294A0B File Offset: 0x00292C0B
		public unsafe int ScorePerfect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScorePerfect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScorePerfect) = value;
			}
		}

		// Token: 0x17007168 RID: 29032
		// (get) Token: 0x0601C0E5 RID: 114917 RVA: 0x00294A1C File Offset: 0x00292C1C
		// (set) Token: 0x0601C0E6 RID: 114918 RVA: 0x00294A2C File Offset: 0x00292C2C
		public unsafe int ScoreGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGreat) = value;
			}
		}

		// Token: 0x17007169 RID: 29033
		// (get) Token: 0x0601C0E7 RID: 114919 RVA: 0x00294A3D File Offset: 0x00292C3D
		// (set) Token: 0x0601C0E8 RID: 114920 RVA: 0x00294A4D File Offset: 0x00292C4D
		public unsafe int ScoreGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGood) = value;
			}
		}

		// Token: 0x1700716A RID: 29034
		// (get) Token: 0x0601C0E9 RID: 114921 RVA: 0x00294A5E File Offset: 0x00292C5E
		// (set) Token: 0x0601C0EA RID: 114922 RVA: 0x00294A6E File Offset: 0x00292C6E
		public unsafe int ScoreBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreBad) = value;
			}
		}

		// Token: 0x1700716B RID: 29035
		// (get) Token: 0x0601C0EB RID: 114923 RVA: 0x00294A7F File Offset: 0x00292C7F
		// (set) Token: 0x0601C0EC RID: 114924 RVA: 0x00294A8F File Offset: 0x00292C8F
		public unsafe int ScoreMiss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreMiss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreMiss) = value;
			}
		}

		// Token: 0x1700716C RID: 29036
		// (get) Token: 0x0601C0ED RID: 114925 RVA: 0x00294AA0 File Offset: 0x00292CA0
		// (set) Token: 0x0601C0EE RID: 114926 RVA: 0x00294AB0 File Offset: 0x00292CB0
		public unsafe int LineHoldScorePerHalfBeatPerfect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatPerfect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatPerfect) = value;
			}
		}

		// Token: 0x1700716D RID: 29037
		// (get) Token: 0x0601C0EF RID: 114927 RVA: 0x00294AC1 File Offset: 0x00292CC1
		// (set) Token: 0x0601C0F0 RID: 114928 RVA: 0x00294AD1 File Offset: 0x00292CD1
		public unsafe int LineHoldScorePerHalfBeatGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGreat) = value;
			}
		}

		// Token: 0x1700716E RID: 29038
		// (get) Token: 0x0601C0F1 RID: 114929 RVA: 0x00294AE2 File Offset: 0x00292CE2
		// (set) Token: 0x0601C0F2 RID: 114930 RVA: 0x00294AF2 File Offset: 0x00292CF2
		public unsafe int LineHoldScorePerHalfBeatGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGood) = value;
			}
		}

		// Token: 0x1700716F RID: 29039
		// (get) Token: 0x0601C0F3 RID: 114931 RVA: 0x00294B03 File Offset: 0x00292D03
		// (set) Token: 0x0601C0F4 RID: 114932 RVA: 0x00294B13 File Offset: 0x00292D13
		public unsafe int LineHoldScorePerHalfBeatBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatBad) = value;
			}
		}

		// Token: 0x17007170 RID: 29040
		// (get) Token: 0x0601C0F5 RID: 114933 RVA: 0x00294B24 File Offset: 0x00292D24
		// (set) Token: 0x0601C0F6 RID: 114934 RVA: 0x00294B34 File Offset: 0x00292D34
		public unsafe float EarlyMiss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyMiss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyMiss) = value;
			}
		}

		// Token: 0x17007171 RID: 29041
		// (get) Token: 0x0601C0F7 RID: 114935 RVA: 0x00294B45 File Offset: 0x00292D45
		// (set) Token: 0x0601C0F8 RID: 114936 RVA: 0x00294B55 File Offset: 0x00292D55
		public unsafe float EarlyBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyBad) = value;
			}
		}

		// Token: 0x17007172 RID: 29042
		// (get) Token: 0x0601C0F9 RID: 114937 RVA: 0x00294B66 File Offset: 0x00292D66
		// (set) Token: 0x0601C0FA RID: 114938 RVA: 0x00294B76 File Offset: 0x00292D76
		public unsafe float EarlyGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGood) = value;
			}
		}

		// Token: 0x17007173 RID: 29043
		// (get) Token: 0x0601C0FB RID: 114939 RVA: 0x00294B87 File Offset: 0x00292D87
		// (set) Token: 0x0601C0FC RID: 114940 RVA: 0x00294B97 File Offset: 0x00292D97
		public unsafe float EarlyGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGreat) = value;
			}
		}

		// Token: 0x17007174 RID: 29044
		// (get) Token: 0x0601C0FD RID: 114941 RVA: 0x00294BA8 File Offset: 0x00292DA8
		// (set) Token: 0x0601C0FE RID: 114942 RVA: 0x00294BB8 File Offset: 0x00292DB8
		public unsafe float Perfect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Perfect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Perfect) = value;
			}
		}

		// Token: 0x17007175 RID: 29045
		// (get) Token: 0x0601C0FF RID: 114943 RVA: 0x00294BC9 File Offset: 0x00292DC9
		// (set) Token: 0x0601C100 RID: 114944 RVA: 0x00294BD9 File Offset: 0x00292DD9
		public unsafe float LateGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGreat) = value;
			}
		}

		// Token: 0x17007176 RID: 29046
		// (get) Token: 0x0601C101 RID: 114945 RVA: 0x00294BEA File Offset: 0x00292DEA
		// (set) Token: 0x0601C102 RID: 114946 RVA: 0x00294BFA File Offset: 0x00292DFA
		public unsafe float LateGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGood) = value;
			}
		}

		// Token: 0x17007177 RID: 29047
		// (get) Token: 0x0601C103 RID: 114947 RVA: 0x00294C0B File Offset: 0x00292E0B
		// (set) Token: 0x0601C104 RID: 114948 RVA: 0x00294C1B File Offset: 0x00292E1B
		public unsafe float LateBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateBad) = value;
			}
		}

		// Token: 0x17007178 RID: 29048
		// (get) Token: 0x0601C105 RID: 114949 RVA: 0x00294C2C File Offset: 0x00292E2C
		// (set) Token: 0x0601C106 RID: 114950 RVA: 0x00294C3C File Offset: 0x00292E3C
		public unsafe float Miss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Miss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Miss) = value;
			}
		}

		// Token: 0x17007179 RID: 29049
		// (get) Token: 0x0601C107 RID: 114951 RVA: 0x00294C50 File Offset: 0x00292E50
		// (set) Token: 0x0601C108 RID: 114952 RVA: 0x00294C93 File Offset: 0x00292E93
		public FKuroRhythmGameHiddenScore HiddenScore
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameHiddenScore result;
				if ((result = this._HiddenScore) == null)
				{
					result = (this._HiddenScore = new FKuroRhythmGameHiddenScore(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_HiddenScore, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameHiddenScore.StaticStruct(), base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_HiddenScore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700717A RID: 29050
		// (get) Token: 0x0601C109 RID: 114953 RVA: 0x00294CB4 File Offset: 0x00292EB4
		// (set) Token: 0x0601C10A RID: 114954 RVA: 0x00294CC4 File Offset: 0x00292EC4
		public unsafe int FeverScoreMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverScoreMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverScoreMax) = value;
			}
		}

		// Token: 0x1700717B RID: 29051
		// (get) Token: 0x0601C10B RID: 114955 RVA: 0x00294CD5 File Offset: 0x00292ED5
		// (set) Token: 0x0601C10C RID: 114956 RVA: 0x00294CE5 File Offset: 0x00292EE5
		public unsafe int FeverConsumptionPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverConsumptionPerSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverConsumptionPerSecond) = value;
			}
		}

		// Token: 0x1700717C RID: 29052
		// (get) Token: 0x0601C10D RID: 114957 RVA: 0x00294CF8 File Offset: 0x00292EF8
		// (set) Token: 0x0601C10E RID: 114958 RVA: 0x00294D3B File Offset: 0x00292F3B
		public FKuroRhythmGameFeverConfig FeverConfig
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameFeverConfig result;
				if ((result = this._FeverConfig) == null)
				{
					result = (this._FeverConfig = new FKuroRhythmGameFeverConfig(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameFeverConfig.StaticStruct(), base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700717D RID: 29053
		// (get) Token: 0x0601C10F RID: 114959 RVA: 0x00294D5C File Offset: 0x00292F5C
		// (set) Token: 0x0601C110 RID: 114960 RVA: 0x00294D6C File Offset: 0x00292F6C
		public unsafe float CurvatureDeltaDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureDeltaDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureDeltaDistance) = value;
			}
		}

		// Token: 0x1700717E RID: 29054
		// (get) Token: 0x0601C111 RID: 114961 RVA: 0x00294D7D File Offset: 0x00292F7D
		// (set) Token: 0x0601C112 RID: 114962 RVA: 0x00294D8D File Offset: 0x00292F8D
		public unsafe float CurvatureMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureMultiplier) = value;
			}
		}

		// Token: 0x1700717F RID: 29055
		// (get) Token: 0x0601C113 RID: 114963 RVA: 0x00294D9E File Offset: 0x00292F9E
		// (set) Token: 0x0601C114 RID: 114964 RVA: 0x00294DAE File Offset: 0x00292FAE
		public unsafe float TrackWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackWidth) = value;
			}
		}

		// Token: 0x17007180 RID: 29056
		// (get) Token: 0x0601C115 RID: 114965 RVA: 0x00294DBF File Offset: 0x00292FBF
		// (set) Token: 0x0601C116 RID: 114966 RVA: 0x00294DCF File Offset: 0x00292FCF
		public unsafe int TrackCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackCount) = value;
			}
		}

		// Token: 0x17007181 RID: 29057
		// (get) Token: 0x0601C117 RID: 114967 RVA: 0x00294DE0 File Offset: 0x00292FE0
		// (set) Token: 0x0601C118 RID: 114968 RVA: 0x00294DF0 File Offset: 0x00292FF0
		public unsafe float TrackSwitchDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackSwitchDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackSwitchDuration) = value;
			}
		}

		// Token: 0x17007182 RID: 29058
		// (get) Token: 0x0601C119 RID: 114969 RVA: 0x00294E01 File Offset: 0x00293001
		// (set) Token: 0x0601C11A RID: 114970 RVA: 0x00294E11 File Offset: 0x00293011
		public unsafe float Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17007183 RID: 29059
		// (get) Token: 0x0601C11B RID: 114971 RVA: 0x00294E22 File Offset: 0x00293022
		// (set) Token: 0x0601C11C RID: 114972 RVA: 0x00294E32 File Offset: 0x00293032
		public unsafe float ShipZAxisOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ShipZAxisOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ShipZAxisOffset) = value;
			}
		}

		// Token: 0x17007184 RID: 29060
		// (get) Token: 0x0601C11D RID: 114973 RVA: 0x00294E43 File Offset: 0x00293043
		// (set) Token: 0x0601C11E RID: 114974 RVA: 0x00294E57 File Offset: 0x00293057
		[Nullable(2)]
		public unsafe UNiagaraSystem EffectSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_EffectSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_EffectSystem, value);
			}
		}

		// Token: 0x17007185 RID: 29061
		// (get) Token: 0x0601C11F RID: 114975 RVA: 0x00294E6C File Offset: 0x0029306C
		// (set) Token: 0x0601C120 RID: 114976 RVA: 0x00294E80 File Offset: 0x00293080
		[Nullable(2)]
		public unsafe UCurveFloat JumpHeightCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_JumpHeightCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_JumpHeightCurve, value);
			}
		}

		// Token: 0x0601C121 RID: 114977 RVA: 0x00294E95 File Offset: 0x00293095
		public FKuroRhythmGameConfig()
		{
		}

		// Token: 0x0601C122 RID: 114978 RVA: 0x00294EA0 File Offset: 0x002930A0
		public FKuroRhythmGameConfig(float GlobalTimeOffset, int ScorePerfect, int ScoreGreat, int ScoreGood, int ScoreBad, int ScoreMiss, int LineHoldScorePerHalfBeatPerfect, int LineHoldScorePerHalfBeatGreat, int LineHoldScorePerHalfBeatGood, int LineHoldScorePerHalfBeatBad, float EarlyMiss, float EarlyBad, float EarlyGood, float EarlyGreat, float Perfect, float LateGreat, float LateGood, float LateBad, float Miss, FKuroRhythmGameHiddenScore HiddenScore, int FeverScoreMax, int FeverConsumptionPerSecond, FKuroRhythmGameFeverConfig FeverConfig, float CurvatureDeltaDistance, float CurvatureMultiplier, float TrackWidth, int TrackCount, float TrackSwitchDuration, float Acceleration, float ShipZAxisOffset, UNiagaraSystem EffectSystem, UCurveFloat JumpHeightCurve)
		{
			this.GlobalTimeOffset = GlobalTimeOffset;
			this.ScorePerfect = ScorePerfect;
			this.ScoreGreat = ScoreGreat;
			this.ScoreGood = ScoreGood;
			this.ScoreBad = ScoreBad;
			this.ScoreMiss = ScoreMiss;
			this.LineHoldScorePerHalfBeatPerfect = LineHoldScorePerHalfBeatPerfect;
			this.LineHoldScorePerHalfBeatGreat = LineHoldScorePerHalfBeatGreat;
			this.LineHoldScorePerHalfBeatGood = LineHoldScorePerHalfBeatGood;
			this.LineHoldScorePerHalfBeatBad = LineHoldScorePerHalfBeatBad;
			this.EarlyMiss = EarlyMiss;
			this.EarlyBad = EarlyBad;
			this.EarlyGood = EarlyGood;
			this.EarlyGreat = EarlyGreat;
			this.Perfect = Perfect;
			this.LateGreat = LateGreat;
			this.LateGood = LateGood;
			this.LateBad = LateBad;
			this.Miss = Miss;
			this.HiddenScore = HiddenScore;
			this.FeverScoreMax = FeverScoreMax;
			this.FeverConsumptionPerSecond = FeverConsumptionPerSecond;
			this.FeverConfig = FeverConfig;
			this.CurvatureDeltaDistance = CurvatureDeltaDistance;
			this.CurvatureMultiplier = CurvatureMultiplier;
			this.TrackWidth = TrackWidth;
			this.TrackCount = TrackCount;
			this.TrackSwitchDuration = TrackSwitchDuration;
			this.Acceleration = Acceleration;
			this.ShipZAxisOffset = ShipZAxisOffset;
			this.EffectSystem = EffectSystem;
			this.JumpHeightCurve = JumpHeightCurve;
		}

		// Token: 0x0601C123 RID: 114979 RVA: 0x00294FB0 File Offset: 0x002931B0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameConfig.StaticStruct();
		}

		// Token: 0x0601C124 RID: 114980 RVA: 0x00294FBC File Offset: 0x002931BC
		[NullableContext(2)]
		public FKuroRhythmGameConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C125 RID: 114981 RVA: 0x00294FC6 File Offset: 0x002931C6
		public FKuroRhythmGameConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C126 RID: 114982 RVA: 0x00294FD1 File Offset: 0x002931D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameConfig(Pointer, false, true);
		}

		// Token: 0x0601C127 RID: 114983 RVA: 0x00294FDB File Offset: 0x002931DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400F160 RID: 61792
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameConfig";

		// Token: 0x0400F161 RID: 61793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F162 RID: 61794
		internal static int __PropertyOffset_GlobalTimeOffset;

		// Token: 0x0400F163 RID: 61795
		internal static int __PropertyOffset_ScorePerfect;

		// Token: 0x0400F164 RID: 61796
		internal static int __PropertyOffset_ScoreGreat;

		// Token: 0x0400F165 RID: 61797
		internal static int __PropertyOffset_ScoreGood;

		// Token: 0x0400F166 RID: 61798
		internal static int __PropertyOffset_ScoreBad;

		// Token: 0x0400F167 RID: 61799
		internal static int __PropertyOffset_ScoreMiss;

		// Token: 0x0400F168 RID: 61800
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatPerfect;

		// Token: 0x0400F169 RID: 61801
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatGreat;

		// Token: 0x0400F16A RID: 61802
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatGood;

		// Token: 0x0400F16B RID: 61803
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatBad;

		// Token: 0x0400F16C RID: 61804
		internal static int __PropertyOffset_EarlyMiss;

		// Token: 0x0400F16D RID: 61805
		internal static int __PropertyOffset_EarlyBad;

		// Token: 0x0400F16E RID: 61806
		internal static int __PropertyOffset_EarlyGood;

		// Token: 0x0400F16F RID: 61807
		internal static int __PropertyOffset_EarlyGreat;

		// Token: 0x0400F170 RID: 61808
		internal static int __PropertyOffset_Perfect;

		// Token: 0x0400F171 RID: 61809
		internal static int __PropertyOffset_LateGreat;

		// Token: 0x0400F172 RID: 61810
		internal static int __PropertyOffset_LateGood;

		// Token: 0x0400F173 RID: 61811
		internal static int __PropertyOffset_LateBad;

		// Token: 0x0400F174 RID: 61812
		internal static int __PropertyOffset_Miss;

		// Token: 0x0400F175 RID: 61813
		internal static int __PropertyOffset_HiddenScore;

		// Token: 0x0400F176 RID: 61814
		[Nullable(2)]
		private FKuroRhythmGameHiddenScore _HiddenScore;

		// Token: 0x0400F177 RID: 61815
		internal static int __PropertyOffset_FeverScoreMax;

		// Token: 0x0400F178 RID: 61816
		internal static int __PropertyOffset_FeverConsumptionPerSecond;

		// Token: 0x0400F179 RID: 61817
		internal static int __PropertyOffset_FeverConfig;

		// Token: 0x0400F17A RID: 61818
		[Nullable(2)]
		private FKuroRhythmGameFeverConfig _FeverConfig;

		// Token: 0x0400F17B RID: 61819
		internal static int __PropertyOffset_CurvatureDeltaDistance;

		// Token: 0x0400F17C RID: 61820
		internal static int __PropertyOffset_CurvatureMultiplier;

		// Token: 0x0400F17D RID: 61821
		internal static int __PropertyOffset_TrackWidth;

		// Token: 0x0400F17E RID: 61822
		internal static int __PropertyOffset_TrackCount;

		// Token: 0x0400F17F RID: 61823
		internal static int __PropertyOffset_TrackSwitchDuration;

		// Token: 0x0400F180 RID: 61824
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x0400F181 RID: 61825
		internal static int __PropertyOffset_ShipZAxisOffset;

		// Token: 0x0400F182 RID: 61826
		internal static int __PropertyOffset_EffectSystem;

		// Token: 0x0400F183 RID: 61827
		internal static int __PropertyOffset_JumpHeightCurve;
	}
}
