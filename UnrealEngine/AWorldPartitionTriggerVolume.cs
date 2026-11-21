using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B5 RID: 693
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionTriggerVolume")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class AWorldPartitionTriggerVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004AFC RID: 19196 RVA: 0x00068E9E File Offset: 0x0006709E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AWorldPartitionTriggerVolume._ClassPtr;
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x00068EAC File Offset: 0x000670AC
		public AWorldPartitionTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00068ED4 File Offset: 0x000670D4
		public AWorldPartitionTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AWorldPartitionTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06004AFF RID: 19199 RVA: 0x00068F08 File Offset: 0x00067108
		// (set) Token: 0x06004B00 RID: 19200 RVA: 0x00068F41 File Offset: 0x00067141
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

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06004B01 RID: 19201 RVA: 0x00068F4F File Offset: 0x0006714F
		// (set) Token: 0x06004B02 RID: 19202 RVA: 0x00068F5F File Offset: 0x0006715F
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

		// Token: 0x06004B03 RID: 19203 RVA: 0x00068F70 File Offset: 0x00067170
		public virtual void OnStateChanged()
		{
			AWorldPartitionTriggerVolume.__OnStateChanged_Internal(base.NativePtr);
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00068F7D File Offset: 0x0006717D
		protected virtual void OnStateChanged_Implementation()
		{
			AWorldPartitionTriggerVolume.__OnStateChanged_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06004B05 RID: 19205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Internal(IntPtr @this);

		// Token: 0x06004B06 RID: 19206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Implementation_Internal(IntPtr @this);

		// Token: 0x06004B07 RID: 19207 RVA: 0x00068F8A File Offset: 0x0006718A
		static AWorldPartitionTriggerVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionTriggerVolume");
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00068F98 File Offset: 0x00067198
		protected AWorldPartitionTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D93 RID: 7571
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionTriggerVolume";

		// Token: 0x04001D94 RID: 7572
		private static IntPtr _ClassPtr;

		// Token: 0x04001D95 RID: 7573
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D96 RID: 7574
		internal static int __PropertyOffset_DatalayerStateMap;

		// Token: 0x04001D97 RID: 7575
		[Nullable(2)]
		private TMap<FName, bool> _DatalayerStateMap;

		// Token: 0x04001D98 RID: 7576
		internal static int __PropertyOffset_State;
	}
}
