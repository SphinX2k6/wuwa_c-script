using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009CD RID: 2509
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DistributionFloatUniformCurve")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UDistributionFloatUniformCurve : UDistributionFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DF7 RID: 36343 RVA: 0x000CAEC0 File Offset: 0x000C90C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionFloatUniformCurve._ClassPtr;
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x000CAECC File Offset: 0x000C90CC
		public UDistributionFloatUniformCurve() : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatUniformCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x000CAEF4 File Offset: 0x000C90F4
		public UDistributionFloatUniformCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatUniformCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06008DFA RID: 36346 RVA: 0x000CAF28 File Offset: 0x000C9128
		// (set) Token: 0x06008DFB RID: 36347 RVA: 0x000CAF61 File Offset: 0x000C9161
		public FInterpCurveVector2D ConstantCurve
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector2D result;
				if ((result = this._ConstantCurve) == null)
				{
					result = (this._ConstantCurve = new FInterpCurveVector2D(base.NativePtr + (IntPtr)UDistributionFloatUniformCurve.__PropertyOffset_ConstantCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector2D.StaticStruct(), base.NativePtr + (IntPtr)UDistributionFloatUniformCurve.__PropertyOffset_ConstantCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x000CAF82 File Offset: 0x000C9182
		static UDistributionFloatUniformCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionFloatUniformCurve");
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x000CAF90 File Offset: 0x000C9190
		protected UDistributionFloatUniformCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004369 RID: 17257
		public new const string __ObjectPath = "/Script/Engine.DistributionFloatUniformCurve";

		// Token: 0x0400436A RID: 17258
		private static IntPtr _ClassPtr;

		// Token: 0x0400436B RID: 17259
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400436C RID: 17260
		internal static int __PropertyOffset_ConstantCurve;

		// Token: 0x0400436D RID: 17261
		[Nullable(2)]
		private FInterpCurveVector2D _ConstantCurve;
	}
}
