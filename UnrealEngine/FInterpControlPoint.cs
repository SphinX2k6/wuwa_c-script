using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C77 RID: 3191
	[UnrealObjectPath("/Script/Engine.InterpControlPoint")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FInterpControlPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A212 RID: 41490 RVA: 0x000E6200 File Offset: 0x000E4400
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpControlPoint._ScriptStructPtr != 0) ? FInterpControlPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InterpControlPoint", ref FInterpControlPoint._ScriptStructPtr);
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x0600A213 RID: 41491 RVA: 0x000E6224 File Offset: 0x000E4424
		// (set) Token: 0x0600A214 RID: 41492 RVA: 0x000E6238 File Offset: 0x000E4438
		public unsafe FVector PositionControlPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpControlPoint.__PropertyOffset_PositionControlPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpControlPoint.__PropertyOffset_PositionControlPoint) = value;
			}
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x000E624D File Offset: 0x000E444D
		// (set) Token: 0x0600A216 RID: 41494 RVA: 0x000E625D File Offset: 0x000E445D
		public unsafe bool bPositionIsRelative
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpControlPoint.__PropertyOffset_bPositionIsRelative) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpControlPoint.__PropertyOffset_bPositionIsRelative) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x000E626E File Offset: 0x000E446E
		public FInterpControlPoint()
		{
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x000E6276 File Offset: 0x000E4476
		public FInterpControlPoint(FVector PositionControlPoint, bool bPositionIsRelative)
		{
			this.PositionControlPoint = PositionControlPoint;
			this.bPositionIsRelative = bPositionIsRelative;
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x000E628C File Offset: 0x000E448C
		protected override IntPtr GetUStructPtr()
		{
			return FInterpControlPoint.StaticStruct();
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x000E6298 File Offset: 0x000E4498
		[NullableContext(2)]
		public FInterpControlPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x000E62A2 File Offset: 0x000E44A2
		public FInterpControlPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x000E62AD File Offset: 0x000E44AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpControlPoint(Pointer, false, true);
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x000E62B7 File Offset: 0x000E44B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpControlPoint(Pointer, MemoryOwner);
		}

		// Token: 0x040058EF RID: 22767
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InterpControlPoint";

		// Token: 0x040058F0 RID: 22768
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058F1 RID: 22769
		internal static int __PropertyOffset_PositionControlPoint;

		// Token: 0x040058F2 RID: 22770
		internal static int __PropertyOffset_bPositionIsRelative;
	}
}
