using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200220A RID: 8714
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkLightRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULiveLinkLightRole : ULiveLinkTransformRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021323 RID: 135971 RVA: 0x0030F0C8 File Offset: 0x0030D2C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkLightRole._ClassPtr;
		}

		// Token: 0x06021324 RID: 135972 RVA: 0x0030F0D4 File Offset: 0x0030D2D4
		public ULiveLinkLightRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkLightRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021325 RID: 135973 RVA: 0x0030F0FC File Offset: 0x0030D2FC
		[NullableContext(1)]
		public ULiveLinkLightRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkLightRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021326 RID: 135974 RVA: 0x0030F12F File Offset: 0x0030D32F
		static ULiveLinkLightRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkLightRole");
		}

		// Token: 0x06021327 RID: 135975 RVA: 0x0030F13D File Offset: 0x0030D33D
		protected ULiveLinkLightRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B5A RID: 72538
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkLightRole";

		// Token: 0x04011B5B RID: 72539
		private static IntPtr _ClassPtr;

		// Token: 0x04011B5C RID: 72540
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
