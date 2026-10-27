using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FC0 RID: 4032
	[UnrealObjectPath("/Script/Engine.ParticleReplayTrackKey")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FParticleReplayTrackKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D900 RID: 55552 RVA: 0x0014055E File Offset: 0x0013E75E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleReplayTrackKey._ScriptStructPtr != 0) ? FParticleReplayTrackKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleReplayTrackKey", ref FParticleReplayTrackKey._ScriptStructPtr);
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600D901 RID: 55553 RVA: 0x00140582 File Offset: 0x0013E782
		// (set) Token: 0x0600D902 RID: 55554 RVA: 0x00140592 File Offset: 0x0013E792
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleReplayTrackKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleReplayTrackKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600D903 RID: 55555 RVA: 0x001405A3 File Offset: 0x0013E7A3
		// (set) Token: 0x0600D904 RID: 55556 RVA: 0x001405B3 File Offset: 0x0013E7B3
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleReplayTrackKey.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleReplayTrackKey.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600D905 RID: 55557 RVA: 0x001405C4 File Offset: 0x0013E7C4
		// (set) Token: 0x0600D906 RID: 55558 RVA: 0x001405D4 File Offset: 0x0013E7D4
		public unsafe int ClipIDNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParticleReplayTrackKey.__PropertyOffset_ClipIDNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParticleReplayTrackKey.__PropertyOffset_ClipIDNumber) = value;
			}
		}

		// Token: 0x0600D907 RID: 55559 RVA: 0x001405E5 File Offset: 0x0013E7E5
		public FParticleReplayTrackKey()
		{
		}

		// Token: 0x0600D908 RID: 55560 RVA: 0x001405ED File Offset: 0x0013E7ED
		public FParticleReplayTrackKey(float Time, float Duration, int ClipIDNumber)
		{
			this.Time = Time;
			this.Duration = Duration;
			this.ClipIDNumber = ClipIDNumber;
		}

		// Token: 0x0600D909 RID: 55561 RVA: 0x0014060A File Offset: 0x0013E80A
		protected override IntPtr GetUStructPtr()
		{
			return FParticleReplayTrackKey.StaticStruct();
		}

		// Token: 0x0600D90A RID: 55562 RVA: 0x00140616 File Offset: 0x0013E816
		[NullableContext(2)]
		public FParticleReplayTrackKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D90B RID: 55563 RVA: 0x00140620 File Offset: 0x0013E820
		public FParticleReplayTrackKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D90C RID: 55564 RVA: 0x0014062B File Offset: 0x0013E82B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleReplayTrackKey(Pointer, false, true);
		}

		// Token: 0x0600D90D RID: 55565 RVA: 0x00140635 File Offset: 0x0013E835
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleReplayTrackKey(Pointer, MemoryOwner);
		}

		// Token: 0x040075AE RID: 30126
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleReplayTrackKey";

		// Token: 0x040075AF RID: 30127
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040075B0 RID: 30128
		internal static int __PropertyOffset_Time;

		// Token: 0x040075B1 RID: 30129
		internal static int __PropertyOffset_Duration;

		// Token: 0x040075B2 RID: 30130
		internal static int __PropertyOffset_ClipIDNumber;
	}
}
