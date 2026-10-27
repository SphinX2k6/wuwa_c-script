using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE6 RID: 3302
	[UnrealObjectPath("/Script/Engine.KuroCharacterNetworkMoveData")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class FKuroCharacterNetworkMoveData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF2F RID: 44847 RVA: 0x000F886A File Offset: 0x000F6A6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharacterNetworkMoveData._ScriptStructPtr != 0) ? FKuroCharacterNetworkMoveData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroCharacterNetworkMoveData", ref FKuroCharacterNetworkMoveData._ScriptStructPtr);
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x0600AF30 RID: 44848 RVA: 0x000F888E File Offset: 0x000F6A8E
		// (set) Token: 0x0600AF31 RID: 44849 RVA: 0x000F889E File Offset: 0x000F6A9E
		public unsafe float TimeStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_TimeStamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_TimeStamp) = value;
			}
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x0600AF32 RID: 44850 RVA: 0x000F88AF File Offset: 0x000F6AAF
		// (set) Token: 0x0600AF33 RID: 44851 RVA: 0x000F88C3 File Offset: 0x000F6AC3
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x000F88D8 File Offset: 0x000F6AD8
		// (set) Token: 0x0600AF35 RID: 44853 RVA: 0x000F88EC File Offset: 0x000F6AEC
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x000F8901 File Offset: 0x000F6B01
		// (set) Token: 0x0600AF37 RID: 44855 RVA: 0x000F8915 File Offset: 0x000F6B15
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0600AF38 RID: 44856 RVA: 0x000F892A File Offset: 0x000F6B2A
		// (set) Token: 0x0600AF39 RID: 44857 RVA: 0x000F893E File Offset: 0x000F6B3E
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x000F8953 File Offset: 0x000F6B53
		// (set) Token: 0x0600AF3B RID: 44859 RVA: 0x000F8967 File Offset: 0x000F6B67
		public unsafe FRotator ControlRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_ControlRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_ControlRotation) = value;
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x000F897C File Offset: 0x000F6B7C
		// (set) Token: 0x0600AF3D RID: 44861 RVA: 0x000F898C File Offset: 0x000F6B8C
		public unsafe byte CompressedMoveFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_CompressedMoveFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_CompressedMoveFlags) = value;
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x000F899D File Offset: 0x000F6B9D
		// (set) Token: 0x0600AF3F RID: 44863 RVA: 0x000F89AD File Offset: 0x000F6BAD
		public unsafe byte MovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_MovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharacterNetworkMoveData.__PropertyOffset_MovementMode) = value;
			}
		}

		// Token: 0x0600AF40 RID: 44864 RVA: 0x000F89BE File Offset: 0x000F6BBE
		public FKuroCharacterNetworkMoveData()
		{
		}

		// Token: 0x0600AF41 RID: 44865 RVA: 0x000F89C8 File Offset: 0x000F6BC8
		public FKuroCharacterNetworkMoveData(float TimeStamp, FVector Acceleration, FVector Velocity, FVector Location, FRotator Rotation, FRotator ControlRotation, byte CompressedMoveFlags, byte MovementMode)
		{
			this.TimeStamp = TimeStamp;
			this.Acceleration = Acceleration;
			this.Velocity = Velocity;
			this.Location = Location;
			this.Rotation = Rotation;
			this.ControlRotation = ControlRotation;
			this.CompressedMoveFlags = CompressedMoveFlags;
			this.MovementMode = MovementMode;
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x000F8A18 File Offset: 0x000F6C18
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharacterNetworkMoveData.StaticStruct();
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x000F8A24 File Offset: 0x000F6C24
		[NullableContext(2)]
		public FKuroCharacterNetworkMoveData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x000F8A2E File Offset: 0x000F6C2E
		public FKuroCharacterNetworkMoveData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF45 RID: 44869 RVA: 0x000F8A39 File Offset: 0x000F6C39
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharacterNetworkMoveData(Pointer, false, true);
		}

		// Token: 0x0600AF46 RID: 44870 RVA: 0x000F8A43 File Offset: 0x000F6C43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharacterNetworkMoveData(Pointer, MemoryOwner);
		}

		// Token: 0x04005BC0 RID: 23488
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroCharacterNetworkMoveData";

		// Token: 0x04005BC1 RID: 23489
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BC2 RID: 23490
		internal static int __PropertyOffset_TimeStamp;

		// Token: 0x04005BC3 RID: 23491
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04005BC4 RID: 23492
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04005BC5 RID: 23493
		internal static int __PropertyOffset_Location;

		// Token: 0x04005BC6 RID: 23494
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04005BC7 RID: 23495
		internal static int __PropertyOffset_ControlRotation;

		// Token: 0x04005BC8 RID: 23496
		internal static int __PropertyOffset_CompressedMoveFlags;

		// Token: 0x04005BC9 RID: 23497
		internal static int __PropertyOffset_MovementMode;
	}
}
