using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200253B RID: 9531
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NDIDataChannelWriteCompiledData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FNDIDataChannelWriteCompiledData : FNDIDataChannelCompiledData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023612 RID: 144914 RVA: 0x0034521A File Offset: 0x0034341A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDIDataChannelWriteCompiledData._ScriptStructPtr != 0) ? FNDIDataChannelWriteCompiledData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDIDataChannelWriteCompiledData", ref FNDIDataChannelWriteCompiledData._ScriptStructPtr);
		}

		// Token: 0x170087FF RID: 34815
		// (get) Token: 0x06023613 RID: 144915 RVA: 0x00345240 File Offset: 0x00343440
		// (set) Token: 0x06023614 RID: 144916 RVA: 0x00345283 File Offset: 0x00343483
		public FNiagaraDataSetCompiledData DataLayout
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._DataLayout) == null)
				{
					result = (this._DataLayout = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)FNDIDataChannelWriteCompiledData.__PropertyOffset_DataLayout, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)FNDIDataChannelWriteCompiledData.__PropertyOffset_DataLayout, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023615 RID: 144917 RVA: 0x003452A4 File Offset: 0x003434A4
		public FNDIDataChannelWriteCompiledData()
		{
		}

		// Token: 0x06023616 RID: 144918 RVA: 0x003452AC File Offset: 0x003434AC
		public FNDIDataChannelWriteCompiledData(FNiagaraDataSetCompiledData DataLayout, TArray<FNDIDataChannelFunctionInfo> FunctionInfo, uint TotalParams, bool bUsedByCPU, bool bUsedByGPU, bool bNeedsSpawnDataTable)
		{
			this.DataLayout = DataLayout;
			base.FunctionInfo = FunctionInfo;
			base.TotalParams = TotalParams;
			base.bUsedByCPU = bUsedByCPU;
			base.bUsedByGPU = bUsedByGPU;
			base.bNeedsSpawnDataTable = bNeedsSpawnDataTable;
		}

		// Token: 0x06023617 RID: 144919 RVA: 0x003452E1 File Offset: 0x003434E1
		protected override IntPtr GetUStructPtr()
		{
			return FNDIDataChannelWriteCompiledData.StaticStruct();
		}

		// Token: 0x06023618 RID: 144920 RVA: 0x003452ED File Offset: 0x003434ED
		[NullableContext(2)]
		public FNDIDataChannelWriteCompiledData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023619 RID: 144921 RVA: 0x003452F7 File Offset: 0x003434F7
		public FNDIDataChannelWriteCompiledData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602361A RID: 144922 RVA: 0x00345302 File Offset: 0x00343502
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDIDataChannelWriteCompiledData(Pointer, false, true);
		}

		// Token: 0x0602361B RID: 144923 RVA: 0x0034530C File Offset: 0x0034350C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDIDataChannelWriteCompiledData(Pointer, MemoryOwner);
		}

		// Token: 0x04012FD4 RID: 77780
		public new const string __ObjectPath = "/Script/Niagara.NDIDataChannelWriteCompiledData";

		// Token: 0x04012FD5 RID: 77781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FD6 RID: 77782
		internal static int __PropertyOffset_DataLayout;

		// Token: 0x04012FD7 RID: 77783
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _DataLayout;
	}
}
