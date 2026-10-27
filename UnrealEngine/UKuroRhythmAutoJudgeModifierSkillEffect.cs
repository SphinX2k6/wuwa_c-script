using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C45 RID: 7237
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmAutoJudgeModifierSkillEffect")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroRhythmAutoJudgeModifierSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C0A3 RID: 114851 RVA: 0x0029445E File Offset: 0x0029265E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmAutoJudgeModifierSkillEffect._ClassPtr;
		}

		// Token: 0x0601C0A4 RID: 114852 RVA: 0x0029446C File Offset: 0x0029266C
		public UKuroRhythmAutoJudgeModifierSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmAutoJudgeModifierSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C0A5 RID: 114853 RVA: 0x00294494 File Offset: 0x00292694
		[NullableContext(1)]
		public UKuroRhythmAutoJudgeModifierSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmAutoJudgeModifierSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C0A6 RID: 114854 RVA: 0x002944C7 File Offset: 0x002926C7
		static UKuroRhythmAutoJudgeModifierSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmAutoJudgeModifierSkillEffect");
		}

		// Token: 0x0601C0A7 RID: 114855 RVA: 0x002944D5 File Offset: 0x002926D5
		protected UKuroRhythmAutoJudgeModifierSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F141 RID: 61761
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmAutoJudgeModifierSkillEffect";

		// Token: 0x0400F142 RID: 61762
		private static IntPtr _ClassPtr;

		// Token: 0x0400F143 RID: 61763
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
