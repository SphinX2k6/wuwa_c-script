using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001275 RID: 4725
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellTransformer")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UWorldPartitionRuntimeCellTransformer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011535 RID: 70965 RVA: 0x00196E3E File Offset: 0x0019503E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeCellTransformer._ClassPtr;
		}

		// Token: 0x17004388 RID: 17288
		// (get) Token: 0x06011536 RID: 70966 RVA: 0x00196E4A File Offset: 0x0019504A
		// (set) Token: 0x06011537 RID: 70967 RVA: 0x00196E5A File Offset: 0x0019505A
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCellTransformer.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeCellTransformer.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06011538 RID: 70968 RVA: 0x00196E6B File Offset: 0x0019506B
		static UWorldPartitionRuntimeCellTransformer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeCellTransformer");
		}

		// Token: 0x06011539 RID: 70969 RVA: 0x00196E7C File Offset: 0x0019507C
		protected UWorldPartitionRuntimeCellTransformer() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeCellTransformer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601153A RID: 70970 RVA: 0x00196EA4 File Offset: 0x001950A4
		protected UWorldPartitionRuntimeCellTransformer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009453 RID: 37971
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellTransformer";

		// Token: 0x04009454 RID: 37972
		private static IntPtr _ClassPtr;

		// Token: 0x04009455 RID: 37973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009456 RID: 37974
		internal static int __PropertyOffset_bEnabled;
	}
}
