using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200187E RID: 6270
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FDamageInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601718E RID: 94606 RVA: 0x0021A980 File Offset: 0x00218B80
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageInfo._ScriptStructPtr != 0) ? FDamageInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.DamageInfo", ref FDamageInfo._ScriptStructPtr);
		}

		// Token: 0x17005CED RID: 23789
		// (get) Token: 0x0601718F RID: 94607 RVA: 0x0021A9A4 File Offset: 0x00218BA4
		// (set) Token: 0x06017190 RID: 94608 RVA: 0x0021A9B4 File Offset: 0x00218BB4
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

		// Token: 0x17005CEE RID: 23790
		// (get) Token: 0x06017191 RID: 94609 RVA: 0x0021A9C5 File Offset: 0x00218BC5
		// (set) Token: 0x06017192 RID: 94610 RVA: 0x0021A9D5 File Offset: 0x00218BD5
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

		// Token: 0x17005CEF RID: 23791
		// (get) Token: 0x06017193 RID: 94611 RVA: 0x0021A9E6 File Offset: 0x00218BE6
		// (set) Token: 0x06017194 RID: 94612 RVA: 0x0021A9FA File Offset: 0x00218BFA
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

		// Token: 0x17005CF0 RID: 23792
		// (get) Token: 0x06017195 RID: 94613 RVA: 0x0021AA0F File Offset: 0x00218C0F
		// (set) Token: 0x06017196 RID: 94614 RVA: 0x0021AA1F File Offset: 0x00218C1F
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

		// Token: 0x17005CF1 RID: 23793
		// (get) Token: 0x06017197 RID: 94615 RVA: 0x0021AA30 File Offset: 0x00218C30
		// (set) Token: 0x06017198 RID: 94616 RVA: 0x0021AA40 File Offset: 0x00218C40
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

		// Token: 0x17005CF2 RID: 23794
		// (get) Token: 0x06017199 RID: 94617 RVA: 0x0021AA51 File Offset: 0x00218C51
		// (set) Token: 0x0601719A RID: 94618 RVA: 0x0021AA61 File Offset: 0x00218C61
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

		// Token: 0x17005CF3 RID: 23795
		// (get) Token: 0x0601719B RID: 94619 RVA: 0x0021AA72 File Offset: 0x00218C72
		// (set) Token: 0x0601719C RID: 94620 RVA: 0x0021AA86 File Offset: 0x00218C86
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

		// Token: 0x17005CF4 RID: 23796
		// (get) Token: 0x0601719D RID: 94621 RVA: 0x0021AA9B File Offset: 0x00218C9B
		// (set) Token: 0x0601719E RID: 94622 RVA: 0x0021AAAB File Offset: 0x00218CAB
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

		// Token: 0x17005CF5 RID: 23797
		// (get) Token: 0x0601719F RID: 94623 RVA: 0x0021AABC File Offset: 0x00218CBC
		// (set) Token: 0x060171A0 RID: 94624 RVA: 0x0021AACC File Offset: 0x00218CCC
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

		// Token: 0x17005CF6 RID: 23798
		// (get) Token: 0x060171A1 RID: 94625 RVA: 0x0021AADD File Offset: 0x00218CDD
		// (set) Token: 0x060171A2 RID: 94626 RVA: 0x0021AAF1 File Offset: 0x00218CF1
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

		// Token: 0x060171A3 RID: 94627 RVA: 0x0021AB06 File Offset: 0x00218D06
		public FDamageInfo()
		{
		}

		// Token: 0x060171A4 RID: 94628 RVA: 0x0021AB10 File Offset: 0x00218D10
		public FDamageInfo(int Damage, int DamageConfigId, FVectorDouble DamagePosition, bool bOwnPlayer, bool bCrit, bool bCure, string DamageText, float ExpiredTime, bool bUseLGUIPos, FVector2D LGUIPos)
		{
			this.Damage = Damage;
			this.DamageConfigId = DamageConfigId;
			this.DamagePosition = DamagePosition;
			this.bOwnPlayer = bOwnPlayer;
			this.bCrit = bCrit;
			this.bCure = bCure;
			this.DamageText = DamageText;
			this.ExpiredTime = ExpiredTime;
			this.bUseLGUIPos = bUseLGUIPos;
			this.LGUIPos = LGUIPos;
		}

		// Token: 0x060171A5 RID: 94629 RVA: 0x0021AB70 File Offset: 0x00218D70
		protected override IntPtr GetUStructPtr()
		{
			return FDamageInfo.StaticStruct();
		}

		// Token: 0x060171A6 RID: 94630 RVA: 0x0021AB7C File Offset: 0x00218D7C
		[NullableContext(2)]
		public FDamageInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060171A7 RID: 94631 RVA: 0x0021AB86 File Offset: 0x00218D86
		public FDamageInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060171A8 RID: 94632 RVA: 0x0021AB91 File Offset: 0x00218D91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageInfo(Pointer, false, true);
		}

		// Token: 0x060171A9 RID: 94633 RVA: 0x0021AB9B File Offset: 0x00218D9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400C884 RID: 51332
		public const string __ObjectPath = "/Script/KuroGameplayUI.DamageInfo";

		// Token: 0x0400C885 RID: 51333
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C886 RID: 51334
		internal static int __PropertyOffset_Damage;

		// Token: 0x0400C887 RID: 51335
		internal static int __PropertyOffset_DamageConfigId;

		// Token: 0x0400C888 RID: 51336
		internal static int __PropertyOffset_DamagePosition;

		// Token: 0x0400C889 RID: 51337
		internal static int __PropertyOffset_bOwnPlayer;

		// Token: 0x0400C88A RID: 51338
		internal static int __PropertyOffset_bCrit;

		// Token: 0x0400C88B RID: 51339
		internal static int __PropertyOffset_bCure;

		// Token: 0x0400C88C RID: 51340
		internal static int __PropertyOffset_DamageText;

		// Token: 0x0400C88D RID: 51341
		internal static int __PropertyOffset_ExpiredTime;

		// Token: 0x0400C88E RID: 51342
		internal static int __PropertyOffset_bUseLGUIPos;

		// Token: 0x0400C88F RID: 51343
		internal static int __PropertyOffset_LGUIPos;
	}
}
