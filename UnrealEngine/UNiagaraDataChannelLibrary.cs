using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A3 RID: 1955
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNiagaraDataChannelLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A9ED RID: 43501 RVA: 0x000FABE2 File Offset: 0x000F8DE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelLibrary._ClassPtr;
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x000FABF0 File Offset: 0x000F8DF0
		public UNiagaraDataChannelLibrary() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x000FAC18 File Offset: 0x000F8E18
		[NullableContext(1)]
		public UNiagaraDataChannelLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x000FAC4B File Offset: 0x000F8E4B
		[NullableContext(2)]
		public static void WriteToNiagaraDataChannelSingle(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, bool bVisibleToBlueprint, bool bVisibleToNiagaraCPU, bool bVisibleToNiagaraGPU)
		{
			UNiagaraDataChannelLibrary.__WriteToNiagaraDataChannelSingle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, bVisibleToBlueprint, bVisibleToNiagaraCPU, bVisibleToNiagaraGPU);
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x000FAC88 File Offset: 0x000F8E88
		[NullableContext(2)]
		public unsafe static UNiagaraDataChannelWriter WriteToNiagaraDataChannel(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, [Nullable(1)] string DebugSource)
		{
			FString fstring = FString.AllocTemp(DebugSource);
			UNiagaraDataChannelWriter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraDataChannelWriter>(UNiagaraDataChannelLibrary.__WriteToNiagaraDataChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, Count, bVisibleToGame, bVisibleToCPU, bVisibleToGPU, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x000FACE8 File Offset: 0x000F8EE8
		[NullableContext(2)]
		public static int GetDataChannelElementCount(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, bool bReadPreviousFrame)
		{
			return UNiagaraDataChannelLibrary.__GetDataChannelElementCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Channel != null) ? Channel.NativePtr : IntPtr.Zero, (SearchParams ?? new FNiagaraDataChannelSearchParameters()).NativePtr, bReadPreviousFrame);
		}

		// Token: 0x0600A9F3 RID: 43507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteToNiagaraDataChannelSingle_Internal(IntPtr WorldContextObject, IntPtr Channel, IntPtr SearchParams, bool bVisibleToBlueprint, bool bVisibleToNiagaraCPU, bool bVisibleToNiagaraGPU);

		// Token: 0x0600A9F4 RID: 43508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WriteToNiagaraDataChannel_Internal(IntPtr WorldContextObject, IntPtr Channel, IntPtr SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU, in FString DebugSource);

		// Token: 0x0600A9F5 RID: 43509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDataChannelElementCount_Internal(IntPtr WorldContextObject, IntPtr Channel, IntPtr SearchParams, bool bReadPreviousFrame);

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x000FAD1F File Offset: 0x000F8F1F
		static UNiagaraDataChannelLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelLibrary");
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x000FAD2D File Offset: 0x000F8F2D
		protected UNiagaraDataChannelLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048DC RID: 18652
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelLibrary";

		// Token: 0x040048DD RID: 18653
		private static IntPtr _ClassPtr;

		// Token: 0x040048DE RID: 18654
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
