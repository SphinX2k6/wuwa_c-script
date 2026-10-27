using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C93 RID: 7315
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.PaymentStruct")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPaymentStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C69D RID: 116381 RVA: 0x0029F618 File Offset: 0x0029D818
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPaymentStruct._ScriptStructPtr != 0) ? FPaymentStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.PaymentStruct", ref FPaymentStruct._ScriptStructPtr);
		}

		// Token: 0x170072C5 RID: 29381
		// (get) Token: 0x0601C69E RID: 116382 RVA: 0x0029F63C File Offset: 0x0029D83C
		// (set) Token: 0x0601C69F RID: 116383 RVA: 0x0029F650 File Offset: 0x0029D850
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

		// Token: 0x170072C6 RID: 29382
		// (get) Token: 0x0601C6A0 RID: 116384 RVA: 0x0029F665 File Offset: 0x0029D865
		// (set) Token: 0x0601C6A1 RID: 116385 RVA: 0x0029F675 File Offset: 0x0029D875
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

		// Token: 0x170072C7 RID: 29383
		// (get) Token: 0x0601C6A2 RID: 116386 RVA: 0x0029F686 File Offset: 0x0029D886
		// (set) Token: 0x0601C6A3 RID: 116387 RVA: 0x0029F69A File Offset: 0x0029D89A
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

		// Token: 0x170072C8 RID: 29384
		// (get) Token: 0x0601C6A4 RID: 116388 RVA: 0x0029F6AF File Offset: 0x0029D8AF
		// (set) Token: 0x0601C6A5 RID: 116389 RVA: 0x0029F6C3 File Offset: 0x0029D8C3
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

		// Token: 0x0601C6A6 RID: 116390 RVA: 0x0029F6D8 File Offset: 0x0029D8D8
		public FPaymentStruct()
		{
		}

		// Token: 0x0601C6A7 RID: 116391 RVA: 0x0029F6E0 File Offset: 0x0029D8E0
		public FPaymentStruct(string OrderId, EPaymentType PaymentType, string Type, string ExtraInfo)
		{
			this.OrderId = OrderId;
			this.PaymentType = PaymentType;
			this.Type = Type;
			this.ExtraInfo = ExtraInfo;
		}

		// Token: 0x0601C6A8 RID: 116392 RVA: 0x0029F705 File Offset: 0x0029D905
		protected override IntPtr GetUStructPtr()
		{
			return FPaymentStruct.StaticStruct();
		}

		// Token: 0x0601C6A9 RID: 116393 RVA: 0x0029F711 File Offset: 0x0029D911
		[NullableContext(2)]
		public FPaymentStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6AA RID: 116394 RVA: 0x0029F71B File Offset: 0x0029D91B
		public FPaymentStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6AB RID: 116395 RVA: 0x0029F726 File Offset: 0x0029D926
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPaymentStruct(Pointer, false, true);
		}

		// Token: 0x0601C6AC RID: 116396 RVA: 0x0029F730 File Offset: 0x0029D930
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPaymentStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400F497 RID: 62615
		public const string __ObjectPath = "/Script/KuroSDK.PaymentStruct";

		// Token: 0x0400F498 RID: 62616
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F499 RID: 62617
		internal static int __PropertyOffset_OrderId;

		// Token: 0x0400F49A RID: 62618
		internal static int __PropertyOffset_PaymentType;

		// Token: 0x0400F49B RID: 62619
		internal static int __PropertyOffset_Type;

		// Token: 0x0400F49C RID: 62620
		internal static int __PropertyOffset_ExtraInfo;
	}
}
