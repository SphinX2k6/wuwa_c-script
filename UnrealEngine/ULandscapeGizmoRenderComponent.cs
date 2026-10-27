using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F73 RID: 8051
	[UnrealObjectPath("/Script/Landscape.LandscapeGizmoRenderComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class ULandscapeGizmoRenderComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E8C3 RID: 125123 RVA: 0x002D6716 File Offset: 0x002D4916
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeGizmoRenderComponent._ClassPtr;
		}

		// Token: 0x0601E8C4 RID: 125124 RVA: 0x002D6724 File Offset: 0x002D4924
		public ULandscapeGizmoRenderComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeGizmoRenderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E8C5 RID: 125125 RVA: 0x002D674C File Offset: 0x002D494C
		[NullableContext(1)]
		public ULandscapeGizmoRenderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeGizmoRenderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E8C6 RID: 125126 RVA: 0x002D677F File Offset: 0x002D497F
		static ULandscapeGizmoRenderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeGizmoRenderComponent");
		}

		// Token: 0x0601E8C7 RID: 125127 RVA: 0x002D678D File Offset: 0x002D498D
		protected ULandscapeGizmoRenderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010822 RID: 67618
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeGizmoRenderComponent";

		// Token: 0x04010823 RID: 67619
		private static IntPtr _ClassPtr;

		// Token: 0x04010824 RID: 67620
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
