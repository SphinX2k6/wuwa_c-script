using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200109F RID: 4255
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RootMotionSource")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRootMotionSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F326 RID: 62246 RVA: 0x0016892B File Offset: 0x00166B2B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSource._ScriptStructPtr != 0) ? FRootMotionSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSource", ref FRootMotionSource._ScriptStructPtr);
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0600F327 RID: 62247 RVA: 0x0016894F File Offset: 0x00166B4F
		// (set) Token: 0x0600F328 RID: 62248 RVA: 0x0016895F File Offset: 0x00166B5F
		public unsafe ushort Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Priority) = (short)value;
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0600F329 RID: 62249 RVA: 0x00168970 File Offset: 0x00166B70
		// (set) Token: 0x0600F32A RID: 62250 RVA: 0x00168980 File Offset: 0x00166B80
		public unsafe ushort LocalID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_LocalID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_LocalID) = (short)value;
			}
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0600F32B RID: 62251 RVA: 0x00168991 File Offset: 0x00166B91
		// (set) Token: 0x0600F32C RID: 62252 RVA: 0x001689A1 File Offset: 0x00166BA1
		public unsafe ERootMotionAccumulateMode AccumulateMode
		{
			get
			{
				return (ERootMotionAccumulateMode)(*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_AccumulateMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_AccumulateMode) = (byte)value;
			}
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0600F32D RID: 62253 RVA: 0x001689B2 File Offset: 0x00166BB2
		// (set) Token: 0x0600F32E RID: 62254 RVA: 0x001689C6 File Offset: 0x00166BC6
		public unsafe FName InstanceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_InstanceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_InstanceName) = value;
			}
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x0600F32F RID: 62255 RVA: 0x001689DB File Offset: 0x00166BDB
		// (set) Token: 0x0600F330 RID: 62256 RVA: 0x001689EB File Offset: 0x00166BEB
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0600F331 RID: 62257 RVA: 0x001689FC File Offset: 0x00166BFC
		// (set) Token: 0x0600F332 RID: 62258 RVA: 0x00168A0C File Offset: 0x00166C0C
		public unsafe float CurrentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_CurrentTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_CurrentTime) = value;
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0600F333 RID: 62259 RVA: 0x00168A1D File Offset: 0x00166C1D
		// (set) Token: 0x0600F334 RID: 62260 RVA: 0x00168A2D File Offset: 0x00166C2D
		public unsafe float PreviousTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_PreviousTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_PreviousTime) = value;
			}
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x0600F335 RID: 62261 RVA: 0x00168A3E File Offset: 0x00166C3E
		// (set) Token: 0x0600F336 RID: 62262 RVA: 0x00168A4E File Offset: 0x00166C4E
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0600F337 RID: 62263 RVA: 0x00168A60 File Offset: 0x00166C60
		// (set) Token: 0x0600F338 RID: 62264 RVA: 0x00168AA3 File Offset: 0x00166CA3
		public FRootMotionSourceStatus Status
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionSourceStatus result;
				if ((result = this._Status) == null)
				{
					result = (this._Status = new FRootMotionSourceStatus(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Status, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionSourceStatus.StaticStruct(), base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Status, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0600F339 RID: 62265 RVA: 0x00168AC4 File Offset: 0x00166CC4
		// (set) Token: 0x0600F33A RID: 62266 RVA: 0x00168B07 File Offset: 0x00166D07
		public FRootMotionSourceSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionSourceSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FRootMotionSourceSettings(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Settings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionSourceSettings.StaticStruct(), base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0600F33B RID: 62267 RVA: 0x00168B28 File Offset: 0x00166D28
		// (set) Token: 0x0600F33C RID: 62268 RVA: 0x00168B38 File Offset: 0x00166D38
		public unsafe bool bInLocalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_bInLocalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_bInLocalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0600F33D RID: 62269 RVA: 0x00168B4C File Offset: 0x00166D4C
		// (set) Token: 0x0600F33E RID: 62270 RVA: 0x00168B8F File Offset: 0x00166D8F
		public FRootMotionMovementParams RootMotionParams
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionMovementParams result;
				if ((result = this._RootMotionParams) == null)
				{
					result = (this._RootMotionParams = new FRootMotionMovementParams(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_RootMotionParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionMovementParams.StaticStruct(), base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_RootMotionParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0600F33F RID: 62271 RVA: 0x00168BB0 File Offset: 0x00166DB0
		// (set) Token: 0x0600F340 RID: 62272 RVA: 0x00168BF3 File Offset: 0x00166DF3
		public FRootMotionFinishVelocitySettings FinishVelocityParams
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionFinishVelocitySettings result;
				if ((result = this._FinishVelocityParams) == null)
				{
					result = (this._FinishVelocityParams = new FRootMotionFinishVelocitySettings(base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_FinishVelocityParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionFinishVelocitySettings.StaticStruct(), base.NativePtr + (IntPtr)FRootMotionSource.__PropertyOffset_FinishVelocityParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600F341 RID: 62273 RVA: 0x00168C14 File Offset: 0x00166E14
		public FRootMotionSource()
		{
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x00168C1C File Offset: 0x00166E1C
		public FRootMotionSource(ushort Priority, ushort LocalID, ERootMotionAccumulateMode AccumulateMode, FName InstanceName, float StartTime, float CurrentTime, float PreviousTime, float Duration, FRootMotionSourceStatus Status, FRootMotionSourceSettings Settings, bool bInLocalSpace, FRootMotionMovementParams RootMotionParams, FRootMotionFinishVelocitySettings FinishVelocityParams)
		{
			this.Priority = Priority;
			this.LocalID = LocalID;
			this.AccumulateMode = AccumulateMode;
			this.InstanceName = InstanceName;
			this.StartTime = StartTime;
			this.CurrentTime = CurrentTime;
			this.PreviousTime = PreviousTime;
			this.Duration = Duration;
			this.Status = Status;
			this.Settings = Settings;
			this.bInLocalSpace = bInLocalSpace;
			this.RootMotionParams = RootMotionParams;
			this.FinishVelocityParams = FinishVelocityParams;
		}

		// Token: 0x0600F343 RID: 62275 RVA: 0x00168C94 File Offset: 0x00166E94
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSource.StaticStruct();
		}

		// Token: 0x0600F344 RID: 62276 RVA: 0x00168CA0 File Offset: 0x00166EA0
		[NullableContext(2)]
		public FRootMotionSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F345 RID: 62277 RVA: 0x00168CAA File Offset: 0x00166EAA
		public FRootMotionSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F346 RID: 62278 RVA: 0x00168CB5 File Offset: 0x00166EB5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSource(Pointer, false, true);
		}

		// Token: 0x0600F347 RID: 62279 RVA: 0x00168CBF File Offset: 0x00166EBF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSource(Pointer, MemoryOwner);
		}

		// Token: 0x040083DA RID: 33754
		public const string __ObjectPath = "/Script/Engine.RootMotionSource";

		// Token: 0x040083DB RID: 33755
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083DC RID: 33756
		internal static int __PropertyOffset_Priority;

		// Token: 0x040083DD RID: 33757
		internal static int __PropertyOffset_LocalID;

		// Token: 0x040083DE RID: 33758
		internal static int __PropertyOffset_AccumulateMode;

		// Token: 0x040083DF RID: 33759
		internal static int __PropertyOffset_InstanceName;

		// Token: 0x040083E0 RID: 33760
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040083E1 RID: 33761
		internal static int __PropertyOffset_CurrentTime;

		// Token: 0x040083E2 RID: 33762
		internal static int __PropertyOffset_PreviousTime;

		// Token: 0x040083E3 RID: 33763
		internal static int __PropertyOffset_Duration;

		// Token: 0x040083E4 RID: 33764
		internal static int __PropertyOffset_Status;

		// Token: 0x040083E5 RID: 33765
		[Nullable(2)]
		private FRootMotionSourceStatus _Status;

		// Token: 0x040083E6 RID: 33766
		internal static int __PropertyOffset_Settings;

		// Token: 0x040083E7 RID: 33767
		[Nullable(2)]
		private FRootMotionSourceSettings _Settings;

		// Token: 0x040083E8 RID: 33768
		internal static int __PropertyOffset_bInLocalSpace;

		// Token: 0x040083E9 RID: 33769
		internal static int __PropertyOffset_RootMotionParams;

		// Token: 0x040083EA RID: 33770
		[Nullable(2)]
		private FRootMotionMovementParams _RootMotionParams;

		// Token: 0x040083EB RID: 33771
		internal static int __PropertyOffset_FinishVelocityParams;

		// Token: 0x040083EC RID: 33772
		[Nullable(2)]
		private FRootMotionFinishVelocitySettings _FinishVelocityParams;
	}
}
