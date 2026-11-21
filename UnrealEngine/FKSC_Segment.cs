using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000586 RID: 1414
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Segment")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKSC_Segment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008050 RID: 32848 RVA: 0x000BDA3E File Offset: 0x000BBC3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Segment._ScriptStructPtr != 0) ? FKSC_Segment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Segment", ref FKSC_Segment._ScriptStructPtr);
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06008051 RID: 32849 RVA: 0x000BDA62 File Offset: 0x000BBC62
		// (set) Token: 0x06008052 RID: 32850 RVA: 0x000BDA76 File Offset: 0x000BBC76
		public unsafe FVector PointA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointA) = value;
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06008053 RID: 32851 RVA: 0x000BDA8B File Offset: 0x000BBC8B
		// (set) Token: 0x06008054 RID: 32852 RVA: 0x000BDA9F File Offset: 0x000BBC9F
		public unsafe FVector PointB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Segment.__PropertyOffset_PointB) = value;
			}
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x000BDAB4 File Offset: 0x000BBCB4
		public FKSC_Segment()
		{
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x000BDABC File Offset: 0x000BBCBC
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Segment.StaticStruct();
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x000BDAC8 File Offset: 0x000BBCC8
		[NullableContext(2)]
		public FKSC_Segment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x000BDAD2 File Offset: 0x000BBCD2
		public FKSC_Segment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x000BDADD File Offset: 0x000BBCDD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Segment(Pointer, false, true);
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x000BDAE7 File Offset: 0x000BBCE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Segment(Pointer, MemoryOwner);
		}

		// Token: 0x04003809 RID: 14345
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Segment";

		// Token: 0x0400380A RID: 14346
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400380B RID: 14347
		internal static int __PropertyOffset_PointA;

		// Token: 0x0400380C RID: 14348
		internal static int __PropertyOffset_PointB;
	}
}
