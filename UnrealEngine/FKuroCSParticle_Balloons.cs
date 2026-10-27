using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B5 RID: 6069
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_Balloons")]
	[UnrealStructLayout(112, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroCSParticle_Balloons : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016141 RID: 90433 RVA: 0x0020581F File Offset: 0x00203A1F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_Balloons._ScriptStructPtr != 0) ? FKuroCSParticle_Balloons._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_Balloons", ref FKuroCSParticle_Balloons._ScriptStructPtr);
		}

		// Token: 0x17005815 RID: 22549
		// (get) Token: 0x06016142 RID: 90434 RVA: 0x00205843 File Offset: 0x00203A43
		// (set) Token: 0x06016143 RID: 90435 RVA: 0x00205857 File Offset: 0x00203A57
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005816 RID: 22550
		// (get) Token: 0x06016144 RID: 90436 RVA: 0x0020586C File Offset: 0x00203A6C
		// (set) Token: 0x06016145 RID: 90437 RVA: 0x0020587C File Offset: 0x00203A7C
		public unsafe int index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_index) = value;
			}
		}

		// Token: 0x17005817 RID: 22551
		// (get) Token: 0x06016146 RID: 90438 RVA: 0x0020588D File Offset: 0x00203A8D
		// (set) Token: 0x06016147 RID: 90439 RVA: 0x002058A1 File Offset: 0x00203AA1
		public unsafe FVector vel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_vel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_vel) = value;
			}
		}

		// Token: 0x17005818 RID: 22552
		// (get) Token: 0x06016148 RID: 90440 RVA: 0x002058B6 File Offset: 0x00203AB6
		// (set) Token: 0x06016149 RID: 90441 RVA: 0x002058C6 File Offset: 0x00203AC6
		public unsafe int up
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_up);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_up) = value;
			}
		}

		// Token: 0x17005819 RID: 22553
		// (get) Token: 0x0601614A RID: 90442 RVA: 0x002058D7 File Offset: 0x00203AD7
		// (set) Token: 0x0601614B RID: 90443 RVA: 0x002058EB File Offset: 0x00203AEB
		public unsafe FVector pos_old
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_pos_old);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_pos_old) = value;
			}
		}

		// Token: 0x1700581A RID: 22554
		// (get) Token: 0x0601614C RID: 90444 RVA: 0x00205900 File Offset: 0x00203B00
		// (set) Token: 0x0601614D RID: 90445 RVA: 0x00205910 File Offset: 0x00203B10
		public unsafe int down
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_down);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_down) = value;
			}
		}

		// Token: 0x1700581B RID: 22555
		// (get) Token: 0x0601614E RID: 90446 RVA: 0x00205921 File Offset: 0x00203B21
		// (set) Token: 0x0601614F RID: 90447 RVA: 0x00205935 File Offset: 0x00203B35
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x1700581C RID: 22556
		// (get) Token: 0x06016150 RID: 90448 RVA: 0x0020594A File Offset: 0x00203B4A
		// (set) Token: 0x06016151 RID: 90449 RVA: 0x0020595A File Offset: 0x00203B5A
		public unsafe float upDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_upDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_upDis) = value;
			}
		}

		// Token: 0x1700581D RID: 22557
		// (get) Token: 0x06016152 RID: 90450 RVA: 0x0020596B File Offset: 0x00203B6B
		// (set) Token: 0x06016153 RID: 90451 RVA: 0x0020597B File Offset: 0x00203B7B
		public unsafe float downDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_downDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_downDis) = value;
			}
		}

		// Token: 0x1700581E RID: 22558
		// (get) Token: 0x06016154 RID: 90452 RVA: 0x0020598C File Offset: 0x00203B8C
		// (set) Token: 0x06016155 RID: 90453 RVA: 0x0020599C File Offset: 0x00203B9C
		public unsafe int ID_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_ID_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_ID_X) = value;
			}
		}

		// Token: 0x1700581F RID: 22559
		// (get) Token: 0x06016156 RID: 90454 RVA: 0x002059AD File Offset: 0x00203BAD
		// (set) Token: 0x06016157 RID: 90455 RVA: 0x002059BD File Offset: 0x00203BBD
		public unsafe int ID_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_ID_Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_ID_Y) = value;
			}
		}

		// Token: 0x17005820 RID: 22560
		// (get) Token: 0x06016158 RID: 90456 RVA: 0x002059CE File Offset: 0x00203BCE
		// (set) Token: 0x06016159 RID: 90457 RVA: 0x002059DE File Offset: 0x00203BDE
		public unsafe int isStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isStart) = value;
			}
		}

		// Token: 0x17005821 RID: 22561
		// (get) Token: 0x0601615A RID: 90458 RVA: 0x002059EF File Offset: 0x00203BEF
		// (set) Token: 0x0601615B RID: 90459 RVA: 0x002059FF File Offset: 0x00203BFF
		public unsafe int isEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isEnd) = value;
			}
		}

		// Token: 0x17005822 RID: 22562
		// (get) Token: 0x0601615C RID: 90460 RVA: 0x00205A10 File Offset: 0x00203C10
		// (set) Token: 0x0601615D RID: 90461 RVA: 0x00205A20 File Offset: 0x00203C20
		public unsafe int isPivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isPivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isPivot) = value;
			}
		}

		// Token: 0x17005823 RID: 22563
		// (get) Token: 0x0601615E RID: 90462 RVA: 0x00205A31 File Offset: 0x00203C31
		// (set) Token: 0x0601615F RID: 90463 RVA: 0x00205A41 File Offset: 0x00203C41
		public unsafe int upBreak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_upBreak);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_upBreak) = value;
			}
		}

		// Token: 0x17005824 RID: 22564
		// (get) Token: 0x06016160 RID: 90464 RVA: 0x00205A52 File Offset: 0x00203C52
		// (set) Token: 0x06016161 RID: 90465 RVA: 0x00205A62 File Offset: 0x00203C62
		public unsafe int downBreak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_downBreak);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_downBreak) = value;
			}
		}

		// Token: 0x17005825 RID: 22565
		// (get) Token: 0x06016162 RID: 90466 RVA: 0x00205A73 File Offset: 0x00203C73
		// (set) Token: 0x06016163 RID: 90467 RVA: 0x00205A83 File Offset: 0x00203C83
		public unsafe int isDestroyed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isDestroyed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isDestroyed) = value;
			}
		}

		// Token: 0x17005826 RID: 22566
		// (get) Token: 0x06016164 RID: 90468 RVA: 0x00205A94 File Offset: 0x00203C94
		// (set) Token: 0x06016165 RID: 90469 RVA: 0x00205AA4 File Offset: 0x00203CA4
		public unsafe float dissolveProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_dissolveProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_dissolveProgress) = value;
			}
		}

		// Token: 0x17005827 RID: 22567
		// (get) Token: 0x06016166 RID: 90470 RVA: 0x00205AB5 File Offset: 0x00203CB5
		// (set) Token: 0x06016167 RID: 90471 RVA: 0x00205AC5 File Offset: 0x00203CC5
		public unsafe int isDestroyedstateLastFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isDestroyedstateLastFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_Balloons.__PropertyOffset_isDestroyedstateLastFrame) = value;
			}
		}

		// Token: 0x06016168 RID: 90472 RVA: 0x00205AD6 File Offset: 0x00203CD6
		public FKuroCSParticle_Balloons()
		{
		}

		// Token: 0x06016169 RID: 90473 RVA: 0x00205AE0 File Offset: 0x00203CE0
		public FKuroCSParticle_Balloons(FVector pos, int index, FVector vel, int up, FVector pos_old, int down, FVector pos_bind, float upDis, float downDis, int ID_X, int ID_Y, int isStart, int isEnd, int isPivot, int upBreak, int downBreak, int isDestroyed, float dissolveProgress, int isDestroyedstateLastFrame)
		{
			this.pos = pos;
			this.index = index;
			this.vel = vel;
			this.up = up;
			this.pos_old = pos_old;
			this.down = down;
			this.pos_bind = pos_bind;
			this.upDis = upDis;
			this.downDis = downDis;
			this.ID_X = ID_X;
			this.ID_Y = ID_Y;
			this.isStart = isStart;
			this.isEnd = isEnd;
			this.isPivot = isPivot;
			this.upBreak = upBreak;
			this.downBreak = downBreak;
			this.isDestroyed = isDestroyed;
			this.dissolveProgress = dissolveProgress;
			this.isDestroyedstateLastFrame = isDestroyedstateLastFrame;
		}

		// Token: 0x0601616A RID: 90474 RVA: 0x00205B88 File Offset: 0x00203D88
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_Balloons.StaticStruct();
		}

		// Token: 0x0601616B RID: 90475 RVA: 0x00205B94 File Offset: 0x00203D94
		[NullableContext(2)]
		public FKuroCSParticle_Balloons(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601616C RID: 90476 RVA: 0x00205B9E File Offset: 0x00203D9E
		public FKuroCSParticle_Balloons(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601616D RID: 90477 RVA: 0x00205BA9 File Offset: 0x00203DA9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_Balloons(Pointer, false, true);
		}

		// Token: 0x0601616E RID: 90478 RVA: 0x00205BB3 File Offset: 0x00203DB3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_Balloons(Pointer, MemoryOwner);
		}

		// Token: 0x0400C064 RID: 49252
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_Balloons";

		// Token: 0x0400C065 RID: 49253
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C066 RID: 49254
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C067 RID: 49255
		internal static int __PropertyOffset_index;

		// Token: 0x0400C068 RID: 49256
		internal static int __PropertyOffset_vel;

		// Token: 0x0400C069 RID: 49257
		internal static int __PropertyOffset_up;

		// Token: 0x0400C06A RID: 49258
		internal static int __PropertyOffset_pos_old;

		// Token: 0x0400C06B RID: 49259
		internal static int __PropertyOffset_down;

		// Token: 0x0400C06C RID: 49260
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C06D RID: 49261
		internal static int __PropertyOffset_upDis;

		// Token: 0x0400C06E RID: 49262
		internal static int __PropertyOffset_downDis;

		// Token: 0x0400C06F RID: 49263
		internal static int __PropertyOffset_ID_X;

		// Token: 0x0400C070 RID: 49264
		internal static int __PropertyOffset_ID_Y;

		// Token: 0x0400C071 RID: 49265
		internal static int __PropertyOffset_isStart;

		// Token: 0x0400C072 RID: 49266
		internal static int __PropertyOffset_isEnd;

		// Token: 0x0400C073 RID: 49267
		internal static int __PropertyOffset_isPivot;

		// Token: 0x0400C074 RID: 49268
		internal static int __PropertyOffset_upBreak;

		// Token: 0x0400C075 RID: 49269
		internal static int __PropertyOffset_downBreak;

		// Token: 0x0400C076 RID: 49270
		internal static int __PropertyOffset_isDestroyed;

		// Token: 0x0400C077 RID: 49271
		internal static int __PropertyOffset_dissolveProgress;

		// Token: 0x0400C078 RID: 49272
		internal static int __PropertyOffset_isDestroyedstateLastFrame;
	}
}
