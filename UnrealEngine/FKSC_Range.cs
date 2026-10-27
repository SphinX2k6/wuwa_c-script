using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E14 RID: 7700
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Range")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKSC_Range : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D611 RID: 120337 RVA: 0x002B5E5B File Offset: 0x002B405B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Range._ScriptStructPtr != 0) ? FKSC_Range._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Range", ref FKSC_Range._ScriptStructPtr);
		}

		// Token: 0x17007680 RID: 30336
		// (get) Token: 0x0601D612 RID: 120338 RVA: 0x002B5E7F File Offset: 0x002B407F
		// (set) Token: 0x0601D613 RID: 120339 RVA: 0x002B5E8F File Offset: 0x002B408F
		public unsafe EKSC_ShapeType RangeShapeType
		{
			get
			{
				return (EKSC_ShapeType)(*(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_RangeShapeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_RangeShapeType) = (byte)value;
			}
		}

		// Token: 0x17007681 RID: 30337
		// (get) Token: 0x0601D614 RID: 120340 RVA: 0x002B5EA0 File Offset: 0x002B40A0
		// (set) Token: 0x0601D615 RID: 120341 RVA: 0x002B5EB4 File Offset: 0x002B40B4
		public unsafe FTransform OffsetTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_OffsetTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_OffsetTrans) = value;
			}
		}

		// Token: 0x17007682 RID: 30338
		// (get) Token: 0x0601D616 RID: 120342 RVA: 0x002B5EC9 File Offset: 0x002B40C9
		// (set) Token: 0x0601D617 RID: 120343 RVA: 0x002B5EDD File Offset: 0x002B40DD
		public unsafe FVector HalfExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_HalfExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_HalfExtent) = value;
			}
		}

		// Token: 0x17007683 RID: 30339
		// (get) Token: 0x0601D618 RID: 120344 RVA: 0x002B5EF2 File Offset: 0x002B40F2
		// (set) Token: 0x0601D619 RID: 120345 RVA: 0x002B5F02 File Offset: 0x002B4102
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Range.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x0601D61A RID: 120346 RVA: 0x002B5F13 File Offset: 0x002B4113
		public FKSC_Range()
		{
		}

		// Token: 0x0601D61B RID: 120347 RVA: 0x002B5F1B File Offset: 0x002B411B
		public FKSC_Range(EKSC_ShapeType RangeShapeType, FTransform OffsetTrans, FVector HalfExtent, float Radius)
		{
			this.RangeShapeType = RangeShapeType;
			this.OffsetTrans = OffsetTrans;
			this.HalfExtent = HalfExtent;
			this.Radius = Radius;
		}

		// Token: 0x0601D61C RID: 120348 RVA: 0x002B5F40 File Offset: 0x002B4140
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Range.StaticStruct();
		}

		// Token: 0x0601D61D RID: 120349 RVA: 0x002B5F4C File Offset: 0x002B414C
		[NullableContext(2)]
		public FKSC_Range(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D61E RID: 120350 RVA: 0x002B5F56 File Offset: 0x002B4156
		public FKSC_Range(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D61F RID: 120351 RVA: 0x002B5F61 File Offset: 0x002B4161
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Range(Pointer, false, true);
		}

		// Token: 0x0601D620 RID: 120352 RVA: 0x002B5F6B File Offset: 0x002B416B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Range(Pointer, MemoryOwner);
		}

		// Token: 0x0400FEF4 RID: 65268
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Range";

		// Token: 0x0400FEF5 RID: 65269
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FEF6 RID: 65270
		internal static int __PropertyOffset_RangeShapeType;

		// Token: 0x0400FEF7 RID: 65271
		internal static int __PropertyOffset_OffsetTrans;

		// Token: 0x0400FEF8 RID: 65272
		internal static int __PropertyOffset_HalfExtent;

		// Token: 0x0400FEF9 RID: 65273
		internal static int __PropertyOffset_Radius;
	}
}
