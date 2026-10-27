using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D6 RID: 2518
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DistributionVectorUniformCurve")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UDistributionVectorUniformCurve : UDistributionVector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E5C RID: 36444 RVA: 0x000CB8D0 File Offset: 0x000C9AD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionVectorUniformCurve._ClassPtr;
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x000CB8DC File Offset: 0x000C9ADC
		public UDistributionVectorUniformCurve() : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorUniformCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x000CB904 File Offset: 0x000C9B04
		public UDistributionVectorUniformCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorUniformCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x000CB938 File Offset: 0x000C9B38
		// (set) Token: 0x06008E60 RID: 36448 RVA: 0x000CB971 File Offset: 0x000C9B71
		public FInterpCurveTwoVectors ConstantCurve
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveTwoVectors result;
				if ((result = this._ConstantCurve) == null)
				{
					result = (this._ConstantCurve = new FInterpCurveTwoVectors(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_ConstantCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveTwoVectors.StaticStruct(), base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_ConstantCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06008E61 RID: 36449 RVA: 0x000CB992 File Offset: 0x000C9B92
		// (set) Token: 0x06008E62 RID: 36450 RVA: 0x000CB9AB File Offset: 0x000C9BAB
		public unsafe bool bLockAxes1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bLockAxes1) & UDistributionVectorUniformCurve.__PropertyMask_bLockAxes1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bLockAxes1) = ((*(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bLockAxes1) & ~UDistributionVectorUniformCurve.__PropertyMask_bLockAxes1) | (value ? UDistributionVectorUniformCurve.__PropertyMask_bLockAxes1 : 0));
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06008E63 RID: 36451 RVA: 0x000CB9DB File Offset: 0x000C9BDB
		// (set) Token: 0x06008E64 RID: 36452 RVA: 0x000CB9F4 File Offset: 0x000C9BF4
		public unsafe bool bLockAxes2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bLockAxes2) & UDistributionVectorUniformCurve.__PropertyMask_bLockAxes2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bLockAxes2) = ((*(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bLockAxes2) & ~UDistributionVectorUniformCurve.__PropertyMask_bLockAxes2) | (value ? UDistributionVectorUniformCurve.__PropertyMask_bLockAxes2 : 0));
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06008E65 RID: 36453 RVA: 0x000CBA24 File Offset: 0x000C9C24
		// (set) Token: 0x06008E66 RID: 36454 RVA: 0x000CBA5E File Offset: 0x000C9C5E
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TFixedArray<TEnumAsByte<EDistributionVectorLockFlags>> LockedAxes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TEnumAsByte<EDistributionVectorLockFlags>> result;
				if ((result = this._LockedAxes) == null)
				{
					result = (this._LockedAxes = new TFixedArray<TEnumAsByte<EDistributionVectorLockFlags>>(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_LockedAxes, 2, this));
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
				this.LockedAxes.CopyAssign(value);
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06008E67 RID: 36455 RVA: 0x000CBA6C File Offset: 0x000C9C6C
		// (set) Token: 0x06008E68 RID: 36456 RVA: 0x000CBAA6 File Offset: 0x000C9CA6
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
					result = (this._MirrorFlags = new TFixedArray<TEnumAsByte<EDistributionVectorMirrorFlags>>(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_MirrorFlags, 3, this));
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

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06008E69 RID: 36457 RVA: 0x000CBAB4 File Offset: 0x000C9CB4
		// (set) Token: 0x06008E6A RID: 36458 RVA: 0x000CBACD File Offset: 0x000C9CCD
		public unsafe bool bUseExtremes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bUseExtremes) & UDistributionVectorUniformCurve.__PropertyMask_bUseExtremes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bUseExtremes) = ((*(base.NativePtr + (IntPtr)UDistributionVectorUniformCurve.__PropertyOffset_bUseExtremes) & ~UDistributionVectorUniformCurve.__PropertyMask_bUseExtremes) | (value ? UDistributionVectorUniformCurve.__PropertyMask_bUseExtremes : 0));
			}
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x000CBAFD File Offset: 0x000C9CFD
		static UDistributionVectorUniformCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionVectorUniformCurve");
		}

		// Token: 0x06008E6C RID: 36460 RVA: 0x000CBB0B File Offset: 0x000C9D0B
		protected UDistributionVectorUniformCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043AF RID: 17327
		public new const string __ObjectPath = "/Script/Engine.DistributionVectorUniformCurve";

		// Token: 0x040043B0 RID: 17328
		private static IntPtr _ClassPtr;

		// Token: 0x040043B1 RID: 17329
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043B2 RID: 17330
		internal static int __PropertyOffset_ConstantCurve;

		// Token: 0x040043B3 RID: 17331
		[Nullable(2)]
		private FInterpCurveTwoVectors _ConstantCurve;

		// Token: 0x040043B4 RID: 17332
		internal static int __PropertyOffset_bLockAxes1;

		// Token: 0x040043B5 RID: 17333
		internal static byte __PropertyMask_bLockAxes1;

		// Token: 0x040043B6 RID: 17334
		internal static int __PropertyOffset_bLockAxes2;

		// Token: 0x040043B7 RID: 17335
		internal static byte __PropertyMask_bLockAxes2;

		// Token: 0x040043B8 RID: 17336
		internal static int __PropertyOffset_LockedAxes;

		// Token: 0x040043B9 RID: 17337
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TFixedArray<TEnumAsByte<EDistributionVectorLockFlags>> _LockedAxes;

		// Token: 0x040043BA RID: 17338
		internal static int __PropertyOffset_MirrorFlags;

		// Token: 0x040043BB RID: 17339
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TFixedArray<TEnumAsByte<EDistributionVectorMirrorFlags>> _MirrorFlags;

		// Token: 0x040043BC RID: 17340
		internal static int __PropertyOffset_bUseExtremes;

		// Token: 0x040043BD RID: 17341
		internal static byte __PropertyMask_bUseExtremes;
	}
}
