using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001207 RID: 4615
	[UnrealObjectPath("/Script/Engine.TriggerVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ATriggerVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011011 RID: 69649 RVA: 0x0018F43A File Offset: 0x0018D63A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerVolume._ClassPtr;
		}

		// Token: 0x06011012 RID: 69650 RVA: 0x0018F448 File Offset: 0x0018D648
		public ATriggerVolume() : this(BuiltinUtils.AllocNativeUObject(ATriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011013 RID: 69651 RVA: 0x0018F470 File Offset: 0x0018D670
		[NullableContext(1)]
		public ATriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011014 RID: 69652 RVA: 0x0018F4A3 File Offset: 0x0018D6A3
		static ATriggerVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerVolume");
		}

		// Token: 0x06011015 RID: 69653 RVA: 0x0018F4B1 File Offset: 0x0018D6B1
		protected ATriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040091B0 RID: 37296
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerVolume";

		// Token: 0x040091B1 RID: 37297
		private static IntPtr _ClassPtr;

		// Token: 0x040091B2 RID: 37298
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
