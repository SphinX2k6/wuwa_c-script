using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025BF RID: 9663
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameterCollection")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraParameterCollection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023EBA RID: 147130 RVA: 0x00351FE9 File Offset: 0x003501E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraParameterCollection._ClassPtr;
		}

		// Token: 0x06023EBB RID: 147131 RVA: 0x00351FF8 File Offset: 0x003501F8
		public UNiagaraParameterCollection() : this(BuiltinUtils.AllocNativeUObject(UNiagaraParameterCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023EBC RID: 147132 RVA: 0x00352020 File Offset: 0x00350220
		[NullableContext(1)]
		public UNiagaraParameterCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraParameterCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A2C RID: 35372
		// (get) Token: 0x06023EBD RID: 147133 RVA: 0x00352053 File Offset: 0x00350253
		// (set) Token: 0x06023EBE RID: 147134 RVA: 0x00352067 File Offset: 0x00350267
		public unsafe FName Namespace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraParameterCollection.__PropertyOffset_Namespace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraParameterCollection.__PropertyOffset_Namespace) = value;
			}
		}

		// Token: 0x17008A2D RID: 35373
		// (get) Token: 0x06023EBF RID: 147135 RVA: 0x0035207C File Offset: 0x0035027C
		// (set) Token: 0x06023EC0 RID: 147136 RVA: 0x003520B5 File Offset: 0x003502B5
		[Nullable(1)]
		public TArray<FNiagaraVariable> Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)UNiagaraParameterCollection.__PropertyOffset_Parameters, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17008A2E RID: 35374
		// (get) Token: 0x06023EC1 RID: 147137 RVA: 0x003520C3 File Offset: 0x003502C3
		// (set) Token: 0x06023EC2 RID: 147138 RVA: 0x003520D7 File Offset: 0x003502D7
		public unsafe UMaterialParameterCollection SourceMaterialCollection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraParameterCollection.__PropertyOffset_SourceMaterialCollection);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraParameterCollection.__PropertyOffset_SourceMaterialCollection, value);
			}
		}

		// Token: 0x17008A2F RID: 35375
		// (get) Token: 0x06023EC3 RID: 147139 RVA: 0x003520EC File Offset: 0x003502EC
		// (set) Token: 0x06023EC4 RID: 147140 RVA: 0x00352100 File Offset: 0x00350300
		public unsafe UNiagaraParameterCollectionInstance DefaultInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraParameterCollectionInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraParameterCollection.__PropertyOffset_DefaultInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraParameterCollection.__PropertyOffset_DefaultInstance, value);
			}
		}

		// Token: 0x17008A30 RID: 35376
		// (get) Token: 0x06023EC5 RID: 147141 RVA: 0x00352115 File Offset: 0x00350315
		// (set) Token: 0x06023EC6 RID: 147142 RVA: 0x00352129 File Offset: 0x00350329
		public unsafe FGuid CompileId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraParameterCollection.__PropertyOffset_CompileId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraParameterCollection.__PropertyOffset_CompileId) = value;
			}
		}

		// Token: 0x06023EC7 RID: 147143 RVA: 0x0035213E File Offset: 0x0035033E
		static UNiagaraParameterCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraParameterCollection");
		}

		// Token: 0x06023EC8 RID: 147144 RVA: 0x0035214C File Offset: 0x0035034C
		protected UNiagaraParameterCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013435 RID: 78901
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraParameterCollection";

		// Token: 0x04013436 RID: 78902
		private static IntPtr _ClassPtr;

		// Token: 0x04013437 RID: 78903
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013438 RID: 78904
		internal static int __PropertyOffset_Namespace;

		// Token: 0x04013439 RID: 78905
		internal static int __PropertyOffset_Parameters;

		// Token: 0x0401343A RID: 78906
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _Parameters;

		// Token: 0x0401343B RID: 78907
		internal static int __PropertyOffset_SourceMaterialCollection;

		// Token: 0x0401343C RID: 78908
		internal static int __PropertyOffset_DefaultInstance;

		// Token: 0x0401343D RID: 78909
		internal static int __PropertyOffset_CompileId;
	}
}
