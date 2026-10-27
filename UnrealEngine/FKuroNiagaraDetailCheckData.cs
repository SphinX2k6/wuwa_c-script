using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CFC RID: 3324
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroNiagaraDetailCheckData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroNiagaraDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B10B RID: 45323 RVA: 0x000FB704 File Offset: 0x000F9904
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNiagaraDetailCheckData._ScriptStructPtr != 0) ? FKuroNiagaraDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroNiagaraDetailCheckData", ref FKuroNiagaraDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x0600B10C RID: 45324 RVA: 0x000FB728 File Offset: 0x000F9928
		// (set) Token: 0x0600B10D RID: 45325 RVA: 0x000FB73C File Offset: 0x000F993C
		public unsafe string niagara_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNiagaraDetailCheckData.__PropertyOffset_niagara_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroNiagaraDetailCheckData.__PropertyOffset_niagara_path)), value);
			}
		}

		// Token: 0x0600B10E RID: 45326 RVA: 0x000FB751 File Offset: 0x000F9951
		public FKuroNiagaraDetailCheckData()
		{
		}

		// Token: 0x0600B10F RID: 45327 RVA: 0x000FB759 File Offset: 0x000F9959
		public FKuroNiagaraDetailCheckData(string niagara_path)
		{
			this.niagara_path = niagara_path;
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x000FB768 File Offset: 0x000F9968
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNiagaraDetailCheckData.StaticStruct();
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x000FB774 File Offset: 0x000F9974
		[NullableContext(2)]
		public FKuroNiagaraDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x000FB77E File Offset: 0x000F997E
		public FKuroNiagaraDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B113 RID: 45331 RVA: 0x000FB789 File Offset: 0x000F9989
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNiagaraDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x000FB793 File Offset: 0x000F9993
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNiagaraDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005CC9 RID: 23753
		public const string __ObjectPath = "/Script/Engine.KuroNiagaraDetailCheckData";

		// Token: 0x04005CCA RID: 23754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CCB RID: 23755
		internal static int __PropertyOffset_niagara_path;
	}
}
