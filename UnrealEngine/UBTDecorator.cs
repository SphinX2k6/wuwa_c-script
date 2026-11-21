using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B1 RID: 177
	[UnrealObjectPath("/Script/AIModule.BTDecorator")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UBTDecorator : UBTAuxiliaryNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x0001511D File Offset: 0x0001331D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator._ClassPtr;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00015129 File Offset: 0x00013329
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00015142 File Offset: 0x00013342
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

		// Token: 0x06000D51 RID: 3409 RVA: 0x00015172 File Offset: 0x00013372
		static UBTDecorator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator");
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00015180 File Offset: 0x00013380
		protected UBTDecorator() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000151A8 File Offset: 0x000133A8
		protected UBTDecorator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400025A RID: 602
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator";

		// Token: 0x0400025B RID: 603
		private static IntPtr _ClassPtr;

		// Token: 0x0400025C RID: 604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400025D RID: 605
		internal static int __PropertyOffset_bInverseCondition;

		// Token: 0x0400025E RID: 606
		internal static byte __PropertyMask_bInverseCondition;
	}
}
