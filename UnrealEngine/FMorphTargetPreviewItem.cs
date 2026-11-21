using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000243 RID: 579
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MorphTargetPreviewItem")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMorphTargetPreviewItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060031CC RID: 12748 RVA: 0x00046E95 File Offset: 0x00045095
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMorphTargetPreviewItem._ScriptStructPtr != 0) ? FMorphTargetPreviewItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MorphTargetPreviewItem", ref FMorphTargetPreviewItem._ScriptStructPtr);
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x00046EB9 File Offset: 0x000450B9
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x00046ECD File Offset: 0x000450CD
		public unsafe string MorphName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMorphTargetPreviewItem.__PropertyOffset_MorphName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMorphTargetPreviewItem.__PropertyOffset_MorphName)), value);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x00046EE2 File Offset: 0x000450E2
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x00046EF2 File Offset: 0x000450F2
		public unsafe float PreviewValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMorphTargetPreviewItem.__PropertyOffset_PreviewValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMorphTargetPreviewItem.__PropertyOffset_PreviewValue) = value;
			}
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00046F03 File Offset: 0x00045103
		public FMorphTargetPreviewItem()
		{
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x00046F0B File Offset: 0x0004510B
		protected override IntPtr GetUStructPtr()
		{
			return FMorphTargetPreviewItem.StaticStruct();
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x00046F17 File Offset: 0x00045117
		[NullableContext(2)]
		public FMorphTargetPreviewItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x00046F21 File Offset: 0x00045121
		public FMorphTargetPreviewItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x00046F2C File Offset: 0x0004512C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMorphTargetPreviewItem(Pointer, false, true);
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x00046F36 File Offset: 0x00045136
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMorphTargetPreviewItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400112C RID: 4396
		public const string __ObjectPath = "/Script/Engine.MorphTargetPreviewItem";

		// Token: 0x0400112D RID: 4397
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400112E RID: 4398
		internal static int __PropertyOffset_MorphName;

		// Token: 0x0400112F RID: 4399
		internal static int __PropertyOffset_PreviewValue;
	}
}
