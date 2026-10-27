using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D2 RID: 2514
	[UnrealObjectPath("/Script/Engine.DistributionVectorConstantCurve")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UDistributionVectorConstantCurve : UDistributionVector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E2B RID: 36395 RVA: 0x000CB3C9 File Offset: 0x000C95C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionVectorConstantCurve._ClassPtr;
		}

		// Token: 0x06008E2C RID: 36396 RVA: 0x000CB3D8 File Offset: 0x000C95D8
		public UDistributionVectorConstantCurve() : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorConstantCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E2D RID: 36397 RVA: 0x000CB400 File Offset: 0x000C9600
		[NullableContext(1)]
		public UDistributionVectorConstantCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorConstantCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x000CB434 File Offset: 0x000C9634
		// (set) Token: 0x06008E2F RID: 36399 RVA: 0x000CB46D File Offset: 0x000C966D
		[Nullable(1)]
		public FInterpCurveVector ConstantCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._ConstantCurve) == null)
				{
					result = (this._ConstantCurve = new FInterpCurveVector(base.NativePtr + (IntPtr)UDistributionVectorConstantCurve.__PropertyOffset_ConstantCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UDistributionVectorConstantCurve.__PropertyOffset_ConstantCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06008E30 RID: 36400 RVA: 0x000CB48E File Offset: 0x000C968E
		// (set) Token: 0x06008E31 RID: 36401 RVA: 0x000CB4A7 File Offset: 0x000C96A7
		public unsafe bool bLockAxes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVectorConstantCurve.__PropertyOffset_bLockAxes) & UDistributionVectorConstantCurve.__PropertyMask_bLockAxes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVectorConstantCurve.__PropertyOffset_bLockAxes) = ((*(base.NativePtr + (IntPtr)UDistributionVectorConstantCurve.__PropertyOffset_bLockAxes) & ~UDistributionVectorConstantCurve.__PropertyMask_bLockAxes) | (value ? UDistributionVectorConstantCurve.__PropertyMask_bLockAxes : 0));
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06008E32 RID: 36402 RVA: 0x000CB4D7 File Offset: 0x000C96D7
		// (set) Token: 0x06008E33 RID: 36403 RVA: 0x000CB4EB File Offset: 0x000C96EB
		public unsafe TEnumAsByte<EDistributionVectorLockFlags> LockedAxes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorConstantCurve.__PropertyOffset_LockedAxes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorConstantCurve.__PropertyOffset_LockedAxes) = value;
			}
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x000CB500 File Offset: 0x000C9700
		static UDistributionVectorConstantCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionVectorConstantCurve");
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x000CB50E File Offset: 0x000C970E
		protected UDistributionVectorConstantCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400438E RID: 17294
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionVectorConstantCurve";

		// Token: 0x0400438F RID: 17295
		private static IntPtr _ClassPtr;

		// Token: 0x04004390 RID: 17296
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004391 RID: 17297
		internal static int __PropertyOffset_ConstantCurve;

		// Token: 0x04004392 RID: 17298
		[Nullable(2)]
		private FInterpCurveVector _ConstantCurve;

		// Token: 0x04004393 RID: 17299
		internal static int __PropertyOffset_bLockAxes;

		// Token: 0x04004394 RID: 17300
		internal static byte __PropertyMask_bLockAxes;

		// Token: 0x04004395 RID: 17301
		internal static int __PropertyOffset_LockedAxes;
	}
}
