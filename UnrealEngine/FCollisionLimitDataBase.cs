using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015CC RID: 5580
	[UnrealObjectPath("/Script/KawaiiPhysics.CollisionLimitDataBase")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FCollisionLimitDataBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014216 RID: 82454 RVA: 0x001D91C5 File Offset: 0x001D73C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionLimitDataBase._ScriptStructPtr != 0) ? FCollisionLimitDataBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.CollisionLimitDataBase", ref FCollisionLimitDataBase._ScriptStructPtr);
		}

		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x06014217 RID: 82455 RVA: 0x001D91E9 File Offset: 0x001D73E9
		// (set) Token: 0x06014218 RID: 82456 RVA: 0x001D91FD File Offset: 0x001D73FD
		public unsafe FName DrivingBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_DrivingBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_DrivingBoneName) = value;
			}
		}

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x06014219 RID: 82457 RVA: 0x001D9212 File Offset: 0x001D7412
		// (set) Token: 0x0601421A RID: 82458 RVA: 0x001D9226 File Offset: 0x001D7426
		public unsafe FVector OffsetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_OffsetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_OffsetLocation) = value;
			}
		}

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x0601421B RID: 82459 RVA: 0x001D923B File Offset: 0x001D743B
		// (set) Token: 0x0601421C RID: 82460 RVA: 0x001D924F File Offset: 0x001D744F
		public unsafe FRotator OffsetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_OffsetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_OffsetRotation) = value;
			}
		}

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x0601421D RID: 82461 RVA: 0x001D9264 File Offset: 0x001D7464
		// (set) Token: 0x0601421E RID: 82462 RVA: 0x001D9278 File Offset: 0x001D7478
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x0601421F RID: 82463 RVA: 0x001D928D File Offset: 0x001D748D
		// (set) Token: 0x06014220 RID: 82464 RVA: 0x001D92A1 File Offset: 0x001D74A1
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17004EF1 RID: 20209
		// (get) Token: 0x06014221 RID: 82465 RVA: 0x001D92B6 File Offset: 0x001D74B6
		// (set) Token: 0x06014222 RID: 82466 RVA: 0x001D92CA File Offset: 0x001D74CA
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitDataBase.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x06014223 RID: 82467 RVA: 0x001D92DF File Offset: 0x001D74DF
		public FCollisionLimitDataBase()
		{
		}

		// Token: 0x06014224 RID: 82468 RVA: 0x001D92E7 File Offset: 0x001D74E7
		public FCollisionLimitDataBase(FName DrivingBoneName, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, FGuid Guid)
		{
			this.DrivingBoneName = DrivingBoneName;
			this.OffsetLocation = OffsetLocation;
			this.OffsetRotation = OffsetRotation;
			this.Location = Location;
			this.Rotation = Rotation;
			this.Guid = Guid;
		}

		// Token: 0x06014225 RID: 82469 RVA: 0x001D931C File Offset: 0x001D751C
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionLimitDataBase.StaticStruct();
		}

		// Token: 0x06014226 RID: 82470 RVA: 0x001D9328 File Offset: 0x001D7528
		[NullableContext(2)]
		public FCollisionLimitDataBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014227 RID: 82471 RVA: 0x001D9332 File Offset: 0x001D7532
		public FCollisionLimitDataBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014228 RID: 82472 RVA: 0x001D933D File Offset: 0x001D753D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionLimitDataBase(Pointer, false, true);
		}

		// Token: 0x06014229 RID: 82473 RVA: 0x001D9347 File Offset: 0x001D7547
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionLimitDataBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF1D RID: 44829
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KawaiiPhysics.CollisionLimitDataBase";

		// Token: 0x0400AF1E RID: 44830
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF1F RID: 44831
		internal static int __PropertyOffset_DrivingBoneName;

		// Token: 0x0400AF20 RID: 44832
		internal static int __PropertyOffset_OffsetLocation;

		// Token: 0x0400AF21 RID: 44833
		internal static int __PropertyOffset_OffsetRotation;

		// Token: 0x0400AF22 RID: 44834
		internal static int __PropertyOffset_Location;

		// Token: 0x0400AF23 RID: 44835
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400AF24 RID: 44836
		internal static int __PropertyOffset_Guid;
	}
}
