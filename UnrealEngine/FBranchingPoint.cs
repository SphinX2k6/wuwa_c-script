using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008F0 RID: 2288
	[UnrealObjectPath("/Script/Engine.BranchingPoint")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FBranchingPoint : FAnimLinkableElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D85 RID: 32133 RVA: 0x000B3E28 File Offset: 0x000B2028
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBranchingPoint._ScriptStructPtr != 0) ? FBranchingPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BranchingPoint", ref FBranchingPoint._ScriptStructPtr);
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06007D86 RID: 32134 RVA: 0x000B3E4C File Offset: 0x000B204C
		// (set) Token: 0x06007D87 RID: 32135 RVA: 0x000B3E60 File Offset: 0x000B2060
		public unsafe FName EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchingPoint.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchingPoint.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06007D88 RID: 32136 RVA: 0x000B3E75 File Offset: 0x000B2075
		// (set) Token: 0x06007D89 RID: 32137 RVA: 0x000B3E85 File Offset: 0x000B2085
		public unsafe float DisplayTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchingPoint.__PropertyOffset_DisplayTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchingPoint.__PropertyOffset_DisplayTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06007D8A RID: 32138 RVA: 0x000B3E96 File Offset: 0x000B2096
		// (set) Token: 0x06007D8B RID: 32139 RVA: 0x000B3EA6 File Offset: 0x000B20A6
		public unsafe float TriggerTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchingPoint.__PropertyOffset_TriggerTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchingPoint.__PropertyOffset_TriggerTimeOffset) = value;
			}
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x000B3EB7 File Offset: 0x000B20B7
		public FBranchingPoint()
		{
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x000B3EC0 File Offset: 0x000B20C0
		public FBranchingPoint(FName EventName, float DisplayTime_DEPRECATED, float TriggerTimeOffset, [Nullable(1)] UAnimMontage LinkedMontage, int SlotIndex, int SegmentIndex, TEnumAsByte<EAnimLinkMethod> LinkMethod, TEnumAsByte<EAnimLinkMethod> CachedLinkMethod, float SegmentBeginTime, float SegmentLength, float LinkValue, [Nullable(1)] UAnimSequenceBase LinkedSequence)
		{
			this.EventName = EventName;
			this.DisplayTime_DEPRECATED = DisplayTime_DEPRECATED;
			this.TriggerTimeOffset = TriggerTimeOffset;
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

		// Token: 0x06007D8E RID: 32142 RVA: 0x000B3F30 File Offset: 0x000B2130
		protected override IntPtr GetUStructPtr()
		{
			return FBranchingPoint.StaticStruct();
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x000B3F3C File Offset: 0x000B213C
		[NullableContext(2)]
		public FBranchingPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x000B3F46 File Offset: 0x000B2146
		public FBranchingPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x000B3F51 File Offset: 0x000B2151
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBranchingPoint(Pointer, false, true);
		}

		// Token: 0x06007D92 RID: 32146 RVA: 0x000B3F5B File Offset: 0x000B215B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBranchingPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04003C23 RID: 15395
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BranchingPoint";

		// Token: 0x04003C24 RID: 15396
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C25 RID: 15397
		internal static int __PropertyOffset_EventName;

		// Token: 0x04003C26 RID: 15398
		internal static int __PropertyOffset_DisplayTime_DEPRECATED;

		// Token: 0x04003C27 RID: 15399
		internal static int __PropertyOffset_TriggerTimeOffset;
	}
}
