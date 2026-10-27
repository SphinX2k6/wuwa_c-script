using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002499 RID: 9369
	[UnrealObjectPath("/Script/NavigationSystem.NavLinkComponent")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class UNavLinkComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject, INavLinkHostInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06023145 RID: 143685 RVA: 0x0033E078 File Offset: 0x0033C278
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavLinkComponent._ClassPtr;
		}

		// Token: 0x06023146 RID: 143686 RVA: 0x0033E084 File Offset: 0x0033C284
		int INavLinkHostInterface.InterfaceOffset()
		{
			return UNavLinkComponent.__InterfaceOffset_INavLinkHostInterface;
		}

		// Token: 0x06023147 RID: 143687 RVA: 0x0033E08C File Offset: 0x0033C28C
		public UNavLinkComponent() : this(BuiltinUtils.AllocNativeUObject(UNavLinkComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023148 RID: 143688 RVA: 0x0033E0B4 File Offset: 0x0033C2B4
		[NullableContext(1)]
		public UNavLinkComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavLinkComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086C9 RID: 34505
		// (get) Token: 0x06023149 RID: 143689 RVA: 0x0033E0E8 File Offset: 0x0033C2E8
		// (set) Token: 0x0602314A RID: 143690 RVA: 0x0033E121 File Offset: 0x0033C321
		[Nullable(1)]
		public TArray<FNavigationLink> Links
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FNavigationLink> result;
				if ((result = this._Links) == null)
				{
					result = (this._Links = new TArray<FNavigationLink>(base.NativePtr + (IntPtr)UNavLinkComponent.__PropertyOffset_Links, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Links.CopyAssign(value);
			}
		}

		// Token: 0x0602314B RID: 143691 RVA: 0x0033E12F File Offset: 0x0033C32F
		static UNavLinkComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavLinkComponent");
		}

		// Token: 0x0602314C RID: 143692 RVA: 0x0033E13D File Offset: 0x0033C33D
		protected UNavLinkComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B9C RID: 76700
		internal static int __InterfaceOffset_INavLinkHostInterface;

		// Token: 0x04012B9D RID: 76701
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavLinkComponent";

		// Token: 0x04012B9E RID: 76702
		private static IntPtr _ClassPtr;

		// Token: 0x04012B9F RID: 76703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BA0 RID: 76704
		internal static int __PropertyOffset_Links;

		// Token: 0x04012BA1 RID: 76705
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavigationLink> _Links;
	}
}
