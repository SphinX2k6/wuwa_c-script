using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D5 RID: 6357
	[UnrealObjectPath("/Script/KuroGameplay.KuroGridLevelComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKuroGridLevelComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060178FF RID: 96511 RVA: 0x00227C72 File Offset: 0x00225E72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGridLevelComponent._ClassPtr;
		}

		// Token: 0x06017900 RID: 96512 RVA: 0x00227C80 File Offset: 0x00225E80
		public UKuroGridLevelComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroGridLevelComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017901 RID: 96513 RVA: 0x00227CA8 File Offset: 0x00225EA8
		[NullableContext(1)]
		public UKuroGridLevelComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGridLevelComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017902 RID: 96514 RVA: 0x00227CDB File Offset: 0x00225EDB
		static UKuroGridLevelComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroGridLevelComponent");
		}

		// Token: 0x06017903 RID: 96515 RVA: 0x00227CE9 File Offset: 0x00225EE9
		protected UKuroGridLevelComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCA0 RID: 52384
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroGridLevelComponent";

		// Token: 0x0400CCA1 RID: 52385
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCA2 RID: 52386
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
