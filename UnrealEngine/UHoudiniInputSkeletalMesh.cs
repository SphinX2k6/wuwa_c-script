using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D8 RID: 5336
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputSkeletalMesh")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UHoudiniInputSkeletalMesh : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013550 RID: 79184 RVA: 0x001C6C8F File Offset: 0x001C4E8F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputSkeletalMesh._ClassPtr;
		}

		// Token: 0x06013551 RID: 79185 RVA: 0x001C6C9C File Offset: 0x001C4E9C
		public UHoudiniInputSkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013552 RID: 79186 RVA: 0x001C6CC4 File Offset: 0x001C4EC4
		[NullableContext(1)]
		public UHoudiniInputSkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013553 RID: 79187 RVA: 0x001C6CF7 File Offset: 0x001C4EF7
		static UHoudiniInputSkeletalMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputSkeletalMesh");
		}

		// Token: 0x06013554 RID: 79188 RVA: 0x001C6D05 File Offset: 0x001C4F05
		protected UHoudiniInputSkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A715 RID: 42773
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputSkeletalMesh";

		// Token: 0x0400A716 RID: 42774
		private static IntPtr _ClassPtr;

		// Token: 0x0400A717 RID: 42775
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
