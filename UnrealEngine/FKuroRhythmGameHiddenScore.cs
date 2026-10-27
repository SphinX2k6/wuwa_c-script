using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C4F RID: 7247
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameHiddenScore")]
	[UnrealStructLayout(120, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FKuroRhythmGameHiddenScore : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C151 RID: 115025 RVA: 0x0029558D File Offset: 0x0029378D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameHiddenScore._ScriptStructPtr != 0) ? FKuroRhythmGameHiddenScore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameHiddenScore", ref FKuroRhythmGameHiddenScore._ScriptStructPtr);
		}

		// Token: 0x1700718E RID: 29070
		// (get) Token: 0x0601C152 RID: 115026 RVA: 0x002955B1 File Offset: 0x002937B1
		// (set) Token: 0x0601C153 RID: 115027 RVA: 0x002955C1 File Offset: 0x002937C1
		public unsafe int CurrentScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_CurrentScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_CurrentScore) = value;
			}
		}

		// Token: 0x1700718F RID: 29071
		// (get) Token: 0x0601C154 RID: 115028 RVA: 0x002955D4 File Offset: 0x002937D4
		// (set) Token: 0x0601C155 RID: 115029 RVA: 0x00295617 File Offset: 0x00293817
		public FKuroRhythmGameHiddenScoreLevelConfig Level1Config
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameHiddenScoreLevelConfig result;
				if ((result = this._Level1Config) == null)
				{
					result = (this._Level1Config = new FKuroRhythmGameHiddenScoreLevelConfig(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level1Config, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameHiddenScoreLevelConfig.StaticStruct(), base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level1Config, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007190 RID: 29072
		// (get) Token: 0x0601C156 RID: 115030 RVA: 0x00295638 File Offset: 0x00293838
		// (set) Token: 0x0601C157 RID: 115031 RVA: 0x00295648 File Offset: 0x00293848
		public unsafe int Level2Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2Threshold) = value;
			}
		}

		// Token: 0x17007191 RID: 29073
		// (get) Token: 0x0601C158 RID: 115032 RVA: 0x0029565C File Offset: 0x0029385C
		// (set) Token: 0x0601C159 RID: 115033 RVA: 0x0029569F File Offset: 0x0029389F
		public FKuroRhythmGameHiddenScoreLevelConfig Level2Config
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameHiddenScoreLevelConfig result;
				if ((result = this._Level2Config) == null)
				{
					result = (this._Level2Config = new FKuroRhythmGameHiddenScoreLevelConfig(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2Config, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameHiddenScoreLevelConfig.StaticStruct(), base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2Config, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007192 RID: 29074
		// (get) Token: 0x0601C15A RID: 115034 RVA: 0x002956C0 File Offset: 0x002938C0
		// (set) Token: 0x0601C15B RID: 115035 RVA: 0x002956D0 File Offset: 0x002938D0
		public unsafe int Level3Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3Threshold) = value;
			}
		}

		// Token: 0x17007193 RID: 29075
		// (get) Token: 0x0601C15C RID: 115036 RVA: 0x002956E4 File Offset: 0x002938E4
		// (set) Token: 0x0601C15D RID: 115037 RVA: 0x00295727 File Offset: 0x00293927
		public FKuroRhythmGameHiddenScoreLevelConfig Level3Config
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameHiddenScoreLevelConfig result;
				if ((result = this._Level3Config) == null)
				{
					result = (this._Level3Config = new FKuroRhythmGameHiddenScoreLevelConfig(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3Config, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameHiddenScoreLevelConfig.StaticStruct(), base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3Config, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007194 RID: 29076
		// (get) Token: 0x0601C15E RID: 115038 RVA: 0x00295748 File Offset: 0x00293948
		// (set) Token: 0x0601C15F RID: 115039 RVA: 0x00295758 File Offset: 0x00293958
		public unsafe int Level4Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4Threshold) = value;
			}
		}

		// Token: 0x17007195 RID: 29077
		// (get) Token: 0x0601C160 RID: 115040 RVA: 0x0029576C File Offset: 0x0029396C
		// (set) Token: 0x0601C161 RID: 115041 RVA: 0x002957AF File Offset: 0x002939AF
		public FKuroRhythmGameHiddenScoreLevelConfig Level4Config
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameHiddenScoreLevelConfig result;
				if ((result = this._Level4Config) == null)
				{
					result = (this._Level4Config = new FKuroRhythmGameHiddenScoreLevelConfig(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4Config, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameHiddenScoreLevelConfig.StaticStruct(), base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4Config, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007196 RID: 29078
		// (get) Token: 0x0601C162 RID: 115042 RVA: 0x002957D0 File Offset: 0x002939D0
		// (set) Token: 0x0601C163 RID: 115043 RVA: 0x002957E0 File Offset: 0x002939E0
		public unsafe int MaxScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_MaxScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_MaxScore) = value;
			}
		}

		// Token: 0x17007197 RID: 29079
		// (get) Token: 0x0601C164 RID: 115044 RVA: 0x002957F1 File Offset: 0x002939F1
		// (set) Token: 0x0601C165 RID: 115045 RVA: 0x00295801 File Offset: 0x00293A01
		public unsafe int Level1ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level1ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level1ScoreMultiplier) = value;
			}
		}

		// Token: 0x17007198 RID: 29080
		// (get) Token: 0x0601C166 RID: 115046 RVA: 0x00295812 File Offset: 0x00293A12
		// (set) Token: 0x0601C167 RID: 115047 RVA: 0x00295822 File Offset: 0x00293A22
		public unsafe int Level2ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level2ScoreMultiplier) = value;
			}
		}

		// Token: 0x17007199 RID: 29081
		// (get) Token: 0x0601C168 RID: 115048 RVA: 0x00295833 File Offset: 0x00293A33
		// (set) Token: 0x0601C169 RID: 115049 RVA: 0x00295843 File Offset: 0x00293A43
		public unsafe int Level3ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level3ScoreMultiplier) = value;
			}
		}

		// Token: 0x1700719A RID: 29082
		// (get) Token: 0x0601C16A RID: 115050 RVA: 0x00295854 File Offset: 0x00293A54
		// (set) Token: 0x0601C16B RID: 115051 RVA: 0x00295864 File Offset: 0x00293A64
		public unsafe int Level4ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level4ScoreMultiplier) = value;
			}
		}

		// Token: 0x1700719B RID: 29083
		// (get) Token: 0x0601C16C RID: 115052 RVA: 0x00295875 File Offset: 0x00293A75
		// (set) Token: 0x0601C16D RID: 115053 RVA: 0x00295885 File Offset: 0x00293A85
		public unsafe int Level5ScoreMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level5ScoreMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameHiddenScore.__PropertyOffset_Level5ScoreMultiplier) = value;
			}
		}

		// Token: 0x0601C16E RID: 115054 RVA: 0x00295896 File Offset: 0x00293A96
		public FKuroRhythmGameHiddenScore()
		{
		}

		// Token: 0x0601C16F RID: 115055 RVA: 0x002958A0 File Offset: 0x00293AA0
		public FKuroRhythmGameHiddenScore(int CurrentScore, FKuroRhythmGameHiddenScoreLevelConfig Level1Config, int Level2Threshold, FKuroRhythmGameHiddenScoreLevelConfig Level2Config, int Level3Threshold, FKuroRhythmGameHiddenScoreLevelConfig Level3Config, int Level4Threshold, FKuroRhythmGameHiddenScoreLevelConfig Level4Config, int MaxScore, int Level1ScoreMultiplier, int Level2ScoreMultiplier, int Level3ScoreMultiplier, int Level4ScoreMultiplier, int Level5ScoreMultiplier)
		{
			this.CurrentScore = CurrentScore;
			this.Level1Config = Level1Config;
			this.Level2Threshold = Level2Threshold;
			this.Level2Config = Level2Config;
			this.Level3Threshold = Level3Threshold;
			this.Level3Config = Level3Config;
			this.Level4Threshold = Level4Threshold;
			this.Level4Config = Level4Config;
			this.MaxScore = MaxScore;
			this.Level1ScoreMultiplier = Level1ScoreMultiplier;
			this.Level2ScoreMultiplier = Level2ScoreMultiplier;
			this.Level3ScoreMultiplier = Level3ScoreMultiplier;
			this.Level4ScoreMultiplier = Level4ScoreMultiplier;
			this.Level5ScoreMultiplier = Level5ScoreMultiplier;
		}

		// Token: 0x0601C170 RID: 115056 RVA: 0x00295920 File Offset: 0x00293B20
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameHiddenScore.StaticStruct();
		}

		// Token: 0x0601C171 RID: 115057 RVA: 0x0029592C File Offset: 0x00293B2C
		[NullableContext(2)]
		public FKuroRhythmGameHiddenScore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C172 RID: 115058 RVA: 0x00295936 File Offset: 0x00293B36
		public FKuroRhythmGameHiddenScore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C173 RID: 115059 RVA: 0x00295941 File Offset: 0x00293B41
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameHiddenScore(Pointer, false, true);
		}

		// Token: 0x0601C174 RID: 115060 RVA: 0x0029594B File Offset: 0x00293B4B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameHiddenScore(Pointer, MemoryOwner);
		}

		// Token: 0x0400F19D RID: 61853
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameHiddenScore";

		// Token: 0x0400F19E RID: 61854
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F19F RID: 61855
		internal static int __PropertyOffset_CurrentScore;

		// Token: 0x0400F1A0 RID: 61856
		internal static int __PropertyOffset_Level1Config;

		// Token: 0x0400F1A1 RID: 61857
		[Nullable(2)]
		private FKuroRhythmGameHiddenScoreLevelConfig _Level1Config;

		// Token: 0x0400F1A2 RID: 61858
		internal static int __PropertyOffset_Level2Threshold;

		// Token: 0x0400F1A3 RID: 61859
		internal static int __PropertyOffset_Level2Config;

		// Token: 0x0400F1A4 RID: 61860
		[Nullable(2)]
		private FKuroRhythmGameHiddenScoreLevelConfig _Level2Config;

		// Token: 0x0400F1A5 RID: 61861
		internal static int __PropertyOffset_Level3Threshold;

		// Token: 0x0400F1A6 RID: 61862
		internal static int __PropertyOffset_Level3Config;

		// Token: 0x0400F1A7 RID: 61863
		[Nullable(2)]
		private FKuroRhythmGameHiddenScoreLevelConfig _Level3Config;

		// Token: 0x0400F1A8 RID: 61864
		internal static int __PropertyOffset_Level4Threshold;

		// Token: 0x0400F1A9 RID: 61865
		internal static int __PropertyOffset_Level4Config;

		// Token: 0x0400F1AA RID: 61866
		[Nullable(2)]
		private FKuroRhythmGameHiddenScoreLevelConfig _Level4Config;

		// Token: 0x0400F1AB RID: 61867
		internal static int __PropertyOffset_MaxScore;

		// Token: 0x0400F1AC RID: 61868
		internal static int __PropertyOffset_Level1ScoreMultiplier;

		// Token: 0x0400F1AD RID: 61869
		internal static int __PropertyOffset_Level2ScoreMultiplier;

		// Token: 0x0400F1AE RID: 61870
		internal static int __PropertyOffset_Level3ScoreMultiplier;

		// Token: 0x0400F1AF RID: 61871
		internal static int __PropertyOffset_Level4ScoreMultiplier;

		// Token: 0x0400F1B0 RID: 61872
		internal static int __PropertyOffset_Level5ScoreMultiplier;
	}
}
