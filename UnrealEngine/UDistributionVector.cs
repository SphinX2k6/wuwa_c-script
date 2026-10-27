using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D0 RID: 2512
	[UnrealObjectPath("/Script/Engine.DistributionVector")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UDistributionVector : UDistribution, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E16 RID: 36374 RVA: 0x000CB184 File Offset: 0x000C9384
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionVector._ClassPtr;
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06008E17 RID: 36375 RVA: 0x000CB190 File Offset: 0x000C9390
		// (set) Token: 0x06008E18 RID: 36376 RVA: 0x000CB1A9 File Offset: 0x000C93A9
		public unsafe bool bCanBeBaked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bCanBeBaked) & UDistributionVector.__PropertyMask_bCanBeBaked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bCanBeBaked) = ((*(base.NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bCanBeBaked) & ~UDistributionVector.__PropertyMask_bCanBeBaked) | (value ? UDistributionVector.__PropertyMask_bCanBeBaked : 0));
			}
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06008E19 RID: 36377 RVA: 0x000CB1D9 File Offset: 0x000C93D9
		// (set) Token: 0x06008E1A RID: 36378 RVA: 0x000CB1F2 File Offset: 0x000C93F2
		public unsafe bool bIsDirty
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bIsDirty) & UDistributionVector.__PropertyMask_bIsDirty) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bIsDirty) = ((*(base.NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bIsDirty) & ~UDistributionVector.__PropertyMask_bIsDirty) | (value ? UDistributionVector.__PropertyMask_bIsDirty : 0));
			}
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x000CB222 File Offset: 0x000C9422
		// (set) Token: 0x06008E1C RID: 36380 RVA: 0x000CB23B File Offset: 0x000C943B
		public unsafe bool bBakedDataSuccesfully
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bBakedDataSuccesfully) & UDistributionVector.__PropertyMask_bBakedDataSuccesfully) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bBakedDataSuccesfully) = ((*(base.NativePtr + (IntPtr)UDistributionVector.__PropertyOffset_bBakedDataSuccesfully) & ~UDistributionVector.__PropertyMask_bBakedDataSuccesfully) | (value ? UDistributionVector.__PropertyMask_bBakedDataSuccesfully : 0));
			}
		}

		// Token: 0x06008E1D RID: 36381 RVA: 0x000CB26B File Offset: 0x000C946B
		static UDistributionVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionVector");
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x000CB27C File Offset: 0x000C947C
		protected UDistributionVector() : this(BuiltinUtils.AllocNativeUObject(UDistributionVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x000CB2A4 File Offset: 0x000C94A4
		protected UDistributionVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400437E RID: 17278
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionVector";

		// Token: 0x0400437F RID: 17279
		private static IntPtr _ClassPtr;

		// Token: 0x04004380 RID: 17280
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004381 RID: 17281
		internal static int __PropertyOffset_bCanBeBaked;

		// Token: 0x04004382 RID: 17282
		internal static byte __PropertyMask_bCanBeBaked;

		// Token: 0x04004383 RID: 17283
		internal static int __PropertyOffset_bIsDirty;

		// Token: 0x04004384 RID: 17284
		internal static byte __PropertyMask_bIsDirty;

		// Token: 0x04004385 RID: 17285
		internal static int __PropertyOffset_bBakedDataSuccesfully;

		// Token: 0x04004386 RID: 17286
		internal static byte __PropertyMask_bBakedDataSuccesfully;
	}
}
