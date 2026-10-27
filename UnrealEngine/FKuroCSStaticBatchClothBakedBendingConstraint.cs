using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017CE RID: 6094
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSStaticBatchClothBakedBendingConstraint")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroCSStaticBatchClothBakedBendingConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060166A6 RID: 91814 RVA: 0x0020C1CA File Offset: 0x0020A3CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSStaticBatchClothBakedBendingConstraint._ScriptStructPtr != 0) ? FKuroCSStaticBatchClothBakedBendingConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSStaticBatchClothBakedBendingConstraint", ref FKuroCSStaticBatchClothBakedBendingConstraint._ScriptStructPtr);
		}

		// Token: 0x17005A46 RID: 23110
		// (get) Token: 0x060166A7 RID: 91815 RVA: 0x0020C1EE File Offset: 0x0020A3EE
		// (set) Token: 0x060166A8 RID: 91816 RVA: 0x0020C1FE File Offset: 0x0020A3FE
		public unsafe int idx0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx0) = value;
			}
		}

		// Token: 0x17005A47 RID: 23111
		// (get) Token: 0x060166A9 RID: 91817 RVA: 0x0020C20F File Offset: 0x0020A40F
		// (set) Token: 0x060166AA RID: 91818 RVA: 0x0020C21F File Offset: 0x0020A41F
		public unsafe int idx1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx1) = value;
			}
		}

		// Token: 0x17005A48 RID: 23112
		// (get) Token: 0x060166AB RID: 91819 RVA: 0x0020C230 File Offset: 0x0020A430
		// (set) Token: 0x060166AC RID: 91820 RVA: 0x0020C240 File Offset: 0x0020A440
		public unsafe int idx2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx2) = value;
			}
		}

		// Token: 0x17005A49 RID: 23113
		// (get) Token: 0x060166AD RID: 91821 RVA: 0x0020C251 File Offset: 0x0020A451
		// (set) Token: 0x060166AE RID: 91822 RVA: 0x0020C261 File Offset: 0x0020A461
		public unsafe int idx3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_idx3) = value;
			}
		}

		// Token: 0x17005A4A RID: 23114
		// (get) Token: 0x060166AF RID: 91823 RVA: 0x0020C272 File Offset: 0x0020A472
		// (set) Token: 0x060166B0 RID: 91824 RVA: 0x0020C282 File Offset: 0x0020A482
		public unsafe float restAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_restAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBakedBendingConstraint.__PropertyOffset_restAngle) = value;
			}
		}

		// Token: 0x060166B1 RID: 91825 RVA: 0x0020C293 File Offset: 0x0020A493
		public FKuroCSStaticBatchClothBakedBendingConstraint()
		{
		}

		// Token: 0x060166B2 RID: 91826 RVA: 0x0020C29B File Offset: 0x0020A49B
		public FKuroCSStaticBatchClothBakedBendingConstraint(int idx0, int idx1, int idx2, int idx3, float restAngle)
		{
			this.idx0 = idx0;
			this.idx1 = idx1;
			this.idx2 = idx2;
			this.idx3 = idx3;
			this.restAngle = restAngle;
		}

		// Token: 0x060166B3 RID: 91827 RVA: 0x0020C2C8 File Offset: 0x0020A4C8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSStaticBatchClothBakedBendingConstraint.StaticStruct();
		}

		// Token: 0x060166B4 RID: 91828 RVA: 0x0020C2D4 File Offset: 0x0020A4D4
		[NullableContext(2)]
		public FKuroCSStaticBatchClothBakedBendingConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060166B5 RID: 91829 RVA: 0x0020C2DE File Offset: 0x0020A4DE
		public FKuroCSStaticBatchClothBakedBendingConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060166B6 RID: 91830 RVA: 0x0020C2E9 File Offset: 0x0020A4E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSStaticBatchClothBakedBendingConstraint(Pointer, false, true);
		}

		// Token: 0x060166B7 RID: 91831 RVA: 0x0020C2F3 File Offset: 0x0020A4F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSStaticBatchClothBakedBendingConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x0400C2EB RID: 49899
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSStaticBatchClothBakedBendingConstraint";

		// Token: 0x0400C2EC RID: 49900
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C2ED RID: 49901
		internal static int __PropertyOffset_idx0;

		// Token: 0x0400C2EE RID: 49902
		internal static int __PropertyOffset_idx1;

		// Token: 0x0400C2EF RID: 49903
		internal static int __PropertyOffset_idx2;

		// Token: 0x0400C2F0 RID: 49904
		internal static int __PropertyOffset_idx3;

		// Token: 0x0400C2F1 RID: 49905
		internal static int __PropertyOffset_restAngle;
	}
}
