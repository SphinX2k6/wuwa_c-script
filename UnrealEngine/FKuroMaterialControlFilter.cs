using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B38 RID: 6968
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControlFilter")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FKuroMaterialControlFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A550 RID: 107856 RVA: 0x0026D9F8 File Offset: 0x0026BBF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControlFilter._ScriptStructPtr != 0) ? FKuroMaterialControlFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControlFilter", ref FKuroMaterialControlFilter._ScriptStructPtr);
		}

		// Token: 0x17006A00 RID: 27136
		// (get) Token: 0x0601A551 RID: 107857 RVA: 0x0026DA1C File Offset: 0x0026BC1C
		// (set) Token: 0x0601A552 RID: 107858 RVA: 0x0026DA2C File Offset: 0x0026BC2C
		public unsafe EKuroCharBodySpecifiedType BodySpecifiedType
		{
			get
			{
				return (EKuroCharBodySpecifiedType)(*(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_BodySpecifiedType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_BodySpecifiedType) = (byte)value;
			}
		}

		// Token: 0x17006A01 RID: 27137
		// (get) Token: 0x0601A553 RID: 107859 RVA: 0x0026DA3D File Offset: 0x0026BC3D
		// (set) Token: 0x0601A554 RID: 107860 RVA: 0x0026DA4D File Offset: 0x0026BC4D
		public unsafe EKuroCharSlotSpecifiedType SlotSpecifiedType
		{
			get
			{
				return (EKuroCharSlotSpecifiedType)(*(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_SlotSpecifiedType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_SlotSpecifiedType) = (byte)value;
			}
		}

		// Token: 0x17006A02 RID: 27138
		// (get) Token: 0x0601A555 RID: 107861 RVA: 0x0026DA60 File Offset: 0x0026BC60
		// (set) Token: 0x0601A556 RID: 107862 RVA: 0x0026DAA3 File Offset: 0x0026BCA3
		public TArray<FName> WeaponCases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._WeaponCases) == null)
				{
					result = (this._WeaponCases = new TArray<FName>(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_WeaponCases, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WeaponCases.CopyAssign(value);
			}
		}

		// Token: 0x17006A03 RID: 27139
		// (get) Token: 0x0601A557 RID: 107863 RVA: 0x0026DAB4 File Offset: 0x0026BCB4
		// (set) Token: 0x0601A558 RID: 107864 RVA: 0x0026DAF7 File Offset: 0x0026BCF7
		public TArray<FName> OtherCases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._OtherCases) == null)
				{
					result = (this._OtherCases = new TArray<FName>(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_OtherCases, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OtherCases.CopyAssign(value);
			}
		}

		// Token: 0x17006A04 RID: 27140
		// (get) Token: 0x0601A559 RID: 107865 RVA: 0x0026DB08 File Offset: 0x0026BD08
		// (set) Token: 0x0601A55A RID: 107866 RVA: 0x0026DB4B File Offset: 0x0026BD4B
		public TArray<FName> ExtraBodyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ExtraBodyNames) == null)
				{
					result = (this._ExtraBodyNames = new TArray<FName>(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_ExtraBodyNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExtraBodyNames.CopyAssign(value);
			}
		}

		// Token: 0x17006A05 RID: 27141
		// (get) Token: 0x0601A55B RID: 107867 RVA: 0x0026DB59 File Offset: 0x0026BD59
		// (set) Token: 0x0601A55C RID: 107868 RVA: 0x0026DB69 File Offset: 0x0026BD69
		public unsafe bool AlwaysApplyToExtraBodies
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_AlwaysApplyToExtraBodies) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_AlwaysApplyToExtraBodies) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A06 RID: 27142
		// (get) Token: 0x0601A55D RID: 107869 RVA: 0x0026DB7C File Offset: 0x0026BD7C
		// (set) Token: 0x0601A55E RID: 107870 RVA: 0x0026DBBF File Offset: 0x0026BDBF
		public TArray<EKuroCharMeshPart> SpecifiedParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKuroCharMeshPart> result;
				if ((result = this._SpecifiedParts) == null)
				{
					result = (this._SpecifiedParts = new TArray<EKuroCharMeshPart>(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_SpecifiedParts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecifiedParts.CopyAssign(value);
			}
		}

		// Token: 0x17006A07 RID: 27143
		// (get) Token: 0x0601A55F RID: 107871 RVA: 0x0026DBD0 File Offset: 0x0026BDD0
		// (set) Token: 0x0601A560 RID: 107872 RVA: 0x0026DC13 File Offset: 0x0026BE13
		public TArray<string> CustomParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomParts) == null)
				{
					result = (this._CustomParts = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_CustomParts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomParts.CopyAssign(value);
			}
		}

		// Token: 0x17006A08 RID: 27144
		// (get) Token: 0x0601A561 RID: 107873 RVA: 0x0026DC24 File Offset: 0x0026BE24
		// (set) Token: 0x0601A562 RID: 107874 RVA: 0x0026DC67 File Offset: 0x0026BE67
		public TArray<string> CustomExcludeParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomExcludeParts) == null)
				{
					result = (this._CustomExcludeParts = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialControlFilter.__PropertyOffset_CustomExcludeParts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomExcludeParts.CopyAssign(value);
			}
		}

		// Token: 0x0601A563 RID: 107875 RVA: 0x0026DC75 File Offset: 0x0026BE75
		public FKuroMaterialControlFilter()
		{
		}

		// Token: 0x0601A564 RID: 107876 RVA: 0x0026DC80 File Offset: 0x0026BE80
		public FKuroMaterialControlFilter(EKuroCharBodySpecifiedType BodySpecifiedType, EKuroCharSlotSpecifiedType SlotSpecifiedType, TArray<FName> WeaponCases, TArray<FName> OtherCases, TArray<FName> ExtraBodyNames, bool AlwaysApplyToExtraBodies, TArray<EKuroCharMeshPart> SpecifiedParts, TArray<string> CustomParts, TArray<string> CustomExcludeParts)
		{
			this.BodySpecifiedType = BodySpecifiedType;
			this.SlotSpecifiedType = SlotSpecifiedType;
			this.WeaponCases = WeaponCases;
			this.OtherCases = OtherCases;
			this.ExtraBodyNames = ExtraBodyNames;
			this.AlwaysApplyToExtraBodies = AlwaysApplyToExtraBodies;
			this.SpecifiedParts = SpecifiedParts;
			this.CustomParts = CustomParts;
			this.CustomExcludeParts = CustomExcludeParts;
		}

		// Token: 0x0601A565 RID: 107877 RVA: 0x0026DCD8 File Offset: 0x0026BED8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControlFilter.StaticStruct();
		}

		// Token: 0x0601A566 RID: 107878 RVA: 0x0026DCE4 File Offset: 0x0026BEE4
		[NullableContext(2)]
		public FKuroMaterialControlFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A567 RID: 107879 RVA: 0x0026DCEE File Offset: 0x0026BEEE
		public FKuroMaterialControlFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A568 RID: 107880 RVA: 0x0026DCF9 File Offset: 0x0026BEF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControlFilter(Pointer, false, true);
		}

		// Token: 0x0601A569 RID: 107881 RVA: 0x0026DD03 File Offset: 0x0026BF03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControlFilter(Pointer, MemoryOwner);
		}

		// Token: 0x0400E4A6 RID: 58534
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControlFilter";

		// Token: 0x0400E4A7 RID: 58535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E4A8 RID: 58536
		internal static int __PropertyOffset_BodySpecifiedType;

		// Token: 0x0400E4A9 RID: 58537
		internal static int __PropertyOffset_SlotSpecifiedType;

		// Token: 0x0400E4AA RID: 58538
		internal static int __PropertyOffset_WeaponCases;

		// Token: 0x0400E4AB RID: 58539
		[Nullable(2)]
		private TArray<FName> _WeaponCases;

		// Token: 0x0400E4AC RID: 58540
		internal static int __PropertyOffset_OtherCases;

		// Token: 0x0400E4AD RID: 58541
		[Nullable(2)]
		private TArray<FName> _OtherCases;

		// Token: 0x0400E4AE RID: 58542
		internal static int __PropertyOffset_ExtraBodyNames;

		// Token: 0x0400E4AF RID: 58543
		[Nullable(2)]
		private TArray<FName> _ExtraBodyNames;

		// Token: 0x0400E4B0 RID: 58544
		internal static int __PropertyOffset_AlwaysApplyToExtraBodies;

		// Token: 0x0400E4B1 RID: 58545
		internal static int __PropertyOffset_SpecifiedParts;

		// Token: 0x0400E4B2 RID: 58546
		[Nullable(2)]
		private TArray<EKuroCharMeshPart> _SpecifiedParts;

		// Token: 0x0400E4B3 RID: 58547
		internal static int __PropertyOffset_CustomParts;

		// Token: 0x0400E4B4 RID: 58548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomParts;

		// Token: 0x0400E4B5 RID: 58549
		internal static int __PropertyOffset_CustomExcludeParts;

		// Token: 0x0400E4B6 RID: 58550
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomExcludeParts;
	}
}
