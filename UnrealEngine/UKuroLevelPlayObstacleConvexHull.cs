using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018EF RID: 6383
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayObstacleConvexHull")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroLevelPlayObstacleConvexHull : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017AC5 RID: 96965 RVA: 0x0022B16C File Offset: 0x0022936C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayObstacleConvexHull._ClassPtr;
		}

		// Token: 0x06017AC6 RID: 96966 RVA: 0x0022B178 File Offset: 0x00229378
		public UKuroLevelPlayObstacleConvexHull() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayObstacleConvexHull.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017AC7 RID: 96967 RVA: 0x0022B1A0 File Offset: 0x002293A0
		public UKuroLevelPlayObstacleConvexHull(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayObstacleConvexHull.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F61 RID: 24417
		// (get) Token: 0x06017AC8 RID: 96968 RVA: 0x0022B1D3 File Offset: 0x002293D3
		// (set) Token: 0x06017AC9 RID: 96969 RVA: 0x0022B1E7 File Offset: 0x002293E7
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayObstacleConvexHull.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayObstacleConvexHull.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17005F62 RID: 24418
		// (get) Token: 0x06017ACA RID: 96970 RVA: 0x0022B1FC File Offset: 0x002293FC
		// (set) Token: 0x06017ACB RID: 96971 RVA: 0x0022B210 File Offset: 0x00229410
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayObstacleConvexHull.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayObstacleConvexHull.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x17005F63 RID: 24419
		// (get) Token: 0x06017ACC RID: 96972 RVA: 0x0022B228 File Offset: 0x00229428
		// (set) Token: 0x06017ACD RID: 96973 RVA: 0x0022B261 File Offset: 0x00229461
		public TArray<FVector2D> ConvexHullPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._ConvexHullPoints) == null)
				{
					result = (this._ConvexHullPoints = new TArray<FVector2D>(base.NativePtr + (IntPtr)UKuroLevelPlayObstacleConvexHull.__PropertyOffset_ConvexHullPoints, this));
				}
				return result;
			}
			set
			{
				this.ConvexHullPoints.CopyAssign(value);
			}
		}

		// Token: 0x06017ACE RID: 96974 RVA: 0x0022B26F File Offset: 0x0022946F
		static UKuroLevelPlayObstacleConvexHull()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayObstacleConvexHull");
		}

		// Token: 0x06017ACF RID: 96975 RVA: 0x0022B27D File Offset: 0x0022947D
		protected UKuroLevelPlayObstacleConvexHull(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDB0 RID: 52656
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayObstacleConvexHull";

		// Token: 0x0400CDB1 RID: 52657
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDB2 RID: 52658
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CDB3 RID: 52659
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400CDB4 RID: 52660
		internal static int __PropertyOffset_Origin;

		// Token: 0x0400CDB5 RID: 52661
		internal static int __PropertyOffset_ConvexHullPoints;

		// Token: 0x0400CDB6 RID: 52662
		[Nullable(2)]
		private TArray<FVector2D> _ConvexHullPoints;
	}
}
