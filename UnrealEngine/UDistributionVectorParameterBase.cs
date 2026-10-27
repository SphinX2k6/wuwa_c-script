using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D3 RID: 2515
	[UnrealObjectPath("/Script/Engine.DistributionVectorParameterBase")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public abstract class UDistributionVectorParameterBase : UDistributionVectorConstant, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E36 RID: 36406 RVA: 0x000CB517 File Offset: 0x000C9717
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionVectorParameterBase._ClassPtr;
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x000CB523 File Offset: 0x000C9723
		// (set) Token: 0x06008E38 RID: 36408 RVA: 0x000CB537 File Offset: 0x000C9737
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x000CB54C File Offset: 0x000C974C
		// (set) Token: 0x06008E3A RID: 36410 RVA: 0x000CB560 File Offset: 0x000C9760
		public unsafe FVector MinInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MinInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MinInput) = value;
			}
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06008E3B RID: 36411 RVA: 0x000CB575 File Offset: 0x000C9775
		// (set) Token: 0x06008E3C RID: 36412 RVA: 0x000CB589 File Offset: 0x000C9789
		public unsafe FVector MaxInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MaxInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MaxInput) = value;
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06008E3D RID: 36413 RVA: 0x000CB59E File Offset: 0x000C979E
		// (set) Token: 0x06008E3E RID: 36414 RVA: 0x000CB5B2 File Offset: 0x000C97B2
		public unsafe FVector MinOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MinOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MinOutput) = value;
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06008E3F RID: 36415 RVA: 0x000CB5C7 File Offset: 0x000C97C7
		// (set) Token: 0x06008E40 RID: 36416 RVA: 0x000CB5DB File Offset: 0x000C97DB
		public unsafe FVector MaxOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MaxOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_MaxOutput) = value;
			}
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x000CB5F0 File Offset: 0x000C97F0
		// (set) Token: 0x06008E42 RID: 36418 RVA: 0x000CB62A File Offset: 0x000C982A
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TFixedArray<TEnumAsByte<DistributionParamMode>> ParamModes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TEnumAsByte<DistributionParamMode>> result;
				if ((result = this._ParamModes) == null)
				{
					result = (this._ParamModes = new TFixedArray<TEnumAsByte<DistributionParamMode>>(base.NativePtr + (IntPtr)UDistributionVectorParameterBase.__PropertyOffset_ParamModes, 3, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.ParamModes.CopyAssign(value);
			}
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x000CB638 File Offset: 0x000C9838
		static UDistributionVectorParameterBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionVectorParameterBase");
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x000CB648 File Offset: 0x000C9848
		protected UDistributionVectorParameterBase() : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorParameterBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x000CB670 File Offset: 0x000C9870
		protected UDistributionVectorParameterBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004396 RID: 17302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionVectorParameterBase";

		// Token: 0x04004397 RID: 17303
		private static IntPtr _ClassPtr;

		// Token: 0x04004398 RID: 17304
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004399 RID: 17305
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400439A RID: 17306
		internal static int __PropertyOffset_MinInput;

		// Token: 0x0400439B RID: 17307
		internal static int __PropertyOffset_MaxInput;

		// Token: 0x0400439C RID: 17308
		internal static int __PropertyOffset_MinOutput;

		// Token: 0x0400439D RID: 17309
		internal static int __PropertyOffset_MaxOutput;

		// Token: 0x0400439E RID: 17310
		internal static int __PropertyOffset_ParamModes;

		// Token: 0x0400439F RID: 17311
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TFixedArray<TEnumAsByte<DistributionParamMode>> _ParamModes;
	}
}
