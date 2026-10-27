using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CF RID: 975
	[UnrealObjectPath("/Script/AugmentedReality.ARTraceResultDummy")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UARTraceResultDummy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600368A RID: 13962 RVA: 0x00052B62 File Offset: 0x00050D62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTraceResultDummy._ClassPtr;
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00052B70 File Offset: 0x00050D70
		public UARTraceResultDummy() : this(BuiltinUtils.AllocNativeUObject(UARTraceResultDummy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00052B98 File Offset: 0x00050D98
		[NullableContext(1)]
		public UARTraceResultDummy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTraceResultDummy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00052BCB File Offset: 0x00050DCB
		static UARTraceResultDummy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTraceResultDummy");
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00052BD9 File Offset: 0x00050DD9
		protected UARTraceResultDummy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001797 RID: 6039
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTraceResultDummy";

		// Token: 0x04001798 RID: 6040
		private static IntPtr _ClassPtr;

		// Token: 0x04001799 RID: 6041
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
