using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D08 RID: 3336
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroRepRootMotionMontage")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroRepRootMotionMontage : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B1A8 RID: 45480 RVA: 0x000FC31C File Offset: 0x000FA51C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRepRootMotionMontage._ScriptStructPtr != 0) ? FKuroRepRootMotionMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroRepRootMotionMontage", ref FKuroRepRootMotionMontage._ScriptStructPtr);
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600B1A9 RID: 45481 RVA: 0x000FC340 File Offset: 0x000FA540
		// (set) Token: 0x0600B1AA RID: 45482 RVA: 0x000FC350 File Offset: 0x000FA550
		public unsafe bool bIsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_bIsActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_bIsActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x0600B1AB RID: 45483 RVA: 0x000FC361 File Offset: 0x000FA561
		// (set) Token: 0x0600B1AC RID: 45484 RVA: 0x000FC371 File Offset: 0x000FA571
		public unsafe float Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x0600B1AD RID: 45485 RVA: 0x000FC382 File Offset: 0x000FA582
		// (set) Token: 0x0600B1AE RID: 45486 RVA: 0x000FC396 File Offset: 0x000FA596
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x0600B1AF RID: 45487 RVA: 0x000FC3AB File Offset: 0x000FA5AB
		// (set) Token: 0x0600B1B0 RID: 45488 RVA: 0x000FC3BF File Offset: 0x000FA5BF
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0600B1B1 RID: 45489 RVA: 0x000FC3D4 File Offset: 0x000FA5D4
		// (set) Token: 0x0600B1B2 RID: 45490 RVA: 0x000FC3E8 File Offset: 0x000FA5E8
		public unsafe string MovementBaseBoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_MovementBaseBoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_MovementBaseBoneName)), value);
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600B1B3 RID: 45491 RVA: 0x000FC3FD File Offset: 0x000FA5FD
		// (set) Token: 0x0600B1B4 RID: 45492 RVA: 0x000FC40D File Offset: 0x000FA60D
		public unsafe bool bRelativePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_bRelativePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_bRelativePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x0600B1B5 RID: 45493 RVA: 0x000FC41E File Offset: 0x000FA61E
		// (set) Token: 0x0600B1B6 RID: 45494 RVA: 0x000FC42E File Offset: 0x000FA62E
		public unsafe bool bRelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_bRelativeRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_bRelativeRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x0600B1B7 RID: 45495 RVA: 0x000FC43F File Offset: 0x000FA63F
		// (set) Token: 0x0600B1B8 RID: 45496 RVA: 0x000FC453 File Offset: 0x000FA653
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600B1B9 RID: 45497 RVA: 0x000FC468 File Offset: 0x000FA668
		// (set) Token: 0x0600B1BA RID: 45498 RVA: 0x000FC47C File Offset: 0x000FA67C
		public unsafe FVector LinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_LinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRepRootMotionMontage.__PropertyOffset_LinearVelocity) = value;
			}
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x000FC491 File Offset: 0x000FA691
		public FKuroRepRootMotionMontage()
		{
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x000FC49C File Offset: 0x000FA69C
		public FKuroRepRootMotionMontage(bool bIsActive, float Position, FVector Location, FRotator Rotation, string MovementBaseBoneName, bool bRelativePosition, bool bRelativeRotation, FVector Acceleration, FVector LinearVelocity)
		{
			this.bIsActive = bIsActive;
			this.Position = Position;
			this.Location = Location;
			this.Rotation = Rotation;
			this.MovementBaseBoneName = MovementBaseBoneName;
			this.bRelativePosition = bRelativePosition;
			this.bRelativeRotation = bRelativeRotation;
			this.Acceleration = Acceleration;
			this.LinearVelocity = LinearVelocity;
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x000FC4F4 File Offset: 0x000FA6F4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRepRootMotionMontage.StaticStruct();
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x000FC500 File Offset: 0x000FA700
		[NullableContext(2)]
		public FKuroRepRootMotionMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x000FC50A File Offset: 0x000FA70A
		public FKuroRepRootMotionMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x000FC515 File Offset: 0x000FA715
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRepRootMotionMontage(Pointer, false, true);
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x000FC51F File Offset: 0x000FA71F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRepRootMotionMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04005D07 RID: 23815
		public const string __ObjectPath = "/Script/Engine.KuroRepRootMotionMontage";

		// Token: 0x04005D08 RID: 23816
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005D09 RID: 23817
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x04005D0A RID: 23818
		internal static int __PropertyOffset_Position;

		// Token: 0x04005D0B RID: 23819
		internal static int __PropertyOffset_Location;

		// Token: 0x04005D0C RID: 23820
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04005D0D RID: 23821
		internal static int __PropertyOffset_MovementBaseBoneName;

		// Token: 0x04005D0E RID: 23822
		internal static int __PropertyOffset_bRelativePosition;

		// Token: 0x04005D0F RID: 23823
		internal static int __PropertyOffset_bRelativeRotation;

		// Token: 0x04005D10 RID: 23824
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04005D11 RID: 23825
		internal static int __PropertyOffset_LinearVelocity;
	}
}
