using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002614 RID: 9748
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OnlineSubsystem.InAppPurchaseProductInfo")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FInAppPurchaseProductInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024416 RID: 148502 RVA: 0x0035AE42 File Offset: 0x00359042
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInAppPurchaseProductInfo._ScriptStructPtr != 0) ? FInAppPurchaseProductInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OnlineSubsystem.InAppPurchaseProductInfo", ref FInAppPurchaseProductInfo._ScriptStructPtr);
		}

		// Token: 0x17008B9B RID: 35739
		// (get) Token: 0x06024417 RID: 148503 RVA: 0x0035AE66 File Offset: 0x00359066
		// (set) Token: 0x06024418 RID: 148504 RVA: 0x0035AE7A File Offset: 0x0035907A
		public unsafe string Identifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_Identifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_Identifier)), value);
			}
		}

		// Token: 0x17008B9C RID: 35740
		// (get) Token: 0x06024419 RID: 148505 RVA: 0x0035AE8F File Offset: 0x0035908F
		// (set) Token: 0x0602441A RID: 148506 RVA: 0x0035AEA3 File Offset: 0x003590A3
		public unsafe string TransactionIdentifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_TransactionIdentifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_TransactionIdentifier)), value);
			}
		}

		// Token: 0x17008B9D RID: 35741
		// (get) Token: 0x0602441B RID: 148507 RVA: 0x0035AEB8 File Offset: 0x003590B8
		// (set) Token: 0x0602441C RID: 148508 RVA: 0x0035AECC File Offset: 0x003590CC
		public unsafe string DisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DisplayName)), value);
			}
		}

		// Token: 0x17008B9E RID: 35742
		// (get) Token: 0x0602441D RID: 148509 RVA: 0x0035AEE1 File Offset: 0x003590E1
		// (set) Token: 0x0602441E RID: 148510 RVA: 0x0035AEF5 File Offset: 0x003590F5
		public unsafe string DisplayDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DisplayDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DisplayDescription)), value);
			}
		}

		// Token: 0x17008B9F RID: 35743
		// (get) Token: 0x0602441F RID: 148511 RVA: 0x0035AF0A File Offset: 0x0035910A
		// (set) Token: 0x06024420 RID: 148512 RVA: 0x0035AF1E File Offset: 0x0035911E
		public unsafe string DisplayPrice
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DisplayPrice)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DisplayPrice)), value);
			}
		}

		// Token: 0x17008BA0 RID: 35744
		// (get) Token: 0x06024421 RID: 148513 RVA: 0x0035AF33 File Offset: 0x00359133
		// (set) Token: 0x06024422 RID: 148514 RVA: 0x0035AF43 File Offset: 0x00359143
		public unsafe float RawPrice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_RawPrice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_RawPrice) = value;
			}
		}

		// Token: 0x17008BA1 RID: 35745
		// (get) Token: 0x06024423 RID: 148515 RVA: 0x0035AF54 File Offset: 0x00359154
		// (set) Token: 0x06024424 RID: 148516 RVA: 0x0035AF68 File Offset: 0x00359168
		public unsafe string CurrencyCode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_CurrencyCode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_CurrencyCode)), value);
			}
		}

		// Token: 0x17008BA2 RID: 35746
		// (get) Token: 0x06024425 RID: 148517 RVA: 0x0035AF7D File Offset: 0x0035917D
		// (set) Token: 0x06024426 RID: 148518 RVA: 0x0035AF91 File Offset: 0x00359191
		public unsafe string CurrencySymbol
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_CurrencySymbol)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_CurrencySymbol)), value);
			}
		}

		// Token: 0x17008BA3 RID: 35747
		// (get) Token: 0x06024427 RID: 148519 RVA: 0x0035AFA6 File Offset: 0x003591A6
		// (set) Token: 0x06024428 RID: 148520 RVA: 0x0035AFBA File Offset: 0x003591BA
		public unsafe string DecimalSeparator
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DecimalSeparator)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_DecimalSeparator)), value);
			}
		}

		// Token: 0x17008BA4 RID: 35748
		// (get) Token: 0x06024429 RID: 148521 RVA: 0x0035AFCF File Offset: 0x003591CF
		// (set) Token: 0x0602442A RID: 148522 RVA: 0x0035AFE3 File Offset: 0x003591E3
		public unsafe string GroupingSeparator
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_GroupingSeparator)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_GroupingSeparator)), value);
			}
		}

		// Token: 0x17008BA5 RID: 35749
		// (get) Token: 0x0602442B RID: 148523 RVA: 0x0035AFF8 File Offset: 0x003591F8
		// (set) Token: 0x0602442C RID: 148524 RVA: 0x0035B00C File Offset: 0x0035920C
		public unsafe string ReceiptData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_ReceiptData)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductInfo.__PropertyOffset_ReceiptData)), value);
			}
		}

		// Token: 0x0602442D RID: 148525 RVA: 0x0035B021 File Offset: 0x00359221
		public FInAppPurchaseProductInfo()
		{
		}

		// Token: 0x0602442E RID: 148526 RVA: 0x0035B02C File Offset: 0x0035922C
		public FInAppPurchaseProductInfo(string Identifier, string TransactionIdentifier, string DisplayName, string DisplayDescription, string DisplayPrice, float RawPrice, string CurrencyCode, string CurrencySymbol, string DecimalSeparator, string GroupingSeparator, string ReceiptData)
		{
			this.Identifier = Identifier;
			this.TransactionIdentifier = TransactionIdentifier;
			this.DisplayName = DisplayName;
			this.DisplayDescription = DisplayDescription;
			this.DisplayPrice = DisplayPrice;
			this.RawPrice = RawPrice;
			this.CurrencyCode = CurrencyCode;
			this.CurrencySymbol = CurrencySymbol;
			this.DecimalSeparator = DecimalSeparator;
			this.GroupingSeparator = GroupingSeparator;
			this.ReceiptData = ReceiptData;
		}

		// Token: 0x0602442F RID: 148527 RVA: 0x0035B094 File Offset: 0x00359294
		protected override IntPtr GetUStructPtr()
		{
			return FInAppPurchaseProductInfo.StaticStruct();
		}

		// Token: 0x06024430 RID: 148528 RVA: 0x0035B0A0 File Offset: 0x003592A0
		[NullableContext(2)]
		public FInAppPurchaseProductInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024431 RID: 148529 RVA: 0x0035B0AA File Offset: 0x003592AA
		public FInAppPurchaseProductInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024432 RID: 148530 RVA: 0x0035B0B5 File Offset: 0x003592B5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInAppPurchaseProductInfo(Pointer, false, true);
		}

		// Token: 0x06024433 RID: 148531 RVA: 0x0035B0BF File Offset: 0x003592BF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInAppPurchaseProductInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013735 RID: 79669
		public const string __ObjectPath = "/Script/OnlineSubsystem.InAppPurchaseProductInfo";

		// Token: 0x04013736 RID: 79670
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013737 RID: 79671
		internal static int __PropertyOffset_Identifier;

		// Token: 0x04013738 RID: 79672
		internal static int __PropertyOffset_TransactionIdentifier;

		// Token: 0x04013739 RID: 79673
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x0401373A RID: 79674
		internal static int __PropertyOffset_DisplayDescription;

		// Token: 0x0401373B RID: 79675
		internal static int __PropertyOffset_DisplayPrice;

		// Token: 0x0401373C RID: 79676
		internal static int __PropertyOffset_RawPrice;

		// Token: 0x0401373D RID: 79677
		internal static int __PropertyOffset_CurrencyCode;

		// Token: 0x0401373E RID: 79678
		internal static int __PropertyOffset_CurrencySymbol;

		// Token: 0x0401373F RID: 79679
		internal static int __PropertyOffset_DecimalSeparator;

		// Token: 0x04013740 RID: 79680
		internal static int __PropertyOffset_GroupingSeparator;

		// Token: 0x04013741 RID: 79681
		internal static int __PropertyOffset_ReceiptData;
	}
}
