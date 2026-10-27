using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002709 RID: 9993
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.QteProgressSpineSegment")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FQteProgressSpineSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060250C5 RID: 151749 RVA: 0x0036D5BB File Offset: 0x0036B7BB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQteProgressSpineSegment._ScriptStructPtr != 0) ? FQteProgressSpineSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.QteProgressSpineSegment", ref FQteProgressSpineSegment._ScriptStructPtr);
		}

		// Token: 0x17008EEF RID: 36591
		// (get) Token: 0x060250C6 RID: 151750 RVA: 0x0036D5E0 File Offset: 0x0036B7E0
		// (set) Token: 0x060250C7 RID: 151751 RVA: 0x0036D623 File Offset: 0x0036B823
		public TArray<FSpineData> Spines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineData> result;
				if ((result = this._Spines) == null)
				{
					result = (this._Spines = new TArray<FSpineData>(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_Spines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Spines.CopyAssign(value);
			}
		}

		// Token: 0x17008EF0 RID: 36592
		// (get) Token: 0x060250C8 RID: 151752 RVA: 0x0036D631 File Offset: 0x0036B831
		// (set) Token: 0x060250C9 RID: 151753 RVA: 0x0036D641 File Offset: 0x0036B841
		public unsafe float QteStartPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteStartPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteStartPercent) = value;
			}
		}

		// Token: 0x17008EF1 RID: 36593
		// (get) Token: 0x060250CA RID: 151754 RVA: 0x0036D652 File Offset: 0x0036B852
		// (set) Token: 0x060250CB RID: 151755 RVA: 0x0036D662 File Offset: 0x0036B862
		public unsafe float QteEndPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteEndPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_QteEndPercent) = value;
			}
		}

		// Token: 0x17008EF2 RID: 36594
		// (get) Token: 0x060250CC RID: 151756 RVA: 0x0036D673 File Offset: 0x0036B873
		// (set) Token: 0x060250CD RID: 151757 RVA: 0x0036D683 File Offset: 0x0036B883
		public unsafe float SpineStartPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineStartPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineStartPercent) = value;
			}
		}

		// Token: 0x17008EF3 RID: 36595
		// (get) Token: 0x060250CE RID: 151758 RVA: 0x0036D694 File Offset: 0x0036B894
		// (set) Token: 0x060250CF RID: 151759 RVA: 0x0036D6A4 File Offset: 0x0036B8A4
		public unsafe float SpineEndPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineEndPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_SpineEndPercent) = value;
			}
		}

		// Token: 0x17008EF4 RID: 36596
		// (get) Token: 0x060250D0 RID: 151760 RVA: 0x0036D6B5 File Offset: 0x0036B8B5
		// (set) Token: 0x060250D1 RID: 151761 RVA: 0x0036D6C5 File Offset: 0x0036B8C5
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x17008EF5 RID: 36597
		// (get) Token: 0x060250D2 RID: 151762 RVA: 0x0036D6D6 File Offset: 0x0036B8D6
		// (set) Token: 0x060250D3 RID: 151763 RVA: 0x0036D6E6 File Offset: 0x0036B8E6
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQteProgressSpineSegment.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x060250D4 RID: 151764 RVA: 0x0036D6F7 File Offset: 0x0036B8F7
		public FQteProgressSpineSegment()
		{
		}

		// Token: 0x060250D5 RID: 151765 RVA: 0x0036D6FF File Offset: 0x0036B8FF
		public FQteProgressSpineSegment(TArray<FSpineData> Spines, float QteStartPercent, float QteEndPercent, float SpineStartPercent, float SpineEndPercent, float BlendInTime, float BlendOutTime)
		{
			this.Spines = Spines;
			this.QteStartPercent = QteStartPercent;
			this.QteEndPercent = QteEndPercent;
			this.SpineStartPercent = SpineStartPercent;
			this.SpineEndPercent = SpineEndPercent;
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
		}

		// Token: 0x060250D6 RID: 151766 RVA: 0x0036D73C File Offset: 0x0036B93C
		protected override IntPtr GetUStructPtr()
		{
			return FQteProgressSpineSegment.StaticStruct();
		}

		// Token: 0x060250D7 RID: 151767 RVA: 0x0036D748 File Offset: 0x0036B948
		[NullableContext(2)]
		public FQteProgressSpineSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060250D8 RID: 151768 RVA: 0x0036D752 File Offset: 0x0036B952
		public FQteProgressSpineSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060250D9 RID: 151769 RVA: 0x0036D75D File Offset: 0x0036B95D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQteProgressSpineSegment(Pointer, false, true);
		}

		// Token: 0x060250DA RID: 151770 RVA: 0x0036D767 File Offset: 0x0036B967
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQteProgressSpineSegment(Pointer, MemoryOwner);
		}

		// Token: 0x04013F53 RID: 81747
		public const string __ObjectPath = "/Script/SequenceDialogue.QteProgressSpineSegment";

		// Token: 0x04013F54 RID: 81748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F55 RID: 81749
		internal static int __PropertyOffset_Spines;

		// Token: 0x04013F56 RID: 81750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineData> _Spines;

		// Token: 0x04013F57 RID: 81751
		internal static int __PropertyOffset_QteStartPercent;

		// Token: 0x04013F58 RID: 81752
		internal static int __PropertyOffset_QteEndPercent;

		// Token: 0x04013F59 RID: 81753
		internal static int __PropertyOffset_SpineStartPercent;

		// Token: 0x04013F5A RID: 81754
		internal static int __PropertyOffset_SpineEndPercent;

		// Token: 0x04013F5B RID: 81755
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x04013F5C RID: 81756
		internal static int __PropertyOffset_BlendOutTime;
	}
}
