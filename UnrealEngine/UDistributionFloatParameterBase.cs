using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009CA RID: 2506
	[UnrealObjectPath("/Script/Engine.DistributionFloatParameterBase")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class UDistributionFloatParameterBase : UDistributionFloatConstant, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DD9 RID: 36313 RVA: 0x000CAC59 File Offset: 0x000C8E59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionFloatParameterBase._ClassPtr;
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06008DDA RID: 36314 RVA: 0x000CAC65 File Offset: 0x000C8E65
		// (set) Token: 0x06008DDB RID: 36315 RVA: 0x000CAC79 File Offset: 0x000C8E79
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06008DDC RID: 36316 RVA: 0x000CAC8E File Offset: 0x000C8E8E
		// (set) Token: 0x06008DDD RID: 36317 RVA: 0x000CAC9E File Offset: 0x000C8E9E
		public unsafe float MinInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MinInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MinInput) = value;
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06008DDE RID: 36318 RVA: 0x000CACAF File Offset: 0x000C8EAF
		// (set) Token: 0x06008DDF RID: 36319 RVA: 0x000CACBF File Offset: 0x000C8EBF
		public unsafe float MaxInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MaxInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MaxInput) = value;
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06008DE0 RID: 36320 RVA: 0x000CACD0 File Offset: 0x000C8ED0
		// (set) Token: 0x06008DE1 RID: 36321 RVA: 0x000CACE0 File Offset: 0x000C8EE0
		public unsafe float MinOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MinOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MinOutput) = value;
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06008DE2 RID: 36322 RVA: 0x000CACF1 File Offset: 0x000C8EF1
		// (set) Token: 0x06008DE3 RID: 36323 RVA: 0x000CAD01 File Offset: 0x000C8F01
		public unsafe float MaxOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MaxOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_MaxOutput) = value;
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06008DE4 RID: 36324 RVA: 0x000CAD12 File Offset: 0x000C8F12
		// (set) Token: 0x06008DE5 RID: 36325 RVA: 0x000CAD26 File Offset: 0x000C8F26
		public unsafe TEnumAsByte<DistributionParamMode> ParamMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_ParamMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatParameterBase.__PropertyOffset_ParamMode) = value;
			}
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x000CAD3B File Offset: 0x000C8F3B
		static UDistributionFloatParameterBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionFloatParameterBase");
		}

		// Token: 0x06008DE7 RID: 36327 RVA: 0x000CAD4C File Offset: 0x000C8F4C
		protected UDistributionFloatParameterBase() : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatParameterBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x000CAD74 File Offset: 0x000C8F74
		protected UDistributionFloatParameterBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004358 RID: 17240
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionFloatParameterBase";

		// Token: 0x04004359 RID: 17241
		private static IntPtr _ClassPtr;

		// Token: 0x0400435A RID: 17242
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400435B RID: 17243
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400435C RID: 17244
		internal static int __PropertyOffset_MinInput;

		// Token: 0x0400435D RID: 17245
		internal static int __PropertyOffset_MaxInput;

		// Token: 0x0400435E RID: 17246
		internal static int __PropertyOffset_MinOutput;

		// Token: 0x0400435F RID: 17247
		internal static int __PropertyOffset_MaxOutput;

		// Token: 0x04004360 RID: 17248
		internal static int __PropertyOffset_ParamMode;
	}
}
