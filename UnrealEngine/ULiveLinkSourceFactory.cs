using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002216 RID: 8726
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSourceFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULiveLinkSourceFactory : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060213D7 RID: 136151 RVA: 0x00310087 File Offset: 0x0030E287
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkSourceFactory._ClassPtr;
		}

		// Token: 0x060213D8 RID: 136152 RVA: 0x00310093 File Offset: 0x0030E293
		static ULiveLinkSourceFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkSourceFactory");
		}

		// Token: 0x060213D9 RID: 136153 RVA: 0x003100A4 File Offset: 0x0030E2A4
		protected ULiveLinkSourceFactory() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkSourceFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060213DA RID: 136154 RVA: 0x003100CC File Offset: 0x0030E2CC
		protected ULiveLinkSourceFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BB1 RID: 72625
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSourceFactory";

		// Token: 0x04011BB2 RID: 72626
		private static IntPtr _ClassPtr;

		// Token: 0x04011BB3 RID: 72627
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
