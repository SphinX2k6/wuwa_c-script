using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A6 RID: 678
	[UnrealObjectPath("/Script/Engine.TriggerSphere")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ATriggerSphere : ATriggerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A06 RID: 18950 RVA: 0x00067AFA File Offset: 0x00065CFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerSphere._ClassPtr;
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00067B08 File Offset: 0x00065D08
		public ATriggerSphere() : this(BuiltinUtils.AllocNativeUObject(ATriggerSphere.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00067B30 File Offset: 0x00065D30
		[NullableContext(1)]
		public ATriggerSphere(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATriggerSphere.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00067B63 File Offset: 0x00065D63
		static ATriggerSphere()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerSphere");
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00067B71 File Offset: 0x00065D71
		protected ATriggerSphere(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D21 RID: 7457
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerSphere";

		// Token: 0x04001D22 RID: 7458
		private static IntPtr _ClassPtr;

		// Token: 0x04001D23 RID: 7459
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
