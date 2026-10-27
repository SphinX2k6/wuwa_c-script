using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B7F RID: 7039
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationConfig")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroNpcExtraDecorationConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AB62 RID: 109410 RVA: 0x00275BFA File Offset: 0x00273DFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNpcExtraDecorationConfig._ClassPtr;
		}

		// Token: 0x0601AB63 RID: 109411 RVA: 0x00275C08 File Offset: 0x00273E08
		public UKuroNpcExtraDecorationConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroNpcExtraDecorationConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AB64 RID: 109412 RVA: 0x00275C30 File Offset: 0x00273E30
		public UKuroNpcExtraDecorationConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNpcExtraDecorationConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B6F RID: 27503
		// (get) Token: 0x0601AB65 RID: 109413 RVA: 0x00275C64 File Offset: 0x00273E64
		// (set) Token: 0x0601AB66 RID: 109414 RVA: 0x00275C9D File Offset: 0x00273E9D
		public TArray<FKuroNpcExtraDecoration> Decorations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroNpcExtraDecoration> result;
				if ((result = this._Decorations) == null)
				{
					result = (this._Decorations = new TArray<FKuroNpcExtraDecoration>(base.NativePtr + (IntPtr)UKuroNpcExtraDecorationConfig.__PropertyOffset_Decorations, this));
				}
				return result;
			}
			set
			{
				this.Decorations.CopyAssign(value);
			}
		}

		// Token: 0x17006B70 RID: 27504
		// (get) Token: 0x0601AB67 RID: 109415 RVA: 0x00275CAB File Offset: 0x00273EAB
		// (set) Token: 0x0601AB68 RID: 109416 RVA: 0x00275CBB File Offset: 0x00273EBB
		public unsafe bool NeedHairEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNpcExtraDecorationConfig.__PropertyOffset_NeedHairEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNpcExtraDecorationConfig.__PropertyOffset_NeedHairEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B71 RID: 27505
		// (get) Token: 0x0601AB69 RID: 109417 RVA: 0x00275CCC File Offset: 0x00273ECC
		// (set) Token: 0x0601AB6A RID: 109418 RVA: 0x00275D05 File Offset: 0x00273F05
		public TArray<FKuroNpcBodyMaterialParameter> MaterialParametersOnBody
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroNpcBodyMaterialParameter> result;
				if ((result = this._MaterialParametersOnBody) == null)
				{
					result = (this._MaterialParametersOnBody = new TArray<FKuroNpcBodyMaterialParameter>(base.NativePtr + (IntPtr)UKuroNpcExtraDecorationConfig.__PropertyOffset_MaterialParametersOnBody, this));
				}
				return result;
			}
			set
			{
				this.MaterialParametersOnBody.CopyAssign(value);
			}
		}

		// Token: 0x0601AB6B RID: 109419 RVA: 0x00275D13 File Offset: 0x00273F13
		static UKuroNpcExtraDecorationConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationConfig");
		}

		// Token: 0x0601AB6C RID: 109420 RVA: 0x00275D21 File Offset: 0x00273F21
		protected UKuroNpcExtraDecorationConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E735 RID: 59189
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationConfig";

		// Token: 0x0400E736 RID: 59190
		private static IntPtr _ClassPtr;

		// Token: 0x0400E737 RID: 59191
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E738 RID: 59192
		internal static int __PropertyOffset_Decorations;

		// Token: 0x0400E739 RID: 59193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroNpcExtraDecoration> _Decorations;

		// Token: 0x0400E73A RID: 59194
		internal static int __PropertyOffset_NeedHairEffect;

		// Token: 0x0400E73B RID: 59195
		internal static int __PropertyOffset_MaterialParametersOnBody;

		// Token: 0x0400E73C RID: 59196
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroNpcBodyMaterialParameter> _MaterialParametersOnBody;
	}
}
