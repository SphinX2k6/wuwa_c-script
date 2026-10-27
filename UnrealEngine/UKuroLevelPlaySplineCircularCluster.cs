using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F1 RID: 6385
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlaySplineCircularCluster")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKuroLevelPlaySplineCircularCluster : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017ADE RID: 96990 RVA: 0x0022B36E File Offset: 0x0022956E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlaySplineCircularCluster._ClassPtr;
		}

		// Token: 0x06017ADF RID: 96991 RVA: 0x0022B37C File Offset: 0x0022957C
		public UKuroLevelPlaySplineCircularCluster() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySplineCircularCluster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017AE0 RID: 96992 RVA: 0x0022B3A4 File Offset: 0x002295A4
		public UKuroLevelPlaySplineCircularCluster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySplineCircularCluster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F67 RID: 24423
		// (get) Token: 0x06017AE1 RID: 96993 RVA: 0x0022B3D7 File Offset: 0x002295D7
		// (set) Token: 0x06017AE2 RID: 96994 RVA: 0x0022B3E7 File Offset: 0x002295E7
		public unsafe float DiffusionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlaySplineCircularCluster.__PropertyOffset_DiffusionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlaySplineCircularCluster.__PropertyOffset_DiffusionRadius) = value;
			}
		}

		// Token: 0x17005F68 RID: 24424
		// (get) Token: 0x06017AE3 RID: 96995 RVA: 0x0022B3F8 File Offset: 0x002295F8
		// (set) Token: 0x06017AE4 RID: 96996 RVA: 0x0022B431 File Offset: 0x00229631
		public TArray<FKuroLevelPlayCircle> Circles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelPlayCircle> result;
				if ((result = this._Circles) == null)
				{
					result = (this._Circles = new TArray<FKuroLevelPlayCircle>(base.NativePtr + (IntPtr)UKuroLevelPlaySplineCircularCluster.__PropertyOffset_Circles, this));
				}
				return result;
			}
			set
			{
				this.Circles.CopyAssign(value);
			}
		}

		// Token: 0x06017AE5 RID: 96997 RVA: 0x0022B43F File Offset: 0x0022963F
		static UKuroLevelPlaySplineCircularCluster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlaySplineCircularCluster");
		}

		// Token: 0x06017AE6 RID: 96998 RVA: 0x0022B44D File Offset: 0x0022964D
		protected UKuroLevelPlaySplineCircularCluster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDBC RID: 52668
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlaySplineCircularCluster";

		// Token: 0x0400CDBD RID: 52669
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDBE RID: 52670
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CDBF RID: 52671
		internal static int __PropertyOffset_DiffusionRadius;

		// Token: 0x0400CDC0 RID: 52672
		internal static int __PropertyOffset_Circles;

		// Token: 0x0400CDC1 RID: 52673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelPlayCircle> _Circles;
	}
}
