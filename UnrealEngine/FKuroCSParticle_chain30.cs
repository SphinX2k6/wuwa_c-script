using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B7 RID: 6071
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_chain30")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroCSParticle_chain30 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016187 RID: 90503 RVA: 0x00205D94 File Offset: 0x00203F94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_chain30._ScriptStructPtr != 0) ? FKuroCSParticle_chain30._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_chain30", ref FKuroCSParticle_chain30._ScriptStructPtr);
		}

		// Token: 0x17005830 RID: 22576
		// (get) Token: 0x06016188 RID: 90504 RVA: 0x00205DB8 File Offset: 0x00203FB8
		// (set) Token: 0x06016189 RID: 90505 RVA: 0x00205DCC File Offset: 0x00203FCC
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005831 RID: 22577
		// (get) Token: 0x0601618A RID: 90506 RVA: 0x00205DE1 File Offset: 0x00203FE1
		// (set) Token: 0x0601618B RID: 90507 RVA: 0x00205DF1 File Offset: 0x00203FF1
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x17005832 RID: 22578
		// (get) Token: 0x0601618C RID: 90508 RVA: 0x00205E02 File Offset: 0x00204002
		// (set) Token: 0x0601618D RID: 90509 RVA: 0x00205E16 File Offset: 0x00204016
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x17005833 RID: 22579
		// (get) Token: 0x0601618E RID: 90510 RVA: 0x00205E2B File Offset: 0x0020402B
		// (set) Token: 0x0601618F RID: 90511 RVA: 0x00205E3B File Offset: 0x0020403B
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x17005834 RID: 22580
		// (get) Token: 0x06016190 RID: 90512 RVA: 0x00205E4C File Offset: 0x0020404C
		// (set) Token: 0x06016191 RID: 90513 RVA: 0x00205E60 File Offset: 0x00204060
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x17005835 RID: 22581
		// (get) Token: 0x06016192 RID: 90514 RVA: 0x00205E75 File Offset: 0x00204075
		// (set) Token: 0x06016193 RID: 90515 RVA: 0x00205E85 File Offset: 0x00204085
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x17005836 RID: 22582
		// (get) Token: 0x06016194 RID: 90516 RVA: 0x00205E96 File Offset: 0x00204096
		// (set) Token: 0x06016195 RID: 90517 RVA: 0x00205EAA File Offset: 0x002040AA
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005837 RID: 22583
		// (get) Token: 0x06016196 RID: 90518 RVA: 0x00205EBF File Offset: 0x002040BF
		// (set) Token: 0x06016197 RID: 90519 RVA: 0x00205ECF File Offset: 0x002040CF
		public unsafe float leftDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_leftDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_leftDis) = value;
			}
		}

		// Token: 0x17005838 RID: 22584
		// (get) Token: 0x06016198 RID: 90520 RVA: 0x00205EE0 File Offset: 0x002040E0
		// (set) Token: 0x06016199 RID: 90521 RVA: 0x00205EF0 File Offset: 0x002040F0
		public unsafe float rightDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_rightDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_chain30.__PropertyOffset_rightDis) = value;
			}
		}

		// Token: 0x0601619A RID: 90522 RVA: 0x00205F01 File Offset: 0x00204101
		public FKuroCSParticle_chain30()
		{
		}

		// Token: 0x0601619B RID: 90523 RVA: 0x00205F0C File Offset: 0x0020410C
		public FKuroCSParticle_chain30(FVector pos, int LeftID, FVector posFoe, int RightID, FVector pos_bind, int isPinned, FVector vol, float leftDis, float rightDis)
		{
			this.pos = pos;
			this.LeftID = LeftID;
			this.posFoe = posFoe;
			this.RightID = RightID;
			this.pos_bind = pos_bind;
			this.isPinned = isPinned;
			this.vol = vol;
			this.leftDis = leftDis;
			this.rightDis = rightDis;
		}

		// Token: 0x0601619C RID: 90524 RVA: 0x00205F64 File Offset: 0x00204164
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_chain30.StaticStruct();
		}

		// Token: 0x0601619D RID: 90525 RVA: 0x00205F70 File Offset: 0x00204170
		[NullableContext(2)]
		public FKuroCSParticle_chain30(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601619E RID: 90526 RVA: 0x00205F7A File Offset: 0x0020417A
		public FKuroCSParticle_chain30(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601619F RID: 90527 RVA: 0x00205F85 File Offset: 0x00204185
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_chain30(Pointer, false, true);
		}

		// Token: 0x060161A0 RID: 90528 RVA: 0x00205F8F File Offset: 0x0020418F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_chain30(Pointer, MemoryOwner);
		}

		// Token: 0x0400C083 RID: 49283
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_chain30";

		// Token: 0x0400C084 RID: 49284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C085 RID: 49285
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C086 RID: 49286
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C087 RID: 49287
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C088 RID: 49288
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C089 RID: 49289
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C08A RID: 49290
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C08B RID: 49291
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C08C RID: 49292
		internal static int __PropertyOffset_leftDis;

		// Token: 0x0400C08D RID: 49293
		internal static int __PropertyOffset_rightDis;
	}
}
