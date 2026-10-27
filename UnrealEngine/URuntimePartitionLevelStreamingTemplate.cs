using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B5 RID: 4277
	[UnrealObjectPath("/Script/Engine.RuntimePartitionLevelStreamingTemplate")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class URuntimePartitionLevelStreamingTemplate : URuntimePartitionTemplate, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F465 RID: 62565 RVA: 0x0016A686 File Offset: 0x00168886
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionLevelStreamingTemplate._ClassPtr;
		}

		// Token: 0x0600F466 RID: 62566 RVA: 0x0016A694 File Offset: 0x00168894
		public URuntimePartitionLevelStreamingTemplate() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLevelStreamingTemplate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F467 RID: 62567 RVA: 0x0016A6BC File Offset: 0x001688BC
		[NullableContext(1)]
		public URuntimePartitionLevelStreamingTemplate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLevelStreamingTemplate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F468 RID: 62568 RVA: 0x0016A6EF File Offset: 0x001688EF
		static URuntimePartitionLevelStreamingTemplate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionLevelStreamingTemplate");
		}

		// Token: 0x0600F469 RID: 62569 RVA: 0x0016A6FD File Offset: 0x001688FD
		protected URuntimePartitionLevelStreamingTemplate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008474 RID: 33908
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionLevelStreamingTemplate";

		// Token: 0x04008475 RID: 33909
		private static IntPtr _ClassPtr;

		// Token: 0x04008476 RID: 33910
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
