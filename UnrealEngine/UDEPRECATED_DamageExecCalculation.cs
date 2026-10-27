using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001960 RID: 6496
	[UnrealObjectPath("/Script/KuroGAS.DamageExecCalculation")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UDEPRECATED_DamageExecCalculation : UGameplayEffectExecutionCalculation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018251 RID: 98897 RVA: 0x0023982D File Offset: 0x00237A2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_DamageExecCalculation._ClassPtr;
		}

		// Token: 0x06018252 RID: 98898 RVA: 0x0023983C File Offset: 0x00237A3C
		public UDEPRECATED_DamageExecCalculation() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_DamageExecCalculation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018253 RID: 98899 RVA: 0x00239864 File Offset: 0x00237A64
		[NullableContext(1)]
		public UDEPRECATED_DamageExecCalculation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_DamageExecCalculation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018254 RID: 98900 RVA: 0x00239897 File Offset: 0x00237A97
		static UDEPRECATED_DamageExecCalculation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.DamageExecCalculation");
		}

		// Token: 0x06018255 RID: 98901 RVA: 0x002398A5 File Offset: 0x00237AA5
		protected UDEPRECATED_DamageExecCalculation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D18C RID: 53644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.DamageExecCalculation";

		// Token: 0x0400D18D RID: 53645
		private static IntPtr _ClassPtr;

		// Token: 0x0400D18E RID: 53646
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
