using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000331 RID: 817
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.BulletHitWorldEntityOperation")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FBulletHitWorldEntityOperation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600553F RID: 21823 RVA: 0x00077401 File Offset: 0x00075601
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBulletHitWorldEntityOperation._ScriptStructPtr != 0) ? FBulletHitWorldEntityOperation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBullet.BulletHitWorldEntityOperation", ref FBulletHitWorldEntityOperation._ScriptStructPtr);
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x00077425 File Offset: 0x00075625
		// (set) Token: 0x06005541 RID: 21825 RVA: 0x00077435 File Offset: 0x00075635
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

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x00077448 File Offset: 0x00075648
		// (set) Token: 0x06005543 RID: 21827 RVA: 0x0007748B File Offset: 0x0007568B
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

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x000774AC File Offset: 0x000756AC
		// (set) Token: 0x06005545 RID: 21829 RVA: 0x000774BC File Offset: 0x000756BC
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

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x000774CD File Offset: 0x000756CD
		// (set) Token: 0x06005547 RID: 21831 RVA: 0x000774DD File Offset: 0x000756DD
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

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06005548 RID: 21832 RVA: 0x000774EE File Offset: 0x000756EE
		// (set) Token: 0x06005549 RID: 21833 RVA: 0x000774FE File Offset: 0x000756FE
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

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x0600554A RID: 21834 RVA: 0x0007750F File Offset: 0x0007570F
		// (set) Token: 0x0600554B RID: 21835 RVA: 0x00077523 File Offset: 0x00075723
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

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x0600554C RID: 21836 RVA: 0x00077538 File Offset: 0x00075738
		// (set) Token: 0x0600554D RID: 21837 RVA: 0x0007754C File Offset: 0x0007574C
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

		// Token: 0x0600554E RID: 21838 RVA: 0x00077561 File Offset: 0x00075761
		public FBulletHitWorldEntityOperation()
		{
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x00077569 File Offset: 0x00075769
		protected override IntPtr GetUStructPtr()
		{
			return FBulletHitWorldEntityOperation.StaticStruct();
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00077575 File Offset: 0x00075775
		[NullableContext(2)]
		public FBulletHitWorldEntityOperation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x0007757F File Offset: 0x0007577F
		public FBulletHitWorldEntityOperation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x0007758A File Offset: 0x0007578A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBulletHitWorldEntityOperation(Pointer, false, true);
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00077594 File Offset: 0x00075794
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBulletHitWorldEntityOperation(Pointer, MemoryOwner);
		}

		// Token: 0x040022C9 RID: 8905
		public const string __ObjectPath = "/Script/KuroBullet.BulletHitWorldEntityOperation";

		// Token: 0x040022CA RID: 8906
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022CB RID: 8907
		internal static int __PropertyOffset_OperationType;

		// Token: 0x040022CC RID: 8908
		internal static int __PropertyOffset_ExtraParam;

		// Token: 0x040022CD RID: 8909
		[Nullable(2)]
		private FWorldEntityBulletParam _ExtraParam;

		// Token: 0x040022CE RID: 8910
		internal static int __PropertyOffset_CasterEntityId;

		// Token: 0x040022CF RID: 8911
		internal static int __PropertyOffset_EntityId;

		// Token: 0x040022D0 RID: 8912
		internal static int __PropertyOffset_LongParam1;

		// Token: 0x040022D1 RID: 8913
		internal static int __PropertyOffset_Location;

		// Token: 0x040022D2 RID: 8914
		internal static int __PropertyOffset_Rotation;
	}
}
