using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016FD RID: 5885
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletLogicDataBase")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class UKuroBulletLogicDataBase : UKuroBulletBpDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015424 RID: 87076 RVA: 0x001F3F1E File Offset: 0x001F211E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletLogicDataBase._ClassPtr;
		}

		// Token: 0x17005415 RID: 21525
		// (get) Token: 0x06015425 RID: 87077 RVA: 0x001F3F2A File Offset: 0x001F212A
		// (set) Token: 0x06015426 RID: 87078 RVA: 0x001F3F3A File Offset: 0x001F213A
		public unsafe EKuroBulletLogicStage ExecuteStage
		{
			get
			{
				return (EKuroBulletLogicStage)(*(base.NativePtr + (IntPtr)UKuroBulletLogicDataBase.__PropertyOffset_ExecuteStage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletLogicDataBase.__PropertyOffset_ExecuteStage) = (byte)value;
			}
		}

		// Token: 0x06015427 RID: 87079 RVA: 0x001F3F4B File Offset: 0x001F214B
		static UKuroBulletLogicDataBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletLogicDataBase");
		}

		// Token: 0x06015428 RID: 87080 RVA: 0x001F3F5C File Offset: 0x001F215C
		protected UKuroBulletLogicDataBase() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletLogicDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015429 RID: 87081 RVA: 0x001F3F84 File Offset: 0x001F2184
		protected UKuroBulletLogicDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B973 RID: 47475
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletLogicDataBase";

		// Token: 0x0400B974 RID: 47476
		private static IntPtr _ClassPtr;

		// Token: 0x0400B975 RID: 47477
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B976 RID: 47478
		internal static int __PropertyOffset_ExecuteStage;
	}
}
