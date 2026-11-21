using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C1 RID: 193
	[UnrealObjectPath("/Script/AkAudio.AkExternalMediaAsset")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAkExternalMediaAsset : UAkMediaAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E4B RID: 3659 RVA: 0x000164C4 File Offset: 0x000146C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkExternalMediaAsset._ClassPtr;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000164D0 File Offset: 0x000146D0
		public UAkExternalMediaAsset() : this(BuiltinUtils.AllocNativeUObject(UAkExternalMediaAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000164F8 File Offset: 0x000146F8
		[NullableContext(1)]
		public UAkExternalMediaAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkExternalMediaAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0001652B File Offset: 0x0001472B
		static UAkExternalMediaAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkExternalMediaAsset");
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00016539 File Offset: 0x00014739
		protected UAkExternalMediaAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002CB RID: 715
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkExternalMediaAsset";

		// Token: 0x040002CC RID: 716
		private static IntPtr _ClassPtr;

		// Token: 0x040002CD RID: 717
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
