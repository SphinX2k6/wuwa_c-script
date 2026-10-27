using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024D1 RID: 9425
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NiagaraShader.NiagaraDataInterfaceGPUParamInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraDataInterfaceGPUParamInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060233CF RID: 144335 RVA: 0x00341EBE File Offset: 0x003400BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataInterfaceGPUParamInfo._ScriptStructPtr != 0) ? FNiagaraDataInterfaceGPUParamInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NiagaraShader.NiagaraDataInterfaceGPUParamInfo", ref FNiagaraDataInterfaceGPUParamInfo._ScriptStructPtr);
		}

		// Token: 0x17008779 RID: 34681
		// (get) Token: 0x060233D0 RID: 144336 RVA: 0x00341EE2 File Offset: 0x003400E2
		// (set) Token: 0x060233D1 RID: 144337 RVA: 0x00341EF6 File Offset: 0x003400F6
		public unsafe string DataInterfaceHLSLSymbol
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraDataInterfaceGPUParamInfo.__PropertyOffset_DataInterfaceHLSLSymbol)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraDataInterfaceGPUParamInfo.__PropertyOffset_DataInterfaceHLSLSymbol)), value);
			}
		}

		// Token: 0x1700877A RID: 34682
		// (get) Token: 0x060233D2 RID: 144338 RVA: 0x00341F0B File Offset: 0x0034010B
		// (set) Token: 0x060233D3 RID: 144339 RVA: 0x00341F1F File Offset: 0x0034011F
		public unsafe string DIClassName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraDataInterfaceGPUParamInfo.__PropertyOffset_DIClassName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraDataInterfaceGPUParamInfo.__PropertyOffset_DIClassName)), value);
			}
		}

		// Token: 0x1700877B RID: 34683
		// (get) Token: 0x060233D4 RID: 144340 RVA: 0x00341F34 File Offset: 0x00340134
		// (set) Token: 0x060233D5 RID: 144341 RVA: 0x00341F77 File Offset: 0x00340177
		public TArray<FNiagaraDataInterfaceGeneratedFunction> GeneratedFunctions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDataInterfaceGeneratedFunction> result;
				if ((result = this._GeneratedFunctions) == null)
				{
					result = (this._GeneratedFunctions = new TArray<FNiagaraDataInterfaceGeneratedFunction>(base.NativePtr + (IntPtr)FNiagaraDataInterfaceGPUParamInfo.__PropertyOffset_GeneratedFunctions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GeneratedFunctions.CopyAssign(value);
			}
		}

		// Token: 0x060233D6 RID: 144342 RVA: 0x00341F85 File Offset: 0x00340185
		public FNiagaraDataInterfaceGPUParamInfo()
		{
		}

		// Token: 0x060233D7 RID: 144343 RVA: 0x00341F8D File Offset: 0x0034018D
		public FNiagaraDataInterfaceGPUParamInfo(string DataInterfaceHLSLSymbol, string DIClassName, TArray<FNiagaraDataInterfaceGeneratedFunction> GeneratedFunctions)
		{
			this.DataInterfaceHLSLSymbol = DataInterfaceHLSLSymbol;
			this.DIClassName = DIClassName;
			this.GeneratedFunctions = GeneratedFunctions;
		}

		// Token: 0x060233D8 RID: 144344 RVA: 0x00341FAA File Offset: 0x003401AA
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataInterfaceGPUParamInfo.StaticStruct();
		}

		// Token: 0x060233D9 RID: 144345 RVA: 0x00341FB6 File Offset: 0x003401B6
		[NullableContext(2)]
		public FNiagaraDataInterfaceGPUParamInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060233DA RID: 144346 RVA: 0x00341FC0 File Offset: 0x003401C0
		public FNiagaraDataInterfaceGPUParamInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060233DB RID: 144347 RVA: 0x00341FCB File Offset: 0x003401CB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataInterfaceGPUParamInfo(Pointer, false, true);
		}

		// Token: 0x060233DC RID: 144348 RVA: 0x00341FD5 File Offset: 0x003401D5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataInterfaceGPUParamInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012D45 RID: 77125
		public const string __ObjectPath = "/Script/NiagaraShader.NiagaraDataInterfaceGPUParamInfo";

		// Token: 0x04012D46 RID: 77126
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012D47 RID: 77127
		internal static int __PropertyOffset_DataInterfaceHLSLSymbol;

		// Token: 0x04012D48 RID: 77128
		internal static int __PropertyOffset_DIClassName;

		// Token: 0x04012D49 RID: 77129
		internal static int __PropertyOffset_GeneratedFunctions;

		// Token: 0x04012D4A RID: 77130
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDataInterfaceGeneratedFunction> _GeneratedFunctions;
	}
}
