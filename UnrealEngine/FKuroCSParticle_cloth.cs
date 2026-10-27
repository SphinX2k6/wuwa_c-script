using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B8 RID: 6072
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_cloth")]
	[UnrealStructLayout(112, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroCSParticle_cloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060161A1 RID: 90529 RVA: 0x00205F98 File Offset: 0x00204198
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_cloth._ScriptStructPtr != 0) ? FKuroCSParticle_cloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_cloth", ref FKuroCSParticle_cloth._ScriptStructPtr);
		}

		// Token: 0x17005839 RID: 22585
		// (get) Token: 0x060161A2 RID: 90530 RVA: 0x00205FBC File Offset: 0x002041BC
		// (set) Token: 0x060161A3 RID: 90531 RVA: 0x00205FD0 File Offset: 0x002041D0
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x1700583A RID: 22586
		// (get) Token: 0x060161A4 RID: 90532 RVA: 0x00205FE5 File Offset: 0x002041E5
		// (set) Token: 0x060161A5 RID: 90533 RVA: 0x00205FF5 File Offset: 0x002041F5
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x1700583B RID: 22587
		// (get) Token: 0x060161A6 RID: 90534 RVA: 0x00206006 File Offset: 0x00204206
		// (set) Token: 0x060161A7 RID: 90535 RVA: 0x0020601A File Offset: 0x0020421A
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x1700583C RID: 22588
		// (get) Token: 0x060161A8 RID: 90536 RVA: 0x0020602F File Offset: 0x0020422F
		// (set) Token: 0x060161A9 RID: 90537 RVA: 0x0020603F File Offset: 0x0020423F
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x1700583D RID: 22589
		// (get) Token: 0x060161AA RID: 90538 RVA: 0x00206050 File Offset: 0x00204250
		// (set) Token: 0x060161AB RID: 90539 RVA: 0x00206064 File Offset: 0x00204264
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x1700583E RID: 22590
		// (get) Token: 0x060161AC RID: 90540 RVA: 0x00206079 File Offset: 0x00204279
		// (set) Token: 0x060161AD RID: 90541 RVA: 0x00206089 File Offset: 0x00204289
		public unsafe int TopID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopID) = value;
			}
		}

		// Token: 0x1700583F RID: 22591
		// (get) Token: 0x060161AE RID: 90542 RVA: 0x0020609A File Offset: 0x0020429A
		// (set) Token: 0x060161AF RID: 90543 RVA: 0x002060AE File Offset: 0x002042AE
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005840 RID: 22592
		// (get) Token: 0x060161B0 RID: 90544 RVA: 0x002060C3 File Offset: 0x002042C3
		// (set) Token: 0x060161B1 RID: 90545 RVA: 0x002060D3 File Offset: 0x002042D3
		public unsafe int BottomID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomID) = value;
			}
		}

		// Token: 0x17005841 RID: 22593
		// (get) Token: 0x060161B2 RID: 90546 RVA: 0x002060E4 File Offset: 0x002042E4
		// (set) Token: 0x060161B3 RID: 90547 RVA: 0x002060F4 File Offset: 0x002042F4
		public unsafe int BottomLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomLeftID) = value;
			}
		}

		// Token: 0x17005842 RID: 22594
		// (get) Token: 0x060161B4 RID: 90548 RVA: 0x00206105 File Offset: 0x00204305
		// (set) Token: 0x060161B5 RID: 90549 RVA: 0x00206115 File Offset: 0x00204315
		public unsafe int BottomRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomRightID) = value;
			}
		}

		// Token: 0x17005843 RID: 22595
		// (get) Token: 0x060161B6 RID: 90550 RVA: 0x00206126 File Offset: 0x00204326
		// (set) Token: 0x060161B7 RID: 90551 RVA: 0x00206136 File Offset: 0x00204336
		public unsafe int TopLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopLeftID) = value;
			}
		}

		// Token: 0x17005844 RID: 22596
		// (get) Token: 0x060161B8 RID: 90552 RVA: 0x00206147 File Offset: 0x00204347
		// (set) Token: 0x060161B9 RID: 90553 RVA: 0x00206157 File Offset: 0x00204357
		public unsafe int TopRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopRightID) = value;
			}
		}

		// Token: 0x17005845 RID: 22597
		// (get) Token: 0x060161BA RID: 90554 RVA: 0x00206168 File Offset: 0x00204368
		// (set) Token: 0x060161BB RID: 90555 RVA: 0x00206178 File Offset: 0x00204378
		public unsafe int BottomRightRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomRightRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_BottomRightRightID) = value;
			}
		}

		// Token: 0x17005846 RID: 22598
		// (get) Token: 0x060161BC RID: 90556 RVA: 0x00206189 File Offset: 0x00204389
		// (set) Token: 0x060161BD RID: 90557 RVA: 0x00206199 File Offset: 0x00204399
		public unsafe int TopLeftLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopLeftLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_TopLeftLeftID) = value;
			}
		}

		// Token: 0x17005847 RID: 22599
		// (get) Token: 0x060161BE RID: 90558 RVA: 0x002061AA File Offset: 0x002043AA
		// (set) Token: 0x060161BF RID: 90559 RVA: 0x002061BA File Offset: 0x002043BA
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x17005848 RID: 22600
		// (get) Token: 0x060161C0 RID: 90560 RVA: 0x002061CB File Offset: 0x002043CB
		// (set) Token: 0x060161C1 RID: 90561 RVA: 0x002061DF File Offset: 0x002043DF
		public unsafe FVector pos_beforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_pos_beforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_cloth.__PropertyOffset_pos_beforeStage) = value;
			}
		}

		// Token: 0x060161C2 RID: 90562 RVA: 0x002061F4 File Offset: 0x002043F4
		public FKuroCSParticle_cloth()
		{
		}

		// Token: 0x060161C3 RID: 90563 RVA: 0x002061FC File Offset: 0x002043FC
		public FKuroCSParticle_cloth(FVector pos, int LeftID, FVector posFoe, int RightID, FVector pos_bind, int TopID, FVector vol, int BottomID, int BottomLeftID, int BottomRightID, int TopLeftID, int TopRightID, int BottomRightRightID, int TopLeftLeftID, int isPinned, FVector pos_beforeStage)
		{
			this.pos = pos;
			this.LeftID = LeftID;
			this.posFoe = posFoe;
			this.RightID = RightID;
			this.pos_bind = pos_bind;
			this.TopID = TopID;
			this.vol = vol;
			this.BottomID = BottomID;
			this.BottomLeftID = BottomLeftID;
			this.BottomRightID = BottomRightID;
			this.TopLeftID = TopLeftID;
			this.TopRightID = TopRightID;
			this.BottomRightRightID = BottomRightRightID;
			this.TopLeftLeftID = TopLeftLeftID;
			this.isPinned = isPinned;
			this.pos_beforeStage = pos_beforeStage;
		}

		// Token: 0x060161C4 RID: 90564 RVA: 0x0020628C File Offset: 0x0020448C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_cloth.StaticStruct();
		}

		// Token: 0x060161C5 RID: 90565 RVA: 0x00206298 File Offset: 0x00204498
		[NullableContext(2)]
		public FKuroCSParticle_cloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060161C6 RID: 90566 RVA: 0x002062A2 File Offset: 0x002044A2
		public FKuroCSParticle_cloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060161C7 RID: 90567 RVA: 0x002062AD File Offset: 0x002044AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_cloth(Pointer, false, true);
		}

		// Token: 0x060161C8 RID: 90568 RVA: 0x002062B7 File Offset: 0x002044B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_cloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C08E RID: 49294
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_cloth";

		// Token: 0x0400C08F RID: 49295
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C090 RID: 49296
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C091 RID: 49297
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C092 RID: 49298
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C093 RID: 49299
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C094 RID: 49300
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C095 RID: 49301
		internal static int __PropertyOffset_TopID;

		// Token: 0x0400C096 RID: 49302
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C097 RID: 49303
		internal static int __PropertyOffset_BottomID;

		// Token: 0x0400C098 RID: 49304
		internal static int __PropertyOffset_BottomLeftID;

		// Token: 0x0400C099 RID: 49305
		internal static int __PropertyOffset_BottomRightID;

		// Token: 0x0400C09A RID: 49306
		internal static int __PropertyOffset_TopLeftID;

		// Token: 0x0400C09B RID: 49307
		internal static int __PropertyOffset_TopRightID;

		// Token: 0x0400C09C RID: 49308
		internal static int __PropertyOffset_BottomRightRightID;

		// Token: 0x0400C09D RID: 49309
		internal static int __PropertyOffset_TopLeftLeftID;

		// Token: 0x0400C09E RID: 49310
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C09F RID: 49311
		internal static int __PropertyOffset_pos_beforeStage;
	}
}
