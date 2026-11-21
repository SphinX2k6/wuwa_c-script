using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001BF RID: 447
	[UnrealObjectPath("/Script/Engine.CurveBase")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class UCurveBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020D6 RID: 8406 RVA: 0x0003039F File Offset: 0x0002E59F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveBase._ClassPtr;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000303AC File Offset: 0x0002E5AC
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

		// Token: 0x060020D8 RID: 8408 RVA: 0x000303D8 File Offset: 0x0002E5D8
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

		// Token: 0x060020D9 RID: 8409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetValueRange_Internal(IntPtr @this, ref float MinValue, ref float MaxValue);

		// Token: 0x060020DA RID: 8410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTimeRange_Internal(IntPtr @this, ref float MinTime, ref float MaxTime);

		// Token: 0x060020DB RID: 8411 RVA: 0x00030402 File Offset: 0x0002E602
		static UCurveBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveBase");
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00030410 File Offset: 0x0002E610
		protected UCurveBase() : this(BuiltinUtils.AllocNativeUObject(UCurveBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00030438 File Offset: 0x0002E638
		protected UCurveBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AE5 RID: 2789
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CurveBase";

		// Token: 0x04000AE6 RID: 2790
		private static IntPtr _ClassPtr;

		// Token: 0x04000AE7 RID: 2791
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
