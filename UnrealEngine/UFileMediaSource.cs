using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002293 RID: 8851
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.FileMediaSource")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UFileMediaSource : UBaseMediaSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060219FD RID: 137725 RVA: 0x0031BE81 File Offset: 0x0031A081
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFileMediaSource._ClassPtr;
		}

		// Token: 0x060219FE RID: 137726 RVA: 0x0031BE90 File Offset: 0x0031A090
		public UFileMediaSource() : this(BuiltinUtils.AllocNativeUObject(UFileMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060219FF RID: 137727 RVA: 0x0031BEB8 File Offset: 0x0031A0B8
		public UFileMediaSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFileMediaSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082A3 RID: 33443
		// (get) Token: 0x06021A00 RID: 137728 RVA: 0x0031BEEB File Offset: 0x0031A0EB
		// (set) Token: 0x06021A01 RID: 137729 RVA: 0x0031BEFF File Offset: 0x0031A0FF
		public unsafe string FilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UFileMediaSource.__PropertyOffset_FilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UFileMediaSource.__PropertyOffset_FilePath)), value);
			}
		}

		// Token: 0x170082A4 RID: 33444
		// (get) Token: 0x06021A02 RID: 137730 RVA: 0x0031BF14 File Offset: 0x0031A114
		// (set) Token: 0x06021A03 RID: 137731 RVA: 0x0031BF24 File Offset: 0x0031A124
		public unsafe bool PrecacheFile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFileMediaSource.__PropertyOffset_PrecacheFile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFileMediaSource.__PropertyOffset_PrecacheFile) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021A04 RID: 137732 RVA: 0x0031BF38 File Offset: 0x0031A138
		public unsafe void SetFilePath(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UFileMediaSource.__SetFilePath_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06021A05 RID: 137733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFilePath_Internal(IntPtr @this, in FString Path);

		// Token: 0x06021A06 RID: 137734 RVA: 0x0031BF62 File Offset: 0x0031A162
		static UFileMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.FileMediaSource");
		}

		// Token: 0x06021A07 RID: 137735 RVA: 0x0031BF70 File Offset: 0x0031A170
		protected UFileMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F60 RID: 73568
		public new const string __ObjectPath = "/Script/MediaAssets.FileMediaSource";

		// Token: 0x04011F61 RID: 73569
		private static IntPtr _ClassPtr;

		// Token: 0x04011F62 RID: 73570
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F63 RID: 73571
		internal static int __PropertyOffset_FilePath;

		// Token: 0x04011F64 RID: 73572
		internal static int __PropertyOffset_PrecacheFile;
	}
}
