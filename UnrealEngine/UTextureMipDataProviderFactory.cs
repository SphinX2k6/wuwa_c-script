using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011DA RID: 4570
	[UnrealObjectPath("/Script/Engine.TextureMipDataProviderFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UTextureMipDataProviderFactory : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010D60 RID: 68960 RVA: 0x0018B962 File Offset: 0x00189B62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureMipDataProviderFactory._ClassPtr;
		}

		// Token: 0x06010D61 RID: 68961 RVA: 0x0018B96E File Offset: 0x00189B6E
		static UTextureMipDataProviderFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureMipDataProviderFactory");
		}

		// Token: 0x06010D62 RID: 68962 RVA: 0x0018B97C File Offset: 0x00189B7C
		protected UTextureMipDataProviderFactory() : this(BuiltinUtils.AllocNativeUObject(UTextureMipDataProviderFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010D63 RID: 68963 RVA: 0x0018B9A4 File Offset: 0x00189BA4
		protected UTextureMipDataProviderFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009044 RID: 36932
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureMipDataProviderFactory";

		// Token: 0x04009045 RID: 36933
		private static IntPtr _ClassPtr;

		// Token: 0x04009046 RID: 36934
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
