using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EE1 RID: 3809
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NavLinkDefinition")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class UNavLinkDefinition : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CE63 RID: 52835 RVA: 0x0012D37C File Offset: 0x0012B57C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavLinkDefinition._ClassPtr;
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0600CE64 RID: 52836 RVA: 0x0012D388 File Offset: 0x0012B588
		// (set) Token: 0x0600CE65 RID: 52837 RVA: 0x0012D3C1 File Offset: 0x0012B5C1
		public TArray<FNavigationLink> Links
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNavigationLink> result;
				if ((result = this._Links) == null)
				{
					result = (this._Links = new TArray<FNavigationLink>(base.NativePtr + (IntPtr)UNavLinkDefinition.__PropertyOffset_Links, this));
				}
				return result;
			}
			set
			{
				this.Links.CopyAssign(value);
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0600CE66 RID: 52838 RVA: 0x0012D3D0 File Offset: 0x0012B5D0
		// (set) Token: 0x0600CE67 RID: 52839 RVA: 0x0012D409 File Offset: 0x0012B609
		public TArray<FNavigationSegmentLink> SegmentLinks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNavigationSegmentLink> result;
				if ((result = this._SegmentLinks) == null)
				{
					result = (this._SegmentLinks = new TArray<FNavigationSegmentLink>(base.NativePtr + (IntPtr)UNavLinkDefinition.__PropertyOffset_SegmentLinks, this));
				}
				return result;
			}
			set
			{
				this.SegmentLinks.CopyAssign(value);
			}
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x0012D417 File Offset: 0x0012B617
		static UNavLinkDefinition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavLinkDefinition");
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x0012D428 File Offset: 0x0012B628
		protected UNavLinkDefinition() : this(BuiltinUtils.AllocNativeUObject(UNavLinkDefinition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CE6A RID: 52842 RVA: 0x0012D450 File Offset: 0x0012B650
		protected UNavLinkDefinition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F4C RID: 28492
		public new const string __ObjectPath = "/Script/Engine.NavLinkDefinition";

		// Token: 0x04006F4D RID: 28493
		private static IntPtr _ClassPtr;

		// Token: 0x04006F4E RID: 28494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006F4F RID: 28495
		internal static int __PropertyOffset_Links;

		// Token: 0x04006F50 RID: 28496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavigationLink> _Links;

		// Token: 0x04006F51 RID: 28497
		internal static int __PropertyOffset_SegmentLinks;

		// Token: 0x04006F52 RID: 28498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavigationSegmentLink> _SegmentLinks;
	}
}
