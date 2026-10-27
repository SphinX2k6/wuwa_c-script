using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000889 RID: 2185
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitAnimBufferData")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UBakedBoneSplitAnimBufferData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007780 RID: 30592 RVA: 0x000AB27D File Offset: 0x000A947D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneSplitAnimBufferData._ClassPtr;
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x000AB28C File Offset: 0x000A948C
		public UBakedBoneSplitAnimBufferData() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitAnimBufferData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x000AB2B4 File Offset: 0x000A94B4
		public UBakedBoneSplitAnimBufferData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitAnimBufferData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06007783 RID: 30595 RVA: 0x000AB2E7 File Offset: 0x000A94E7
		// (set) Token: 0x06007784 RID: 30596 RVA: 0x000AB2F7 File Offset: 0x000A94F7
		public unsafe int Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitAnimBufferData.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitAnimBufferData.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06007785 RID: 30597 RVA: 0x000AB308 File Offset: 0x000A9508
		// (set) Token: 0x06007786 RID: 30598 RVA: 0x000AB318 File Offset: 0x000A9518
		public unsafe int Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitAnimBufferData.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitAnimBufferData.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06007787 RID: 30599 RVA: 0x000AB329 File Offset: 0x000A9529
		// (set) Token: 0x06007788 RID: 30600 RVA: 0x000AB339 File Offset: 0x000A9539
		public unsafe bool IsCompressedData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBakedBoneSplitAnimBufferData.__PropertyOffset_IsCompressedData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBakedBoneSplitAnimBufferData.__PropertyOffset_IsCompressedData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06007789 RID: 30601 RVA: 0x000AB34C File Offset: 0x000A954C
		// (set) Token: 0x0600778A RID: 30602 RVA: 0x000AB385 File Offset: 0x000A9585
		public TArray<FBakedBoneSplitAnimSection> AnimSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneSplitAnimSection> result;
				if ((result = this._AnimSections) == null)
				{
					result = (this._AnimSections = new TArray<FBakedBoneSplitAnimSection>(base.NativePtr + (IntPtr)UBakedBoneSplitAnimBufferData.__PropertyOffset_AnimSections, this));
				}
				return result;
			}
			set
			{
				this.AnimSections.CopyAssign(value);
			}
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x000AB393 File Offset: 0x000A9593
		static UBakedBoneSplitAnimBufferData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneSplitAnimBufferData");
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x000AB3A1 File Offset: 0x000A95A1
		protected UBakedBoneSplitAnimBufferData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003961 RID: 14689
		public new const string __ObjectPath = "/Script/Engine.BakedBoneSplitAnimBufferData";

		// Token: 0x04003962 RID: 14690
		private static IntPtr _ClassPtr;

		// Token: 0x04003963 RID: 14691
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003964 RID: 14692
		internal static int __PropertyOffset_Width;

		// Token: 0x04003965 RID: 14693
		internal static int __PropertyOffset_Height;

		// Token: 0x04003966 RID: 14694
		internal static int __PropertyOffset_IsCompressedData;

		// Token: 0x04003967 RID: 14695
		internal static int __PropertyOffset_AnimSections;

		// Token: 0x04003968 RID: 14696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneSplitAnimSection> _AnimSections;
	}
}
