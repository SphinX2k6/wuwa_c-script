using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002552 RID: 9554
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraDataChannelLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237DA RID: 145370 RVA: 0x0034777E File Offset: 0x0034597E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelLibrary._ClassPtr;
		}

		// Token: 0x060237DB RID: 145371 RVA: 0x0034778C File Offset: 0x0034598C
		public UNiagaraDataChannelLibrary() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237DC RID: 145372 RVA: 0x003477B4 File Offset: 0x003459B4
		[NullableContext(1)]
		public UNiagaraDataChannelLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060237DD RID: 145373 RVA: 0x003477E7 File Offset: 0x003459E7
		public static void WriteToNiagaraDataChannelSingle(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, bool bVisibleToBlueprint, bool bVisibleToNiagaraCPU, bool bVisibleToNiagaraGPU)
		{
			UNiagaraDataChannelLibrary.__WriteToNiagaraDataChannelSingle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, bVisibleToBlueprint, bVisibleToNiagaraCPU, bVisibleToNiagaraGPU);
		}

		// Token: 0x060237DE RID: 145374 RVA: 0x00347824 File Offset: 0x00345A24
		public unsafe static UNiagaraDataChannelWriter WriteToNiagaraDataChannel(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, [Nullable(1)] string DebugSource)
		{
			FString fstring = FString.AllocTemp(DebugSource);
			UNiagaraDataChannelWriter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraDataChannelWriter>(UNiagaraDataChannelLibrary.__WriteToNiagaraDataChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, Count, bVisibleToGame, bVisibleToCPU, bVisibleToGPU, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060237DF RID: 145375 RVA: 0x00347884 File Offset: 0x00345A84
		public unsafe static void ReadFromNiagaraDataChannelSingle(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, int Index, FNiagaraDataChannelSearchParameters SearchParams, bool bReadPreviousFrame, ref ENiagartaDataChannelReadResult ReadResult)
		{
			fixed (ENiagartaDataChannelReadResult* ptr = &ReadResult)
			{
				void* ptr2 = (void*)ptr;
				UNiagaraDataChannelLibrary.__ReadFromNiagaraDataChannelSingle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, Index, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, bReadPreviousFrame, ref ReadResult);
			}
		}

		// Token: 0x060237E0 RID: 145376 RVA: 0x003478D3 File Offset: 0x00345AD3
		public static UNiagaraDataChannelReader ReadFromNiagaraDataChannel(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, bool bReadPreviousFrame)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraDataChannelReader>(UNiagaraDataChannelLibrary.__ReadFromNiagaraDataChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, bReadPreviousFrame));
		}

		// Token: 0x060237E1 RID: 145377 RVA: 0x0034790F File Offset: 0x00345B0F
		public static UNiagaraDataChannelHandler GetNiagaraDataChannel(UObject WorldContextObject, UNiagaraDataChannelAsset Channel)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraDataChannelHandler>(UNiagaraDataChannelLibrary.__GetNiagaraDataChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060237E2 RID: 145378 RVA: 0x0034793B File Offset: 0x00345B3B
		public static int GetDataChannelElementCount(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, bool bReadPreviousFrame)
		{
			return UNiagaraDataChannelLibrary.__GetDataChannelElementCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, bReadPreviousFrame);
		}

		// Token: 0x060237E3 RID: 145379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteToNiagaraDataChannelSingle_Internal(IntPtr WorldContextObject, IntPtr Channel, IntPtr SearchParams, bool bVisibleToBlueprint, bool bVisibleToNiagaraCPU, bool bVisibleToNiagaraGPU);

		// Token: 0x060237E4 RID: 145380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WriteToNiagaraDataChannel_Internal(IntPtr WorldContextObject, IntPtr Channel, IntPtr SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, in FString DebugSource);

		// Token: 0x060237E5 RID: 145381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReadFromNiagaraDataChannelSingle_Internal(IntPtr WorldContextObject, IntPtr Channel, int Index, IntPtr SearchParams, bool bReadPreviousFrame, ref ENiagartaDataChannelReadResult ReadResult);

		// Token: 0x060237E6 RID: 145382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ReadFromNiagaraDataChannel_Internal(IntPtr WorldContextObject, IntPtr Channel, IntPtr SearchParams, bool bReadPreviousFrame);

		// Token: 0x060237E7 RID: 145383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNiagaraDataChannel_Internal(IntPtr WorldContextObject, IntPtr Channel);

		// Token: 0x060237E8 RID: 145384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDataChannelElementCount_Internal(IntPtr WorldContextObject, IntPtr Channel, IntPtr SearchParams, bool bReadPreviousFrame);

		// Token: 0x060237E9 RID: 145385 RVA: 0x00347972 File Offset: 0x00345B72
		static UNiagaraDataChannelLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelLibrary");
		}

		// Token: 0x060237EA RID: 145386 RVA: 0x00347980 File Offset: 0x00345B80
		protected UNiagaraDataChannelLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013083 RID: 77955
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelLibrary";

		// Token: 0x04013084 RID: 77956
		private static IntPtr _ClassPtr;

		// Token: 0x04013085 RID: 77957
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
