using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000581 RID: 1409
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugArcItemSpace")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FRigUnit_DebugArcItemSpace : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B04 RID: 19204 RVA: 0x0006F374 File Offset: 0x0006D574
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugArcItemSpace._ScriptStructPtr != 0) ? FRigUnit_DebugArcItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugArcItemSpace", ref FRigUnit_DebugArcItemSpace._ScriptStructPtr);
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06004B05 RID: 19205 RVA: 0x0006F398 File Offset: 0x0006D598
		// (set) Token: 0x06004B06 RID: 19206 RVA: 0x0006F3AC File Offset: 0x0006D5AC
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06004B07 RID: 19207 RVA: 0x0006F3C1 File Offset: 0x0006D5C1
		// (set) Token: 0x06004B08 RID: 19208 RVA: 0x0006F3D5 File Offset: 0x0006D5D5
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06004B09 RID: 19209 RVA: 0x0006F3EA File Offset: 0x0006D5EA
		// (set) Token: 0x06004B0A RID: 19210 RVA: 0x0006F3FA File Offset: 0x0006D5FA
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x0006F40B File Offset: 0x0006D60B
		// (set) Token: 0x06004B0C RID: 19212 RVA: 0x0006F41B File Offset: 0x0006D61B
		public unsafe float MinimumDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_MinimumDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_MinimumDegrees) = value;
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x0006F42C File Offset: 0x0006D62C
		// (set) Token: 0x06004B0E RID: 19214 RVA: 0x0006F43C File Offset: 0x0006D63C
		public unsafe float MaximumDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_MaximumDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_MaximumDegrees) = value;
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x0006F44D File Offset: 0x0006D64D
		// (set) Token: 0x06004B10 RID: 19216 RVA: 0x0006F45D File Offset: 0x0006D65D
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x0006F46E File Offset: 0x0006D66E
		// (set) Token: 0x06004B12 RID: 19218 RVA: 0x0006F47E File Offset: 0x0006D67E
		public unsafe int Detail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Detail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Detail) = value;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06004B13 RID: 19219 RVA: 0x0006F490 File Offset: 0x0006D690
		// (set) Token: 0x06004B14 RID: 19220 RVA: 0x0006F4D3 File Offset: 0x0006D6D3
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x0006F4F4 File Offset: 0x0006D6F4
		// (set) Token: 0x06004B16 RID: 19222 RVA: 0x0006F508 File Offset: 0x0006D708
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x0006F51D File Offset: 0x0006D71D
		// (set) Token: 0x06004B18 RID: 19224 RVA: 0x0006F52D File Offset: 0x0006D72D
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArcItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x0006F53E File Offset: 0x0006D73E
		public FRigUnit_DebugArcItemSpace()
		{
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x0006F548 File Offset: 0x0006D748
		public FRigUnit_DebugArcItemSpace(FTransform Transform, FLinearColor Color, float Radius, float MinimumDegrees, float MaximumDegrees, float Thickness, int Detail, FRigElementKey Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Transform = Transform;
			this.Color = Color;
			this.Radius = Radius;
			this.MinimumDegrees = MinimumDegrees;
			this.MaximumDegrees = MaximumDegrees;
			this.Thickness = Thickness;
			this.Detail = Detail;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x0006F5B0 File Offset: 0x0006D7B0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugArcItemSpace.StaticStruct();
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x0006F5BC File Offset: 0x0006D7BC
		[NullableContext(2)]
		public FRigUnit_DebugArcItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x0006F5C6 File Offset: 0x0006D7C6
		public FRigUnit_DebugArcItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x0006F5D1 File Offset: 0x0006D7D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugArcItemSpace(Pointer, false, true);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x0006F5DB File Offset: 0x0006D7DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugArcItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x0400245D RID: 9309
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugArcItemSpace";

		// Token: 0x0400245E RID: 9310
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400245F RID: 9311
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002460 RID: 9312
		internal static int __PropertyOffset_Color;

		// Token: 0x04002461 RID: 9313
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002462 RID: 9314
		internal static int __PropertyOffset_MinimumDegrees;

		// Token: 0x04002463 RID: 9315
		internal static int __PropertyOffset_MaximumDegrees;

		// Token: 0x04002464 RID: 9316
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002465 RID: 9317
		internal static int __PropertyOffset_Detail;

		// Token: 0x04002466 RID: 9318
		internal static int __PropertyOffset_Space;

		// Token: 0x04002467 RID: 9319
		[Nullable(2)]
		private FRigElementKey _Space;

		// Token: 0x04002468 RID: 9320
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x04002469 RID: 9321
		internal static int __PropertyOffset_bEnabled;
	}
}
