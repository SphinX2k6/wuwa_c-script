using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014DA RID: 5338
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputSplineComponent")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UHoudiniInputSplineComponent : UHoudiniInputSceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601355A RID: 79194 RVA: 0x001C6D8E File Offset: 0x001C4F8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputSplineComponent._ClassPtr;
		}

		// Token: 0x0601355B RID: 79195 RVA: 0x001C6D9C File Offset: 0x001C4F9C
		public UHoudiniInputSplineComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601355C RID: 79196 RVA: 0x001C6DC4 File Offset: 0x001C4FC4
		public UHoudiniInputSplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B5E RID: 19294
		// (get) Token: 0x0601355D RID: 79197 RVA: 0x001C6DF7 File Offset: 0x001C4FF7
		// (set) Token: 0x0601355E RID: 79198 RVA: 0x001C6E07 File Offset: 0x001C5007
		public unsafe int NumberOfSplineControlPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_NumberOfSplineControlPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_NumberOfSplineControlPoints) = value;
			}
		}

		// Token: 0x17004B5F RID: 19295
		// (get) Token: 0x0601355F RID: 79199 RVA: 0x001C6E18 File Offset: 0x001C5018
		// (set) Token: 0x06013560 RID: 79200 RVA: 0x001C6E28 File Offset: 0x001C5028
		public unsafe float SplineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_SplineLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_SplineLength) = value;
			}
		}

		// Token: 0x17004B60 RID: 19296
		// (get) Token: 0x06013561 RID: 79201 RVA: 0x001C6E39 File Offset: 0x001C5039
		// (set) Token: 0x06013562 RID: 79202 RVA: 0x001C6E49 File Offset: 0x001C5049
		public unsafe float SplineResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_SplineResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_SplineResolution) = value;
			}
		}

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x06013563 RID: 79203 RVA: 0x001C6E5A File Offset: 0x001C505A
		// (set) Token: 0x06013564 RID: 79204 RVA: 0x001C6E6A File Offset: 0x001C506A
		public unsafe bool SplineClosed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_SplineClosed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_SplineClosed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x06013565 RID: 79205 RVA: 0x001C6E7C File Offset: 0x001C507C
		// (set) Token: 0x06013566 RID: 79206 RVA: 0x001C6EB5 File Offset: 0x001C50B5
		public TArray<FTransform> SplineControlPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._SplineControlPoints) == null)
				{
					result = (this._SplineControlPoints = new TArray<FTransform>(base.NativePtr + (IntPtr)UHoudiniInputSplineComponent.__PropertyOffset_SplineControlPoints, this));
				}
				return result;
			}
			set
			{
				this.SplineControlPoints.CopyAssign(value);
			}
		}

		// Token: 0x06013567 RID: 79207 RVA: 0x001C6EC3 File Offset: 0x001C50C3
		static UHoudiniInputSplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputSplineComponent");
		}

		// Token: 0x06013568 RID: 79208 RVA: 0x001C6ED1 File Offset: 0x001C50D1
		protected UHoudiniInputSplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A71B RID: 42779
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputSplineComponent";

		// Token: 0x0400A71C RID: 42780
		private static IntPtr _ClassPtr;

		// Token: 0x0400A71D RID: 42781
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A71E RID: 42782
		internal static int __PropertyOffset_NumberOfSplineControlPoints;

		// Token: 0x0400A71F RID: 42783
		internal static int __PropertyOffset_SplineLength;

		// Token: 0x0400A720 RID: 42784
		internal static int __PropertyOffset_SplineResolution;

		// Token: 0x0400A721 RID: 42785
		internal static int __PropertyOffset_SplineClosed;

		// Token: 0x0400A722 RID: 42786
		internal static int __PropertyOffset_SplineControlPoints;

		// Token: 0x0400A723 RID: 42787
		[Nullable(2)]
		private TArray<FTransform> _SplineControlPoints;
	}
}
