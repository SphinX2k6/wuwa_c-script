using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003A9 RID: 937
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageViewData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FDamageViewData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CCD RID: 23757 RVA: 0x00082A77 File Offset: 0x00080C77
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageViewData._ScriptStructPtr != 0) ? FDamageViewData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.DamageViewData", ref FDamageViewData._ScriptStructPtr);
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06005CCE RID: 23758 RVA: 0x00082A9B File Offset: 0x00080C9B
		// (set) Token: 0x06005CCF RID: 23759 RVA: 0x00082AAB File Offset: 0x00080CAB
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_ConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_ConfigId) = value;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06005CD0 RID: 23760 RVA: 0x00082ABC File Offset: 0x00080CBC
		// (set) Token: 0x06005CD1 RID: 23761 RVA: 0x00082ACC File Offset: 0x00080CCC
		public unsafe int MinRandomOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MinRandomOffsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MinRandomOffsetX) = value;
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06005CD2 RID: 23762 RVA: 0x00082ADD File Offset: 0x00080CDD
		// (set) Token: 0x06005CD3 RID: 23763 RVA: 0x00082AED File Offset: 0x00080CED
		public unsafe int MinRandomOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MinRandomOffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MinRandomOffsetY) = value;
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06005CD4 RID: 23764 RVA: 0x00082AFE File Offset: 0x00080CFE
		// (set) Token: 0x06005CD5 RID: 23765 RVA: 0x00082B0E File Offset: 0x00080D0E
		public unsafe int MaxRandomOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MaxRandomOffsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MaxRandomOffsetX) = value;
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06005CD6 RID: 23766 RVA: 0x00082B1F File Offset: 0x00080D1F
		// (set) Token: 0x06005CD7 RID: 23767 RVA: 0x00082B2F File Offset: 0x00080D2F
		public unsafe int MaxRandomOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MaxRandomOffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MaxRandomOffsetY) = value;
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06005CD8 RID: 23768 RVA: 0x00082B40 File Offset: 0x00080D40
		// (set) Token: 0x06005CD9 RID: 23769 RVA: 0x00082B54 File Offset: 0x00080D54
		public unsafe FColor TextColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_TextColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_TextColor) = value;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06005CDA RID: 23770 RVA: 0x00082B69 File Offset: 0x00080D69
		// (set) Token: 0x06005CDB RID: 23771 RVA: 0x00082B7D File Offset: 0x00080D7D
		public unsafe FColor CritTextColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_CritTextColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_CritTextColor) = value;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06005CDC RID: 23772 RVA: 0x00082B92 File Offset: 0x00080D92
		// (set) Token: 0x06005CDD RID: 23773 RVA: 0x00082BA6 File Offset: 0x00080DA6
		public unsafe FColor OutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_OutlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_OutlineColor) = value;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x00082BBB File Offset: 0x00080DBB
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x00082BCF File Offset: 0x00080DCF
		public unsafe FColor CritOutlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_CritOutlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_CritOutlineColor) = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x00082BE4 File Offset: 0x00080DE4
		// (set) Token: 0x06005CE1 RID: 23777 RVA: 0x00082BF4 File Offset: 0x00080DF4
		public unsafe int CritNiagaraType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_CritNiagaraType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_CritNiagaraType) = value;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06005CE2 RID: 23778 RVA: 0x00082C05 File Offset: 0x00080E05
		// (set) Token: 0x06005CE3 RID: 23779 RVA: 0x00082C15 File Offset: 0x00080E15
		public unsafe int OwnDamageAnimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_OwnDamageAnimType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_OwnDamageAnimType) = value;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06005CE4 RID: 23780 RVA: 0x00082C26 File Offset: 0x00080E26
		// (set) Token: 0x06005CE5 RID: 23781 RVA: 0x00082C36 File Offset: 0x00080E36
		public unsafe int OwnCritDamageAnimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_OwnCritDamageAnimType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_OwnCritDamageAnimType) = value;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x00082C47 File Offset: 0x00080E47
		// (set) Token: 0x06005CE7 RID: 23783 RVA: 0x00082C57 File Offset: 0x00080E57
		public unsafe int MonsterDamageAnimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MonsterDamageAnimType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MonsterDamageAnimType) = value;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x00082C68 File Offset: 0x00080E68
		// (set) Token: 0x06005CE9 RID: 23785 RVA: 0x00082C78 File Offset: 0x00080E78
		public unsafe int MonsterCritDamageAnimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MonsterCritDamageAnimType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_MonsterCritDamageAnimType) = value;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x00082C89 File Offset: 0x00080E89
		// (set) Token: 0x06005CEB RID: 23787 RVA: 0x00082C99 File Offset: 0x00080E99
		public unsafe int TextDamageAnimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_TextDamageAnimType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_TextDamageAnimType) = value;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x00082CAA File Offset: 0x00080EAA
		// (set) Token: 0x06005CED RID: 23789 RVA: 0x00082CBE File Offset: 0x00080EBE
		public unsafe string IconPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDamageViewData.__PropertyOffset_IconPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDamageViewData.__PropertyOffset_IconPath)), value);
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x00082CD3 File Offset: 0x00080ED3
		// (set) Token: 0x06005CEF RID: 23791 RVA: 0x00082CE3 File Offset: 0x00080EE3
		public unsafe float IconScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_IconScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageViewData.__PropertyOffset_IconScale) = value;
			}
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x00082CF4 File Offset: 0x00080EF4
		public FDamageViewData()
		{
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x00082CFC File Offset: 0x00080EFC
		protected override IntPtr GetUStructPtr()
		{
			return FDamageViewData.StaticStruct();
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x00082D08 File Offset: 0x00080F08
		[NullableContext(2)]
		public FDamageViewData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x00082D12 File Offset: 0x00080F12
		public FDamageViewData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x00082D1D File Offset: 0x00080F1D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageViewData(Pointer, false, true);
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x00082D27 File Offset: 0x00080F27
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageViewData(Pointer, MemoryOwner);
		}

		// Token: 0x040026AC RID: 9900
		public const string __ObjectPath = "/Script/KuroGameplayUI.DamageViewData";

		// Token: 0x040026AD RID: 9901
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026AE RID: 9902
		internal static int __PropertyOffset_ConfigId;

		// Token: 0x040026AF RID: 9903
		internal static int __PropertyOffset_MinRandomOffsetX;

		// Token: 0x040026B0 RID: 9904
		internal static int __PropertyOffset_MinRandomOffsetY;

		// Token: 0x040026B1 RID: 9905
		internal static int __PropertyOffset_MaxRandomOffsetX;

		// Token: 0x040026B2 RID: 9906
		internal static int __PropertyOffset_MaxRandomOffsetY;

		// Token: 0x040026B3 RID: 9907
		internal static int __PropertyOffset_TextColor;

		// Token: 0x040026B4 RID: 9908
		internal static int __PropertyOffset_CritTextColor;

		// Token: 0x040026B5 RID: 9909
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x040026B6 RID: 9910
		internal static int __PropertyOffset_CritOutlineColor;

		// Token: 0x040026B7 RID: 9911
		internal static int __PropertyOffset_CritNiagaraType;

		// Token: 0x040026B8 RID: 9912
		internal static int __PropertyOffset_OwnDamageAnimType;

		// Token: 0x040026B9 RID: 9913
		internal static int __PropertyOffset_OwnCritDamageAnimType;

		// Token: 0x040026BA RID: 9914
		internal static int __PropertyOffset_MonsterDamageAnimType;

		// Token: 0x040026BB RID: 9915
		internal static int __PropertyOffset_MonsterCritDamageAnimType;

		// Token: 0x040026BC RID: 9916
		internal static int __PropertyOffset_TextDamageAnimType;

		// Token: 0x040026BD RID: 9917
		internal static int __PropertyOffset_IconPath;

		// Token: 0x040026BE RID: 9918
		internal static int __PropertyOffset_IconScale;
	}
}
