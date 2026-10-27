using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BB3 RID: 7091
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterSystemData")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroScreenFilterSystemData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B1F2 RID: 111090 RVA: 0x0027F696 File Offset: 0x0027D896
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenFilterSystemData._ClassPtr;
		}

		// Token: 0x0601B1F3 RID: 111091 RVA: 0x0027F6A4 File Offset: 0x0027D8A4
		public UKuroScreenFilterSystemData() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenFilterSystemData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B1F4 RID: 111092 RVA: 0x0027F6CC File Offset: 0x0027D8CC
		public UKuroScreenFilterSystemData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenFilterSystemData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CBB RID: 27835
		// (get) Token: 0x0601B1F5 RID: 111093 RVA: 0x0027F700 File Offset: 0x0027D900
		// (set) Token: 0x0601B1F6 RID: 111094 RVA: 0x0027F739 File Offset: 0x0027D939
		public TArray<UKuroScreenFilterDataAsset> ScreenFilterSystemDatas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroScreenFilterDataAsset> result;
				if ((result = this._ScreenFilterSystemDatas) == null)
				{
					result = (this._ScreenFilterSystemDatas = new TArray<UKuroScreenFilterDataAsset>(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_ScreenFilterSystemDatas, this));
				}
				return result;
			}
			set
			{
				this.ScreenFilterSystemDatas.CopyAssign(value);
			}
		}

		// Token: 0x17006CBC RID: 27836
		// (get) Token: 0x0601B1F7 RID: 111095 RVA: 0x0027F747 File Offset: 0x0027D947
		// (set) Token: 0x0601B1F8 RID: 111096 RVA: 0x0027F757 File Offset: 0x0027D957
		public unsafe float SharpenRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenRadius) = value;
			}
		}

		// Token: 0x17006CBD RID: 27837
		// (get) Token: 0x0601B1F9 RID: 111097 RVA: 0x0027F768 File Offset: 0x0027D968
		// (set) Token: 0x0601B1FA RID: 111098 RVA: 0x0027F778 File Offset: 0x0027D978
		public unsafe float SharpenAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenAmount) = value;
			}
		}

		// Token: 0x17006CBE RID: 27838
		// (get) Token: 0x0601B1FB RID: 111099 RVA: 0x0027F789 File Offset: 0x0027D989
		// (set) Token: 0x0601B1FC RID: 111100 RVA: 0x0027F799 File Offset: 0x0027D999
		public unsafe float LaplacianAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_LaplacianAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_LaplacianAmount) = value;
			}
		}

		// Token: 0x17006CBF RID: 27839
		// (get) Token: 0x0601B1FD RID: 111101 RVA: 0x0027F7AA File Offset: 0x0027D9AA
		// (set) Token: 0x0601B1FE RID: 111102 RVA: 0x0027F7BA File Offset: 0x0027D9BA
		public unsafe float SharpenIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenIntensity) = value;
			}
		}

		// Token: 0x17006CC0 RID: 27840
		// (get) Token: 0x0601B1FF RID: 111103 RVA: 0x0027F7CB File Offset: 0x0027D9CB
		// (set) Token: 0x0601B200 RID: 111104 RVA: 0x0027F7DB File Offset: 0x0027D9DB
		public unsafe float ToonSharpenIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_ToonSharpenIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_ToonSharpenIntensity) = value;
			}
		}

		// Token: 0x17006CC1 RID: 27841
		// (get) Token: 0x0601B201 RID: 111105 RVA: 0x0027F7EC File Offset: 0x0027D9EC
		// (set) Token: 0x0601B202 RID: 111106 RVA: 0x0027F7FC File Offset: 0x0027D9FC
		public unsafe float SharpenDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterSystemData.__PropertyOffset_SharpenDistance) = value;
			}
		}

		// Token: 0x0601B203 RID: 111107 RVA: 0x0027F80D File Offset: 0x0027DA0D
		static UKuroScreenFilterSystemData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterSystemData");
		}

		// Token: 0x0601B204 RID: 111108 RVA: 0x0027F81B File Offset: 0x0027DA1B
		protected UKuroScreenFilterSystemData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E9AA RID: 59818
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterSystemData";

		// Token: 0x0400E9AB RID: 59819
		private static IntPtr _ClassPtr;

		// Token: 0x0400E9AC RID: 59820
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E9AD RID: 59821
		internal static int __PropertyOffset_ScreenFilterSystemDatas;

		// Token: 0x0400E9AE RID: 59822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroScreenFilterDataAsset> _ScreenFilterSystemDatas;

		// Token: 0x0400E9AF RID: 59823
		internal static int __PropertyOffset_SharpenRadius;

		// Token: 0x0400E9B0 RID: 59824
		internal static int __PropertyOffset_SharpenAmount;

		// Token: 0x0400E9B1 RID: 59825
		internal static int __PropertyOffset_LaplacianAmount;

		// Token: 0x0400E9B2 RID: 59826
		internal static int __PropertyOffset_SharpenIntensity;

		// Token: 0x0400E9B3 RID: 59827
		internal static int __PropertyOffset_ToonSharpenIntensity;

		// Token: 0x0400E9B4 RID: 59828
		internal static int __PropertyOffset_SharpenDistance;
	}
}
