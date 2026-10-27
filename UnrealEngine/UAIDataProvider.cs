using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E4 RID: 228
	[UnrealObjectPath("/Script/AIModule.AIDataProvider")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAIDataProvider : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x0001B531 File Offset: 0x00019731
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIDataProvider._ClassPtr;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0001B53D File Offset: 0x0001973D
		static UAIDataProvider()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIDataProvider");
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0001B54C File Offset: 0x0001974C
		protected UAIDataProvider() : this(BuiltinUtils.AllocNativeUObject(UAIDataProvider.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0001B574 File Offset: 0x00019774
		protected UAIDataProvider(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000320 RID: 800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProvider";

		// Token: 0x04000321 RID: 801
		private static IntPtr _ClassPtr;

		// Token: 0x04000322 RID: 802
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
