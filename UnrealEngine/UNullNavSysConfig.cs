using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EF9 RID: 3833
	[UnrealObjectPath("/Script/Engine.NullNavSysConfig")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UNullNavSysConfig : UNavigationSystemConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFB3 RID: 53171 RVA: 0x0012EEBE File Offset: 0x0012D0BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNullNavSysConfig._ClassPtr;
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x0012EECC File Offset: 0x0012D0CC
		public UNullNavSysConfig() : this(BuiltinUtils.AllocNativeUObject(UNullNavSysConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x0012EEF4 File Offset: 0x0012D0F4
		[NullableContext(1)]
		public UNullNavSysConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNullNavSysConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x0012EF27 File Offset: 0x0012D127
		static UNullNavSysConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NullNavSysConfig");
		}

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x0012EF35 File Offset: 0x0012D135
		protected UNullNavSysConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006FF7 RID: 28663
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NullNavSysConfig";

		// Token: 0x04006FF8 RID: 28664
		private static IntPtr _ClassPtr;

		// Token: 0x04006FF9 RID: 28665
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
