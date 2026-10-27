using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001881 RID: 6273
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageViewData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FDamageViewData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060171D8 RID: 94680 RVA: 0x0021AF0F File Offset: 0x0021910F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageViewData._ScriptStructPtr != 0) ? FDamageViewData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.DamageViewData", ref FDamageViewData._ScriptStructPtr);
		}

		// Token: 0x17005CFD RID: 23805
		// (get) Token: 0x060171D9 RID: 94681 RVA: 0x0021AF33 File Offset: 0x00219133
		// (set) Token: 0x060171DA RID: 94682 RVA: 0x0021AF43 File Offset: 0x00219143
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

		// Token: 0x17005CFE RID: 23806
		// (get) Token: 0x060171DB RID: 94683 RVA: 0x0021AF54 File Offset: 0x00219154
		// (set) Token: 0x060171DC RID: 94684 RVA: 0x0021AF64 File Offset: 0x00219164
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

		// Token: 0x17005CFF RID: 23807
		// (get) Token: 0x060171DD RID: 94685 RVA: 0x0021AF75 File Offset: 0x00219175
		// (set) Token: 0x060171DE RID: 94686 RVA: 0x0021AF85 File Offset: 0x00219185
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

		// Token: 0x17005D00 RID: 23808
		// (get) Token: 0x060171DF RID: 94687 RVA: 0x0021AF96 File Offset: 0x00219196
		// (set) Token: 0x060171E0 RID: 94688 RVA: 0x0021AFA6 File Offset: 0x002191A6
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

		// Token: 0x17005D01 RID: 23809
		// (get) Token: 0x060171E1 RID: 94689 RVA: 0x0021AFB7 File Offset: 0x002191B7
		// (set) Token: 0x060171E2 RID: 94690 RVA: 0x0021AFC7 File Offset: 0x002191C7
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

		// Token: 0x17005D02 RID: 23810
		// (get) Token: 0x060171E3 RID: 94691 RVA: 0x0021AFD8 File Offset: 0x002191D8
		// (set) Token: 0x060171E4 RID: 94692 RVA: 0x0021AFEC File Offset: 0x002191EC
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

		// Token: 0x17005D03 RID: 23811
		// (get) Token: 0x060171E5 RID: 94693 RVA: 0x0021B001 File Offset: 0x00219201
		// (set) Token: 0x060171E6 RID: 94694 RVA: 0x0021B015 File Offset: 0x00219215
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

		// Token: 0x17005D04 RID: 23812
		// (get) Token: 0x060171E7 RID: 94695 RVA: 0x0021B02A File Offset: 0x0021922A
		// (set) Token: 0x060171E8 RID: 94696 RVA: 0x0021B03E File Offset: 0x0021923E
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

		// Token: 0x17005D05 RID: 23813
		// (get) Token: 0x060171E9 RID: 94697 RVA: 0x0021B053 File Offset: 0x00219253
		// (set) Token: 0x060171EA RID: 94698 RVA: 0x0021B067 File Offset: 0x00219267
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

		// Token: 0x17005D06 RID: 23814
		// (get) Token: 0x060171EB RID: 94699 RVA: 0x0021B07C File Offset: 0x0021927C
		// (set) Token: 0x060171EC RID: 94700 RVA: 0x0021B08C File Offset: 0x0021928C
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

		// Token: 0x17005D07 RID: 23815
		// (get) Token: 0x060171ED RID: 94701 RVA: 0x0021B09D File Offset: 0x0021929D
		// (set) Token: 0x060171EE RID: 94702 RVA: 0x0021B0AD File Offset: 0x002192AD
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

		// Token: 0x17005D08 RID: 23816
		// (get) Token: 0x060171EF RID: 94703 RVA: 0x0021B0BE File Offset: 0x002192BE
		// (set) Token: 0x060171F0 RID: 94704 RVA: 0x0021B0CE File Offset: 0x002192CE
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

		// Token: 0x17005D09 RID: 23817
		// (get) Token: 0x060171F1 RID: 94705 RVA: 0x0021B0DF File Offset: 0x002192DF
		// (set) Token: 0x060171F2 RID: 94706 RVA: 0x0021B0EF File Offset: 0x002192EF
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

		// Token: 0x17005D0A RID: 23818
		// (get) Token: 0x060171F3 RID: 94707 RVA: 0x0021B100 File Offset: 0x00219300
		// (set) Token: 0x060171F4 RID: 94708 RVA: 0x0021B110 File Offset: 0x00219310
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

		// Token: 0x17005D0B RID: 23819
		// (get) Token: 0x060171F5 RID: 94709 RVA: 0x0021B121 File Offset: 0x00219321
		// (set) Token: 0x060171F6 RID: 94710 RVA: 0x0021B131 File Offset: 0x00219331
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

		// Token: 0x17005D0C RID: 23820
		// (get) Token: 0x060171F7 RID: 94711 RVA: 0x0021B142 File Offset: 0x00219342
		// (set) Token: 0x060171F8 RID: 94712 RVA: 0x0021B156 File Offset: 0x00219356
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

		// Token: 0x17005D0D RID: 23821
		// (get) Token: 0x060171F9 RID: 94713 RVA: 0x0021B16B File Offset: 0x0021936B
		// (set) Token: 0x060171FA RID: 94714 RVA: 0x0021B17B File Offset: 0x0021937B
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

		// Token: 0x060171FB RID: 94715 RVA: 0x0021B18C File Offset: 0x0021938C
		public FDamageViewData()
		{
		}

		// Token: 0x060171FC RID: 94716 RVA: 0x0021B194 File Offset: 0x00219394
		public FDamageViewData(int ConfigId, int MinRandomOffsetX, int MinRandomOffsetY, int MaxRandomOffsetX, int MaxRandomOffsetY, FColor TextColor, FColor CritTextColor, FColor OutlineColor, FColor CritOutlineColor, int CritNiagaraType, int OwnDamageAnimType, int OwnCritDamageAnimType, int MonsterDamageAnimType, int MonsterCritDamageAnimType, int TextDamageAnimType, string IconPath, float IconScale)
		{
			this.ConfigId = ConfigId;
			this.MinRandomOffsetX = MinRandomOffsetX;
			this.MinRandomOffsetY = MinRandomOffsetY;
			this.MaxRandomOffsetX = MaxRandomOffsetX;
			this.MaxRandomOffsetY = MaxRandomOffsetY;
			this.TextColor = TextColor;
			this.CritTextColor = CritTextColor;
			this.OutlineColor = OutlineColor;
			this.CritOutlineColor = CritOutlineColor;
			this.CritNiagaraType = CritNiagaraType;
			this.OwnDamageAnimType = OwnDamageAnimType;
			this.OwnCritDamageAnimType = OwnCritDamageAnimType;
			this.MonsterDamageAnimType = MonsterDamageAnimType;
			this.MonsterCritDamageAnimType = MonsterCritDamageAnimType;
			this.TextDamageAnimType = TextDamageAnimType;
			this.IconPath = IconPath;
			this.IconScale = IconScale;
		}

		// Token: 0x060171FD RID: 94717 RVA: 0x0021B22C File Offset: 0x0021942C
		protected override IntPtr GetUStructPtr()
		{
			return FDamageViewData.StaticStruct();
		}

		// Token: 0x060171FE RID: 94718 RVA: 0x0021B238 File Offset: 0x00219438
		[NullableContext(2)]
		public FDamageViewData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060171FF RID: 94719 RVA: 0x0021B242 File Offset: 0x00219442
		public FDamageViewData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017200 RID: 94720 RVA: 0x0021B24D File Offset: 0x0021944D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageViewData(Pointer, false, true);
		}

		// Token: 0x06017201 RID: 94721 RVA: 0x0021B257 File Offset: 0x00219457
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageViewData(Pointer, MemoryOwner);
		}

		// Token: 0x0400C89D RID: 51357
		public const string __ObjectPath = "/Script/KuroGameplayUI.DamageViewData";

		// Token: 0x0400C89E RID: 51358
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C89F RID: 51359
		internal static int __PropertyOffset_ConfigId;

		// Token: 0x0400C8A0 RID: 51360
		internal static int __PropertyOffset_MinRandomOffsetX;

		// Token: 0x0400C8A1 RID: 51361
		internal static int __PropertyOffset_MinRandomOffsetY;

		// Token: 0x0400C8A2 RID: 51362
		internal static int __PropertyOffset_MaxRandomOffsetX;

		// Token: 0x0400C8A3 RID: 51363
		internal static int __PropertyOffset_MaxRandomOffsetY;

		// Token: 0x0400C8A4 RID: 51364
		internal static int __PropertyOffset_TextColor;

		// Token: 0x0400C8A5 RID: 51365
		internal static int __PropertyOffset_CritTextColor;

		// Token: 0x0400C8A6 RID: 51366
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x0400C8A7 RID: 51367
		internal static int __PropertyOffset_CritOutlineColor;

		// Token: 0x0400C8A8 RID: 51368
		internal static int __PropertyOffset_CritNiagaraType;

		// Token: 0x0400C8A9 RID: 51369
		internal static int __PropertyOffset_OwnDamageAnimType;

		// Token: 0x0400C8AA RID: 51370
		internal static int __PropertyOffset_OwnCritDamageAnimType;

		// Token: 0x0400C8AB RID: 51371
		internal static int __PropertyOffset_MonsterDamageAnimType;

		// Token: 0x0400C8AC RID: 51372
		internal static int __PropertyOffset_MonsterCritDamageAnimType;

		// Token: 0x0400C8AD RID: 51373
		internal static int __PropertyOffset_TextDamageAnimType;

		// Token: 0x0400C8AE RID: 51374
		internal static int __PropertyOffset_IconPath;

		// Token: 0x0400C8AF RID: 51375
		internal static int __PropertyOffset_IconScale;
	}
}
