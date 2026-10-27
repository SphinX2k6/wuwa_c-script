using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000968 RID: 2408
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CompositeSection")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FCompositeSection : FAnimLinkableElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060087F3 RID: 34803 RVA: 0x000C2C4E File Offset: 0x000C0E4E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompositeSection._ScriptStructPtr != 0) ? FCompositeSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CompositeSection", ref FCompositeSection._ScriptStructPtr);
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x060087F4 RID: 34804 RVA: 0x000C2C72 File Offset: 0x000C0E72
		// (set) Token: 0x060087F5 RID: 34805 RVA: 0x000C2C86 File Offset: 0x000C0E86
		public unsafe FName SectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_SectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_SectionName) = value;
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x060087F6 RID: 34806 RVA: 0x000C2C9B File Offset: 0x000C0E9B
		// (set) Token: 0x060087F7 RID: 34807 RVA: 0x000C2CAB File Offset: 0x000C0EAB
		public unsafe float StartTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_StartTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_StartTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x060087F8 RID: 34808 RVA: 0x000C2CBC File Offset: 0x000C0EBC
		// (set) Token: 0x060087F9 RID: 34809 RVA: 0x000C2CD0 File Offset: 0x000C0ED0
		public unsafe FName NextSectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_NextSectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_NextSectionName) = value;
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x000C2CE8 File Offset: 0x000C0EE8
		// (set) Token: 0x060087FB RID: 34811 RVA: 0x000C2D2B File Offset: 0x000C0F2B
		public TArray<UAnimMetaData> MetaData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimMetaData> result;
				if ((result = this._MetaData) == null)
				{
					result = (this._MetaData = new TArray<UAnimMetaData>(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_MetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MetaData.CopyAssign(value);
			}
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x000C2D39 File Offset: 0x000C0F39
		public FCompositeSection()
		{
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x000C2D44 File Offset: 0x000C0F44
		public FCompositeSection(FName SectionName, float StartTime_DEPRECATED, FName NextSectionName, TArray<UAnimMetaData> MetaData, UAnimMontage LinkedMontage, int SlotIndex, int SegmentIndex, [Nullable(0)] TEnumAsByte<EAnimLinkMethod> LinkMethod, [Nullable(0)] TEnumAsByte<EAnimLinkMethod> CachedLinkMethod, float SegmentBeginTime, float SegmentLength, float LinkValue, UAnimSequenceBase LinkedSequence)
		{
			this.SectionName = SectionName;
			this.StartTime_DEPRECATED = StartTime_DEPRECATED;
			this.NextSectionName = NextSectionName;
			this.MetaData = MetaData;
			base.LinkedMontage = LinkedMontage;
			base.SlotIndex = SlotIndex;
			base.SegmentIndex = SegmentIndex;
			base.LinkMethod = LinkMethod;
			base.CachedLinkMethod = CachedLinkMethod;
			base.SegmentBeginTime = SegmentBeginTime;
			base.SegmentLength = SegmentLength;
			base.LinkValue = LinkValue;
			base.LinkedSequence = LinkedSequence;
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x000C2DBC File Offset: 0x000C0FBC
		protected override IntPtr GetUStructPtr()
		{
			return FCompositeSection.StaticStruct();
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x000C2DC8 File Offset: 0x000C0FC8
		[NullableContext(2)]
		public FCompositeSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x000C2DD2 File Offset: 0x000C0FD2
		public FCompositeSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x000C2DDD File Offset: 0x000C0FDD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompositeSection(Pointer, false, true);
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x000C2DE7 File Offset: 0x000C0FE7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompositeSection(Pointer, MemoryOwner);
		}

		// Token: 0x040040A2 RID: 16546
		public new const string __ObjectPath = "/Script/Engine.CompositeSection";

		// Token: 0x040040A3 RID: 16547
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040A4 RID: 16548
		internal static int __PropertyOffset_SectionName;

		// Token: 0x040040A5 RID: 16549
		internal static int __PropertyOffset_StartTime_DEPRECATED;

		// Token: 0x040040A6 RID: 16550
		internal static int __PropertyOffset_NextSectionName;

		// Token: 0x040040A7 RID: 16551
		internal static int __PropertyOffset_MetaData;

		// Token: 0x040040A8 RID: 16552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimMetaData> _MetaData;
	}
}
