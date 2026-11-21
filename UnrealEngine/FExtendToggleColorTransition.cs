using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200065D RID: 1629
	[UnrealObjectPath("/Script/LGUI.ExtendToggleColorTransition")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FExtendToggleColorTransition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008D5A RID: 36186 RVA: 0x000D4BA7 File Offset: 0x000D2DA7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtendToggleColorTransition._ScriptStructPtr != 0) ? FExtendToggleColorTransition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ExtendToggleColorTransition", ref FExtendToggleColorTransition._ScriptStructPtr);
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06008D5B RID: 36187 RVA: 0x000D4BCB File Offset: 0x000D2DCB
		// (set) Token: 0x06008D5C RID: 36188 RVA: 0x000D4BDF File Offset: 0x000D2DDF
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

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06008D5D RID: 36189 RVA: 0x000D4BF4 File Offset: 0x000D2DF4
		// (set) Token: 0x06008D5E RID: 36190 RVA: 0x000D4C08 File Offset: 0x000D2E08
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

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06008D5F RID: 36191 RVA: 0x000D4C1D File Offset: 0x000D2E1D
		// (set) Token: 0x06008D60 RID: 36192 RVA: 0x000D4C31 File Offset: 0x000D2E31
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

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06008D61 RID: 36193 RVA: 0x000D4C46 File Offset: 0x000D2E46
		// (set) Token: 0x06008D62 RID: 36194 RVA: 0x000D4C5A File Offset: 0x000D2E5A
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

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06008D63 RID: 36195 RVA: 0x000D4C6F File Offset: 0x000D2E6F
		// (set) Token: 0x06008D64 RID: 36196 RVA: 0x000D4C83 File Offset: 0x000D2E83
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

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06008D65 RID: 36197 RVA: 0x000D4C98 File Offset: 0x000D2E98
		// (set) Token: 0x06008D66 RID: 36198 RVA: 0x000D4CAC File Offset: 0x000D2EAC
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

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06008D67 RID: 36199 RVA: 0x000D4CC1 File Offset: 0x000D2EC1
		// (set) Token: 0x06008D68 RID: 36200 RVA: 0x000D4CD5 File Offset: 0x000D2ED5
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

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06008D69 RID: 36201 RVA: 0x000D4CEA File Offset: 0x000D2EEA
		// (set) Token: 0x06008D6A RID: 36202 RVA: 0x000D4CFE File Offset: 0x000D2EFE
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

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06008D6B RID: 36203 RVA: 0x000D4D13 File Offset: 0x000D2F13
		// (set) Token: 0x06008D6C RID: 36204 RVA: 0x000D4D27 File Offset: 0x000D2F27
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

		// Token: 0x06008D6D RID: 36205 RVA: 0x000D4D3C File Offset: 0x000D2F3C
		public FExtendToggleColorTransition()
		{
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x000D4D44 File Offset: 0x000D2F44
		protected override IntPtr GetUStructPtr()
		{
			return FExtendToggleColorTransition.StaticStruct();
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x000D4D50 File Offset: 0x000D2F50
		[NullableContext(2)]
		public FExtendToggleColorTransition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x000D4D5A File Offset: 0x000D2F5A
		public FExtendToggleColorTransition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008D71 RID: 36209 RVA: 0x000D4D65 File Offset: 0x000D2F65
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtendToggleColorTransition(Pointer, false, true);
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x000D4D6F File Offset: 0x000D2F6F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtendToggleColorTransition(Pointer, MemoryOwner);
		}

		// Token: 0x04003E39 RID: 15929
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.ExtendToggleColorTransition";

		// Token: 0x04003E3A RID: 15930
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003E3B RID: 15931
		internal static int __PropertyOffset_UnCheckedUnHoverColor;

		// Token: 0x04003E3C RID: 15932
		internal static int __PropertyOffset_UnCheckedHoverColor;

		// Token: 0x04003E3D RID: 15933
		internal static int __PropertyOffset_UnCheckedPressedColor;

		// Token: 0x04003E3E RID: 15934
		internal static int __PropertyOffset_CheckedUnHoverColor;

		// Token: 0x04003E3F RID: 15935
		internal static int __PropertyOffset_CheckedHoverColor;

		// Token: 0x04003E40 RID: 15936
		internal static int __PropertyOffset_CheckedPressedColor;

		// Token: 0x04003E41 RID: 15937
		internal static int __PropertyOffset_UnDeterminedUnHoverColor;

		// Token: 0x04003E42 RID: 15938
		internal static int __PropertyOffset_UnDeterminedHoverColor;

		// Token: 0x04003E43 RID: 15939
		internal static int __PropertyOffset_UnDeterminedPressedColor;
	}
}
