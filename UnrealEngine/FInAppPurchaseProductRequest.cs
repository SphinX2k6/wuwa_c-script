using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002615 RID: 9749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OnlineSubsystem.InAppPurchaseProductRequest")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInAppPurchaseProductRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024434 RID: 148532 RVA: 0x0035B0C8 File Offset: 0x003592C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInAppPurchaseProductRequest._ScriptStructPtr != 0) ? FInAppPurchaseProductRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OnlineSubsystem.InAppPurchaseProductRequest", ref FInAppPurchaseProductRequest._ScriptStructPtr);
		}

		// Token: 0x17008BA6 RID: 35750
		// (get) Token: 0x06024435 RID: 148533 RVA: 0x0035B0EC File Offset: 0x003592EC
		// (set) Token: 0x06024436 RID: 148534 RVA: 0x0035B100 File Offset: 0x00359300
		public unsafe string ProductIdentifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductRequest.__PropertyOffset_ProductIdentifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FInAppPurchaseProductRequest.__PropertyOffset_ProductIdentifier)), value);
			}
		}

		// Token: 0x17008BA7 RID: 35751
		// (get) Token: 0x06024437 RID: 148535 RVA: 0x0035B115 File Offset: 0x00359315
		// (set) Token: 0x06024438 RID: 148536 RVA: 0x0035B125 File Offset: 0x00359325
		public unsafe bool bIsConsumable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInAppPurchaseProductRequest.__PropertyOffset_bIsConsumable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInAppPurchaseProductRequest.__PropertyOffset_bIsConsumable) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024439 RID: 148537 RVA: 0x0035B136 File Offset: 0x00359336
		public FInAppPurchaseProductRequest()
		{
		}

		// Token: 0x0602443A RID: 148538 RVA: 0x0035B13E File Offset: 0x0035933E
		public FInAppPurchaseProductRequest(string ProductIdentifier, bool bIsConsumable)
		{
			this.ProductIdentifier = ProductIdentifier;
			this.bIsConsumable = bIsConsumable;
		}

		// Token: 0x0602443B RID: 148539 RVA: 0x0035B154 File Offset: 0x00359354
		protected override IntPtr GetUStructPtr()
		{
			return FInAppPurchaseProductRequest.StaticStruct();
		}

		// Token: 0x0602443C RID: 148540 RVA: 0x0035B160 File Offset: 0x00359360
		[NullableContext(2)]
		public FInAppPurchaseProductRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602443D RID: 148541 RVA: 0x0035B16A File Offset: 0x0035936A
		public FInAppPurchaseProductRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602443E RID: 148542 RVA: 0x0035B175 File Offset: 0x00359375
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInAppPurchaseProductRequest(Pointer, false, true);
		}

		// Token: 0x0602443F RID: 148543 RVA: 0x0035B17F File Offset: 0x0035937F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInAppPurchaseProductRequest(Pointer, MemoryOwner);
		}

		// Token: 0x04013742 RID: 79682
		public const string __ObjectPath = "/Script/OnlineSubsystem.InAppPurchaseProductRequest";

		// Token: 0x04013743 RID: 79683
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013744 RID: 79684
		internal static int __PropertyOffset_ProductIdentifier;

		// Token: 0x04013745 RID: 79685
		internal static int __PropertyOffset_bIsConsumable;
	}
}
