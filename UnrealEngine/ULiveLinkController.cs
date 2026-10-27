using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021FC RID: 8700
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkController")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULiveLinkController : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021290 RID: 135824 RVA: 0x0030E510 File Offset: 0x0030C710
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkController._ClassPtr;
		}

		// Token: 0x06021291 RID: 135825 RVA: 0x0030E51C File Offset: 0x0030C71C
		static ULiveLinkController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkController");
		}

		// Token: 0x06021292 RID: 135826 RVA: 0x0030E52C File Offset: 0x0030C72C
		protected ULiveLinkController() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021293 RID: 135827 RVA: 0x0030E554 File Offset: 0x0030C754
		protected ULiveLinkController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B16 RID: 72470
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkController";

		// Token: 0x04011B17 RID: 72471
		private static IntPtr _ClassPtr;

		// Token: 0x04011B18 RID: 72472
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
