using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B5F RID: 7007
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerSyncComponent")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKuroMaterialControllerSyncComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A87D RID: 108669 RVA: 0x00271E2E File Offset: 0x0027002E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialControllerSyncComponent._ClassPtr;
		}

		// Token: 0x0601A87E RID: 108670 RVA: 0x00271E3C File Offset: 0x0027003C
		public UKuroMaterialControllerSyncComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerSyncComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A87F RID: 108671 RVA: 0x00271E64 File Offset: 0x00270064
		[NullableContext(1)]
		public UKuroMaterialControllerSyncComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerSyncComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A880 RID: 108672 RVA: 0x00271E97 File Offset: 0x00270097
		static UKuroMaterialControllerSyncComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerSyncComponent");
		}

		// Token: 0x0601A881 RID: 108673 RVA: 0x00271EA5 File Offset: 0x002700A5
		protected UKuroMaterialControllerSyncComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E5E3 RID: 58851
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerSyncComponent";

		// Token: 0x0400E5E4 RID: 58852
		private static IntPtr _ClassPtr;

		// Token: 0x0400E5E5 RID: 58853
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
