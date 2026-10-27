using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011D1 RID: 4561
	[UnrealObjectPath("/Script/Engine.TextureAllMipDataProviderFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UTextureAllMipDataProviderFactory : UTextureMipDataProviderFactory, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010D03 RID: 68867 RVA: 0x0018B13B File Offset: 0x0018933B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureAllMipDataProviderFactory._ClassPtr;
		}

		// Token: 0x06010D04 RID: 68868 RVA: 0x0018B147 File Offset: 0x00189347
		static UTextureAllMipDataProviderFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureAllMipDataProviderFactory");
		}

		// Token: 0x06010D05 RID: 68869 RVA: 0x0018B158 File Offset: 0x00189358
		protected UTextureAllMipDataProviderFactory() : this(BuiltinUtils.AllocNativeUObject(UTextureAllMipDataProviderFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010D06 RID: 68870 RVA: 0x0018B180 File Offset: 0x00189380
		protected UTextureAllMipDataProviderFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008FC8 RID: 36808
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureAllMipDataProviderFactory";

		// Token: 0x04008FC9 RID: 36809
		private static IntPtr _ClassPtr;

		// Token: 0x04008FCA RID: 36810
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
