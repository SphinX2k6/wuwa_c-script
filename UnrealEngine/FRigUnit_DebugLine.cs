using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000587 RID: 1415
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugLine")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FRigUnit_DebugLine : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B75 RID: 19317 RVA: 0x0006FCC6 File Offset: 0x0006DEC6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugLine._ScriptStructPtr != 0) ? FRigUnit_DebugLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugLine", ref FRigUnit_DebugLine._ScriptStructPtr);
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x0006FCEA File Offset: 0x0006DEEA
		// (set) Token: 0x06004B77 RID: 19319 RVA: 0x0006FCFE File Offset: 0x0006DEFE
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x0006FD13 File Offset: 0x0006DF13
		// (set) Token: 0x06004B79 RID: 19321 RVA: 0x0006FD27 File Offset: 0x0006DF27
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x0006FD3C File Offset: 0x0006DF3C
		// (set) Token: 0x06004B7B RID: 19323 RVA: 0x0006FD50 File Offset: 0x0006DF50
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x0006FD65 File Offset: 0x0006DF65
		// (set) Token: 0x06004B7D RID: 19325 RVA: 0x0006FD75 File Offset: 0x0006DF75
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x0006FD86 File Offset: 0x0006DF86
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x0006FD9A File Offset: 0x0006DF9A
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x0006FDAF File Offset: 0x0006DFAF
		// (set) Token: 0x06004B81 RID: 19329 RVA: 0x0006FDC3 File Offset: 0x0006DFC3
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x0006FDD8 File Offset: 0x0006DFD8
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x0006FDE8 File Offset: 0x0006DFE8
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLine.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x0006FDF9 File Offset: 0x0006DFF9
		public FRigUnit_DebugLine()
		{
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x0006FE04 File Offset: 0x0006E004
		[NullableContext(1)]
		public FRigUnit_DebugLine(FVector A, FVector B, FLinearColor Color, float Thickness, FName Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.A = A;
			this.B = B;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x0006FE54 File Offset: 0x0006E054
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugLine.StaticStruct();
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x0006FE60 File Offset: 0x0006E060
		[NullableContext(2)]
		public FRigUnit_DebugLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x0006FE6A File Offset: 0x0006E06A
		public FRigUnit_DebugLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x0006FE75 File Offset: 0x0006E075
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugLine(Pointer, false, true);
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x0006FE7F File Offset: 0x0006E07F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugLine(Pointer, MemoryOwner);
		}

		// Token: 0x0400248E RID: 9358
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugLine";

		// Token: 0x0400248F RID: 9359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002490 RID: 9360
		internal static int __PropertyOffset_A;

		// Token: 0x04002491 RID: 9361
		internal static int __PropertyOffset_B;

		// Token: 0x04002492 RID: 9362
		internal static int __PropertyOffset_Color;

		// Token: 0x04002493 RID: 9363
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002494 RID: 9364
		internal static int __PropertyOffset_Space;

		// Token: 0x04002495 RID: 9365
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x04002496 RID: 9366
		internal static int __PropertyOffset_bEnabled;
	}
}
