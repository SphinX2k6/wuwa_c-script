using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001286 RID: 4742
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionStreamingPolicy")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public abstract class UWorldPartitionStreamingPolicy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060115D9 RID: 71129 RVA: 0x00197D5E File Offset: 0x00195F5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionStreamingPolicy._ClassPtr;
		}

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x060115DA RID: 71130 RVA: 0x00197D6C File Offset: 0x00195F6C
		// (set) Token: 0x060115DB RID: 71131 RVA: 0x00197DA5 File Offset: 0x00195FA5
		public TMap<FName, UWorldPartitionRuntimeCell> ExternalStreamingObjectsToCells
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UWorldPartitionRuntimeCell> result;
				if ((result = this._ExternalStreamingObjectsToCells) == null)
				{
					result = (this._ExternalStreamingObjectsToCells = new TMap<FName, UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_ExternalStreamingObjectsToCells, this));
				}
				return result;
			}
			set
			{
				this.ExternalStreamingObjectsToCells.CopyAssign(value);
			}
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x060115DC RID: 71132 RVA: 0x00197DB4 File Offset: 0x00195FB4
		// (set) Token: 0x060115DD RID: 71133 RVA: 0x00197DED File Offset: 0x00195FED
		public FWorldPartitionUpdateStreamingCurrentState CurrentState
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionUpdateStreamingCurrentState result;
				if ((result = this._CurrentState) == null)
				{
					result = (this._CurrentState = new FWorldPartitionUpdateStreamingCurrentState(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_CurrentState, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionUpdateStreamingCurrentState.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_CurrentState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x060115DE RID: 71134 RVA: 0x00197E0E File Offset: 0x0019600E
		// (set) Token: 0x060115DF RID: 71135 RVA: 0x00197E1E File Offset: 0x0019601E
		public unsafe EWorldPartitionStreamingPerformance CurrentStreamingPerformance
		{
			get
			{
				return (EWorldPartitionStreamingPerformance)(*(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_CurrentStreamingPerformance));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_CurrentStreamingPerformance) = (byte)value;
			}
		}

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x060115E0 RID: 71136 RVA: 0x00197E30 File Offset: 0x00196030
		// (set) Token: 0x060115E1 RID: 71137 RVA: 0x00197E69 File Offset: 0x00196069
		public FWorldPartitionUpdateStreamingTargetState TargetState
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionUpdateStreamingTargetState result;
				if ((result = this._TargetState) == null)
				{
					result = (this._TargetState = new FWorldPartitionUpdateStreamingTargetState(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_TargetState, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionUpdateStreamingTargetState.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_TargetState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x060115E2 RID: 71138 RVA: 0x00197E8C File Offset: 0x0019608C
		// (set) Token: 0x060115E3 RID: 71139 RVA: 0x00197EC5 File Offset: 0x001960C5
		public FWorldPartitionUpdateStreamingCurrentState AsyncTaskCurrentState
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionUpdateStreamingCurrentState result;
				if ((result = this._AsyncTaskCurrentState) == null)
				{
					result = (this._AsyncTaskCurrentState = new FWorldPartitionUpdateStreamingCurrentState(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_AsyncTaskCurrentState, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionUpdateStreamingCurrentState.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_AsyncTaskCurrentState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x060115E4 RID: 71140 RVA: 0x00197EE8 File Offset: 0x001960E8
		// (set) Token: 0x060115E5 RID: 71141 RVA: 0x00197F21 File Offset: 0x00196121
		public FWorldPartitionUpdateStreamingTargetState AsyncTaskTargetState
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionUpdateStreamingTargetState result;
				if ((result = this._AsyncTaskTargetState) == null)
				{
					result = (this._AsyncTaskTargetState = new FWorldPartitionUpdateStreamingTargetState(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_AsyncTaskTargetState, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionUpdateStreamingTargetState.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_AsyncTaskTargetState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x060115E6 RID: 71142 RVA: 0x00197F42 File Offset: 0x00196142
		// (set) Token: 0x060115E7 RID: 71143 RVA: 0x00197F52 File Offset: 0x00196152
		public unsafe bool bShouldMergeStreamingSourceInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_bShouldMergeStreamingSourceInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionStreamingPolicy.__PropertyOffset_bShouldMergeStreamingSourceInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x060115E8 RID: 71144 RVA: 0x00197F63 File Offset: 0x00196163
		static UWorldPartitionStreamingPolicy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionStreamingPolicy");
		}

		// Token: 0x060115E9 RID: 71145 RVA: 0x00197F74 File Offset: 0x00196174
		protected UWorldPartitionStreamingPolicy() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionStreamingPolicy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060115EA RID: 71146 RVA: 0x00197F9C File Offset: 0x0019619C
		protected UWorldPartitionStreamingPolicy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094B2 RID: 38066
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionStreamingPolicy";

		// Token: 0x040094B3 RID: 38067
		private static IntPtr _ClassPtr;

		// Token: 0x040094B4 RID: 38068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040094B5 RID: 38069
		internal static int __PropertyOffset_ExternalStreamingObjectsToCells;

		// Token: 0x040094B6 RID: 38070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UWorldPartitionRuntimeCell> _ExternalStreamingObjectsToCells;

		// Token: 0x040094B7 RID: 38071
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x040094B8 RID: 38072
		[Nullable(2)]
		private FWorldPartitionUpdateStreamingCurrentState _CurrentState;

		// Token: 0x040094B9 RID: 38073
		internal static int __PropertyOffset_CurrentStreamingPerformance;

		// Token: 0x040094BA RID: 38074
		internal static int __PropertyOffset_TargetState;

		// Token: 0x040094BB RID: 38075
		[Nullable(2)]
		private FWorldPartitionUpdateStreamingTargetState _TargetState;

		// Token: 0x040094BC RID: 38076
		internal static int __PropertyOffset_AsyncTaskCurrentState;

		// Token: 0x040094BD RID: 38077
		[Nullable(2)]
		private FWorldPartitionUpdateStreamingCurrentState _AsyncTaskCurrentState;

		// Token: 0x040094BE RID: 38078
		internal static int __PropertyOffset_AsyncTaskTargetState;

		// Token: 0x040094BF RID: 38079
		[Nullable(2)]
		private FWorldPartitionUpdateStreamingTargetState _AsyncTaskTargetState;

		// Token: 0x040094C0 RID: 38080
		internal static int __PropertyOffset_bShouldMergeStreamingSourceInfo;
	}
}
