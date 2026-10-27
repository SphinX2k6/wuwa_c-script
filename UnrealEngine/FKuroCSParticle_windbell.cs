using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017C4 RID: 6084
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_windbell")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCSParticle_windbell : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016427 RID: 91175 RVA: 0x00209378 File Offset: 0x00207578
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_windbell._ScriptStructPtr != 0) ? FKuroCSParticle_windbell._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_windbell", ref FKuroCSParticle_windbell._ScriptStructPtr);
		}

		// Token: 0x1700594C RID: 22860
		// (get) Token: 0x06016428 RID: 91176 RVA: 0x0020939C File Offset: 0x0020759C
		// (set) Token: 0x06016429 RID: 91177 RVA: 0x002093B0 File Offset: 0x002075B0
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x1700594D RID: 22861
		// (get) Token: 0x0601642A RID: 91178 RVA: 0x002093C5 File Offset: 0x002075C5
		// (set) Token: 0x0601642B RID: 91179 RVA: 0x002093D5 File Offset: 0x002075D5
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x1700594E RID: 22862
		// (get) Token: 0x0601642C RID: 91180 RVA: 0x002093E6 File Offset: 0x002075E6
		// (set) Token: 0x0601642D RID: 91181 RVA: 0x002093FA File Offset: 0x002075FA
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x1700594F RID: 22863
		// (get) Token: 0x0601642E RID: 91182 RVA: 0x0020940F File Offset: 0x0020760F
		// (set) Token: 0x0601642F RID: 91183 RVA: 0x0020941F File Offset: 0x0020761F
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x17005950 RID: 22864
		// (get) Token: 0x06016430 RID: 91184 RVA: 0x00209430 File Offset: 0x00207630
		// (set) Token: 0x06016431 RID: 91185 RVA: 0x00209444 File Offset: 0x00207644
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x17005951 RID: 22865
		// (get) Token: 0x06016432 RID: 91186 RVA: 0x00209459 File Offset: 0x00207659
		// (set) Token: 0x06016433 RID: 91187 RVA: 0x00209469 File Offset: 0x00207669
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x17005952 RID: 22866
		// (get) Token: 0x06016434 RID: 91188 RVA: 0x0020947A File Offset: 0x0020767A
		// (set) Token: 0x06016435 RID: 91189 RVA: 0x0020948E File Offset: 0x0020768E
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x17005953 RID: 22867
		// (get) Token: 0x06016436 RID: 91190 RVA: 0x002094A3 File Offset: 0x002076A3
		// (set) Token: 0x06016437 RID: 91191 RVA: 0x002094B3 File Offset: 0x002076B3
		public unsafe float padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell.__PropertyOffset_padding0) = value;
			}
		}

		// Token: 0x06016438 RID: 91192 RVA: 0x002094C4 File Offset: 0x002076C4
		public FKuroCSParticle_windbell()
		{
		}

		// Token: 0x06016439 RID: 91193 RVA: 0x002094CC File Offset: 0x002076CC
		public FKuroCSParticle_windbell(FVector pos, int LeftID, FVector posFoe, int RightID, FVector pos_bind, int isPinned, FVector vol, float padding0)
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

		// Token: 0x0601643A RID: 91194 RVA: 0x0020951C File Offset: 0x0020771C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_windbell.StaticStruct();
		}

		// Token: 0x0601643B RID: 91195 RVA: 0x00209528 File Offset: 0x00207728
		[NullableContext(2)]
		public FKuroCSParticle_windbell(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601643C RID: 91196 RVA: 0x00209532 File Offset: 0x00207732
		public FKuroCSParticle_windbell(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601643D RID: 91197 RVA: 0x0020953D File Offset: 0x0020773D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_windbell(Pointer, false, true);
		}

		// Token: 0x0601643E RID: 91198 RVA: 0x00209547 File Offset: 0x00207747
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_windbell(Pointer, MemoryOwner);
		}

		// Token: 0x0400C1B9 RID: 49593
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_windbell";

		// Token: 0x0400C1BA RID: 49594
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C1BB RID: 49595
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C1BC RID: 49596
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C1BD RID: 49597
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C1BE RID: 49598
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C1BF RID: 49599
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C1C0 RID: 49600
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C1C1 RID: 49601
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C1C2 RID: 49602
		internal static int __PropertyOffset_padding0;
	}
}
