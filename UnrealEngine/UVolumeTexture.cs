using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200123F RID: 4671
	[UnrealObjectPath("/Script/Engine.VolumeTexture")]
	[UnrealStructLayout(4032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4032)]
	public class UVolumeTexture : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601128E RID: 70286 RVA: 0x0019304D File Offset: 0x0019124D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVolumeTexture._ClassPtr;
		}

		// Token: 0x0601128F RID: 70287 RVA: 0x0019305C File Offset: 0x0019125C
		public UVolumeTexture() : this(BuiltinUtils.AllocNativeUObject(UVolumeTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011290 RID: 70288 RVA: 0x00193084 File Offset: 0x00191284
		[NullableContext(1)]
		public UVolumeTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVolumeTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011291 RID: 70289 RVA: 0x001930B7 File Offset: 0x001912B7
		static UVolumeTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VolumeTexture");
		}

		// Token: 0x06011292 RID: 70290 RVA: 0x001930C5 File Offset: 0x001912C5
		protected UVolumeTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092E8 RID: 37608
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VolumeTexture";

		// Token: 0x040092E9 RID: 37609
		private static IntPtr _ClassPtr;

		// Token: 0x040092EA RID: 37610
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
