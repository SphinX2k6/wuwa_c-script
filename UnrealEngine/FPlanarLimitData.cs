using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015DA RID: 5594
	[UnrealObjectPath("/Script/KawaiiPhysics.PlanarLimitData")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FPlanarLimitData : FCollisionLimitDataBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060142C6 RID: 82630 RVA: 0x001DA18E File Offset: 0x001D838E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlanarLimitData._ScriptStructPtr != 0) ? FPlanarLimitData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.PlanarLimitData", ref FPlanarLimitData._ScriptStructPtr);
		}

		// Token: 0x17004F1F RID: 20255
		// (get) Token: 0x060142C7 RID: 82631 RVA: 0x001DA1B2 File Offset: 0x001D83B2
		// (set) Token: 0x060142C8 RID: 82632 RVA: 0x001DA1C6 File Offset: 0x001D83C6
		public unsafe FPlane Plane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlanarLimitData.__PropertyOffset_Plane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlanarLimitData.__PropertyOffset_Plane) = value;
			}
		}

		// Token: 0x060142C9 RID: 82633 RVA: 0x001DA1DB File Offset: 0x001D83DB
		public FPlanarLimitData()
		{
		}

		// Token: 0x060142CA RID: 82634 RVA: 0x001DA1E3 File Offset: 0x001D83E3
		public FPlanarLimitData(FPlane Plane, FName DrivingBoneName, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, FGuid Guid)
		{
			this.Plane = Plane;
			base.DrivingBoneName = DrivingBoneName;
			base.OffsetLocation = OffsetLocation;
			base.OffsetRotation = OffsetRotation;
			base.Location = Location;
			base.Rotation = Rotation;
			base.Guid = Guid;
		}

		// Token: 0x060142CB RID: 82635 RVA: 0x001DA220 File Offset: 0x001D8420
		protected override IntPtr GetUStructPtr()
		{
			return FPlanarLimitData.StaticStruct();
		}

		// Token: 0x060142CC RID: 82636 RVA: 0x001DA22C File Offset: 0x001D842C
		[NullableContext(2)]
		public FPlanarLimitData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060142CD RID: 82637 RVA: 0x001DA236 File Offset: 0x001D8436
		public FPlanarLimitData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060142CE RID: 82638 RVA: 0x001DA241 File Offset: 0x001D8441
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlanarLimitData(Pointer, false, true);
		}

		// Token: 0x060142CF RID: 82639 RVA: 0x001DA24B File Offset: 0x001D844B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlanarLimitData(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF8C RID: 44940
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KawaiiPhysics.PlanarLimitData";

		// Token: 0x0400AF8D RID: 44941
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF8E RID: 44942
		internal static int __PropertyOffset_Plane;
	}
}
