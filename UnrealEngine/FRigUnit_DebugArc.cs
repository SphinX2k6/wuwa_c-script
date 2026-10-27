using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000580 RID: 1408
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugArc")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_DebugArc : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004AE8 RID: 19176 RVA: 0x0006F140 File Offset: 0x0006D340
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugArc._ScriptStructPtr != 0) ? FRigUnit_DebugArc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugArc", ref FRigUnit_DebugArc._ScriptStructPtr);
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06004AE9 RID: 19177 RVA: 0x0006F164 File Offset: 0x0006D364
		// (set) Token: 0x06004AEA RID: 19178 RVA: 0x0006F178 File Offset: 0x0006D378
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06004AEB RID: 19179 RVA: 0x0006F18D File Offset: 0x0006D38D
		// (set) Token: 0x06004AEC RID: 19180 RVA: 0x0006F1A1 File Offset: 0x0006D3A1
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06004AED RID: 19181 RVA: 0x0006F1B6 File Offset: 0x0006D3B6
		// (set) Token: 0x06004AEE RID: 19182 RVA: 0x0006F1C6 File Offset: 0x0006D3C6
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06004AEF RID: 19183 RVA: 0x0006F1D7 File Offset: 0x0006D3D7
		// (set) Token: 0x06004AF0 RID: 19184 RVA: 0x0006F1E7 File Offset: 0x0006D3E7
		public unsafe float MinimumDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_MinimumDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_MinimumDegrees) = value;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x0006F1F8 File Offset: 0x0006D3F8
		// (set) Token: 0x06004AF2 RID: 19186 RVA: 0x0006F208 File Offset: 0x0006D408
		public unsafe float MaximumDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_MaximumDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_MaximumDegrees) = value;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x0006F219 File Offset: 0x0006D419
		// (set) Token: 0x06004AF4 RID: 19188 RVA: 0x0006F229 File Offset: 0x0006D429
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x0006F23A File Offset: 0x0006D43A
		// (set) Token: 0x06004AF6 RID: 19190 RVA: 0x0006F24A File Offset: 0x0006D44A
		public unsafe int Detail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Detail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Detail) = value;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x0006F25B File Offset: 0x0006D45B
		// (set) Token: 0x06004AF8 RID: 19192 RVA: 0x0006F26F File Offset: 0x0006D46F
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x0006F284 File Offset: 0x0006D484
		// (set) Token: 0x06004AFA RID: 19194 RVA: 0x0006F298 File Offset: 0x0006D498
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x0006F2AD File Offset: 0x0006D4AD
		// (set) Token: 0x06004AFC RID: 19196 RVA: 0x0006F2BD File Offset: 0x0006D4BD
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugArc.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x0006F2CE File Offset: 0x0006D4CE
		public FRigUnit_DebugArc()
		{
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x0006F2D8 File Offset: 0x0006D4D8
		[NullableContext(1)]
		public FRigUnit_DebugArc(FTransform Transform, FLinearColor Color, float Radius, float MinimumDegrees, float MaximumDegrees, float Thickness, int Detail, FName Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
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

		// Token: 0x06004AFF RID: 19199 RVA: 0x0006F340 File Offset: 0x0006D540
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugArc.StaticStruct();
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x0006F34C File Offset: 0x0006D54C
		[NullableContext(2)]
		public FRigUnit_DebugArc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x0006F356 File Offset: 0x0006D556
		public FRigUnit_DebugArc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x0006F361 File Offset: 0x0006D561
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugArc(Pointer, false, true);
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x0006F36B File Offset: 0x0006D56B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugArc(Pointer, MemoryOwner);
		}

		// Token: 0x04002451 RID: 9297
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugArc";

		// Token: 0x04002452 RID: 9298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002453 RID: 9299
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002454 RID: 9300
		internal static int __PropertyOffset_Color;

		// Token: 0x04002455 RID: 9301
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002456 RID: 9302
		internal static int __PropertyOffset_MinimumDegrees;

		// Token: 0x04002457 RID: 9303
		internal static int __PropertyOffset_MaximumDegrees;

		// Token: 0x04002458 RID: 9304
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002459 RID: 9305
		internal static int __PropertyOffset_Detail;

		// Token: 0x0400245A RID: 9306
		internal static int __PropertyOffset_Space;

		// Token: 0x0400245B RID: 9307
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x0400245C RID: 9308
		internal static int __PropertyOffset_bEnabled;
	}
}
