using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D57 RID: 3415
	[UnrealObjectPath("/Script/Engine.LightmassPortalComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class ULightmassPortalComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B846 RID: 47174 RVA: 0x001063E3 File Offset: 0x001045E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightmassPortalComponent._ClassPtr;
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x001063F0 File Offset: 0x001045F0
		public ULightmassPortalComponent() : this(BuiltinUtils.AllocNativeUObject(ULightmassPortalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B848 RID: 47176 RVA: 0x00106418 File Offset: 0x00104618
		[NullableContext(1)]
		public ULightmassPortalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightmassPortalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0600B849 RID: 47177 RVA: 0x0010644B File Offset: 0x0010464B
		// (set) Token: 0x0600B84A RID: 47178 RVA: 0x0010645F File Offset: 0x0010465F
		[Nullable(2)]
		public unsafe UBoxComponent PreviewBox
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULightmassPortalComponent.__PropertyOffset_PreviewBox);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULightmassPortalComponent.__PropertyOffset_PreviewBox, value);
			}
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x00106474 File Offset: 0x00104674
		static ULightmassPortalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightmassPortalComponent");
		}

		// Token: 0x0600B84C RID: 47180 RVA: 0x00106482 File Offset: 0x00104682
		protected ULightmassPortalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400608F RID: 24719
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightmassPortalComponent";

		// Token: 0x04006090 RID: 24720
		private static IntPtr _ClassPtr;

		// Token: 0x04006091 RID: 24721
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006092 RID: 24722
		internal static int __PropertyOffset_PreviewBox;
	}
}
