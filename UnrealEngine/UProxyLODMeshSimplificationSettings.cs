using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001041 RID: 4161
	[UnrealObjectPath("/Script/Engine.ProxyLODMeshSimplificationSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UProxyLODMeshSimplificationSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ECD3 RID: 60627 RVA: 0x0015F48E File Offset: 0x0015D68E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProxyLODMeshSimplificationSettings._ClassPtr;
		}

		// Token: 0x0600ECD4 RID: 60628 RVA: 0x0015F49C File Offset: 0x0015D69C
		public UProxyLODMeshSimplificationSettings() : this(BuiltinUtils.AllocNativeUObject(UProxyLODMeshSimplificationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ECD5 RID: 60629 RVA: 0x0015F4C4 File Offset: 0x0015D6C4
		[NullableContext(1)]
		public UProxyLODMeshSimplificationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProxyLODMeshSimplificationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600ECD6 RID: 60630 RVA: 0x0015F4F7 File Offset: 0x0015D6F7
		// (set) Token: 0x0600ECD7 RID: 60631 RVA: 0x0015F50B File Offset: 0x0015D70B
		public unsafe FName ProxyLODMeshReductionModuleName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProxyLODMeshSimplificationSettings.__PropertyOffset_ProxyLODMeshReductionModuleName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProxyLODMeshSimplificationSettings.__PropertyOffset_ProxyLODMeshReductionModuleName) = value;
			}
		}

		// Token: 0x0600ECD8 RID: 60632 RVA: 0x0015F520 File Offset: 0x0015D720
		static UProxyLODMeshSimplificationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ProxyLODMeshSimplificationSettings");
		}

		// Token: 0x0600ECD9 RID: 60633 RVA: 0x0015F52E File Offset: 0x0015D72E
		protected UProxyLODMeshSimplificationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008039 RID: 32825
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ProxyLODMeshSimplificationSettings";

		// Token: 0x0400803A RID: 32826
		private static IntPtr _ClassPtr;

		// Token: 0x0400803B RID: 32827
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400803C RID: 32828
		internal static int __PropertyOffset_ProxyLODMeshReductionModuleName;
	}
}
