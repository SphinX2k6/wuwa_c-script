using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A5 RID: 677
	[UnrealObjectPath("/Script/Engine.TriggerBox")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ATriggerBox : ATriggerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A01 RID: 18945 RVA: 0x00067A79 File Offset: 0x00065C79
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerBox._ClassPtr;
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00067A88 File Offset: 0x00065C88
		public ATriggerBox() : this(BuiltinUtils.AllocNativeUObject(ATriggerBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00067AB0 File Offset: 0x00065CB0
		[NullableContext(1)]
		public ATriggerBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATriggerBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00067AE3 File Offset: 0x00065CE3
		static ATriggerBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerBox");
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00067AF1 File Offset: 0x00065CF1
		protected ATriggerBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D1E RID: 7454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerBox";

		// Token: 0x04001D1F RID: 7455
		private static IntPtr _ClassPtr;

		// Token: 0x04001D20 RID: 7456
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
