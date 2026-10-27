using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EAF RID: 3759
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MicroTransactionBase")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UMicroTransactionBase : UPlatformInterfaceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CB6B RID: 52075 RVA: 0x0012885B File Offset: 0x00126A5B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMicroTransactionBase._ClassPtr;
		}

		// Token: 0x0600CB6C RID: 52076 RVA: 0x00128868 File Offset: 0x00126A68
		public UMicroTransactionBase() : this(BuiltinUtils.AllocNativeUObject(UMicroTransactionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CB6D RID: 52077 RVA: 0x00128890 File Offset: 0x00126A90
		public UMicroTransactionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMicroTransactionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0600CB6E RID: 52078 RVA: 0x001288C4 File Offset: 0x00126AC4
		// (set) Token: 0x0600CB6F RID: 52079 RVA: 0x001288FD File Offset: 0x00126AFD
		public TArray<FPurchaseInfo> AvailableProducts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPurchaseInfo> result;
				if ((result = this._AvailableProducts) == null)
				{
					result = (this._AvailableProducts = new TArray<FPurchaseInfo>(base.NativePtr + (IntPtr)UMicroTransactionBase.__PropertyOffset_AvailableProducts, this));
				}
				return result;
			}
			set
			{
				this.AvailableProducts.CopyAssign(value);
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0600CB70 RID: 52080 RVA: 0x0012890B File Offset: 0x00126B0B
		// (set) Token: 0x0600CB71 RID: 52081 RVA: 0x0012891F File Offset: 0x00126B1F
		public unsafe string LastError
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMicroTransactionBase.__PropertyOffset_LastError)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMicroTransactionBase.__PropertyOffset_LastError)), value);
			}
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0600CB72 RID: 52082 RVA: 0x00128934 File Offset: 0x00126B34
		// (set) Token: 0x0600CB73 RID: 52083 RVA: 0x00128948 File Offset: 0x00126B48
		public unsafe string LastErrorSolution
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMicroTransactionBase.__PropertyOffset_LastErrorSolution)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMicroTransactionBase.__PropertyOffset_LastErrorSolution)), value);
			}
		}

		// Token: 0x0600CB74 RID: 52084 RVA: 0x0012895D File Offset: 0x00126B5D
		static UMicroTransactionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MicroTransactionBase");
		}

		// Token: 0x0600CB75 RID: 52085 RVA: 0x0012896B File Offset: 0x00126B6B
		protected UMicroTransactionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006D9A RID: 28058
		public new const string __ObjectPath = "/Script/Engine.MicroTransactionBase";

		// Token: 0x04006D9B RID: 28059
		private static IntPtr _ClassPtr;

		// Token: 0x04006D9C RID: 28060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006D9D RID: 28061
		internal static int __PropertyOffset_AvailableProducts;

		// Token: 0x04006D9E RID: 28062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPurchaseInfo> _AvailableProducts;

		// Token: 0x04006D9F RID: 28063
		internal static int __PropertyOffset_LastError;

		// Token: 0x04006DA0 RID: 28064
		internal static int __PropertyOffset_LastErrorSolution;
	}
}
