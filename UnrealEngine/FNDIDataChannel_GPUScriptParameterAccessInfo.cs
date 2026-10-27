using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200253C RID: 9532
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NDIDataChannel_GPUScriptParameterAccessInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNDIDataChannel_GPUScriptParameterAccessInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602361C RID: 144924 RVA: 0x00345315 File Offset: 0x00343515
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDIDataChannel_GPUScriptParameterAccessInfo._ScriptStructPtr != 0) ? FNDIDataChannel_GPUScriptParameterAccessInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDIDataChannel_GPUScriptParameterAccessInfo", ref FNDIDataChannel_GPUScriptParameterAccessInfo._ScriptStructPtr);
		}

		// Token: 0x17008800 RID: 34816
		// (get) Token: 0x0602361D RID: 144925 RVA: 0x0034533C File Offset: 0x0034353C
		// (set) Token: 0x0602361E RID: 144926 RVA: 0x0034537F File Offset: 0x0034357F
		public TArray<FNiagaraVariableBase> SortedParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariableBase> result;
				if ((result = this._SortedParameters) == null)
				{
					result = (this._SortedParameters = new TArray<FNiagaraVariableBase>(base.NativePtr + (IntPtr)FNDIDataChannel_GPUScriptParameterAccessInfo.__PropertyOffset_SortedParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SortedParameters.CopyAssign(value);
			}
		}

		// Token: 0x0602361F RID: 144927 RVA: 0x0034538D File Offset: 0x0034358D
		public FNDIDataChannel_GPUScriptParameterAccessInfo()
		{
		}

		// Token: 0x06023620 RID: 144928 RVA: 0x00345395 File Offset: 0x00343595
		public FNDIDataChannel_GPUScriptParameterAccessInfo(TArray<FNiagaraVariableBase> SortedParameters)
		{
			this.SortedParameters = SortedParameters;
		}

		// Token: 0x06023621 RID: 144929 RVA: 0x003453A4 File Offset: 0x003435A4
		protected override IntPtr GetUStructPtr()
		{
			return FNDIDataChannel_GPUScriptParameterAccessInfo.StaticStruct();
		}

		// Token: 0x06023622 RID: 144930 RVA: 0x003453B0 File Offset: 0x003435B0
		[NullableContext(2)]
		public FNDIDataChannel_GPUScriptParameterAccessInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023623 RID: 144931 RVA: 0x003453BA File Offset: 0x003435BA
		public FNDIDataChannel_GPUScriptParameterAccessInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023624 RID: 144932 RVA: 0x003453C5 File Offset: 0x003435C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDIDataChannel_GPUScriptParameterAccessInfo(Pointer, false, true);
		}

		// Token: 0x06023625 RID: 144933 RVA: 0x003453CF File Offset: 0x003435CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDIDataChannel_GPUScriptParameterAccessInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012FD8 RID: 77784
		public const string __ObjectPath = "/Script/Niagara.NDIDataChannel_GPUScriptParameterAccessInfo";

		// Token: 0x04012FD9 RID: 77785
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FDA RID: 77786
		internal static int __PropertyOffset_SortedParameters;

		// Token: 0x04012FDB RID: 77787
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariableBase> _SortedParameters;
	}
}
