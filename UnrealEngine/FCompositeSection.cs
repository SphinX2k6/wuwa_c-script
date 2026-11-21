using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001BB RID: 443
	[UnrealObjectPath("/Script/Engine.CompositeSection")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FCompositeSection : FAnimLinkableElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002072 RID: 8306 RVA: 0x0002FD9E File Offset: 0x0002DF9E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompositeSection._ScriptStructPtr != 0) ? FCompositeSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CompositeSection", ref FCompositeSection._ScriptStructPtr);
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0002FDC2 File Offset: 0x0002DFC2
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x0002FDD6 File Offset: 0x0002DFD6
		public unsafe FName SectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_SectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_SectionName) = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0002FDEB File Offset: 0x0002DFEB
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x0002FDFB File Offset: 0x0002DFFB
		public unsafe float StartTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_StartTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_StartTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0002FE0C File Offset: 0x0002E00C
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x0002FE20 File Offset: 0x0002E020
		public unsafe FName NextSectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_NextSectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompositeSection.__PropertyOffset_NextSectionName) = value;
			}
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x0002FE35 File Offset: 0x0002E035
		public FCompositeSection()
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x0002FE3D File Offset: 0x0002E03D
		protected override IntPtr GetUStructPtr()
		{
			return FCompositeSection.StaticStruct();
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x0002FE49 File Offset: 0x0002E049
		[NullableContext(2)]
		public FCompositeSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0002FE53 File Offset: 0x0002E053
		public FCompositeSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x0002FE5E File Offset: 0x0002E05E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompositeSection(Pointer, false, true);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x0002FE68 File Offset: 0x0002E068
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompositeSection(Pointer, MemoryOwner);
		}

		// Token: 0x04000ACE RID: 2766
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CompositeSection";

		// Token: 0x04000ACF RID: 2767
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AD0 RID: 2768
		internal static int __PropertyOffset_SectionName;

		// Token: 0x04000AD1 RID: 2769
		internal static int __PropertyOffset_StartTime_DEPRECATED;

		// Token: 0x04000AD2 RID: 2770
		internal static int __PropertyOffset_NextSectionName;
	}
}
