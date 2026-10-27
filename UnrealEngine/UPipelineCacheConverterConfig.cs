using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FEC RID: 4076
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PipelineCacheConverterConfig")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UPipelineCacheConverterConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DCBB RID: 56507 RVA: 0x00144F1D File Offset: 0x0014311D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPipelineCacheConverterConfig._ClassPtr;
		}

		// Token: 0x0600DCBC RID: 56508 RVA: 0x00144F2C File Offset: 0x0014312C
		public UPipelineCacheConverterConfig() : this(BuiltinUtils.AllocNativeUObject(UPipelineCacheConverterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DCBD RID: 56509 RVA: 0x00144F54 File Offset: 0x00143154
		public UPipelineCacheConverterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPipelineCacheConverterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600DCBE RID: 56510 RVA: 0x00144F88 File Offset: 0x00143188
		// (set) Token: 0x0600DCBF RID: 56511 RVA: 0x00144FC1 File Offset: 0x001431C1
		public TArray<FPSOConverterConfigShader> ShaderTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOConverterConfigShader> result;
				if ((result = this._ShaderTemplates) == null)
				{
					result = (this._ShaderTemplates = new TArray<FPSOConverterConfigShader>(base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_ShaderTemplates, this));
				}
				return result;
			}
			set
			{
				this.ShaderTemplates.CopyAssign(value);
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600DCC0 RID: 56512 RVA: 0x00144FD0 File Offset: 0x001431D0
		// (set) Token: 0x0600DCC1 RID: 56513 RVA: 0x00145009 File Offset: 0x00143209
		public TArray<FPSOConverterConfigVariable> VariablesValueOverride
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOConverterConfigVariable> result;
				if ((result = this._VariablesValueOverride) == null)
				{
					result = (this._VariablesValueOverride = new TArray<FPSOConverterConfigVariable>(base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_VariablesValueOverride, this));
				}
				return result;
			}
			set
			{
				this.VariablesValueOverride.CopyAssign(value);
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600DCC2 RID: 56514 RVA: 0x00145018 File Offset: 0x00143218
		// (set) Token: 0x0600DCC3 RID: 56515 RVA: 0x00145051 File Offset: 0x00143251
		public TArray<FPSOConverterConfigFilter> Filters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOConverterConfigFilter> result;
				if ((result = this._Filters) == null)
				{
					result = (this._Filters = new TArray<FPSOConverterConfigFilter>(base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_Filters, this));
				}
				return result;
			}
			set
			{
				this.Filters.CopyAssign(value);
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x00145060 File Offset: 0x00143260
		// (set) Token: 0x0600DCC5 RID: 56517 RVA: 0x00145099 File Offset: 0x00143299
		public FPSOGeneratorConfigUsageMask UsageMask
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigUsageMask result;
				if ((result = this._UsageMask) == null)
				{
					result = (this._UsageMask = new FPSOGeneratorConfigUsageMask(base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_UsageMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigUsageMask.StaticStruct(), base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_UsageMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x001450BC File Offset: 0x001432BC
		// (set) Token: 0x0600DCC7 RID: 56519 RVA: 0x001450F5 File Offset: 0x001432F5
		public TMap<string, string> AdditionalBaseMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._AdditionalBaseMaterialMap) == null)
				{
					result = (this._AdditionalBaseMaterialMap = new TMap<string, string>(base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_AdditionalBaseMaterialMap, this));
				}
				return result;
			}
			set
			{
				this.AdditionalBaseMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600DCC8 RID: 56520 RVA: 0x00145103 File Offset: 0x00143303
		// (set) Token: 0x0600DCC9 RID: 56521 RVA: 0x00145113 File Offset: 0x00143313
		public unsafe bool bStripPipelineStates
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_bStripPipelineStates) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPipelineCacheConverterConfig.__PropertyOffset_bStripPipelineStates) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600DCCA RID: 56522 RVA: 0x00145124 File Offset: 0x00143324
		static UPipelineCacheConverterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PipelineCacheConverterConfig");
		}

		// Token: 0x0600DCCB RID: 56523 RVA: 0x00145132 File Offset: 0x00143332
		protected UPipelineCacheConverterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007741 RID: 30529
		public new const string __ObjectPath = "/Script/Engine.PipelineCacheConverterConfig";

		// Token: 0x04007742 RID: 30530
		private static IntPtr _ClassPtr;

		// Token: 0x04007743 RID: 30531
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007744 RID: 30532
		internal static int __PropertyOffset_ShaderTemplates;

		// Token: 0x04007745 RID: 30533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSOConverterConfigShader> _ShaderTemplates;

		// Token: 0x04007746 RID: 30534
		internal static int __PropertyOffset_VariablesValueOverride;

		// Token: 0x04007747 RID: 30535
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSOConverterConfigVariable> _VariablesValueOverride;

		// Token: 0x04007748 RID: 30536
		internal static int __PropertyOffset_Filters;

		// Token: 0x04007749 RID: 30537
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSOConverterConfigFilter> _Filters;

		// Token: 0x0400774A RID: 30538
		internal static int __PropertyOffset_UsageMask;

		// Token: 0x0400774B RID: 30539
		[Nullable(2)]
		private FPSOGeneratorConfigUsageMask _UsageMask;

		// Token: 0x0400774C RID: 30540
		internal static int __PropertyOffset_AdditionalBaseMaterialMap;

		// Token: 0x0400774D RID: 30541
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _AdditionalBaseMaterialMap;

		// Token: 0x0400774E RID: 30542
		internal static int __PropertyOffset_bStripPipelineStates;
	}
}
