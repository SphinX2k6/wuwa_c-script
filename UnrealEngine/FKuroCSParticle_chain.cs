using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B6 RID: 6070
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_chain")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCSParticle_chain : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601616F RID: 90479 RVA: 0x00205BBC File Offset: 0x00203DBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_chain._ScriptStructPtr != 0) ? FKuroCSParticle_chain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_chain", ref FKuroCSParticle_chain._ScriptStructPtr);
		}

		// Token: 0x17005828 RID: 22568
		// (get) Token: 0x06016170 RID: 90480 RVA: 0x00205BE0 File Offset: 0x00203DE0
		// (set) Token: 0x06016171 RID: 90481 RVA: 0x00205BF4 File Offset: 0x00203DF4
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005829 RID: 22569
		// (get) Token: 0x06016172 RID: 90482 RVA: 0x00205C09 File Offset: 0x00203E09
		// (set) Token: 0x06016173 RID: 90483 RVA: 0x00205C19 File Offset: 0x00203E19
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x1700582A RID: 22570
		// (get) Token: 0x06016174 RID: 90484 RVA: 0x00205C2A File Offset: 0x00203E2A
		// (set) Token: 0x06016175 RID: 90485 RVA: 0x00205C3E File Offset: 0x00203E3E
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x1700582B RID: 22571
		// (get) Token: 0x06016176 RID: 90486 RVA: 0x00205C53 File Offset: 0x00203E53
		// (set) Token: 0x06016177 RID: 90487 RVA: 0x00205C63 File Offset: 0x00203E63
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x1700582C RID: 22572
		// (get) Token: 0x06016178 RID: 90488 RVA: 0x00205C74 File Offset: 0x00203E74
		// (set) Token: 0x06016179 RID: 90489 RVA: 0x00205C88 File Offset: 0x00203E88
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x1700582D RID: 22573
		// (get) Token: 0x0601617A RID: 90490 RVA: 0x00205C9D File Offset: 0x00203E9D
		// (set) Token: 0x0601617B RID: 90491 RVA: 0x00205CAD File Offset: 0x00203EAD
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x1700582E RID: 22574
		// (get) Token: 0x0601617C RID: 90492 RVA: 0x00205CBE File Offset: 0x00203EBE
		// (set) Token: 0x0601617D RID: 90493 RVA: 0x00205CD2 File Offset: 0x00203ED2
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x1700582F RID: 22575
		// (get) Token: 0x0601617E RID: 90494 RVA: 0x00205CE7 File Offset: 0x00203EE7
		// (set) Token: 0x0601617F RID: 90495 RVA: 0x00205CF7 File Offset: 0x00203EF7
		public unsafe float padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain.__PropertyOffset_padding0) = value;
			}
		}

		// Token: 0x06016180 RID: 90496 RVA: 0x00205D08 File Offset: 0x00203F08
		public FKuroCSParticle_chain()
		{
		}

		// Token: 0x06016181 RID: 90497 RVA: 0x00205D10 File Offset: 0x00203F10
		public FKuroCSParticle_chain(FVector pos, int LeftID, FVector posFoe, int RightID, FVector pos_bind, int isPinned, FVector vol, float padding0)
		{
			this.pos = pos;
			this.LeftID = LeftID;
			this.posFoe = posFoe;
			this.RightID = RightID;
			this.pos_bind = pos_bind;
			this.isPinned = isPinned;
			this.vol = vol;
			this.padding0 = padding0;
		}

		// Token: 0x06016182 RID: 90498 RVA: 0x00205D60 File Offset: 0x00203F60
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_chain.StaticStruct();
		}

		// Token: 0x06016183 RID: 90499 RVA: 0x00205D6C File Offset: 0x00203F6C
		[NullableContext(2)]
		public FKuroCSParticle_chain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016184 RID: 90500 RVA: 0x00205D76 File Offset: 0x00203F76
		public FKuroCSParticle_chain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016185 RID: 90501 RVA: 0x00205D81 File Offset: 0x00203F81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_chain(Pointer, false, true);
		}

		// Token: 0x06016186 RID: 90502 RVA: 0x00205D8B File Offset: 0x00203F8B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_chain(Pointer, MemoryOwner);
		}

		// Token: 0x0400C079 RID: 49273
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_chain";

		// Token: 0x0400C07A RID: 49274
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C07B RID: 49275
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C07C RID: 49276
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C07D RID: 49277
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C07E RID: 49278
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C07F RID: 49279
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C080 RID: 49280
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C081 RID: 49281
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C082 RID: 49282
		internal static int __PropertyOffset_padding0;
	}
}
