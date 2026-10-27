using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013A RID: 314
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_Blackboard")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UBTDecorator_Blackboard : UBTDecorator_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001604 RID: 5636 RVA: 0x00020561 File Offset: 0x0001E761
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_Blackboard._ClassPtr;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00020570 File Offset: 0x0001E770
		public UBTDecorator_Blackboard() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_Blackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00020598 File Offset: 0x0001E798
		public UBTDecorator_Blackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_Blackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x000205CB File Offset: 0x0001E7CB
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x000205DB File Offset: 0x0001E7DB
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x000205EC File Offset: 0x0001E7EC
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x000205FC File Offset: 0x0001E7FC
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0002060D File Offset: 0x0001E80D
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00020621 File Offset: 0x0001E821
		public unsafe string StringValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBTDecorator_Blackboard.__PropertyOffset_StringValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBTDecorator_Blackboard.__PropertyOffset_StringValue)), value);
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00020636 File Offset: 0x0001E836
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x0002064A File Offset: 0x0001E84A
		public unsafe string CachedDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBTDecorator_Blackboard.__PropertyOffset_CachedDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBTDecorator_Blackboard.__PropertyOffset_CachedDescription)), value);
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0002065F File Offset: 0x0001E85F
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x0002066F File Offset: 0x0001E86F
		public unsafe byte OperationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_OperationType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_OperationType) = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00020680 File Offset: 0x0001E880
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x00020694 File Offset: 0x0001E894
		[Nullable(0)]
		public unsafe TEnumAsByte<EBTBlackboardRestart> NotifyObserver
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_NotifyObserver);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_Blackboard.__PropertyOffset_NotifyObserver) = value;
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000206A9 File Offset: 0x0001E8A9
		static UBTDecorator_Blackboard()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_Blackboard");
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000206B7 File Offset: 0x0001E8B7
		protected UBTDecorator_Blackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004DD RID: 1245
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_Blackboard";

		// Token: 0x040004DE RID: 1246
		private static IntPtr _ClassPtr;

		// Token: 0x040004DF RID: 1247
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004E0 RID: 1248
		internal static int __PropertyOffset_IntValue;

		// Token: 0x040004E1 RID: 1249
		internal static int __PropertyOffset_FloatValue;

		// Token: 0x040004E2 RID: 1250
		internal static int __PropertyOffset_StringValue;

		// Token: 0x040004E3 RID: 1251
		internal static int __PropertyOffset_CachedDescription;

		// Token: 0x040004E4 RID: 1252
		internal static int __PropertyOffset_OperationType;

		// Token: 0x040004E5 RID: 1253
		internal static int __PropertyOffset_NotifyObserver;
	}
}
