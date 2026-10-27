using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025C2 RID: 9666
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraParameterDataSetBindingCollection")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNiagaraParameterDataSetBindingCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023EFB RID: 147195 RVA: 0x00352640 File Offset: 0x00350840
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraParameterDataSetBindingCollection._ScriptStructPtr != 0) ? FNiagaraParameterDataSetBindingCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraParameterDataSetBindingCollection", ref FNiagaraParameterDataSetBindingCollection._ScriptStructPtr);
		}

		// Token: 0x17008A34 RID: 35380
		// (get) Token: 0x06023EFC RID: 147196 RVA: 0x00352664 File Offset: 0x00350864
		// (set) Token: 0x06023EFD RID: 147197 RVA: 0x003526A7 File Offset: 0x003508A7
		public TArray<FNiagaraParameterDataSetBinding> FloatOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraParameterDataSetBinding> result;
				if ((result = this._FloatOffsets) == null)
				{
					result = (this._FloatOffsets = new TArray<FNiagaraParameterDataSetBinding>(base.NativePtr + (IntPtr)FNiagaraParameterDataSetBindingCollection.__PropertyOffset_FloatOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17008A35 RID: 35381
		// (get) Token: 0x06023EFE RID: 147198 RVA: 0x003526B8 File Offset: 0x003508B8
		// (set) Token: 0x06023EFF RID: 147199 RVA: 0x003526FB File Offset: 0x003508FB
		public TArray<FNiagaraParameterDataSetBinding> Int32Offsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraParameterDataSetBinding> result;
				if ((result = this._Int32Offsets) == null)
				{
					result = (this._Int32Offsets = new TArray<FNiagaraParameterDataSetBinding>(base.NativePtr + (IntPtr)FNiagaraParameterDataSetBindingCollection.__PropertyOffset_Int32Offsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32Offsets.CopyAssign(value);
			}
		}

		// Token: 0x06023F00 RID: 147200 RVA: 0x00352709 File Offset: 0x00350909
		public FNiagaraParameterDataSetBindingCollection()
		{
		}

		// Token: 0x06023F01 RID: 147201 RVA: 0x00352711 File Offset: 0x00350911
		public FNiagaraParameterDataSetBindingCollection(TArray<FNiagaraParameterDataSetBinding> FloatOffsets, TArray<FNiagaraParameterDataSetBinding> Int32Offsets)
		{
			this.FloatOffsets = FloatOffsets;
			this.Int32Offsets = Int32Offsets;
		}

		// Token: 0x06023F02 RID: 147202 RVA: 0x00352727 File Offset: 0x00350927
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraParameterDataSetBindingCollection.StaticStruct();
		}

		// Token: 0x06023F03 RID: 147203 RVA: 0x00352733 File Offset: 0x00350933
		[NullableContext(2)]
		public FNiagaraParameterDataSetBindingCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F04 RID: 147204 RVA: 0x0035273D File Offset: 0x0035093D
		public FNiagaraParameterDataSetBindingCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F05 RID: 147205 RVA: 0x00352748 File Offset: 0x00350948
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraParameterDataSetBindingCollection(Pointer, false, true);
		}

		// Token: 0x06023F06 RID: 147206 RVA: 0x00352752 File Offset: 0x00350952
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraParameterDataSetBindingCollection(Pointer, MemoryOwner);
		}

		// Token: 0x0401344A RID: 78922
		public const string __ObjectPath = "/Script/Niagara.NiagaraParameterDataSetBindingCollection";

		// Token: 0x0401344B RID: 78923
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401344C RID: 78924
		internal static int __PropertyOffset_FloatOffsets;

		// Token: 0x0401344D RID: 78925
		[Nullable(2)]
		private TArray<FNiagaraParameterDataSetBinding> _FloatOffsets;

		// Token: 0x0401344E RID: 78926
		internal static int __PropertyOffset_Int32Offsets;

		// Token: 0x0401344F RID: 78927
		[Nullable(2)]
		private TArray<FNiagaraParameterDataSetBinding> _Int32Offsets;
	}
}
