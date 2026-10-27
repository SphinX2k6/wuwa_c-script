using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001224 RID: 4644
	[UnrealObjectPath("/Script/Engine.VectorFieldVolume")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AVectorFieldVolume : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011184 RID: 70020 RVA: 0x001915F2 File Offset: 0x0018F7F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AVectorFieldVolume._ClassPtr;
		}

		// Token: 0x06011185 RID: 70021 RVA: 0x00191600 File Offset: 0x0018F800
		public AVectorFieldVolume() : this(BuiltinUtils.AllocNativeUObject(AVectorFieldVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011186 RID: 70022 RVA: 0x00191628 File Offset: 0x0018F828
		[NullableContext(1)]
		public AVectorFieldVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AVectorFieldVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x06011187 RID: 70023 RVA: 0x0019165B File Offset: 0x0018F85B
		// (set) Token: 0x06011188 RID: 70024 RVA: 0x0019166F File Offset: 0x0018F86F
		[Nullable(2)]
		public unsafe UVectorFieldComponent VectorFieldComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorFieldComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AVectorFieldVolume.__PropertyOffset_VectorFieldComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AVectorFieldVolume.__PropertyOffset_VectorFieldComponent, value);
			}
		}

		// Token: 0x06011189 RID: 70025 RVA: 0x00191684 File Offset: 0x0018F884
		static AVectorFieldVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VectorFieldVolume");
		}

		// Token: 0x0601118A RID: 70026 RVA: 0x00191692 File Offset: 0x0018F892
		protected AVectorFieldVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400926F RID: 37487
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VectorFieldVolume";

		// Token: 0x04009270 RID: 37488
		private static IntPtr _ClassPtr;

		// Token: 0x04009271 RID: 37489
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009272 RID: 37490
		internal static int __PropertyOffset_VectorFieldComponent;
	}
}
