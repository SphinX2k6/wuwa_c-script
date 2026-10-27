using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200261B RID: 9755
	[UnrealObjectPath("/Script/OodleTextureStorageProvider.OodleTextureStorageProviderFactory")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UOodleTextureStorageProviderFactory : UTextureAllMipDataProviderFactory, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024472 RID: 148594 RVA: 0x0035B5E1 File Offset: 0x003597E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOodleTextureStorageProviderFactory._ClassPtr;
		}

		// Token: 0x06024473 RID: 148595 RVA: 0x0035B5F0 File Offset: 0x003597F0
		public UOodleTextureStorageProviderFactory() : this(BuiltinUtils.AllocNativeUObject(UOodleTextureStorageProviderFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024474 RID: 148596 RVA: 0x0035B618 File Offset: 0x00359818
		[NullableContext(1)]
		public UOodleTextureStorageProviderFactory(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOodleTextureStorageProviderFactory.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024475 RID: 148597 RVA: 0x0035B64B File Offset: 0x0035984B
		static UOodleTextureStorageProviderFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OodleTextureStorageProvider.OodleTextureStorageProviderFactory");
		}

		// Token: 0x06024476 RID: 148598 RVA: 0x0035B659 File Offset: 0x00359859
		protected UOodleTextureStorageProviderFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401375B RID: 79707
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OodleTextureStorageProvider.OodleTextureStorageProviderFactory";

		// Token: 0x0401375C RID: 79708
		private static IntPtr _ClassPtr;

		// Token: 0x0401375D RID: 79709
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
