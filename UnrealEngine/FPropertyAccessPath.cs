using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002669 RID: 9833
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccessPath")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FPropertyAccessPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060248A3 RID: 149667 RVA: 0x0036190C File Offset: 0x0035FB0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyAccessPath._ScriptStructPtr != 0) ? FPropertyAccessPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyAccess.PropertyAccessPath", ref FPropertyAccessPath._ScriptStructPtr);
		}

		// Token: 0x17008CD8 RID: 36056
		// (get) Token: 0x060248A4 RID: 149668 RVA: 0x00361930 File Offset: 0x0035FB30
		// (set) Token: 0x060248A5 RID: 149669 RVA: 0x00361940 File Offset: 0x0035FB40
		public unsafe int PathSegmentStartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessPath.__PropertyOffset_PathSegmentStartIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessPath.__PropertyOffset_PathSegmentStartIndex) = value;
			}
		}

		// Token: 0x17008CD9 RID: 36057
		// (get) Token: 0x060248A6 RID: 149670 RVA: 0x00361951 File Offset: 0x0035FB51
		// (set) Token: 0x060248A7 RID: 149671 RVA: 0x00361961 File Offset: 0x0035FB61
		public unsafe int PathSegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessPath.__PropertyOffset_PathSegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessPath.__PropertyOffset_PathSegmentCount) = value;
			}
		}

		// Token: 0x17008CDA RID: 36058
		// (get) Token: 0x060248A8 RID: 149672 RVA: 0x00361972 File Offset: 0x0035FB72
		// (set) Token: 0x060248A9 RID: 149673 RVA: 0x0036198B File Offset: 0x0035FB8B
		public unsafe bool bHasEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPropertyAccessPath.__PropertyOffset_bHasEvents) & FPropertyAccessPath.__PropertyMask_bHasEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPropertyAccessPath.__PropertyOffset_bHasEvents) = ((*(base.NativePtr + (IntPtr)FPropertyAccessPath.__PropertyOffset_bHasEvents) & ~FPropertyAccessPath.__PropertyMask_bHasEvents) | (value ? FPropertyAccessPath.__PropertyMask_bHasEvents : 0));
			}
		}

		// Token: 0x060248AA RID: 149674 RVA: 0x003619BB File Offset: 0x0035FBBB
		public FPropertyAccessPath()
		{
		}

		// Token: 0x060248AB RID: 149675 RVA: 0x003619C3 File Offset: 0x0035FBC3
		public FPropertyAccessPath(int PathSegmentStartIndex, int PathSegmentCount, bool bHasEvents)
		{
			this.PathSegmentStartIndex = PathSegmentStartIndex;
			this.PathSegmentCount = PathSegmentCount;
			this.bHasEvents = bHasEvents;
		}

		// Token: 0x060248AC RID: 149676 RVA: 0x003619E0 File Offset: 0x0035FBE0
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyAccessPath.StaticStruct();
		}

		// Token: 0x060248AD RID: 149677 RVA: 0x003619EC File Offset: 0x0035FBEC
		[NullableContext(2)]
		public FPropertyAccessPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060248AE RID: 149678 RVA: 0x003619F6 File Offset: 0x0035FBF6
		public FPropertyAccessPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060248AF RID: 149679 RVA: 0x00361A01 File Offset: 0x0035FC01
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyAccessPath(Pointer, false, true);
		}

		// Token: 0x060248B0 RID: 149680 RVA: 0x00361A0B File Offset: 0x0035FC0B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyAccessPath(Pointer, MemoryOwner);
		}

		// Token: 0x04013A22 RID: 80418
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccessPath";

		// Token: 0x04013A23 RID: 80419
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013A24 RID: 80420
		internal static int __PropertyOffset_PathSegmentStartIndex;

		// Token: 0x04013A25 RID: 80421
		internal static int __PropertyOffset_PathSegmentCount;

		// Token: 0x04013A26 RID: 80422
		internal static int __PropertyOffset_bHasEvents;

		// Token: 0x04013A27 RID: 80423
		internal static byte __PropertyMask_bHasEvents;
	}
}
