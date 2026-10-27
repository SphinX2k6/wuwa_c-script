using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001720 RID: 5920
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.BulletHitWorldEntityOperation")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FBulletHitWorldEntityOperation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601556F RID: 87407 RVA: 0x001F5C1D File Offset: 0x001F3E1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBulletHitWorldEntityOperation._ScriptStructPtr != 0) ? FBulletHitWorldEntityOperation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBullet.BulletHitWorldEntityOperation", ref FBulletHitWorldEntityOperation._ScriptStructPtr);
		}

		// Token: 0x17005446 RID: 21574
		// (get) Token: 0x06015570 RID: 87408 RVA: 0x001F5C41 File Offset: 0x001F3E41
		// (set) Token: 0x06015571 RID: 87409 RVA: 0x001F5C51 File Offset: 0x001F3E51
		public unsafe EBulletHitWorldEntityOperation OperationType
		{
			get
			{
				return (EBulletHitWorldEntityOperation)(*(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_OperationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_OperationType) = (byte)value;
			}
		}

		// Token: 0x17005447 RID: 21575
		// (get) Token: 0x06015572 RID: 87410 RVA: 0x001F5C64 File Offset: 0x001F3E64
		// (set) Token: 0x06015573 RID: 87411 RVA: 0x001F5CA7 File Offset: 0x001F3EA7
		public FWorldEntityBulletParam ExtraParam
		{
			get
			{
				base.FastCheckIsValid();
				FWorldEntityBulletParam result;
				if ((result = this._ExtraParam) == null)
				{
					result = (this._ExtraParam = new FWorldEntityBulletParam(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_ExtraParam, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldEntityBulletParam.StaticStruct(), base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_ExtraParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005448 RID: 21576
		// (get) Token: 0x06015574 RID: 87412 RVA: 0x001F5CC8 File Offset: 0x001F3EC8
		// (set) Token: 0x06015575 RID: 87413 RVA: 0x001F5CD8 File Offset: 0x001F3ED8
		public unsafe int CasterEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_CasterEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_CasterEntityId) = value;
			}
		}

		// Token: 0x17005449 RID: 21577
		// (get) Token: 0x06015576 RID: 87414 RVA: 0x001F5CE9 File Offset: 0x001F3EE9
		// (set) Token: 0x06015577 RID: 87415 RVA: 0x001F5CF9 File Offset: 0x001F3EF9
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x1700544A RID: 21578
		// (get) Token: 0x06015578 RID: 87416 RVA: 0x001F5D0A File Offset: 0x001F3F0A
		// (set) Token: 0x06015579 RID: 87417 RVA: 0x001F5D1A File Offset: 0x001F3F1A
		public unsafe long LongParam1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_LongParam1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_LongParam1) = value;
			}
		}

		// Token: 0x1700544B RID: 21579
		// (get) Token: 0x0601557A RID: 87418 RVA: 0x001F5D2B File Offset: 0x001F3F2B
		// (set) Token: 0x0601557B RID: 87419 RVA: 0x001F5D3F File Offset: 0x001F3F3F
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700544C RID: 21580
		// (get) Token: 0x0601557C RID: 87420 RVA: 0x001F5D54 File Offset: 0x001F3F54
		// (set) Token: 0x0601557D RID: 87421 RVA: 0x001F5D68 File Offset: 0x001F3F68
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBulletHitWorldEntityOperation.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x0601557E RID: 87422 RVA: 0x001F5D7D File Offset: 0x001F3F7D
		public FBulletHitWorldEntityOperation()
		{
		}

		// Token: 0x0601557F RID: 87423 RVA: 0x001F5D85 File Offset: 0x001F3F85
		public FBulletHitWorldEntityOperation(EBulletHitWorldEntityOperation OperationType, FWorldEntityBulletParam ExtraParam, int CasterEntityId, int EntityId, long LongParam1, FVectorDouble Location, FRotator Rotation)
		{
			this.OperationType = OperationType;
			this.ExtraParam = ExtraParam;
			this.CasterEntityId = CasterEntityId;
			this.EntityId = EntityId;
			this.LongParam1 = LongParam1;
			this.Location = Location;
			this.Rotation = Rotation;
		}

		// Token: 0x06015580 RID: 87424 RVA: 0x001F5DC2 File Offset: 0x001F3FC2
		protected override IntPtr GetUStructPtr()
		{
			return FBulletHitWorldEntityOperation.StaticStruct();
		}

		// Token: 0x06015581 RID: 87425 RVA: 0x001F5DCE File Offset: 0x001F3FCE
		[NullableContext(2)]
		public FBulletHitWorldEntityOperation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015582 RID: 87426 RVA: 0x001F5DD8 File Offset: 0x001F3FD8
		public FBulletHitWorldEntityOperation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015583 RID: 87427 RVA: 0x001F5DE3 File Offset: 0x001F3FE3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBulletHitWorldEntityOperation(Pointer, false, true);
		}

		// Token: 0x06015584 RID: 87428 RVA: 0x001F5DED File Offset: 0x001F3FED
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBulletHitWorldEntityOperation(Pointer, MemoryOwner);
		}

		// Token: 0x0400BA0D RID: 47629
		public const string __ObjectPath = "/Script/KuroBullet.BulletHitWorldEntityOperation";

		// Token: 0x0400BA0E RID: 47630
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BA0F RID: 47631
		internal static int __PropertyOffset_OperationType;

		// Token: 0x0400BA10 RID: 47632
		internal static int __PropertyOffset_ExtraParam;

		// Token: 0x0400BA11 RID: 47633
		[Nullable(2)]
		private FWorldEntityBulletParam _ExtraParam;

		// Token: 0x0400BA12 RID: 47634
		internal static int __PropertyOffset_CasterEntityId;

		// Token: 0x0400BA13 RID: 47635
		internal static int __PropertyOffset_EntityId;

		// Token: 0x0400BA14 RID: 47636
		internal static int __PropertyOffset_LongParam1;

		// Token: 0x0400BA15 RID: 47637
		internal static int __PropertyOffset_Location;

		// Token: 0x0400BA16 RID: 47638
		internal static int __PropertyOffset_Rotation;
	}
}
