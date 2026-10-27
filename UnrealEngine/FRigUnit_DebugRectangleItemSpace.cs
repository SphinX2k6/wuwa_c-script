using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058E RID: 1422
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugRectangleItemSpace")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_DebugRectangleItemSpace : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004C0F RID: 19471 RVA: 0x00070988 File Offset: 0x0006EB88
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugRectangleItemSpace._ScriptStructPtr != 0) ? FRigUnit_DebugRectangleItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugRectangleItemSpace", ref FRigUnit_DebugRectangleItemSpace._ScriptStructPtr);
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x000709AC File Offset: 0x0006EBAC
		// (set) Token: 0x06004C11 RID: 19473 RVA: 0x000709C0 File Offset: 0x0006EBC0
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x000709D5 File Offset: 0x0006EBD5
		// (set) Token: 0x06004C13 RID: 19475 RVA: 0x000709E9 File Offset: 0x0006EBE9
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06004C14 RID: 19476 RVA: 0x000709FE File Offset: 0x0006EBFE
		// (set) Token: 0x06004C15 RID: 19477 RVA: 0x00070A0E File Offset: 0x0006EC0E
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06004C16 RID: 19478 RVA: 0x00070A1F File Offset: 0x0006EC1F
		// (set) Token: 0x06004C17 RID: 19479 RVA: 0x00070A2F File Offset: 0x0006EC2F
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06004C18 RID: 19480 RVA: 0x00070A40 File Offset: 0x0006EC40
		// (set) Token: 0x06004C19 RID: 19481 RVA: 0x00070A83 File Offset: 0x0006EC83
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06004C1A RID: 19482 RVA: 0x00070AA4 File Offset: 0x0006ECA4
		// (set) Token: 0x06004C1B RID: 19483 RVA: 0x00070AB8 File Offset: 0x0006ECB8
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06004C1C RID: 19484 RVA: 0x00070ACD File Offset: 0x0006ECCD
		// (set) Token: 0x06004C1D RID: 19485 RVA: 0x00070ADD File Offset: 0x0006ECDD
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugRectangleItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00070AEE File Offset: 0x0006ECEE
		public FRigUnit_DebugRectangleItemSpace()
		{
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00070AF8 File Offset: 0x0006ECF8
		public FRigUnit_DebugRectangleItemSpace(FTransform Transform, FLinearColor Color, float Scale, float Thickness, FRigElementKey Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
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

		// Token: 0x06004C20 RID: 19488 RVA: 0x00070B48 File Offset: 0x0006ED48
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugRectangleItemSpace.StaticStruct();
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00070B54 File Offset: 0x0006ED54
		[NullableContext(2)]
		public FRigUnit_DebugRectangleItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00070B5E File Offset: 0x0006ED5E
		public FRigUnit_DebugRectangleItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00070B69 File Offset: 0x0006ED69
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugRectangleItemSpace(Pointer, false, true);
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x00070B73 File Offset: 0x0006ED73
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugRectangleItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x040024D1 RID: 9425
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugRectangleItemSpace";

		// Token: 0x040024D2 RID: 9426
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024D3 RID: 9427
		internal static int __PropertyOffset_Transform;

		// Token: 0x040024D4 RID: 9428
		internal static int __PropertyOffset_Color;

		// Token: 0x040024D5 RID: 9429
		internal static int __PropertyOffset_Scale;

		// Token: 0x040024D6 RID: 9430
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024D7 RID: 9431
		internal static int __PropertyOffset_Space;

		// Token: 0x040024D8 RID: 9432
		[Nullable(2)]
		private FRigElementKey _Space;

		// Token: 0x040024D9 RID: 9433
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024DA RID: 9434
		internal static int __PropertyOffset_bEnabled;
	}
}
