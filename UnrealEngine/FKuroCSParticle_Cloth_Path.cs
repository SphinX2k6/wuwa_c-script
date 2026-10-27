using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017BA RID: 6074
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_Cloth_Path")]
	[UnrealStructLayout(144, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroCSParticle_Cloth_Path : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060161F3 RID: 90611 RVA: 0x0020660C File Offset: 0x0020480C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_Cloth_Path._ScriptStructPtr != 0) ? FKuroCSParticle_Cloth_Path._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_Cloth_Path", ref FKuroCSParticle_Cloth_Path._ScriptStructPtr);
		}

		// Token: 0x1700585A RID: 22618
		// (get) Token: 0x060161F4 RID: 90612 RVA: 0x00206630 File Offset: 0x00204830
		// (set) Token: 0x060161F5 RID: 90613 RVA: 0x00206644 File Offset: 0x00204844
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x1700585B RID: 22619
		// (get) Token: 0x060161F6 RID: 90614 RVA: 0x00206659 File Offset: 0x00204859
		// (set) Token: 0x060161F7 RID: 90615 RVA: 0x0020666D File Offset: 0x0020486D
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x1700585C RID: 22620
		// (get) Token: 0x060161F8 RID: 90616 RVA: 0x00206682 File Offset: 0x00204882
		// (set) Token: 0x060161F9 RID: 90617 RVA: 0x00206696 File Offset: 0x00204896
		public unsafe FVector normal_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_normal_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_normal_bind) = value;
			}
		}

		// Token: 0x1700585D RID: 22621
		// (get) Token: 0x060161FA RID: 90618 RVA: 0x002066AB File Offset: 0x002048AB
		// (set) Token: 0x060161FB RID: 90619 RVA: 0x002066BF File Offset: 0x002048BF
		public unsafe FVector pos_beforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pos_beforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pos_beforeStage) = value;
			}
		}

		// Token: 0x1700585E RID: 22622
		// (get) Token: 0x060161FC RID: 90620 RVA: 0x002066D4 File Offset: 0x002048D4
		// (set) Token: 0x060161FD RID: 90621 RVA: 0x002066E8 File Offset: 0x002048E8
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x1700585F RID: 22623
		// (get) Token: 0x060161FE RID: 90622 RVA: 0x002066FD File Offset: 0x002048FD
		// (set) Token: 0x060161FF RID: 90623 RVA: 0x0020670D File Offset: 0x0020490D
		public unsafe float pinWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pinWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_pinWeight) = value;
			}
		}

		// Token: 0x17005860 RID: 22624
		// (get) Token: 0x06016200 RID: 90624 RVA: 0x0020671E File Offset: 0x0020491E
		// (set) Token: 0x06016201 RID: 90625 RVA: 0x0020672E File Offset: 0x0020492E
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x17005861 RID: 22625
		// (get) Token: 0x06016202 RID: 90626 RVA: 0x0020673F File Offset: 0x0020493F
		// (set) Token: 0x06016203 RID: 90627 RVA: 0x0020674F File Offset: 0x0020494F
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x17005862 RID: 22626
		// (get) Token: 0x06016204 RID: 90628 RVA: 0x00206760 File Offset: 0x00204960
		// (set) Token: 0x06016205 RID: 90629 RVA: 0x00206770 File Offset: 0x00204970
		public unsafe int TopID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_TopID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_TopID) = value;
			}
		}

		// Token: 0x17005863 RID: 22627
		// (get) Token: 0x06016206 RID: 90630 RVA: 0x00206781 File Offset: 0x00204981
		// (set) Token: 0x06016207 RID: 90631 RVA: 0x00206791 File Offset: 0x00204991
		public unsafe int BottomID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_BottomID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_BottomID) = value;
			}
		}

		// Token: 0x17005864 RID: 22628
		// (get) Token: 0x06016208 RID: 90632 RVA: 0x002067A2 File Offset: 0x002049A2
		// (set) Token: 0x06016209 RID: 90633 RVA: 0x002067B2 File Offset: 0x002049B2
		public unsafe int BottomLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_BottomLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_BottomLeftID) = value;
			}
		}

		// Token: 0x17005865 RID: 22629
		// (get) Token: 0x0601620A RID: 90634 RVA: 0x002067C3 File Offset: 0x002049C3
		// (set) Token: 0x0601620B RID: 90635 RVA: 0x002067D3 File Offset: 0x002049D3
		public unsafe int BottomRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_BottomRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_BottomRightID) = value;
			}
		}

		// Token: 0x17005866 RID: 22630
		// (get) Token: 0x0601620C RID: 90636 RVA: 0x002067E4 File Offset: 0x002049E4
		// (set) Token: 0x0601620D RID: 90637 RVA: 0x002067F4 File Offset: 0x002049F4
		public unsafe int TopLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_TopLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_TopLeftID) = value;
			}
		}

		// Token: 0x17005867 RID: 22631
		// (get) Token: 0x0601620E RID: 90638 RVA: 0x00206805 File Offset: 0x00204A05
		// (set) Token: 0x0601620F RID: 90639 RVA: 0x00206815 File Offset: 0x00204A15
		public unsafe int TopRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_TopRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_TopRightID) = value;
			}
		}

		// Token: 0x17005868 RID: 22632
		// (get) Token: 0x06016210 RID: 90640 RVA: 0x00206826 File Offset: 0x00204A26
		// (set) Token: 0x06016211 RID: 90641 RVA: 0x00206836 File Offset: 0x00204A36
		public unsafe float dis_left
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_left);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_left) = value;
			}
		}

		// Token: 0x17005869 RID: 22633
		// (get) Token: 0x06016212 RID: 90642 RVA: 0x00206847 File Offset: 0x00204A47
		// (set) Token: 0x06016213 RID: 90643 RVA: 0x00206857 File Offset: 0x00204A57
		public unsafe float dis_right
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_right);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_right) = value;
			}
		}

		// Token: 0x1700586A RID: 22634
		// (get) Token: 0x06016214 RID: 90644 RVA: 0x00206868 File Offset: 0x00204A68
		// (set) Token: 0x06016215 RID: 90645 RVA: 0x00206878 File Offset: 0x00204A78
		public unsafe float dis_top
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_top);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_top) = value;
			}
		}

		// Token: 0x1700586B RID: 22635
		// (get) Token: 0x06016216 RID: 90646 RVA: 0x00206889 File Offset: 0x00204A89
		// (set) Token: 0x06016217 RID: 90647 RVA: 0x00206899 File Offset: 0x00204A99
		public unsafe float dis_bottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_bottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_bottom) = value;
			}
		}

		// Token: 0x1700586C RID: 22636
		// (get) Token: 0x06016218 RID: 90648 RVA: 0x002068AA File Offset: 0x00204AAA
		// (set) Token: 0x06016219 RID: 90649 RVA: 0x002068BA File Offset: 0x00204ABA
		public unsafe float dis_bottomLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_bottomLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_bottomLeft) = value;
			}
		}

		// Token: 0x1700586D RID: 22637
		// (get) Token: 0x0601621A RID: 90650 RVA: 0x002068CB File Offset: 0x00204ACB
		// (set) Token: 0x0601621B RID: 90651 RVA: 0x002068DB File Offset: 0x00204ADB
		public unsafe float dis_bottomRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_bottomRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_bottomRight) = value;
			}
		}

		// Token: 0x1700586E RID: 22638
		// (get) Token: 0x0601621C RID: 90652 RVA: 0x002068EC File Offset: 0x00204AEC
		// (set) Token: 0x0601621D RID: 90653 RVA: 0x002068FC File Offset: 0x00204AFC
		public unsafe float dis_topLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_topLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_topLeft) = value;
			}
		}

		// Token: 0x1700586F RID: 22639
		// (get) Token: 0x0601621E RID: 90654 RVA: 0x0020690D File Offset: 0x00204B0D
		// (set) Token: 0x0601621F RID: 90655 RVA: 0x0020691D File Offset: 0x00204B1D
		public unsafe float dis_topRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_topRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_Path.__PropertyOffset_dis_topRight) = value;
			}
		}

		// Token: 0x06016220 RID: 90656 RVA: 0x0020692E File Offset: 0x00204B2E
		public FKuroCSParticle_Cloth_Path()
		{
		}

		// Token: 0x06016221 RID: 90657 RVA: 0x00206938 File Offset: 0x00204B38
		public FKuroCSParticle_Cloth_Path(FVector pos, FVector pos_bind, FVector normal_bind, FVector pos_beforeStage, FVector vol, float pinWeight, int LeftID, int RightID, int TopID, int BottomID, int BottomLeftID, int BottomRightID, int TopLeftID, int TopRightID, float dis_left, float dis_right, float dis_top, float dis_bottom, float dis_bottomLeft, float dis_bottomRight, float dis_topLeft, float dis_topRight)
		{
			this.pos = pos;
			this.pos_bind = pos_bind;
			this.normal_bind = normal_bind;
			this.pos_beforeStage = pos_beforeStage;
			this.vol = vol;
			this.pinWeight = pinWeight;
			this.LeftID = LeftID;
			this.RightID = RightID;
			this.TopID = TopID;
			this.BottomID = BottomID;
			this.BottomLeftID = BottomLeftID;
			this.BottomRightID = BottomRightID;
			this.TopLeftID = TopLeftID;
			this.TopRightID = TopRightID;
			this.dis_left = dis_left;
			this.dis_right = dis_right;
			this.dis_top = dis_top;
			this.dis_bottom = dis_bottom;
			this.dis_bottomLeft = dis_bottomLeft;
			this.dis_bottomRight = dis_bottomRight;
			this.dis_topLeft = dis_topLeft;
			this.dis_topRight = dis_topRight;
		}

		// Token: 0x06016222 RID: 90658 RVA: 0x002069F8 File Offset: 0x00204BF8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_Cloth_Path.StaticStruct();
		}

		// Token: 0x06016223 RID: 90659 RVA: 0x00206A04 File Offset: 0x00204C04
		[NullableContext(2)]
		public FKuroCSParticle_Cloth_Path(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016224 RID: 90660 RVA: 0x00206A0E File Offset: 0x00204C0E
		public FKuroCSParticle_Cloth_Path(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016225 RID: 90661 RVA: 0x00206A19 File Offset: 0x00204C19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_Cloth_Path(Pointer, false, true);
		}

		// Token: 0x06016226 RID: 90662 RVA: 0x00206A23 File Offset: 0x00204C23
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_Cloth_Path(Pointer, MemoryOwner);
		}

		// Token: 0x0400C0B3 RID: 49331
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_Cloth_Path";

		// Token: 0x0400C0B4 RID: 49332
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C0B5 RID: 49333
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C0B6 RID: 49334
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C0B7 RID: 49335
		internal static int __PropertyOffset_normal_bind;

		// Token: 0x0400C0B8 RID: 49336
		internal static int __PropertyOffset_pos_beforeStage;

		// Token: 0x0400C0B9 RID: 49337
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C0BA RID: 49338
		internal static int __PropertyOffset_pinWeight;

		// Token: 0x0400C0BB RID: 49339
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C0BC RID: 49340
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C0BD RID: 49341
		internal static int __PropertyOffset_TopID;

		// Token: 0x0400C0BE RID: 49342
		internal static int __PropertyOffset_BottomID;

		// Token: 0x0400C0BF RID: 49343
		internal static int __PropertyOffset_BottomLeftID;

		// Token: 0x0400C0C0 RID: 49344
		internal static int __PropertyOffset_BottomRightID;

		// Token: 0x0400C0C1 RID: 49345
		internal static int __PropertyOffset_TopLeftID;

		// Token: 0x0400C0C2 RID: 49346
		internal static int __PropertyOffset_TopRightID;

		// Token: 0x0400C0C3 RID: 49347
		internal static int __PropertyOffset_dis_left;

		// Token: 0x0400C0C4 RID: 49348
		internal static int __PropertyOffset_dis_right;

		// Token: 0x0400C0C5 RID: 49349
		internal static int __PropertyOffset_dis_top;

		// Token: 0x0400C0C6 RID: 49350
		internal static int __PropertyOffset_dis_bottom;

		// Token: 0x0400C0C7 RID: 49351
		internal static int __PropertyOffset_dis_bottomLeft;

		// Token: 0x0400C0C8 RID: 49352
		internal static int __PropertyOffset_dis_bottomRight;

		// Token: 0x0400C0C9 RID: 49353
		internal static int __PropertyOffset_dis_topLeft;

		// Token: 0x0400C0CA RID: 49354
		internal static int __PropertyOffset_dis_topRight;
	}
}
