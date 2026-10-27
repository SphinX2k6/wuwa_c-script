using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020FB RID: 8443
	[UnrealObjectPath("/Script/LGUI.PrefabActorHierarchyData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UPrefabActorHierarchyData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC61 RID: 130145 RVA: 0x002F40AF File Offset: 0x002F22AF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrefabActorHierarchyData._ClassPtr;
		}

		// Token: 0x0601FC62 RID: 130146 RVA: 0x002F40BC File Offset: 0x002F22BC
		public UPrefabActorHierarchyData() : this(BuiltinUtils.AllocNativeUObject(UPrefabActorHierarchyData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC63 RID: 130147 RVA: 0x002F40E4 File Offset: 0x002F22E4
		[NullableContext(1)]
		public UPrefabActorHierarchyData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrefabActorHierarchyData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FC64 RID: 130148 RVA: 0x002F4117 File Offset: 0x002F2317
		static UPrefabActorHierarchyData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.PrefabActorHierarchyData");
		}

		// Token: 0x0601FC65 RID: 130149 RVA: 0x002F4125 File Offset: 0x002F2325
		protected UPrefabActorHierarchyData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011200 RID: 70144
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.PrefabActorHierarchyData";

		// Token: 0x04011201 RID: 70145
		private static IntPtr _ClassPtr;

		// Token: 0x04011202 RID: 70146
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
