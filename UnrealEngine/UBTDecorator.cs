using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000138 RID: 312
	[UnrealObjectPath("/Script/AIModule.BTDecorator")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UBTDecorator : UBTAuxiliaryNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015F0 RID: 5616 RVA: 0x000203E3 File Offset: 0x0001E5E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator._ClassPtr;
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x000203EF File Offset: 0x0001E5EF
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x00020408 File Offset: 0x0001E608
		public unsafe bool bInverseCondition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator.__PropertyOffset_bInverseCondition) & UBTDecorator.__PropertyMask_bInverseCondition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator.__PropertyOffset_bInverseCondition) = ((*(base.NativePtr + (IntPtr)UBTDecorator.__PropertyOffset_bInverseCondition) & ~UBTDecorator.__PropertyMask_bInverseCondition) | (value ? UBTDecorator.__PropertyMask_bInverseCondition : 0));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00020438 File Offset: 0x0001E638
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0002044C File Offset: 0x0001E64C
		public unsafe TEnumAsByte<EBTFlowAbortMode> FlowAbortMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator.__PropertyOffset_FlowAbortMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator.__PropertyOffset_FlowAbortMode) = value;
			}
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00020461 File Offset: 0x0001E661
		static UBTDecorator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator");
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00020470 File Offset: 0x0001E670
		protected UBTDecorator() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00020498 File Offset: 0x0001E698
		protected UBTDecorator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004D3 RID: 1235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator";

		// Token: 0x040004D4 RID: 1236
		private static IntPtr _ClassPtr;

		// Token: 0x040004D5 RID: 1237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004D6 RID: 1238
		internal static int __PropertyOffset_bInverseCondition;

		// Token: 0x040004D7 RID: 1239
		internal static byte __PropertyMask_bInverseCondition;

		// Token: 0x040004D8 RID: 1240
		internal static int __PropertyOffset_FlowAbortMode;
	}
}
