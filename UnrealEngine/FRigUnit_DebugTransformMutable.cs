using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000592 RID: 1426
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugTransformMutable")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_DebugTransformMutable : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004C61 RID: 19553 RVA: 0x00071088 File Offset: 0x0006F288
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugTransformMutable._ScriptStructPtr != 0) ? FRigUnit_DebugTransformMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugTransformMutable", ref FRigUnit_DebugTransformMutable._ScriptStructPtr);
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x000710AC File Offset: 0x0006F2AC
		// (set) Token: 0x06004C63 RID: 19555 RVA: 0x000710C0 File Offset: 0x0006F2C0
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x000710D5 File Offset: 0x0006F2D5
		// (set) Token: 0x06004C65 RID: 19557 RVA: 0x000710E5 File Offset: 0x0006F2E5
		public unsafe ERigUnitDebugTransformMode Mode
		{
			get
			{
				return (ERigUnitDebugTransformMode)(*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06004C66 RID: 19558 RVA: 0x000710F6 File Offset: 0x0006F2F6
		// (set) Token: 0x06004C67 RID: 19559 RVA: 0x0007110A File Offset: 0x0006F30A
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x0007111F File Offset: 0x0006F31F
		// (set) Token: 0x06004C69 RID: 19561 RVA: 0x0007112F File Offset: 0x0006F32F
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06004C6A RID: 19562 RVA: 0x00071140 File Offset: 0x0006F340
		// (set) Token: 0x06004C6B RID: 19563 RVA: 0x00071150 File Offset: 0x0006F350
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06004C6C RID: 19564 RVA: 0x00071161 File Offset: 0x0006F361
		// (set) Token: 0x06004C6D RID: 19565 RVA: 0x00071175 File Offset: 0x0006F375
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x0007118A File Offset: 0x0006F38A
		// (set) Token: 0x06004C6F RID: 19567 RVA: 0x0007119E File Offset: 0x0006F39E
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x000711B3 File Offset: 0x0006F3B3
		// (set) Token: 0x06004C71 RID: 19569 RVA: 0x000711C3 File Offset: 0x0006F3C3
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutable.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x000711D4 File Offset: 0x0006F3D4
		public FRigUnit_DebugTransformMutable()
		{
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x000711DC File Offset: 0x0006F3DC
		[NullableContext(1)]
		public FRigUnit_DebugTransformMutable(FTransform Transform, ERigUnitDebugTransformMode Mode, FLinearColor Color, float Thickness, float Scale, FName Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Transform = Transform;
			this.Mode = Mode;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00071234 File Offset: 0x0006F434
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugTransformMutable.StaticStruct();
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00071240 File Offset: 0x0006F440
		[NullableContext(2)]
		public FRigUnit_DebugTransformMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x0007124A File Offset: 0x0006F44A
		public FRigUnit_DebugTransformMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00071255 File Offset: 0x0006F455
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugTransformMutable(Pointer, false, true);
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x0007125F File Offset: 0x0006F45F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugTransformMutable(Pointer, MemoryOwner);
		}

		// Token: 0x040024F6 RID: 9462
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugTransformMutable";

		// Token: 0x040024F7 RID: 9463
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024F8 RID: 9464
		internal static int __PropertyOffset_Transform;

		// Token: 0x040024F9 RID: 9465
		internal static int __PropertyOffset_Mode;

		// Token: 0x040024FA RID: 9466
		internal static int __PropertyOffset_Color;

		// Token: 0x040024FB RID: 9467
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024FC RID: 9468
		internal static int __PropertyOffset_Scale;

		// Token: 0x040024FD RID: 9469
		internal static int __PropertyOffset_Space;

		// Token: 0x040024FE RID: 9470
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024FF RID: 9471
		internal static int __PropertyOffset_bEnabled;
	}
}
