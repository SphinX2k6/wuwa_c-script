using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015CA RID: 5578
	[UnrealObjectPath("/Script/KawaiiPhysics.CapsuleLimitData")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FCapsuleLimitData : FCollisionLimitDataBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060141F8 RID: 82424 RVA: 0x001D8F3B File Offset: 0x001D713B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCapsuleLimitData._ScriptStructPtr != 0) ? FCapsuleLimitData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.CapsuleLimitData", ref FCapsuleLimitData._ScriptStructPtr);
		}

		// Token: 0x17004EE5 RID: 20197
		// (get) Token: 0x060141F9 RID: 82425 RVA: 0x001D8F5F File Offset: 0x001D715F
		// (set) Token: 0x060141FA RID: 82426 RVA: 0x001D8F6F File Offset: 0x001D716F
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleLimitData.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleLimitData.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004EE6 RID: 20198
		// (get) Token: 0x060141FB RID: 82427 RVA: 0x001D8F80 File Offset: 0x001D7180
		// (set) Token: 0x060141FC RID: 82428 RVA: 0x001D8F90 File Offset: 0x001D7190
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCapsuleLimitData.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCapsuleLimitData.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x060141FD RID: 82429 RVA: 0x001D8FA1 File Offset: 0x001D71A1
		public FCapsuleLimitData()
		{
		}

		// Token: 0x060141FE RID: 82430 RVA: 0x001D8FAC File Offset: 0x001D71AC
		public FCapsuleLimitData(float Radius, float Length, FName DrivingBoneName, FVector OffsetLocation, FRotator OffsetRotation, FVector Location, FQuat Rotation, FGuid Guid)
		{
			this.Radius = Radius;
			this.Length = Length;
			base.DrivingBoneName = DrivingBoneName;
			base.OffsetLocation = OffsetLocation;
			base.OffsetRotation = OffsetRotation;
			base.Location = Location;
			base.Rotation = Rotation;
			base.Guid = Guid;
		}

		// Token: 0x060141FF RID: 82431 RVA: 0x001D8FFC File Offset: 0x001D71FC
		protected override IntPtr GetUStructPtr()
		{
			return FCapsuleLimitData.StaticStruct();
		}

		// Token: 0x06014200 RID: 82432 RVA: 0x001D9008 File Offset: 0x001D7208
		[NullableContext(2)]
		public FCapsuleLimitData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014201 RID: 82433 RVA: 0x001D9012 File Offset: 0x001D7212
		public FCapsuleLimitData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014202 RID: 82434 RVA: 0x001D901D File Offset: 0x001D721D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCapsuleLimitData(Pointer, false, true);
		}

		// Token: 0x06014203 RID: 82435 RVA: 0x001D9027 File Offset: 0x001D7227
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCapsuleLimitData(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF11 RID: 44817
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KawaiiPhysics.CapsuleLimitData";

		// Token: 0x0400AF12 RID: 44818
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF13 RID: 44819
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400AF14 RID: 44820
		internal static int __PropertyOffset_Length;
	}
}
