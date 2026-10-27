using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D51 RID: 3409
	[UnrealObjectPath("/Script/Engine.LightmassImportanceComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class ULightmassImportanceComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B807 RID: 47111 RVA: 0x00105E5A File Offset: 0x0010405A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightmassImportanceComponent._ClassPtr;
		}

		// Token: 0x0600B808 RID: 47112 RVA: 0x00105E68 File Offset: 0x00104068
		public ULightmassImportanceComponent() : this(BuiltinUtils.AllocNativeUObject(ULightmassImportanceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x00105E90 File Offset: 0x00104090
		[NullableContext(1)]
		public ULightmassImportanceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightmassImportanceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x00105EC3 File Offset: 0x001040C3
		static ULightmassImportanceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightmassImportanceComponent");
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x00105ED1 File Offset: 0x001040D1
		protected ULightmassImportanceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400606F RID: 24687
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightmassImportanceComponent";

		// Token: 0x04006070 RID: 24688
		private static IntPtr _ClassPtr;

		// Token: 0x04006071 RID: 24689
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
