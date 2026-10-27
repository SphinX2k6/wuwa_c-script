using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F6 RID: 2038
	[UnrealObjectPath("/Script/Engine.AnimCompress")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UAnimCompress : UAnimBoneCompressionCodec, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CBB RID: 27835 RVA: 0x0009C841 File Offset: 0x0009AA41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress._ClassPtr;
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06006CBC RID: 27836 RVA: 0x0009C84D File Offset: 0x0009AA4D
		// (set) Token: 0x06006CBD RID: 27837 RVA: 0x0009C866 File Offset: 0x0009AA66
		public unsafe bool bNeedsSkeleton
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_bNeedsSkeleton) & UAnimCompress.__PropertyMask_bNeedsSkeleton) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_bNeedsSkeleton) = ((*(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_bNeedsSkeleton) & ~UAnimCompress.__PropertyMask_bNeedsSkeleton) | (value ? UAnimCompress.__PropertyMask_bNeedsSkeleton : 0));
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06006CBE RID: 27838 RVA: 0x0009C896 File Offset: 0x0009AA96
		// (set) Token: 0x06006CBF RID: 27839 RVA: 0x0009C8AA File Offset: 0x0009AAAA
		public unsafe TEnumAsByte<AnimationCompressionFormat> TranslationCompressionFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_TranslationCompressionFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_TranslationCompressionFormat) = value;
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x0009C8BF File Offset: 0x0009AABF
		// (set) Token: 0x06006CC1 RID: 27841 RVA: 0x0009C8D3 File Offset: 0x0009AAD3
		public unsafe TEnumAsByte<AnimationCompressionFormat> RotationCompressionFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_RotationCompressionFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_RotationCompressionFormat) = value;
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x0009C8E8 File Offset: 0x0009AAE8
		// (set) Token: 0x06006CC3 RID: 27843 RVA: 0x0009C8FC File Offset: 0x0009AAFC
		public unsafe TEnumAsByte<AnimationCompressionFormat> ScaleCompressionFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_ScaleCompressionFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress.__PropertyOffset_ScaleCompressionFormat) = value;
			}
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x0009C911 File Offset: 0x0009AB11
		static UAnimCompress()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress");
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x0009C920 File Offset: 0x0009AB20
		protected UAnimCompress() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x0009C948 File Offset: 0x0009AB48
		protected UAnimCompress(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003474 RID: 13428
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress";

		// Token: 0x04003475 RID: 13429
		private static IntPtr _ClassPtr;

		// Token: 0x04003476 RID: 13430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003477 RID: 13431
		internal static int __PropertyOffset_bNeedsSkeleton;

		// Token: 0x04003478 RID: 13432
		internal static byte __PropertyMask_bNeedsSkeleton;

		// Token: 0x04003479 RID: 13433
		internal static int __PropertyOffset_TranslationCompressionFormat;

		// Token: 0x0400347A RID: 13434
		internal static int __PropertyOffset_RotationCompressionFormat;

		// Token: 0x0400347B RID: 13435
		internal static int __PropertyOffset_ScaleCompressionFormat;
	}
}
