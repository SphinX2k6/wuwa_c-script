using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000585 RID: 1413
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugBezierItemSpace")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_DebugBezierItemSpace : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B49 RID: 19273 RVA: 0x0006F8F8 File Offset: 0x0006DAF8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugBezierItemSpace._ScriptStructPtr != 0) ? FRigUnit_DebugBezierItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugBezierItemSpace", ref FRigUnit_DebugBezierItemSpace._ScriptStructPtr);
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0006F91C File Offset: 0x0006DB1C
		// (set) Token: 0x06004B4B RID: 19275 RVA: 0x0006F95F File Offset: 0x0006DB5F
		public FCRFourPointBezier Bezier
		{
			get
			{
				base.FastCheckIsValid();
				FCRFourPointBezier result;
				if ((result = this._Bezier) == null)
				{
					result = (this._Bezier = new FCRFourPointBezier(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Bezier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRFourPointBezier.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Bezier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x0006F980 File Offset: 0x0006DB80
		// (set) Token: 0x06004B4D RID: 19277 RVA: 0x0006F990 File Offset: 0x0006DB90
		public unsafe float MinimumU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_MinimumU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_MinimumU) = value;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06004B4E RID: 19278 RVA: 0x0006F9A1 File Offset: 0x0006DBA1
		// (set) Token: 0x06004B4F RID: 19279 RVA: 0x0006F9B1 File Offset: 0x0006DBB1
		public unsafe float MaximumU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_MaximumU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_MaximumU) = value;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06004B50 RID: 19280 RVA: 0x0006F9C2 File Offset: 0x0006DBC2
		// (set) Token: 0x06004B51 RID: 19281 RVA: 0x0006F9D6 File Offset: 0x0006DBD6
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06004B52 RID: 19282 RVA: 0x0006F9EB File Offset: 0x0006DBEB
		// (set) Token: 0x06004B53 RID: 19283 RVA: 0x0006F9FB File Offset: 0x0006DBFB
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06004B54 RID: 19284 RVA: 0x0006FA0C File Offset: 0x0006DC0C
		// (set) Token: 0x06004B55 RID: 19285 RVA: 0x0006FA1C File Offset: 0x0006DC1C
		public unsafe int Detail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Detail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Detail) = value;
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06004B56 RID: 19286 RVA: 0x0006FA30 File Offset: 0x0006DC30
		// (set) Token: 0x06004B57 RID: 19287 RVA: 0x0006FA73 File Offset: 0x0006DC73
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x0006FA94 File Offset: 0x0006DC94
		// (set) Token: 0x06004B59 RID: 19289 RVA: 0x0006FAA8 File Offset: 0x0006DCA8
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06004B5A RID: 19290 RVA: 0x0006FABD File Offset: 0x0006DCBD
		// (set) Token: 0x06004B5B RID: 19291 RVA: 0x0006FACD File Offset: 0x0006DCCD
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezierItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x0006FADE File Offset: 0x0006DCDE
		public FRigUnit_DebugBezierItemSpace()
		{
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x0006FAE8 File Offset: 0x0006DCE8
		public FRigUnit_DebugBezierItemSpace(FCRFourPointBezier Bezier, float MinimumU, float MaximumU, FLinearColor Color, float Thickness, int Detail, FRigElementKey Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Bezier = Bezier;
			this.MinimumU = MinimumU;
			this.MaximumU = MaximumU;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Detail = Detail;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x0006FB48 File Offset: 0x0006DD48
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugBezierItemSpace.StaticStruct();
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x0006FB54 File Offset: 0x0006DD54
		[NullableContext(2)]
		public FRigUnit_DebugBezierItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x0006FB5E File Offset: 0x0006DD5E
		public FRigUnit_DebugBezierItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x0006FB69 File Offset: 0x0006DD69
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugBezierItemSpace(Pointer, false, true);
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x0006FB73 File Offset: 0x0006DD73
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugBezierItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x0400247A RID: 9338
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugBezierItemSpace";

		// Token: 0x0400247B RID: 9339
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400247C RID: 9340
		internal static int __PropertyOffset_Bezier;

		// Token: 0x0400247D RID: 9341
		[Nullable(2)]
		private FCRFourPointBezier _Bezier;

		// Token: 0x0400247E RID: 9342
		internal static int __PropertyOffset_MinimumU;

		// Token: 0x0400247F RID: 9343
		internal static int __PropertyOffset_MaximumU;

		// Token: 0x04002480 RID: 9344
		internal static int __PropertyOffset_Color;

		// Token: 0x04002481 RID: 9345
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002482 RID: 9346
		internal static int __PropertyOffset_Detail;

		// Token: 0x04002483 RID: 9347
		internal static int __PropertyOffset_Space;

		// Token: 0x04002484 RID: 9348
		[Nullable(2)]
		private FRigElementKey _Space;

		// Token: 0x04002485 RID: 9349
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x04002486 RID: 9350
		internal static int __PropertyOffset_bEnabled;
	}
}
