using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025C6 RID: 9670
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameterStore")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FNiagaraParameterStore : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023F22 RID: 147234 RVA: 0x00352970 File Offset: 0x00350B70
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraParameterStore._ScriptStructPtr != 0) ? FNiagaraParameterStore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraParameterStore", ref FNiagaraParameterStore._ScriptStructPtr);
		}

		// Token: 0x17008A39 RID: 35385
		// (get) Token: 0x06023F23 RID: 147235 RVA: 0x00352994 File Offset: 0x00350B94
		// (set) Token: 0x06023F24 RID: 147236 RVA: 0x003529A8 File Offset: 0x00350BA8
		[Nullable(2)]
		public unsafe UObject Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraParameterStore.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraParameterStore.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x17008A3A RID: 35386
		// (get) Token: 0x06023F25 RID: 147237 RVA: 0x003529C0 File Offset: 0x00350BC0
		// (set) Token: 0x06023F26 RID: 147238 RVA: 0x00352A03 File Offset: 0x00350C03
		public TArray<FNiagaraVariableWithOffset> SortedParameterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariableWithOffset> result;
				if ((result = this._SortedParameterOffsets) == null)
				{
					result = (this._SortedParameterOffsets = new TArray<FNiagaraVariableWithOffset>(base.NativePtr + (IntPtr)FNiagaraParameterStore.__PropertyOffset_SortedParameterOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SortedParameterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008A3B RID: 35387
		// (get) Token: 0x06023F27 RID: 147239 RVA: 0x00352A14 File Offset: 0x00350C14
		// (set) Token: 0x06023F28 RID: 147240 RVA: 0x00352A57 File Offset: 0x00350C57
		public TArray<byte> ParameterData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ParameterData) == null)
				{
					result = (this._ParameterData = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraParameterStore.__PropertyOffset_ParameterData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParameterData.CopyAssign(value);
			}
		}

		// Token: 0x17008A3C RID: 35388
		// (get) Token: 0x06023F29 RID: 147241 RVA: 0x00352A68 File Offset: 0x00350C68
		// (set) Token: 0x06023F2A RID: 147242 RVA: 0x00352AAB File Offset: 0x00350CAB
		public TArray<UNiagaraDataInterface> DataInterfaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraDataInterface> result;
				if ((result = this._DataInterfaces) == null)
				{
					result = (this._DataInterfaces = new TArray<UNiagaraDataInterface>(base.NativePtr + (IntPtr)FNiagaraParameterStore.__PropertyOffset_DataInterfaces, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataInterfaces.CopyAssign(value);
			}
		}

		// Token: 0x17008A3D RID: 35389
		// (get) Token: 0x06023F2B RID: 147243 RVA: 0x00352ABC File Offset: 0x00350CBC
		// (set) Token: 0x06023F2C RID: 147244 RVA: 0x00352AFF File Offset: 0x00350CFF
		public TArray<UObject> UObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._UObjects) == null)
				{
					result = (this._UObjects = new TArray<UObject>(base.NativePtr + (IntPtr)FNiagaraParameterStore.__PropertyOffset_UObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UObjects.CopyAssign(value);
			}
		}

		// Token: 0x06023F2D RID: 147245 RVA: 0x00352B0D File Offset: 0x00350D0D
		public FNiagaraParameterStore()
		{
		}

		// Token: 0x06023F2E RID: 147246 RVA: 0x00352B15 File Offset: 0x00350D15
		public FNiagaraParameterStore(UObject Owner, TMap<FNiagaraVariable, int> ParameterOffsets, TArray<FNiagaraVariableWithOffset> SortedParameterOffsets, TArray<byte> ParameterData, TArray<UNiagaraDataInterface> DataInterfaces, TArray<UObject> UObjects, string DebugName)
		{
			this.Owner = Owner;
			this.SortedParameterOffsets = SortedParameterOffsets;
			this.ParameterData = ParameterData;
			this.DataInterfaces = DataInterfaces;
			this.UObjects = UObjects;
		}

		// Token: 0x06023F2F RID: 147247 RVA: 0x00352B43 File Offset: 0x00350D43
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraParameterStore.StaticStruct();
		}

		// Token: 0x06023F30 RID: 147248 RVA: 0x00352B4F File Offset: 0x00350D4F
		[NullableContext(2)]
		public FNiagaraParameterStore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F31 RID: 147249 RVA: 0x00352B59 File Offset: 0x00350D59
		public FNiagaraParameterStore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F32 RID: 147250 RVA: 0x00352B64 File Offset: 0x00350D64
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraParameterStore(Pointer, false, true);
		}

		// Token: 0x06023F33 RID: 147251 RVA: 0x00352B6E File Offset: 0x00350D6E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraParameterStore(Pointer, MemoryOwner);
		}

		// Token: 0x0401345A RID: 78938
		public const string __ObjectPath = "/Script/Niagara.NiagaraParameterStore";

		// Token: 0x0401345B RID: 78939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401345C RID: 78940
		internal static int __PropertyOffset_Owner;

		// Token: 0x0401345D RID: 78941
		internal static int __PropertyOffset_SortedParameterOffsets;

		// Token: 0x0401345E RID: 78942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariableWithOffset> _SortedParameterOffsets;

		// Token: 0x0401345F RID: 78943
		internal static int __PropertyOffset_ParameterData;

		// Token: 0x04013460 RID: 78944
		[Nullable(2)]
		private TArray<byte> _ParameterData;

		// Token: 0x04013461 RID: 78945
		internal static int __PropertyOffset_DataInterfaces;

		// Token: 0x04013462 RID: 78946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraDataInterface> _DataInterfaces;

		// Token: 0x04013463 RID: 78947
		internal static int __PropertyOffset_UObjects;

		// Token: 0x04013464 RID: 78948
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _UObjects;
	}
}
