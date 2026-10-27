using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D5 RID: 2517
	[UnrealObjectPath("/Script/Engine.DistributionVectorUniform")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UDistributionVectorUniform : UDistributionVector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E4B RID: 36427 RVA: 0x000CB6FA File Offset: 0x000C98FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionVectorUniform._ClassPtr;
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x000CB708 File Offset: 0x000C9908
		public UDistributionVectorUniform() : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorUniform.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x000CB730 File Offset: 0x000C9930
		[NullableContext(1)]
		public UDistributionVectorUniform(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorUniform.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06008E4E RID: 36430 RVA: 0x000CB763 File Offset: 0x000C9963
		// (set) Token: 0x06008E4F RID: 36431 RVA: 0x000CB777 File Offset: 0x000C9977
		public unsafe FVector Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06008E50 RID: 36432 RVA: 0x000CB78C File Offset: 0x000C998C
		// (set) Token: 0x06008E51 RID: 36433 RVA: 0x000CB7A0 File Offset: 0x000C99A0
		public unsafe FVector Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06008E52 RID: 36434 RVA: 0x000CB7B5 File Offset: 0x000C99B5
		// (set) Token: 0x06008E53 RID: 36435 RVA: 0x000CB7CE File Offset: 0x000C99CE
		public unsafe bool bLockAxes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_bLockAxes) & UDistributionVectorUniform.__PropertyMask_bLockAxes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_bLockAxes) = ((*(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_bLockAxes) & ~UDistributionVectorUniform.__PropertyMask_bLockAxes) | (value ? UDistributionVectorUniform.__PropertyMask_bLockAxes : 0));
			}
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06008E54 RID: 36436 RVA: 0x000CB7FE File Offset: 0x000C99FE
		// (set) Token: 0x06008E55 RID: 36437 RVA: 0x000CB812 File Offset: 0x000C9A12
		public unsafe TEnumAsByte<EDistributionVectorLockFlags> LockedAxes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_LockedAxes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_LockedAxes) = value;
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06008E56 RID: 36438 RVA: 0x000CB828 File Offset: 0x000C9A28
		// (set) Token: 0x06008E57 RID: 36439 RVA: 0x000CB862 File Offset: 0x000C9A62
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TFixedArray<TEnumAsByte<EDistributionVectorMirrorFlags>> MirrorFlags
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TEnumAsByte<EDistributionVectorMirrorFlags>> result;
				if ((result = this._MirrorFlags) == null)
				{
					result = (this._MirrorFlags = new TFixedArray<TEnumAsByte<EDistributionVectorMirrorFlags>>(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_MirrorFlags, 3, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.MirrorFlags.CopyAssign(value);
			}
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06008E58 RID: 36440 RVA: 0x000CB870 File Offset: 0x000C9A70
		// (set) Token: 0x06008E59 RID: 36441 RVA: 0x000CB889 File Offset: 0x000C9A89
		public unsafe bool bUseExtremes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_bUseExtremes) & UDistributionVectorUniform.__PropertyMask_bUseExtremes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_bUseExtremes) = ((*(base.NativePtr + (IntPtr)UDistributionVectorUniform.__PropertyOffset_bUseExtremes) & ~UDistributionVectorUniform.__PropertyMask_bUseExtremes) | (value ? UDistributionVectorUniform.__PropertyMask_bUseExtremes : 0));
			}
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x000CB8B9 File Offset: 0x000C9AB9
		static UDistributionVectorUniform()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionVectorUniform");
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x000CB8C7 File Offset: 0x000C9AC7
		protected UDistributionVectorUniform(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043A3 RID: 17315
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionVectorUniform";

		// Token: 0x040043A4 RID: 17316
		private static IntPtr _ClassPtr;

		// Token: 0x040043A5 RID: 17317
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043A6 RID: 17318
		internal static int __PropertyOffset_Max;

		// Token: 0x040043A7 RID: 17319
		internal static int __PropertyOffset_Min;

		// Token: 0x040043A8 RID: 17320
		internal static int __PropertyOffset_bLockAxes;

		// Token: 0x040043A9 RID: 17321
		internal static byte __PropertyMask_bLockAxes;

		// Token: 0x040043AA RID: 17322
		internal static int __PropertyOffset_LockedAxes;

		// Token: 0x040043AB RID: 17323
		internal static int __PropertyOffset_MirrorFlags;

		// Token: 0x040043AC RID: 17324
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TFixedArray<TEnumAsByte<EDistributionVectorMirrorFlags>> _MirrorFlags;

		// Token: 0x040043AD RID: 17325
		internal static int __PropertyOffset_bUseExtremes;

		// Token: 0x040043AE RID: 17326
		internal static byte __PropertyMask_bUseExtremes;
	}
}
