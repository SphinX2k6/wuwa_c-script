using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000978 RID: 2424
	[UnrealObjectPath("/Script/Engine.CurveBase")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class UCurveBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008927 RID: 35111 RVA: 0x000C4683 File Offset: 0x000C2883
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveBase._ClassPtr;
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x000C4690 File Offset: 0x000C2890
		public unsafe void GetValueRange(ref float MinValue, ref float MaxValue)
		{
			fixed (float* ptr = &MinValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &MaxValue)
				{
					void* ptr4 = (void*)ptr3;
					UCurveBase.__GetValueRange_Internal(base.NativePtr, ref MinValue, ref MaxValue);
					ptr = null;
				}
			}
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x000C46BC File Offset: 0x000C28BC
		public unsafe void GetTimeRange(ref float MinTime, ref float MaxTime)
		{
			fixed (float* ptr = &MinTime)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &MaxTime)
				{
					void* ptr4 = (void*)ptr3;
					UCurveBase.__GetTimeRange_Internal(base.NativePtr, ref MinTime, ref MaxTime);
					ptr = null;
				}
			}
		}

		// Token: 0x0600892A RID: 35114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetValueRange_Internal(IntPtr @this, ref float MinValue, ref float MaxValue);

		// Token: 0x0600892B RID: 35115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTimeRange_Internal(IntPtr @this, ref float MinTime, ref float MaxTime);

		// Token: 0x0600892C RID: 35116 RVA: 0x000C46E6 File Offset: 0x000C28E6
		static UCurveBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveBase");
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x000C46F4 File Offset: 0x000C28F4
		protected UCurveBase() : this(BuiltinUtils.AllocNativeUObject(UCurveBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x000C471C File Offset: 0x000C291C
		protected UCurveBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004126 RID: 16678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CurveBase";

		// Token: 0x04004127 RID: 16679
		private static IntPtr _ClassPtr;

		// Token: 0x04004128 RID: 16680
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
