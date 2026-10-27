using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021F1 RID: 8689
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkAnimationRole")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULiveLinkAnimationRole : ULiveLinkBasicRole, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021217 RID: 135703 RVA: 0x0030DA9A File Offset: 0x0030BC9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkAnimationRole._ClassPtr;
		}

		// Token: 0x06021218 RID: 135704 RVA: 0x0030DAA8 File Offset: 0x0030BCA8
		public ULiveLinkAnimationRole() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkAnimationRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021219 RID: 135705 RVA: 0x0030DAD0 File Offset: 0x0030BCD0
		[NullableContext(1)]
		public ULiveLinkAnimationRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkAnimationRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602121A RID: 135706 RVA: 0x0030DB03 File Offset: 0x0030BD03
		static ULiveLinkAnimationRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkAnimationRole");
		}

		// Token: 0x0602121B RID: 135707 RVA: 0x0030DB11 File Offset: 0x0030BD11
		protected ULiveLinkAnimationRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011ADF RID: 72415
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkAnimationRole";

		// Token: 0x04011AE0 RID: 72416
		private static IntPtr _ClassPtr;

		// Token: 0x04011AE1 RID: 72417
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
