using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A99 RID: 6809
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FS_Segment2D")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFS_Segment2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060191D4 RID: 102868 RVA: 0x00251D9D File Offset: 0x0024FF9D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFS_Segment2D._ScriptStructPtr != 0) ? FFS_Segment2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.FS_Segment2D", ref FFS_Segment2D._ScriptStructPtr);
		}

		// Token: 0x170063BE RID: 25534
		// (get) Token: 0x060191D5 RID: 102869 RVA: 0x00251DC1 File Offset: 0x0024FFC1
		// (set) Token: 0x060191D6 RID: 102870 RVA: 0x00251DD5 File Offset: 0x0024FFD5
		public unsafe FVector2D A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_Segment2D.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_Segment2D.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170063BF RID: 25535
		// (get) Token: 0x060191D7 RID: 102871 RVA: 0x00251DEA File Offset: 0x0024FFEA
		// (set) Token: 0x060191D8 RID: 102872 RVA: 0x00251DFE File Offset: 0x0024FFFE
		public unsafe FVector2D B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFS_Segment2D.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFS_Segment2D.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x060191D9 RID: 102873 RVA: 0x00251E13 File Offset: 0x00250013
		public FFS_Segment2D()
		{
		}

		// Token: 0x060191DA RID: 102874 RVA: 0x00251E1B File Offset: 0x0025001B
		public FFS_Segment2D(FVector2D A, FVector2D B)
		{
			this.A = A;
			this.B = B;
		}

		// Token: 0x060191DB RID: 102875 RVA: 0x00251E31 File Offset: 0x00250031
		protected override IntPtr GetUStructPtr()
		{
			return FFS_Segment2D.StaticStruct();
		}

		// Token: 0x060191DC RID: 102876 RVA: 0x00251E3D File Offset: 0x0025003D
		[NullableContext(2)]
		public FFS_Segment2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060191DD RID: 102877 RVA: 0x00251E47 File Offset: 0x00250047
		public FFS_Segment2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060191DE RID: 102878 RVA: 0x00251E52 File Offset: 0x00250052
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFS_Segment2D(Pointer, false, true);
		}

		// Token: 0x060191DF RID: 102879 RVA: 0x00251E5C File Offset: 0x0025005C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFS_Segment2D(Pointer, MemoryOwner);
		}

		// Token: 0x0400DAF5 RID: 56053
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FS_Segment2D";

		// Token: 0x0400DAF6 RID: 56054
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DAF7 RID: 56055
		internal static int __PropertyOffset_A;

		// Token: 0x0400DAF8 RID: 56056
		internal static int __PropertyOffset_B;
	}
}
