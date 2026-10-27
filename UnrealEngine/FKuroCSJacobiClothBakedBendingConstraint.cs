using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017B0 RID: 6064
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSJacobiClothBakedBendingConstraint")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroCSJacobiClothBakedBendingConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060160A0 RID: 90272 RVA: 0x00204B3A File Offset: 0x00202D3A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSJacobiClothBakedBendingConstraint._ScriptStructPtr != 0) ? FKuroCSJacobiClothBakedBendingConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSJacobiClothBakedBendingConstraint", ref FKuroCSJacobiClothBakedBendingConstraint._ScriptStructPtr);
		}

		// Token: 0x170057D7 RID: 22487
		// (get) Token: 0x060160A1 RID: 90273 RVA: 0x00204B5E File Offset: 0x00202D5E
		// (set) Token: 0x060160A2 RID: 90274 RVA: 0x00204B6E File Offset: 0x00202D6E
		public unsafe int idx0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx0) = value;
			}
		}

		// Token: 0x170057D8 RID: 22488
		// (get) Token: 0x060160A3 RID: 90275 RVA: 0x00204B7F File Offset: 0x00202D7F
		// (set) Token: 0x060160A4 RID: 90276 RVA: 0x00204B8F File Offset: 0x00202D8F
		public unsafe int idx1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx1) = value;
			}
		}

		// Token: 0x170057D9 RID: 22489
		// (get) Token: 0x060160A5 RID: 90277 RVA: 0x00204BA0 File Offset: 0x00202DA0
		// (set) Token: 0x060160A6 RID: 90278 RVA: 0x00204BB0 File Offset: 0x00202DB0
		public unsafe int idx2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx2) = value;
			}
		}

		// Token: 0x170057DA RID: 22490
		// (get) Token: 0x060160A7 RID: 90279 RVA: 0x00204BC1 File Offset: 0x00202DC1
		// (set) Token: 0x060160A8 RID: 90280 RVA: 0x00204BD1 File Offset: 0x00202DD1
		public unsafe int idx3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_idx3) = value;
			}
		}

		// Token: 0x170057DB RID: 22491
		// (get) Token: 0x060160A9 RID: 90281 RVA: 0x00204BE2 File Offset: 0x00202DE2
		// (set) Token: 0x060160AA RID: 90282 RVA: 0x00204BF2 File Offset: 0x00202DF2
		public unsafe float restAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_restAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSJacobiClothBakedBendingConstraint.__PropertyOffset_restAngle) = value;
			}
		}

		// Token: 0x060160AB RID: 90283 RVA: 0x00204C03 File Offset: 0x00202E03
		public FKuroCSJacobiClothBakedBendingConstraint()
		{
		}

		// Token: 0x060160AC RID: 90284 RVA: 0x00204C0B File Offset: 0x00202E0B
		public FKuroCSJacobiClothBakedBendingConstraint(int idx0, int idx1, int idx2, int idx3, float restAngle)
		{
			this.idx0 = idx0;
			this.idx1 = idx1;
			this.idx2 = idx2;
			this.idx3 = idx3;
			this.restAngle = restAngle;
		}

		// Token: 0x060160AD RID: 90285 RVA: 0x00204C38 File Offset: 0x00202E38
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSJacobiClothBakedBendingConstraint.StaticStruct();
		}

		// Token: 0x060160AE RID: 90286 RVA: 0x00204C44 File Offset: 0x00202E44
		[NullableContext(2)]
		public FKuroCSJacobiClothBakedBendingConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060160AF RID: 90287 RVA: 0x00204C4E File Offset: 0x00202E4E
		public FKuroCSJacobiClothBakedBendingConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060160B0 RID: 90288 RVA: 0x00204C59 File Offset: 0x00202E59
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSJacobiClothBakedBendingConstraint(Pointer, false, true);
		}

		// Token: 0x060160B1 RID: 90289 RVA: 0x00204C63 File Offset: 0x00202E63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSJacobiClothBakedBendingConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x0400C019 RID: 49177
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSJacobiClothBakedBendingConstraint";

		// Token: 0x0400C01A RID: 49178
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C01B RID: 49179
		internal static int __PropertyOffset_idx0;

		// Token: 0x0400C01C RID: 49180
		internal static int __PropertyOffset_idx1;

		// Token: 0x0400C01D RID: 49181
		internal static int __PropertyOffset_idx2;

		// Token: 0x0400C01E RID: 49182
		internal static int __PropertyOffset_idx3;

		// Token: 0x0400C01F RID: 49183
		internal static int __PropertyOffset_restAngle;
	}
}
