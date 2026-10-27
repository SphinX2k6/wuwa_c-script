using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C5C RID: 7260
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmJudgeTimeModifierSkillEffect")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroRhythmJudgeTimeModifierSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C2C8 RID: 115400 RVA: 0x00298606 File Offset: 0x00296806
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmJudgeTimeModifierSkillEffect._ClassPtr;
		}

		// Token: 0x0601C2C9 RID: 115401 RVA: 0x00298614 File Offset: 0x00296814
		public UKuroRhythmJudgeTimeModifierSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmJudgeTimeModifierSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C2CA RID: 115402 RVA: 0x0029863C File Offset: 0x0029683C
		[NullableContext(1)]
		public UKuroRhythmJudgeTimeModifierSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmJudgeTimeModifierSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C2CB RID: 115403 RVA: 0x0029866F File Offset: 0x0029686F
		static UKuroRhythmJudgeTimeModifierSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmJudgeTimeModifierSkillEffect");
		}

		// Token: 0x0601C2CC RID: 115404 RVA: 0x0029867D File Offset: 0x0029687D
		protected UKuroRhythmJudgeTimeModifierSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F295 RID: 62101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmJudgeTimeModifierSkillEffect";

		// Token: 0x0400F296 RID: 62102
		private static IntPtr _ClassPtr;

		// Token: 0x0400F297 RID: 62103
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
