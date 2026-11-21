using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C6 RID: 198
	[UnrealObjectPath("/Script/AkAudio.AkMediaAsset")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UAkMediaAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000ECE RID: 3790 RVA: 0x00016EC5 File Offset: 0x000150C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMediaAsset._ClassPtr;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00016ED4 File Offset: 0x000150D4
		public UAkMediaAsset() : this(BuiltinUtils.AllocNativeUObject(UAkMediaAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00016EFC File Offset: 0x000150FC
		[NullableContext(1)]
		public UAkMediaAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMediaAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00016F2F File Offset: 0x0001512F
		static UAkMediaAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMediaAsset");
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00016F3D File Offset: 0x0001513D
		protected UAkMediaAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002E0 RID: 736
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMediaAsset";

		// Token: 0x040002E1 RID: 737
		private static IntPtr _ClassPtr;

		// Token: 0x040002E2 RID: 738
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
