using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017BF RID: 6079
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_liuShu")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroCSParticle_liuShu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016343 RID: 90947 RVA: 0x00208130 File Offset: 0x00206330
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_liuShu._ScriptStructPtr != 0) ? FKuroCSParticle_liuShu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_liuShu", ref FKuroCSParticle_liuShu._ScriptStructPtr);
		}

		// Token: 0x170058EE RID: 22766
		// (get) Token: 0x06016344 RID: 90948 RVA: 0x00208154 File Offset: 0x00206354
		// (set) Token: 0x06016345 RID: 90949 RVA: 0x00208168 File Offset: 0x00206368
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x170058EF RID: 22767
		// (get) Token: 0x06016346 RID: 90950 RVA: 0x0020817D File Offset: 0x0020637D
		// (set) Token: 0x06016347 RID: 90951 RVA: 0x0020818D File Offset: 0x0020638D
		public unsafe int IDA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_IDA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_IDA) = value;
			}
		}

		// Token: 0x170058F0 RID: 22768
		// (get) Token: 0x06016348 RID: 90952 RVA: 0x0020819E File Offset: 0x0020639E
		// (set) Token: 0x06016349 RID: 90953 RVA: 0x002081B2 File Offset: 0x002063B2
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x170058F1 RID: 22769
		// (get) Token: 0x0601634A RID: 90954 RVA: 0x002081C7 File Offset: 0x002063C7
		// (set) Token: 0x0601634B RID: 90955 RVA: 0x002081D7 File Offset: 0x002063D7
		public unsafe int IDB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_IDB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_IDB) = value;
			}
		}

		// Token: 0x170058F2 RID: 22770
		// (get) Token: 0x0601634C RID: 90956 RVA: 0x002081E8 File Offset: 0x002063E8
		// (set) Token: 0x0601634D RID: 90957 RVA: 0x002081FC File Offset: 0x002063FC
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x170058F3 RID: 22771
		// (get) Token: 0x0601634E RID: 90958 RVA: 0x00208211 File Offset: 0x00206411
		// (set) Token: 0x0601634F RID: 90959 RVA: 0x00208221 File Offset: 0x00206421
		public unsafe float percent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_percent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_percent) = value;
			}
		}

		// Token: 0x170058F4 RID: 22772
		// (get) Token: 0x06016350 RID: 90960 RVA: 0x00208232 File Offset: 0x00206432
		// (set) Token: 0x06016351 RID: 90961 RVA: 0x00208246 File Offset: 0x00206446
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x170058F5 RID: 22773
		// (get) Token: 0x06016352 RID: 90962 RVA: 0x0020825B File Offset: 0x0020645B
		// (set) Token: 0x06016353 RID: 90963 RVA: 0x0020826B File Offset: 0x0020646B
		public unsafe int hardPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_hardPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_hardPoint) = value;
			}
		}

		// Token: 0x170058F6 RID: 22774
		// (get) Token: 0x06016354 RID: 90964 RVA: 0x0020827C File Offset: 0x0020647C
		// (set) Token: 0x06016355 RID: 90965 RVA: 0x00208290 File Offset: 0x00206490
		public unsafe FVector col
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_col);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_liuShu.__PropertyOffset_col) = value;
			}
		}

		// Token: 0x06016356 RID: 90966 RVA: 0x002082A5 File Offset: 0x002064A5
		public FKuroCSParticle_liuShu()
		{
		}

		// Token: 0x06016357 RID: 90967 RVA: 0x002082B0 File Offset: 0x002064B0
		public FKuroCSParticle_liuShu(FVector pos, int IDA, FVector posFoe, int IDB, FVector pos_bind, float percent, FVector vol, int hardPoint, FVector col)
		{
			this.pos = pos;
			this.IDA = IDA;
			this.posFoe = posFoe;
			this.IDB = IDB;
			this.pos_bind = pos_bind;
			this.percent = percent;
			this.vol = vol;
			this.hardPoint = hardPoint;
			this.col = col;
		}

		// Token: 0x06016358 RID: 90968 RVA: 0x00208308 File Offset: 0x00206508
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_liuShu.StaticStruct();
		}

		// Token: 0x06016359 RID: 90969 RVA: 0x00208314 File Offset: 0x00206514
		[NullableContext(2)]
		public FKuroCSParticle_liuShu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601635A RID: 90970 RVA: 0x0020831E File Offset: 0x0020651E
		public FKuroCSParticle_liuShu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601635B RID: 90971 RVA: 0x00208329 File Offset: 0x00206529
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_liuShu(Pointer, false, true);
		}

		// Token: 0x0601635C RID: 90972 RVA: 0x00208333 File Offset: 0x00206533
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_liuShu(Pointer, MemoryOwner);
		}

		// Token: 0x0400C151 RID: 49489
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_liuShu";

		// Token: 0x0400C152 RID: 49490
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C153 RID: 49491
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C154 RID: 49492
		internal static int __PropertyOffset_IDA;

		// Token: 0x0400C155 RID: 49493
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C156 RID: 49494
		internal static int __PropertyOffset_IDB;

		// Token: 0x0400C157 RID: 49495
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C158 RID: 49496
		internal static int __PropertyOffset_percent;

		// Token: 0x0400C159 RID: 49497
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C15A RID: 49498
		internal static int __PropertyOffset_hardPoint;

		// Token: 0x0400C15B RID: 49499
		internal static int __PropertyOffset_col;
	}
}
