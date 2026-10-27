using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000203 RID: 515
	[UnrealObjectPath("/Script/AkAudio.AkExternalMediaAsset")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAkExternalMediaAsset : UAkMediaAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E47 RID: 7751 RVA: 0x0002CE50 File Offset: 0x0002B050
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkExternalMediaAsset._ClassPtr;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0002CE5C File Offset: 0x0002B05C
		public UAkExternalMediaAsset() : this(BuiltinUtils.AllocNativeUObject(UAkExternalMediaAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0002CE84 File Offset: 0x0002B084
		[NullableContext(1)]
		public UAkExternalMediaAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkExternalMediaAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0002CEB7 File Offset: 0x0002B0B7
		static UAkExternalMediaAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkExternalMediaAsset");
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0002CEC5 File Offset: 0x0002B0C5
		protected UAkExternalMediaAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A0E RID: 2574
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkExternalMediaAsset";

		// Token: 0x04000A0F RID: 2575
		private static IntPtr _ClassPtr;

		// Token: 0x04000A10 RID: 2576
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
