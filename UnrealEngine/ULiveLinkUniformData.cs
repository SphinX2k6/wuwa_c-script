using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200222D RID: 8749
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkUniformData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULiveLinkUniformData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060214EF RID: 136431 RVA: 0x003117C2 File Offset: 0x0030F9C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkUniformData._ClassPtr;
		}

		// Token: 0x060214F0 RID: 136432 RVA: 0x003117CE File Offset: 0x0030F9CE
		static ULiveLinkUniformData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkUniformData");
		}

		// Token: 0x060214F1 RID: 136433 RVA: 0x003117DC File Offset: 0x0030F9DC
		protected ULiveLinkUniformData() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkUniformData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060214F2 RID: 136434 RVA: 0x00311804 File Offset: 0x0030FA04
		protected ULiveLinkUniformData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C2E RID: 72750
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkUniformData";

		// Token: 0x04011C2F RID: 72751
		private static IntPtr _ClassPtr;

		// Token: 0x04011C30 RID: 72752
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
