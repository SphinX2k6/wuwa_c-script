using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021FA RID: 8698
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkCameraRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULiveLinkCameraRole : ULiveLinkTransformRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021273 RID: 135795 RVA: 0x0030E2B8 File Offset: 0x0030C4B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkCameraRole._ClassPtr;
		}

		// Token: 0x06021274 RID: 135796 RVA: 0x0030E2C4 File Offset: 0x0030C4C4
		public ULiveLinkCameraRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkCameraRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021275 RID: 135797 RVA: 0x0030E2EC File Offset: 0x0030C4EC
		[NullableContext(1)]
		public ULiveLinkCameraRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkCameraRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021276 RID: 135798 RVA: 0x0030E31F File Offset: 0x0030C51F
		static ULiveLinkCameraRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkCameraRole");
		}

		// Token: 0x06021277 RID: 135799 RVA: 0x0030E32D File Offset: 0x0030C52D
		protected ULiveLinkCameraRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B09 RID: 72457
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkCameraRole";

		// Token: 0x04011B0A RID: 72458
		private static IntPtr _ClassPtr;

		// Token: 0x04011B0B RID: 72459
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
