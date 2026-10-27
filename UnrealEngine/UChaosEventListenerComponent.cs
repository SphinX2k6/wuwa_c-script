using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200044C RID: 1100
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosEventListenerComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UChaosEventListenerComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003B61 RID: 15201 RVA: 0x0005983E File Offset: 0x00057A3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosEventListenerComponent._ClassPtr;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x0005984C File Offset: 0x00057A4C
		public UChaosEventListenerComponent() : this(BuiltinUtils.AllocNativeUObject(UChaosEventListenerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00059874 File Offset: 0x00057A74
		[NullableContext(1)]
		public UChaosEventListenerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosEventListenerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x000598A7 File Offset: 0x00057AA7
		static UChaosEventListenerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosSolverEngine.ChaosEventListenerComponent");
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x000598B5 File Offset: 0x00057AB5
		protected UChaosEventListenerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B52 RID: 6994
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosEventListenerComponent";

		// Token: 0x04001B53 RID: 6995
		private static IntPtr _ClassPtr;

		// Token: 0x04001B54 RID: 6996
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
