using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017C5 RID: 6085
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSParticle_windbell_set")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCSParticle_windbell_set : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601643F RID: 91199 RVA: 0x00209550 File Offset: 0x00207750
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSParticle_windbell_set._ScriptStructPtr != 0) ? FKuroCSParticle_windbell_set._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSParticle_windbell_set", ref FKuroCSParticle_windbell_set._ScriptStructPtr);
		}

		// Token: 0x17005954 RID: 22868
		// (get) Token: 0x06016440 RID: 91200 RVA: 0x00209574 File Offset: 0x00207774
		// (set) Token: 0x06016441 RID: 91201 RVA: 0x00209588 File Offset: 0x00207788
		public unsafe FVector pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_pos) = value;
			}
		}

		// Token: 0x17005955 RID: 22869
		// (get) Token: 0x06016442 RID: 91202 RVA: 0x0020959D File Offset: 0x0020779D
		// (set) Token: 0x06016443 RID: 91203 RVA: 0x002095AD File Offset: 0x002077AD
		public unsafe int LeftID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_LeftID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_LeftID) = value;
			}
		}

		// Token: 0x17005956 RID: 22870
		// (get) Token: 0x06016444 RID: 91204 RVA: 0x002095BE File Offset: 0x002077BE
		// (set) Token: 0x06016445 RID: 91205 RVA: 0x002095D2 File Offset: 0x002077D2
		public unsafe FVector posFoe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_posFoe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_posFoe) = value;
			}
		}

		// Token: 0x17005957 RID: 22871
		// (get) Token: 0x06016446 RID: 91206 RVA: 0x002095E7 File Offset: 0x002077E7
		// (set) Token: 0x06016447 RID: 91207 RVA: 0x002095F7 File Offset: 0x002077F7
		public unsafe int RightID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_RightID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_RightID) = value;
			}
		}

		// Token: 0x17005958 RID: 22872
		// (get) Token: 0x06016448 RID: 91208 RVA: 0x00209608 File Offset: 0x00207808
		// (set) Token: 0x06016449 RID: 91209 RVA: 0x0020961C File Offset: 0x0020781C
		public unsafe FVector pos_bind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_pos_bind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_pos_bind) = value;
			}
		}

		// Token: 0x17005959 RID: 22873
		// (get) Token: 0x0601644A RID: 91210 RVA: 0x00209631 File Offset: 0x00207831
		// (set) Token: 0x0601644B RID: 91211 RVA: 0x00209641 File Offset: 0x00207841
		public unsafe int isPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_isPinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_isPinned) = value;
			}
		}

		// Token: 0x1700595A RID: 22874
		// (get) Token: 0x0601644C RID: 91212 RVA: 0x00209652 File Offset: 0x00207852
		// (set) Token: 0x0601644D RID: 91213 RVA: 0x00209666 File Offset: 0x00207866
		public unsafe FVector vol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_vol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_vol) = value;
			}
		}

		// Token: 0x1700595B RID: 22875
		// (get) Token: 0x0601644E RID: 91214 RVA: 0x0020967B File Offset: 0x0020787B
		// (set) Token: 0x0601644F RID: 91215 RVA: 0x0020968B File Offset: 0x0020788B
		public unsafe float padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSParticle_windbell_set.__PropertyOffset_padding0) = value;
			}
		}

		// Token: 0x06016450 RID: 91216 RVA: 0x0020969C File Offset: 0x0020789C
		public FKuroCSParticle_windbell_set()
		{
		}

		// Token: 0x06016451 RID: 91217 RVA: 0x002096A4 File Offset: 0x002078A4
		public FKuroCSParticle_windbell_set(FVector pos, int LeftID, FVector posFoe, int RightID, FVector pos_bind, int isPinned, FVector vol, float padding0)
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

		// Token: 0x06016452 RID: 91218 RVA: 0x002096F4 File Offset: 0x002078F4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSParticle_windbell_set.StaticStruct();
		}

		// Token: 0x06016453 RID: 91219 RVA: 0x00209700 File Offset: 0x00207900
		[NullableContext(2)]
		public FKuroCSParticle_windbell_set(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016454 RID: 91220 RVA: 0x0020970A File Offset: 0x0020790A
		public FKuroCSParticle_windbell_set(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016455 RID: 91221 RVA: 0x00209715 File Offset: 0x00207915
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSParticle_windbell_set(Pointer, false, true);
		}

		// Token: 0x06016456 RID: 91222 RVA: 0x0020971F File Offset: 0x0020791F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSParticle_windbell_set(Pointer, MemoryOwner);
		}

		// Token: 0x0400C1C3 RID: 49603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSParticle_windbell_set";

		// Token: 0x0400C1C4 RID: 49604
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C1C5 RID: 49605
		internal static int __PropertyOffset_pos;

		// Token: 0x0400C1C6 RID: 49606
		internal static int __PropertyOffset_LeftID;

		// Token: 0x0400C1C7 RID: 49607
		internal static int __PropertyOffset_posFoe;

		// Token: 0x0400C1C8 RID: 49608
		internal static int __PropertyOffset_RightID;

		// Token: 0x0400C1C9 RID: 49609
		internal static int __PropertyOffset_pos_bind;

		// Token: 0x0400C1CA RID: 49610
		internal static int __PropertyOffset_isPinned;

		// Token: 0x0400C1CB RID: 49611
		internal static int __PropertyOffset_vol;

		// Token: 0x0400C1CC RID: 49612
		internal static int __PropertyOffset_padding0;
	}
}
