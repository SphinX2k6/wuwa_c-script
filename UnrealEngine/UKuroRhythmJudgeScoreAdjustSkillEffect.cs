using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C5B RID: 7259
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmJudgeScoreAdjustSkillEffect")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroRhythmJudgeScoreAdjustSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C2C3 RID: 115395 RVA: 0x00298588 File Offset: 0x00296788
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmJudgeScoreAdjustSkillEffect._ClassPtr;
		}

		// Token: 0x0601C2C4 RID: 115396 RVA: 0x00298594 File Offset: 0x00296794
		public UKuroRhythmJudgeScoreAdjustSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmJudgeScoreAdjustSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C2C5 RID: 115397 RVA: 0x002985BC File Offset: 0x002967BC
		[NullableContext(1)]
		public UKuroRhythmJudgeScoreAdjustSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmJudgeScoreAdjustSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C2C6 RID: 115398 RVA: 0x002985EF File Offset: 0x002967EF
		static UKuroRhythmJudgeScoreAdjustSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmJudgeScoreAdjustSkillEffect");
		}

		// Token: 0x0601C2C7 RID: 115399 RVA: 0x002985FD File Offset: 0x002967FD
		protected UKuroRhythmJudgeScoreAdjustSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F292 RID: 62098
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmJudgeScoreAdjustSkillEffect";

		// Token: 0x0400F293 RID: 62099
		private static IntPtr _ClassPtr;

		// Token: 0x0400F294 RID: 62100
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
