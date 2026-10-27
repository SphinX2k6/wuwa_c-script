using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002622 RID: 9762
	[UnrealObjectPath("/Script/OpacityMicroMap.OpacityMicromapDesc")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FOpacityMicromapDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060244B0 RID: 148656 RVA: 0x0035BBFA File Offset: 0x00359DFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOpacityMicromapDesc._ScriptStructPtr != 0) ? FOpacityMicromapDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OpacityMicroMap.OpacityMicromapDesc", ref FOpacityMicromapDesc._ScriptStructPtr);
		}

		// Token: 0x17008BBF RID: 35775
		// (get) Token: 0x060244B1 RID: 148657 RVA: 0x0035BC1E File Offset: 0x00359E1E
		// (set) Token: 0x060244B2 RID: 148658 RVA: 0x0035BC2E File Offset: 0x00359E2E
		public unsafe uint Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromapDesc.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromapDesc.__PropertyOffset_Offset) = (int)value;
			}
		}

		// Token: 0x17008BC0 RID: 35776
		// (get) Token: 0x060244B3 RID: 148659 RVA: 0x0035BC3F File Offset: 0x00359E3F
		// (set) Token: 0x060244B4 RID: 148660 RVA: 0x0035BC4F File Offset: 0x00359E4F
		public unsafe ushort SubdivisionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromapDesc.__PropertyOffset_SubdivisionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromapDesc.__PropertyOffset_SubdivisionLevel) = (short)value;
			}
		}

		// Token: 0x17008BC1 RID: 35777
		// (get) Token: 0x060244B5 RID: 148661 RVA: 0x0035BC60 File Offset: 0x00359E60
		// (set) Token: 0x060244B6 RID: 148662 RVA: 0x0035BC70 File Offset: 0x00359E70
		public unsafe ushort Format
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicromapDesc.__PropertyOffset_Format);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicromapDesc.__PropertyOffset_Format) = (short)value;
			}
		}

		// Token: 0x060244B7 RID: 148663 RVA: 0x0035BC81 File Offset: 0x00359E81
		public FOpacityMicromapDesc()
		{
		}

		// Token: 0x060244B8 RID: 148664 RVA: 0x0035BC89 File Offset: 0x00359E89
		public FOpacityMicromapDesc(uint Offset, ushort SubdivisionLevel, ushort Format)
		{
			this.Offset = Offset;
			this.SubdivisionLevel = SubdivisionLevel;
			this.Format = Format;
		}

		// Token: 0x060244B9 RID: 148665 RVA: 0x0035BCA6 File Offset: 0x00359EA6
		protected override IntPtr GetUStructPtr()
		{
			return FOpacityMicromapDesc.StaticStruct();
		}

		// Token: 0x060244BA RID: 148666 RVA: 0x0035BCB2 File Offset: 0x00359EB2
		[NullableContext(2)]
		public FOpacityMicromapDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060244BB RID: 148667 RVA: 0x0035BCBC File Offset: 0x00359EBC
		public FOpacityMicromapDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060244BC RID: 148668 RVA: 0x0035BCC7 File Offset: 0x00359EC7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOpacityMicromapDesc(Pointer, false, true);
		}

		// Token: 0x060244BD RID: 148669 RVA: 0x0035BCD1 File Offset: 0x00359ED1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOpacityMicromapDesc(Pointer, MemoryOwner);
		}

		// Token: 0x04013784 RID: 79748
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OpacityMicroMap.OpacityMicromapDesc";

		// Token: 0x04013785 RID: 79749
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013786 RID: 79750
		internal static int __PropertyOffset_Offset;

		// Token: 0x04013787 RID: 79751
		internal static int __PropertyOffset_SubdivisionLevel;

		// Token: 0x04013788 RID: 79752
		internal static int __PropertyOffset_Format;
	}
}
