using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000141 RID: 321
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.PolyglotTextData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FPolyglotTextData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060012A4 RID: 4772 RVA: 0x0001D81C File Offset: 0x0001BA1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPolyglotTextData._ScriptStructPtr != 0) ? FPolyglotTextData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PolyglotTextData", ref FPolyglotTextData._ScriptStructPtr);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0001D840 File Offset: 0x0001BA40
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x0001D850 File Offset: 0x0001BA50
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0001D861 File Offset: 0x0001BA61
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x0001D875 File Offset: 0x0001BA75
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

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0001D88A File Offset: 0x0001BA8A
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x0001D89E File Offset: 0x0001BA9E
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

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x0001D8B3 File Offset: 0x0001BAB3
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x0001D8C7 File Offset: 0x0001BAC7
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0001D8DC File Offset: 0x0001BADC
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0001D908 File Offset: 0x0001BB08
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0001D94B File Offset: 0x0001BB4B
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0001D959 File Offset: 0x0001BB59
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0001D969 File Offset: 0x0001BB69
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

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x0001D97C File Offset: 0x0001BB7C
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0001D9BF File Offset: 0x0001BBBF
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

		// Token: 0x060012B5 RID: 4789 RVA: 0x0001D9DA File Offset: 0x0001BBDA
		public FPolyglotTextData()
		{
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0001D9E2 File Offset: 0x0001BBE2
		protected override IntPtr GetUStructPtr()
		{
			return FPolyglotTextData.StaticStruct();
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0001D9EE File Offset: 0x0001BBEE
		[NullableContext(2)]
		public FPolyglotTextData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0001D9F8 File Offset: 0x0001BBF8
		public FPolyglotTextData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0001DA03 File Offset: 0x0001BC03
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPolyglotTextData(Pointer, false, true);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0001DA0D File Offset: 0x0001BC0D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPolyglotTextData(Pointer, MemoryOwner);
		}

		// Token: 0x040005CA RID: 1482
		public const string __ObjectPath = "/Script/CoreUObject.PolyglotTextData";

		// Token: 0x040005CB RID: 1483
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040005CC RID: 1484
		internal static int __PropertyOffset_Category;

		// Token: 0x040005CD RID: 1485
		internal static int __PropertyOffset_NativeCulture;

		// Token: 0x040005CE RID: 1486
		internal static int __PropertyOffset_Namespace;

		// Token: 0x040005CF RID: 1487
		internal static int __PropertyOffset_Key;

		// Token: 0x040005D0 RID: 1488
		internal static int __PropertyOffset_NativeString;

		// Token: 0x040005D1 RID: 1489
		internal static int __PropertyOffset_LocalizedStrings;

		// Token: 0x040005D2 RID: 1490
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _LocalizedStrings;

		// Token: 0x040005D3 RID: 1491
		internal static int __PropertyOffset_bIsMinimalPatch;

		// Token: 0x040005D4 RID: 1492
		internal static int __PropertyOffset_CachedText;

		// Token: 0x040005D5 RID: 1493
		[Nullable(2)]
		private FText _CachedText;
	}
}
