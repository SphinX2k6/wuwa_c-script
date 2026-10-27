using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002203 RID: 8707
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkFrameInterpolationProcessor")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULiveLinkFrameInterpolationProcessor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060212D9 RID: 135897 RVA: 0x0030EB29 File Offset: 0x0030CD29
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkFrameInterpolationProcessor._ClassPtr;
		}

		// Token: 0x060212DA RID: 135898 RVA: 0x0030EB35 File Offset: 0x0030CD35
		static ULiveLinkFrameInterpolationProcessor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkFrameInterpolationProcessor");
		}

		// Token: 0x060212DB RID: 135899 RVA: 0x0030EB44 File Offset: 0x0030CD44
		protected ULiveLinkFrameInterpolationProcessor() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkFrameInterpolationProcessor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060212DC RID: 135900 RVA: 0x0030EB6C File Offset: 0x0030CD6C
		protected ULiveLinkFrameInterpolationProcessor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B38 RID: 72504
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkFrameInterpolationProcessor";

		// Token: 0x04011B39 RID: 72505
		private static IntPtr _ClassPtr;

		// Token: 0x04011B3A RID: 72506
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
