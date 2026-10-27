using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200127B RID: 4731
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeHash")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public abstract class UWorldPartitionRuntimeHash : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011567 RID: 71015 RVA: 0x00197228 File Offset: 0x00195428
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeHash._ClassPtr;
		}

		// Token: 0x06011568 RID: 71016 RVA: 0x00197234 File Offset: 0x00195434
		static UWorldPartitionRuntimeHash()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeHash");
		}

		// Token: 0x06011569 RID: 71017 RVA: 0x00197244 File Offset: 0x00195444
		protected UWorldPartitionRuntimeHash() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeHash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601156A RID: 71018 RVA: 0x0019726C File Offset: 0x0019546C
		protected UWorldPartitionRuntimeHash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400946A RID: 37994
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeHash";

		// Token: 0x0400946B RID: 37995
		private static IntPtr _ClassPtr;

		// Token: 0x0400946C RID: 37996
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
