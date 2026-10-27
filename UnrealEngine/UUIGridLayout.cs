using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002175 RID: 8565
	[UnrealObjectPath("/Script/LGUI.UIGridLayout")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UUIGridLayout : UUILayoutWithAnimation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020560 RID: 132448 RVA: 0x00300429 File Offset: 0x002FE629
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGridLayout._ClassPtr;
		}

		// Token: 0x06020561 RID: 132449 RVA: 0x00300438 File Offset: 0x002FE638
		public UUIGridLayout() : this(BuiltinUtils.AllocNativeUObject(UUIGridLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020562 RID: 132450 RVA: 0x00300460 File Offset: 0x002FE660
		[NullableContext(1)]
		public UUIGridLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIGridLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EC1 RID: 32449
		// (get) Token: 0x06020563 RID: 132451 RVA: 0x00300493 File Offset: 0x002FE693
		// (set) Token: 0x06020564 RID: 132452 RVA: 0x003004A7 File Offset: 0x002FE6A7
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17007EC2 RID: 32450
		// (get) Token: 0x06020565 RID: 132453 RVA: 0x003004BC File Offset: 0x002FE6BC
		// (set) Token: 0x06020566 RID: 132454 RVA: 0x003004D0 File Offset: 0x002FE6D0
		public unsafe FVector2D Spacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Spacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Spacing) = value;
			}
		}

		// Token: 0x17007EC3 RID: 32451
		// (get) Token: 0x06020567 RID: 132455 RVA: 0x003004E5 File Offset: 0x002FE6E5
		// (set) Token: 0x06020568 RID: 132456 RVA: 0x003004F5 File Offset: 0x002FE6F5
		public unsafe ELGUILayoutAlignmentType Align
		{
			get
			{
				return (ELGUILayoutAlignmentType)(*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Align));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_Align) = (byte)value;
			}
		}

		// Token: 0x17007EC4 RID: 32452
		// (get) Token: 0x06020569 RID: 132457 RVA: 0x00300506 File Offset: 0x002FE706
		// (set) Token: 0x0602056A RID: 132458 RVA: 0x00300516 File Offset: 0x002FE716
		public unsafe bool LastLineCanAlign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LastLineCanAlign) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LastLineCanAlign) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EC5 RID: 32453
		// (get) Token: 0x0602056B RID: 132459 RVA: 0x00300527 File Offset: 0x002FE727
		// (set) Token: 0x0602056C RID: 132460 RVA: 0x00300537 File Offset: 0x002FE737
		public unsafe bool HorizontalOrVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HorizontalOrVertical) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HorizontalOrVertical) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EC6 RID: 32454
		// (get) Token: 0x0602056D RID: 132461 RVA: 0x00300548 File Offset: 0x002FE748
		// (set) Token: 0x0602056E RID: 132462 RVA: 0x00300558 File Offset: 0x002FE758
		public unsafe EUIGridLayoutStartCorner StartCorner
		{
			get
			{
				return (EUIGridLayoutStartCorner)(*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_StartCorner));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_StartCorner) = (byte)value;
			}
		}

		// Token: 0x17007EC7 RID: 32455
		// (get) Token: 0x0602056F RID: 132463 RVA: 0x00300569 File Offset: 0x002FE769
		// (set) Token: 0x06020570 RID: 132464 RVA: 0x00300579 File Offset: 0x002FE779
		public unsafe bool DependOnSizeOrCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_DependOnSizeOrCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_DependOnSizeOrCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EC8 RID: 32456
		// (get) Token: 0x06020571 RID: 132465 RVA: 0x0030058A File Offset: 0x002FE78A
		// (set) Token: 0x06020572 RID: 132466 RVA: 0x0030059A File Offset: 0x002FE79A
		public unsafe bool ExpendChildSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_ExpendChildSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_ExpendChildSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EC9 RID: 32457
		// (get) Token: 0x06020573 RID: 132467 RVA: 0x003005AB File Offset: 0x002FE7AB
		// (set) Token: 0x06020574 RID: 132468 RVA: 0x003005BF File Offset: 0x002FE7BF
		public unsafe FVector2D CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x17007ECA RID: 32458
		// (get) Token: 0x06020575 RID: 132469 RVA: 0x003005D4 File Offset: 0x002FE7D4
		// (set) Token: 0x06020576 RID: 132470 RVA: 0x003005E4 File Offset: 0x002FE7E4
		public unsafe uint LineCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LineCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_LineCount) = (int)value;
			}
		}

		// Token: 0x17007ECB RID: 32459
		// (get) Token: 0x06020577 RID: 132471 RVA: 0x003005F5 File Offset: 0x002FE7F5
		// (set) Token: 0x06020578 RID: 132472 RVA: 0x00300605 File Offset: 0x002FE805
		public unsafe bool WidthFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_WidthFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_WidthFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007ECC RID: 32460
		// (get) Token: 0x06020579 RID: 132473 RVA: 0x00300616 File Offset: 0x002FE816
		// (set) Token: 0x0602057A RID: 132474 RVA: 0x00300626 File Offset: 0x002FE826
		public unsafe bool HeightFitToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HeightFitToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_HeightFitToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007ECD RID: 32461
		// (get) Token: 0x0602057B RID: 132475 RVA: 0x00300637 File Offset: 0x002FE837
		// (set) Token: 0x0602057C RID: 132476 RVA: 0x00300647 File Offset: 0x002FE847
		public unsafe EGridFitType FitType
		{
			get
			{
				return (EGridFitType)(*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_FitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_FitType) = (byte)value;
			}
		}

		// Token: 0x17007ECE RID: 32462
		// (get) Token: 0x0602057D RID: 132477 RVA: 0x00300658 File Offset: 0x002FE858
		// (set) Token: 0x0602057E RID: 132478 RVA: 0x0030066C File Offset: 0x002FE86C
		public unsafe FVector2D CellScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGridLayout.__PropertyOffset_CellScale) = value;
			}
		}

		// Token: 0x0602057F RID: 132479 RVA: 0x00300681 File Offset: 0x002FE881
		public void SetWidthFitToChildren(bool value)
		{
			UUIGridLayout.__SetWidthFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x06020580 RID: 132480 RVA: 0x0030068F File Offset: 0x002FE88F
		public void SetSpacing(FVector2D value)
		{
			UUIGridLayout.__SetSpacing_Internal(base.NativePtr, value);
		}

		// Token: 0x06020581 RID: 132481 RVA: 0x0030069D File Offset: 0x002FE89D
		public void SetPadding(FMargin value)
		{
			UUIGridLayout.__SetPadding_Internal(base.NativePtr, value);
		}

		// Token: 0x06020582 RID: 132482 RVA: 0x003006AB File Offset: 0x002FE8AB
		public void SetMaxItemCountInOneLine(int value)
		{
			UUIGridLayout.__SetMaxItemCountInOneLine_Internal(base.NativePtr, value);
		}

		// Token: 0x06020583 RID: 132483 RVA: 0x003006B9 File Offset: 0x002FE8B9
		public void SetLineCount(int value)
		{
			UUIGridLayout.__SetLineCount_Internal(base.NativePtr, value);
		}

		// Token: 0x06020584 RID: 132484 RVA: 0x003006C7 File Offset: 0x002FE8C7
		public void SetLastLineCanAlign(bool value)
		{
			UUIGridLayout.__SetLastLineCanAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x06020585 RID: 132485 RVA: 0x003006D5 File Offset: 0x002FE8D5
		public void SetHorizontalOrVertical(bool value, EUIGridLayoutStartCorner startCorner = EUIGridLayoutStartCorner.UpperLeft)
		{
			UUIGridLayout.__SetHorizontalOrVertical_Internal(base.NativePtr, value, startCorner);
		}

		// Token: 0x06020586 RID: 132486 RVA: 0x003006E4 File Offset: 0x002FE8E4
		public void SetHeightFitToChildren(bool value)
		{
			UUIGridLayout.__SetHeightFitToChildren_Internal(base.NativePtr, value);
		}

		// Token: 0x06020587 RID: 132487 RVA: 0x003006F2 File Offset: 0x002FE8F2
		public void SetExpendChildSize(bool value)
		{
			UUIGridLayout.__SetExpendChildSize_Internal(base.NativePtr, value);
		}

		// Token: 0x06020588 RID: 132488 RVA: 0x00300700 File Offset: 0x002FE900
		public void SetDependOnSizeOrCount(bool value)
		{
			UUIGridLayout.__SetDependOnSizeOrCount_Internal(base.NativePtr, value);
		}

		// Token: 0x06020589 RID: 132489 RVA: 0x0030070E File Offset: 0x002FE90E
		public void SetCellSize(FVector2D value)
		{
			UUIGridLayout.__SetCellSize_Internal(base.NativePtr, value);
		}

		// Token: 0x0602058A RID: 132490 RVA: 0x0030071C File Offset: 0x002FE91C
		public void SetCellScale(FVector2D value)
		{
			UUIGridLayout.__SetCellScale_Internal(base.NativePtr, value);
		}

		// Token: 0x0602058B RID: 132491 RVA: 0x0030072A File Offset: 0x002FE92A
		public void SetAlign(ELGUILayoutAlignmentType value)
		{
			UUIGridLayout.__SetAlign_Internal(base.NativePtr, value);
		}

		// Token: 0x0602058C RID: 132492 RVA: 0x00300738 File Offset: 0x002FE938
		public bool GetWidthFitToChildren()
		{
			return UUIGridLayout.__GetWidthFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x0602058D RID: 132493 RVA: 0x00300745 File Offset: 0x002FE945
		public FVector2D GetSpacing()
		{
			return UUIGridLayout.__GetSpacing_Internal(base.NativePtr);
		}

		// Token: 0x0602058E RID: 132494 RVA: 0x00300752 File Offset: 0x002FE952
		public FMargin GetPadding()
		{
			return UUIGridLayout.__GetPadding_Internal(base.NativePtr);
		}

		// Token: 0x0602058F RID: 132495 RVA: 0x0030075F File Offset: 0x002FE95F
		public int GetMaxItemCountInOneLine()
		{
			return UUIGridLayout.__GetMaxItemCountInOneLine_Internal(base.NativePtr);
		}

		// Token: 0x06020590 RID: 132496 RVA: 0x0030076C File Offset: 0x002FE96C
		public int GetLineCount()
		{
			return UUIGridLayout.__GetLineCount_Internal(base.NativePtr);
		}

		// Token: 0x06020591 RID: 132497 RVA: 0x00300779 File Offset: 0x002FE979
		public bool GetLastLineCanAlign()
		{
			return UUIGridLayout.__GetLastLineCanAlign_Internal(base.NativePtr);
		}

		// Token: 0x06020592 RID: 132498 RVA: 0x00300786 File Offset: 0x002FE986
		public bool GetHorizontalOrVertical()
		{
			return UUIGridLayout.__GetHorizontalOrVertical_Internal(base.NativePtr);
		}

		// Token: 0x06020593 RID: 132499 RVA: 0x00300793 File Offset: 0x002FE993
		public bool GetHeightFitToChildren()
		{
			return UUIGridLayout.__GetHeightFitToChildren_Internal(base.NativePtr);
		}

		// Token: 0x06020594 RID: 132500 RVA: 0x003007A0 File Offset: 0x002FE9A0
		public bool GetExpendChildSize()
		{
			return UUIGridLayout.__GetExpendChildSize_Internal(base.NativePtr);
		}

		// Token: 0x06020595 RID: 132501 RVA: 0x003007AD File Offset: 0x002FE9AD
		public bool GetDependOnSizeOrCount()
		{
			return UUIGridLayout.__GetDependOnSizeOrCount_Internal(base.NativePtr);
		}

		// Token: 0x06020596 RID: 132502 RVA: 0x003007BA File Offset: 0x002FE9BA
		public FVector2D GetCellSize()
		{
			return UUIGridLayout.__GetCellSize_Internal(base.NativePtr);
		}

		// Token: 0x06020597 RID: 132503 RVA: 0x003007C7 File Offset: 0x002FE9C7
		public ELGUILayoutAlignmentType GetAlign()
		{
			return UUIGridLayout.__GetAlign_Internal(base.NativePtr);
		}

		// Token: 0x06020598 RID: 132504 RVA: 0x003007D4 File Offset: 0x002FE9D4
		public FVector2D GetActuralRange()
		{
			return UUIGridLayout.__GetActuralRange_Internal(base.NativePtr);
		}

		// Token: 0x06020599 RID: 132505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidthFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x0602059A RID: 132506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpacing_Internal(IntPtr @this, FVector2D value);

		// Token: 0x0602059B RID: 132507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin value);

		// Token: 0x0602059C RID: 132508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxItemCountInOneLine_Internal(IntPtr @this, int value);

		// Token: 0x0602059D RID: 132509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLineCount_Internal(IntPtr @this, int value);

		// Token: 0x0602059E RID: 132510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLastLineCanAlign_Internal(IntPtr @this, bool value);

		// Token: 0x0602059F RID: 132511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalOrVertical_Internal(IntPtr @this, bool value, EUIGridLayoutStartCorner startCorner);

		// Token: 0x060205A0 RID: 132512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFitToChildren_Internal(IntPtr @this, bool value);

		// Token: 0x060205A1 RID: 132513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExpendChildSize_Internal(IntPtr @this, bool value);

		// Token: 0x060205A2 RID: 132514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDependOnSizeOrCount_Internal(IntPtr @this, bool value);

		// Token: 0x060205A3 RID: 132515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCellSize_Internal(IntPtr @this, FVector2D value);

		// Token: 0x060205A4 RID: 132516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCellScale_Internal(IntPtr @this, FVector2D value);

		// Token: 0x060205A5 RID: 132517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlign_Internal(IntPtr @this, ELGUILayoutAlignmentType value);

		// Token: 0x060205A6 RID: 132518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWidthFitToChildren_Internal(IntPtr @this);

		// Token: 0x060205A7 RID: 132519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetSpacing_Internal(IntPtr @this);

		// Token: 0x060205A8 RID: 132520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetPadding_Internal(IntPtr @this);

		// Token: 0x060205A9 RID: 132521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxItemCountInOneLine_Internal(IntPtr @this);

		// Token: 0x060205AA RID: 132522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLineCount_Internal(IntPtr @this);

		// Token: 0x060205AB RID: 132523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLastLineCanAlign_Internal(IntPtr @this);

		// Token: 0x060205AC RID: 132524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHorizontalOrVertical_Internal(IntPtr @this);

		// Token: 0x060205AD RID: 132525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHeightFitToChildren_Internal(IntPtr @this);

		// Token: 0x060205AE RID: 132526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetExpendChildSize_Internal(IntPtr @this);

		// Token: 0x060205AF RID: 132527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDependOnSizeOrCount_Internal(IntPtr @this);

		// Token: 0x060205B0 RID: 132528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetCellSize_Internal(IntPtr @this);

		// Token: 0x060205B1 RID: 132529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUILayoutAlignmentType __GetAlign_Internal(IntPtr @this);

		// Token: 0x060205B2 RID: 132530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetActuralRange_Internal(IntPtr @this);

		// Token: 0x060205B3 RID: 132531 RVA: 0x003007E1 File Offset: 0x002FE9E1
		static UUIGridLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGridLayout");
		}

		// Token: 0x060205B4 RID: 132532 RVA: 0x003007EF File Offset: 0x002FE9EF
		protected UUIGridLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115EF RID: 71151
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIGridLayout";

		// Token: 0x040115F0 RID: 71152
		private static IntPtr _ClassPtr;

		// Token: 0x040115F1 RID: 71153
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115F2 RID: 71154
		internal static int __PropertyOffset_Padding;

		// Token: 0x040115F3 RID: 71155
		internal static int __PropertyOffset_Spacing;

		// Token: 0x040115F4 RID: 71156
		internal static int __PropertyOffset_Align;

		// Token: 0x040115F5 RID: 71157
		internal static int __PropertyOffset_LastLineCanAlign;

		// Token: 0x040115F6 RID: 71158
		internal static int __PropertyOffset_HorizontalOrVertical;

		// Token: 0x040115F7 RID: 71159
		internal static int __PropertyOffset_StartCorner;

		// Token: 0x040115F8 RID: 71160
		internal static int __PropertyOffset_DependOnSizeOrCount;

		// Token: 0x040115F9 RID: 71161
		internal static int __PropertyOffset_ExpendChildSize;

		// Token: 0x040115FA RID: 71162
		internal static int __PropertyOffset_CellSize;

		// Token: 0x040115FB RID: 71163
		internal static int __PropertyOffset_LineCount;

		// Token: 0x040115FC RID: 71164
		internal static int __PropertyOffset_WidthFitToChildren;

		// Token: 0x040115FD RID: 71165
		internal static int __PropertyOffset_HeightFitToChildren;

		// Token: 0x040115FE RID: 71166
		internal static int __PropertyOffset_FitType;

		// Token: 0x040115FF RID: 71167
		internal static int __PropertyOffset_CellScale;
	}
}
