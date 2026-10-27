using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001761 RID: 5985
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionSphereComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionSphereComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015837 RID: 88119 RVA: 0x001F9D09 File Offset: 0x001F7F09
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionSphereComponent._ClassPtr;
		}

		// Token: 0x06015838 RID: 88120 RVA: 0x001F9D18 File Offset: 0x001F7F18
		public UKuroRegionSphereComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015839 RID: 88121 RVA: 0x001F9D40 File Offset: 0x001F7F40
		[NullableContext(1)]
		public UKuroRegionSphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionSphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054F4 RID: 21748
		// (get) Token: 0x0601583A RID: 88122 RVA: 0x001F9D73 File Offset: 0x001F7F73
		// (set) Token: 0x0601583B RID: 88123 RVA: 0x001F9D83 File Offset: 0x001F7F83
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRegionSphereComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRegionSphereComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x0601583C RID: 88124 RVA: 0x001F9D94 File Offset: 0x001F7F94
		static UKuroRegionSphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionSphereComponent");
		}

		// Token: 0x0601583D RID: 88125 RVA: 0x001F9DA2 File Offset: 0x001F7FA2
		protected UKuroRegionSphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBCD RID: 48077
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionSphereComponent";

		// Token: 0x0400BBCE RID: 48078
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBCF RID: 48079
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBD0 RID: 48080
		internal static int __PropertyOffset_Radius;
	}
}
