using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000471 RID: 1137
	[UnrealObjectPath("/Script/KuroMovement.KuroFlowerFlyingLocationParams")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroFlowerFlyingLocationParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006C1E RID: 27678 RVA: 0x0009D526 File Offset: 0x0009B726
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFlowerFlyingLocationParams._ScriptStructPtr != 0) ? FKuroFlowerFlyingLocationParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.KuroFlowerFlyingLocationParams", ref FKuroFlowerFlyingLocationParams._ScriptStructPtr);
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x0009D54A File Offset: 0x0009B74A
		// (set) Token: 0x06006C20 RID: 27680 RVA: 0x0009D55A File Offset: 0x0009B75A
		public unsafe float DeadZoneCenterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_DeadZoneCenterHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_DeadZoneCenterHeight) = value;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x0009D56B File Offset: 0x0009B76B
		// (set) Token: 0x06006C22 RID: 27682 RVA: 0x0009D57F File Offset: 0x0009B77F
		public unsafe FVector2D DeadZoneThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_DeadZoneThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_DeadZoneThickness) = value;
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x0009D594 File Offset: 0x0009B794
		// (set) Token: 0x06006C24 RID: 27684 RVA: 0x0009D5A4 File Offset: 0x0009B7A4
		public unsafe float LimitBrakeDeceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_LimitBrakeDeceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_LimitBrakeDeceleration) = value;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06006C25 RID: 27685 RVA: 0x0009D5B5 File Offset: 0x0009B7B5
		// (set) Token: 0x06006C26 RID: 27686 RVA: 0x0009D5C9 File Offset: 0x0009B7C9
		public unsafe FVector2D SoftZoneThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_SoftZoneThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_SoftZoneThickness) = value;
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06006C27 RID: 27687 RVA: 0x0009D5DE File Offset: 0x0009B7DE
		// (set) Token: 0x06006C28 RID: 27688 RVA: 0x0009D5EE File Offset: 0x0009B7EE
		public unsafe float DiveFlattenDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_DiveFlattenDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_DiveFlattenDistance) = value;
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06006C29 RID: 27689 RVA: 0x0009D5FF File Offset: 0x0009B7FF
		// (set) Token: 0x06006C2A RID: 27690 RVA: 0x0009D60F File Offset: 0x0009B80F
		public unsafe float ReturnMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_ReturnMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_ReturnMaxSpeed) = value;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06006C2B RID: 27691 RVA: 0x0009D620 File Offset: 0x0009B820
		// (set) Token: 0x06006C2C RID: 27692 RVA: 0x0009D630 File Offset: 0x0009B830
		public unsafe float EscapePitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_EscapePitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_EscapePitch) = value;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x0009D641 File Offset: 0x0009B841
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x0009D651 File Offset: 0x0009B851
		public unsafe float ForceDescendPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_ForceDescendPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_ForceDescendPitch) = value;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x0009D662 File Offset: 0x0009B862
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x0009D676 File Offset: 0x0009B876
		public unsafe FVector2D InputDeadZone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_InputDeadZone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_InputDeadZone) = value;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06006C31 RID: 27697 RVA: 0x0009D68B File Offset: 0x0009B88B
		// (set) Token: 0x06006C32 RID: 27698 RVA: 0x0009D69B File Offset: 0x0009B89B
		public unsafe float GroundTraceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_GroundTraceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_GroundTraceDistance) = value;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06006C33 RID: 27699 RVA: 0x0009D6AC File Offset: 0x0009B8AC
		// (set) Token: 0x06006C34 RID: 27700 RVA: 0x0009D6BC File Offset: 0x0009B8BC
		public unsafe bool bUseAsyncTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_bUseAsyncTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingLocationParams.__PropertyOffset_bUseAsyncTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x0009D6CD File Offset: 0x0009B8CD
		public FKuroFlowerFlyingLocationParams()
		{
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x0009D6D5 File Offset: 0x0009B8D5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFlowerFlyingLocationParams.StaticStruct();
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x0009D6E1 File Offset: 0x0009B8E1
		[NullableContext(2)]
		public FKuroFlowerFlyingLocationParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x0009D6EB File Offset: 0x0009B8EB
		public FKuroFlowerFlyingLocationParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x0009D6F6 File Offset: 0x0009B8F6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFlowerFlyingLocationParams(Pointer, false, true);
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x0009D700 File Offset: 0x0009B900
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFlowerFlyingLocationParams(Pointer, MemoryOwner);
		}

		// Token: 0x04002E25 RID: 11813
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMovement.KuroFlowerFlyingLocationParams";

		// Token: 0x04002E26 RID: 11814
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002E27 RID: 11815
		internal static int __PropertyOffset_DeadZoneCenterHeight;

		// Token: 0x04002E28 RID: 11816
		internal static int __PropertyOffset_DeadZoneThickness;

		// Token: 0x04002E29 RID: 11817
		internal static int __PropertyOffset_LimitBrakeDeceleration;

		// Token: 0x04002E2A RID: 11818
		internal static int __PropertyOffset_SoftZoneThickness;

		// Token: 0x04002E2B RID: 11819
		internal static int __PropertyOffset_DiveFlattenDistance;

		// Token: 0x04002E2C RID: 11820
		internal static int __PropertyOffset_ReturnMaxSpeed;

		// Token: 0x04002E2D RID: 11821
		internal static int __PropertyOffset_EscapePitch;

		// Token: 0x04002E2E RID: 11822
		internal static int __PropertyOffset_ForceDescendPitch;

		// Token: 0x04002E2F RID: 11823
		internal static int __PropertyOffset_InputDeadZone;

		// Token: 0x04002E30 RID: 11824
		internal static int __PropertyOffset_GroundTraceDistance;

		// Token: 0x04002E31 RID: 11825
		internal static int __PropertyOffset_bUseAsyncTrace;
	}
}
