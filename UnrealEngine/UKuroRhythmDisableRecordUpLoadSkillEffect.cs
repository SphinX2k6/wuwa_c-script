using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C48 RID: 7240
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmDisableRecordUpLoadSkillEffect")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroRhythmDisableRecordUpLoadSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C0CC RID: 114892 RVA: 0x002947B7 File Offset: 0x002929B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmDisableRecordUpLoadSkillEffect._ClassPtr;
		}

		// Token: 0x0601C0CD RID: 114893 RVA: 0x002947C4 File Offset: 0x002929C4
		public UKuroRhythmDisableRecordUpLoadSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmDisableRecordUpLoadSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C0CE RID: 114894 RVA: 0x002947EC File Offset: 0x002929EC
		[NullableContext(1)]
		public UKuroRhythmDisableRecordUpLoadSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmDisableRecordUpLoadSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C0CF RID: 114895 RVA: 0x0029481F File Offset: 0x00292A1F
		static UKuroRhythmDisableRecordUpLoadSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmDisableRecordUpLoadSkillEffect");
		}

		// Token: 0x0601C0D0 RID: 114896 RVA: 0x0029482D File Offset: 0x00292A2D
		protected UKuroRhythmDisableRecordUpLoadSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F154 RID: 61780
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmDisableRecordUpLoadSkillEffect";

		// Token: 0x0400F155 RID: 61781
		private static IntPtr _ClassPtr;

		// Token: 0x0400F156 RID: 61782
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
