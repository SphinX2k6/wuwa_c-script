using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019EA RID: 6634
	[UnrealObjectPath("/Script/KuroNavMeshCookData.NavEdgesExportVolume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ANavEdgesExportVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060189C7 RID: 100807 RVA: 0x002443B2 File Offset: 0x002425B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavEdgesExportVolume._ClassPtr;
		}

		// Token: 0x060189C8 RID: 100808 RVA: 0x002443C0 File Offset: 0x002425C0
		public ANavEdgesExportVolume() : this(BuiltinUtils.AllocNativeUObject(ANavEdgesExportVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060189C9 RID: 100809 RVA: 0x002443E8 File Offset: 0x002425E8
		[NullableContext(1)]
		public ANavEdgesExportVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavEdgesExportVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060189CA RID: 100810 RVA: 0x0024441B File Offset: 0x0024261B
		static ANavEdgesExportVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNavMeshCookData.NavEdgesExportVolume");
		}

		// Token: 0x060189CB RID: 100811 RVA: 0x00244429 File Offset: 0x00242629
		protected ANavEdgesExportVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4D7 RID: 54487
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNavMeshCookData.NavEdgesExportVolume";

		// Token: 0x0400D4D8 RID: 54488
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4D9 RID: 54489
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
