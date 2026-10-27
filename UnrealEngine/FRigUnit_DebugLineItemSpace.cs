using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000588 RID: 1416
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugLineItemSpace")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FRigUnit_DebugLineItemSpace : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B8B RID: 19339 RVA: 0x0006FE88 File Offset: 0x0006E088
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugLineItemSpace._ScriptStructPtr != 0) ? FRigUnit_DebugLineItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugLineItemSpace", ref FRigUnit_DebugLineItemSpace._ScriptStructPtr);
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06004B8C RID: 19340 RVA: 0x0006FEAC File Offset: 0x0006E0AC
		// (set) Token: 0x06004B8D RID: 19341 RVA: 0x0006FEC0 File Offset: 0x0006E0C0
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x0006FED5 File Offset: 0x0006E0D5
		// (set) Token: 0x06004B8F RID: 19343 RVA: 0x0006FEE9 File Offset: 0x0006E0E9
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06004B90 RID: 19344 RVA: 0x0006FEFE File Offset: 0x0006E0FE
		// (set) Token: 0x06004B91 RID: 19345 RVA: 0x0006FF12 File Offset: 0x0006E112
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06004B92 RID: 19346 RVA: 0x0006FF27 File Offset: 0x0006E127
		// (set) Token: 0x06004B93 RID: 19347 RVA: 0x0006FF37 File Offset: 0x0006E137
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x0006FF48 File Offset: 0x0006E148
		// (set) Token: 0x06004B95 RID: 19349 RVA: 0x0006FF8B File Offset: 0x0006E18B
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06004B96 RID: 19350 RVA: 0x0006FFAC File Offset: 0x0006E1AC
		// (set) Token: 0x06004B97 RID: 19351 RVA: 0x0006FFC0 File Offset: 0x0006E1C0
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06004B98 RID: 19352 RVA: 0x0006FFD5 File Offset: 0x0006E1D5
		// (set) Token: 0x06004B99 RID: 19353 RVA: 0x0006FFE5 File Offset: 0x0006E1E5
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugLineItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x0006FFF6 File Offset: 0x0006E1F6
		public FRigUnit_DebugLineItemSpace()
		{
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00070000 File Offset: 0x0006E200
		public FRigUnit_DebugLineItemSpace(FVector A, FVector B, FLinearColor Color, float Thickness, FRigElementKey Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
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

		// Token: 0x06004B9C RID: 19356 RVA: 0x00070050 File Offset: 0x0006E250
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugLineItemSpace.StaticStruct();
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x0007005C File Offset: 0x0006E25C
		[NullableContext(2)]
		public FRigUnit_DebugLineItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00070066 File Offset: 0x0006E266
		public FRigUnit_DebugLineItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00070071 File Offset: 0x0006E271
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugLineItemSpace(Pointer, false, true);
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x0007007B File Offset: 0x0006E27B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugLineItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x04002497 RID: 9367
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugLineItemSpace";

		// Token: 0x04002498 RID: 9368
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002499 RID: 9369
		internal static int __PropertyOffset_A;

		// Token: 0x0400249A RID: 9370
		internal static int __PropertyOffset_B;

		// Token: 0x0400249B RID: 9371
		internal static int __PropertyOffset_Color;

		// Token: 0x0400249C RID: 9372
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400249D RID: 9373
		internal static int __PropertyOffset_Space;

		// Token: 0x0400249E RID: 9374
		[Nullable(2)]
		private FRigElementKey _Space;

		// Token: 0x0400249F RID: 9375
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024A0 RID: 9376
		internal static int __PropertyOffset_bEnabled;
	}
}
