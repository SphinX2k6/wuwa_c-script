using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AAE RID: 6830
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInstanceState")]
	[UnrealStructLayout(256, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FKuroBirdInstanceState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019491 RID: 103569 RVA: 0x002562B3 File Offset: 0x002544B3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBirdInstanceState._ScriptStructPtr != 0) ? FKuroBirdInstanceState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInstanceState", ref FKuroBirdInstanceState._ScriptStructPtr);
		}

		// Token: 0x170064C0 RID: 25792
		// (get) Token: 0x06019492 RID: 103570 RVA: 0x002562D7 File Offset: 0x002544D7
		// (set) Token: 0x06019493 RID: 103571 RVA: 0x002562E7 File Offset: 0x002544E7
		public unsafe bool bCanBeScaredAgain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_bCanBeScaredAgain) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_bCanBeScaredAgain) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064C1 RID: 25793
		// (get) Token: 0x06019494 RID: 103572 RVA: 0x002562F8 File Offset: 0x002544F8
		// (set) Token: 0x06019495 RID: 103573 RVA: 0x00256308 File Offset: 0x00254508
		public unsafe bool bIsFlying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_bIsFlying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_bIsFlying) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064C2 RID: 25794
		// (get) Token: 0x06019496 RID: 103574 RVA: 0x00256319 File Offset: 0x00254519
		// (set) Token: 0x06019497 RID: 103575 RVA: 0x00256329 File Offset: 0x00254529
		public unsafe bool bScareForwardFleeActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_bScareForwardFleeActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_bScareForwardFleeActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064C3 RID: 25795
		// (get) Token: 0x06019498 RID: 103576 RVA: 0x0025633A File Offset: 0x0025453A
		// (set) Token: 0x06019499 RID: 103577 RVA: 0x0025634A File Offset: 0x0025454A
		public unsafe EBirdGroundLocomotion GroundLocomotion
		{
			get
			{
				return (EBirdGroundLocomotion)(*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_GroundLocomotion));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_GroundLocomotion) = (byte)value;
			}
		}

		// Token: 0x170064C4 RID: 25796
		// (get) Token: 0x0601949A RID: 103578 RVA: 0x0025635B File Offset: 0x0025455B
		// (set) Token: 0x0601949B RID: 103579 RVA: 0x0025636B File Offset: 0x0025456B
		public unsafe EBirdFlightPhase FlightPhase
		{
			get
			{
				return (EBirdFlightPhase)(*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_FlightPhase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_FlightPhase) = (byte)value;
			}
		}

		// Token: 0x170064C5 RID: 25797
		// (get) Token: 0x0601949C RID: 103580 RVA: 0x0025637C File Offset: 0x0025457C
		// (set) Token: 0x0601949D RID: 103581 RVA: 0x0025638C File Offset: 0x0025458C
		public unsafe float UpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_UpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_UpSpeed) = value;
			}
		}

		// Token: 0x170064C6 RID: 25798
		// (get) Token: 0x0601949E RID: 103582 RVA: 0x0025639D File Offset: 0x0025459D
		// (set) Token: 0x0601949F RID: 103583 RVA: 0x002563AD File Offset: 0x002545AD
		public unsafe float DateStore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_DateStore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_DateStore) = value;
			}
		}

		// Token: 0x170064C7 RID: 25799
		// (get) Token: 0x060194A0 RID: 103584 RVA: 0x002563BE File Offset: 0x002545BE
		// (set) Token: 0x060194A1 RID: 103585 RVA: 0x002563CE File Offset: 0x002545CE
		public unsafe EBirdVATState CurrentVATState
		{
			get
			{
				return (EBirdVATState)(*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_CurrentVATState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_CurrentVATState) = (byte)value;
			}
		}

		// Token: 0x170064C8 RID: 25800
		// (get) Token: 0x060194A2 RID: 103586 RVA: 0x002563DF File Offset: 0x002545DF
		// (set) Token: 0x060194A3 RID: 103587 RVA: 0x002563EF File Offset: 0x002545EF
		public unsafe EBirdVATState PreviousVATState
		{
			get
			{
				return (EBirdVATState)(*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_PreviousVATState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBirdInstanceState.__PropertyOffset_PreviousVATState) = (byte)value;
			}
		}

		// Token: 0x060194A4 RID: 103588 RVA: 0x00256400 File Offset: 0x00254600
		public FKuroBirdInstanceState()
		{
		}

		// Token: 0x060194A5 RID: 103589 RVA: 0x00256408 File Offset: 0x00254608
		public FKuroBirdInstanceState(bool bCanBeScaredAgain, bool bIsFlying, bool bScareForwardFleeActive, EBirdGroundLocomotion GroundLocomotion, EBirdFlightPhase FlightPhase, float UpSpeed, float DateStore, EBirdVATState CurrentVATState, EBirdVATState PreviousVATState)
		{
			this.bCanBeScaredAgain = bCanBeScaredAgain;
			this.bIsFlying = bIsFlying;
			this.bScareForwardFleeActive = bScareForwardFleeActive;
			this.GroundLocomotion = GroundLocomotion;
			this.FlightPhase = FlightPhase;
			this.UpSpeed = UpSpeed;
			this.DateStore = DateStore;
			this.CurrentVATState = CurrentVATState;
			this.PreviousVATState = PreviousVATState;
		}

		// Token: 0x060194A6 RID: 103590 RVA: 0x00256460 File Offset: 0x00254660
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBirdInstanceState.StaticStruct();
		}

		// Token: 0x060194A7 RID: 103591 RVA: 0x0025646C File Offset: 0x0025466C
		[NullableContext(2)]
		public FKuroBirdInstanceState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060194A8 RID: 103592 RVA: 0x00256476 File Offset: 0x00254676
		public FKuroBirdInstanceState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060194A9 RID: 103593 RVA: 0x00256481 File Offset: 0x00254681
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBirdInstanceState(Pointer, false, true);
		}

		// Token: 0x060194AA RID: 103594 RVA: 0x0025648B File Offset: 0x0025468B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBirdInstanceState(Pointer, MemoryOwner);
		}

		// Token: 0x0400DC8E RID: 56462
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdInstanceState";

		// Token: 0x0400DC8F RID: 56463
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DC90 RID: 56464
		internal static int __PropertyOffset_bCanBeScaredAgain;

		// Token: 0x0400DC91 RID: 56465
		internal static int __PropertyOffset_bIsFlying;

		// Token: 0x0400DC92 RID: 56466
		internal static int __PropertyOffset_bScareForwardFleeActive;

		// Token: 0x0400DC93 RID: 56467
		internal static int __PropertyOffset_GroundLocomotion;

		// Token: 0x0400DC94 RID: 56468
		internal static int __PropertyOffset_FlightPhase;

		// Token: 0x0400DC95 RID: 56469
		internal static int __PropertyOffset_UpSpeed;

		// Token: 0x0400DC96 RID: 56470
		internal static int __PropertyOffset_DateStore;

		// Token: 0x0400DC97 RID: 56471
		internal static int __PropertyOffset_CurrentVATState;

		// Token: 0x0400DC98 RID: 56472
		internal static int __PropertyOffset_PreviousVATState;
	}
}
