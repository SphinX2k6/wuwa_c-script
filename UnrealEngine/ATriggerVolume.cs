using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A7 RID: 679
	[UnrealObjectPath("/Script/Engine.TriggerVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ATriggerVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A0B RID: 18955 RVA: 0x00067B7A File Offset: 0x00065D7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerVolume._ClassPtr;
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x00067B88 File Offset: 0x00065D88
		public ATriggerVolume() : this(BuiltinUtils.AllocNativeUObject(ATriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x00067BB0 File Offset: 0x00065DB0
		[NullableContext(1)]
		public ATriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x00067BE3 File Offset: 0x00065DE3
		static ATriggerVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerVolume");
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x00067BF1 File Offset: 0x00065DF1
		protected ATriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D24 RID: 7460
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerVolume";

		// Token: 0x04001D25 RID: 7461
		private static IntPtr _ClassPtr;

		// Token: 0x04001D26 RID: 7462
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
