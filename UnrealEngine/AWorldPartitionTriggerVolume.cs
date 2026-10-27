using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200128B RID: 4747
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionTriggerVolume")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class AWorldPartitionTriggerVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601165B RID: 71259 RVA: 0x001988F2 File Offset: 0x00196AF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionTriggerVolume._ClassPtr;
		}

		// Token: 0x0601165C RID: 71260 RVA: 0x00198900 File Offset: 0x00196B00
		public AWorldPartitionTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601165D RID: 71261 RVA: 0x00198928 File Offset: 0x00196B28
		public AWorldPartitionTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C1 RID: 17345
		// (get) Token: 0x0601165E RID: 71262 RVA: 0x0019895C File Offset: 0x00196B5C
		// (set) Token: 0x0601165F RID: 71263 RVA: 0x00198995 File Offset: 0x00196B95
		public TMap<FName, bool> DatalayerStateMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, bool> result;
				if ((result = this._DatalayerStateMap) == null)
				{
					result = (this._DatalayerStateMap = new TMap<FName, bool>(base.NativePtr + (IntPtr)AWorldPartitionTriggerVolume.__PropertyOffset_DatalayerStateMap, this));
				}
				return result;
			}
			set
			{
				this.DatalayerStateMap.CopyAssign(value);
			}
		}

		// Token: 0x170043C2 RID: 17346
		// (get) Token: 0x06011660 RID: 71264 RVA: 0x001989A3 File Offset: 0x00196BA3
		// (set) Token: 0x06011661 RID: 71265 RVA: 0x001989B3 File Offset: 0x00196BB3
		public unsafe EWorldPartitionTriggerVolumeState State
		{
			get
			{
				return (EWorldPartitionTriggerVolumeState)(*(base.NativePtr + (IntPtr)AWorldPartitionTriggerVolume.__PropertyOffset_State));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AWorldPartitionTriggerVolume.__PropertyOffset_State) = (byte)value;
			}
		}

		// Token: 0x06011662 RID: 71266 RVA: 0x001989C4 File Offset: 0x00196BC4
		public virtual void OnStateChanged()
		{
			AWorldPartitionTriggerVolume.__OnStateChanged_Internal(base.NativePtr);
		}

		// Token: 0x06011663 RID: 71267 RVA: 0x001989D1 File Offset: 0x00196BD1
		protected virtual void OnStateChanged_Implementation()
		{
			AWorldPartitionTriggerVolume.__OnStateChanged_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06011664 RID: 71268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Internal(IntPtr @this);

		// Token: 0x06011665 RID: 71269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Implementation_Internal(IntPtr @this);

		// Token: 0x06011666 RID: 71270 RVA: 0x001989DE File Offset: 0x00196BDE
		static AWorldPartitionTriggerVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionTriggerVolume");
		}

		// Token: 0x06011667 RID: 71271 RVA: 0x001989EC File Offset: 0x00196BEC
		protected AWorldPartitionTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094E9 RID: 38121
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionTriggerVolume";

		// Token: 0x040094EA RID: 38122
		private static IntPtr _ClassPtr;

		// Token: 0x040094EB RID: 38123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040094EC RID: 38124
		internal static int __PropertyOffset_DatalayerStateMap;

		// Token: 0x040094ED RID: 38125
		[Nullable(2)]
		private TMap<FName, bool> _DatalayerStateMap;

		// Token: 0x040094EE RID: 38126
		internal static int __PropertyOffset_State;
	}
}
