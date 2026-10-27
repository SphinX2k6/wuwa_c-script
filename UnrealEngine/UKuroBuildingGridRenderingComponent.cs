using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016B8 RID: 5816
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridRenderingComponent")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class UKuroBuildingGridRenderingComponent : UDebugDrawComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015165 RID: 86373 RVA: 0x001EFE84 File Offset: 0x001EE084
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBuildingGridRenderingComponent._ClassPtr;
		}

		// Token: 0x06015166 RID: 86374 RVA: 0x001EFE90 File Offset: 0x001EE090
		public UKuroBuildingGridRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015167 RID: 86375 RVA: 0x001EFEB8 File Offset: 0x001EE0B8
		[NullableContext(1)]
		public UKuroBuildingGridRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015168 RID: 86376 RVA: 0x001EFEEB File Offset: 0x001EE0EB
		static UKuroBuildingGridRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridRenderingComponent");
		}

		// Token: 0x06015169 RID: 86377 RVA: 0x001EFEF9 File Offset: 0x001EE0F9
		protected UKuroBuildingGridRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B79A RID: 47002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridRenderingComponent";

		// Token: 0x0400B79B RID: 47003
		private static IntPtr _ClassPtr;

		// Token: 0x0400B79C RID: 47004
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
