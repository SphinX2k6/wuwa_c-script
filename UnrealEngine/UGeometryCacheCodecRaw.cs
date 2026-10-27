using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200140F RID: 5135
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheCodecRaw")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UGeometryCacheCodecRaw : UGeometryCacheCodecBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012BDA RID: 76762 RVA: 0x001B96BA File Offset: 0x001B78BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCacheCodecRaw._ClassPtr;
		}

		// Token: 0x06012BDB RID: 76763 RVA: 0x001B96C8 File Offset: 0x001B78C8
		public UGeometryCacheCodecRaw() : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheCodecRaw.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012BDC RID: 76764 RVA: 0x001B96F0 File Offset: 0x001B78F0
		[NullableContext(1)]
		public UGeometryCacheCodecRaw(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheCodecRaw.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048A5 RID: 18597
		// (get) Token: 0x06012BDD RID: 76765 RVA: 0x001B9723 File Offset: 0x001B7923
		// (set) Token: 0x06012BDE RID: 76766 RVA: 0x001B9733 File Offset: 0x001B7933
		public unsafe int DummyProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheCodecRaw.__PropertyOffset_DummyProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheCodecRaw.__PropertyOffset_DummyProperty) = value;
			}
		}

		// Token: 0x06012BDF RID: 76767 RVA: 0x001B9744 File Offset: 0x001B7944
		static UGeometryCacheCodecRaw()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheCodecRaw");
		}

		// Token: 0x06012BE0 RID: 76768 RVA: 0x001B9752 File Offset: 0x001B7952
		protected UGeometryCacheCodecRaw(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A053 RID: 41043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheCodecRaw";

		// Token: 0x0400A054 RID: 41044
		private static IntPtr _ClassPtr;

		// Token: 0x0400A055 RID: 41045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A056 RID: 41046
		internal static int __PropertyOffset_DummyProperty;
	}
}
