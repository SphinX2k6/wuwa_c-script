using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200112A RID: 4394
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundConcurrency")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class USoundConcurrency : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010152 RID: 65874 RVA: 0x0017B180 File Offset: 0x00179380
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundConcurrency._ClassPtr;
		}

		// Token: 0x06010153 RID: 65875 RVA: 0x0017B18C File Offset: 0x0017938C
		public USoundConcurrency() : this(BuiltinUtils.AllocNativeUObject(USoundConcurrency.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010154 RID: 65876 RVA: 0x0017B1B4 File Offset: 0x001793B4
		public USoundConcurrency(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundConcurrency.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x06010155 RID: 65877 RVA: 0x0017B1E8 File Offset: 0x001793E8
		// (set) Token: 0x06010156 RID: 65878 RVA: 0x0017B221 File Offset: 0x00179421
		public FSoundConcurrencySettings Concurrency
		{
			get
			{
				base.FastCheckIsValid();
				FSoundConcurrencySettings result;
				if ((result = this._Concurrency) == null)
				{
					result = (this._Concurrency = new FSoundConcurrencySettings(base.NativePtr + (IntPtr)USoundConcurrency.__PropertyOffset_Concurrency, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundConcurrencySettings.StaticStruct(), base.NativePtr + (IntPtr)USoundConcurrency.__PropertyOffset_Concurrency, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010157 RID: 65879 RVA: 0x0017B242 File Offset: 0x00179442
		static USoundConcurrency()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundConcurrency");
		}

		// Token: 0x06010158 RID: 65880 RVA: 0x0017B250 File Offset: 0x00179450
		protected USoundConcurrency(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A57 RID: 35415
		public new const string __ObjectPath = "/Script/Engine.SoundConcurrency";

		// Token: 0x04008A58 RID: 35416
		private static IntPtr _ClassPtr;

		// Token: 0x04008A59 RID: 35417
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008A5A RID: 35418
		internal static int __PropertyOffset_Concurrency;

		// Token: 0x04008A5B RID: 35419
		[Nullable(2)]
		private FSoundConcurrencySettings _Concurrency;
	}
}
