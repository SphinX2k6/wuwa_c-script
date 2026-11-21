using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C2 RID: 450
	[UnrealObjectPath("/Script/Engine.DataAsset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UDataAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020F2 RID: 8434 RVA: 0x00030621 File Offset: 0x0002E821
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataAsset._ClassPtr;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x0003062D File Offset: 0x0002E82D
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x00030641 File Offset: 0x0002E841
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

		// Token: 0x060020F5 RID: 8437 RVA: 0x00030656 File Offset: 0x0002E856
		static UDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataAsset");
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00030664 File Offset: 0x0002E864
		protected UDataAsset() : this(BuiltinUtils.AllocNativeUObject(UDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0003068C File Offset: 0x0002E88C
		protected UDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AF3 RID: 2803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataAsset";

		// Token: 0x04000AF4 RID: 2804
		private static IntPtr _ClassPtr;

		// Token: 0x04000AF5 RID: 2805
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AF6 RID: 2806
		internal static int __PropertyOffset_NativeClass;
	}
}
