using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C4A RID: 7242
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmFeverDurationExtendSkillEffect")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroRhythmFeverDurationExtendSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C0D6 RID: 114902 RVA: 0x002948B6 File Offset: 0x00292AB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmFeverDurationExtendSkillEffect._ClassPtr;
		}

		// Token: 0x0601C0D7 RID: 114903 RVA: 0x002948C4 File Offset: 0x00292AC4
		public UKuroRhythmFeverDurationExtendSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmFeverDurationExtendSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C0D8 RID: 114904 RVA: 0x002948EC File Offset: 0x00292AEC
		[NullableContext(1)]
		public UKuroRhythmFeverDurationExtendSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmFeverDurationExtendSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C0D9 RID: 114905 RVA: 0x0029491F File Offset: 0x00292B1F
		static UKuroRhythmFeverDurationExtendSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmFeverDurationExtendSkillEffect");
		}

		// Token: 0x0601C0DA RID: 114906 RVA: 0x0029492D File Offset: 0x00292B2D
		protected UKuroRhythmFeverDurationExtendSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F15A RID: 61786
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmFeverDurationExtendSkillEffect";

		// Token: 0x0400F15B RID: 61787
		private static IntPtr _ClassPtr;

		// Token: 0x0400F15C RID: 61788
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
