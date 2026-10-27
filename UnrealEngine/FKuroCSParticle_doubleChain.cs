using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017BB RID: 6075
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_doubleChain")]
	[UnrealStructLayout(112, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroCSParticle_doubleChain : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016227 RID: 90663 RVA: 0x00206A2C File Offset: 0x00204C2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_doubleChain._ScriptStructPtr != 0) ? FKuroCSParticle_doubleChain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_doubleChain", ref FKuroCSParticle_doubleChain._ScriptStructPtr);
		}

		// Token: 0x17005870 RID: 22640
		// (get) Token: 0x06016228 RID: 90664 RVA: 0x00206A50 File Offset: 0x00204C50
		// (set) Token: 0x06016229 RID: 90665 RVA: 0x00206A64 File Offset: 0x00204C64
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005871 RID: 22641
		// (get) Token: 0x0601622A RID: 90666 RVA: 0x00206A79 File Offset: 0x00204C79
		// (set) Token: 0x0601622B RID: 90667 RVA: 0x00206A89 File Offset: 0x00204C89
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x17005872 RID: 22642
		// (get) Token: 0x0601622C RID: 90668 RVA: 0x00206A9A File Offset: 0x00204C9A
		// (set) Token: 0x0601622D RID: 90669 RVA: 0x00206AAE File Offset: 0x00204CAE
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x17005873 RID: 22643
		// (get) Token: 0x0601622E RID: 90670 RVA: 0x00206AC3 File Offset: 0x00204CC3
		// (set) Token: 0x0601622F RID: 90671 RVA: 0x00206AD3 File Offset: 0x00204CD3
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x17005874 RID: 22644
		// (get) Token: 0x06016230 RID: 90672 RVA: 0x00206AE4 File Offset: 0x00204CE4
		// (set) Token: 0x06016231 RID: 90673 RVA: 0x00206AF8 File Offset: 0x00204CF8
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x17005875 RID: 22645
		// (get) Token: 0x06016232 RID: 90674 RVA: 0x00206B0D File Offset: 0x00204D0D
		// (set) Token: 0x06016233 RID: 90675 RVA: 0x00206B1D File Offset: 0x00204D1D
		public unsafe int TopID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopID) = value;
			}
		}

		// Token: 0x17005876 RID: 22646
		// (get) Token: 0x06016234 RID: 90676 RVA: 0x00206B2E File Offset: 0x00204D2E
		// (set) Token: 0x06016235 RID: 90677 RVA: 0x00206B42 File Offset: 0x00204D42
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005877 RID: 22647
		// (get) Token: 0x06016236 RID: 90678 RVA: 0x00206B57 File Offset: 0x00204D57
		// (set) Token: 0x06016237 RID: 90679 RVA: 0x00206B67 File Offset: 0x00204D67
		public unsafe int BottomID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomID) = value;
			}
		}

		// Token: 0x17005878 RID: 22648
		// (get) Token: 0x06016238 RID: 90680 RVA: 0x00206B78 File Offset: 0x00204D78
		// (set) Token: 0x06016239 RID: 90681 RVA: 0x00206B88 File Offset: 0x00204D88
		public unsafe int BottomLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomLeftID) = value;
			}
		}

		// Token: 0x17005879 RID: 22649
		// (get) Token: 0x0601623A RID: 90682 RVA: 0x00206B99 File Offset: 0x00204D99
		// (set) Token: 0x0601623B RID: 90683 RVA: 0x00206BA9 File Offset: 0x00204DA9
		public unsafe int BottomRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomRightID) = value;
			}
		}

		// Token: 0x1700587A RID: 22650
		// (get) Token: 0x0601623C RID: 90684 RVA: 0x00206BBA File Offset: 0x00204DBA
		// (set) Token: 0x0601623D RID: 90685 RVA: 0x00206BCA File Offset: 0x00204DCA
		public unsafe int TopLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopLeftID) = value;
			}
		}

		// Token: 0x1700587B RID: 22651
		// (get) Token: 0x0601623E RID: 90686 RVA: 0x00206BDB File Offset: 0x00204DDB
		// (set) Token: 0x0601623F RID: 90687 RVA: 0x00206BEB File Offset: 0x00204DEB
		public unsafe int TopRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopRightID) = value;
			}
		}

		// Token: 0x1700587C RID: 22652
		// (get) Token: 0x06016240 RID: 90688 RVA: 0x00206BFC File Offset: 0x00204DFC
		// (set) Token: 0x06016241 RID: 90689 RVA: 0x00206C0C File Offset: 0x00204E0C
		public unsafe int BottomRightRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomRightRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_BottomRightRightID) = value;
			}
		}

		// Token: 0x1700587D RID: 22653
		// (get) Token: 0x06016242 RID: 90690 RVA: 0x00206C1D File Offset: 0x00204E1D
		// (set) Token: 0x06016243 RID: 90691 RVA: 0x00206C2D File Offset: 0x00204E2D
		public unsafe int TopLeftLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopLeftLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_TopLeftLeftID) = value;
			}
		}

		// Token: 0x1700587E RID: 22654
		// (get) Token: 0x06016244 RID: 90692 RVA: 0x00206C3E File Offset: 0x00204E3E
		// (set) Token: 0x06016245 RID: 90693 RVA: 0x00206C4E File Offset: 0x00204E4E
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x1700587F RID: 22655
		// (get) Token: 0x06016246 RID: 90694 RVA: 0x00206C5F File Offset: 0x00204E5F
		// (set) Token: 0x06016247 RID: 90695 RVA: 0x00206C73 File Offset: 0x00204E73
		public unsafe FVector pos_beforeStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_pos_beforeStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_doubleChain.__PropertyOffset_pos_beforeStage) = value;
			}
		}

		// Token: 0x06016248 RID: 90696 RVA: 0x00206C88 File Offset: 0x00204E88
		public FKuroCSParticle_doubleChain()
		{
		}

		// Token: 0x06016249 RID: 90697 RVA: 0x00206C90 File Offset: 0x00204E90
		public FKuroCSParticle_doubleChain(FVector pos, int LeftID, FVector posFoe, int RightID, FVector pos_bind, int TopID, FVector vol, int BottomID, int BottomLeftID, int BottomRightID, int TopLeftID, int TopRightID, int BottomRightRightID, int TopLeftLeftID, int isPinned, FVector pos_beforeStage)
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

		// Token: 0x0601624A RID: 90698 RVA: 0x00206D20 File Offset: 0x00204F20
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_doubleChain.StaticStruct();
		}

		// Token: 0x0601624B RID: 90699 RVA: 0x00206D2C File Offset: 0x00204F2C
		[NullableContext(2)]
		public FKuroCSParticle_doubleChain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601624C RID: 90700 RVA: 0x00206D36 File Offset: 0x00204F36
		public FKuroCSParticle_doubleChain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601624D RID: 90701 RVA: 0x00206D41 File Offset: 0x00204F41
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_doubleChain(Pointer, false, true);
		}

		// Token: 0x0601624E RID: 90702 RVA: 0x00206D4B File Offset: 0x00204F4B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_doubleChain(Pointer, MemoryOwner);
		}

		// Token: 0x0400C0CB RID: 49355
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_doubleChain";

		// Token: 0x0400C0CC RID: 49356
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C0CD RID: 49357
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C0CE RID: 49358
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C0CF RID: 49359
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C0D0 RID: 49360
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C0D1 RID: 49361
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C0D2 RID: 49362
		internal static int __PropertyOffset_TopID;

		// Token: 0x0400C0D3 RID: 49363
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C0D4 RID: 49364
		internal static int __PropertyOffset_BottomID;

		// Token: 0x0400C0D5 RID: 49365
		internal static int __PropertyOffset_BottomLeftID;

		// Token: 0x0400C0D6 RID: 49366
		internal static int __PropertyOffset_BottomRightID;

		// Token: 0x0400C0D7 RID: 49367
		internal static int __PropertyOffset_TopLeftID;

		// Token: 0x0400C0D8 RID: 49368
		internal static int __PropertyOffset_TopRightID;

		// Token: 0x0400C0D9 RID: 49369
		internal static int __PropertyOffset_BottomRightRightID;

		// Token: 0x0400C0DA RID: 49370
		internal static int __PropertyOffset_TopLeftLeftID;

		// Token: 0x0400C0DB RID: 49371
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C0DC RID: 49372
		internal static int __PropertyOffset_pos_beforeStage;
	}
}
