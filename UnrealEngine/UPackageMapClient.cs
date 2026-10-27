using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F39 RID: 3897
	[UnrealObjectPath("/Script/Engine.PackageMapClient")]
	[UnrealStructLayout(1024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1024)]
	public class UPackageMapClient : UPackageMap, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D223 RID: 53795 RVA: 0x00133F9C File Offset: 0x0013219C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPackageMapClient._ClassPtr;
		}

		// Token: 0x0600D224 RID: 53796 RVA: 0x00133FA8 File Offset: 0x001321A8
		public UPackageMapClient() : this(BuiltinUtils.AllocNativeUObject(UPackageMapClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D225 RID: 53797 RVA: 0x00133FD0 File Offset: 0x001321D0
		[NullableContext(1)]
		public UPackageMapClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPackageMapClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x00134003 File Offset: 0x00132203
		static UPackageMapClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PackageMapClient");
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x00134011 File Offset: 0x00132211
		protected UPackageMapClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040070C6 RID: 28870
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PackageMapClient";

		// Token: 0x040070C7 RID: 28871
		private static IntPtr _ClassPtr;

		// Token: 0x040070C8 RID: 28872
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
