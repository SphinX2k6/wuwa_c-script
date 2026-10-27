using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002616 RID: 9750
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInAppPurchaseRestoreInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024440 RID: 148544 RVA: 0x0035B188 File Offset: 0x00359388
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInAppPurchaseRestoreInfo._ScriptStructPtr != 0) ? FInAppPurchaseRestoreInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OnlineSubsystem.InAppPurchaseRestoreInfo", ref FInAppPurchaseRestoreInfo._ScriptStructPtr);
		}

		// Token: 0x17008BA8 RID: 35752
		// (get) Token: 0x06024441 RID: 148545 RVA: 0x0035B1AC File Offset: 0x003593AC
		// (set) Token: 0x06024442 RID: 148546 RVA: 0x0035B1C0 File Offset: 0x003593C0
		public unsafe string Identifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseRestoreInfo.__PropertyOffset_Identifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseRestoreInfo.__PropertyOffset_Identifier)), value);
			}
		}

		// Token: 0x17008BA9 RID: 35753
		// (get) Token: 0x06024443 RID: 148547 RVA: 0x0035B1D5 File Offset: 0x003593D5
		// (set) Token: 0x06024444 RID: 148548 RVA: 0x0035B1E9 File Offset: 0x003593E9
		public unsafe string ReceiptData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseRestoreInfo.__PropertyOffset_ReceiptData)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseRestoreInfo.__PropertyOffset_ReceiptData)), value);
			}
		}

		// Token: 0x17008BAA RID: 35754
		// (get) Token: 0x06024445 RID: 148549 RVA: 0x0035B1FE File Offset: 0x003593FE
		// (set) Token: 0x06024446 RID: 148550 RVA: 0x0035B212 File Offset: 0x00359412
		public unsafe string TransactionIdentifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseRestoreInfo.__PropertyOffset_TransactionIdentifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseRestoreInfo.__PropertyOffset_TransactionIdentifier)), value);
			}
		}

		// Token: 0x06024447 RID: 148551 RVA: 0x0035B227 File Offset: 0x00359427
		public FInAppPurchaseRestoreInfo()
		{
		}

		// Token: 0x06024448 RID: 148552 RVA: 0x0035B22F File Offset: 0x0035942F
		public FInAppPurchaseRestoreInfo(string Identifier, string ReceiptData, string TransactionIdentifier)
		{
			this.Identifier = Identifier;
			this.ReceiptData = ReceiptData;
			this.TransactionIdentifier = TransactionIdentifier;
		}

		// Token: 0x06024449 RID: 148553 RVA: 0x0035B24C File Offset: 0x0035944C
		protected override IntPtr GetUStructPtr()
		{
			return FInAppPurchaseRestoreInfo.StaticStruct();
		}

		// Token: 0x0602444A RID: 148554 RVA: 0x0035B258 File Offset: 0x00359458
		[NullableContext(2)]
		public FInAppPurchaseRestoreInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602444B RID: 148555 RVA: 0x0035B262 File Offset: 0x00359462
		public FInAppPurchaseRestoreInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602444C RID: 148556 RVA: 0x0035B26D File Offset: 0x0035946D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInAppPurchaseRestoreInfo(Pointer, false, true);
		}

		// Token: 0x0602444D RID: 148557 RVA: 0x0035B277 File Offset: 0x00359477
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInAppPurchaseRestoreInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013746 RID: 79686
		public const string __ObjectPath = "/Script/OnlineSubsystem.InAppPurchaseRestoreInfo";

		// Token: 0x04013747 RID: 79687
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013748 RID: 79688
		internal static int __PropertyOffset_Identifier;

		// Token: 0x04013749 RID: 79689
		internal static int __PropertyOffset_ReceiptData;

		// Token: 0x0401374A RID: 79690
		internal static int __PropertyOffset_TransactionIdentifier;
	}
}
