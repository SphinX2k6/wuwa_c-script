using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DA RID: 2010
	[UnrealObjectPath("/Script/Engine.AnimatedSparseVolumeTexture")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UAnimatedSparseVolumeTexture : UStreamableSparseVolumeTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B1C RID: 27420 RVA: 0x0009A498 File Offset: 0x00098698
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimatedSparseVolumeTexture._ClassPtr;
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x0009A4A4 File Offset: 0x000986A4
		public UAnimatedSparseVolumeTexture() : this(BuiltinUtils.AllocNativeUObject(UAnimatedSparseVolumeTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x0009A4CC File Offset: 0x000986CC
		[NullableContext(1)]
		public UAnimatedSparseVolumeTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimatedSparseVolumeTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x0009A4FF File Offset: 0x000986FF
		static UAnimatedSparseVolumeTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimatedSparseVolumeTexture");
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x0009A50D File Offset: 0x0009870D
		protected UAnimatedSparseVolumeTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400338A RID: 13194
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimatedSparseVolumeTexture";

		// Token: 0x0400338B RID: 13195
		private static IntPtr _ClassPtr;

		// Token: 0x0400338C RID: 13196
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
