using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035C RID: 860
	[UnrealObjectPath("/Script/AssetMemoryAnalyzer.AssetMemoryAnalyzerSubsystem")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAssetMemoryAnalyzerSubsystem : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002FC2 RID: 12226 RVA: 0x00049314 File Offset: 0x00047514
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetMemoryAnalyzerSubsystem._ClassPtr;
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00049320 File Offset: 0x00047520
		public UAssetMemoryAnalyzerSubsystem() : this(BuiltinUtils.AllocNativeUObject(UAssetMemoryAnalyzerSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00049348 File Offset: 0x00047548
		[NullableContext(1)]
		public UAssetMemoryAnalyzerSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetMemoryAnalyzerSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x0004937B File Offset: 0x0004757B
		static UAssetMemoryAnalyzerSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AssetMemoryAnalyzer.AssetMemoryAnalyzerSubsystem");
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00049389 File Offset: 0x00047589
		protected UAssetMemoryAnalyzerSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014BB RID: 5307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AssetMemoryAnalyzer.AssetMemoryAnalyzerSubsystem";

		// Token: 0x040014BC RID: 5308
		private static IntPtr _ClassPtr;

		// Token: 0x040014BD RID: 5309
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
