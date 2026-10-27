using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001597 RID: 5527
	[UnrealObjectPath("/Script/InteractiveToolsFramework.SingleClickToolBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USingleClickToolBuilder : UInteractiveToolBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EE1 RID: 81633 RVA: 0x001D43FE File Offset: 0x001D25FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USingleClickToolBuilder._ClassPtr;
		}

		// Token: 0x06013EE2 RID: 81634 RVA: 0x001D440C File Offset: 0x001D260C
		public USingleClickToolBuilder() : this(BuiltinUtils.AllocNativeUObject(USingleClickToolBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EE3 RID: 81635 RVA: 0x001D4434 File Offset: 0x001D2634
		[NullableContext(1)]
		public USingleClickToolBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USingleClickToolBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013EE4 RID: 81636 RVA: 0x001D4467 File Offset: 0x001D2667
		static USingleClickToolBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.SingleClickToolBuilder");
		}

		// Token: 0x06013EE5 RID: 81637 RVA: 0x001D4475 File Offset: 0x001D2675
		protected USingleClickToolBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC98 RID: 44184
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.SingleClickToolBuilder";

		// Token: 0x0400AC99 RID: 44185
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC9A RID: 44186
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
