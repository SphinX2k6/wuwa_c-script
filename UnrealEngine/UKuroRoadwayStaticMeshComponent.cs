using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001907 RID: 6407
	[UnrealObjectPath("/Script/KuroGameplay.KuroRoadwayStaticMeshComponent")]
	[UnrealStructLayout(2016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2016)]
	public class UKuroRoadwayStaticMeshComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C73 RID: 97395 RVA: 0x0022D5EA File Offset: 0x0022B7EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRoadwayStaticMeshComponent._ClassPtr;
		}

		// Token: 0x06017C74 RID: 97396 RVA: 0x0022D5F8 File Offset: 0x0022B7F8
		public UKuroRoadwayStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRoadwayStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C75 RID: 97397 RVA: 0x0022D620 File Offset: 0x0022B820
		[NullableContext(1)]
		public UKuroRoadwayStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRoadwayStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017C76 RID: 97398 RVA: 0x0022D653 File Offset: 0x0022B853
		static UKuroRoadwayStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroRoadwayStaticMeshComponent");
		}

		// Token: 0x06017C77 RID: 97399 RVA: 0x0022D661 File Offset: 0x0022B861
		protected UKuroRoadwayStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE5B RID: 52827
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroRoadwayStaticMeshComponent";

		// Token: 0x0400CE5C RID: 52828
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE5D RID: 52829
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
