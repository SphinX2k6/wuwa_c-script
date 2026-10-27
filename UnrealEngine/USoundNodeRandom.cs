using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200114D RID: 4429
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeRandom")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class USoundNodeRandom : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102E0 RID: 66272 RVA: 0x0017D777 File Offset: 0x0017B977
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeRandom._ClassPtr;
		}

		// Token: 0x060102E1 RID: 66273 RVA: 0x0017D784 File Offset: 0x0017B984
		public USoundNodeRandom() : this(BuiltinUtils.AllocNativeUObject(USoundNodeRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102E2 RID: 66274 RVA: 0x0017D7AC File Offset: 0x0017B9AC
		public USoundNodeRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x060102E3 RID: 66275 RVA: 0x0017D7E0 File Offset: 0x0017B9E0
		// (set) Token: 0x060102E4 RID: 66276 RVA: 0x0017D819 File Offset: 0x0017BA19
		public TArray<float> Weights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Weights) == null)
				{
					result = (this._Weights = new TArray<float>(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_Weights, this));
				}
				return result;
			}
			set
			{
				this.Weights.CopyAssign(value);
			}
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x060102E5 RID: 66277 RVA: 0x0017D828 File Offset: 0x0017BA28
		// (set) Token: 0x060102E6 RID: 66278 RVA: 0x0017D861 File Offset: 0x0017BA61
		public TArray<bool> HasBeenUsed
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._HasBeenUsed) == null)
				{
					result = (this._HasBeenUsed = new TArray<bool>(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_HasBeenUsed, this));
				}
				return result;
			}
			set
			{
				this.HasBeenUsed.CopyAssign(value);
			}
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x060102E7 RID: 66279 RVA: 0x0017D86F File Offset: 0x0017BA6F
		// (set) Token: 0x060102E8 RID: 66280 RVA: 0x0017D87F File Offset: 0x0017BA7F
		public unsafe int NumRandomUsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_NumRandomUsed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_NumRandomUsed) = value;
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x060102E9 RID: 66281 RVA: 0x0017D890 File Offset: 0x0017BA90
		// (set) Token: 0x060102EA RID: 66282 RVA: 0x0017D8A0 File Offset: 0x0017BAA0
		public unsafe int PreselectAtLevelLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_PreselectAtLevelLoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_PreselectAtLevelLoad) = value;
			}
		}

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x060102EB RID: 66283 RVA: 0x0017D8B1 File Offset: 0x0017BAB1
		// (set) Token: 0x060102EC RID: 66284 RVA: 0x0017D8CA File Offset: 0x0017BACA
		public unsafe bool bShouldExcludeFromBranchCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bShouldExcludeFromBranchCulling) & USoundNodeRandom.__PropertyMask_bShouldExcludeFromBranchCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bShouldExcludeFromBranchCulling) = ((*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bShouldExcludeFromBranchCulling) & ~USoundNodeRandom.__PropertyMask_bShouldExcludeFromBranchCulling) | (value ? USoundNodeRandom.__PropertyMask_bShouldExcludeFromBranchCulling : 0));
			}
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x060102ED RID: 66285 RVA: 0x0017D8FA File Offset: 0x0017BAFA
		// (set) Token: 0x060102EE RID: 66286 RVA: 0x0017D913 File Offset: 0x0017BB13
		public unsafe bool bSoundCueExcludedFromBranchCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bSoundCueExcludedFromBranchCulling) & USoundNodeRandom.__PropertyMask_bSoundCueExcludedFromBranchCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bSoundCueExcludedFromBranchCulling) = ((*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bSoundCueExcludedFromBranchCulling) & ~USoundNodeRandom.__PropertyMask_bSoundCueExcludedFromBranchCulling) | (value ? USoundNodeRandom.__PropertyMask_bSoundCueExcludedFromBranchCulling : 0));
			}
		}

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x060102EF RID: 66287 RVA: 0x0017D943 File Offset: 0x0017BB43
		// (set) Token: 0x060102F0 RID: 66288 RVA: 0x0017D95C File Offset: 0x0017BB5C
		public unsafe bool bRandomizeWithoutReplacement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bRandomizeWithoutReplacement) & USoundNodeRandom.__PropertyMask_bRandomizeWithoutReplacement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bRandomizeWithoutReplacement) = ((*(base.NativePtr + (IntPtr)USoundNodeRandom.__PropertyOffset_bRandomizeWithoutReplacement) & ~USoundNodeRandom.__PropertyMask_bRandomizeWithoutReplacement) | (value ? USoundNodeRandom.__PropertyMask_bRandomizeWithoutReplacement : 0));
			}
		}

		// Token: 0x060102F1 RID: 66289 RVA: 0x0017D98C File Offset: 0x0017BB8C
		static USoundNodeRandom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeRandom");
		}

		// Token: 0x060102F2 RID: 66290 RVA: 0x0017D99A File Offset: 0x0017BB9A
		protected USoundNodeRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B4B RID: 35659
		public new const string __ObjectPath = "/Script/Engine.SoundNodeRandom";

		// Token: 0x04008B4C RID: 35660
		private static IntPtr _ClassPtr;

		// Token: 0x04008B4D RID: 35661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B4E RID: 35662
		internal static int __PropertyOffset_Weights;

		// Token: 0x04008B4F RID: 35663
		[Nullable(2)]
		private TArray<float> _Weights;

		// Token: 0x04008B50 RID: 35664
		internal static int __PropertyOffset_HasBeenUsed;

		// Token: 0x04008B51 RID: 35665
		[Nullable(2)]
		private TArray<bool> _HasBeenUsed;

		// Token: 0x04008B52 RID: 35666
		internal static int __PropertyOffset_NumRandomUsed;

		// Token: 0x04008B53 RID: 35667
		internal static int __PropertyOffset_PreselectAtLevelLoad;

		// Token: 0x04008B54 RID: 35668
		internal static int __PropertyOffset_bShouldExcludeFromBranchCulling;

		// Token: 0x04008B55 RID: 35669
		internal static byte __PropertyMask_bShouldExcludeFromBranchCulling;

		// Token: 0x04008B56 RID: 35670
		internal static int __PropertyOffset_bSoundCueExcludedFromBranchCulling;

		// Token: 0x04008B57 RID: 35671
		internal static byte __PropertyMask_bSoundCueExcludedFromBranchCulling;

		// Token: 0x04008B58 RID: 35672
		internal static int __PropertyOffset_bRandomizeWithoutReplacement;

		// Token: 0x04008B59 RID: 35673
		internal static byte __PropertyMask_bRandomizeWithoutReplacement;
	}
}
