using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014DB RID: 5339
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputStaticMesh")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UHoudiniInputStaticMesh : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013569 RID: 79209 RVA: 0x001C6EDA File Offset: 0x001C50DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputStaticMesh._ClassPtr;
		}

		// Token: 0x0601356A RID: 79210 RVA: 0x001C6EE8 File Offset: 0x001C50E8
		public UHoudiniInputStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601356B RID: 79211 RVA: 0x001C6F10 File Offset: 0x001C5110
		[NullableContext(1)]
		public UHoudiniInputStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601356C RID: 79212 RVA: 0x001C6F43 File Offset: 0x001C5143
		static UHoudiniInputStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputStaticMesh");
		}

		// Token: 0x0601356D RID: 79213 RVA: 0x001C6F51 File Offset: 0x001C5151
		protected UHoudiniInputStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A724 RID: 42788
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputStaticMesh";

		// Token: 0x0400A725 RID: 42789
		private static IntPtr _ClassPtr;

		// Token: 0x0400A726 RID: 42790
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
