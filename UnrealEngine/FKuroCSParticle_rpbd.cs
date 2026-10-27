using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017C1 RID: 6081
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_rpbd")]
	[UnrealStructLayout(144, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroCSParticle_rpbd : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016373 RID: 90995 RVA: 0x002084E8 File Offset: 0x002066E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_rpbd._ScriptStructPtr != 0) ? FKuroCSParticle_rpbd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_rpbd", ref FKuroCSParticle_rpbd._ScriptStructPtr);
		}

		// Token: 0x170058FE RID: 22782
		// (get) Token: 0x06016374 RID: 90996 RVA: 0x0020850C File Offset: 0x0020670C
		// (set) Token: 0x06016375 RID: 90997 RVA: 0x00208520 File Offset: 0x00206720
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x170058FF RID: 22783
		// (get) Token: 0x06016376 RID: 90998 RVA: 0x00208535 File Offset: 0x00206735
		// (set) Token: 0x06016377 RID: 90999 RVA: 0x00208545 File Offset: 0x00206745
		public unsafe int index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_index) = value;
			}
		}

		// Token: 0x17005900 RID: 22784
		// (get) Token: 0x06016378 RID: 91000 RVA: 0x00208556 File Offset: 0x00206756
		// (set) Token: 0x06016379 RID: 91001 RVA: 0x00208566 File Offset: 0x00206766
		public unsafe int neighbour1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour1) = value;
			}
		}

		// Token: 0x17005901 RID: 22785
		// (get) Token: 0x0601637A RID: 91002 RVA: 0x00208577 File Offset: 0x00206777
		// (set) Token: 0x0601637B RID: 91003 RVA: 0x00208587 File Offset: 0x00206787
		public unsafe int neighbour2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour2) = value;
			}
		}

		// Token: 0x17005902 RID: 22786
		// (get) Token: 0x0601637C RID: 91004 RVA: 0x00208598 File Offset: 0x00206798
		// (set) Token: 0x0601637D RID: 91005 RVA: 0x002085A8 File Offset: 0x002067A8
		public unsafe int neighbour3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour3) = value;
			}
		}

		// Token: 0x17005903 RID: 22787
		// (get) Token: 0x0601637E RID: 91006 RVA: 0x002085B9 File Offset: 0x002067B9
		// (set) Token: 0x0601637F RID: 91007 RVA: 0x002085C9 File Offset: 0x002067C9
		public unsafe int neighbour4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour4) = value;
			}
		}

		// Token: 0x17005904 RID: 22788
		// (get) Token: 0x06016380 RID: 91008 RVA: 0x002085DA File Offset: 0x002067DA
		// (set) Token: 0x06016381 RID: 91009 RVA: 0x002085EE File Offset: 0x002067EE
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x17005905 RID: 22789
		// (get) Token: 0x06016382 RID: 91010 RVA: 0x00208603 File Offset: 0x00206803
		// (set) Token: 0x06016383 RID: 91011 RVA: 0x00208613 File Offset: 0x00206813
		public unsafe int neighbour5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour5) = value;
			}
		}

		// Token: 0x17005906 RID: 22790
		// (get) Token: 0x06016384 RID: 91012 RVA: 0x00208624 File Offset: 0x00206824
		// (set) Token: 0x06016385 RID: 91013 RVA: 0x00208638 File Offset: 0x00206838
		public unsafe FVector pos_foe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos_foe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos_foe) = value;
			}
		}

		// Token: 0x17005907 RID: 22791
		// (get) Token: 0x06016386 RID: 91014 RVA: 0x0020864D File Offset: 0x0020684D
		// (set) Token: 0x06016387 RID: 91015 RVA: 0x0020865D File Offset: 0x0020685D
		public unsafe int neighbour6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour6) = value;
			}
		}

		// Token: 0x17005908 RID: 22792
		// (get) Token: 0x06016388 RID: 91016 RVA: 0x0020866E File Offset: 0x0020686E
		// (set) Token: 0x06016389 RID: 91017 RVA: 0x0020867E File Offset: 0x0020687E
		public unsafe float dis1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis1) = value;
			}
		}

		// Token: 0x17005909 RID: 22793
		// (get) Token: 0x0601638A RID: 91018 RVA: 0x0020868F File Offset: 0x0020688F
		// (set) Token: 0x0601638B RID: 91019 RVA: 0x0020869F File Offset: 0x0020689F
		public unsafe float dis2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis2) = value;
			}
		}

		// Token: 0x1700590A RID: 22794
		// (get) Token: 0x0601638C RID: 91020 RVA: 0x002086B0 File Offset: 0x002068B0
		// (set) Token: 0x0601638D RID: 91021 RVA: 0x002086C0 File Offset: 0x002068C0
		public unsafe float dis3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis3) = value;
			}
		}

		// Token: 0x1700590B RID: 22795
		// (get) Token: 0x0601638E RID: 91022 RVA: 0x002086D1 File Offset: 0x002068D1
		// (set) Token: 0x0601638F RID: 91023 RVA: 0x002086E1 File Offset: 0x002068E1
		public unsafe float dis4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis4) = value;
			}
		}

		// Token: 0x1700590C RID: 22796
		// (get) Token: 0x06016390 RID: 91024 RVA: 0x002086F2 File Offset: 0x002068F2
		// (set) Token: 0x06016391 RID: 91025 RVA: 0x00208702 File Offset: 0x00206902
		public unsafe float dis5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis5) = value;
			}
		}

		// Token: 0x1700590D RID: 22797
		// (get) Token: 0x06016392 RID: 91026 RVA: 0x00208713 File Offset: 0x00206913
		// (set) Token: 0x06016393 RID: 91027 RVA: 0x00208723 File Offset: 0x00206923
		public unsafe float dis6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis6) = value;
			}
		}

		// Token: 0x1700590E RID: 22798
		// (get) Token: 0x06016394 RID: 91028 RVA: 0x00208734 File Offset: 0x00206934
		// (set) Token: 0x06016395 RID: 91029 RVA: 0x00208744 File Offset: 0x00206944
		public unsafe int neighbour7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour7) = value;
			}
		}

		// Token: 0x1700590F RID: 22799
		// (get) Token: 0x06016396 RID: 91030 RVA: 0x00208755 File Offset: 0x00206955
		// (set) Token: 0x06016397 RID: 91031 RVA: 0x00208765 File Offset: 0x00206965
		public unsafe int neighbour8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_neighbour8) = value;
			}
		}

		// Token: 0x17005910 RID: 22800
		// (get) Token: 0x06016398 RID: 91032 RVA: 0x00208776 File Offset: 0x00206976
		// (set) Token: 0x06016399 RID: 91033 RVA: 0x0020878A File Offset: 0x0020698A
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005911 RID: 22801
		// (get) Token: 0x0601639A RID: 91034 RVA: 0x0020879F File Offset: 0x0020699F
		// (set) Token: 0x0601639B RID: 91035 RVA: 0x002087AF File Offset: 0x002069AF
		public unsafe float dis7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis7) = value;
			}
		}

		// Token: 0x17005912 RID: 22802
		// (get) Token: 0x0601639C RID: 91036 RVA: 0x002087C0 File Offset: 0x002069C0
		// (set) Token: 0x0601639D RID: 91037 RVA: 0x002087D4 File Offset: 0x002069D4
		public unsafe FVector pos_before_rotate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos_before_rotate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_pos_before_rotate) = value;
			}
		}

		// Token: 0x17005913 RID: 22803
		// (get) Token: 0x0601639E RID: 91038 RVA: 0x002087E9 File Offset: 0x002069E9
		// (set) Token: 0x0601639F RID: 91039 RVA: 0x002087F9 File Offset: 0x002069F9
		public unsafe float dis8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_dis8) = value;
			}
		}

		// Token: 0x17005914 RID: 22804
		// (get) Token: 0x060163A0 RID: 91040 RVA: 0x0020880A File Offset: 0x00206A0A
		// (set) Token: 0x060163A1 RID: 91041 RVA: 0x0020881E File Offset: 0x00206A1E
		public unsafe FVector myNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_myNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_rpbd.__PropertyOffset_myNormal) = value;
			}
		}

		// Token: 0x060163A2 RID: 91042 RVA: 0x00208833 File Offset: 0x00206A33
		public FKuroCSParticle_rpbd()
		{
		}

		// Token: 0x060163A3 RID: 91043 RVA: 0x0020883C File Offset: 0x00206A3C
		public FKuroCSParticle_rpbd(FVector pos, int index, int neighbour1, int neighbour2, int neighbour3, int neighbour4, FVector pos_bind, int neighbour5, FVector pos_foe, int neighbour6, float dis1, float dis2, float dis3, float dis4, float dis5, float dis6, int neighbour7, int neighbour8, FVector vol, float dis7, FVector pos_before_rotate, float dis8, FVector myNormal)
		{
			this.pos = pos;
			this.index = index;
			this.neighbour1 = neighbour1;
			this.neighbour2 = neighbour2;
			this.neighbour3 = neighbour3;
			this.neighbour4 = neighbour4;
			this.pos_bind = pos_bind;
			this.neighbour5 = neighbour5;
			this.pos_foe = pos_foe;
			this.neighbour6 = neighbour6;
			this.dis1 = dis1;
			this.dis2 = dis2;
			this.dis3 = dis3;
			this.dis4 = dis4;
			this.dis5 = dis5;
			this.dis6 = dis6;
			this.neighbour7 = neighbour7;
			this.neighbour8 = neighbour8;
			this.vol = vol;
			this.dis7 = dis7;
			this.pos_before_rotate = pos_before_rotate;
			this.dis8 = dis8;
			this.myNormal = myNormal;
		}

		// Token: 0x060163A4 RID: 91044 RVA: 0x00208904 File Offset: 0x00206B04
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_rpbd.StaticStruct();
		}

		// Token: 0x060163A5 RID: 91045 RVA: 0x00208910 File Offset: 0x00206B10
		[NullableContext(2)]
		public FKuroCSParticle_rpbd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060163A6 RID: 91046 RVA: 0x0020891A File Offset: 0x00206B1A
		public FKuroCSParticle_rpbd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060163A7 RID: 91047 RVA: 0x00208925 File Offset: 0x00206B25
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_rpbd(Pointer, false, true);
		}

		// Token: 0x060163A8 RID: 91048 RVA: 0x0020892F File Offset: 0x00206B2F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_rpbd(Pointer, MemoryOwner);
		}

		// Token: 0x0400C165 RID: 49509
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_rpbd";

		// Token: 0x0400C166 RID: 49510
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C167 RID: 49511
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C168 RID: 49512
		internal static int __PropertyOffset_index;

		// Token: 0x0400C169 RID: 49513
		internal static int __PropertyOffset_neighbour1;

		// Token: 0x0400C16A RID: 49514
		internal static int __PropertyOffset_neighbour2;

		// Token: 0x0400C16B RID: 49515
		internal static int __PropertyOffset_neighbour3;

		// Token: 0x0400C16C RID: 49516
		internal static int __PropertyOffset_neighbour4;

		// Token: 0x0400C16D RID: 49517
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C16E RID: 49518
		internal static int __PropertyOffset_neighbour5;

		// Token: 0x0400C16F RID: 49519
		internal static int __PropertyOffset_pos_foe;

		// Token: 0x0400C170 RID: 49520
		internal static int __PropertyOffset_neighbour6;

		// Token: 0x0400C171 RID: 49521
		internal static int __PropertyOffset_dis1;

		// Token: 0x0400C172 RID: 49522
		internal static int __PropertyOffset_dis2;

		// Token: 0x0400C173 RID: 49523
		internal static int __PropertyOffset_dis3;

		// Token: 0x0400C174 RID: 49524
		internal static int __PropertyOffset_dis4;

		// Token: 0x0400C175 RID: 49525
		internal static int __PropertyOffset_dis5;

		// Token: 0x0400C176 RID: 49526
		internal static int __PropertyOffset_dis6;

		// Token: 0x0400C177 RID: 49527
		internal static int __PropertyOffset_neighbour7;

		// Token: 0x0400C178 RID: 49528
		internal static int __PropertyOffset_neighbour8;

		// Token: 0x0400C179 RID: 49529
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C17A RID: 49530
		internal static int __PropertyOffset_dis7;

		// Token: 0x0400C17B RID: 49531
		internal static int __PropertyOffset_pos_before_rotate;

		// Token: 0x0400C17C RID: 49532
		internal static int __PropertyOffset_dis8;

		// Token: 0x0400C17D RID: 49533
		internal static int __PropertyOffset_myNormal;
	}
}
