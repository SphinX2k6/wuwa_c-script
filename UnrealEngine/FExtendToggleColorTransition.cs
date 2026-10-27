using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200200E RID: 8206
	[UnrealObjectPath("/Script/LGUI.ExtendToggleColorTransition")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FExtendToggleColorTransition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE84 RID: 126596 RVA: 0x002DEE33 File Offset: 0x002DD033
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtendToggleColorTransition._ScriptStructPtr != 0) ? FExtendToggleColorTransition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ExtendToggleColorTransition", ref FExtendToggleColorTransition._ScriptStructPtr);
		}

		// Token: 0x17007AF9 RID: 31481
		// (get) Token: 0x0601EE85 RID: 126597 RVA: 0x002DEE57 File Offset: 0x002DD057
		// (set) Token: 0x0601EE86 RID: 126598 RVA: 0x002DEE6B File Offset: 0x002DD06B
		public unsafe FColor UnCheckedUnHoverColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnCheckedUnHoverColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnCheckedUnHoverColor) = value;
			}
		}

		// Token: 0x17007AFA RID: 31482
		// (get) Token: 0x0601EE87 RID: 126599 RVA: 0x002DEE80 File Offset: 0x002DD080
		// (set) Token: 0x0601EE88 RID: 126600 RVA: 0x002DEE94 File Offset: 0x002DD094
		public unsafe FColor UnCheckedHoverColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnCheckedHoverColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnCheckedHoverColor) = value;
			}
		}

		// Token: 0x17007AFB RID: 31483
		// (get) Token: 0x0601EE89 RID: 126601 RVA: 0x002DEEA9 File Offset: 0x002DD0A9
		// (set) Token: 0x0601EE8A RID: 126602 RVA: 0x002DEEBD File Offset: 0x002DD0BD
		public unsafe FColor UnCheckedPressedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnCheckedPressedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnCheckedPressedColor) = value;
			}
		}

		// Token: 0x17007AFC RID: 31484
		// (get) Token: 0x0601EE8B RID: 126603 RVA: 0x002DEED2 File Offset: 0x002DD0D2
		// (set) Token: 0x0601EE8C RID: 126604 RVA: 0x002DEEE6 File Offset: 0x002DD0E6
		public unsafe FColor CheckedUnHoverColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_CheckedUnHoverColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_CheckedUnHoverColor) = value;
			}
		}

		// Token: 0x17007AFD RID: 31485
		// (get) Token: 0x0601EE8D RID: 126605 RVA: 0x002DEEFB File Offset: 0x002DD0FB
		// (set) Token: 0x0601EE8E RID: 126606 RVA: 0x002DEF0F File Offset: 0x002DD10F
		public unsafe FColor CheckedHoverColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_CheckedHoverColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_CheckedHoverColor) = value;
			}
		}

		// Token: 0x17007AFE RID: 31486
		// (get) Token: 0x0601EE8F RID: 126607 RVA: 0x002DEF24 File Offset: 0x002DD124
		// (set) Token: 0x0601EE90 RID: 126608 RVA: 0x002DEF38 File Offset: 0x002DD138
		public unsafe FColor CheckedPressedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_CheckedPressedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_CheckedPressedColor) = value;
			}
		}

		// Token: 0x17007AFF RID: 31487
		// (get) Token: 0x0601EE91 RID: 126609 RVA: 0x002DEF4D File Offset: 0x002DD14D
		// (set) Token: 0x0601EE92 RID: 126610 RVA: 0x002DEF61 File Offset: 0x002DD161
		public unsafe FColor UnDeterminedUnHoverColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnDeterminedUnHoverColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnDeterminedUnHoverColor) = value;
			}
		}

		// Token: 0x17007B00 RID: 31488
		// (get) Token: 0x0601EE93 RID: 126611 RVA: 0x002DEF76 File Offset: 0x002DD176
		// (set) Token: 0x0601EE94 RID: 126612 RVA: 0x002DEF8A File Offset: 0x002DD18A
		public unsafe FColor UnDeterminedHoverColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnDeterminedHoverColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnDeterminedHoverColor) = value;
			}
		}

		// Token: 0x17007B01 RID: 31489
		// (get) Token: 0x0601EE95 RID: 126613 RVA: 0x002DEF9F File Offset: 0x002DD19F
		// (set) Token: 0x0601EE96 RID: 126614 RVA: 0x002DEFB3 File Offset: 0x002DD1B3
		public unsafe FColor UnDeterminedPressedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnDeterminedPressedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_UnDeterminedPressedColor) = value;
			}
		}

		// Token: 0x17007B02 RID: 31490
		// (get) Token: 0x0601EE97 RID: 126615 RVA: 0x002DEFC8 File Offset: 0x002DD1C8
		// (set) Token: 0x0601EE98 RID: 126616 RVA: 0x002DEFE1 File Offset: 0x002DD1E1
		public unsafe bool bEnableUnDetermined
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bEnableUnDetermined) & FExtendToggleColorTransition.__PropertyMask_bEnableUnDetermined) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bEnableUnDetermined) = ((*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bEnableUnDetermined) & ~FExtendToggleColorTransition.__PropertyMask_bEnableUnDetermined) | (value ? FExtendToggleColorTransition.__PropertyMask_bEnableUnDetermined : 0));
			}
		}

		// Token: 0x17007B03 RID: 31491
		// (get) Token: 0x0601EE99 RID: 126617 RVA: 0x002DF011 File Offset: 0x002DD211
		// (set) Token: 0x0601EE9A RID: 126618 RVA: 0x002DF02A File Offset: 0x002DD22A
		public unsafe bool bCustomUnCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnCheckedHover) & FExtendToggleColorTransition.__PropertyMask_bCustomUnCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnCheckedHover) & ~FExtendToggleColorTransition.__PropertyMask_bCustomUnCheckedHover) | (value ? FExtendToggleColorTransition.__PropertyMask_bCustomUnCheckedHover : 0));
			}
		}

		// Token: 0x17007B04 RID: 31492
		// (get) Token: 0x0601EE9B RID: 126619 RVA: 0x002DF05A File Offset: 0x002DD25A
		// (set) Token: 0x0601EE9C RID: 126620 RVA: 0x002DF073 File Offset: 0x002DD273
		public unsafe bool bCustomUnCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnCheckedPressed) & FExtendToggleColorTransition.__PropertyMask_bCustomUnCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnCheckedPressed) & ~FExtendToggleColorTransition.__PropertyMask_bCustomUnCheckedPressed) | (value ? FExtendToggleColorTransition.__PropertyMask_bCustomUnCheckedPressed : 0));
			}
		}

		// Token: 0x17007B05 RID: 31493
		// (get) Token: 0x0601EE9D RID: 126621 RVA: 0x002DF0A3 File Offset: 0x002DD2A3
		// (set) Token: 0x0601EE9E RID: 126622 RVA: 0x002DF0BC File Offset: 0x002DD2BC
		public unsafe bool bCustomCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomCheckedHover) & FExtendToggleColorTransition.__PropertyMask_bCustomCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomCheckedHover) & ~FExtendToggleColorTransition.__PropertyMask_bCustomCheckedHover) | (value ? FExtendToggleColorTransition.__PropertyMask_bCustomCheckedHover : 0));
			}
		}

		// Token: 0x17007B06 RID: 31494
		// (get) Token: 0x0601EE9F RID: 126623 RVA: 0x002DF0EC File Offset: 0x002DD2EC
		// (set) Token: 0x0601EEA0 RID: 126624 RVA: 0x002DF105 File Offset: 0x002DD305
		public unsafe bool bCustomCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomCheckedPressed) & FExtendToggleColorTransition.__PropertyMask_bCustomCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomCheckedPressed) & ~FExtendToggleColorTransition.__PropertyMask_bCustomCheckedPressed) | (value ? FExtendToggleColorTransition.__PropertyMask_bCustomCheckedPressed : 0));
			}
		}

		// Token: 0x17007B07 RID: 31495
		// (get) Token: 0x0601EEA1 RID: 126625 RVA: 0x002DF135 File Offset: 0x002DD335
		// (set) Token: 0x0601EEA2 RID: 126626 RVA: 0x002DF14E File Offset: 0x002DD34E
		public unsafe bool bCustomUnDeterminedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnDeterminedHover) & FExtendToggleColorTransition.__PropertyMask_bCustomUnDeterminedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnDeterminedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnDeterminedHover) & ~FExtendToggleColorTransition.__PropertyMask_bCustomUnDeterminedHover) | (value ? FExtendToggleColorTransition.__PropertyMask_bCustomUnDeterminedHover : 0));
			}
		}

		// Token: 0x17007B08 RID: 31496
		// (get) Token: 0x0601EEA3 RID: 126627 RVA: 0x002DF17E File Offset: 0x002DD37E
		// (set) Token: 0x0601EEA4 RID: 126628 RVA: 0x002DF197 File Offset: 0x002DD397
		public unsafe bool bCustomUnDeterminePressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnDeterminePressed) & FExtendToggleColorTransition.__PropertyMask_bCustomUnDeterminePressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnDeterminePressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleColorTransition.__PropertyOffset_bCustomUnDeterminePressed) & ~FExtendToggleColorTransition.__PropertyMask_bCustomUnDeterminePressed) | (value ? FExtendToggleColorTransition.__PropertyMask_bCustomUnDeterminePressed : 0));
			}
		}

		// Token: 0x0601EEA5 RID: 126629 RVA: 0x002DF1C7 File Offset: 0x002DD3C7
		public FExtendToggleColorTransition()
		{
		}

		// Token: 0x0601EEA6 RID: 126630 RVA: 0x002DF1D0 File Offset: 0x002DD3D0
		public FExtendToggleColorTransition(FColor UnCheckedUnHoverColor, FColor UnCheckedHoverColor, FColor UnCheckedPressedColor, FColor CheckedUnHoverColor, FColor CheckedHoverColor, FColor CheckedPressedColor, FColor UnDeterminedUnHoverColor, FColor UnDeterminedHoverColor, FColor UnDeterminedPressedColor, bool bEnableUnDetermined, bool bCustomUnCheckedHover, bool bCustomUnCheckedPressed, bool bCustomCheckedHover, bool bCustomCheckedPressed, bool bCustomUnDeterminedHover, bool bCustomUnDeterminePressed)
		{
			this.UnCheckedUnHoverColor = UnCheckedUnHoverColor;
			this.UnCheckedHoverColor = UnCheckedHoverColor;
			this.UnCheckedPressedColor = UnCheckedPressedColor;
			this.CheckedUnHoverColor = CheckedUnHoverColor;
			this.CheckedHoverColor = CheckedHoverColor;
			this.CheckedPressedColor = CheckedPressedColor;
			this.UnDeterminedUnHoverColor = UnDeterminedUnHoverColor;
			this.UnDeterminedHoverColor = UnDeterminedHoverColor;
			this.UnDeterminedPressedColor = UnDeterminedPressedColor;
			this.bEnableUnDetermined = bEnableUnDetermined;
			this.bCustomUnCheckedHover = bCustomUnCheckedHover;
			this.bCustomUnCheckedPressed = bCustomUnCheckedPressed;
			this.bCustomCheckedHover = bCustomCheckedHover;
			this.bCustomCheckedPressed = bCustomCheckedPressed;
			this.bCustomUnDeterminedHover = bCustomUnDeterminedHover;
			this.bCustomUnDeterminePressed = bCustomUnDeterminePressed;
		}

		// Token: 0x0601EEA7 RID: 126631 RVA: 0x002DF260 File Offset: 0x002DD460
		protected override IntPtr GetUStructPtr()
		{
			return FExtendToggleColorTransition.StaticStruct();
		}

		// Token: 0x0601EEA8 RID: 126632 RVA: 0x002DF26C File Offset: 0x002DD46C
		[NullableContext(2)]
		public FExtendToggleColorTransition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EEA9 RID: 126633 RVA: 0x002DF276 File Offset: 0x002DD476
		public FExtendToggleColorTransition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EEAA RID: 126634 RVA: 0x002DF281 File Offset: 0x002DD481
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtendToggleColorTransition(Pointer, false, true);
		}

		// Token: 0x0601EEAB RID: 126635 RVA: 0x002DF28B File Offset: 0x002DD48B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtendToggleColorTransition(Pointer, MemoryOwner);
		}

		// Token: 0x04010CB9 RID: 68793
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.ExtendToggleColorTransition";

		// Token: 0x04010CBA RID: 68794
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CBB RID: 68795
		internal static int __PropertyOffset_UnCheckedUnHoverColor;

		// Token: 0x04010CBC RID: 68796
		internal static int __PropertyOffset_UnCheckedHoverColor;

		// Token: 0x04010CBD RID: 68797
		internal static int __PropertyOffset_UnCheckedPressedColor;

		// Token: 0x04010CBE RID: 68798
		internal static int __PropertyOffset_CheckedUnHoverColor;

		// Token: 0x04010CBF RID: 68799
		internal static int __PropertyOffset_CheckedHoverColor;

		// Token: 0x04010CC0 RID: 68800
		internal static int __PropertyOffset_CheckedPressedColor;

		// Token: 0x04010CC1 RID: 68801
		internal static int __PropertyOffset_UnDeterminedUnHoverColor;

		// Token: 0x04010CC2 RID: 68802
		internal static int __PropertyOffset_UnDeterminedHoverColor;

		// Token: 0x04010CC3 RID: 68803
		internal static int __PropertyOffset_UnDeterminedPressedColor;

		// Token: 0x04010CC4 RID: 68804
		internal static int __PropertyOffset_bEnableUnDetermined;

		// Token: 0x04010CC5 RID: 68805
		internal static byte __PropertyMask_bEnableUnDetermined;

		// Token: 0x04010CC6 RID: 68806
		internal static int __PropertyOffset_bCustomUnCheckedHover;

		// Token: 0x04010CC7 RID: 68807
		internal static byte __PropertyMask_bCustomUnCheckedHover;

		// Token: 0x04010CC8 RID: 68808
		internal static int __PropertyOffset_bCustomUnCheckedPressed;

		// Token: 0x04010CC9 RID: 68809
		internal static byte __PropertyMask_bCustomUnCheckedPressed;

		// Token: 0x04010CCA RID: 68810
		internal static int __PropertyOffset_bCustomCheckedHover;

		// Token: 0x04010CCB RID: 68811
		internal static byte __PropertyMask_bCustomCheckedHover;

		// Token: 0x04010CCC RID: 68812
		internal static int __PropertyOffset_bCustomCheckedPressed;

		// Token: 0x04010CCD RID: 68813
		internal static byte __PropertyMask_bCustomCheckedPressed;

		// Token: 0x04010CCE RID: 68814
		internal static int __PropertyOffset_bCustomUnDeterminedHover;

		// Token: 0x04010CCF RID: 68815
		internal static byte __PropertyMask_bCustomUnDeterminedHover;

		// Token: 0x04010CD0 RID: 68816
		internal static int __PropertyOffset_bCustomUnDeterminePressed;

		// Token: 0x04010CD1 RID: 68817
		internal static byte __PropertyMask_bCustomUnDeterminePressed;
	}
}
