using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019D5 RID: 6613
	[UnrealObjectPath("/Script/KuroMovement.BaseRecord")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FBaseRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060188E4 RID: 100580 RVA: 0x00242A19 File Offset: 0x00240C19
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBaseRecord._ScriptStructPtr != 0) ? FBaseRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.BaseRecord", ref FBaseRecord._ScriptStructPtr);
		}

		// Token: 0x170061DD RID: 25053
		// (get) Token: 0x060188E5 RID: 100581 RVA: 0x00242A3D File Offset: 0x00240C3D
		// (set) Token: 0x060188E6 RID: 100582 RVA: 0x00242A51 File Offset: 0x00240C51
		public unsafe FVectorDouble ActorLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_ActorLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_ActorLocation) = value;
			}
		}

		// Token: 0x170061DE RID: 25054
		// (get) Token: 0x060188E7 RID: 100583 RVA: 0x00242A66 File Offset: 0x00240C66
		// (set) Token: 0x060188E8 RID: 100584 RVA: 0x00242A7A File Offset: 0x00240C7A
		public unsafe FRotator ActorRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_ActorRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_ActorRotation) = value;
			}
		}

		// Token: 0x170061DF RID: 25055
		// (get) Token: 0x060188E9 RID: 100585 RVA: 0x00242A8F File Offset: 0x00240C8F
		// (set) Token: 0x060188EA RID: 100586 RVA: 0x00242AA3 File Offset: 0x00240CA3
		public unsafe FVectorDouble MeshLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_MeshLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_MeshLocation) = value;
			}
		}

		// Token: 0x170061E0 RID: 25056
		// (get) Token: 0x060188EB RID: 100587 RVA: 0x00242AB8 File Offset: 0x00240CB8
		// (set) Token: 0x060188EC RID: 100588 RVA: 0x00242ACC File Offset: 0x00240CCC
		public unsafe FVector CustomVector01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_CustomVector01);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_CustomVector01) = value;
			}
		}

		// Token: 0x170061E1 RID: 25057
		// (get) Token: 0x060188ED RID: 100589 RVA: 0x00242AE1 File Offset: 0x00240CE1
		// (set) Token: 0x060188EE RID: 100590 RVA: 0x00242AF5 File Offset: 0x00240CF5
		public unsafe FVector CustomVector02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_CustomVector02);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_CustomVector02) = value;
			}
		}

		// Token: 0x170061E2 RID: 25058
		// (get) Token: 0x060188EF RID: 100591 RVA: 0x00242B0A File Offset: 0x00240D0A
		// (set) Token: 0x060188F0 RID: 100592 RVA: 0x00242B1E File Offset: 0x00240D1E
		public unsafe TEnumAsByte<EMovementMode> MovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_MovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_MovementMode) = value;
			}
		}

		// Token: 0x170061E3 RID: 25059
		// (get) Token: 0x060188F1 RID: 100593 RVA: 0x00242B33 File Offset: 0x00240D33
		// (set) Token: 0x060188F2 RID: 100594 RVA: 0x00242B43 File Offset: 0x00240D43
		public unsafe EKDMCustomMovement CustomMovementMode
		{
			get
			{
				return (EKDMCustomMovement)(*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_CustomMovementMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_CustomMovementMode) = (byte)value;
			}
		}

		// Token: 0x170061E4 RID: 25060
		// (get) Token: 0x060188F3 RID: 100595 RVA: 0x00242B54 File Offset: 0x00240D54
		// (set) Token: 0x060188F4 RID: 100596 RVA: 0x00242B64 File Offset: 0x00240D64
		public unsafe bool bIsVehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_bIsVehicle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_bIsVehicle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061E5 RID: 25061
		// (get) Token: 0x060188F5 RID: 100597 RVA: 0x00242B75 File Offset: 0x00240D75
		// (set) Token: 0x060188F6 RID: 100598 RVA: 0x00242B89 File Offset: 0x00240D89
		public unsafe TEnumAsByte<EKuroVehicleMovementMode> VehicleMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_VehicleMovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseRecord.__PropertyOffset_VehicleMovementMode) = value;
			}
		}

		// Token: 0x060188F7 RID: 100599 RVA: 0x00242B9E File Offset: 0x00240D9E
		public FBaseRecord()
		{
		}

		// Token: 0x060188F8 RID: 100600 RVA: 0x00242BA8 File Offset: 0x00240DA8
		public FBaseRecord(FVectorDouble ActorLocation, FRotator ActorRotation, FVectorDouble MeshLocation, FVector CustomVector01, FVector CustomVector02, TEnumAsByte<EMovementMode> MovementMode, EKDMCustomMovement CustomMovementMode, bool bIsVehicle, TEnumAsByte<EKuroVehicleMovementMode> VehicleMovementMode)
		{
			this.ActorLocation = ActorLocation;
			this.ActorRotation = ActorRotation;
			this.MeshLocation = MeshLocation;
			this.CustomVector01 = CustomVector01;
			this.CustomVector02 = CustomVector02;
			this.MovementMode = MovementMode;
			this.CustomMovementMode = CustomMovementMode;
			this.bIsVehicle = bIsVehicle;
			this.VehicleMovementMode = VehicleMovementMode;
		}

		// Token: 0x060188F9 RID: 100601 RVA: 0x00242C00 File Offset: 0x00240E00
		protected override IntPtr GetUStructPtr()
		{
			return FBaseRecord.StaticStruct();
		}

		// Token: 0x060188FA RID: 100602 RVA: 0x00242C0C File Offset: 0x00240E0C
		[NullableContext(2)]
		public FBaseRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060188FB RID: 100603 RVA: 0x00242C16 File Offset: 0x00240E16
		public FBaseRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060188FC RID: 100604 RVA: 0x00242C21 File Offset: 0x00240E21
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBaseRecord(Pointer, false, true);
		}

		// Token: 0x060188FD RID: 100605 RVA: 0x00242C2B File Offset: 0x00240E2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBaseRecord(Pointer, MemoryOwner);
		}

		// Token: 0x0400D446 RID: 54342
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMovement.BaseRecord";

		// Token: 0x0400D447 RID: 54343
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D448 RID: 54344
		internal static int __PropertyOffset_ActorLocation;

		// Token: 0x0400D449 RID: 54345
		internal static int __PropertyOffset_ActorRotation;

		// Token: 0x0400D44A RID: 54346
		internal static int __PropertyOffset_MeshLocation;

		// Token: 0x0400D44B RID: 54347
		internal static int __PropertyOffset_CustomVector01;

		// Token: 0x0400D44C RID: 54348
		internal static int __PropertyOffset_CustomVector02;

		// Token: 0x0400D44D RID: 54349
		internal static int __PropertyOffset_MovementMode;

		// Token: 0x0400D44E RID: 54350
		internal static int __PropertyOffset_CustomMovementMode;

		// Token: 0x0400D44F RID: 54351
		internal static int __PropertyOffset_bIsVehicle;

		// Token: 0x0400D450 RID: 54352
		internal static int __PropertyOffset_VehicleMovementMode;
	}
}
