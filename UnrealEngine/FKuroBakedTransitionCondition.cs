using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE2 RID: 3298
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroBakedTransitionCondition")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroBakedTransitionCondition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AEE5 RID: 44773 RVA: 0x000F8208 File Offset: 0x000F6408
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBakedTransitionCondition._ScriptStructPtr != 0) ? FKuroBakedTransitionCondition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroBakedTransitionCondition", ref FKuroBakedTransitionCondition._ScriptStructPtr);
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x000F822C File Offset: 0x000F642C
		// (set) Token: 0x0600AEE7 RID: 44775 RVA: 0x000F823C File Offset: 0x000F643C
		public unsafe EKuroBakedTransitionCondType Type
		{
			get
			{
				return (EKuroBakedTransitionCondType)(*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x0600AEE8 RID: 44776 RVA: 0x000F824D File Offset: 0x000F644D
		// (set) Token: 0x0600AEE9 RID: 44777 RVA: 0x000F8261 File Offset: 0x000F6461
		public unsafe FName PropertyPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_PropertyPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_PropertyPath) = value;
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x0600AEEA RID: 44778 RVA: 0x000F8276 File Offset: 0x000F6476
		// (set) Token: 0x0600AEEB RID: 44779 RVA: 0x000F8286 File Offset: 0x000F6486
		public unsafe bool bValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_bValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_bValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x0600AEEC RID: 44780 RVA: 0x000F8297 File Offset: 0x000F6497
		// (set) Token: 0x0600AEED RID: 44781 RVA: 0x000F82A7 File Offset: 0x000F64A7
		public unsafe EKuroTransitionCondEnumOp EnumOp
		{
			get
			{
				return (EKuroTransitionCondEnumOp)(*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_EnumOp));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_EnumOp) = (byte)value;
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x0600AEEE RID: 44782 RVA: 0x000F82B8 File Offset: 0x000F64B8
		// (set) Token: 0x0600AEEF RID: 44783 RVA: 0x000F82C8 File Offset: 0x000F64C8
		public unsafe long EnumValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_EnumValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_EnumValue) = value;
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600AEF0 RID: 44784 RVA: 0x000F82D9 File Offset: 0x000F64D9
		// (set) Token: 0x0600AEF1 RID: 44785 RVA: 0x000F82ED File Offset: 0x000F64ED
		public unsafe FName MachineName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_MachineName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_MachineName) = value;
			}
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x0600AEF2 RID: 44786 RVA: 0x000F8302 File Offset: 0x000F6502
		// (set) Token: 0x0600AEF3 RID: 44787 RVA: 0x000F8312 File Offset: 0x000F6512
		public unsafe EKuroTransitionCondGroupOp GroupOp
		{
			get
			{
				return (EKuroTransitionCondGroupOp)(*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_GroupOp));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_GroupOp) = (byte)value;
			}
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600AEF4 RID: 44788 RVA: 0x000F8323 File Offset: 0x000F6523
		// (set) Token: 0x0600AEF5 RID: 44789 RVA: 0x000F8333 File Offset: 0x000F6533
		public unsafe EKuroRelevantAnimParam RelevantParam
		{
			get
			{
				return (EKuroRelevantAnimParam)(*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_RelevantParam));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_RelevantParam) = (byte)value;
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x0600AEF6 RID: 44790 RVA: 0x000F8344 File Offset: 0x000F6544
		// (set) Token: 0x0600AEF7 RID: 44791 RVA: 0x000F8354 File Offset: 0x000F6554
		public unsafe EKuroTransitionCondFloatOp FloatOp
		{
			get
			{
				return (EKuroTransitionCondFloatOp)(*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_FloatOp));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_FloatOp) = (byte)value;
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x000F8365 File Offset: 0x000F6565
		// (set) Token: 0x0600AEF9 RID: 44793 RVA: 0x000F8375 File Offset: 0x000F6575
		public unsafe float CompareValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_CompareValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_CompareValue) = value;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x000F8386 File Offset: 0x000F6586
		// (set) Token: 0x0600AEFB RID: 44795 RVA: 0x000F8396 File Offset: 0x000F6596
		public unsafe bool bRelevantUseCurrentSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_bRelevantUseCurrentSource) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_bRelevantUseCurrentSource) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x000F83A8 File Offset: 0x000F65A8
		// (set) Token: 0x0600AEFD RID: 44797 RVA: 0x000F83EB File Offset: 0x000F65EB
		public TArray<int> ChildIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ChildIndices) == null)
				{
					result = (this._ChildIndices = new TArray<int>(base.NativePtr + (IntPtr)FKuroBakedTransitionCondition.__PropertyOffset_ChildIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildIndices.CopyAssign(value);
			}
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x000F83F9 File Offset: 0x000F65F9
		public FKuroBakedTransitionCondition()
		{
		}

		// Token: 0x0600AEFF RID: 44799 RVA: 0x000F8404 File Offset: 0x000F6604
		public FKuroBakedTransitionCondition(EKuroBakedTransitionCondType Type, FName PropertyPath, bool bValue, EKuroTransitionCondEnumOp EnumOp, long EnumValue, FName MachineName, EKuroTransitionCondGroupOp GroupOp, EKuroRelevantAnimParam RelevantParam, EKuroTransitionCondFloatOp FloatOp, float CompareValue, bool bRelevantUseCurrentSource, TArray<int> ChildIndices)
		{
			this.Type = Type;
			this.PropertyPath = PropertyPath;
			this.bValue = bValue;
			this.EnumOp = EnumOp;
			this.EnumValue = EnumValue;
			this.MachineName = MachineName;
			this.GroupOp = GroupOp;
			this.RelevantParam = RelevantParam;
			this.FloatOp = FloatOp;
			this.CompareValue = CompareValue;
			this.bRelevantUseCurrentSource = bRelevantUseCurrentSource;
			this.ChildIndices = ChildIndices;
		}

		// Token: 0x0600AF00 RID: 44800 RVA: 0x000F8474 File Offset: 0x000F6674
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBakedTransitionCondition.StaticStruct();
		}

		// Token: 0x0600AF01 RID: 44801 RVA: 0x000F8480 File Offset: 0x000F6680
		[NullableContext(2)]
		public FKuroBakedTransitionCondition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x000F848A File Offset: 0x000F668A
		public FKuroBakedTransitionCondition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x000F8495 File Offset: 0x000F6695
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBakedTransitionCondition(Pointer, false, true);
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x000F849F File Offset: 0x000F669F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBakedTransitionCondition(Pointer, MemoryOwner);
		}

		// Token: 0x04005B9D RID: 23453
		public const string __ObjectPath = "/Script/Engine.KuroBakedTransitionCondition";

		// Token: 0x04005B9E RID: 23454
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B9F RID: 23455
		internal static int __PropertyOffset_Type;

		// Token: 0x04005BA0 RID: 23456
		internal static int __PropertyOffset_PropertyPath;

		// Token: 0x04005BA1 RID: 23457
		internal static int __PropertyOffset_bValue;

		// Token: 0x04005BA2 RID: 23458
		internal static int __PropertyOffset_EnumOp;

		// Token: 0x04005BA3 RID: 23459
		internal static int __PropertyOffset_EnumValue;

		// Token: 0x04005BA4 RID: 23460
		internal static int __PropertyOffset_MachineName;

		// Token: 0x04005BA5 RID: 23461
		internal static int __PropertyOffset_GroupOp;

		// Token: 0x04005BA6 RID: 23462
		internal static int __PropertyOffset_RelevantParam;

		// Token: 0x04005BA7 RID: 23463
		internal static int __PropertyOffset_FloatOp;

		// Token: 0x04005BA8 RID: 23464
		internal static int __PropertyOffset_CompareValue;

		// Token: 0x04005BA9 RID: 23465
		internal static int __PropertyOffset_bRelevantUseCurrentSource;

		// Token: 0x04005BAA RID: 23466
		internal static int __PropertyOffset_ChildIndices;

		// Token: 0x04005BAB RID: 23467
		[Nullable(2)]
		private TArray<int> _ChildIndices;
	}
}
