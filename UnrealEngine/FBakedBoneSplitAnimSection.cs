using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200088B RID: 2187
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitAnimSection")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBakedBoneSplitAnimSection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600779D RID: 30621 RVA: 0x000AB509 File Offset: 0x000A9709
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneSplitAnimSection._ScriptStructPtr != 0) ? FBakedBoneSplitAnimSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneSplitAnimSection", ref FBakedBoneSplitAnimSection._ScriptStructPtr);
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x0600779E RID: 30622 RVA: 0x000AB52D File Offset: 0x000A972D
		// (set) Token: 0x0600779F RID: 30623 RVA: 0x000AB53D File Offset: 0x000A973D
		public unsafe int StartSliceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitAnimSection.__PropertyOffset_StartSliceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitAnimSection.__PropertyOffset_StartSliceIndex) = value;
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x060077A0 RID: 30624 RVA: 0x000AB54E File Offset: 0x000A974E
		// (set) Token: 0x060077A1 RID: 30625 RVA: 0x000AB55E File Offset: 0x000A975E
		public unsafe int StartY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitAnimSection.__PropertyOffset_StartY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitAnimSection.__PropertyOffset_StartY) = value;
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x060077A2 RID: 30626 RVA: 0x000AB56F File Offset: 0x000A976F
		// (set) Token: 0x060077A3 RID: 30627 RVA: 0x000AB57F File Offset: 0x000A977F
		public unsafe int NumFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitAnimSection.__PropertyOffset_NumFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitAnimSection.__PropertyOffset_NumFrames) = value;
			}
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x000AB590 File Offset: 0x000A9790
		public FBakedBoneSplitAnimSection()
		{
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x000AB598 File Offset: 0x000A9798
		[NullableContext(1)]
		public FBakedBoneSplitAnimSection(UAnimSequenceBase AnimSequence, int StartSliceIndex, int StartY, int NumFrames)
		{
			this.StartSliceIndex = StartSliceIndex;
			this.StartY = StartY;
			this.NumFrames = NumFrames;
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x000AB5B6 File Offset: 0x000A97B6
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneSplitAnimSection.StaticStruct();
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x000AB5C2 File Offset: 0x000A97C2
		[NullableContext(2)]
		public FBakedBoneSplitAnimSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x000AB5CC File Offset: 0x000A97CC
		public FBakedBoneSplitAnimSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x000AB5D7 File Offset: 0x000A97D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneSplitAnimSection(Pointer, false, true);
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x000AB5E1 File Offset: 0x000A97E1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneSplitAnimSection(Pointer, MemoryOwner);
		}

		// Token: 0x0400396F RID: 14703
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BakedBoneSplitAnimSection";

		// Token: 0x04003970 RID: 14704
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003971 RID: 14705
		internal static int __PropertyOffset_StartSliceIndex;

		// Token: 0x04003972 RID: 14706
		internal static int __PropertyOffset_StartY;

		// Token: 0x04003973 RID: 14707
		internal static int __PropertyOffset_NumFrames;
	}
}
