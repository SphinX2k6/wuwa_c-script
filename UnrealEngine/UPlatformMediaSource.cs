using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022A3 RID: 8867
	[UnrealObjectPath("/Script/MediaAssets.PlatformMediaSource")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UPlatformMediaSource : UMediaSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B95 RID: 138133 RVA: 0x0031DCD6 File Offset: 0x0031BED6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlatformMediaSource._ClassPtr;
		}

		// Token: 0x06021B96 RID: 138134 RVA: 0x0031DCE4 File Offset: 0x0031BEE4
		public UPlatformMediaSource() : this(BuiltinUtils.AllocNativeUObject(UPlatformMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B97 RID: 138135 RVA: 0x0031DD0C File Offset: 0x0031BF0C
		[NullableContext(1)]
		public UPlatformMediaSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlatformMediaSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082D2 RID: 33490
		// (get) Token: 0x06021B98 RID: 138136 RVA: 0x0031DD3F File Offset: 0x0031BF3F
		// (set) Token: 0x06021B99 RID: 138137 RVA: 0x0031DD53 File Offset: 0x0031BF53
		[Nullable(2)]
		public unsafe UMediaSource MediaSource
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + UPlatformMediaSource.__PropertyOffset_MediaSource);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPlatformMediaSource.__PropertyOffset_MediaSource, value);
			}
		}

		// Token: 0x06021B9A RID: 138138 RVA: 0x0031DD68 File Offset: 0x0031BF68
		static UPlatformMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.PlatformMediaSource");
		}

		// Token: 0x06021B9B RID: 138139 RVA: 0x0031DD76 File Offset: 0x0031BF76
		protected UPlatformMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FD7 RID: 73687
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.PlatformMediaSource";

		// Token: 0x04011FD8 RID: 73688
		private static IntPtr _ClassPtr;

		// Token: 0x04011FD9 RID: 73689
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FDA RID: 73690
		internal static int __PropertyOffset_MediaSource;
	}
}
