using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A5 RID: 1957
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelWriter")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UNiagaraDataChannelWriter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AA05 RID: 43525 RVA: 0x000FAE31 File Offset: 0x000F9031
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelWriter._ClassPtr;
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x000FAE40 File Offset: 0x000F9040
		public UNiagaraDataChannelWriter() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelWriter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x000FAE68 File Offset: 0x000F9068
		[NullableContext(1)]
		public UNiagaraDataChannelWriter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelWriter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x000FAE9C File Offset: 0x000F909C
		public unsafe void WriteVector4(FName VarName, int Index, FVector4 InData)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InData;
			UNiagaraDataChannelWriter.__WriteVector4_Internal(base.NativePtr, VarName, Index, ptr);
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x000FAECE File Offset: 0x000F90CE
		public void WriteVector2D(FName VarName, int Index, FVector2D InData)
		{
			UNiagaraDataChannelWriter.__WriteVector2D_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x000FAEDE File Offset: 0x000F90DE
		public void WriteVector(FName VarName, int Index, FVector InData)
		{
			UNiagaraDataChannelWriter.__WriteVector_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x000FAEF0 File Offset: 0x000F90F0
		public unsafe void WriteQuat(FName VarName, int Index, FQuat InData)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InData;
			UNiagaraDataChannelWriter.__WriteQuat_Internal(base.NativePtr, VarName, Index, ptr);
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x000FAF22 File Offset: 0x000F9122
		public void WritePosition(FName VarName, int Index, FVector InData)
		{
			UNiagaraDataChannelWriter.__WritePosition_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x000FAF32 File Offset: 0x000F9132
		public void WriteLinearColor(FName VarName, int Index, FLinearColor InData)
		{
			UNiagaraDataChannelWriter.__WriteLinearColor_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x000FAF42 File Offset: 0x000F9142
		public void WriteInt(FName VarName, int Index, int InData)
		{
			UNiagaraDataChannelWriter.__WriteInt_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x000FAF52 File Offset: 0x000F9152
		public void WriteFloat(FName VarName, int Index, double InData)
		{
			UNiagaraDataChannelWriter.__WriteFloat_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x000FAF62 File Offset: 0x000F9162
		public void WriteEnum(FName VarName, int Index, byte InData)
		{
			UNiagaraDataChannelWriter.__WriteEnum_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x000FAF72 File Offset: 0x000F9172
		public void WriteBool(FName VarName, int Index, bool InData)
		{
			UNiagaraDataChannelWriter.__WriteBool_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x000FAF82 File Offset: 0x000F9182
		public int Num()
		{
			return UNiagaraDataChannelWriter.__Num_Internal(base.NativePtr);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x000FAF90 File Offset: 0x000F9190
		[NullableContext(1)]
		public unsafe bool InitWrite([Nullable(2)] FNiagaraDataChannelSearchParameters SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, string DebugSource)
		{
			FString fstring = FString.AllocTemp(DebugSource);
			bool result = UNiagaraDataChannelWriter.__InitWrite_Internal(base.NativePtr, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, Count, bVisibleToGame, bVisibleToCPU, bVisibleToGPU, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AA14 RID: 43540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteVector4_Internal(IntPtr @this, FName VarName, int Index, in FVector4 InData);

		// Token: 0x0600AA15 RID: 43541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteVector2D_Internal(IntPtr @this, FName VarName, int Index, FVector2D InData);

		// Token: 0x0600AA16 RID: 43542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteVector_Internal(IntPtr @this, FName VarName, int Index, FVector InData);

		// Token: 0x0600AA17 RID: 43543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteQuat_Internal(IntPtr @this, FName VarName, int Index, in FQuat InData);

		// Token: 0x0600AA18 RID: 43544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WritePosition_Internal(IntPtr @this, FName VarName, int Index, FVector InData);

		// Token: 0x0600AA19 RID: 43545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteLinearColor_Internal(IntPtr @this, FName VarName, int Index, FLinearColor InData);

		// Token: 0x0600AA1A RID: 43546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteInt_Internal(IntPtr @this, FName VarName, int Index, int InData);

		// Token: 0x0600AA1B RID: 43547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteFloat_Internal(IntPtr @this, FName VarName, int Index, double InData);

		// Token: 0x0600AA1C RID: 43548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteEnum_Internal(IntPtr @this, FName VarName, int Index, byte InData);

		// Token: 0x0600AA1D RID: 43549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteBool_Internal(IntPtr @this, FName VarName, int Index, bool InData);

		// Token: 0x0600AA1E RID: 43550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Num_Internal(IntPtr @this);

		// Token: 0x0600AA1F RID: 43551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitWrite_Internal(IntPtr @this, IntPtr SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, in FString DebugSource);

		// Token: 0x0600AA20 RID: 43552 RVA: 0x000FAFD0 File Offset: 0x000F91D0
		static UNiagaraDataChannelWriter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelWriter");
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x000FAFDE File Offset: 0x000F91DE
		protected UNiagaraDataChannelWriter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048E5 RID: 18661
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelWriter";

		// Token: 0x040048E6 RID: 18662
		private static IntPtr _ClassPtr;

		// Token: 0x040048E7 RID: 18663
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
