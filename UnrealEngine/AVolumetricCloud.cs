using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001240 RID: 4672
	[UnrealObjectPath("/Script/Engine.VolumetricCloud")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AVolumetricCloud : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011293 RID: 70291 RVA: 0x001930CE File Offset: 0x001912CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AVolumetricCloud._ClassPtr;
		}

		// Token: 0x06011294 RID: 70292 RVA: 0x001930DC File Offset: 0x001912DC
		public AVolumetricCloud() : this(BuiltinUtils.AllocNativeUObject(AVolumetricCloud.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011295 RID: 70293 RVA: 0x00193104 File Offset: 0x00191304
		[NullableContext(1)]
		public AVolumetricCloud(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AVolumetricCloud.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x06011296 RID: 70294 RVA: 0x00193137 File Offset: 0x00191337
		// (set) Token: 0x06011297 RID: 70295 RVA: 0x0019314B File Offset: 0x0019134B
		[Nullable(2)]
		public unsafe UVolumetricCloudComponent VolumetricCloudComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumetricCloudComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AVolumetricCloud.__PropertyOffset_VolumetricCloudComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AVolumetricCloud.__PropertyOffset_VolumetricCloudComponent, value);
			}
		}

		// Token: 0x06011298 RID: 70296 RVA: 0x00193160 File Offset: 0x00191360
		static AVolumetricCloud()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VolumetricCloud");
		}

		// Token: 0x06011299 RID: 70297 RVA: 0x0019316E File Offset: 0x0019136E
		protected AVolumetricCloud(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092EB RID: 37611
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VolumetricCloud";

		// Token: 0x040092EC RID: 37612
		private static IntPtr _ClassPtr;

		// Token: 0x040092ED RID: 37613
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040092EE RID: 37614
		internal static int __PropertyOffset_VolumetricCloudComponent;
	}
}
