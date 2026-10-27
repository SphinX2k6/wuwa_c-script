using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200125A RID: 4698
	[UnrealObjectPath("/Script/Engine.WorldPartitionExclusiveDataLayerTriggerVolume")]
	[UnrealStructLayout(1256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1256)]
	public class AWorldPartitionExclusiveDataLayerTriggerVolume : AWorldPartitionTriggerVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601142C RID: 70700 RVA: 0x00195706 File Offset: 0x00193906
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionExclusiveDataLayerTriggerVolume._ClassPtr;
		}

		// Token: 0x0601142D RID: 70701 RVA: 0x00195714 File Offset: 0x00193914
		public AWorldPartitionExclusiveDataLayerTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionExclusiveDataLayerTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601142E RID: 70702 RVA: 0x0019573C File Offset: 0x0019393C
		[NullableContext(1)]
		public AWorldPartitionExclusiveDataLayerTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionExclusiveDataLayerTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601142F RID: 70703 RVA: 0x0019576F File Offset: 0x0019396F
		static AWorldPartitionExclusiveDataLayerTriggerVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionExclusiveDataLayerTriggerVolume");
		}

		// Token: 0x06011430 RID: 70704 RVA: 0x0019577D File Offset: 0x0019397D
		protected AWorldPartitionExclusiveDataLayerTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093C2 RID: 37826
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionExclusiveDataLayerTriggerVolume";

		// Token: 0x040093C3 RID: 37827
		private static IntPtr _ClassPtr;

		// Token: 0x040093C4 RID: 37828
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
