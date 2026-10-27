using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025C0 RID: 9664
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameterCollectionInstance")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UNiagaraParameterCollectionInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023EC9 RID: 147145 RVA: 0x00352155 File Offset: 0x00350355
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraParameterCollectionInstance._ClassPtr;
		}

		// Token: 0x06023ECA RID: 147146 RVA: 0x00352164 File Offset: 0x00350364
		public UNiagaraParameterCollectionInstance() : this(BuiltinUtils.AllocNativeUObject(UNiagaraParameterCollectionInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023ECB RID: 147147 RVA: 0x0035218C File Offset: 0x0035038C
		public UNiagaraParameterCollectionInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraParameterCollectionInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A31 RID: 35377
		// (get) Token: 0x06023ECC RID: 147148 RVA: 0x003521BF File Offset: 0x003503BF
		// (set) Token: 0x06023ECD RID: 147149 RVA: 0x003521D3 File Offset: 0x003503D3
		[Nullable(2)]
		public unsafe UNiagaraParameterCollection Collection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraParameterCollectionInstance.__PropertyOffset_Collection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraParameterCollectionInstance.__PropertyOffset_Collection, value);
			}
		}

		// Token: 0x17008A32 RID: 35378
		// (get) Token: 0x06023ECE RID: 147150 RVA: 0x003521E8 File Offset: 0x003503E8
		// (set) Token: 0x06023ECF RID: 147151 RVA: 0x00352221 File Offset: 0x00350421
		public TArray<FNiagaraVariable> OverridenParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._OverridenParameters) == null)
				{
					result = (this._OverridenParameters = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)UNiagaraParameterCollectionInstance.__PropertyOffset_OverridenParameters, this));
				}
				return result;
			}
			set
			{
				this.OverridenParameters.CopyAssign(value);
			}
		}

		// Token: 0x17008A33 RID: 35379
		// (get) Token: 0x06023ED0 RID: 147152 RVA: 0x00352230 File Offset: 0x00350430
		// (set) Token: 0x06023ED1 RID: 147153 RVA: 0x00352269 File Offset: 0x00350469
		public FNiagaraParameterStore ParameterStorage
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterStore result;
				if ((result = this._ParameterStorage) == null)
				{
					result = (this._ParameterStorage = new FNiagaraParameterStore(base.NativePtr + (IntPtr)UNiagaraParameterCollectionInstance.__PropertyOffset_ParameterStorage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterStore.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraParameterCollectionInstance.__PropertyOffset_ParameterStorage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023ED2 RID: 147154 RVA: 0x0035228C File Offset: 0x0035048C
		public unsafe void SetVectorParameter(string InVariableName, FVector InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraParameterCollectionInstance.__SetVectorParameter_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023ED3 RID: 147155 RVA: 0x003522B8 File Offset: 0x003504B8
		public unsafe void SetVector4Parameter(string InVariableName, in FVector4 InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraParameterCollectionInstance.__SetVector4Parameter_Internal(base.NativePtr, fstring, ptr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023ED4 RID: 147156 RVA: 0x00352300 File Offset: 0x00350500
		public unsafe void SetVector2DParameter(string InVariableName, FVector2D InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraParameterCollectionInstance.__SetVector2DParameter_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023ED5 RID: 147157 RVA: 0x0035232C File Offset: 0x0035052C
		public unsafe void SetQuatParameter(string InVariableName, in FQuat InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UNiagaraParameterCollectionInstance.__SetQuatParameter_Internal(base.NativePtr, fstring, ptr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023ED6 RID: 147158 RVA: 0x00352374 File Offset: 0x00350574
		public unsafe void SetIntParameter(string InVariableName, int InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraParameterCollectionInstance.__SetIntParameter_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023ED7 RID: 147159 RVA: 0x003523A0 File Offset: 0x003505A0
		public unsafe void SetFloatParameter(string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraParameterCollectionInstance.__SetFloatParameter_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023ED8 RID: 147160 RVA: 0x003523CC File Offset: 0x003505CC
		public unsafe void SetColorParameter(string InVariableName, FLinearColor InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraParameterCollectionInstance.__SetColorParameter_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023ED9 RID: 147161 RVA: 0x003523F8 File Offset: 0x003505F8
		public unsafe void SetBoolParameter(string InVariableName, bool InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UNiagaraParameterCollectionInstance.__SetBoolParameter_Internal(base.NativePtr, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06023EDA RID: 147162 RVA: 0x00352424 File Offset: 0x00350624
		public unsafe FVector GetVectorParameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			FVector result = UNiagaraParameterCollectionInstance.__GetVectorParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EDB RID: 147163 RVA: 0x00352450 File Offset: 0x00350650
		public unsafe FVector4 GetVector4Parameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			FVector4 result = UNiagaraParameterCollectionInstance.__GetVector4Parameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EDC RID: 147164 RVA: 0x0035247C File Offset: 0x0035067C
		public unsafe FVector2D GetVector2DParameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			FVector2D result = UNiagaraParameterCollectionInstance.__GetVector2DParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EDD RID: 147165 RVA: 0x003524A8 File Offset: 0x003506A8
		public unsafe FQuat GetQuatParameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			FQuat result = UNiagaraParameterCollectionInstance.__GetQuatParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EDE RID: 147166 RVA: 0x003524D4 File Offset: 0x003506D4
		public unsafe int GetIntParameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			int result = UNiagaraParameterCollectionInstance.__GetIntParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EDF RID: 147167 RVA: 0x00352500 File Offset: 0x00350700
		public unsafe float GetFloatParameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			float result = UNiagaraParameterCollectionInstance.__GetFloatParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EE0 RID: 147168 RVA: 0x0035252C File Offset: 0x0035072C
		public unsafe FLinearColor GetColorParameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			FLinearColor result = UNiagaraParameterCollectionInstance.__GetColorParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EE1 RID: 147169 RVA: 0x00352558 File Offset: 0x00350758
		public unsafe bool GetBoolParameter(string InVariableName)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			bool result = UNiagaraParameterCollectionInstance.__GetBoolParameter_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023EE2 RID: 147170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameter_Internal(IntPtr @this, in FString InVariableName, FVector InValue);

		// Token: 0x06023EE3 RID: 147171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVector4Parameter_Internal(IntPtr @this, in FString InVariableName, in FVector4 InValue);

		// Token: 0x06023EE4 RID: 147172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVector2DParameter_Internal(IntPtr @this, in FString InVariableName, FVector2D InValue);

		// Token: 0x06023EE5 RID: 147173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetQuatParameter_Internal(IntPtr @this, in FString InVariableName, in FQuat InValue);

		// Token: 0x06023EE6 RID: 147174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntParameter_Internal(IntPtr @this, in FString InVariableName, int InValue);

		// Token: 0x06023EE7 RID: 147175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatParameter_Internal(IntPtr @this, in FString InVariableName, float InValue);

		// Token: 0x06023EE8 RID: 147176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorParameter_Internal(IntPtr @this, in FString InVariableName, FLinearColor InValue);

		// Token: 0x06023EE9 RID: 147177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoolParameter_Internal(IntPtr @this, in FString InVariableName, bool InValue);

		// Token: 0x06023EEA RID: 147178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorParameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EEB RID: 147179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __GetVector4Parameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EEC RID: 147180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetVector2DParameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EED RID: 147181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetQuatParameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EEE RID: 147182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIntParameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EEF RID: 147183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatParameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EF0 RID: 147184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetColorParameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EF1 RID: 147185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBoolParameter_Internal(IntPtr @this, in FString InVariableName);

		// Token: 0x06023EF2 RID: 147186 RVA: 0x00352582 File Offset: 0x00350782
		static UNiagaraParameterCollectionInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraParameterCollectionInstance");
		}

		// Token: 0x06023EF3 RID: 147187 RVA: 0x00352590 File Offset: 0x00350790
		protected UNiagaraParameterCollectionInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401343E RID: 78910
		public new const string __ObjectPath = "/Script/Niagara.NiagaraParameterCollectionInstance";

		// Token: 0x0401343F RID: 78911
		private static IntPtr _ClassPtr;

		// Token: 0x04013440 RID: 78912
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013441 RID: 78913
		internal static int __PropertyOffset_Collection;

		// Token: 0x04013442 RID: 78914
		internal static int __PropertyOffset_OverridenParameters;

		// Token: 0x04013443 RID: 78915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _OverridenParameters;

		// Token: 0x04013444 RID: 78916
		internal static int __PropertyOffset_ParameterStorage;

		// Token: 0x04013445 RID: 78917
		[Nullable(2)]
		private FNiagaraParameterStore _ParameterStorage;
	}
}
