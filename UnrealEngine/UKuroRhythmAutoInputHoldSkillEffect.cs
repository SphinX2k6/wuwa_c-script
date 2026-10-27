using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C44 RID: 7236
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmAutoInputHoldSkillEffect")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroRhythmAutoInputHoldSkillEffect : UKuroRhythmGameSkillEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C09E RID: 114846 RVA: 0x002943E0 File Offset: 0x002925E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmAutoInputHoldSkillEffect._ClassPtr;
		}

		// Token: 0x0601C09F RID: 114847 RVA: 0x002943EC File Offset: 0x002925EC
		public UKuroRhythmAutoInputHoldSkillEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmAutoInputHoldSkillEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C0A0 RID: 114848 RVA: 0x00294414 File Offset: 0x00292614
		[NullableContext(1)]
		public UKuroRhythmAutoInputHoldSkillEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmAutoInputHoldSkillEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C0A1 RID: 114849 RVA: 0x00294447 File Offset: 0x00292647
		static UKuroRhythmAutoInputHoldSkillEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmAutoInputHoldSkillEffect");
		}

		// Token: 0x0601C0A2 RID: 114850 RVA: 0x00294455 File Offset: 0x00292655
		protected UKuroRhythmAutoInputHoldSkillEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F13E RID: 61758
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmAutoInputHoldSkillEffect";

		// Token: 0x0400F13F RID: 61759
		private static IntPtr _ClassPtr;

		// Token: 0x0400F140 RID: 61760
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
