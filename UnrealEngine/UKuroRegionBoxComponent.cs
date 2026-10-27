using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200175B RID: 5979
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionBoxComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionBoxComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060157F6 RID: 88054 RVA: 0x001F978E File Offset: 0x001F798E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionBoxComponent._ClassPtr;
		}

		// Token: 0x060157F7 RID: 88055 RVA: 0x001F979C File Offset: 0x001F799C
		public UKuroRegionBoxComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionBoxComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060157F8 RID: 88056 RVA: 0x001F97C4 File Offset: 0x001F79C4
		[NullableContext(1)]
		public UKuroRegionBoxComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionBoxComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054EA RID: 21738
		// (get) Token: 0x060157F9 RID: 88057 RVA: 0x001F97F7 File Offset: 0x001F79F7
		// (set) Token: 0x060157FA RID: 88058 RVA: 0x001F980B File Offset: 0x001F7A0B
		public unsafe FVector BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionBoxComponent.__PropertyOffset_BoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionBoxComponent.__PropertyOffset_BoxExtent) = value;
			}
		}

		// Token: 0x060157FB RID: 88059 RVA: 0x001F9820 File Offset: 0x001F7A20
		static UKuroRegionBoxComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionBoxComponent");
		}

		// Token: 0x060157FC RID: 88060 RVA: 0x001F982E File Offset: 0x001F7A2E
		protected UKuroRegionBoxComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBAE RID: 48046
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionBoxComponent";

		// Token: 0x0400BBAF RID: 48047
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBB0 RID: 48048
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBB1 RID: 48049
		internal static int __PropertyOffset_BoxExtent;
	}
}
