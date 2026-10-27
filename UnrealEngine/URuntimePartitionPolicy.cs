using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B9 RID: 4281
	[UnrealObjectPath("/Script/Engine.RuntimePartitionPolicy")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class URuntimePartitionPolicy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F479 RID: 62585 RVA: 0x0016A886 File Offset: 0x00168A86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimePartitionPolicy._ClassPtr;
		}

		// Token: 0x0600F47A RID: 62586 RVA: 0x0016A892 File Offset: 0x00168A92
		static URuntimePartitionPolicy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimePartitionPolicy");
		}

		// Token: 0x0600F47B RID: 62587 RVA: 0x0016A8A0 File Offset: 0x00168AA0
		protected URuntimePartitionPolicy() : this(BuiltinUtils.AllocNativeUObject(URuntimePartitionPolicy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F47C RID: 62588 RVA: 0x0016A8C8 File Offset: 0x00168AC8
		protected URuntimePartitionPolicy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008480 RID: 33920
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimePartitionPolicy";

		// Token: 0x04008481 RID: 33921
		private static IntPtr _ClassPtr;

		// Token: 0x04008482 RID: 33922
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
