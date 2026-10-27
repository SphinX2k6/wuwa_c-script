using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FC RID: 2044
	[UnrealObjectPath("/Script/Engine.AnimCompress_RemoveLinearKeys")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAnimCompress_RemoveLinearKeys : UAnimCompress, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006D0E RID: 27918 RVA: 0x0009D004 File Offset: 0x0009B204
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress_RemoveLinearKeys._ClassPtr;
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x0009D010 File Offset: 0x0009B210
		public UAnimCompress_RemoveLinearKeys() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_RemoveLinearKeys.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x0009D038 File Offset: 0x0009B238
		[NullableContext(1)]
		public UAnimCompress_RemoveLinearKeys(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_RemoveLinearKeys.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x0009D06B File Offset: 0x0009B26B
		// (set) Token: 0x06006D12 RID: 27922 RVA: 0x0009D07B File Offset: 0x0009B27B
		public unsafe float MaxPosDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxPosDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxPosDiff) = value;
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x0009D08C File Offset: 0x0009B28C
		// (set) Token: 0x06006D14 RID: 27924 RVA: 0x0009D09C File Offset: 0x0009B29C
		public unsafe float MaxAngleDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxAngleDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxAngleDiff) = value;
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x0009D0AD File Offset: 0x0009B2AD
		// (set) Token: 0x06006D16 RID: 27926 RVA: 0x0009D0BD File Offset: 0x0009B2BD
		public unsafe float MaxScaleDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxScaleDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxScaleDiff) = value;
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06006D17 RID: 27927 RVA: 0x0009D0CE File Offset: 0x0009B2CE
		// (set) Token: 0x06006D18 RID: 27928 RVA: 0x0009D0DE File Offset: 0x0009B2DE
		public unsafe float MaxEffectorDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxEffectorDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MaxEffectorDiff) = value;
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x0009D0EF File Offset: 0x0009B2EF
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x0009D0FF File Offset: 0x0009B2FF
		public unsafe float MinEffectorDiff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MinEffectorDiff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_MinEffectorDiff) = value;
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x0009D110 File Offset: 0x0009B310
		// (set) Token: 0x06006D1C RID: 27932 RVA: 0x0009D120 File Offset: 0x0009B320
		public unsafe float EffectorDiffSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_EffectorDiffSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_EffectorDiffSocket) = value;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06006D1D RID: 27933 RVA: 0x0009D131 File Offset: 0x0009B331
		// (set) Token: 0x06006D1E RID: 27934 RVA: 0x0009D141 File Offset: 0x0009B341
		public unsafe float ParentKeyScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_ParentKeyScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_ParentKeyScale) = value;
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06006D1F RID: 27935 RVA: 0x0009D152 File Offset: 0x0009B352
		// (set) Token: 0x06006D20 RID: 27936 RVA: 0x0009D16B File Offset: 0x0009B36B
		public unsafe bool bRetarget
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_bRetarget) & UAnimCompress_RemoveLinearKeys.__PropertyMask_bRetarget) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_bRetarget) = ((*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_bRetarget) & ~UAnimCompress_RemoveLinearKeys.__PropertyMask_bRetarget) | (value ? UAnimCompress_RemoveLinearKeys.__PropertyMask_bRetarget : 0));
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06006D21 RID: 27937 RVA: 0x0009D19B File Offset: 0x0009B39B
		// (set) Token: 0x06006D22 RID: 27938 RVA: 0x0009D1B4 File Offset: 0x0009B3B4
		public unsafe bool bActuallyFilterLinearKeys
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_bActuallyFilterLinearKeys) & UAnimCompress_RemoveLinearKeys.__PropertyMask_bActuallyFilterLinearKeys) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_bActuallyFilterLinearKeys) = ((*(base.NativePtr + (IntPtr)UAnimCompress_RemoveLinearKeys.__PropertyOffset_bActuallyFilterLinearKeys) & ~UAnimCompress_RemoveLinearKeys.__PropertyMask_bActuallyFilterLinearKeys) | (value ? UAnimCompress_RemoveLinearKeys.__PropertyMask_bActuallyFilterLinearKeys : 0));
			}
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x0009D1E4 File Offset: 0x0009B3E4
		static UAnimCompress_RemoveLinearKeys()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress_RemoveLinearKeys");
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x0009D1F2 File Offset: 0x0009B3F2
		protected UAnimCompress_RemoveLinearKeys(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034AA RID: 13482
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress_RemoveLinearKeys";

		// Token: 0x040034AB RID: 13483
		private static IntPtr _ClassPtr;

		// Token: 0x040034AC RID: 13484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040034AD RID: 13485
		internal static int __PropertyOffset_MaxPosDiff;

		// Token: 0x040034AE RID: 13486
		internal static int __PropertyOffset_MaxAngleDiff;

		// Token: 0x040034AF RID: 13487
		internal static int __PropertyOffset_MaxScaleDiff;

		// Token: 0x040034B0 RID: 13488
		internal static int __PropertyOffset_MaxEffectorDiff;

		// Token: 0x040034B1 RID: 13489
		internal static int __PropertyOffset_MinEffectorDiff;

		// Token: 0x040034B2 RID: 13490
		internal static int __PropertyOffset_EffectorDiffSocket;

		// Token: 0x040034B3 RID: 13491
		internal static int __PropertyOffset_ParentKeyScale;

		// Token: 0x040034B4 RID: 13492
		internal static int __PropertyOffset_bRetarget;

		// Token: 0x040034B5 RID: 13493
		internal static byte __PropertyMask_bRetarget;

		// Token: 0x040034B6 RID: 13494
		internal static int __PropertyOffset_bActuallyFilterLinearKeys;

		// Token: 0x040034B7 RID: 13495
		internal static byte __PropertyMask_bActuallyFilterLinearKeys;
	}
}
