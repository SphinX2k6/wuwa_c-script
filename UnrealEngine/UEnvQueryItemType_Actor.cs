using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A0 RID: 416
	[UnrealObjectPath("/Script/AIModule.EnvQueryItemType_Actor")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UEnvQueryItemType_Actor : UEnvQueryItemType_ActorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019B4 RID: 6580 RVA: 0x000261E9 File Offset: 0x000243E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryItemType_Actor._ClassPtr;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000261F8 File Offset: 0x000243F8
		public UEnvQueryItemType_Actor() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_Actor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00026220 File Offset: 0x00024420
		[NullableContext(1)]
		public UEnvQueryItemType_Actor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_Actor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00026253 File Offset: 0x00024453
		static UEnvQueryItemType_Actor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryItemType_Actor");
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00026261 File Offset: 0x00024461
		protected UEnvQueryItemType_Actor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400078B RID: 1931
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryItemType_Actor";

		// Token: 0x0400078C RID: 1932
		private static IntPtr _ClassPtr;

		// Token: 0x0400078D RID: 1933
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
