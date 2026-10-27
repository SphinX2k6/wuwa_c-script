using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015C9 RID: 5577
	[UnrealObjectPath("/Script/KawaiiPhysics.CapsuleLimit")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FCapsuleLimit : FCollisionLimitBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060141EC RID: 82412 RVA: 0x001D8E5C File Offset: 0x001D705C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCapsuleLimit._ScriptStructPtr != 0) ? FCapsuleLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.CapsuleLimit", ref FCapsuleLimit._ScriptStructPtr);
		}

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x060141ED RID: 82413 RVA: 0x001D8E80 File Offset: 0x001D7080
		// (set) Token: 0x060141EE RID: 82414 RVA: 0x001D8E90 File Offset: 0x001D7090
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleLimit.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleLimit.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x060141EF RID: 82415 RVA: 0x001D8EA1 File Offset: 0x001D70A1
		// (set) Token: 0x060141F0 RID: 82416 RVA: 0x001D8EB1 File Offset: 0x001D70B1
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleLimit.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleLimit.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x060141F1 RID: 82417 RVA: 0x001D8EC2 File Offset: 0x001D70C2
		public FCapsuleLimit()
		{
		}

		// Token: 0x060141F2 RID: 82418 RVA: 0x001D8ECA File Offset: 0x001D70CA
		[NullableContext(1)]
		public FCapsuleLimit(float Radius, float Length, FBoneReference DrivingBone, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, bool bFromDataAsset, FGuid Guid, ECollisionLimitType Type)
		{
			this.Radius = Radius;
			this.Length = Length;
			base.DrivingBone = DrivingBone;
			base.OffsetLocation = OffsetLocation;
			base.OffsetRotation = OffsetRotation;
			base.Location = Location;
			base.Rotation = Rotation;
		}

		// Token: 0x060141F3 RID: 82419 RVA: 0x001D8F07 File Offset: 0x001D7107
		protected override IntPtr GetUStructPtr()
		{
			return FCapsuleLimit.StaticStruct();
		}

		// Token: 0x060141F4 RID: 82420 RVA: 0x001D8F13 File Offset: 0x001D7113
		[NullableContext(2)]
		public FCapsuleLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060141F5 RID: 82421 RVA: 0x001D8F1D File Offset: 0x001D711D
		public FCapsuleLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060141F6 RID: 82422 RVA: 0x001D8F28 File Offset: 0x001D7128
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCapsuleLimit(Pointer, false, true);
		}

		// Token: 0x060141F7 RID: 82423 RVA: 0x001D8F32 File Offset: 0x001D7132
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCapsuleLimit(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF0D RID: 44813
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KawaiiPhysics.CapsuleLimit";

		// Token: 0x0400AF0E RID: 44814
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF0F RID: 44815
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400AF10 RID: 44816
		internal static int __PropertyOffset_Length;
	}
}
