using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007D2 RID: 2002
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AddTagItem")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAddTagItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006ABB RID: 27323 RVA: 0x00099C7F File Offset: 0x00097E7F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAddTagItem._ScriptStructPtr != 0) ? FAddTagItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AddTagItem", ref FAddTagItem._ScriptStructPtr);
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06006ABC RID: 27324 RVA: 0x00099CA3 File Offset: 0x00097EA3
		// (set) Token: 0x06006ABD RID: 27325 RVA: 0x00099CB7 File Offset: 0x00097EB7
		public unsafe string FolderRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAddTagItem.__PropertyOffset_FolderRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAddTagItem.__PropertyOffset_FolderRegex)), value);
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06006ABE RID: 27326 RVA: 0x00099CCC File Offset: 0x00097ECC
		// (set) Token: 0x06006ABF RID: 27327 RVA: 0x00099D0F File Offset: 0x00097F0F
		public TArray<string> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<string>(base.NativePtr + (IntPtr)FAddTagItem.__PropertyOffset_Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x00099D1D File Offset: 0x00097F1D
		// (set) Token: 0x06006AC1 RID: 27329 RVA: 0x00099D31 File Offset: 0x00097F31
		public unsafe string Type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAddTagItem.__PropertyOffset_Type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAddTagItem.__PropertyOffset_Type)), value);
			}
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x00099D46 File Offset: 0x00097F46
		public FAddTagItem()
		{
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x00099D4E File Offset: 0x00097F4E
		public FAddTagItem(string FolderRegex, TArray<string> Tags, string Type)
		{
			this.FolderRegex = FolderRegex;
			this.Tags = Tags;
			this.Type = Type;
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x00099D6B File Offset: 0x00097F6B
		protected override IntPtr GetUStructPtr()
		{
			return FAddTagItem.StaticStruct();
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x00099D77 File Offset: 0x00097F77
		[NullableContext(2)]
		public FAddTagItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x00099D81 File Offset: 0x00097F81
		public FAddTagItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x00099D8C File Offset: 0x00097F8C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAddTagItem(Pointer, false, true);
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x00099D96 File Offset: 0x00097F96
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAddTagItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400335E RID: 13150
		public const string __ObjectPath = "/Script/Engine.AddTagItem";

		// Token: 0x0400335F RID: 13151
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003360 RID: 13152
		internal static int __PropertyOffset_FolderRegex;

		// Token: 0x04003361 RID: 13153
		internal static int __PropertyOffset_Tags;

		// Token: 0x04003362 RID: 13154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Tags;

		// Token: 0x04003363 RID: 13155
		internal static int __PropertyOffset_Type;
	}
}
