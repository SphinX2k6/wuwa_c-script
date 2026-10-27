using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000993 RID: 2451
	[UnrealObjectPath("/Script/Engine.DataAsset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UDataAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008A64 RID: 35428 RVA: 0x000C629D File Offset: 0x000C449D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataAsset._ClassPtr;
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x000C62A9 File Offset: 0x000C44A9
		// (set) Token: 0x06008A66 RID: 35430 RVA: 0x000C62BD File Offset: 0x000C44BD
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UDataAsset> NativeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UDataAsset.__PropertyOffset_NativeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UDataAsset.__PropertyOffset_NativeClass) = value;
			}
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x000C62D2 File Offset: 0x000C44D2
		static UDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataAsset");
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x000C62E0 File Offset: 0x000C44E0
		protected UDataAsset() : this(BuiltinUtils.AllocNativeUObject(UDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x000C6308 File Offset: 0x000C4508
		protected UDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041B6 RID: 16822
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataAsset";

		// Token: 0x040041B7 RID: 16823
		private static IntPtr _ClassPtr;

		// Token: 0x040041B8 RID: 16824
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041B9 RID: 16825
		internal static int __PropertyOffset_NativeClass;
	}
}
