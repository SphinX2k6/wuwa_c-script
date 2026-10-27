using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002556 RID: 9558
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelWriter")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UNiagaraDataChannelWriter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023824 RID: 145444 RVA: 0x00347D7B File Offset: 0x00345F7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelWriter._ClassPtr;
		}

		// Token: 0x06023825 RID: 145445 RVA: 0x00347D88 File Offset: 0x00345F88
		public UNiagaraDataChannelWriter() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelWriter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023826 RID: 145446 RVA: 0x00347DB0 File Offset: 0x00345FB0
		[NullableContext(1)]
		public UNiagaraDataChannelWriter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelWriter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008850 RID: 34896
		// (get) Token: 0x06023827 RID: 145447 RVA: 0x00347DE3 File Offset: 0x00345FE3
		// (set) Token: 0x06023828 RID: 145448 RVA: 0x00347DF7 File Offset: 0x00345FF7
		public unsafe UNiagaraDataChannelHandler Owner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelWriter.__PropertyOffset_Owner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelWriter.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x06023829 RID: 145449 RVA: 0x00347E0C File Offset: 0x0034600C
		public unsafe void WriteVector4(FName VarName, int Index, FVector4 InData)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InData;
			UNiagaraDataChannelWriter.__WriteVector4_Internal(base.NativePtr, VarName, Index, ptr);
		}

		// Token: 0x0602382A RID: 145450 RVA: 0x00347E3E File Offset: 0x0034603E
		public void WriteVector2D(FName VarName, int Index, FVector2D InData)
		{
			UNiagaraDataChannelWriter.__WriteVector2D_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0602382B RID: 145451 RVA: 0x00347E4E File Offset: 0x0034604E
		public void WriteVector(FName VarName, int Index, FVector InData)
		{
			UNiagaraDataChannelWriter.__WriteVector_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0602382C RID: 145452 RVA: 0x00347E5E File Offset: 0x0034605E
		public void WriteSpawnInfo(FName VarName, int Index, FNiagaraSpawnInfo InData)
		{
			UNiagaraDataChannelWriter.__WriteSpawnInfo_Internal(base.NativePtr, VarName, Index, (InData ?? new FNiagaraSpawnInfo()).NativePtr);
		}

		// Token: 0x0602382D RID: 145453 RVA: 0x00347E7C File Offset: 0x0034607C
		public unsafe void WriteQuat(FName VarName, int Index, FQuat InData)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InData;
			UNiagaraDataChannelWriter.__WriteQuat_Internal(base.NativePtr, VarName, Index, ptr);
		}

		// Token: 0x0602382E RID: 145454 RVA: 0x00347EAE File Offset: 0x003460AE
		public void WritePosition(FName VarName, int Index, FVector InData)
		{
			UNiagaraDataChannelWriter.__WritePosition_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x0602382F RID: 145455 RVA: 0x00347EBE File Offset: 0x003460BE
		public void WriteLinearColor(FName VarName, int Index, FLinearColor InData)
		{
			UNiagaraDataChannelWriter.__WriteLinearColor_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x06023830 RID: 145456 RVA: 0x00347ECE File Offset: 0x003460CE
		public void WriteInt(FName VarName, int Index, int InData)
		{
			UNiagaraDataChannelWriter.__WriteInt_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x06023831 RID: 145457 RVA: 0x00347EDE File Offset: 0x003460DE
		public void WriteID(FName VarName, int Index, FNiagaraID InData)
		{
			UNiagaraDataChannelWriter.__WriteID_Internal(base.NativePtr, VarName, Index, (InData ?? new FNiagaraID()).NativePtr);
		}

		// Token: 0x06023832 RID: 145458 RVA: 0x00347EFC File Offset: 0x003460FC
		public void WriteFloat(FName VarName, int Index, double InData)
		{
			UNiagaraDataChannelWriter.__WriteFloat_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x06023833 RID: 145459 RVA: 0x00347F0C File Offset: 0x0034610C
		public void WriteEnum(FName VarName, int Index, byte InData)
		{
			UNiagaraDataChannelWriter.__WriteEnum_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x06023834 RID: 145460 RVA: 0x00347F1C File Offset: 0x0034611C
		public void WriteBool(FName VarName, int Index, bool InData)
		{
			UNiagaraDataChannelWriter.__WriteBool_Internal(base.NativePtr, VarName, Index, InData);
		}

		// Token: 0x06023835 RID: 145461 RVA: 0x00347F2C File Offset: 0x0034612C
		public int Num()
		{
			return UNiagaraDataChannelWriter.__Num_Internal(base.NativePtr);
		}

		// Token: 0x06023836 RID: 145462 RVA: 0x00347F3C File Offset: 0x0034613C
		[NullableContext(1)]
		public unsafe bool InitWrite([Nullable(2)] FNiagaraDataChannelSearchParameters SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, string DebugSource)
		{
			FString fstring = FString.AllocTemp(DebugSource);
			bool result = UNiagaraDataChannelWriter.__InitWrite_Internal(base.NativePtr, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, Count, bVisibleToGame, bVisibleToCPU, bVisibleToGPU, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06023837 RID: 145463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteVector4_Internal(IntPtr @this, FName VarName, int Index, in FVector4 InData);

		// Token: 0x06023838 RID: 145464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteVector2D_Internal(IntPtr @this, FName VarName, int Index, FVector2D InData);

		// Token: 0x06023839 RID: 145465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteVector_Internal(IntPtr @this, FName VarName, int Index, FVector InData);

		// Token: 0x0602383A RID: 145466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteSpawnInfo_Internal(IntPtr @this, FName VarName, int Index, IntPtr InData);

		// Token: 0x0602383B RID: 145467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteQuat_Internal(IntPtr @this, FName VarName, int Index, in FQuat InData);

		// Token: 0x0602383C RID: 145468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WritePosition_Internal(IntPtr @this, FName VarName, int Index, FVector InData);

		// Token: 0x0602383D RID: 145469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteLinearColor_Internal(IntPtr @this, FName VarName, int Index, FLinearColor InData);

		// Token: 0x0602383E RID: 145470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteInt_Internal(IntPtr @this, FName VarName, int Index, int InData);

		// Token: 0x0602383F RID: 145471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteID_Internal(IntPtr @this, FName VarName, int Index, IntPtr InData);

		// Token: 0x06023840 RID: 145472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteFloat_Internal(IntPtr @this, FName VarName, int Index, double InData);

		// Token: 0x06023841 RID: 145473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteEnum_Internal(IntPtr @this, FName VarName, int Index, byte InData);

		// Token: 0x06023842 RID: 145474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteBool_Internal(IntPtr @this, FName VarName, int Index, bool InData);

		// Token: 0x06023843 RID: 145475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Num_Internal(IntPtr @this);

		// Token: 0x06023844 RID: 145476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitWrite_Internal(IntPtr @this, IntPtr SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, in FString DebugSource);

		// Token: 0x06023845 RID: 145477 RVA: 0x00347F7C File Offset: 0x0034617C
		static UNiagaraDataChannelWriter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelWriter");
		}

		// Token: 0x06023846 RID: 145478 RVA: 0x00347F8A File Offset: 0x0034618A
		protected UNiagaraDataChannelWriter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013092 RID: 77970
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelWriter";

		// Token: 0x04013093 RID: 77971
		private static IntPtr _ClassPtr;

		// Token: 0x04013094 RID: 77972
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013095 RID: 77973
		internal static int __PropertyOffset_Owner;
	}
}
