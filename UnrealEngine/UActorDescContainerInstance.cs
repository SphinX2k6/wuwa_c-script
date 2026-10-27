using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007BD RID: 1981
	[UnrealObjectPath("/Script/Engine.ActorDescContainerInstance")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UActorDescContainerInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060069FB RID: 27131 RVA: 0x000982CA File Offset: 0x000964CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorDescContainerInstance._ClassPtr;
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x000982D8 File Offset: 0x000964D8
		public UActorDescContainerInstance() : this(BuiltinUtils.AllocNativeUObject(UActorDescContainerInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x00098300 File Offset: 0x00096500
		[NullableContext(1)]
		public UActorDescContainerInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorDescContainerInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x00098333 File Offset: 0x00096533
		static UActorDescContainerInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorDescContainerInstance");
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x00098341 File Offset: 0x00096541
		protected UActorDescContainerInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003316 RID: 13078
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorDescContainerInstance";

		// Token: 0x04003317 RID: 13079
		private static IntPtr _ClassPtr;

		// Token: 0x04003318 RID: 13080
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
