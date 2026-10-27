using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200135C RID: 4956
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetActor_SingleLineTrace")]
	[UnrealStructLayout(1376, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1376)]
	public class AGameplayAbilityTargetActor_SingleLineTrace : AGameplayAbilityTargetActor_Trace, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060122F2 RID: 74482 RVA: 0x001AB2EB File Offset: 0x001A94EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityTargetActor_SingleLineTrace._ClassPtr;
		}

		// Token: 0x060122F3 RID: 74483 RVA: 0x001AB2F8 File Offset: 0x001A94F8
		public AGameplayAbilityTargetActor_SingleLineTrace() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_SingleLineTrace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060122F4 RID: 74484 RVA: 0x001AB320 File Offset: 0x001A9520
		[NullableContext(1)]
		public AGameplayAbilityTargetActor_SingleLineTrace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_SingleLineTrace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060122F5 RID: 74485 RVA: 0x001AB353 File Offset: 0x001A9553
		static AGameplayAbilityTargetActor_SingleLineTrace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityTargetActor_SingleLineTrace");
		}

		// Token: 0x060122F6 RID: 74486 RVA: 0x001AB361 File Offset: 0x001A9561
		protected AGameplayAbilityTargetActor_SingleLineTrace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009BDC RID: 39900
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetActor_SingleLineTrace";

		// Token: 0x04009BDD RID: 39901
		private static IntPtr _ClassPtr;

		// Token: 0x04009BDE RID: 39902
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
