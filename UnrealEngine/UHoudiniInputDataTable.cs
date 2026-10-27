using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014CD RID: 5325
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputDataTable")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UHoudiniInputDataTable : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134E7 RID: 79079 RVA: 0x001C6334 File Offset: 0x001C4534
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputDataTable._ClassPtr;
		}

		// Token: 0x060134E8 RID: 79080 RVA: 0x001C6340 File Offset: 0x001C4540
		public UHoudiniInputDataTable() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputDataTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134E9 RID: 79081 RVA: 0x001C6368 File Offset: 0x001C4568
		[NullableContext(1)]
		public UHoudiniInputDataTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputDataTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060134EA RID: 79082 RVA: 0x001C639B File Offset: 0x001C459B
		static UHoudiniInputDataTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputDataTable");
		}

		// Token: 0x060134EB RID: 79083 RVA: 0x001C63A9 File Offset: 0x001C45A9
		protected UHoudiniInputDataTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6D9 RID: 42713
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputDataTable";

		// Token: 0x0400A6DA RID: 42714
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6DB RID: 42715
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
