using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022A4 RID: 8868
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.StreamMediaSource")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UStreamMediaSource : UBaseMediaSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B9C RID: 138140 RVA: 0x0031DD7F File Offset: 0x0031BF7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamMediaSource._ClassPtr;
		}

		// Token: 0x06021B9D RID: 138141 RVA: 0x0031DD8C File Offset: 0x0031BF8C
		public UStreamMediaSource() : this(BuiltinUtils.AllocNativeUObject(UStreamMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B9E RID: 138142 RVA: 0x0031DDB4 File Offset: 0x0031BFB4
		public UStreamMediaSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamMediaSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082D3 RID: 33491
		// (get) Token: 0x06021B9F RID: 138143 RVA: 0x0031DDE7 File Offset: 0x0031BFE7
		// (set) Token: 0x06021BA0 RID: 138144 RVA: 0x0031DDFB File Offset: 0x0031BFFB
		public unsafe string StreamUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UStreamMediaSource.__PropertyOffset_StreamUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UStreamMediaSource.__PropertyOffset_StreamUrl)), value);
			}
		}

		// Token: 0x06021BA1 RID: 138145 RVA: 0x0031DE10 File Offset: 0x0031C010
		static UStreamMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.StreamMediaSource");
		}

		// Token: 0x06021BA2 RID: 138146 RVA: 0x0031DE1E File Offset: 0x0031C01E
		protected UStreamMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FDB RID: 73691
		public new const string __ObjectPath = "/Script/MediaAssets.StreamMediaSource";

		// Token: 0x04011FDC RID: 73692
		private static IntPtr _ClassPtr;

		// Token: 0x04011FDD RID: 73693
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FDE RID: 73694
		internal static int __PropertyOffset_StreamUrl;
	}
}
