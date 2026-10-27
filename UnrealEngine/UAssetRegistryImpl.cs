using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000360 RID: 864
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistryImpl")]
	[UnrealStructLayout(2152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2152)]
	public class UAssetRegistryImpl : UObject, IUnrealUObject, IUnrealObject, IAssetRegistry, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06003003 RID: 12291 RVA: 0x0004A739 File Offset: 0x00048939
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetRegistryImpl._ClassPtr;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0004A745 File Offset: 0x00048945
		int IAssetRegistry.InterfaceOffset()
		{
			return UAssetRegistryImpl.__InterfaceOffset_IAssetRegistry;
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0004A74C File Offset: 0x0004894C
		public UAssetRegistryImpl() : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryImpl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0004A774 File Offset: 0x00048974
		[NullableContext(1)]
		public UAssetRegistryImpl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryImpl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0004A7A7 File Offset: 0x000489A7
		static UAssetRegistryImpl()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AssetRegistry.AssetRegistryImpl");
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0004A7B5 File Offset: 0x000489B5
		protected UAssetRegistryImpl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014D6 RID: 5334
		internal static int __InterfaceOffset_IAssetRegistry;

		// Token: 0x040014D7 RID: 5335
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AssetRegistry.AssetRegistryImpl";

		// Token: 0x040014D8 RID: 5336
		private static IntPtr _ClassPtr;

		// Token: 0x040014D9 RID: 5337
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
