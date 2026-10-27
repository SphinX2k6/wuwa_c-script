using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E58 RID: 7768
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_TagFilter")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKSC_TagFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D94B RID: 121163 RVA: 0x002BACDF File Offset: 0x002B8EDF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_TagFilter._ScriptStructPtr != 0) ? FKSC_TagFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_TagFilter", ref FKSC_TagFilter._ScriptStructPtr);
		}

		// Token: 0x17007733 RID: 30515
		// (get) Token: 0x0601D94C RID: 121164 RVA: 0x002BAD03 File Offset: 0x002B8F03
		// (set) Token: 0x0601D94D RID: 121165 RVA: 0x002BAD13 File Offset: 0x002B8F13
		public unsafe bool IsNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_TagFilter.__PropertyOffset_IsNot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_TagFilter.__PropertyOffset_IsNot) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007734 RID: 30516
		// (get) Token: 0x0601D94E RID: 121166 RVA: 0x002BAD24 File Offset: 0x002B8F24
		// (set) Token: 0x0601D94F RID: 121167 RVA: 0x002BAD34 File Offset: 0x002B8F34
		public unsafe bool CompareHasAll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_TagFilter.__PropertyOffset_CompareHasAll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_TagFilter.__PropertyOffset_CompareHasAll) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007735 RID: 30517
		// (get) Token: 0x0601D950 RID: 121168 RVA: 0x002BAD48 File Offset: 0x002B8F48
		// (set) Token: 0x0601D951 RID: 121169 RVA: 0x002BAD8B File Offset: 0x002B8F8B
		public FGameplayTagContainer CompareTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CompareTags) == null)
				{
					result = (this._CompareTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FKSC_TagFilter.__PropertyOffset_CompareTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FKSC_TagFilter.__PropertyOffset_CompareTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601D952 RID: 121170 RVA: 0x002BADAC File Offset: 0x002B8FAC
		public FKSC_TagFilter()
		{
		}

		// Token: 0x0601D953 RID: 121171 RVA: 0x002BADB4 File Offset: 0x002B8FB4
		public FKSC_TagFilter(bool IsNot, bool CompareHasAll, FGameplayTagContainer CompareTags)
		{
			this.IsNot = IsNot;
			this.CompareHasAll = CompareHasAll;
			this.CompareTags = CompareTags;
		}

		// Token: 0x0601D954 RID: 121172 RVA: 0x002BADD1 File Offset: 0x002B8FD1
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_TagFilter.StaticStruct();
		}

		// Token: 0x0601D955 RID: 121173 RVA: 0x002BADDD File Offset: 0x002B8FDD
		[NullableContext(2)]
		public FKSC_TagFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D956 RID: 121174 RVA: 0x002BADE7 File Offset: 0x002B8FE7
		public FKSC_TagFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D957 RID: 121175 RVA: 0x002BADF2 File Offset: 0x002B8FF2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_TagFilter(Pointer, false, true);
		}

		// Token: 0x0601D958 RID: 121176 RVA: 0x002BADFC File Offset: 0x002B8FFC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_TagFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04010092 RID: 65682
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_TagFilter";

		// Token: 0x04010093 RID: 65683
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010094 RID: 65684
		internal static int __PropertyOffset_IsNot;

		// Token: 0x04010095 RID: 65685
		internal static int __PropertyOffset_CompareHasAll;

		// Token: 0x04010096 RID: 65686
		internal static int __PropertyOffset_CompareTags;

		// Token: 0x04010097 RID: 65687
		[Nullable(2)]
		private FGameplayTagContainer _CompareTags;
	}
}
