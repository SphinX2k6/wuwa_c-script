using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033D RID: 829
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.RBFTarget")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRBFTarget : FRBFEntry, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002E3D RID: 11837 RVA: 0x00046E5C File Offset: 0x0004505C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFTarget._ScriptStructPtr != 0) ? FRBFTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.RBFTarget", ref FRBFTarget._ScriptStructPtr);
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x00046E80 File Offset: 0x00045080
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x00046E90 File Offset: 0x00045090
		public unsafe float ScaleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_ScaleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_ScaleFactor) = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x00046EA1 File Offset: 0x000450A1
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x00046EB1 File Offset: 0x000450B1
		public unsafe bool bApplyCustomCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_bApplyCustomCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_bApplyCustomCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x00046EC4 File Offset: 0x000450C4
		// (set) Token: 0x06002E43 RID: 11843 RVA: 0x00046F07 File Offset: 0x00045107
		public FRichCurve CustomCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._CustomCurve) == null)
				{
					result = (this._CustomCurve = new FRichCurve(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_CustomCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_CustomCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x00046F28 File Offset: 0x00045128
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x00046F38 File Offset: 0x00045138
		public unsafe ERBFDistanceMethod DistanceMethod
		{
			get
			{
				return (ERBFDistanceMethod)(*(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_DistanceMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_DistanceMethod) = (byte)value;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x00046F49 File Offset: 0x00045149
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x00046F59 File Offset: 0x00045159
		public unsafe ERBFFunctionType FunctionType
		{
			get
			{
				return (ERBFFunctionType)(*(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_FunctionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFTarget.__PropertyOffset_FunctionType) = (byte)value;
			}
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00046F6A File Offset: 0x0004516A
		public FRBFTarget()
		{
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00046F72 File Offset: 0x00045172
		public FRBFTarget(float ScaleFactor, bool bApplyCustomCurve, FRichCurve CustomCurve, ERBFDistanceMethod DistanceMethod, ERBFFunctionType FunctionType, TArray<float> Values)
		{
			this.ScaleFactor = ScaleFactor;
			this.bApplyCustomCurve = bApplyCustomCurve;
			this.CustomCurve = CustomCurve;
			this.DistanceMethod = DistanceMethod;
			this.FunctionType = FunctionType;
			base.Values = Values;
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00046FA7 File Offset: 0x000451A7
		protected override IntPtr GetUStructPtr()
		{
			return FRBFTarget.StaticStruct();
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00046FB3 File Offset: 0x000451B3
		[NullableContext(2)]
		public FRBFTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00046FBD File Offset: 0x000451BD
		public FRBFTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00046FC8 File Offset: 0x000451C8
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFTarget(Pointer, false, true);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00046FD2 File Offset: 0x000451D2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFTarget(Pointer, MemoryOwner);
		}

		// Token: 0x040013D0 RID: 5072
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.RBFTarget";

		// Token: 0x040013D1 RID: 5073
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013D2 RID: 5074
		internal static int __PropertyOffset_ScaleFactor;

		// Token: 0x040013D3 RID: 5075
		internal static int __PropertyOffset_bApplyCustomCurve;

		// Token: 0x040013D4 RID: 5076
		internal static int __PropertyOffset_CustomCurve;

		// Token: 0x040013D5 RID: 5077
		[Nullable(2)]
		private FRichCurve _CustomCurve;

		// Token: 0x040013D6 RID: 5078
		internal static int __PropertyOffset_DistanceMethod;

		// Token: 0x040013D7 RID: 5079
		internal static int __PropertyOffset_FunctionType;
	}
}
