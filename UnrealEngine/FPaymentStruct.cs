using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200052C RID: 1324
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.PaymentStruct")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPaymentStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007BDB RID: 31707 RVA: 0x000B6FF1 File Offset: 0x000B51F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPaymentStruct._ScriptStructPtr != 0) ? FPaymentStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.PaymentStruct", ref FPaymentStruct._ScriptStructPtr);
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06007BDC RID: 31708 RVA: 0x000B7015 File Offset: 0x000B5215
		// (set) Token: 0x06007BDD RID: 31709 RVA: 0x000B7029 File Offset: 0x000B5229
		public unsafe string OrderId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPaymentStruct.__PropertyOffset_OrderId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPaymentStruct.__PropertyOffset_OrderId)), value);
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06007BDE RID: 31710 RVA: 0x000B703E File Offset: 0x000B523E
		// (set) Token: 0x06007BDF RID: 31711 RVA: 0x000B704E File Offset: 0x000B524E
		public unsafe EPaymentType PaymentType
		{
			get
			{
				return (EPaymentType)(*(base.NativePtr + (IntPtr)FPaymentStruct.__PropertyOffset_PaymentType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPaymentStruct.__PropertyOffset_PaymentType) = (byte)value;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06007BE0 RID: 31712 RVA: 0x000B705F File Offset: 0x000B525F
		// (set) Token: 0x06007BE1 RID: 31713 RVA: 0x000B7073 File Offset: 0x000B5273
		public unsafe string Type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPaymentStruct.__PropertyOffset_Type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPaymentStruct.__PropertyOffset_Type)), value);
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06007BE2 RID: 31714 RVA: 0x000B7088 File Offset: 0x000B5288
		// (set) Token: 0x06007BE3 RID: 31715 RVA: 0x000B709C File Offset: 0x000B529C
		public unsafe string ExtraInfo
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPaymentStruct.__PropertyOffset_ExtraInfo)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPaymentStruct.__PropertyOffset_ExtraInfo)), value);
			}
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x000B70B1 File Offset: 0x000B52B1
		public FPaymentStruct()
		{
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x000B70B9 File Offset: 0x000B52B9
		protected override IntPtr GetUStructPtr()
		{
			return FPaymentStruct.StaticStruct();
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x000B70C5 File Offset: 0x000B52C5
		[NullableContext(2)]
		public FPaymentStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007BE7 RID: 31719 RVA: 0x000B70CF File Offset: 0x000B52CF
		public FPaymentStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x000B70DA File Offset: 0x000B52DA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPaymentStruct(Pointer, false, true);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x000B70E4 File Offset: 0x000B52E4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPaymentStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04003501 RID: 13569
		public const string __ObjectPath = "/Script/KuroSDK.PaymentStruct";

		// Token: 0x04003502 RID: 13570
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003503 RID: 13571
		internal static int __PropertyOffset_OrderId;

		// Token: 0x04003504 RID: 13572
		internal static int __PropertyOffset_PaymentType;

		// Token: 0x04003505 RID: 13573
		internal static int __PropertyOffset_Type;

		// Token: 0x04003506 RID: 13574
		internal static int __PropertyOffset_ExtraInfo;
	}
}
