using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200020D RID: 525
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkInitBank")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAkInitBank : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F50 RID: 8016 RVA: 0x0002E445 File Offset: 0x0002C645
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkInitBank._ClassPtr;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0002E454 File Offset: 0x0002C654
		public UAkInitBank() : this(BuiltinUtils.AllocNativeUObject(UAkInitBank.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0002E47C File Offset: 0x0002C67C
		public UAkInitBank(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkInitBank.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0002E4B0 File Offset: 0x0002C6B0
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x0002E4E9 File Offset: 0x0002C6E9
		public FWwiseInitBankCookedData InitBankCookedData
		{
			get
			{
				base.FastCheckIsValid();
				FWwiseInitBankCookedData result;
				if ((result = this._InitBankCookedData) == null)
				{
					result = (this._InitBankCookedData = new FWwiseInitBankCookedData(base.NativePtr + (IntPtr)UAkInitBank.__PropertyOffset_InitBankCookedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseInitBankCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkInitBank.__PropertyOffset_InitBankCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x0002E50A File Offset: 0x0002C70A
		static UAkInitBank()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkInitBank");
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0002E518 File Offset: 0x0002C718
		protected UAkInitBank(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A50 RID: 2640
		public new const string __ObjectPath = "/Script/AkAudio.AkInitBank";

		// Token: 0x04000A51 RID: 2641
		private static IntPtr _ClassPtr;

		// Token: 0x04000A52 RID: 2642
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A53 RID: 2643
		internal static int __PropertyOffset_InitBankCookedData;

		// Token: 0x04000A54 RID: 2644
		[Nullable(2)]
		private FWwiseInitBankCookedData _InitBankCookedData;
	}
}
