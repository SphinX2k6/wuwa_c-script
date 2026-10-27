using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C9 RID: 4297
	[UnrealObjectPath("/Script/Engine.RuntimeVirtualTextureVolume")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ARuntimeVirtualTextureVolume : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F553 RID: 62803 RVA: 0x0016B9B6 File Offset: 0x00169BB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARuntimeVirtualTextureVolume._ClassPtr;
		}

		// Token: 0x0600F554 RID: 62804 RVA: 0x0016B9C4 File Offset: 0x00169BC4
		public ARuntimeVirtualTextureVolume() : this(BuiltinUtils.AllocNativeUObject(ARuntimeVirtualTextureVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F555 RID: 62805 RVA: 0x0016B9EC File Offset: 0x00169BEC
		[NullableContext(1)]
		public ARuntimeVirtualTextureVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARuntimeVirtualTextureVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0600F556 RID: 62806 RVA: 0x0016BA1F File Offset: 0x00169C1F
		// (set) Token: 0x0600F557 RID: 62807 RVA: 0x0016BA33 File Offset: 0x00169C33
		[Nullable(2)]
		public unsafe URuntimeVirtualTextureComponent VirtualTextureComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimeVirtualTextureComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ARuntimeVirtualTextureVolume.__PropertyOffset_VirtualTextureComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ARuntimeVirtualTextureVolume.__PropertyOffset_VirtualTextureComponent, value);
			}
		}

		// Token: 0x0600F558 RID: 62808 RVA: 0x0016BA48 File Offset: 0x00169C48
		static ARuntimeVirtualTextureVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeVirtualTextureVolume");
		}

		// Token: 0x0600F559 RID: 62809 RVA: 0x0016BA56 File Offset: 0x00169C56
		protected ARuntimeVirtualTextureVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084EB RID: 34027
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimeVirtualTextureVolume";

		// Token: 0x040084EC RID: 34028
		private static IntPtr _ClassPtr;

		// Token: 0x040084ED RID: 34029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040084EE RID: 34030
		internal static int __PropertyOffset_VirtualTextureComponent;
	}
}
