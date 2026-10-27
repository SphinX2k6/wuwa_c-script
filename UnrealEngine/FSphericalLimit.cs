using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015DB RID: 5595
	[UnrealObjectPath("/Script/KawaiiPhysics.SphericalLimit")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FSphericalLimit : FCollisionLimitBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060142D0 RID: 82640 RVA: 0x001DA254 File Offset: 0x001D8454
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSphericalLimit._ScriptStructPtr != 0) ? FSphericalLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.SphericalLimit", ref FSphericalLimit._ScriptStructPtr);
		}

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x060142D1 RID: 82641 RVA: 0x001DA278 File Offset: 0x001D8478
		// (set) Token: 0x060142D2 RID: 82642 RVA: 0x001DA288 File Offset: 0x001D8488
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSphericalLimit.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphericalLimit.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x060142D3 RID: 82643 RVA: 0x001DA299 File Offset: 0x001D8499
		// (set) Token: 0x060142D4 RID: 82644 RVA: 0x001DA2A9 File Offset: 0x001D84A9
		public unsafe ESphericalLimitType LimitType
		{
			get
			{
				return (ESphericalLimitType)(*(base.NativePtr + (IntPtr)FSphericalLimit.__PropertyOffset_LimitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSphericalLimit.__PropertyOffset_LimitType) = (byte)value;
			}
		}

		// Token: 0x060142D5 RID: 82645 RVA: 0x001DA2BA File Offset: 0x001D84BA
		public FSphericalLimit()
		{
		}

		// Token: 0x060142D6 RID: 82646 RVA: 0x001DA2C2 File Offset: 0x001D84C2
		[NullableContext(1)]
		public FSphericalLimit(float Radius, ESphericalLimitType LimitType, FBoneReference DrivingBone, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, bool bFromDataAsset, FGuid Guid, ECollisionLimitType Type)
		{
			this.Radius = Radius;
			this.LimitType = LimitType;
			base.DrivingBone = DrivingBone;
			base.OffsetLocation = OffsetLocation;
			base.OffsetRotation = OffsetRotation;
			base.Location = Location;
			base.Rotation = Rotation;
		}

		// Token: 0x060142D7 RID: 82647 RVA: 0x001DA2FF File Offset: 0x001D84FF
		protected override IntPtr GetUStructPtr()
		{
			return FSphericalLimit.StaticStruct();
		}

		// Token: 0x060142D8 RID: 82648 RVA: 0x001DA30B File Offset: 0x001D850B
		[NullableContext(2)]
		public FSphericalLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060142D9 RID: 82649 RVA: 0x001DA315 File Offset: 0x001D8515
		public FSphericalLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060142DA RID: 82650 RVA: 0x001DA320 File Offset: 0x001D8520
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSphericalLimit(Pointer, false, true);
		}

		// Token: 0x060142DB RID: 82651 RVA: 0x001DA32A File Offset: 0x001D852A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSphericalLimit(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF8F RID: 44943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KawaiiPhysics.SphericalLimit";

		// Token: 0x0400AF90 RID: 44944
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF91 RID: 44945
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400AF92 RID: 44946
		internal static int __PropertyOffset_LimitType;
	}
}
