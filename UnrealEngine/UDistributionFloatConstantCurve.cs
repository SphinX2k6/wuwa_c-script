using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009C9 RID: 2505
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DistributionFloatConstantCurve")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UDistributionFloatConstantCurve : UDistributionFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DD2 RID: 36306 RVA: 0x000CAB7F File Offset: 0x000C8D7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionFloatConstantCurve._ClassPtr;
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x000CAB8C File Offset: 0x000C8D8C
		public UDistributionFloatConstantCurve() : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatConstantCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x000CABB4 File Offset: 0x000C8DB4
		public UDistributionFloatConstantCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatConstantCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06008DD5 RID: 36309 RVA: 0x000CABE8 File Offset: 0x000C8DE8
		// (set) Token: 0x06008DD6 RID: 36310 RVA: 0x000CAC21 File Offset: 0x000C8E21
		public FInterpCurveFloat ConstantCurve
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveFloat result;
				if ((result = this._ConstantCurve) == null)
				{
					result = (this._ConstantCurve = new FInterpCurveFloat(base.NativePtr + (IntPtr)UDistributionFloatConstantCurve.__PropertyOffset_ConstantCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UDistributionFloatConstantCurve.__PropertyOffset_ConstantCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008DD7 RID: 36311 RVA: 0x000CAC42 File Offset: 0x000C8E42
		static UDistributionFloatConstantCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionFloatConstantCurve");
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x000CAC50 File Offset: 0x000C8E50
		protected UDistributionFloatConstantCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004353 RID: 17235
		public new const string __ObjectPath = "/Script/Engine.DistributionFloatConstantCurve";

		// Token: 0x04004354 RID: 17236
		private static IntPtr _ClassPtr;

		// Token: 0x04004355 RID: 17237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004356 RID: 17238
		internal static int __PropertyOffset_ConstantCurve;

		// Token: 0x04004357 RID: 17239
		[Nullable(2)]
		private FInterpCurveFloat _ConstantCurve;
	}
}
