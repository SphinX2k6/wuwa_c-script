using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001215 RID: 4629
	[UnrealObjectPath("/Script/Engine.UpdateLevelVisibilityLevelInfo")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FUpdateLevelVisibilityLevelInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060110AE RID: 69806 RVA: 0x0019023E File Offset: 0x0018E43E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUpdateLevelVisibilityLevelInfo._ScriptStructPtr != 0) ? FUpdateLevelVisibilityLevelInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.UpdateLevelVisibilityLevelInfo", ref FUpdateLevelVisibilityLevelInfo._ScriptStructPtr);
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x060110AF RID: 69807 RVA: 0x00190262 File Offset: 0x0018E462
		// (set) Token: 0x060110B0 RID: 69808 RVA: 0x00190276 File Offset: 0x0018E476
		public unsafe FName PackageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUpdateLevelVisibilityLevelInfo.__PropertyOffset_PackageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUpdateLevelVisibilityLevelInfo.__PropertyOffset_PackageName) = value;
			}
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x060110B1 RID: 69809 RVA: 0x0019028B File Offset: 0x0018E48B
		// (set) Token: 0x060110B2 RID: 69810 RVA: 0x0019029F File Offset: 0x0018E49F
		public unsafe FName FileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUpdateLevelVisibilityLevelInfo.__PropertyOffset_FileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUpdateLevelVisibilityLevelInfo.__PropertyOffset_FileName) = value;
			}
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x060110B3 RID: 69811 RVA: 0x001902B4 File Offset: 0x0018E4B4
		// (set) Token: 0x060110B4 RID: 69812 RVA: 0x001902CD File Offset: 0x0018E4CD
		public unsafe bool bIsVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FUpdateLevelVisibilityLevelInfo.__PropertyOffset_bIsVisible) & FUpdateLevelVisibilityLevelInfo.__PropertyMask_bIsVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FUpdateLevelVisibilityLevelInfo.__PropertyOffset_bIsVisible) = ((*(base.NativePtr + (IntPtr)FUpdateLevelVisibilityLevelInfo.__PropertyOffset_bIsVisible) & ~FUpdateLevelVisibilityLevelInfo.__PropertyMask_bIsVisible) | (value ? FUpdateLevelVisibilityLevelInfo.__PropertyMask_bIsVisible : 0));
			}
		}

		// Token: 0x060110B5 RID: 69813 RVA: 0x001902FD File Offset: 0x0018E4FD
		public FUpdateLevelVisibilityLevelInfo()
		{
		}

		// Token: 0x060110B6 RID: 69814 RVA: 0x00190305 File Offset: 0x0018E505
		public FUpdateLevelVisibilityLevelInfo(FName PackageName, FName FileName, bool bIsVisible)
		{
			this.PackageName = PackageName;
			this.FileName = FileName;
			this.bIsVisible = bIsVisible;
		}

		// Token: 0x060110B7 RID: 69815 RVA: 0x00190322 File Offset: 0x0018E522
		protected override IntPtr GetUStructPtr()
		{
			return FUpdateLevelVisibilityLevelInfo.StaticStruct();
		}

		// Token: 0x060110B8 RID: 69816 RVA: 0x0019032E File Offset: 0x0018E52E
		[NullableContext(2)]
		public FUpdateLevelVisibilityLevelInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060110B9 RID: 69817 RVA: 0x00190338 File Offset: 0x0018E538
		public FUpdateLevelVisibilityLevelInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060110BA RID: 69818 RVA: 0x00190343 File Offset: 0x0018E543
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUpdateLevelVisibilityLevelInfo(Pointer, false, true);
		}

		// Token: 0x060110BB RID: 69819 RVA: 0x0019034D File Offset: 0x0018E54D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUpdateLevelVisibilityLevelInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040091F4 RID: 37364
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.UpdateLevelVisibilityLevelInfo";

		// Token: 0x040091F5 RID: 37365
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091F6 RID: 37366
		internal static int __PropertyOffset_PackageName;

		// Token: 0x040091F7 RID: 37367
		internal static int __PropertyOffset_FileName;

		// Token: 0x040091F8 RID: 37368
		internal static int __PropertyOffset_bIsVisible;

		// Token: 0x040091F9 RID: 37369
		internal static byte __PropertyMask_bIsVisible;
	}
}
