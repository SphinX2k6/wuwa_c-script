using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EB6 RID: 3766
	[UnrealObjectPath("/Script/Engine.MontageSectionInfoItem")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMontageSectionInfoItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CBCD RID: 52173 RVA: 0x00129106 File Offset: 0x00127306
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMontageSectionInfoItem._ScriptStructPtr != 0) ? FMontageSectionInfoItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MontageSectionInfoItem", ref FMontageSectionInfoItem._ScriptStructPtr);
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x0600CBCE RID: 52174 RVA: 0x0012912A File Offset: 0x0012732A
		// (set) Token: 0x0600CBCF RID: 52175 RVA: 0x0012913E File Offset: 0x0012733E
		public unsafe FName SectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMontageSectionInfoItem.__PropertyOffset_SectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMontageSectionInfoItem.__PropertyOffset_SectionName) = value;
			}
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x0600CBD0 RID: 52176 RVA: 0x00129153 File Offset: 0x00127353
		// (set) Token: 0x0600CBD1 RID: 52177 RVA: 0x00129163 File Offset: 0x00127363
		public unsafe float SectionStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMontageSectionInfoItem.__PropertyOffset_SectionStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMontageSectionInfoItem.__PropertyOffset_SectionStartTime) = value;
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x0600CBD2 RID: 52178 RVA: 0x00129174 File Offset: 0x00127374
		// (set) Token: 0x0600CBD3 RID: 52179 RVA: 0x00129184 File Offset: 0x00127384
		public unsafe float SectionLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMontageSectionInfoItem.__PropertyOffset_SectionLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMontageSectionInfoItem.__PropertyOffset_SectionLength) = value;
			}
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x00129195 File Offset: 0x00127395
		public FMontageSectionInfoItem()
		{
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x0012919D File Offset: 0x0012739D
		public FMontageSectionInfoItem(FName SectionName, float SectionStartTime, float SectionLength)
		{
			this.SectionName = SectionName;
			this.SectionStartTime = SectionStartTime;
			this.SectionLength = SectionLength;
		}

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x001291BA File Offset: 0x001273BA
		protected override IntPtr GetUStructPtr()
		{
			return FMontageSectionInfoItem.StaticStruct();
		}

		// Token: 0x0600CBD7 RID: 52183 RVA: 0x001291C6 File Offset: 0x001273C6
		[NullableContext(2)]
		public FMontageSectionInfoItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CBD8 RID: 52184 RVA: 0x001291D0 File Offset: 0x001273D0
		public FMontageSectionInfoItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x001291DB File Offset: 0x001273DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMontageSectionInfoItem(Pointer, false, true);
		}

		// Token: 0x0600CBDA RID: 52186 RVA: 0x001291E5 File Offset: 0x001273E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMontageSectionInfoItem(Pointer, MemoryOwner);
		}

		// Token: 0x04006DD2 RID: 28114
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MontageSectionInfoItem";

		// Token: 0x04006DD3 RID: 28115
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006DD4 RID: 28116
		internal static int __PropertyOffset_SectionName;

		// Token: 0x04006DD5 RID: 28117
		internal static int __PropertyOffset_SectionStartTime;

		// Token: 0x04006DD6 RID: 28118
		internal static int __PropertyOffset_SectionLength;
	}
}
