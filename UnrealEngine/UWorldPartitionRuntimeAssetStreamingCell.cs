using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200126C RID: 4716
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeAssetStreamingCell")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public abstract class UWorldPartitionRuntimeAssetStreamingCell : UWorldPartitionRuntimeCell, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060114C4 RID: 70852 RVA: 0x001965C6 File Offset: 0x001947C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeAssetStreamingCell._ClassPtr;
		}

		// Token: 0x060114C5 RID: 70853 RVA: 0x001965D2 File Offset: 0x001947D2
		static UWorldPartitionRuntimeAssetStreamingCell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeAssetStreamingCell");
		}

		// Token: 0x060114C6 RID: 70854 RVA: 0x001965E0 File Offset: 0x001947E0
		protected UWorldPartitionRuntimeAssetStreamingCell() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeAssetStreamingCell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060114C7 RID: 70855 RVA: 0x00196608 File Offset: 0x00194808
		protected UWorldPartitionRuntimeAssetStreamingCell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009420 RID: 37920
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeAssetStreamingCell";

		// Token: 0x04009421 RID: 37921
		private static IntPtr _ClassPtr;

		// Token: 0x04009422 RID: 37922
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
