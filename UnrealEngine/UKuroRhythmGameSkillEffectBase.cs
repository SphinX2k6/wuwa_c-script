using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C58 RID: 7256
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameSkillEffectBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroRhythmGameSkillEffectBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C294 RID: 115348 RVA: 0x0029804D File Offset: 0x0029624D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameSkillEffectBase._ClassPtr;
		}

		// Token: 0x0601C295 RID: 115349 RVA: 0x0029805C File Offset: 0x0029625C
		public UKuroRhythmGameSkillEffectBase() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameSkillEffectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C296 RID: 115350 RVA: 0x00298084 File Offset: 0x00296284
		[NullableContext(1)]
		public UKuroRhythmGameSkillEffectBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameSkillEffectBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C297 RID: 115351 RVA: 0x002980B7 File Offset: 0x002962B7
		static UKuroRhythmGameSkillEffectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameSkillEffectBase");
		}

		// Token: 0x0601C298 RID: 115352 RVA: 0x002980C5 File Offset: 0x002962C5
		protected UKuroRhythmGameSkillEffectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F278 RID: 62072
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameSkillEffectBase";

		// Token: 0x0400F279 RID: 62073
		private static IntPtr _ClassPtr;

		// Token: 0x0400F27A RID: 62074
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
