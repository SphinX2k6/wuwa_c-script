using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002206 RID: 8710
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkFrameTranslator")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULiveLinkFrameTranslator : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060212ED RID: 135917 RVA: 0x0030EC79 File Offset: 0x0030CE79
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkFrameTranslator._ClassPtr;
		}

		// Token: 0x060212EE RID: 135918 RVA: 0x0030EC85 File Offset: 0x0030CE85
		static ULiveLinkFrameTranslator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkFrameTranslator");
		}

		// Token: 0x060212EF RID: 135919 RVA: 0x0030EC94 File Offset: 0x0030CE94
		protected ULiveLinkFrameTranslator() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkFrameTranslator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060212F0 RID: 135920 RVA: 0x0030ECBC File Offset: 0x0030CEBC
		protected ULiveLinkFrameTranslator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B42 RID: 72514
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkFrameTranslator";

		// Token: 0x04011B43 RID: 72515
		private static IntPtr _ClassPtr;

		// Token: 0x04011B44 RID: 72516
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
