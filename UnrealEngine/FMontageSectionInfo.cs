using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EB5 RID: 3765
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MontageSectionInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMontageSectionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CBBF RID: 52159 RVA: 0x00128FEB File Offset: 0x001271EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMontageSectionInfo._ScriptStructPtr != 0) ? FMontageSectionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MontageSectionInfo", ref FMontageSectionInfo._ScriptStructPtr);
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x0600CBC0 RID: 52160 RVA: 0x0012900F File Offset: 0x0012720F
		// (set) Token: 0x0600CBC1 RID: 52161 RVA: 0x0012901F File Offset: 0x0012721F
		public unsafe int AnimArrayIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMontageSectionInfo.__PropertyOffset_AnimArrayIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMontageSectionInfo.__PropertyOffset_AnimArrayIndex) = value;
			}
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x0600CBC2 RID: 52162 RVA: 0x00129030 File Offset: 0x00127230
		// (set) Token: 0x0600CBC3 RID: 52163 RVA: 0x00129044 File Offset: 0x00127244
		public unsafe FName MontageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMontageSectionInfo.__PropertyOffset_MontageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMontageSectionInfo.__PropertyOffset_MontageName) = value;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x0600CBC4 RID: 52164 RVA: 0x0012905C File Offset: 0x0012725C
		// (set) Token: 0x0600CBC5 RID: 52165 RVA: 0x0012909F File Offset: 0x0012729F
		public TArray<FMontageSectionInfoItem> SectionArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMontageSectionInfoItem> result;
				if ((result = this._SectionArray) == null)
				{
					result = (this._SectionArray = new TArray<FMontageSectionInfoItem>(base.NativePtr + (IntPtr)FMontageSectionInfo.__PropertyOffset_SectionArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SectionArray.CopyAssign(value);
			}
		}

		// Token: 0x0600CBC6 RID: 52166 RVA: 0x001290AD File Offset: 0x001272AD
		public FMontageSectionInfo()
		{
		}

		// Token: 0x0600CBC7 RID: 52167 RVA: 0x001290B5 File Offset: 0x001272B5
		public FMontageSectionInfo(int AnimArrayIndex, FName MontageName, TArray<FMontageSectionInfoItem> SectionArray)
		{
			this.AnimArrayIndex = AnimArrayIndex;
			this.MontageName = MontageName;
			this.SectionArray = SectionArray;
		}

		// Token: 0x0600CBC8 RID: 52168 RVA: 0x001290D2 File Offset: 0x001272D2
		protected override IntPtr GetUStructPtr()
		{
			return FMontageSectionInfo.StaticStruct();
		}

		// Token: 0x0600CBC9 RID: 52169 RVA: 0x001290DE File Offset: 0x001272DE
		[NullableContext(2)]
		public FMontageSectionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CBCA RID: 52170 RVA: 0x001290E8 File Offset: 0x001272E8
		public FMontageSectionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CBCB RID: 52171 RVA: 0x001290F3 File Offset: 0x001272F3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMontageSectionInfo(Pointer, false, true);
		}

		// Token: 0x0600CBCC RID: 52172 RVA: 0x001290FD File Offset: 0x001272FD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMontageSectionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006DCC RID: 28108
		public const string __ObjectPath = "/Script/Engine.MontageSectionInfo";

		// Token: 0x04006DCD RID: 28109
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006DCE RID: 28110
		internal static int __PropertyOffset_AnimArrayIndex;

		// Token: 0x04006DCF RID: 28111
		internal static int __PropertyOffset_MontageName;

		// Token: 0x04006DD0 RID: 28112
		internal static int __PropertyOffset_SectionArray;

		// Token: 0x04006DD1 RID: 28113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMontageSectionInfoItem> _SectionArray;
	}
}
