using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000584 RID: 1412
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugBezier")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_DebugBezier : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B2F RID: 19247 RVA: 0x0006F6B3 File Offset: 0x0006D8B3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugBezier._ScriptStructPtr != 0) ? FRigUnit_DebugBezier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugBezier", ref FRigUnit_DebugBezier._ScriptStructPtr);
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x0006F6D8 File Offset: 0x0006D8D8
		// (set) Token: 0x06004B31 RID: 19249 RVA: 0x0006F71B File Offset: 0x0006D91B
		public FCRFourPointBezier Bezier
		{
			get
			{
				base.FastCheckIsValid();
				FCRFourPointBezier result;
				if ((result = this._Bezier) == null)
				{
					result = (this._Bezier = new FCRFourPointBezier(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Bezier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRFourPointBezier.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Bezier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06004B32 RID: 19250 RVA: 0x0006F73C File Offset: 0x0006D93C
		// (set) Token: 0x06004B33 RID: 19251 RVA: 0x0006F74C File Offset: 0x0006D94C
		public unsafe float MinimumU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_MinimumU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_MinimumU) = value;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x0006F75D File Offset: 0x0006D95D
		// (set) Token: 0x06004B35 RID: 19253 RVA: 0x0006F76D File Offset: 0x0006D96D
		public unsafe float MaximumU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_MaximumU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_MaximumU) = value;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x0006F77E File Offset: 0x0006D97E
		// (set) Token: 0x06004B37 RID: 19255 RVA: 0x0006F792 File Offset: 0x0006D992
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x0006F7A7 File Offset: 0x0006D9A7
		// (set) Token: 0x06004B39 RID: 19257 RVA: 0x0006F7B7 File Offset: 0x0006D9B7
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06004B3A RID: 19258 RVA: 0x0006F7C8 File Offset: 0x0006D9C8
		// (set) Token: 0x06004B3B RID: 19259 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
		public unsafe int Detail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Detail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Detail) = value;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x0006F7E9 File Offset: 0x0006D9E9
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x0006F7FD File Offset: 0x0006D9FD
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x0006F812 File Offset: 0x0006DA12
		// (set) Token: 0x06004B3F RID: 19263 RVA: 0x0006F826 File Offset: 0x0006DA26
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x0006F83B File Offset: 0x0006DA3B
		// (set) Token: 0x06004B41 RID: 19265 RVA: 0x0006F84B File Offset: 0x0006DA4B
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugBezier.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x0006F85C File Offset: 0x0006DA5C
		public FRigUnit_DebugBezier()
		{
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x0006F864 File Offset: 0x0006DA64
		public FRigUnit_DebugBezier(FCRFourPointBezier Bezier, float MinimumU, float MaximumU, FLinearColor Color, float Thickness, int Detail, FName Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
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

		// Token: 0x06004B44 RID: 19268 RVA: 0x0006F8C4 File Offset: 0x0006DAC4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugBezier.StaticStruct();
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x0006F8D0 File Offset: 0x0006DAD0
		[NullableContext(2)]
		public FRigUnit_DebugBezier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x0006F8DA File Offset: 0x0006DADA
		public FRigUnit_DebugBezier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x0006F8E5 File Offset: 0x0006DAE5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugBezier(Pointer, false, true);
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x0006F8EF File Offset: 0x0006DAEF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugBezier(Pointer, MemoryOwner);
		}

		// Token: 0x0400246E RID: 9326
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugBezier";

		// Token: 0x0400246F RID: 9327
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002470 RID: 9328
		internal static int __PropertyOffset_Bezier;

		// Token: 0x04002471 RID: 9329
		[Nullable(2)]
		private FCRFourPointBezier _Bezier;

		// Token: 0x04002472 RID: 9330
		internal static int __PropertyOffset_MinimumU;

		// Token: 0x04002473 RID: 9331
		internal static int __PropertyOffset_MaximumU;

		// Token: 0x04002474 RID: 9332
		internal static int __PropertyOffset_Color;

		// Token: 0x04002475 RID: 9333
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002476 RID: 9334
		internal static int __PropertyOffset_Detail;

		// Token: 0x04002477 RID: 9335
		internal static int __PropertyOffset_Space;

		// Token: 0x04002478 RID: 9336
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x04002479 RID: 9337
		internal static int __PropertyOffset_bEnabled;
	}
}
