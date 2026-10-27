using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001232 RID: 4658
	[UnrealObjectPath("/Script/Engine.VirtualTextureBuilder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UVirtualTextureBuilder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011210 RID: 70160 RVA: 0x00192225 File Offset: 0x00190425
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVirtualTextureBuilder._ClassPtr;
		}

		// Token: 0x06011211 RID: 70161 RVA: 0x00192234 File Offset: 0x00190434
		public UVirtualTextureBuilder() : this(BuiltinUtils.AllocNativeUObject(UVirtualTextureBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011212 RID: 70162 RVA: 0x0019225C File Offset: 0x0019045C
		[NullableContext(1)]
		public UVirtualTextureBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVirtualTextureBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x06011213 RID: 70163 RVA: 0x0019228F File Offset: 0x0019048F
		// (set) Token: 0x06011214 RID: 70164 RVA: 0x001922A3 File Offset: 0x001904A3
		[Nullable(2)]
		public unsafe UVirtualTexture2D Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVirtualTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UVirtualTextureBuilder.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UVirtualTextureBuilder.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x06011215 RID: 70165 RVA: 0x001922B8 File Offset: 0x001904B8
		// (set) Token: 0x06011216 RID: 70166 RVA: 0x001922C8 File Offset: 0x001904C8
		public unsafe ulong BuildHash
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)UVirtualTextureBuilder.__PropertyOffset_BuildHash));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVirtualTextureBuilder.__PropertyOffset_BuildHash) = (long)value;
			}
		}

		// Token: 0x06011217 RID: 70167 RVA: 0x001922D9 File Offset: 0x001904D9
		static UVirtualTextureBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VirtualTextureBuilder");
		}

		// Token: 0x06011218 RID: 70168 RVA: 0x001922E7 File Offset: 0x001904E7
		protected UVirtualTextureBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092A9 RID: 37545
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VirtualTextureBuilder";

		// Token: 0x040092AA RID: 37546
		private static IntPtr _ClassPtr;

		// Token: 0x040092AB RID: 37547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040092AC RID: 37548
		internal static int __PropertyOffset_Texture;

		// Token: 0x040092AD RID: 37549
		internal static int __PropertyOffset_BuildHash;
	}
}
