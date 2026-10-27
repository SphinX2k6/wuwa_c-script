using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009B9 RID: 2489
	[UnrealObjectPath("/Script/Engine.DeviceProfileFragment")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UDeviceProfileFragment : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CA2 RID: 36002 RVA: 0x000C9422 File Offset: 0x000C7622
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDeviceProfileFragment._ClassPtr;
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x000C9430 File Offset: 0x000C7630
		public UDeviceProfileFragment() : this(BuiltinUtils.AllocNativeUObject(UDeviceProfileFragment.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x000C9458 File Offset: 0x000C7658
		[NullableContext(1)]
		public UDeviceProfileFragment(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDeviceProfileFragment.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x000C948B File Offset: 0x000C768B
		static UDeviceProfileFragment()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DeviceProfileFragment");
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x000C9499 File Offset: 0x000C7699
		protected UDeviceProfileFragment(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042C5 RID: 17093
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DeviceProfileFragment";

		// Token: 0x040042C6 RID: 17094
		private static IntPtr _ClassPtr;

		// Token: 0x040042C7 RID: 17095
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
