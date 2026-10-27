using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200254D RID: 9549
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelHandler")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UNiagaraDataChannelHandler : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237B2 RID: 145330 RVA: 0x003472FC File Offset: 0x003454FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelHandler._ClassPtr;
		}

		// Token: 0x17008845 RID: 34885
		// (get) Token: 0x060237B3 RID: 145331 RVA: 0x00347308 File Offset: 0x00345508
		// (set) Token: 0x060237B4 RID: 145332 RVA: 0x0034731C File Offset: 0x0034551C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UNiagaraDataChannel> DataChannel
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannelHandler.__PropertyOffset_DataChannel);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannelHandler.__PropertyOffset_DataChannel) = value;
			}
		}

		// Token: 0x17008846 RID: 34886
		// (get) Token: 0x060237B5 RID: 145333 RVA: 0x00347331 File Offset: 0x00345531
		// (set) Token: 0x060237B6 RID: 145334 RVA: 0x00347345 File Offset: 0x00345545
		public unsafe UNiagaraDataChannelWriter Writer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelWriter>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelHandler.__PropertyOffset_Writer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelHandler.__PropertyOffset_Writer, value);
			}
		}

		// Token: 0x17008847 RID: 34887
		// (get) Token: 0x060237B7 RID: 145335 RVA: 0x0034735A File Offset: 0x0034555A
		// (set) Token: 0x060237B8 RID: 145336 RVA: 0x0034736E File Offset: 0x0034556E
		public unsafe UNiagaraDataChannelReader Reader
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelReader>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelHandler.__PropertyOffset_Reader);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelHandler.__PropertyOffset_Reader, value);
			}
		}

		// Token: 0x060237B9 RID: 145337 RVA: 0x00347384 File Offset: 0x00345584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UNiagaraDataChannelWriter GetDataChannelWriter()
		{
			UNiagaraDataChannelHandler.__GetDataChannelWriter_FunctionParams* ptr = stackalloc UNiagaraDataChannelHandler.__GetDataChannelWriter_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UNiagaraDataChannelHandler.__GetDataChannelWriter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UNiagaraDataChannelHandler.__GetDataChannelWriter_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UNiagaraDataChannelHandler.__GetDataChannelWriter_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraDataChannelWriter>(ptr->__Result);
		}

		// Token: 0x060237BA RID: 145338 RVA: 0x003473D0 File Offset: 0x003455D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UNiagaraDataChannelReader GetDataChannelReader()
		{
			UNiagaraDataChannelHandler.__GetDataChannelReader_FunctionParams* ptr = stackalloc UNiagaraDataChannelHandler.__GetDataChannelReader_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UNiagaraDataChannelHandler.__GetDataChannelReader_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UNiagaraDataChannelHandler.__GetDataChannelReader_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UNiagaraDataChannelHandler.__GetDataChannelReader_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraDataChannelReader>(ptr->__Result);
		}

		// Token: 0x060237BB RID: 145339 RVA: 0x0034741B File Offset: 0x0034561B
		static UNiagaraDataChannelHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelHandler");
		}

		// Token: 0x060237BC RID: 145340 RVA: 0x0034742C File Offset: 0x0034562C
		protected UNiagaraDataChannelHandler() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237BD RID: 145341 RVA: 0x00347454 File Offset: 0x00345654
		protected UNiagaraDataChannelHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013067 RID: 77927
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelHandler";

		// Token: 0x04013068 RID: 77928
		private static IntPtr _ClassPtr;

		// Token: 0x04013069 RID: 77929
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401306A RID: 77930
		internal static int __PropertyOffset_DataChannel;

		// Token: 0x0401306B RID: 77931
		internal static int __PropertyOffset_Writer;

		// Token: 0x0401306C RID: 77932
		internal static int __PropertyOffset_Reader;

		// Token: 0x0401306D RID: 77933
		private static IntPtr __GetDataChannelWriter_NativeFunctionPtr;

		// Token: 0x0401306E RID: 77934
		private static IntPtr __GetDataChannelReader_NativeFunctionPtr;

		// Token: 0x0200366D RID: 13933
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDataChannelWriter_FunctionParams
		{
			// Token: 0x0401773F RID: 96063
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200366E RID: 13934
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetDataChannelReader_FunctionParams
		{
			// Token: 0x04017740 RID: 96064
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
