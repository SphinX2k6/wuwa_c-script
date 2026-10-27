using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001263 RID: 4707
	[UnrealObjectPath("/Script/Engine.WorldPartitionKuroCellLayerTrigger")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AWorldPartitionKuroCellLayerTrigger : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011465 RID: 70757 RVA: 0x00195CC2 File Offset: 0x00193EC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionKuroCellLayerTrigger._ClassPtr;
		}

		// Token: 0x06011466 RID: 70758 RVA: 0x00195CD0 File Offset: 0x00193ED0
		public AWorldPartitionKuroCellLayerTrigger() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionKuroCellLayerTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011467 RID: 70759 RVA: 0x00195CF8 File Offset: 0x00193EF8
		[NullableContext(1)]
		public AWorldPartitionKuroCellLayerTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionKuroCellLayerTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011468 RID: 70760 RVA: 0x00195D2B File Offset: 0x00193F2B
		public virtual void OnTeleportStart()
		{
			AWorldPartitionKuroCellLayerTrigger.__OnTeleportStart_Internal(base.NativePtr);
		}

		// Token: 0x06011469 RID: 70761 RVA: 0x00195D38 File Offset: 0x00193F38
		[NullableContext(2)]
		public static void NotifyAllCellLayerTriggerTeleportStart(AActor WorldContext)
		{
			AWorldPartitionKuroCellLayerTrigger.__NotifyAllCellLayerTriggerTeleportStart_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601146A RID: 70762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTeleportStart_Internal(IntPtr @this);

		// Token: 0x0601146B RID: 70763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyAllCellLayerTriggerTeleportStart_Internal(IntPtr WorldContext);

		// Token: 0x0601146C RID: 70764 RVA: 0x00195D4F File Offset: 0x00193F4F
		static AWorldPartitionKuroCellLayerTrigger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionKuroCellLayerTrigger");
		}

		// Token: 0x0601146D RID: 70765 RVA: 0x00195D5D File Offset: 0x00193F5D
		protected AWorldPartitionKuroCellLayerTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093E9 RID: 37865
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionKuroCellLayerTrigger";

		// Token: 0x040093EA RID: 37866
		private static IntPtr _ClassPtr;

		// Token: 0x040093EB RID: 37867
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
