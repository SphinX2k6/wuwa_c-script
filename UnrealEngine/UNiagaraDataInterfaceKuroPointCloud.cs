using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A3A RID: 6714
	[UnrealObjectPath("/Script/KuroPointCloud.NiagaraDataInterfaceKuroPointCloud")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UNiagaraDataInterfaceKuroPointCloud : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018DB8 RID: 101816 RVA: 0x0024B7E1 File Offset: 0x002499E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceKuroPointCloud._ClassPtr;
		}

		// Token: 0x06018DB9 RID: 101817 RVA: 0x0024B7F0 File Offset: 0x002499F0
		public UNiagaraDataInterfaceKuroPointCloud() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroPointCloud.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018DBA RID: 101818 RVA: 0x0024B818 File Offset: 0x00249A18
		[NullableContext(1)]
		public UNiagaraDataInterfaceKuroPointCloud(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroPointCloud.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006274 RID: 25204
		// (get) Token: 0x06018DBB RID: 101819 RVA: 0x0024B84B File Offset: 0x00249A4B
		// (set) Token: 0x06018DBC RID: 101820 RVA: 0x0024B85F File Offset: 0x00249A5F
		[Nullable(2)]
		public unsafe UKuroPointCloudCache PointCloudCache
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceKuroPointCloud.__PropertyOffset_PointCloudCache);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceKuroPointCloud.__PropertyOffset_PointCloudCache, value);
			}
		}

		// Token: 0x17006275 RID: 25205
		// (get) Token: 0x06018DBD RID: 101821 RVA: 0x0024B874 File Offset: 0x00249A74
		// (set) Token: 0x06018DBE RID: 101822 RVA: 0x0024B888 File Offset: 0x00249A88
		public unsafe FName WorldCollectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceKuroPointCloud.__PropertyOffset_WorldCollectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceKuroPointCloud.__PropertyOffset_WorldCollectionName) = value;
			}
		}

		// Token: 0x06018DBF RID: 101823 RVA: 0x0024B89D File Offset: 0x00249A9D
		static UNiagaraDataInterfaceKuroPointCloud()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.NiagaraDataInterfaceKuroPointCloud");
		}

		// Token: 0x06018DC0 RID: 101824 RVA: 0x0024B8AB File Offset: 0x00249AAB
		protected UNiagaraDataInterfaceKuroPointCloud(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6DA RID: 55002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPointCloud.NiagaraDataInterfaceKuroPointCloud";

		// Token: 0x0400D6DB RID: 55003
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6DC RID: 55004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6DD RID: 55005
		internal static int __PropertyOffset_PointCloudCache;

		// Token: 0x0400D6DE RID: 55006
		internal static int __PropertyOffset_WorldCollectionName;
	}
}
