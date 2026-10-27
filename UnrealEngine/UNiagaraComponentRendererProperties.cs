using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002546 RID: 9542
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraComponentRendererProperties")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UNiagaraComponentRendererProperties : UNiagaraRendererProperties, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023762 RID: 145250 RVA: 0x00346B4D File Offset: 0x00344D4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraComponentRendererProperties._ClassPtr;
		}

		// Token: 0x06023763 RID: 145251 RVA: 0x00346B5C File Offset: 0x00344D5C
		public UNiagaraComponentRendererProperties() : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponentRendererProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023764 RID: 145252 RVA: 0x00346B84 File Offset: 0x00344D84
		public UNiagaraComponentRendererProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponentRendererProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700882F RID: 34863
		// (get) Token: 0x06023765 RID: 145253 RVA: 0x00346BB7 File Offset: 0x00344DB7
		// (set) Token: 0x06023766 RID: 145254 RVA: 0x00346BCB File Offset: 0x00344DCB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USceneComponent> ComponentType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_ComponentType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_ComponentType) = value;
			}
		}

		// Token: 0x17008830 RID: 34864
		// (get) Token: 0x06023767 RID: 145255 RVA: 0x00346BE0 File Offset: 0x00344DE0
		// (set) Token: 0x06023768 RID: 145256 RVA: 0x00346BF0 File Offset: 0x00344DF0
		public unsafe uint ComponentCountLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_ComponentCountLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_ComponentCountLimit) = (int)value;
			}
		}

		// Token: 0x17008831 RID: 34865
		// (get) Token: 0x06023769 RID: 145257 RVA: 0x00346C04 File Offset: 0x00344E04
		// (set) Token: 0x0602376A RID: 145258 RVA: 0x00346C3D File Offset: 0x00344E3D
		public FNiagaraVariableAttributeBinding EnabledBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._EnabledBinding) == null)
				{
					result = (this._EnabledBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_EnabledBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_EnabledBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008832 RID: 34866
		// (get) Token: 0x0602376B RID: 145259 RVA: 0x00346C5E File Offset: 0x00344E5E
		// (set) Token: 0x0602376C RID: 145260 RVA: 0x00346C6E File Offset: 0x00344E6E
		public unsafe bool bAssignComponentsOnParticleID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_bAssignComponentsOnParticleID) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_bAssignComponentsOnParticleID) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008833 RID: 34867
		// (get) Token: 0x0602376D RID: 145261 RVA: 0x00346C7F File Offset: 0x00344E7F
		// (set) Token: 0x0602376E RID: 145262 RVA: 0x00346C8F File Offset: 0x00344E8F
		public unsafe bool bOnlyCreateComponentsOnParticleSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_bOnlyCreateComponentsOnParticleSpawn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_bOnlyCreateComponentsOnParticleSpawn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008834 RID: 34868
		// (get) Token: 0x0602376F RID: 145263 RVA: 0x00346CA0 File Offset: 0x00344EA0
		// (set) Token: 0x06023770 RID: 145264 RVA: 0x00346CB4 File Offset: 0x00344EB4
		[Nullable(2)]
		public unsafe USceneComponent TemplateComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraComponentRendererProperties.__PropertyOffset_TemplateComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraComponentRendererProperties.__PropertyOffset_TemplateComponent, value);
			}
		}

		// Token: 0x17008835 RID: 34869
		// (get) Token: 0x06023771 RID: 145265 RVA: 0x00346CCC File Offset: 0x00344ECC
		// (set) Token: 0x06023772 RID: 145266 RVA: 0x00346D05 File Offset: 0x00344F05
		public TArray<FNiagaraComponentPropertyBinding> PropertyBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraComponentPropertyBinding> result;
				if ((result = this._PropertyBindings) == null)
				{
					result = (this._PropertyBindings = new TArray<FNiagaraComponentPropertyBinding>(base.NativePtr + (IntPtr)UNiagaraComponentRendererProperties.__PropertyOffset_PropertyBindings, this));
				}
				return result;
			}
			set
			{
				this.PropertyBindings.CopyAssign(value);
			}
		}

		// Token: 0x06023773 RID: 145267 RVA: 0x00346D13 File Offset: 0x00344F13
		static UNiagaraComponentRendererProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraComponentRendererProperties");
		}

		// Token: 0x06023774 RID: 145268 RVA: 0x00346D21 File Offset: 0x00344F21
		protected UNiagaraComponentRendererProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013034 RID: 77876
		public new const string __ObjectPath = "/Script/Niagara.NiagaraComponentRendererProperties";

		// Token: 0x04013035 RID: 77877
		private static IntPtr _ClassPtr;

		// Token: 0x04013036 RID: 77878
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013037 RID: 77879
		internal static int __PropertyOffset_ComponentType;

		// Token: 0x04013038 RID: 77880
		internal static int __PropertyOffset_ComponentCountLimit;

		// Token: 0x04013039 RID: 77881
		internal static int __PropertyOffset_EnabledBinding;

		// Token: 0x0401303A RID: 77882
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _EnabledBinding;

		// Token: 0x0401303B RID: 77883
		internal static int __PropertyOffset_bAssignComponentsOnParticleID;

		// Token: 0x0401303C RID: 77884
		internal static int __PropertyOffset_bOnlyCreateComponentsOnParticleSpawn;

		// Token: 0x0401303D RID: 77885
		internal static int __PropertyOffset_TemplateComponent;

		// Token: 0x0401303E RID: 77886
		internal static int __PropertyOffset_PropertyBindings;

		// Token: 0x0401303F RID: 77887
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraComponentPropertyBinding> _PropertyBindings;
	}
}
