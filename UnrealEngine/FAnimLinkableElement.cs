using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000179 RID: 377
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimLinkableElement")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAnimLinkableElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060017D3 RID: 6099 RVA: 0x0002480F File Offset: 0x00022A0F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimLinkableElement._ScriptStructPtr != 0) ? FAnimLinkableElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimLinkableElement", ref FAnimLinkableElement._ScriptStructPtr);
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00024833 File Offset: 0x00022A33
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00024847 File Offset: 0x00022A47
		public unsafe UAnimMontage LinkedMontage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedMontage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedMontage, value);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0002485C File Offset: 0x00022A5C
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0002486C File Offset: 0x00022A6C
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0002487D File Offset: 0x00022A7D
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0002488D File Offset: 0x00022A8D
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0002489E File Offset: 0x00022A9E
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x000248AE File Offset: 0x00022AAE
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x000248BF File Offset: 0x00022ABF
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x000248CF File Offset: 0x00022ACF
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x000248E0 File Offset: 0x00022AE0
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x000248F0 File Offset: 0x00022AF0
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00024901 File Offset: 0x00022B01
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00024915 File Offset: 0x00022B15
		public unsafe UAnimSequenceBase LinkedSequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedSequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimLinkableElement.__PropertyOffset_LinkedSequence, value);
			}
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0002492A File Offset: 0x00022B2A
		public FAnimLinkableElement()
		{
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00024932 File Offset: 0x00022B32
		protected override IntPtr GetUStructPtr()
		{
			return FAnimLinkableElement.StaticStruct();
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0002493E File Offset: 0x00022B3E
		public FAnimLinkableElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00024948 File Offset: 0x00022B48
		public FAnimLinkableElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00024953 File Offset: 0x00022B53
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimLinkableElement(Pointer, false, true);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0002495D File Offset: 0x00022B5D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimLinkableElement(Pointer, MemoryOwner);
		}

		// Token: 0x04000776 RID: 1910
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimLinkableElement";

		// Token: 0x04000777 RID: 1911
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000778 RID: 1912
		internal static int __PropertyOffset_LinkedMontage;

		// Token: 0x04000779 RID: 1913
		internal static int __PropertyOffset_SlotIndex;

		// Token: 0x0400077A RID: 1914
		internal static int __PropertyOffset_SegmentIndex;

		// Token: 0x0400077B RID: 1915
		internal static int __PropertyOffset_SegmentBeginTime;

		// Token: 0x0400077C RID: 1916
		internal static int __PropertyOffset_SegmentLength;

		// Token: 0x0400077D RID: 1917
		internal static int __PropertyOffset_LinkValue;

		// Token: 0x0400077E RID: 1918
		internal static int __PropertyOffset_LinkedSequence;
	}
}
