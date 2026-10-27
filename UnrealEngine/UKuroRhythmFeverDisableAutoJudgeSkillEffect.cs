using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C49 RID: 7241
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmFeverDisableAutoJudgeSkillEffect")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroRhythmFeverDisableAutoJudgeSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C0D1 RID: 114897 RVA: 0x00294836 File Offset: 0x00292A36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmFeverDisableAutoJudgeSkillEffect._ClassPtr;
		}

		// Token: 0x0601C0D2 RID: 114898 RVA: 0x00294844 File Offset: 0x00292A44
		public UKuroRhythmFeverDisableAutoJudgeSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmFeverDisableAutoJudgeSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C0D3 RID: 114899 RVA: 0x0029486C File Offset: 0x00292A6C
		[NullableContext(1)]
		public UKuroRhythmFeverDisableAutoJudgeSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmFeverDisableAutoJudgeSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C0D4 RID: 114900 RVA: 0x0029489F File Offset: 0x00292A9F
		static UKuroRhythmFeverDisableAutoJudgeSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmFeverDisableAutoJudgeSkillEffect");
		}

		// Token: 0x0601C0D5 RID: 114901 RVA: 0x002948AD File Offset: 0x00292AAD
		protected UKuroRhythmFeverDisableAutoJudgeSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F157 RID: 61783
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmFeverDisableAutoJudgeSkillEffect";

		// Token: 0x0400F158 RID: 61784
		private static IntPtr _ClassPtr;

		// Token: 0x0400F159 RID: 61785
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
