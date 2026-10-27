using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000586 RID: 1414
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugHierarchy")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_DebugHierarchy : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B63 RID: 19299 RVA: 0x0006FB7C File Offset: 0x0006DD7C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugHierarchy._ScriptStructPtr != 0) ? FRigUnit_DebugHierarchy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugHierarchy", ref FRigUnit_DebugHierarchy._ScriptStructPtr);
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x0006FBA0 File Offset: 0x0006DDA0
		// (set) Token: 0x06004B65 RID: 19301 RVA: 0x0006FBB0 File Offset: 0x0006DDB0
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x0006FBC1 File Offset: 0x0006DDC1
		// (set) Token: 0x06004B67 RID: 19303 RVA: 0x0006FBD5 File Offset: 0x0006DDD5
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06004B68 RID: 19304 RVA: 0x0006FBEA File Offset: 0x0006DDEA
		// (set) Token: 0x06004B69 RID: 19305 RVA: 0x0006FBFA File Offset: 0x0006DDFA
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06004B6A RID: 19306 RVA: 0x0006FC0B File Offset: 0x0006DE0B
		// (set) Token: 0x06004B6B RID: 19307 RVA: 0x0006FC1F File Offset: 0x0006DE1F
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x0006FC34 File Offset: 0x0006DE34
		// (set) Token: 0x06004B6D RID: 19309 RVA: 0x0006FC44 File Offset: 0x0006DE44
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugHierarchy.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x0006FC55 File Offset: 0x0006DE55
		public FRigUnit_DebugHierarchy()
		{
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x0006FC5D File Offset: 0x0006DE5D
		[NullableContext(1)]
		public FRigUnit_DebugHierarchy(float Scale, FLinearColor Color, float Thickness, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Scale = Scale;
			this.Color = Color;
			this.Thickness = Thickness;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x0006FC92 File Offset: 0x0006DE92
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugHierarchy.StaticStruct();
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x0006FC9E File Offset: 0x0006DE9E
		[NullableContext(2)]
		public FRigUnit_DebugHierarchy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x0006FCA8 File Offset: 0x0006DEA8
		public FRigUnit_DebugHierarchy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x0006FCB3 File Offset: 0x0006DEB3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugHierarchy(Pointer, false, true);
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x0006FCBD File Offset: 0x0006DEBD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugHierarchy(Pointer, MemoryOwner);
		}

		// Token: 0x04002487 RID: 9351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugHierarchy";

		// Token: 0x04002488 RID: 9352
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002489 RID: 9353
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400248A RID: 9354
		internal static int __PropertyOffset_Color;

		// Token: 0x0400248B RID: 9355
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400248C RID: 9356
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x0400248D RID: 9357
		internal static int __PropertyOffset_bEnabled;
	}
}
