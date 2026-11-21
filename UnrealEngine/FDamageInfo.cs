using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003A7 RID: 935
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FDamageInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C90 RID: 23696 RVA: 0x00082644 File Offset: 0x00080844
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageInfo._ScriptStructPtr != 0) ? FDamageInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.DamageInfo", ref FDamageInfo._ScriptStructPtr);
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06005C91 RID: 23697 RVA: 0x00082668 File Offset: 0x00080868
		// (set) Token: 0x06005C92 RID: 23698 RVA: 0x00082678 File Offset: 0x00080878
		public unsafe int Damage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_Damage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_Damage) = value;
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06005C93 RID: 23699 RVA: 0x00082689 File Offset: 0x00080889
		// (set) Token: 0x06005C94 RID: 23700 RVA: 0x00082699 File Offset: 0x00080899
		public unsafe int DamageConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_DamageConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_DamageConfigId) = value;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06005C95 RID: 23701 RVA: 0x000826AA File Offset: 0x000808AA
		// (set) Token: 0x06005C96 RID: 23702 RVA: 0x000826BE File Offset: 0x000808BE
		public unsafe FVectorDouble DamagePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_DamagePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_DamagePosition) = value;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06005C97 RID: 23703 RVA: 0x000826D3 File Offset: 0x000808D3
		// (set) Token: 0x06005C98 RID: 23704 RVA: 0x000826E3 File Offset: 0x000808E3
		public unsafe bool bOwnPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bOwnPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bOwnPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06005C99 RID: 23705 RVA: 0x000826F4 File Offset: 0x000808F4
		// (set) Token: 0x06005C9A RID: 23706 RVA: 0x00082704 File Offset: 0x00080904
		public unsafe bool bCrit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bCrit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bCrit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06005C9B RID: 23707 RVA: 0x00082715 File Offset: 0x00080915
		// (set) Token: 0x06005C9C RID: 23708 RVA: 0x00082725 File Offset: 0x00080925
		public unsafe bool bCure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bCure) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bCure) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x00082736 File Offset: 0x00080936
		// (set) Token: 0x06005C9E RID: 23710 RVA: 0x0008274A File Offset: 0x0008094A
		public unsafe string DamageText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDamageInfo.__PropertyOffset_DamageText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDamageInfo.__PropertyOffset_DamageText)), value);
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06005C9F RID: 23711 RVA: 0x0008275F File Offset: 0x0008095F
		// (set) Token: 0x06005CA0 RID: 23712 RVA: 0x0008276F File Offset: 0x0008096F
		public unsafe float ExpiredTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_ExpiredTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_ExpiredTime) = value;
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06005CA1 RID: 23713 RVA: 0x00082780 File Offset: 0x00080980
		// (set) Token: 0x06005CA2 RID: 23714 RVA: 0x00082790 File Offset: 0x00080990
		public unsafe bool bUseLGUIPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bUseLGUIPos) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_bUseLGUIPos) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06005CA3 RID: 23715 RVA: 0x000827A1 File Offset: 0x000809A1
		// (set) Token: 0x06005CA4 RID: 23716 RVA: 0x000827B5 File Offset: 0x000809B5
		public unsafe FVector2D LGUIPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_LGUIPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageInfo.__PropertyOffset_LGUIPos) = value;
			}
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x000827CA File Offset: 0x000809CA
		public FDamageInfo()
		{
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x000827D2 File Offset: 0x000809D2
		protected override IntPtr GetUStructPtr()
		{
			return FDamageInfo.StaticStruct();
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x000827DE File Offset: 0x000809DE
		[NullableContext(2)]
		public FDamageInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x000827E8 File Offset: 0x000809E8
		public FDamageInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x000827F3 File Offset: 0x000809F3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageInfo(Pointer, false, true);
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x000827FD File Offset: 0x000809FD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04002698 RID: 9880
		public const string __ObjectPath = "/Script/KuroGameplayUI.DamageInfo";

		// Token: 0x04002699 RID: 9881
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400269A RID: 9882
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400269B RID: 9883
		internal static int __PropertyOffset_DamageConfigId;

		// Token: 0x0400269C RID: 9884
		internal static int __PropertyOffset_DamagePosition;

		// Token: 0x0400269D RID: 9885
		internal static int __PropertyOffset_bOwnPlayer;

		// Token: 0x0400269E RID: 9886
		internal static int __PropertyOffset_bCrit;

		// Token: 0x0400269F RID: 9887
		internal static int __PropertyOffset_bCure;

		// Token: 0x040026A0 RID: 9888
		internal static int __PropertyOffset_DamageText;

		// Token: 0x040026A1 RID: 9889
		internal static int __PropertyOffset_ExpiredTime;

		// Token: 0x040026A2 RID: 9890
		internal static int __PropertyOffset_bUseLGUIPos;

		// Token: 0x040026A3 RID: 9891
		internal static int __PropertyOffset_LGUIPos;
	}
}
