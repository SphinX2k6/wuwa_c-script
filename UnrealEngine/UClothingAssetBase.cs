using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048F RID: 1167
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothingAssetBase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UClothingAssetBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003EAE RID: 16046 RVA: 0x0005E411 File Offset: 0x0005C611
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothingAssetBase._ClassPtr;
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x0005E41D File Offset: 0x0005C61D
		// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x0005E431 File Offset: 0x0005C631
		public unsafe string ImportedFilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UClothingAssetBase.__PropertyOffset_ImportedFilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UClothingAssetBase.__PropertyOffset_ImportedFilePath)), value);
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06003EB1 RID: 16049 RVA: 0x0005E446 File Offset: 0x0005C646
		// (set) Token: 0x06003EB2 RID: 16050 RVA: 0x0005E45A File Offset: 0x0005C65A
		public unsafe FGuid AssetGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClothingAssetBase.__PropertyOffset_AssetGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClothingAssetBase.__PropertyOffset_AssetGuid) = value;
			}
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0005E46F File Offset: 0x0005C66F
		static UClothingAssetBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeInterface.ClothingAssetBase");
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x0005E480 File Offset: 0x0005C680
		protected UClothingAssetBase() : this(BuiltinUtils.AllocNativeUObject(UClothingAssetBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0005E4A8 File Offset: 0x0005C6A8
		protected UClothingAssetBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D8E RID: 7566
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothingAssetBase";

		// Token: 0x04001D8F RID: 7567
		private static IntPtr _ClassPtr;

		// Token: 0x04001D90 RID: 7568
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D91 RID: 7569
		internal static int __PropertyOffset_ImportedFilePath;

		// Token: 0x04001D92 RID: 7570
		internal static int __PropertyOffset_AssetGuid;
	}
}
