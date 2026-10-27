using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200249E RID: 9374
	[UnrealObjectPath("/Script/NavigationSystem.NavLinkRenderingComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class UNavLinkRenderingComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023181 RID: 143745 RVA: 0x0033E5FC File Offset: 0x0033C7FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavLinkRenderingComponent._ClassPtr;
		}

		// Token: 0x06023182 RID: 143746 RVA: 0x0033E608 File Offset: 0x0033C808
		public UNavLinkRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UNavLinkRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023183 RID: 143747 RVA: 0x0033E630 File Offset: 0x0033C830
		[NullableContext(1)]
		public UNavLinkRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavLinkRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023184 RID: 143748 RVA: 0x0033E663 File Offset: 0x0033C863
		static UNavLinkRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavLinkRenderingComponent");
		}

		// Token: 0x06023185 RID: 143749 RVA: 0x0033E671 File Offset: 0x0033C871
		protected UNavLinkRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BC1 RID: 76737
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavLinkRenderingComponent";

		// Token: 0x04012BC2 RID: 76738
		private static IntPtr _ClassPtr;

		// Token: 0x04012BC3 RID: 76739
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
