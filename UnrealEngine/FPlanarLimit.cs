using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015D9 RID: 5593
	[UnrealObjectPath("/Script/KawaiiPhysics.PlanarLimit")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FPlanarLimit : FCollisionLimitBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060142BC RID: 82620 RVA: 0x001DA0D0 File Offset: 0x001D82D0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlanarLimit._ScriptStructPtr != 0) ? FPlanarLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.PlanarLimit", ref FPlanarLimit._ScriptStructPtr);
		}

		// Token: 0x17004F1E RID: 20254
		// (get) Token: 0x060142BD RID: 82621 RVA: 0x001DA0F4 File Offset: 0x001D82F4
		// (set) Token: 0x060142BE RID: 82622 RVA: 0x001DA108 File Offset: 0x001D8308
		public unsafe FPlane Plane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlanarLimit.__PropertyOffset_Plane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlanarLimit.__PropertyOffset_Plane) = value;
			}
		}

		// Token: 0x060142BF RID: 82623 RVA: 0x001DA11D File Offset: 0x001D831D
		public FPlanarLimit()
		{
		}

		// Token: 0x060142C0 RID: 82624 RVA: 0x001DA125 File Offset: 0x001D8325
		[NullableContext(1)]
		public FPlanarLimit(FPlane Plane, FBoneReference DrivingBone, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, bool bFromDataAsset, FGuid Guid, ECollisionLimitType Type)
		{
			this.Plane = Plane;
			base.DrivingBone = DrivingBone;
			base.OffsetLocation = OffsetLocation;
			base.OffsetRotation = OffsetRotation;
			base.Location = Location;
			base.Rotation = Rotation;
		}

		// Token: 0x060142C1 RID: 82625 RVA: 0x001DA15A File Offset: 0x001D835A
		protected override IntPtr GetUStructPtr()
		{
			return FPlanarLimit.StaticStruct();
		}

		// Token: 0x060142C2 RID: 82626 RVA: 0x001DA166 File Offset: 0x001D8366
		[NullableContext(2)]
		public FPlanarLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060142C3 RID: 82627 RVA: 0x001DA170 File Offset: 0x001D8370
		public FPlanarLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060142C4 RID: 82628 RVA: 0x001DA17B File Offset: 0x001D837B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlanarLimit(Pointer, false, true);
		}

		// Token: 0x060142C5 RID: 82629 RVA: 0x001DA185 File Offset: 0x001D8385
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlanarLimit(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF89 RID: 44937
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KawaiiPhysics.PlanarLimit";

		// Token: 0x0400AF8A RID: 44938
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF8B RID: 44939
		internal static int __PropertyOffset_Plane;
	}
}
