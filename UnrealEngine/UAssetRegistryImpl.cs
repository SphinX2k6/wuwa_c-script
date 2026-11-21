using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E0 RID: 224
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistryImpl")]
	[UnrealStructLayout(2152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2152)]
	public class UAssetRegistryImpl : UObject, IUnrealUObject, IUnrealObject, IAssetRegistry, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x0001947C File Offset: 0x0001767C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetRegistryImpl._ClassPtr;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00019488 File Offset: 0x00017688
		int IAssetRegistry.InterfaceOffset()
		{
			return UAssetRegistryImpl.__InterfaceOffset_IAssetRegistry;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00019490 File Offset: 0x00017690
		public UAssetRegistryImpl() : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryImpl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000194B8 File Offset: 0x000176B8
		[NullableContext(1)]
		public UAssetRegistryImpl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryImpl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000194EB File Offset: 0x000176EB
		static UAssetRegistryImpl()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AssetRegistry.AssetRegistryImpl");
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000194F9 File Offset: 0x000176F9
		protected UAssetRegistryImpl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000390 RID: 912
		internal static int __InterfaceOffset_IAssetRegistry;

		// Token: 0x04000391 RID: 913
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AssetRegistry.AssetRegistryImpl";

		// Token: 0x04000392 RID: 914
		private static IntPtr _ClassPtr;

		// Token: 0x04000393 RID: 915
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
