using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000344 RID: 836
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionBoxComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRegionBoxComponent : UKuroRegionShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600560E RID: 22030 RVA: 0x00078A65 File Offset: 0x00076C65
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionBoxComponent._ClassPtr;
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x00078A74 File Offset: 0x00076C74
		public UKuroRegionBoxComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionBoxComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x00078A9C File Offset: 0x00076C9C
		[NullableContext(1)]
		public UKuroRegionBoxComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionBoxComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06005611 RID: 22033 RVA: 0x00078ACF File Offset: 0x00076CCF
		// (set) Token: 0x06005612 RID: 22034 RVA: 0x00078AE3 File Offset: 0x00076CE3
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

		// Token: 0x06005613 RID: 22035 RVA: 0x00078AF8 File Offset: 0x00076CF8
		static UKuroRegionBoxComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionBoxComponent");
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00078B06 File Offset: 0x00076D06
		protected UKuroRegionBoxComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400234A RID: 9034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionBoxComponent";

		// Token: 0x0400234B RID: 9035
		private static IntPtr _ClassPtr;

		// Token: 0x0400234C RID: 9036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400234D RID: 9037
		internal static int __PropertyOffset_BoxExtent;
	}
}
