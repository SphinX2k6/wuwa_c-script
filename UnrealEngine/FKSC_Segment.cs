using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E2B RID: 7723
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Segment")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKSC_Segment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D6FF RID: 120575 RVA: 0x002B7B5A File Offset: 0x002B5D5A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Segment._ScriptStructPtr != 0) ? FKSC_Segment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Segment", ref FKSC_Segment._ScriptStructPtr);
		}

		// Token: 0x170076AC RID: 30380
		// (get) Token: 0x0601D700 RID: 120576 RVA: 0x002B7B7E File Offset: 0x002B5D7E
		// (set) Token: 0x0601D701 RID: 120577 RVA: 0x002B7B92 File Offset: 0x002B5D92
		public unsafe FVector PointA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointA) = value;
			}
		}

		// Token: 0x170076AD RID: 30381
		// (get) Token: 0x0601D702 RID: 120578 RVA: 0x002B7BA7 File Offset: 0x002B5DA7
		// (set) Token: 0x0601D703 RID: 120579 RVA: 0x002B7BBB File Offset: 0x002B5DBB
		public unsafe FVector PointB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointB) = value;
			}
		}

		// Token: 0x0601D704 RID: 120580 RVA: 0x002B7BD0 File Offset: 0x002B5DD0
		public FKSC_Segment()
		{
		}

		// Token: 0x0601D705 RID: 120581 RVA: 0x002B7BD8 File Offset: 0x002B5DD8
		public FKSC_Segment(FVector PointA, FVector PointB)
		{
			this.PointA = PointA;
			this.PointB = PointB;
		}

		// Token: 0x0601D706 RID: 120582 RVA: 0x002B7BEE File Offset: 0x002B5DEE
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Segment.StaticStruct();
		}

		// Token: 0x0601D707 RID: 120583 RVA: 0x002B7BFA File Offset: 0x002B5DFA
		[NullableContext(2)]
		public FKSC_Segment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D708 RID: 120584 RVA: 0x002B7C04 File Offset: 0x002B5E04
		public FKSC_Segment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D709 RID: 120585 RVA: 0x002B7C0F File Offset: 0x002B5E0F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Segment(Pointer, false, true);
		}

		// Token: 0x0601D70A RID: 120586 RVA: 0x002B7C19 File Offset: 0x002B5E19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Segment(Pointer, MemoryOwner);
		}

		// Token: 0x0400FF6A RID: 65386
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Segment";

		// Token: 0x0400FF6B RID: 65387
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FF6C RID: 65388
		internal static int __PropertyOffset_PointA;

		// Token: 0x0400FF6D RID: 65389
		internal static int __PropertyOffset_PointB;
	}
}
