using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B2E RID: 6958
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLandscapeParametersData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroLandscapeParametersData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A439 RID: 107577 RVA: 0x0026C0D8 File Offset: 0x0026A2D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLandscapeParametersData._ClassPtr;
		}

		// Token: 0x0601A43A RID: 107578 RVA: 0x0026C0E4 File Offset: 0x0026A2E4
		public UKuroLandscapeParametersData() : this(BuiltinUtils.AllocNativeUObject(UKuroLandscapeParametersData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A43B RID: 107579 RVA: 0x0026C10C File Offset: 0x0026A30C
		public UKuroLandscapeParametersData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLandscapeParametersData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700699E RID: 27038
		// (get) Token: 0x0601A43C RID: 107580 RVA: 0x0026C140 File Offset: 0x0026A340
		// (set) Token: 0x0601A43D RID: 107581 RVA: 0x0026C179 File Offset: 0x0026A379
		public TArray<float> Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new TArray<float>(base.NativePtr + (IntPtr)UKuroLandscapeParametersData.__PropertyOffset_Parameters, this));
				}
				return result;
			}
			set
			{
				this.Parameters.CopyAssign(value);
			}
		}

		// Token: 0x0601A43E RID: 107582 RVA: 0x0026C187 File Offset: 0x0026A387
		static UKuroLandscapeParametersData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLandscapeParametersData");
		}

		// Token: 0x0601A43F RID: 107583 RVA: 0x0026C195 File Offset: 0x0026A395
		protected UKuroLandscapeParametersData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E40C RID: 58380
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLandscapeParametersData";

		// Token: 0x0400E40D RID: 58381
		private static IntPtr _ClassPtr;

		// Token: 0x0400E40E RID: 58382
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E40F RID: 58383
		internal static int __PropertyOffset_Parameters;

		// Token: 0x0400E410 RID: 58384
		[Nullable(2)]
		private TArray<float> _Parameters;
	}
}
