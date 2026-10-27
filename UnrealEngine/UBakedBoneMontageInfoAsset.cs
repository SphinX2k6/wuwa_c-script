using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000883 RID: 2179
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMontageInfoAsset")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UBakedBoneMontageInfoAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600773F RID: 30527 RVA: 0x000AABFA File Offset: 0x000A8DFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneMontageInfoAsset._ClassPtr;
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x000AAC08 File Offset: 0x000A8E08
		public UBakedBoneMontageInfoAsset() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMontageInfoAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x000AAC30 File Offset: 0x000A8E30
		public UBakedBoneMontageInfoAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneMontageInfoAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06007742 RID: 30530 RVA: 0x000AAC64 File Offset: 0x000A8E64
		// (set) Token: 0x06007743 RID: 30531 RVA: 0x000AAC9D File Offset: 0x000A8E9D
		public TMap<int, FMontageSectionInfo> MontageSectionInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FMontageSectionInfo> result;
				if ((result = this._MontageSectionInfo) == null)
				{
					result = (this._MontageSectionInfo = new TMap<int, FMontageSectionInfo>(base.NativePtr + (IntPtr)UBakedBoneMontageInfoAsset.__PropertyOffset_MontageSectionInfo, this));
				}
				return result;
			}
			set
			{
				this.MontageSectionInfo.CopyAssign(value);
			}
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x000AACAB File Offset: 0x000A8EAB
		public void Clear()
		{
			UBakedBoneMontageInfoAsset.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06007745 RID: 30533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06007746 RID: 30534 RVA: 0x000AACB8 File Offset: 0x000A8EB8
		static UBakedBoneMontageInfoAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneMontageInfoAsset");
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x000AACC6 File Offset: 0x000A8EC6
		protected UBakedBoneMontageInfoAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400393F RID: 14655
		public new const string __ObjectPath = "/Script/Engine.BakedBoneMontageInfoAsset";

		// Token: 0x04003940 RID: 14656
		private static IntPtr _ClassPtr;

		// Token: 0x04003941 RID: 14657
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003942 RID: 14658
		internal static int __PropertyOffset_MontageSectionInfo;

		// Token: 0x04003943 RID: 14659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FMontageSectionInfo> _MontageSectionInfo;
	}
}
