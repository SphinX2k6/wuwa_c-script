using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005AA RID: 1450
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_FitChainToCurve_DebugSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E0F RID: 19983 RVA: 0x00073588 File Offset: 0x00071788
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FitChainToCurve_DebugSettings._ScriptStructPtr != 0) ? FRigUnit_FitChainToCurve_DebugSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings", ref FRigUnit_FitChainToCurve_DebugSettings._ScriptStructPtr);
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06004E10 RID: 19984 RVA: 0x000735AC File Offset: 0x000717AC
		// (set) Token: 0x06004E11 RID: 19985 RVA: 0x000735BC File Offset: 0x000717BC
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x000735CD File Offset: 0x000717CD
		// (set) Token: 0x06004E13 RID: 19987 RVA: 0x000735DD File Offset: 0x000717DD
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x000735EE File Offset: 0x000717EE
		// (set) Token: 0x06004E15 RID: 19989 RVA: 0x00073602 File Offset: 0x00071802
		public unsafe FLinearColor CurveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_CurveColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_CurveColor) = value;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x00073617 File Offset: 0x00071817
		// (set) Token: 0x06004E17 RID: 19991 RVA: 0x0007362B File Offset: 0x0007182B
		public unsafe FLinearColor SegmentsColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_SegmentsColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_SegmentsColor) = value;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x00073640 File Offset: 0x00071840
		// (set) Token: 0x06004E19 RID: 19993 RVA: 0x00073654 File Offset: 0x00071854
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve_DebugSettings.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00073669 File Offset: 0x00071869
		public FRigUnit_FitChainToCurve_DebugSettings()
		{
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00073671 File Offset: 0x00071871
		public FRigUnit_FitChainToCurve_DebugSettings(bool bEnabled, float Scale, FLinearColor CurveColor, FLinearColor SegmentsColor, FTransform WorldOffset)
		{
			this.bEnabled = bEnabled;
			this.Scale = Scale;
			this.CurveColor = CurveColor;
			this.SegmentsColor = SegmentsColor;
			this.WorldOffset = WorldOffset;
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x0007369E File Offset: 0x0007189E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FitChainToCurve_DebugSettings.StaticStruct();
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x000736AA File Offset: 0x000718AA
		[NullableContext(2)]
		public FRigUnit_FitChainToCurve_DebugSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x000736B4 File Offset: 0x000718B4
		public FRigUnit_FitChainToCurve_DebugSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x000736BF File Offset: 0x000718BF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FitChainToCurve_DebugSettings(Pointer, false, true);
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x000736C9 File Offset: 0x000718C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FitChainToCurve_DebugSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040025B7 RID: 9655
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_FitChainToCurve_DebugSettings";

		// Token: 0x040025B8 RID: 9656
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025B9 RID: 9657
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040025BA RID: 9658
		internal static int __PropertyOffset_Scale;

		// Token: 0x040025BB RID: 9659
		internal static int __PropertyOffset_CurveColor;

		// Token: 0x040025BC RID: 9660
		internal static int __PropertyOffset_SegmentsColor;

		// Token: 0x040025BD RID: 9661
		internal static int __PropertyOffset_WorldOffset;
	}
}
