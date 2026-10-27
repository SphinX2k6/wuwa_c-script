using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001185 RID: 4485
	[UnrealObjectPath("/Script/Engine.StandaloneSpecialStaticMeshBodySetup")]
	[UnrealStructLayout(864, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 864)]
	public class UStandaloneSpecialStaticMeshBodySetup : USpecialStaticMeshBodySetup, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060107CE RID: 67534 RVA: 0x001836BE File Offset: 0x001818BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStandaloneSpecialStaticMeshBodySetup._ClassPtr;
		}

		// Token: 0x060107CF RID: 67535 RVA: 0x001836CC File Offset: 0x001818CC
		public UStandaloneSpecialStaticMeshBodySetup() : this(BuiltinUtils.AllocNativeUObject(UStandaloneSpecialStaticMeshBodySetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060107D0 RID: 67536 RVA: 0x001836F4 File Offset: 0x001818F4
		[NullableContext(1)]
		public UStandaloneSpecialStaticMeshBodySetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStandaloneSpecialStaticMeshBodySetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060107D1 RID: 67537 RVA: 0x00183727 File Offset: 0x00181927
		static UStandaloneSpecialStaticMeshBodySetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StandaloneSpecialStaticMeshBodySetup");
		}

		// Token: 0x060107D2 RID: 67538 RVA: 0x00183735 File Offset: 0x00181935
		protected UStandaloneSpecialStaticMeshBodySetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008D20 RID: 36128
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StandaloneSpecialStaticMeshBodySetup";

		// Token: 0x04008D21 RID: 36129
		private static IntPtr _ClassPtr;

		// Token: 0x04008D22 RID: 36130
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
