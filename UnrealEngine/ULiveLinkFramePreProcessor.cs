using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002204 RID: 8708
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkFramePreProcessor")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULiveLinkFramePreProcessor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060212DD RID: 135901 RVA: 0x0030EB75 File Offset: 0x0030CD75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkFramePreProcessor._ClassPtr;
		}

		// Token: 0x060212DE RID: 135902 RVA: 0x0030EB81 File Offset: 0x0030CD81
		static ULiveLinkFramePreProcessor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkFramePreProcessor");
		}

		// Token: 0x060212DF RID: 135903 RVA: 0x0030EB90 File Offset: 0x0030CD90
		protected ULiveLinkFramePreProcessor() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkFramePreProcessor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060212E0 RID: 135904 RVA: 0x0030EBB8 File Offset: 0x0030CDB8
		protected ULiveLinkFramePreProcessor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B3B RID: 72507
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkFramePreProcessor";

		// Token: 0x04011B3C RID: 72508
		private static IntPtr _ClassPtr;

		// Token: 0x04011B3D RID: 72509
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
