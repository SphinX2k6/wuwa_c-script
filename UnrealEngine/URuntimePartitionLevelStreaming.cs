using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B4 RID: 4276
	[UnrealObjectPath("/Script/Engine.RuntimePartitionLevelStreaming")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class URuntimePartitionLevelStreaming : URuntimePartition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F460 RID: 62560 RVA: 0x0016A607 File Offset: 0x00168807
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionLevelStreaming._ClassPtr;
		}

		// Token: 0x0600F461 RID: 62561 RVA: 0x0016A614 File Offset: 0x00168814
		public URuntimePartitionLevelStreaming() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLevelStreaming.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F462 RID: 62562 RVA: 0x0016A63C File Offset: 0x0016883C
		[NullableContext(1)]
		public URuntimePartitionLevelStreaming(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionLevelStreaming.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F463 RID: 62563 RVA: 0x0016A66F File Offset: 0x0016886F
		static URuntimePartitionLevelStreaming()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionLevelStreaming");
		}

		// Token: 0x0600F464 RID: 62564 RVA: 0x0016A67D File Offset: 0x0016887D
		protected URuntimePartitionLevelStreaming(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008471 RID: 33905
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionLevelStreaming";

		// Token: 0x04008472 RID: 33906
		private static IntPtr _ClassPtr;

		// Token: 0x04008473 RID: 33907
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
