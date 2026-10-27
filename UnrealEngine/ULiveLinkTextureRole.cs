using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002221 RID: 8737
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTextureRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULiveLinkTextureRole : ULiveLinkBasicRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021474 RID: 136308 RVA: 0x00310E38 File Offset: 0x0030F038
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkTextureRole._ClassPtr;
		}

		// Token: 0x06021475 RID: 136309 RVA: 0x00310E44 File Offset: 0x0030F044
		public ULiveLinkTextureRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkTextureRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021476 RID: 136310 RVA: 0x00310E6C File Offset: 0x0030F06C
		[NullableContext(1)]
		public ULiveLinkTextureRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkTextureRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021477 RID: 136311 RVA: 0x00310E9F File Offset: 0x0030F09F
		static ULiveLinkTextureRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkTextureRole");
		}

		// Token: 0x06021478 RID: 136312 RVA: 0x00310EAD File Offset: 0x0030F0AD
		protected ULiveLinkTextureRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BFD RID: 72701
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTextureRole";

		// Token: 0x04011BFE RID: 72702
		private static IntPtr _ClassPtr;

		// Token: 0x04011BFF RID: 72703
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
