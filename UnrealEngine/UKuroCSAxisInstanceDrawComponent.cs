using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200179F RID: 6047
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSAxisInstanceDrawComponent")]
	[UnrealStructLayout(2320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2320)]
	public class UKuroCSAxisInstanceDrawComponent : UInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015CDF RID: 89311 RVA: 0x002005F8 File Offset: 0x001FE7F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCSAxisInstanceDrawComponent._ClassPtr;
		}

		// Token: 0x06015CE0 RID: 89312 RVA: 0x00200604 File Offset: 0x001FE804
		public UKuroCSAxisInstanceDrawComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCSAxisInstanceDrawComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015CE1 RID: 89313 RVA: 0x0020062C File Offset: 0x001FE82C
		[NullableContext(1)]
		public UKuroCSAxisInstanceDrawComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCSAxisInstanceDrawComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015CE2 RID: 89314 RVA: 0x0020065F File Offset: 0x001FE85F
		static UKuroCSAxisInstanceDrawComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSAxisInstanceDrawComponent");
		}

		// Token: 0x06015CE3 RID: 89315 RVA: 0x0020066D File Offset: 0x001FE86D
		protected UKuroCSAxisInstanceDrawComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BE53 RID: 48723
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSAxisInstanceDrawComponent";

		// Token: 0x0400BE54 RID: 48724
		private static IntPtr _ClassPtr;

		// Token: 0x0400BE55 RID: 48725
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
