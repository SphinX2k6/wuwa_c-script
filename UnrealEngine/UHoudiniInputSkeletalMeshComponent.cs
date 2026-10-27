using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D9 RID: 5337
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputSkeletalMeshComponent")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UHoudiniInputSkeletalMeshComponent : UHoudiniInputSceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013555 RID: 79189 RVA: 0x001C6D0E File Offset: 0x001C4F0E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputSkeletalMeshComponent._ClassPtr;
		}

		// Token: 0x06013556 RID: 79190 RVA: 0x001C6D1C File Offset: 0x001C4F1C
		public UHoudiniInputSkeletalMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSkeletalMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013557 RID: 79191 RVA: 0x001C6D44 File Offset: 0x001C4F44
		[NullableContext(1)]
		public UHoudiniInputSkeletalMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSkeletalMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013558 RID: 79192 RVA: 0x001C6D77 File Offset: 0x001C4F77
		static UHoudiniInputSkeletalMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputSkeletalMeshComponent");
		}

		// Token: 0x06013559 RID: 79193 RVA: 0x001C6D85 File Offset: 0x001C4F85
		protected UHoudiniInputSkeletalMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A718 RID: 42776
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputSkeletalMeshComponent";

		// Token: 0x0400A719 RID: 42777
		private static IntPtr _ClassPtr;

		// Token: 0x0400A71A RID: 42778
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
