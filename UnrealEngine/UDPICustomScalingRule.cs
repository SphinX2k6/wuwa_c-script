using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D8 RID: 2520
	[UnrealObjectPath("/Script/Engine.DPICustomScalingRule")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UDPICustomScalingRule : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E72 RID: 36466 RVA: 0x000CBB92 File Offset: 0x000C9D92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDPICustomScalingRule._ClassPtr;
		}

		// Token: 0x06008E73 RID: 36467 RVA: 0x000CBB9E File Offset: 0x000C9D9E
		static UDPICustomScalingRule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DPICustomScalingRule");
		}

		// Token: 0x06008E74 RID: 36468 RVA: 0x000CBBAC File Offset: 0x000C9DAC
		protected UDPICustomScalingRule() : this(BuiltinUtils.AllocNativeUObject(UDPICustomScalingRule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x000CBBD4 File Offset: 0x000C9DD4
		protected UDPICustomScalingRule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043C1 RID: 17345
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DPICustomScalingRule";

		// Token: 0x040043C2 RID: 17346
		private static IntPtr _ClassPtr;

		// Token: 0x040043C3 RID: 17347
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
