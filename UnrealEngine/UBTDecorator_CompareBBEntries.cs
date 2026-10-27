using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013E RID: 318
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_CompareBBEntries")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UBTDecorator_CompareBBEntries : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x00020C8A File Offset: 0x0001EE8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_CompareBBEntries._ClassPtr;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00020C98 File Offset: 0x0001EE98
		public UBTDecorator_CompareBBEntries() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_CompareBBEntries.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		public UBTDecorator_CompareBBEntries(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_CompareBBEntries.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x00020CF3 File Offset: 0x0001EEF3
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x00020D07 File Offset: 0x0001EF07
		[Nullable(0)]
		public unsafe TEnumAsByte<EBlackBoardEntryComparison> Operator
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_CompareBBEntries.__PropertyOffset_Operator);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_CompareBBEntries.__PropertyOffset_Operator) = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00020D1C File Offset: 0x0001EF1C
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x00020D55 File Offset: 0x0001EF55
		public FBlackboardKeySelector BlackboardKeyA
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKeyA) == null)
				{
					result = (this._BlackboardKeyA = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_CompareBBEntries.__PropertyOffset_BlackboardKeyA, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_CompareBBEntries.__PropertyOffset_BlackboardKeyA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x00020D78 File Offset: 0x0001EF78
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x00020DB1 File Offset: 0x0001EFB1
		public FBlackboardKeySelector BlackboardKeyB
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKeyB) == null)
				{
					result = (this._BlackboardKeyB = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_CompareBBEntries.__PropertyOffset_BlackboardKeyB, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_CompareBBEntries.__PropertyOffset_BlackboardKeyB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00020DD2 File Offset: 0x0001EFD2
		static UBTDecorator_CompareBBEntries()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_CompareBBEntries");
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00020DE0 File Offset: 0x0001EFE0
		protected UBTDecorator_CompareBBEntries(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000501 RID: 1281
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_CompareBBEntries";

		// Token: 0x04000502 RID: 1282
		private static IntPtr _ClassPtr;

		// Token: 0x04000503 RID: 1283
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000504 RID: 1284
		internal static int __PropertyOffset_Operator;

		// Token: 0x04000505 RID: 1285
		internal static int __PropertyOffset_BlackboardKeyA;

		// Token: 0x04000506 RID: 1286
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKeyA;

		// Token: 0x04000507 RID: 1287
		internal static int __PropertyOffset_BlackboardKeyB;

		// Token: 0x04000508 RID: 1288
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKeyB;
	}
}
