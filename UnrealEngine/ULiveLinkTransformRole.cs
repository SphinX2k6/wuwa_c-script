using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200222B RID: 8747
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTransformRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULiveLinkTransformRole : ULiveLinkBasicRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060214DC RID: 136412 RVA: 0x0031165C File Offset: 0x0030F85C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkTransformRole._ClassPtr;
		}

		// Token: 0x060214DD RID: 136413 RVA: 0x00311668 File Offset: 0x0030F868
		public ULiveLinkTransformRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkTransformRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060214DE RID: 136414 RVA: 0x00311690 File Offset: 0x0030F890
		[NullableContext(1)]
		public ULiveLinkTransformRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkTransformRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060214DF RID: 136415 RVA: 0x003116C3 File Offset: 0x0030F8C3
		static ULiveLinkTransformRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkTransformRole");
		}

		// Token: 0x060214E0 RID: 136416 RVA: 0x003116D1 File Offset: 0x0030F8D1
		protected ULiveLinkTransformRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C26 RID: 72742
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTransformRole";

		// Token: 0x04011C27 RID: 72743
		private static IntPtr _ClassPtr;

		// Token: 0x04011C28 RID: 72744
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
