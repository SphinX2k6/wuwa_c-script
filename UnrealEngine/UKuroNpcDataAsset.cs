using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B7D RID: 7037
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroNpcDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AB47 RID: 109383 RVA: 0x0027597C File Offset: 0x00273B7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNpcDataAsset._ClassPtr;
		}

		// Token: 0x0601AB48 RID: 109384 RVA: 0x00275988 File Offset: 0x00273B88
		public UKuroNpcDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroNpcDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AB49 RID: 109385 RVA: 0x002759B0 File Offset: 0x00273BB0
		[NullableContext(1)]
		public UKuroNpcDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNpcDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601AB4A RID: 109386 RVA: 0x002759E3 File Offset: 0x00273BE3
		static UKuroNpcDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcDataAsset");
		}

		// Token: 0x0601AB4B RID: 109387 RVA: 0x002759F1 File Offset: 0x00273BF1
		protected UKuroNpcDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E727 RID: 59175
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcDataAsset";

		// Token: 0x0400E728 RID: 59176
		private static IntPtr _ClassPtr;

		// Token: 0x0400E729 RID: 59177
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
