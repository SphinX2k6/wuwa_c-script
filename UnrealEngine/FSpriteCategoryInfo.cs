using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001183 RID: 4483
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpriteCategoryInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSpriteCategoryInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060107BB RID: 67515 RVA: 0x001834D8 File Offset: 0x001816D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpriteCategoryInfo._ScriptStructPtr != 0) ? FSpriteCategoryInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpriteCategoryInfo", ref FSpriteCategoryInfo._ScriptStructPtr);
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x060107BC RID: 67516 RVA: 0x001834FC File Offset: 0x001816FC
		// (set) Token: 0x060107BD RID: 67517 RVA: 0x00183510 File Offset: 0x00181710
		public unsafe FName Category
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpriteCategoryInfo.__PropertyOffset_Category);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpriteCategoryInfo.__PropertyOffset_Category) = value;
			}
		}

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x060107BE RID: 67518 RVA: 0x00183528 File Offset: 0x00181728
		// (set) Token: 0x060107BF RID: 67519 RVA: 0x0018356B File Offset: 0x0018176B
		public unsafe FText DisplayName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DisplayName) == null)
				{
					result = (this._DisplayName = new FText(base.NativePtr + (IntPtr)FSpriteCategoryInfo.__PropertyOffset_DisplayName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FSpriteCategoryInfo.__PropertyOffset_DisplayName)), value.NativePtr, 1);
			}
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x060107C0 RID: 67520 RVA: 0x00183588 File Offset: 0x00181788
		// (set) Token: 0x060107C1 RID: 67521 RVA: 0x001835CB File Offset: 0x001817CB
		public unsafe FText Description
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Description) == null)
				{
					result = (this._Description = new FText(base.NativePtr + (IntPtr)FSpriteCategoryInfo.__PropertyOffset_Description, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FSpriteCategoryInfo.__PropertyOffset_Description)), value.NativePtr, 1);
			}
		}

		// Token: 0x060107C2 RID: 67522 RVA: 0x001835E6 File Offset: 0x001817E6
		public FSpriteCategoryInfo()
		{
		}

		// Token: 0x060107C3 RID: 67523 RVA: 0x001835EE File Offset: 0x001817EE
		public FSpriteCategoryInfo(FName Category, FText DisplayName, FText Description)
		{
			this.Category = Category;
			this.DisplayName = DisplayName;
			this.Description = Description;
		}

		// Token: 0x060107C4 RID: 67524 RVA: 0x0018360B File Offset: 0x0018180B
		protected override IntPtr GetUStructPtr()
		{
			return FSpriteCategoryInfo.StaticStruct();
		}

		// Token: 0x060107C5 RID: 67525 RVA: 0x00183617 File Offset: 0x00181817
		[NullableContext(2)]
		public FSpriteCategoryInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060107C6 RID: 67526 RVA: 0x00183621 File Offset: 0x00181821
		public FSpriteCategoryInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060107C7 RID: 67527 RVA: 0x0018362C File Offset: 0x0018182C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpriteCategoryInfo(Pointer, false, true);
		}

		// Token: 0x060107C8 RID: 67528 RVA: 0x00183636 File Offset: 0x00181836
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpriteCategoryInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008D16 RID: 36118
		public const string __ObjectPath = "/Script/Engine.SpriteCategoryInfo";

		// Token: 0x04008D17 RID: 36119
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008D18 RID: 36120
		internal static int __PropertyOffset_Category;

		// Token: 0x04008D19 RID: 36121
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04008D1A RID: 36122
		[Nullable(2)]
		private FText _DisplayName;

		// Token: 0x04008D1B RID: 36123
		internal static int __PropertyOffset_Description;

		// Token: 0x04008D1C RID: 36124
		[Nullable(2)]
		private FText _Description;
	}
}
