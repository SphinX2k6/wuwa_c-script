using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009C7 RID: 2503
	[UnrealObjectPath("/Script/Engine.DistributionFloat")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UDistributionFloat : UDistribution, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DC3 RID: 36291 RVA: 0x000CA9FD File Offset: 0x000C8BFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionFloat._ClassPtr;
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06008DC4 RID: 36292 RVA: 0x000CAA09 File Offset: 0x000C8C09
		// (set) Token: 0x06008DC5 RID: 36293 RVA: 0x000CAA22 File Offset: 0x000C8C22
		public unsafe bool bCanBeBaked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionFloat.__PropertyOffset_bCanBeBaked) & UDistributionFloat.__PropertyMask_bCanBeBaked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionFloat.__PropertyOffset_bCanBeBaked) = ((*(base.NativePtr + (IntPtr)UDistributionFloat.__PropertyOffset_bCanBeBaked) & ~UDistributionFloat.__PropertyMask_bCanBeBaked) | (value ? UDistributionFloat.__PropertyMask_bCanBeBaked : 0));
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06008DC6 RID: 36294 RVA: 0x000CAA52 File Offset: 0x000C8C52
		// (set) Token: 0x06008DC7 RID: 36295 RVA: 0x000CAA6B File Offset: 0x000C8C6B
		public unsafe bool bBakedDataSuccesfully
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionFloat.__PropertyOffset_bBakedDataSuccesfully) & UDistributionFloat.__PropertyMask_bBakedDataSuccesfully) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionFloat.__PropertyOffset_bBakedDataSuccesfully) = ((*(base.NativePtr + (IntPtr)UDistributionFloat.__PropertyOffset_bBakedDataSuccesfully) & ~UDistributionFloat.__PropertyMask_bBakedDataSuccesfully) | (value ? UDistributionFloat.__PropertyMask_bBakedDataSuccesfully : 0));
			}
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x000CAA9B File Offset: 0x000C8C9B
		static UDistributionFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionFloat");
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x000CAAAC File Offset: 0x000C8CAC
		protected UDistributionFloat() : this(BuiltinUtils.AllocNativeUObject(UDistributionFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x000CAAD4 File Offset: 0x000C8CD4
		protected UDistributionFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004348 RID: 17224
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionFloat";

		// Token: 0x04004349 RID: 17225
		private static IntPtr _ClassPtr;

		// Token: 0x0400434A RID: 17226
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400434B RID: 17227
		internal static int __PropertyOffset_bCanBeBaked;

		// Token: 0x0400434C RID: 17228
		internal static byte __PropertyMask_bCanBeBaked;

		// Token: 0x0400434D RID: 17229
		internal static int __PropertyOffset_bBakedDataSuccesfully;

		// Token: 0x0400434E RID: 17230
		internal static byte __PropertyMask_bBakedDataSuccesfully;
	}
}
