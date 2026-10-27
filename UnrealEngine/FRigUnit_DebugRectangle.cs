using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200058D RID: 1421
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugRectangle")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_DebugRectangle : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004BF9 RID: 19449 RVA: 0x000707D0 File Offset: 0x0006E9D0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugRectangle._ScriptStructPtr != 0) ? FRigUnit_DebugRectangle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugRectangle", ref FRigUnit_DebugRectangle._ScriptStructPtr);
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x000707F4 File Offset: 0x0006E9F4
		// (set) Token: 0x06004BFB RID: 19451 RVA: 0x00070808 File Offset: 0x0006EA08
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x0007081D File Offset: 0x0006EA1D
		// (set) Token: 0x06004BFD RID: 19453 RVA: 0x00070831 File Offset: 0x0006EA31
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06004BFE RID: 19454 RVA: 0x00070846 File Offset: 0x0006EA46
		// (set) Token: 0x06004BFF RID: 19455 RVA: 0x00070856 File Offset: 0x0006EA56
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x00070867 File Offset: 0x0006EA67
		// (set) Token: 0x06004C01 RID: 19457 RVA: 0x00070877 File Offset: 0x0006EA77
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x00070888 File Offset: 0x0006EA88
		// (set) Token: 0x06004C03 RID: 19459 RVA: 0x0007089C File Offset: 0x0006EA9C
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06004C04 RID: 19460 RVA: 0x000708B1 File Offset: 0x0006EAB1
		// (set) Token: 0x06004C05 RID: 19461 RVA: 0x000708C5 File Offset: 0x0006EAC5
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x000708DA File Offset: 0x0006EADA
		// (set) Token: 0x06004C07 RID: 19463 RVA: 0x000708EA File Offset: 0x0006EAEA
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangle.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x000708FB File Offset: 0x0006EAFB
		public FRigUnit_DebugRectangle()
		{
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00070904 File Offset: 0x0006EB04
		[NullableContext(1)]
		public FRigUnit_DebugRectangle(FTransform Transform, FLinearColor Color, float Scale, float Thickness, FName Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Transform = Transform;
			this.Color = Color;
			this.Scale = Scale;
			this.Thickness = Thickness;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00070954 File Offset: 0x0006EB54
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugRectangle.StaticStruct();
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00070960 File Offset: 0x0006EB60
		[NullableContext(2)]
		public FRigUnit_DebugRectangle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x0007096A File Offset: 0x0006EB6A
		public FRigUnit_DebugRectangle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x00070975 File Offset: 0x0006EB75
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugRectangle(Pointer, false, true);
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x0007097F File Offset: 0x0006EB7F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugRectangle(Pointer, MemoryOwner);
		}

		// Token: 0x040024C8 RID: 9416
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugRectangle";

		// Token: 0x040024C9 RID: 9417
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024CA RID: 9418
		internal static int __PropertyOffset_Transform;

		// Token: 0x040024CB RID: 9419
		internal static int __PropertyOffset_Color;

		// Token: 0x040024CC RID: 9420
		internal static int __PropertyOffset_Scale;

		// Token: 0x040024CD RID: 9421
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024CE RID: 9422
		internal static int __PropertyOffset_Space;

		// Token: 0x040024CF RID: 9423
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024D0 RID: 9424
		internal static int __PropertyOffset_bEnabled;
	}
}
