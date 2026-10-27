using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015DC RID: 5596
	[UnrealObjectPath("/Script/KawaiiPhysics.SphericalLimitData")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FSphericalLimitData : FCollisionLimitDataBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060142DC RID: 82652 RVA: 0x001DA333 File Offset: 0x001D8533
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSphericalLimitData._ScriptStructPtr != 0) ? FSphericalLimitData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.SphericalLimitData", ref FSphericalLimitData._ScriptStructPtr);
		}

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x060142DD RID: 82653 RVA: 0x001DA357 File Offset: 0x001D8557
		// (set) Token: 0x060142DE RID: 82654 RVA: 0x001DA367 File Offset: 0x001D8567
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSphericalLimitData.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphericalLimitData.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x060142DF RID: 82655 RVA: 0x001DA378 File Offset: 0x001D8578
		// (set) Token: 0x060142E0 RID: 82656 RVA: 0x001DA388 File Offset: 0x001D8588
		public unsafe ESphericalLimitType LimitType
		{
			get
			{
				return (ESphericalLimitType)(*(base.NativePtr + (IntPtr)FSphericalLimitData.__PropertyOffset_LimitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphericalLimitData.__PropertyOffset_LimitType) = (byte)value;
			}
		}

		// Token: 0x060142E1 RID: 82657 RVA: 0x001DA399 File Offset: 0x001D8599
		public FSphericalLimitData()
		{
		}

		// Token: 0x060142E2 RID: 82658 RVA: 0x001DA3A4 File Offset: 0x001D85A4
		public FSphericalLimitData(float Radius, ESphericalLimitType LimitType, FName DrivingBoneName, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, FGuid Guid)
		{
			this.Radius = Radius;
			this.LimitType = LimitType;
			base.DrivingBoneName = DrivingBoneName;
			base.OffsetLocation = OffsetLocation;
			base.OffsetRotation = OffsetRotation;
			base.Location = Location;
			base.Rotation = Rotation;
			base.Guid = Guid;
		}

		// Token: 0x060142E3 RID: 82659 RVA: 0x001DA3F4 File Offset: 0x001D85F4
		protected override IntPtr GetUStructPtr()
		{
			return FSphericalLimitData.StaticStruct();
		}

		// Token: 0x060142E4 RID: 82660 RVA: 0x001DA400 File Offset: 0x001D8600
		[NullableContext(2)]
		public FSphericalLimitData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060142E5 RID: 82661 RVA: 0x001DA40A File Offset: 0x001D860A
		public FSphericalLimitData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060142E6 RID: 82662 RVA: 0x001DA415 File Offset: 0x001D8615
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSphericalLimitData(Pointer, false, true);
		}

		// Token: 0x060142E7 RID: 82663 RVA: 0x001DA41F File Offset: 0x001D861F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSphericalLimitData(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF93 RID: 44947
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KawaiiPhysics.SphericalLimitData";

		// Token: 0x0400AF94 RID: 44948
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF95 RID: 44949
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400AF96 RID: 44950
		internal static int __PropertyOffset_LimitType;
	}
}
