using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200125C RID: 4700
	[UnrealObjectPath("/Script/Engine.WorldPartitionHLODModifier")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UWorldPartitionHLODModifier : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601143E RID: 70718 RVA: 0x0019589A File Offset: 0x00193A9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionHLODModifier._ClassPtr;
		}

		// Token: 0x0601143F RID: 70719 RVA: 0x001958A6 File Offset: 0x00193AA6
		static UWorldPartitionHLODModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionHLODModifier");
		}

		// Token: 0x06011440 RID: 70720 RVA: 0x001958B4 File Offset: 0x00193AB4
		protected UWorldPartitionHLODModifier() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHLODModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011441 RID: 70721 RVA: 0x001958DC File Offset: 0x00193ADC
		protected UWorldPartitionHLODModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093CC RID: 37836
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionHLODModifier";

		// Token: 0x040093CD RID: 37837
		private static IntPtr _ClassPtr;

		// Token: 0x040093CE RID: 37838
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
