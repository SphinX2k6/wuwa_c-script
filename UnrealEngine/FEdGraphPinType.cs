using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A4B RID: 2635
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EdGraphPinType")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FEdGraphPinType : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008F06 RID: 36614 RVA: 0x000CC810 File Offset: 0x000CAA10
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEdGraphPinType._ScriptStructPtr != 0) ? FEdGraphPinType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EdGraphPinType", ref FEdGraphPinType._ScriptStructPtr);
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06008F07 RID: 36615 RVA: 0x000CC834 File Offset: 0x000CAA34
		// (set) Token: 0x06008F08 RID: 36616 RVA: 0x000CC848 File Offset: 0x000CAA48
		public unsafe FName PinCategory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinCategory);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinCategory) = value;
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06008F09 RID: 36617 RVA: 0x000CC85D File Offset: 0x000CAA5D
		// (set) Token: 0x06008F0A RID: 36618 RVA: 0x000CC871 File Offset: 0x000CAA71
		public unsafe FName PinSubCategory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinSubCategory);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinSubCategory) = value;
			}
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06008F0B RID: 36619 RVA: 0x000CC886 File Offset: 0x000CAA86
		// (set) Token: 0x06008F0C RID: 36620 RVA: 0x000CC89A File Offset: 0x000CAA9A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> PinSubCategoryObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinSubCategoryObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinSubCategoryObject) = value;
			}
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06008F0D RID: 36621 RVA: 0x000CC8B0 File Offset: 0x000CAAB0
		// (set) Token: 0x06008F0E RID: 36622 RVA: 0x000CC8F3 File Offset: 0x000CAAF3
		public FSimpleMemberReference PinSubCategoryMemberReference
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleMemberReference result;
				if ((result = this._PinSubCategoryMemberReference) == null)
				{
					result = (this._PinSubCategoryMemberReference = new FSimpleMemberReference(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinSubCategoryMemberReference, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSimpleMemberReference.StaticStruct(), base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinSubCategoryMemberReference, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06008F0F RID: 36623 RVA: 0x000CC914 File Offset: 0x000CAB14
		// (set) Token: 0x06008F10 RID: 36624 RVA: 0x000CC957 File Offset: 0x000CAB57
		public FEdGraphTerminalType PinValueType
		{
			get
			{
				base.FastCheckIsValid();
				FEdGraphTerminalType result;
				if ((result = this._PinValueType) == null)
				{
					result = (this._PinValueType = new FEdGraphTerminalType(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinValueType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEdGraphTerminalType.StaticStruct(), base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_PinValueType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06008F11 RID: 36625 RVA: 0x000CC978 File Offset: 0x000CAB78
		// (set) Token: 0x06008F12 RID: 36626 RVA: 0x000CC988 File Offset: 0x000CAB88
		public unsafe EPinContainerType ContainerType
		{
			get
			{
				return (EPinContainerType)(*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_ContainerType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_ContainerType) = (byte)value;
			}
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06008F13 RID: 36627 RVA: 0x000CC999 File Offset: 0x000CAB99
		// (set) Token: 0x06008F14 RID: 36628 RVA: 0x000CC9B2 File Offset: 0x000CABB2
		public unsafe bool bIsArray_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsArray_DEPRECATED) & FEdGraphPinType.__PropertyMask_bIsArray_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsArray_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsArray_DEPRECATED) & ~FEdGraphPinType.__PropertyMask_bIsArray_DEPRECATED) | (value ? FEdGraphPinType.__PropertyMask_bIsArray_DEPRECATED : 0));
			}
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06008F15 RID: 36629 RVA: 0x000CC9E2 File Offset: 0x000CABE2
		// (set) Token: 0x06008F16 RID: 36630 RVA: 0x000CC9FB File Offset: 0x000CABFB
		public unsafe bool bIsReference
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsReference) & FEdGraphPinType.__PropertyMask_bIsReference) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsReference) = ((*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsReference) & ~FEdGraphPinType.__PropertyMask_bIsReference) | (value ? FEdGraphPinType.__PropertyMask_bIsReference : 0));
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06008F17 RID: 36631 RVA: 0x000CCA2B File Offset: 0x000CAC2B
		// (set) Token: 0x06008F18 RID: 36632 RVA: 0x000CCA44 File Offset: 0x000CAC44
		public unsafe bool bIsConst
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsConst) & FEdGraphPinType.__PropertyMask_bIsConst) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsConst) = ((*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsConst) & ~FEdGraphPinType.__PropertyMask_bIsConst) | (value ? FEdGraphPinType.__PropertyMask_bIsConst : 0));
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06008F19 RID: 36633 RVA: 0x000CCA74 File Offset: 0x000CAC74
		// (set) Token: 0x06008F1A RID: 36634 RVA: 0x000CCA8D File Offset: 0x000CAC8D
		public unsafe bool bIsWeakPointer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsWeakPointer) & FEdGraphPinType.__PropertyMask_bIsWeakPointer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsWeakPointer) = ((*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsWeakPointer) & ~FEdGraphPinType.__PropertyMask_bIsWeakPointer) | (value ? FEdGraphPinType.__PropertyMask_bIsWeakPointer : 0));
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06008F1B RID: 36635 RVA: 0x000CCABD File Offset: 0x000CACBD
		// (set) Token: 0x06008F1C RID: 36636 RVA: 0x000CCAD6 File Offset: 0x000CACD6
		public unsafe bool bIsUObjectWrapper
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsUObjectWrapper) & FEdGraphPinType.__PropertyMask_bIsUObjectWrapper) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsUObjectWrapper) = ((*(base.NativePtr + (IntPtr)FEdGraphPinType.__PropertyOffset_bIsUObjectWrapper) & ~FEdGraphPinType.__PropertyMask_bIsUObjectWrapper) | (value ? FEdGraphPinType.__PropertyMask_bIsUObjectWrapper : 0));
			}
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x000CCB06 File Offset: 0x000CAD06
		public FEdGraphPinType()
		{
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x000CCB10 File Offset: 0x000CAD10
		public FEdGraphPinType(FName PinCategory, FName PinSubCategory, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> PinSubCategoryObject, FSimpleMemberReference PinSubCategoryMemberReference, FEdGraphTerminalType PinValueType, EPinContainerType ContainerType, bool bIsArray_DEPRECATED, bool bIsReference, bool bIsConst, bool bIsWeakPointer, bool bIsUObjectWrapper)
		{
			this.PinCategory = PinCategory;
			this.PinSubCategory = PinSubCategory;
			this.PinSubCategoryObject = PinSubCategoryObject;
			this.PinSubCategoryMemberReference = PinSubCategoryMemberReference;
			this.PinValueType = PinValueType;
			this.ContainerType = ContainerType;
			this.bIsArray_DEPRECATED = bIsArray_DEPRECATED;
			this.bIsReference = bIsReference;
			this.bIsConst = bIsConst;
			this.bIsWeakPointer = bIsWeakPointer;
			this.bIsUObjectWrapper = bIsUObjectWrapper;
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x000CCB78 File Offset: 0x000CAD78
		protected override IntPtr GetUStructPtr()
		{
			return FEdGraphPinType.StaticStruct();
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x000CCB84 File Offset: 0x000CAD84
		[NullableContext(2)]
		public FEdGraphPinType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008F21 RID: 36641 RVA: 0x000CCB8E File Offset: 0x000CAD8E
		public FEdGraphPinType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x000CCB99 File Offset: 0x000CAD99
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEdGraphPinType(Pointer, false, true);
		}

		// Token: 0x06008F23 RID: 36643 RVA: 0x000CCBA3 File Offset: 0x000CADA3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEdGraphPinType(Pointer, MemoryOwner);
		}

		// Token: 0x04004696 RID: 18070
		public const string __ObjectPath = "/Script/Engine.EdGraphPinType";

		// Token: 0x04004697 RID: 18071
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004698 RID: 18072
		internal static int __PropertyOffset_PinCategory;

		// Token: 0x04004699 RID: 18073
		internal static int __PropertyOffset_PinSubCategory;

		// Token: 0x0400469A RID: 18074
		internal static int __PropertyOffset_PinSubCategoryObject;

		// Token: 0x0400469B RID: 18075
		internal static int __PropertyOffset_PinSubCategoryMemberReference;

		// Token: 0x0400469C RID: 18076
		[Nullable(2)]
		private FSimpleMemberReference _PinSubCategoryMemberReference;

		// Token: 0x0400469D RID: 18077
		internal static int __PropertyOffset_PinValueType;

		// Token: 0x0400469E RID: 18078
		[Nullable(2)]
		private FEdGraphTerminalType _PinValueType;

		// Token: 0x0400469F RID: 18079
		internal static int __PropertyOffset_ContainerType;

		// Token: 0x040046A0 RID: 18080
		internal static int __PropertyOffset_bIsArray_DEPRECATED;

		// Token: 0x040046A1 RID: 18081
		internal static byte __PropertyMask_bIsArray_DEPRECATED;

		// Token: 0x040046A2 RID: 18082
		internal static int __PropertyOffset_bIsReference;

		// Token: 0x040046A3 RID: 18083
		internal static byte __PropertyMask_bIsReference;

		// Token: 0x040046A4 RID: 18084
		internal static int __PropertyOffset_bIsConst;

		// Token: 0x040046A5 RID: 18085
		internal static byte __PropertyMask_bIsConst;

		// Token: 0x040046A6 RID: 18086
		internal static int __PropertyOffset_bIsWeakPointer;

		// Token: 0x040046A7 RID: 18087
		internal static byte __PropertyMask_bIsWeakPointer;

		// Token: 0x040046A8 RID: 18088
		internal static int __PropertyOffset_bIsUObjectWrapper;

		// Token: 0x040046A9 RID: 18089
		internal static byte __PropertyMask_bIsUObjectWrapper;
	}
}
