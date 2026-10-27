using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016A3 RID: 5795
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroAutomationCustomMemoryTestObject")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroAutomationCustomMemoryTestObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015026 RID: 86054 RVA: 0x001EE010 File Offset: 0x001EC210
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAutomationCustomMemoryTestObject._ClassPtr;
		}

		// Token: 0x06015027 RID: 86055 RVA: 0x001EE01C File Offset: 0x001EC21C
		public UKuroAutomationCustomMemoryTestObject() : this(BuiltinUtils.AllocNativeUObject(UKuroAutomationCustomMemoryTestObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015028 RID: 86056 RVA: 0x001EE044 File Offset: 0x001EC244
		[NullableContext(1)]
		public UKuroAutomationCustomMemoryTestObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAutomationCustomMemoryTestObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015029 RID: 86057 RVA: 0x001EE077 File Offset: 0x001EC277
		static UKuroAutomationCustomMemoryTestObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAutomationTool.KuroAutomationCustomMemoryTestObject");
		}

		// Token: 0x0601502A RID: 86058 RVA: 0x001EE085 File Offset: 0x001EC285
		protected UKuroAutomationCustomMemoryTestObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B70A RID: 46858
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAutomationTool.KuroAutomationCustomMemoryTestObject";

		// Token: 0x0400B70B RID: 46859
		private static IntPtr _ClassPtr;

		// Token: 0x0400B70C RID: 46860
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
