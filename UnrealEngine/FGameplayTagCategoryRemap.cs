using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013DD RID: 5085
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagCategoryRemap")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayTagCategoryRemap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601298C RID: 76172 RVA: 0x001B5E49 File Offset: 0x001B4049
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagCategoryRemap._ScriptStructPtr != 0) ? FGameplayTagCategoryRemap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagCategoryRemap", ref FGameplayTagCategoryRemap._ScriptStructPtr);
		}

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x0601298D RID: 76173 RVA: 0x001B5E6D File Offset: 0x001B406D
		// (set) Token: 0x0601298E RID: 76174 RVA: 0x001B5E81 File Offset: 0x001B4081
		public unsafe string BaseCategory
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagCategoryRemap.__PropertyOffset_BaseCategory)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGameplayTagCategoryRemap.__PropertyOffset_BaseCategory)), value);
			}
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x0601298F RID: 76175 RVA: 0x001B5E98 File Offset: 0x001B4098
		// (set) Token: 0x06012990 RID: 76176 RVA: 0x001B5EDB File Offset: 0x001B40DB
		public TArray<string> RemapCategories
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RemapCategories) == null)
				{
					result = (this._RemapCategories = new TArray<string>(base.NativePtr + (IntPtr)FGameplayTagCategoryRemap.__PropertyOffset_RemapCategories, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemapCategories.CopyAssign(value);
			}
		}

		// Token: 0x06012991 RID: 76177 RVA: 0x001B5EE9 File Offset: 0x001B40E9
		public FGameplayTagCategoryRemap()
		{
		}

		// Token: 0x06012992 RID: 76178 RVA: 0x001B5EF1 File Offset: 0x001B40F1
		public FGameplayTagCategoryRemap(string BaseCategory, TArray<string> RemapCategories)
		{
			this.BaseCategory = BaseCategory;
			this.RemapCategories = RemapCategories;
		}

		// Token: 0x06012993 RID: 76179 RVA: 0x001B5F07 File Offset: 0x001B4107
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagCategoryRemap.StaticStruct();
		}

		// Token: 0x06012994 RID: 76180 RVA: 0x001B5F13 File Offset: 0x001B4113
		[NullableContext(2)]
		public FGameplayTagCategoryRemap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012995 RID: 76181 RVA: 0x001B5F1D File Offset: 0x001B411D
		public FGameplayTagCategoryRemap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012996 RID: 76182 RVA: 0x001B5F28 File Offset: 0x001B4128
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagCategoryRemap(Pointer, false, true);
		}

		// Token: 0x06012997 RID: 76183 RVA: 0x001B5F32 File Offset: 0x001B4132
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagCategoryRemap(Pointer, MemoryOwner);
		}

		// Token: 0x04009EFF RID: 40703
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagCategoryRemap";

		// Token: 0x04009F00 RID: 40704
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F01 RID: 40705
		internal static int __PropertyOffset_BaseCategory;

		// Token: 0x04009F02 RID: 40706
		internal static int __PropertyOffset_RemapCategories;

		// Token: 0x04009F03 RID: 40707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RemapCategories;
	}
}
