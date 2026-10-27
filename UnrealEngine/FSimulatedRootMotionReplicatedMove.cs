using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010EF RID: 4335
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SimulatedRootMotionReplicatedMove")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FSimulatedRootMotionReplicatedMove : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F8AD RID: 63661 RVA: 0x0016FCD2 File Offset: 0x0016DED2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimulatedRootMotionReplicatedMove._ScriptStructPtr != 0) ? FSimulatedRootMotionReplicatedMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SimulatedRootMotionReplicatedMove", ref FSimulatedRootMotionReplicatedMove._ScriptStructPtr);
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0600F8AE RID: 63662 RVA: 0x0016FCF6 File Offset: 0x0016DEF6
		// (set) Token: 0x0600F8AF RID: 63663 RVA: 0x0016FD06 File Offset: 0x0016DF06
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimulatedRootMotionReplicatedMove.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimulatedRootMotionReplicatedMove.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0600F8B0 RID: 63664 RVA: 0x0016FD18 File Offset: 0x0016DF18
		// (set) Token: 0x0600F8B1 RID: 63665 RVA: 0x0016FD5B File Offset: 0x0016DF5B
		public FRepRootMotionMontage RootMotion
		{
			get
			{
				base.FastCheckIsValid();
				FRepRootMotionMontage result;
				if ((result = this._RootMotion) == null)
				{
					result = (this._RootMotion = new FRepRootMotionMontage(base.NativePtr + (IntPtr)FSimulatedRootMotionReplicatedMove.__PropertyOffset_RootMotion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRepRootMotionMontage.StaticStruct(), base.NativePtr + (IntPtr)FSimulatedRootMotionReplicatedMove.__PropertyOffset_RootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600F8B2 RID: 63666 RVA: 0x0016FD7C File Offset: 0x0016DF7C
		public FSimulatedRootMotionReplicatedMove()
		{
		}

		// Token: 0x0600F8B3 RID: 63667 RVA: 0x0016FD84 File Offset: 0x0016DF84
		public FSimulatedRootMotionReplicatedMove(float Time, FRepRootMotionMontage RootMotion)
		{
			this.Time = Time;
			this.RootMotion = RootMotion;
		}

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x0016FD9A File Offset: 0x0016DF9A
		protected override IntPtr GetUStructPtr()
		{
			return FSimulatedRootMotionReplicatedMove.StaticStruct();
		}

		// Token: 0x0600F8B5 RID: 63669 RVA: 0x0016FDA6 File Offset: 0x0016DFA6
		[NullableContext(2)]
		public FSimulatedRootMotionReplicatedMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F8B6 RID: 63670 RVA: 0x0016FDB0 File Offset: 0x0016DFB0
		public FSimulatedRootMotionReplicatedMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F8B7 RID: 63671 RVA: 0x0016FDBB File Offset: 0x0016DFBB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimulatedRootMotionReplicatedMove(Pointer, false, true);
		}

		// Token: 0x0600F8B8 RID: 63672 RVA: 0x0016FDC5 File Offset: 0x0016DFC5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimulatedRootMotionReplicatedMove(Pointer, MemoryOwner);
		}

		// Token: 0x04008659 RID: 34393
		public const string __ObjectPath = "/Script/Engine.SimulatedRootMotionReplicatedMove";

		// Token: 0x0400865A RID: 34394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400865B RID: 34395
		internal static int __PropertyOffset_Time;

		// Token: 0x0400865C RID: 34396
		internal static int __PropertyOffset_RootMotion;

		// Token: 0x0400865D RID: 34397
		[Nullable(2)]
		private FRepRootMotionMontage _RootMotion;
	}
}
