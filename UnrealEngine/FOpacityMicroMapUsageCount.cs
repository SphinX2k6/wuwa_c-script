using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002624 RID: 9764
	[UnrealObjectPath("/Script/OpacityMicroMap.OpacityMicroMapUsageCount")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FOpacityMicroMapUsageCount : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060244D7 RID: 148695 RVA: 0x0035BECB File Offset: 0x0035A0CB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOpacityMicroMapUsageCount._ScriptStructPtr != 0) ? FOpacityMicroMapUsageCount._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OpacityMicroMap.OpacityMicroMapUsageCount", ref FOpacityMicroMapUsageCount._ScriptStructPtr);
		}

		// Token: 0x17008BCC RID: 35788
		// (get) Token: 0x060244D8 RID: 148696 RVA: 0x0035BEEF File Offset: 0x0035A0EF
		// (set) Token: 0x060244D9 RID: 148697 RVA: 0x0035BEFF File Offset: 0x0035A0FF
		public unsafe uint Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicroMapUsageCount.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicroMapUsageCount.__PropertyOffset_Count) = (int)value;
			}
		}

		// Token: 0x17008BCD RID: 35789
		// (get) Token: 0x060244DA RID: 148698 RVA: 0x0035BF10 File Offset: 0x0035A110
		// (set) Token: 0x060244DB RID: 148699 RVA: 0x0035BF20 File Offset: 0x0035A120
		public unsafe uint SubdivisionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicroMapUsageCount.__PropertyOffset_SubdivisionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicroMapUsageCount.__PropertyOffset_SubdivisionLevel) = (int)value;
			}
		}

		// Token: 0x17008BCE RID: 35790
		// (get) Token: 0x060244DC RID: 148700 RVA: 0x0035BF31 File Offset: 0x0035A131
		// (set) Token: 0x060244DD RID: 148701 RVA: 0x0035BF41 File Offset: 0x0035A141
		public unsafe uint Format
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMicroMapUsageCount.__PropertyOffset_Format);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMicroMapUsageCount.__PropertyOffset_Format) = (int)value;
			}
		}

		// Token: 0x060244DE RID: 148702 RVA: 0x0035BF52 File Offset: 0x0035A152
		public FOpacityMicroMapUsageCount()
		{
		}

		// Token: 0x060244DF RID: 148703 RVA: 0x0035BF5A File Offset: 0x0035A15A
		public FOpacityMicroMapUsageCount(uint Count, uint SubdivisionLevel, uint Format)
		{
			this.Count = Count;
			this.SubdivisionLevel = SubdivisionLevel;
			this.Format = Format;
		}

		// Token: 0x060244E0 RID: 148704 RVA: 0x0035BF77 File Offset: 0x0035A177
		protected override IntPtr GetUStructPtr()
		{
			return FOpacityMicroMapUsageCount.StaticStruct();
		}

		// Token: 0x060244E1 RID: 148705 RVA: 0x0035BF83 File Offset: 0x0035A183
		[NullableContext(2)]
		public FOpacityMicroMapUsageCount(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060244E2 RID: 148706 RVA: 0x0035BF8D File Offset: 0x0035A18D
		public FOpacityMicroMapUsageCount(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060244E3 RID: 148707 RVA: 0x0035BF98 File Offset: 0x0035A198
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOpacityMicroMapUsageCount(Pointer, false, true);
		}

		// Token: 0x060244E4 RID: 148708 RVA: 0x0035BFA2 File Offset: 0x0035A1A2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOpacityMicroMapUsageCount(Pointer, MemoryOwner);
		}

		// Token: 0x04013797 RID: 79767
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OpacityMicroMap.OpacityMicroMapUsageCount";

		// Token: 0x04013798 RID: 79768
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013799 RID: 79769
		internal static int __PropertyOffset_Count;

		// Token: 0x0401379A RID: 79770
		internal static int __PropertyOffset_SubdivisionLevel;

		// Token: 0x0401379B RID: 79771
		internal static int __PropertyOffset_Format;
	}
}
