using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015CB RID: 5579
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.CollisionLimitBase")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FCollisionLimitBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014204 RID: 82436 RVA: 0x001D9030 File Offset: 0x001D7230
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionLimitBase._ScriptStructPtr != 0) ? FCollisionLimitBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.CollisionLimitBase", ref FCollisionLimitBase._ScriptStructPtr);
		}

		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x06014205 RID: 82437 RVA: 0x001D9054 File Offset: 0x001D7254
		// (set) Token: 0x06014206 RID: 82438 RVA: 0x001D9097 File Offset: 0x001D7297
		public FBoneReference DrivingBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._DrivingBone) == null)
				{
					result = (this._DrivingBone = new FBoneReference(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_DrivingBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_DrivingBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x06014207 RID: 82439 RVA: 0x001D90B8 File Offset: 0x001D72B8
		// (set) Token: 0x06014208 RID: 82440 RVA: 0x001D90CC File Offset: 0x001D72CC
		public unsafe FVector OffsetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_OffsetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_OffsetLocation) = value;
			}
		}

		// Token: 0x17004EE9 RID: 20201
		// (get) Token: 0x06014209 RID: 82441 RVA: 0x001D90E1 File Offset: 0x001D72E1
		// (set) Token: 0x0601420A RID: 82442 RVA: 0x001D90F5 File Offset: 0x001D72F5
		public unsafe FRotator OffsetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_OffsetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_OffsetRotation) = value;
			}
		}

		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x0601420B RID: 82443 RVA: 0x001D910A File Offset: 0x001D730A
		// (set) Token: 0x0601420C RID: 82444 RVA: 0x001D911E File Offset: 0x001D731E
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x0601420D RID: 82445 RVA: 0x001D9133 File Offset: 0x001D7333
		// (set) Token: 0x0601420E RID: 82446 RVA: 0x001D9147 File Offset: 0x001D7347
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionLimitBase.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x0601420F RID: 82447 RVA: 0x001D915C File Offset: 0x001D735C
		public FCollisionLimitBase()
		{
		}

		// Token: 0x06014210 RID: 82448 RVA: 0x001D9164 File Offset: 0x001D7364
		public FCollisionLimitBase(FBoneReference DrivingBone, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, bool bFromDataAsset, FGuid Guid, ECollisionLimitType Type)
		{
			this.DrivingBone = DrivingBone;
			this.OffsetLocation = OffsetLocation;
			this.OffsetRotation = OffsetRotation;
			this.Location = Location;
			this.Rotation = Rotation;
		}

		// Token: 0x06014211 RID: 82449 RVA: 0x001D9191 File Offset: 0x001D7391
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionLimitBase.StaticStruct();
		}

		// Token: 0x06014212 RID: 82450 RVA: 0x001D919D File Offset: 0x001D739D
		[NullableContext(2)]
		public FCollisionLimitBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014213 RID: 82451 RVA: 0x001D91A7 File Offset: 0x001D73A7
		public FCollisionLimitBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014214 RID: 82452 RVA: 0x001D91B2 File Offset: 0x001D73B2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionLimitBase(Pointer, false, true);
		}

		// Token: 0x06014215 RID: 82453 RVA: 0x001D91BC File Offset: 0x001D73BC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionLimitBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF15 RID: 44821
		public const string __ObjectPath = "/Script/KawaiiPhysics.CollisionLimitBase";

		// Token: 0x0400AF16 RID: 44822
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF17 RID: 44823
		internal static int __PropertyOffset_DrivingBone;

		// Token: 0x0400AF18 RID: 44824
		[Nullable(2)]
		private FBoneReference _DrivingBone;

		// Token: 0x0400AF19 RID: 44825
		internal static int __PropertyOffset_OffsetLocation;

		// Token: 0x0400AF1A RID: 44826
		internal static int __PropertyOffset_OffsetRotation;

		// Token: 0x0400AF1B RID: 44827
		internal static int __PropertyOffset_Location;

		// Token: 0x0400AF1C RID: 44828
		internal static int __PropertyOffset_Rotation;
	}
}
