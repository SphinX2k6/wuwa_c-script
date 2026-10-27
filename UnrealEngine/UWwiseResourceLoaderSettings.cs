using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A91 RID: 10897
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseResourceLoaderSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UWwiseResourceLoaderSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060282C5 RID: 164549 RVA: 0x003D1F16 File Offset: 0x003D0116
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWwiseResourceLoaderSettings._ClassPtr;
		}

		// Token: 0x060282C6 RID: 164550 RVA: 0x003D1F24 File Offset: 0x003D0124
		public UWwiseResourceLoaderSettings() : this(BuiltinUtils.AllocNativeUObject(UWwiseResourceLoaderSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060282C7 RID: 164551 RVA: 0x003D1F4C File Offset: 0x003D014C
		[NullableContext(1)]
		public UWwiseResourceLoaderSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWwiseResourceLoaderSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009949 RID: 39241
		// (get) Token: 0x060282C8 RID: 164552 RVA: 0x003D1F7F File Offset: 0x003D017F
		// (set) Token: 0x060282C9 RID: 164553 RVA: 0x003D1F8F File Offset: 0x003D018F
		public unsafe int MaxAllowedMediaCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWwiseResourceLoaderSettings.__PropertyOffset_MaxAllowedMediaCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWwiseResourceLoaderSettings.__PropertyOffset_MaxAllowedMediaCount) = value;
			}
		}

		// Token: 0x060282CA RID: 164554 RVA: 0x003D1FA0 File Offset: 0x003D01A0
		static UWwiseResourceLoaderSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/WwiseResourceLoader.WwiseResourceLoaderSettings");
		}

		// Token: 0x060282CB RID: 164555 RVA: 0x003D1FAE File Offset: 0x003D01AE
		protected UWwiseResourceLoaderSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016080 RID: 90240
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseResourceLoaderSettings";

		// Token: 0x04016081 RID: 90241
		private static IntPtr _ClassPtr;

		// Token: 0x04016082 RID: 90242
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016083 RID: 90243
		internal static int __PropertyOffset_MaxAllowedMediaCount;
	}
}
