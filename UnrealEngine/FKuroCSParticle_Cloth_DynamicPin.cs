using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B9 RID: 6073
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_Cloth_DynamicPin")]
	[UnrealStructLayout(112, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroCSParticle_Cloth_DynamicPin : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060161C9 RID: 90569 RVA: 0x002062C0 File Offset: 0x002044C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_Cloth_DynamicPin._ScriptStructPtr != 0) ? FKuroCSParticle_Cloth_DynamicPin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_Cloth_DynamicPin", ref FKuroCSParticle_Cloth_DynamicPin._ScriptStructPtr);
		}

		// Token: 0x17005849 RID: 22601
		// (get) Token: 0x060161CA RID: 90570 RVA: 0x002062E4 File Offset: 0x002044E4
		// (set) Token: 0x060161CB RID: 90571 RVA: 0x002062F8 File Offset: 0x002044F8
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x1700584A RID: 22602
		// (get) Token: 0x060161CC RID: 90572 RVA: 0x0020630D File Offset: 0x0020450D
		// (set) Token: 0x060161CD RID: 90573 RVA: 0x0020631D File Offset: 0x0020451D
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x1700584B RID: 22603
		// (get) Token: 0x060161CE RID: 90574 RVA: 0x0020632E File Offset: 0x0020452E
		// (set) Token: 0x060161CF RID: 90575 RVA: 0x00206342 File Offset: 0x00204542
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x1700584C RID: 22604
		// (get) Token: 0x060161D0 RID: 90576 RVA: 0x00206357 File Offset: 0x00204557
		// (set) Token: 0x060161D1 RID: 90577 RVA: 0x00206367 File Offset: 0x00204567
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x1700584D RID: 22605
		// (get) Token: 0x060161D2 RID: 90578 RVA: 0x00206378 File Offset: 0x00204578
		// (set) Token: 0x060161D3 RID: 90579 RVA: 0x0020638C File Offset: 0x0020458C
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x1700584E RID: 22606
		// (get) Token: 0x060161D4 RID: 90580 RVA: 0x002063A1 File Offset: 0x002045A1
		// (set) Token: 0x060161D5 RID: 90581 RVA: 0x002063B1 File Offset: 0x002045B1
		public unsafe int TopID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopID) = value;
			}
		}

		// Token: 0x1700584F RID: 22607
		// (get) Token: 0x060161D6 RID: 90582 RVA: 0x002063C2 File Offset: 0x002045C2
		// (set) Token: 0x060161D7 RID: 90583 RVA: 0x002063D6 File Offset: 0x002045D6
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005850 RID: 22608
		// (get) Token: 0x060161D8 RID: 90584 RVA: 0x002063EB File Offset: 0x002045EB
		// (set) Token: 0x060161D9 RID: 90585 RVA: 0x002063FB File Offset: 0x002045FB
		public unsafe int BottomID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomID) = value;
			}
		}

		// Token: 0x17005851 RID: 22609
		// (get) Token: 0x060161DA RID: 90586 RVA: 0x0020640C File Offset: 0x0020460C
		// (set) Token: 0x060161DB RID: 90587 RVA: 0x0020641C File Offset: 0x0020461C
		public unsafe int BottomLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomLeftID) = value;
			}
		}

		// Token: 0x17005852 RID: 22610
		// (get) Token: 0x060161DC RID: 90588 RVA: 0x0020642D File Offset: 0x0020462D
		// (set) Token: 0x060161DD RID: 90589 RVA: 0x0020643D File Offset: 0x0020463D
		public unsafe int BottomRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomRightID) = value;
			}
		}

		// Token: 0x17005853 RID: 22611
		// (get) Token: 0x060161DE RID: 90590 RVA: 0x0020644E File Offset: 0x0020464E
		// (set) Token: 0x060161DF RID: 90591 RVA: 0x0020645E File Offset: 0x0020465E
		public unsafe int TopLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopLeftID) = value;
			}
		}

		// Token: 0x17005854 RID: 22612
		// (get) Token: 0x060161E0 RID: 90592 RVA: 0x0020646F File Offset: 0x0020466F
		// (set) Token: 0x060161E1 RID: 90593 RVA: 0x0020647F File Offset: 0x0020467F
		public unsafe int TopRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopRightID) = value;
			}
		}

		// Token: 0x17005855 RID: 22613
		// (get) Token: 0x060161E2 RID: 90594 RVA: 0x00206490 File Offset: 0x00204690
		// (set) Token: 0x060161E3 RID: 90595 RVA: 0x002064A0 File Offset: 0x002046A0
		public unsafe int BottomRightRightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomRightRightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_BottomRightRightID) = value;
			}
		}

		// Token: 0x17005856 RID: 22614
		// (get) Token: 0x060161E4 RID: 90596 RVA: 0x002064B1 File Offset: 0x002046B1
		// (set) Token: 0x060161E5 RID: 90597 RVA: 0x002064C1 File Offset: 0x002046C1
		public unsafe int TopLeftLeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopLeftLeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_TopLeftLeftID) = value;
			}
		}

		// Token: 0x17005857 RID: 22615
		// (get) Token: 0x060161E6 RID: 90598 RVA: 0x002064D2 File Offset: 0x002046D2
		// (set) Token: 0x060161E7 RID: 90599 RVA: 0x002064E2 File Offset: 0x002046E2
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x17005858 RID: 22616
		// (get) Token: 0x060161E8 RID: 90600 RVA: 0x002064F3 File Offset: 0x002046F3
		// (set) Token: 0x060161E9 RID: 90601 RVA: 0x00206503 File Offset: 0x00204703
		public unsafe int indexX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_indexX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_indexX) = value;
			}
		}

		// Token: 0x17005859 RID: 22617
		// (get) Token: 0x060161EA RID: 90602 RVA: 0x00206514 File Offset: 0x00204714
		// (set) Token: 0x060161EB RID: 90603 RVA: 0x00206524 File Offset: 0x00204724
		public unsafe int indexY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_indexY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Cloth_DynamicPin.__PropertyOffset_indexY) = value;
			}
		}

		// Token: 0x060161EC RID: 90604 RVA: 0x00206535 File Offset: 0x00204735
		public FKuroCSParticle_Cloth_DynamicPin()
		{
		}

		// Token: 0x060161ED RID: 90605 RVA: 0x00206540 File Offset: 0x00204740
		public FKuroCSParticle_Cloth_DynamicPin(FVector pos, int LeftID, FVector posFoe, int RightID, FVector pos_bind, int TopID, FVector vol, int BottomID, int BottomLeftID, int BottomRightID, int TopLeftID, int TopRightID, int BottomRightRightID, int TopLeftLeftID, int isPinned, int indexX, int indexY)
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
			this.indexX = indexX;
			this.indexY = indexY;
		}

		// Token: 0x060161EE RID: 90606 RVA: 0x002065D8 File Offset: 0x002047D8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_Cloth_DynamicPin.StaticStruct();
		}

		// Token: 0x060161EF RID: 90607 RVA: 0x002065E4 File Offset: 0x002047E4
		[NullableContext(2)]
		public FKuroCSParticle_Cloth_DynamicPin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060161F0 RID: 90608 RVA: 0x002065EE File Offset: 0x002047EE
		public FKuroCSParticle_Cloth_DynamicPin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060161F1 RID: 90609 RVA: 0x002065F9 File Offset: 0x002047F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_Cloth_DynamicPin(Pointer, false, true);
		}

		// Token: 0x060161F2 RID: 90610 RVA: 0x00206603 File Offset: 0x00204803
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_Cloth_DynamicPin(Pointer, MemoryOwner);
		}

		// Token: 0x0400C0A0 RID: 49312
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_Cloth_DynamicPin";

		// Token: 0x0400C0A1 RID: 49313
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C0A2 RID: 49314
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C0A3 RID: 49315
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C0A4 RID: 49316
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C0A5 RID: 49317
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C0A6 RID: 49318
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C0A7 RID: 49319
		internal static int __PropertyOffset_TopID;

		// Token: 0x0400C0A8 RID: 49320
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C0A9 RID: 49321
		internal static int __PropertyOffset_BottomID;

		// Token: 0x0400C0AA RID: 49322
		internal static int __PropertyOffset_BottomLeftID;

		// Token: 0x0400C0AB RID: 49323
		internal static int __PropertyOffset_BottomRightID;

		// Token: 0x0400C0AC RID: 49324
		internal static int __PropertyOffset_TopLeftID;

		// Token: 0x0400C0AD RID: 49325
		internal static int __PropertyOffset_TopRightID;

		// Token: 0x0400C0AE RID: 49326
		internal static int __PropertyOffset_BottomRightRightID;

		// Token: 0x0400C0AF RID: 49327
		internal static int __PropertyOffset_TopLeftLeftID;

		// Token: 0x0400C0B0 RID: 49328
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C0B1 RID: 49329
		internal static int __PropertyOffset_indexX;

		// Token: 0x0400C0B2 RID: 49330
		internal static int __PropertyOffset_indexY;
	}
}
