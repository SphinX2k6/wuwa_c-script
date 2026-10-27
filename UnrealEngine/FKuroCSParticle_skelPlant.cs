using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017C2 RID: 6082
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_skelPlant")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FKuroCSParticle_skelPlant : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060163A9 RID: 91049 RVA: 0x00208938 File Offset: 0x00206B38
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_skelPlant._ScriptStructPtr != 0) ? FKuroCSParticle_skelPlant._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_skelPlant", ref FKuroCSParticle_skelPlant._ScriptStructPtr);
		}

		// Token: 0x17005915 RID: 22805
		// (get) Token: 0x060163AA RID: 91050 RVA: 0x0020895C File Offset: 0x00206B5C
		// (set) Token: 0x060163AB RID: 91051 RVA: 0x00208970 File Offset: 0x00206B70
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005916 RID: 22806
		// (get) Token: 0x060163AC RID: 91052 RVA: 0x00208985 File Offset: 0x00206B85
		// (set) Token: 0x060163AD RID: 91053 RVA: 0x00208995 File Offset: 0x00206B95
		public unsafe int PPID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_PPID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_PPID) = value;
			}
		}

		// Token: 0x17005917 RID: 22807
		// (get) Token: 0x060163AE RID: 91054 RVA: 0x002089A6 File Offset: 0x00206BA6
		// (set) Token: 0x060163AF RID: 91055 RVA: 0x002089BA File Offset: 0x00206BBA
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x17005918 RID: 22808
		// (get) Token: 0x060163B0 RID: 91056 RVA: 0x002089CF File Offset: 0x00206BCF
		// (set) Token: 0x060163B1 RID: 91057 RVA: 0x002089DF File Offset: 0x00206BDF
		public unsafe int childID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_childID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_childID) = value;
			}
		}

		// Token: 0x17005919 RID: 22809
		// (get) Token: 0x060163B2 RID: 91058 RVA: 0x002089F0 File Offset: 0x00206BF0
		// (set) Token: 0x060163B3 RID: 91059 RVA: 0x00208A04 File Offset: 0x00206C04
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x1700591A RID: 22810
		// (get) Token: 0x060163B4 RID: 91060 RVA: 0x00208A19 File Offset: 0x00206C19
		// (set) Token: 0x060163B5 RID: 91061 RVA: 0x00208A29 File Offset: 0x00206C29
		public unsafe int parentID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_parentID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_parentID) = value;
			}
		}

		// Token: 0x1700591B RID: 22811
		// (get) Token: 0x060163B6 RID: 91062 RVA: 0x00208A3A File Offset: 0x00206C3A
		// (set) Token: 0x060163B7 RID: 91063 RVA: 0x00208A4E File Offset: 0x00206C4E
		public unsafe FVector dir_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_dir_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_dir_bind) = value;
			}
		}

		// Token: 0x1700591C RID: 22812
		// (get) Token: 0x060163B8 RID: 91064 RVA: 0x00208A63 File Offset: 0x00206C63
		// (set) Token: 0x060163B9 RID: 91065 RVA: 0x00208A73 File Offset: 0x00206C73
		public unsafe float dis_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_dis_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_dis_bind) = value;
			}
		}

		// Token: 0x1700591D RID: 22813
		// (get) Token: 0x060163BA RID: 91066 RVA: 0x00208A84 File Offset: 0x00206C84
		// (set) Token: 0x060163BB RID: 91067 RVA: 0x00208A98 File Offset: 0x00206C98
		public unsafe FVector4 ori
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_ori);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_ori) = value;
			}
		}

		// Token: 0x1700591E RID: 22814
		// (get) Token: 0x060163BC RID: 91068 RVA: 0x00208AAD File Offset: 0x00206CAD
		// (set) Token: 0x060163BD RID: 91069 RVA: 0x00208AC1 File Offset: 0x00206CC1
		public unsafe FVector4 ori_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_ori_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_ori_bind) = value;
			}
		}

		// Token: 0x1700591F RID: 22815
		// (get) Token: 0x060163BE RID: 91070 RVA: 0x00208AD6 File Offset: 0x00206CD6
		// (set) Token: 0x060163BF RID: 91071 RVA: 0x00208AEA File Offset: 0x00206CEA
		public unsafe FVector PPdir_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_PPdir_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_PPdir_bind) = value;
			}
		}

		// Token: 0x17005920 RID: 22816
		// (get) Token: 0x060163C0 RID: 91072 RVA: 0x00208AFF File Offset: 0x00206CFF
		// (set) Token: 0x060163C1 RID: 91073 RVA: 0x00208B0F File Offset: 0x00206D0F
		public unsafe int isNoChild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_isNoChild);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_isNoChild) = value;
			}
		}

		// Token: 0x17005921 RID: 22817
		// (get) Token: 0x060163C2 RID: 91074 RVA: 0x00208B20 File Offset: 0x00206D20
		// (set) Token: 0x060163C3 RID: 91075 RVA: 0x00208B30 File Offset: 0x00206D30
		public unsafe int isNoParent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_isNoParent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_isNoParent) = value;
			}
		}

		// Token: 0x17005922 RID: 22818
		// (get) Token: 0x060163C4 RID: 91076 RVA: 0x00208B41 File Offset: 0x00206D41
		// (set) Token: 0x060163C5 RID: 91077 RVA: 0x00208B51 File Offset: 0x00206D51
		public unsafe int isNoPP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_isNoPP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_isNoPP) = value;
			}
		}

		// Token: 0x17005923 RID: 22819
		// (get) Token: 0x060163C6 RID: 91078 RVA: 0x00208B62 File Offset: 0x00206D62
		// (set) Token: 0x060163C7 RID: 91079 RVA: 0x00208B72 File Offset: 0x00206D72
		public unsafe float BoneMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_BoneMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_BoneMask) = value;
			}
		}

		// Token: 0x17005924 RID: 22820
		// (get) Token: 0x060163C8 RID: 91080 RVA: 0x00208B83 File Offset: 0x00206D83
		// (set) Token: 0x060163C9 RID: 91081 RVA: 0x00208B93 File Offset: 0x00206D93
		public unsafe float padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_skelPlant.__PropertyOffset_padding0) = value;
			}
		}

		// Token: 0x060163CA RID: 91082 RVA: 0x00208BA4 File Offset: 0x00206DA4
		public FKuroCSParticle_skelPlant()
		{
		}

		// Token: 0x060163CB RID: 91083 RVA: 0x00208BAC File Offset: 0x00206DAC
		public FKuroCSParticle_skelPlant(FVector pos, int PPID, FVector posFoe, int childID, FVector pos_bind, int parentID, FVector dir_bind, float dis_bind, FVector4 ori, FVector4 ori_bind, FVector PPdir_bind, int isNoChild, int isNoParent, int isNoPP, float BoneMask, float padding0)
		{
			this.pos = pos;
			this.PPID = PPID;
			this.posFoe = posFoe;
			this.childID = childID;
			this.pos_bind = pos_bind;
			this.parentID = parentID;
			this.dir_bind = dir_bind;
			this.dis_bind = dis_bind;
			this.ori = ori;
			this.ori_bind = ori_bind;
			this.PPdir_bind = PPdir_bind;
			this.isNoChild = isNoChild;
			this.isNoParent = isNoParent;
			this.isNoPP = isNoPP;
			this.BoneMask = BoneMask;
			this.padding0 = padding0;
		}

		// Token: 0x060163CC RID: 91084 RVA: 0x00208C3C File Offset: 0x00206E3C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_skelPlant.StaticStruct();
		}

		// Token: 0x060163CD RID: 91085 RVA: 0x00208C48 File Offset: 0x00206E48
		[NullableContext(2)]
		public FKuroCSParticle_skelPlant(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060163CE RID: 91086 RVA: 0x00208C52 File Offset: 0x00206E52
		public FKuroCSParticle_skelPlant(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060163CF RID: 91087 RVA: 0x00208C5D File Offset: 0x00206E5D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_skelPlant(Pointer, false, true);
		}

		// Token: 0x060163D0 RID: 91088 RVA: 0x00208C67 File Offset: 0x00206E67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_skelPlant(Pointer, MemoryOwner);
		}

		// Token: 0x0400C17E RID: 49534
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_skelPlant";

		// Token: 0x0400C17F RID: 49535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C180 RID: 49536
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C181 RID: 49537
		internal static int __PropertyOffset_PPID;

		// Token: 0x0400C182 RID: 49538
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C183 RID: 49539
		internal static int __PropertyOffset_childID;

		// Token: 0x0400C184 RID: 49540
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C185 RID: 49541
		internal static int __PropertyOffset_parentID;

		// Token: 0x0400C186 RID: 49542
		internal static int __PropertyOffset_dir_bind;

		// Token: 0x0400C187 RID: 49543
		internal static int __PropertyOffset_dis_bind;

		// Token: 0x0400C188 RID: 49544
		internal static int __PropertyOffset_ori;

		// Token: 0x0400C189 RID: 49545
		internal static int __PropertyOffset_ori_bind;

		// Token: 0x0400C18A RID: 49546
		internal static int __PropertyOffset_PPdir_bind;

		// Token: 0x0400C18B RID: 49547
		internal static int __PropertyOffset_isNoChild;

		// Token: 0x0400C18C RID: 49548
		internal static int __PropertyOffset_isNoParent;

		// Token: 0x0400C18D RID: 49549
		internal static int __PropertyOffset_isNoPP;

		// Token: 0x0400C18E RID: 49550
		internal static int __PropertyOffset_BoneMask;

		// Token: 0x0400C18F RID: 49551
		internal static int __PropertyOffset_padding0;
	}
}
