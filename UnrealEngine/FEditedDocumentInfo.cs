using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A53 RID: 2643
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EditedDocumentInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FEditedDocumentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008F89 RID: 36745 RVA: 0x000CD703 File Offset: 0x000CB903
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditedDocumentInfo._ScriptStructPtr != 0) ? FEditedDocumentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EditedDocumentInfo", ref FEditedDocumentInfo._ScriptStructPtr);
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06008F8A RID: 36746 RVA: 0x000CD728 File Offset: 0x000CB928
		// (set) Token: 0x06008F8B RID: 36747 RVA: 0x000CD76B File Offset: 0x000CB96B
		public FSoftObjectPath EditedObjectPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EditedObjectPath) == null)
				{
					result = (this._EditedObjectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)FEditedDocumentInfo.__PropertyOffset_EditedObjectPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FEditedDocumentInfo.__PropertyOffset_EditedObjectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06008F8C RID: 36748 RVA: 0x000CD78C File Offset: 0x000CB98C
		// (set) Token: 0x06008F8D RID: 36749 RVA: 0x000CD7A0 File Offset: 0x000CB9A0
		public unsafe FVector2D SavedViewOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEditedDocumentInfo.__PropertyOffset_SavedViewOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEditedDocumentInfo.__PropertyOffset_SavedViewOffset) = value;
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06008F8E RID: 36750 RVA: 0x000CD7B5 File Offset: 0x000CB9B5
		// (set) Token: 0x06008F8F RID: 36751 RVA: 0x000CD7C5 File Offset: 0x000CB9C5
		public unsafe float SavedZoomAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEditedDocumentInfo.__PropertyOffset_SavedZoomAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEditedDocumentInfo.__PropertyOffset_SavedZoomAmount) = value;
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06008F90 RID: 36752 RVA: 0x000CD7D6 File Offset: 0x000CB9D6
		// (set) Token: 0x06008F91 RID: 36753 RVA: 0x000CD7EA File Offset: 0x000CB9EA
		[Nullable(2)]
		public unsafe UObject EditedObject_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FEditedDocumentInfo.__PropertyOffset_EditedObject_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEditedDocumentInfo.__PropertyOffset_EditedObject_DEPRECATED, value);
			}
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x000CD7FF File Offset: 0x000CB9FF
		public FEditedDocumentInfo()
		{
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x000CD807 File Offset: 0x000CBA07
		public FEditedDocumentInfo(FSoftObjectPath EditedObjectPath, FVector2D SavedViewOffset, float SavedZoomAmount, UObject EditedObject_DEPRECATED)
		{
			this.EditedObjectPath = EditedObjectPath;
			this.SavedViewOffset = SavedViewOffset;
			this.SavedZoomAmount = SavedZoomAmount;
			this.EditedObject_DEPRECATED = EditedObject_DEPRECATED;
		}

		// Token: 0x06008F94 RID: 36756 RVA: 0x000CD82C File Offset: 0x000CBA2C
		protected override IntPtr GetUStructPtr()
		{
			return FEditedDocumentInfo.StaticStruct();
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x000CD838 File Offset: 0x000CBA38
		[NullableContext(2)]
		public FEditedDocumentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x000CD842 File Offset: 0x000CBA42
		public FEditedDocumentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x000CD84D File Offset: 0x000CBA4D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditedDocumentInfo(Pointer, false, true);
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x000CD857 File Offset: 0x000CBA57
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditedDocumentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040046F4 RID: 18164
		public const string __ObjectPath = "/Script/Engine.EditedDocumentInfo";

		// Token: 0x040046F5 RID: 18165
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046F6 RID: 18166
		internal static int __PropertyOffset_EditedObjectPath;

		// Token: 0x040046F7 RID: 18167
		[Nullable(2)]
		private FSoftObjectPath _EditedObjectPath;

		// Token: 0x040046F8 RID: 18168
		internal static int __PropertyOffset_SavedViewOffset;

		// Token: 0x040046F9 RID: 18169
		internal static int __PropertyOffset_SavedZoomAmount;

		// Token: 0x040046FA RID: 18170
		internal static int __PropertyOffset_EditedObject_DEPRECATED;
	}
}
