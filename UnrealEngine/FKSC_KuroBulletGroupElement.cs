using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001732 RID: 5938
	[UnrealObjectPath("/Script/KuroBullet.KSC_KuroBulletGroupElement")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKSC_KuroBulletGroupElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015600 RID: 87552 RVA: 0x001F686E File Offset: 0x001F4A6E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_KuroBulletGroupElement._ScriptStructPtr != 0) ? FKSC_KuroBulletGroupElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBullet.KSC_KuroBulletGroupElement", ref FKSC_KuroBulletGroupElement._ScriptStructPtr);
		}

		// Token: 0x17005471 RID: 21617
		// (get) Token: 0x06015601 RID: 87553 RVA: 0x001F6892 File Offset: 0x001F4A92
		// (set) Token: 0x06015602 RID: 87554 RVA: 0x001F68A2 File Offset: 0x001F4AA2
		public unsafe long BulletConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletConfigId) = value;
			}
		}

		// Token: 0x17005472 RID: 21618
		// (get) Token: 0x06015603 RID: 87555 RVA: 0x001F68B3 File Offset: 0x001F4AB3
		// (set) Token: 0x06015604 RID: 87556 RVA: 0x001F68C3 File Offset: 0x001F4AC3
		public unsafe EKSC_PTT_BulletTarget Target
		{
			get
			{
				return (EKSC_PTT_BulletTarget)(*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_Target));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_Target) = (byte)value;
			}
		}

		// Token: 0x17005473 RID: 21619
		// (get) Token: 0x06015605 RID: 87557 RVA: 0x001F68D4 File Offset: 0x001F4AD4
		// (set) Token: 0x06015606 RID: 87558 RVA: 0x001F68E4 File Offset: 0x001F4AE4
		public unsafe EKSC_PTT_BulletDirection BulletDirection
		{
			get
			{
				return (EKSC_PTT_BulletDirection)(*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletDirection) = (byte)value;
			}
		}

		// Token: 0x17005474 RID: 21620
		// (get) Token: 0x06015607 RID: 87559 RVA: 0x001F68F5 File Offset: 0x001F4AF5
		// (set) Token: 0x06015608 RID: 87560 RVA: 0x001F6905 File Offset: 0x001F4B05
		public unsafe float AttackRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_AttackRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_AttackRange) = value;
			}
		}

		// Token: 0x17005475 RID: 21621
		// (get) Token: 0x06015609 RID: 87561 RVA: 0x001F6916 File Offset: 0x001F4B16
		// (set) Token: 0x0601560A RID: 87562 RVA: 0x001F6926 File Offset: 0x001F4B26
		public unsafe int MultiBulletNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_MultiBulletNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_MultiBulletNum) = value;
			}
		}

		// Token: 0x17005476 RID: 21622
		// (get) Token: 0x0601560B RID: 87563 RVA: 0x001F6937 File Offset: 0x001F4B37
		// (set) Token: 0x0601560C RID: 87564 RVA: 0x001F6947 File Offset: 0x001F4B47
		public unsafe float MultiBulletInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_MultiBulletInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_MultiBulletInterval) = value;
			}
		}

		// Token: 0x17005477 RID: 21623
		// (get) Token: 0x0601560D RID: 87565 RVA: 0x001F6958 File Offset: 0x001F4B58
		// (set) Token: 0x0601560E RID: 87566 RVA: 0x001F6968 File Offset: 0x001F4B68
		public unsafe float MultiBulletIntervalMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_MultiBulletIntervalMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_MultiBulletIntervalMin) = value;
			}
		}

		// Token: 0x17005478 RID: 21624
		// (get) Token: 0x0601560F RID: 87567 RVA: 0x001F6979 File Offset: 0x001F4B79
		// (set) Token: 0x06015610 RID: 87568 RVA: 0x001F6989 File Offset: 0x001F4B89
		public unsafe EKSC_PTT_KuroBulletAttackType AttackType
		{
			get
			{
				return (EKSC_PTT_KuroBulletAttackType)(*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_AttackType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_AttackType) = (byte)value;
			}
		}

		// Token: 0x17005479 RID: 21625
		// (get) Token: 0x06015611 RID: 87569 RVA: 0x001F699A File Offset: 0x001F4B9A
		// (set) Token: 0x06015612 RID: 87570 RVA: 0x001F69AA File Offset: 0x001F4BAA
		public unsafe EKSC_PTT_KuroBulletHandAttack HandAttackType
		{
			get
			{
				return (EKSC_PTT_KuroBulletHandAttack)(*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_HandAttackType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_HandAttackType) = (byte)value;
			}
		}

		// Token: 0x1700547A RID: 21626
		// (get) Token: 0x06015613 RID: 87571 RVA: 0x001F69BB File Offset: 0x001F4BBB
		// (set) Token: 0x06015614 RID: 87572 RVA: 0x001F69CB File Offset: 0x001F4BCB
		public unsafe bool EnableCatapult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_EnableCatapult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_EnableCatapult) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700547B RID: 21627
		// (get) Token: 0x06015615 RID: 87573 RVA: 0x001F69DC File Offset: 0x001F4BDC
		// (set) Token: 0x06015616 RID: 87574 RVA: 0x001F69EC File Offset: 0x001F4BEC
		public unsafe bool EnablePenetrate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_EnablePenetrate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_EnablePenetrate) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700547C RID: 21628
		// (get) Token: 0x06015617 RID: 87575 RVA: 0x001F69FD File Offset: 0x001F4BFD
		// (set) Token: 0x06015618 RID: 87576 RVA: 0x001F6A0D File Offset: 0x001F4C0D
		public unsafe int BulletNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletNum) = value;
			}
		}

		// Token: 0x1700547D RID: 21629
		// (get) Token: 0x06015619 RID: 87577 RVA: 0x001F6A1E File Offset: 0x001F4C1E
		// (set) Token: 0x0601561A RID: 87578 RVA: 0x001F6A2E File Offset: 0x001F4C2E
		public unsafe float BulletTotalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletTotalAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_KuroBulletGroupElement.__PropertyOffset_BulletTotalAngle) = value;
			}
		}

		// Token: 0x0601561B RID: 87579 RVA: 0x001F6A3F File Offset: 0x001F4C3F
		public FKSC_KuroBulletGroupElement()
		{
		}

		// Token: 0x0601561C RID: 87580 RVA: 0x001F6A48 File Offset: 0x001F4C48
		public FKSC_KuroBulletGroupElement(long BulletConfigId, EKSC_PTT_BulletTarget Target, EKSC_PTT_BulletDirection BulletDirection, float AttackRange, int MultiBulletNum, float MultiBulletInterval, float MultiBulletIntervalMin, EKSC_PTT_KuroBulletAttackType AttackType, EKSC_PTT_KuroBulletHandAttack HandAttackType, bool EnableCatapult, bool EnablePenetrate, int BulletNum, float BulletTotalAngle)
		{
			this.BulletConfigId = BulletConfigId;
			this.Target = Target;
			this.BulletDirection = BulletDirection;
			this.AttackRange = AttackRange;
			this.MultiBulletNum = MultiBulletNum;
			this.MultiBulletInterval = MultiBulletInterval;
			this.MultiBulletIntervalMin = MultiBulletIntervalMin;
			this.AttackType = AttackType;
			this.HandAttackType = HandAttackType;
			this.EnableCatapult = EnableCatapult;
			this.EnablePenetrate = EnablePenetrate;
			this.BulletNum = BulletNum;
			this.BulletTotalAngle = BulletTotalAngle;
		}

		// Token: 0x0601561D RID: 87581 RVA: 0x001F6AC0 File Offset: 0x001F4CC0
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_KuroBulletGroupElement.StaticStruct();
		}

		// Token: 0x0601561E RID: 87582 RVA: 0x001F6ACC File Offset: 0x001F4CCC
		[NullableContext(2)]
		public FKSC_KuroBulletGroupElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601561F RID: 87583 RVA: 0x001F6AD6 File Offset: 0x001F4CD6
		public FKSC_KuroBulletGroupElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015620 RID: 87584 RVA: 0x001F6AE1 File Offset: 0x001F4CE1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_KuroBulletGroupElement(Pointer, false, true);
		}

		// Token: 0x06015621 RID: 87585 RVA: 0x001F6AEB File Offset: 0x001F4CEB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_KuroBulletGroupElement(Pointer, MemoryOwner);
		}

		// Token: 0x0400BA83 RID: 47747
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBullet.KSC_KuroBulletGroupElement";

		// Token: 0x0400BA84 RID: 47748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BA85 RID: 47749
		internal static int __PropertyOffset_BulletConfigId;

		// Token: 0x0400BA86 RID: 47750
		internal static int __PropertyOffset_Target;

		// Token: 0x0400BA87 RID: 47751
		internal static int __PropertyOffset_BulletDirection;

		// Token: 0x0400BA88 RID: 47752
		internal static int __PropertyOffset_AttackRange;

		// Token: 0x0400BA89 RID: 47753
		internal static int __PropertyOffset_MultiBulletNum;

		// Token: 0x0400BA8A RID: 47754
		internal static int __PropertyOffset_MultiBulletInterval;

		// Token: 0x0400BA8B RID: 47755
		internal static int __PropertyOffset_MultiBulletIntervalMin;

		// Token: 0x0400BA8C RID: 47756
		internal static int __PropertyOffset_AttackType;

		// Token: 0x0400BA8D RID: 47757
		internal static int __PropertyOffset_HandAttackType;

		// Token: 0x0400BA8E RID: 47758
		internal static int __PropertyOffset_EnableCatapult;

		// Token: 0x0400BA8F RID: 47759
		internal static int __PropertyOffset_EnablePenetrate;

		// Token: 0x0400BA90 RID: 47760
		internal static int __PropertyOffset_BulletNum;

		// Token: 0x0400BA91 RID: 47761
		internal static int __PropertyOffset_BulletTotalAngle;
	}
}
