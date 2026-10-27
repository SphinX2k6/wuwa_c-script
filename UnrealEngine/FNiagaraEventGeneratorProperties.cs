using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025A4 RID: 9636
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEventGeneratorProperties")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FNiagaraEventGeneratorProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023CA9 RID: 146601 RVA: 0x0034EE76 File Offset: 0x0034D076
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEventGeneratorProperties._ScriptStructPtr != 0) ? FNiagaraEventGeneratorProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEventGeneratorProperties", ref FNiagaraEventGeneratorProperties._ScriptStructPtr);
		}

		// Token: 0x17008991 RID: 35217
		// (get) Token: 0x06023CAA RID: 146602 RVA: 0x0034EE9A File Offset: 0x0034D09A
		// (set) Token: 0x06023CAB RID: 146603 RVA: 0x0034EEAA File Offset: 0x0034D0AA
		public unsafe int MaxEventsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventGeneratorProperties.__PropertyOffset_MaxEventsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventGeneratorProperties.__PropertyOffset_MaxEventsPerFrame) = value;
			}
		}

		// Token: 0x17008992 RID: 35218
		// (get) Token: 0x06023CAC RID: 146604 RVA: 0x0034EEBB File Offset: 0x0034D0BB
		// (set) Token: 0x06023CAD RID: 146605 RVA: 0x0034EECF File Offset: 0x0034D0CF
		public unsafe FName ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEventGeneratorProperties.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEventGeneratorProperties.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x17008993 RID: 35219
		// (get) Token: 0x06023CAE RID: 146606 RVA: 0x0034EEE4 File Offset: 0x0034D0E4
		// (set) Token: 0x06023CAF RID: 146607 RVA: 0x0034EF27 File Offset: 0x0034D127
		public FNiagaraDataSetCompiledData DataSetCompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._DataSetCompiledData) == null)
				{
					result = (this._DataSetCompiledData = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)FNiagaraEventGeneratorProperties.__PropertyOffset_DataSetCompiledData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEventGeneratorProperties.__PropertyOffset_DataSetCompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023CB0 RID: 146608 RVA: 0x0034EF48 File Offset: 0x0034D148
		public FNiagaraEventGeneratorProperties()
		{
		}

		// Token: 0x06023CB1 RID: 146609 RVA: 0x0034EF50 File Offset: 0x0034D150
		public FNiagaraEventGeneratorProperties(int MaxEventsPerFrame, FName ID, FNiagaraDataSetCompiledData DataSetCompiledData)
		{
			this.MaxEventsPerFrame = MaxEventsPerFrame;
			this.ID = ID;
			this.DataSetCompiledData = DataSetCompiledData;
		}

		// Token: 0x06023CB2 RID: 146610 RVA: 0x0034EF6D File Offset: 0x0034D16D
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEventGeneratorProperties.StaticStruct();
		}

		// Token: 0x06023CB3 RID: 146611 RVA: 0x0034EF79 File Offset: 0x0034D179
		[NullableContext(2)]
		public FNiagaraEventGeneratorProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023CB4 RID: 146612 RVA: 0x0034EF83 File Offset: 0x0034D183
		public FNiagaraEventGeneratorProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023CB5 RID: 146613 RVA: 0x0034EF8E File Offset: 0x0034D18E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEventGeneratorProperties(Pointer, false, true);
		}

		// Token: 0x06023CB6 RID: 146614 RVA: 0x0034EF98 File Offset: 0x0034D198
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEventGeneratorProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04013325 RID: 78629
		public const string __ObjectPath = "/Script/Niagara.NiagaraEventGeneratorProperties";

		// Token: 0x04013326 RID: 78630
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013327 RID: 78631
		internal static int __PropertyOffset_MaxEventsPerFrame;

		// Token: 0x04013328 RID: 78632
		internal static int __PropertyOffset_ID;

		// Token: 0x04013329 RID: 78633
		internal static int __PropertyOffset_DataSetCompiledData;

		// Token: 0x0401332A RID: 78634
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _DataSetCompiledData;
	}
}
