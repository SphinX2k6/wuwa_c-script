using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200080F RID: 2063
	[UnrealObjectPath("/Script/Engine.AnimLinkableElement")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAnimLinkableElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006EB1 RID: 28337 RVA: 0x0009EBE9 File Offset: 0x0009CDE9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimLinkableElement._ScriptStructPtr != 0) ? FAnimLinkableElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimLinkableElement", ref FAnimLinkableElement._ScriptStructPtr);
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06006EB2 RID: 28338 RVA: 0x0009EC0D File Offset: 0x0009CE0D
		// (set) Token: 0x06006EB3 RID: 28339 RVA: 0x0009EC21 File Offset: 0x0009CE21
		[Nullable(2)]
		public unsafe UAnimMontage LinkedMontage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedMontage);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedMontage, value);
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06006EB4 RID: 28340 RVA: 0x0009EC36 File Offset: 0x0009CE36
		// (set) Token: 0x06006EB5 RID: 28341 RVA: 0x0009EC46 File Offset: 0x0009CE46
		public unsafe int SlotIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SlotIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SlotIndex) = value;
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06006EB6 RID: 28342 RVA: 0x0009EC57 File Offset: 0x0009CE57
		// (set) Token: 0x06006EB7 RID: 28343 RVA: 0x0009EC67 File Offset: 0x0009CE67
		public unsafe int SegmentIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SegmentIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SegmentIndex) = value;
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06006EB8 RID: 28344 RVA: 0x0009EC78 File Offset: 0x0009CE78
		// (set) Token: 0x06006EB9 RID: 28345 RVA: 0x0009EC8C File Offset: 0x0009CE8C
		public unsafe TEnumAsByte<EAnimLinkMethod> LinkMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_LinkMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_LinkMethod) = value;
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x06006EBA RID: 28346 RVA: 0x0009ECA1 File Offset: 0x0009CEA1
		// (set) Token: 0x06006EBB RID: 28347 RVA: 0x0009ECB5 File Offset: 0x0009CEB5
		public unsafe TEnumAsByte<EAnimLinkMethod> CachedLinkMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_CachedLinkMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_CachedLinkMethod) = value;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06006EBC RID: 28348 RVA: 0x0009ECCA File Offset: 0x0009CECA
		// (set) Token: 0x06006EBD RID: 28349 RVA: 0x0009ECDA File Offset: 0x0009CEDA
		public unsafe float SegmentBeginTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SegmentBeginTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SegmentBeginTime) = value;
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06006EBE RID: 28350 RVA: 0x0009ECEB File Offset: 0x0009CEEB
		// (set) Token: 0x06006EBF RID: 28351 RVA: 0x0009ECFB File Offset: 0x0009CEFB
		public unsafe float SegmentLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SegmentLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_SegmentLength) = value;
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06006EC0 RID: 28352 RVA: 0x0009ED0C File Offset: 0x0009CF0C
		// (set) Token: 0x06006EC1 RID: 28353 RVA: 0x0009ED1C File Offset: 0x0009CF1C
		public unsafe float LinkValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_LinkValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimLinkableElement.__PropertyOffset_LinkValue) = value;
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x0009ED2D File Offset: 0x0009CF2D
		// (set) Token: 0x06006EC3 RID: 28355 RVA: 0x0009ED41 File Offset: 0x0009CF41
		[Nullable(2)]
		public unsafe UAnimSequenceBase LinkedSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedSequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedSequence, value);
			}
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x0009ED56 File Offset: 0x0009CF56
		public FAnimLinkableElement()
		{
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x0009ED60 File Offset: 0x0009CF60
		public FAnimLinkableElement([Nullable(1)] UAnimMontage LinkedMontage, int SlotIndex, int SegmentIndex, TEnumAsByte<EAnimLinkMethod> LinkMethod, TEnumAsByte<EAnimLinkMethod> CachedLinkMethod, float SegmentBeginTime, float SegmentLength, float LinkValue, [Nullable(1)] UAnimSequenceBase LinkedSequence)
		{
			this.LinkedMontage = LinkedMontage;
			this.SlotIndex = SlotIndex;
			this.SegmentIndex = SegmentIndex;
			this.LinkMethod = LinkMethod;
			this.CachedLinkMethod = CachedLinkMethod;
			this.SegmentBeginTime = SegmentBeginTime;
			this.SegmentLength = SegmentLength;
			this.LinkValue = LinkValue;
			this.LinkedSequence = LinkedSequence;
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x0009EDB8 File Offset: 0x0009CFB8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimLinkableElement.StaticStruct();
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x0009EDC4 File Offset: 0x0009CFC4
		[NullableContext(2)]
		public FAnimLinkableElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x0009EDCE File Offset: 0x0009CFCE
		public FAnimLinkableElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x0009EDD9 File Offset: 0x0009CFD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimLinkableElement(Pointer, false, true);
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x0009EDE3 File Offset: 0x0009CFE3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimLinkableElement(Pointer, MemoryOwner);
		}

		// Token: 0x04003525 RID: 13605
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimLinkableElement";

		// Token: 0x04003526 RID: 13606
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003527 RID: 13607
		internal static int __PropertyOffset_LinkedMontage;

		// Token: 0x04003528 RID: 13608
		internal static int __PropertyOffset_SlotIndex;

		// Token: 0x04003529 RID: 13609
		internal static int __PropertyOffset_SegmentIndex;

		// Token: 0x0400352A RID: 13610
		internal static int __PropertyOffset_LinkMethod;

		// Token: 0x0400352B RID: 13611
		internal static int __PropertyOffset_CachedLinkMethod;

		// Token: 0x0400352C RID: 13612
		internal static int __PropertyOffset_SegmentBeginTime;

		// Token: 0x0400352D RID: 13613
		internal static int __PropertyOffset_SegmentLength;

		// Token: 0x0400352E RID: 13614
		internal static int __PropertyOffset_LinkValue;

		// Token: 0x0400352F RID: 13615
		internal static int __PropertyOffset_LinkedSequence;
	}
}
