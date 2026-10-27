using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019B RID: 411
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_ProjectedPoints")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UEnvQueryGenerator_ProjectedPoints : UEnvQueryGenerator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600197B RID: 6523 RVA: 0x00025D31 File Offset: 0x00023F31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_ProjectedPoints._ClassPtr;
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00025D40 File Offset: 0x00023F40
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x00025D79 File Offset: 0x00023F79
		public FEnvTraceData ProjectionData
		{
			get
			{
				base.FastCheckIsValid();
				FEnvTraceData result;
				if ((result = this._ProjectionData) == null)
				{
					result = (this._ProjectionData = new FEnvTraceData(base.NativePtr + (IntPtr)UEnvQueryGenerator_ProjectedPoints.__PropertyOffset_ProjectionData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvTraceData.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_ProjectedPoints.__PropertyOffset_ProjectionData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00025D9A File Offset: 0x00023F9A
		static UEnvQueryGenerator_ProjectedPoints()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_ProjectedPoints");
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00025DA8 File Offset: 0x00023FA8
		protected UEnvQueryGenerator_ProjectedPoints() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_ProjectedPoints.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00025DD0 File Offset: 0x00023FD0
		protected UEnvQueryGenerator_ProjectedPoints(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400076E RID: 1902
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_ProjectedPoints";

		// Token: 0x0400076F RID: 1903
		private static IntPtr _ClassPtr;

		// Token: 0x04000770 RID: 1904
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000771 RID: 1905
		internal static int __PropertyOffset_ProjectionData;

		// Token: 0x04000772 RID: 1906
		[Nullable(2)]
		private FEnvTraceData _ProjectionData;
	}
}
