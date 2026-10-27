using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001840 RID: 6208
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsComponentDebug")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKuroFauxPhysicsComponentDebug : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016E4A RID: 93770 RVA: 0x002168E9 File Offset: 0x00214AE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsComponentDebug._ClassPtr;
		}

		// Token: 0x06016E4B RID: 93771 RVA: 0x002168F8 File Offset: 0x00214AF8
		public UKuroFauxPhysicsComponentDebug() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsComponentDebug.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E4C RID: 93772 RVA: 0x00216920 File Offset: 0x00214B20
		[NullableContext(1)]
		public UKuroFauxPhysicsComponentDebug(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsComponentDebug.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016E4D RID: 93773 RVA: 0x00216953 File Offset: 0x00214B53
		static UKuroFauxPhysicsComponentDebug()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsComponentDebug");
		}

		// Token: 0x06016E4E RID: 93774 RVA: 0x00216961 File Offset: 0x00214B61
		protected UKuroFauxPhysicsComponentDebug(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C708 RID: 50952
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsComponentDebug";

		// Token: 0x0400C709 RID: 50953
		private static IntPtr _ClassPtr;

		// Token: 0x0400C70A RID: 50954
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
