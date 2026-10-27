using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200075B RID: 1883
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.PolyglotTextData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FPolyglotTextData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006348 RID: 25416 RVA: 0x0008E89C File Offset: 0x0008CA9C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPolyglotTextData._ScriptStructPtr != 0) ? FPolyglotTextData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PolyglotTextData", ref FPolyglotTextData._ScriptStructPtr);
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06006349 RID: 25417 RVA: 0x0008E8C0 File Offset: 0x0008CAC0
		// (set) Token: 0x0600634A RID: 25418 RVA: 0x0008E8D0 File Offset: 0x0008CAD0
		public unsafe ELocalizedTextSourceCategory Category
		{
			get
			{
				return (ELocalizedTextSourceCategory)(*(base.NativePtr + (IntPtr)FPolyglotTextData.__PropertyOffset_Category));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolyglotTextData.__PropertyOffset_Category) = (byte)value;
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x0600634B RID: 25419 RVA: 0x0008E8E1 File Offset: 0x0008CAE1
		// (set) Token: 0x0600634C RID: 25420 RVA: 0x0008E8F5 File Offset: 0x0008CAF5
		public unsafe string NativeCulture
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_NativeCulture)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_NativeCulture)), value);
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x0600634D RID: 25421 RVA: 0x0008E90A File Offset: 0x0008CB0A
		// (set) Token: 0x0600634E RID: 25422 RVA: 0x0008E91E File Offset: 0x0008CB1E
		public unsafe string Namespace
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_Namespace)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_Namespace)), value);
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x0600634F RID: 25423 RVA: 0x0008E933 File Offset: 0x0008CB33
		// (set) Token: 0x06006350 RID: 25424 RVA: 0x0008E947 File Offset: 0x0008CB47
		public unsafe string Key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_Key)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_Key)), value);
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06006351 RID: 25425 RVA: 0x0008E95C File Offset: 0x0008CB5C
		// (set) Token: 0x06006352 RID: 25426 RVA: 0x0008E970 File Offset: 0x0008CB70
		public unsafe string NativeString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_NativeString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_NativeString)), value);
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06006353 RID: 25427 RVA: 0x0008E988 File Offset: 0x0008CB88
		// (set) Token: 0x06006354 RID: 25428 RVA: 0x0008E9CB File Offset: 0x0008CBCB
		public TMap<string, string> LocalizedStrings
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._LocalizedStrings) == null)
				{
					result = (this._LocalizedStrings = new TMap<string, string>(base.NativePtr + (IntPtr)FPolyglotTextData.__PropertyOffset_LocalizedStrings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalizedStrings.CopyAssign(value);
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06006355 RID: 25429 RVA: 0x0008E9D9 File Offset: 0x0008CBD9
		// (set) Token: 0x06006356 RID: 25430 RVA: 0x0008E9E9 File Offset: 0x0008CBE9
		public unsafe bool bIsMinimalPatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPolyglotTextData.__PropertyOffset_bIsMinimalPatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPolyglotTextData.__PropertyOffset_bIsMinimalPatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x0008E9FC File Offset: 0x0008CBFC
		// (set) Token: 0x06006358 RID: 25432 RVA: 0x0008EA3F File Offset: 0x0008CC3F
		public unsafe FText CachedText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._CachedText) == null)
				{
					result = (this._CachedText = new FText(base.NativePtr + (IntPtr)FPolyglotTextData.__PropertyOffset_CachedText, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FPolyglotTextData.__PropertyOffset_CachedText)), value.NativePtr, 1);
			}
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x0008EA5A File Offset: 0x0008CC5A
		public FPolyglotTextData()
		{
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x0008EA64 File Offset: 0x0008CC64
		public FPolyglotTextData(ELocalizedTextSourceCategory Category, string NativeCulture, string Namespace, string Key, string NativeString, TMap<string, string> LocalizedStrings, bool bIsMinimalPatch, FText CachedText)
		{
			this.Category = Category;
			this.NativeCulture = NativeCulture;
			this.Namespace = Namespace;
			this.Key = Key;
			this.NativeString = NativeString;
			this.LocalizedStrings = LocalizedStrings;
			this.bIsMinimalPatch = bIsMinimalPatch;
			this.CachedText = CachedText;
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x0008EAB4 File Offset: 0x0008CCB4
		protected override IntPtr GetUStructPtr()
		{
			return FPolyglotTextData.StaticStruct();
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x0008EAC0 File Offset: 0x0008CCC0
		[NullableContext(2)]
		public FPolyglotTextData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x0008EACA File Offset: 0x0008CCCA
		public FPolyglotTextData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x0008EAD5 File Offset: 0x0008CCD5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPolyglotTextData(Pointer, false, true);
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x0008EADF File Offset: 0x0008CCDF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPolyglotTextData(Pointer, MemoryOwner);
		}

		// Token: 0x04002F94 RID: 12180
		public const string __ObjectPath = "/Script/CoreUObject.PolyglotTextData";

		// Token: 0x04002F95 RID: 12181
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002F96 RID: 12182
		internal static int __PropertyOffset_Category;

		// Token: 0x04002F97 RID: 12183
		internal static int __PropertyOffset_NativeCulture;

		// Token: 0x04002F98 RID: 12184
		internal static int __PropertyOffset_Namespace;

		// Token: 0x04002F99 RID: 12185
		internal static int __PropertyOffset_Key;

		// Token: 0x04002F9A RID: 12186
		internal static int __PropertyOffset_NativeString;

		// Token: 0x04002F9B RID: 12187
		internal static int __PropertyOffset_LocalizedStrings;

		// Token: 0x04002F9C RID: 12188
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _LocalizedStrings;

		// Token: 0x04002F9D RID: 12189
		internal static int __PropertyOffset_bIsMinimalPatch;

		// Token: 0x04002F9E RID: 12190
		internal static int __PropertyOffset_CachedText;

		// Token: 0x04002F9F RID: 12191
		[Nullable(2)]
		private FText _CachedText;
	}
}
