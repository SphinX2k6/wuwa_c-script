using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200149F RID: 5279
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAsset")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UHoudiniAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060131D4 RID: 78292 RVA: 0x001C1D32 File Offset: 0x001BFF32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAsset._ClassPtr;
		}

		// Token: 0x060131D5 RID: 78293 RVA: 0x001C1D40 File Offset: 0x001BFF40
		public UHoudiniAsset() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060131D6 RID: 78294 RVA: 0x001C1D68 File Offset: 0x001BFF68
		public UHoudiniAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x060131D7 RID: 78295 RVA: 0x001C1D9B File Offset: 0x001BFF9B
		// (set) Token: 0x060131D8 RID: 78296 RVA: 0x001C1DAF File Offset: 0x001BFFAF
		public unsafe string AssetFileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniAsset.__PropertyOffset_AssetFileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniAsset.__PropertyOffset_AssetFileName)), value);
			}
		}

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x060131D9 RID: 78297 RVA: 0x001C1DC4 File Offset: 0x001BFFC4
		// (set) Token: 0x060131DA RID: 78298 RVA: 0x001C1DFD File Offset: 0x001BFFFD
		public TArray<byte> AssetBytes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._AssetBytes) == null)
				{
					result = (this._AssetBytes = new TArray<byte>(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_AssetBytes, this));
				}
				return result;
			}
			set
			{
				this.AssetBytes.CopyAssign(value);
			}
		}

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x060131DB RID: 78299 RVA: 0x001C1E0B File Offset: 0x001C000B
		// (set) Token: 0x060131DC RID: 78300 RVA: 0x001C1E1B File Offset: 0x001C001B
		public unsafe uint AssetBytesCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_AssetBytesCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_AssetBytesCount) = (int)value;
			}
		}

		// Token: 0x17004A42 RID: 19010
		// (get) Token: 0x060131DD RID: 78301 RVA: 0x001C1E2C File Offset: 0x001C002C
		// (set) Token: 0x060131DE RID: 78302 RVA: 0x001C1E3C File Offset: 0x001C003C
		public unsafe bool bAssetLimitedCommercial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_bAssetLimitedCommercial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_bAssetLimitedCommercial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A43 RID: 19011
		// (get) Token: 0x060131DF RID: 78303 RVA: 0x001C1E4D File Offset: 0x001C004D
		// (set) Token: 0x060131E0 RID: 78304 RVA: 0x001C1E5D File Offset: 0x001C005D
		public unsafe bool bAssetNonCommercial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_bAssetNonCommercial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_bAssetNonCommercial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A44 RID: 19012
		// (get) Token: 0x060131E1 RID: 78305 RVA: 0x001C1E6E File Offset: 0x001C006E
		// (set) Token: 0x060131E2 RID: 78306 RVA: 0x001C1E7E File Offset: 0x001C007E
		public unsafe bool bAssetExpanded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_bAssetExpanded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAsset.__PropertyOffset_bAssetExpanded) = (value ? 1 : 0);
			}
		}

		// Token: 0x060131E3 RID: 78307 RVA: 0x001C1E8F File Offset: 0x001C008F
		static UHoudiniAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAsset");
		}

		// Token: 0x060131E4 RID: 78308 RVA: 0x001C1E9D File Offset: 0x001C009D
		protected UHoudiniAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A51B RID: 42267
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAsset";

		// Token: 0x0400A51C RID: 42268
		private static IntPtr _ClassPtr;

		// Token: 0x0400A51D RID: 42269
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A51E RID: 42270
		internal static int __PropertyOffset_AssetFileName;

		// Token: 0x0400A51F RID: 42271
		internal static int __PropertyOffset_AssetBytes;

		// Token: 0x0400A520 RID: 42272
		[Nullable(2)]
		private TArray<byte> _AssetBytes;

		// Token: 0x0400A521 RID: 42273
		internal static int __PropertyOffset_AssetBytesCount;

		// Token: 0x0400A522 RID: 42274
		internal static int __PropertyOffset_bAssetLimitedCommercial;

		// Token: 0x0400A523 RID: 42275
		internal static int __PropertyOffset_bAssetNonCommercial;

		// Token: 0x0400A524 RID: 42276
		internal static int __PropertyOffset_bAssetExpanded;
	}
}
