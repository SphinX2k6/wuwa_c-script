using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200112F RID: 4399
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundEffectSourcePresetChain")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class USoundEffectSourcePresetChain : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010196 RID: 65942 RVA: 0x0017B7FD File Offset: 0x001799FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundEffectSourcePresetChain._ClassPtr;
		}

		// Token: 0x06010197 RID: 65943 RVA: 0x0017B80C File Offset: 0x00179A0C
		public USoundEffectSourcePresetChain() : this(BuiltinUtils.AllocNativeUObject(USoundEffectSourcePresetChain.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010198 RID: 65944 RVA: 0x0017B834 File Offset: 0x00179A34
		public USoundEffectSourcePresetChain(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundEffectSourcePresetChain.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x06010199 RID: 65945 RVA: 0x0017B868 File Offset: 0x00179A68
		// (set) Token: 0x0601019A RID: 65946 RVA: 0x0017B8A1 File Offset: 0x00179AA1
		public TArray<FSourceEffectChainEntry> Chain
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSourceEffectChainEntry> result;
				if ((result = this._Chain) == null)
				{
					result = (this._Chain = new TArray<FSourceEffectChainEntry>(base.NativePtr + (IntPtr)USoundEffectSourcePresetChain.__PropertyOffset_Chain, this));
				}
				return result;
			}
			set
			{
				this.Chain.CopyAssign(value);
			}
		}

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x0601019B RID: 65947 RVA: 0x0017B8AF File Offset: 0x00179AAF
		// (set) Token: 0x0601019C RID: 65948 RVA: 0x0017B8C8 File Offset: 0x00179AC8
		public unsafe bool bPlayEffectChainTails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundEffectSourcePresetChain.__PropertyOffset_bPlayEffectChainTails) & USoundEffectSourcePresetChain.__PropertyMask_bPlayEffectChainTails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundEffectSourcePresetChain.__PropertyOffset_bPlayEffectChainTails) = ((*(base.NativePtr + (IntPtr)USoundEffectSourcePresetChain.__PropertyOffset_bPlayEffectChainTails) & ~USoundEffectSourcePresetChain.__PropertyMask_bPlayEffectChainTails) | (value ? USoundEffectSourcePresetChain.__PropertyMask_bPlayEffectChainTails : 0));
			}
		}

		// Token: 0x0601019D RID: 65949 RVA: 0x0017B8F8 File Offset: 0x00179AF8
		static USoundEffectSourcePresetChain()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundEffectSourcePresetChain");
		}

		// Token: 0x0601019E RID: 65950 RVA: 0x0017B906 File Offset: 0x00179B06
		protected USoundEffectSourcePresetChain(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A82 RID: 35458
		public new const string __ObjectPath = "/Script/Engine.SoundEffectSourcePresetChain";

		// Token: 0x04008A83 RID: 35459
		private static IntPtr _ClassPtr;

		// Token: 0x04008A84 RID: 35460
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008A85 RID: 35461
		internal static int __PropertyOffset_Chain;

		// Token: 0x04008A86 RID: 35462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSourceEffectChainEntry> _Chain;

		// Token: 0x04008A87 RID: 35463
		internal static int __PropertyOffset_bPlayEffectChainTails;

		// Token: 0x04008A88 RID: 35464
		internal static byte __PropertyMask_bPlayEffectChainTails;
	}
}
