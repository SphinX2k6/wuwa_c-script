using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B00 RID: 6912
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingFishDrawComponent")]
	[UnrealStructLayout(2320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2320)]
	public class UKuroFlockingFishDrawComponent : UInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019D7C RID: 105852 RVA: 0x002628E7 File Offset: 0x00260AE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFlockingFishDrawComponent._ClassPtr;
		}

		// Token: 0x06019D7D RID: 105853 RVA: 0x002628F4 File Offset: 0x00260AF4
		public UKuroFlockingFishDrawComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFlockingFishDrawComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019D7E RID: 105854 RVA: 0x0026291C File Offset: 0x00260B1C
		[NullableContext(1)]
		public UKuroFlockingFishDrawComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFlockingFishDrawComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019D7F RID: 105855 RVA: 0x0026294F File Offset: 0x00260B4F
		static UKuroFlockingFishDrawComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingFishDrawComponent");
		}

		// Token: 0x06019D80 RID: 105856 RVA: 0x0026295D File Offset: 0x00260B5D
		protected UKuroFlockingFishDrawComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E0D6 RID: 57558
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingFishDrawComponent";

		// Token: 0x0400E0D7 RID: 57559
		private static IntPtr _ClassPtr;

		// Token: 0x0400E0D8 RID: 57560
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
