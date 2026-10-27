using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F8E RID: 8078
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeSplinesComponent")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class ULandscapeSplinesComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EAD9 RID: 125657 RVA: 0x002D99E4 File Offset: 0x002D7BE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeSplinesComponent._ClassPtr;
		}

		// Token: 0x0601EADA RID: 125658 RVA: 0x002D99F0 File Offset: 0x002D7BF0
		public ULandscapeSplinesComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeSplinesComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EADB RID: 125659 RVA: 0x002D9A18 File Offset: 0x002D7C18
		public ULandscapeSplinesComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeSplinesComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A35 RID: 31285
		// (get) Token: 0x0601EADC RID: 125660 RVA: 0x002D9A4C File Offset: 0x002D7C4C
		// (set) Token: 0x0601EADD RID: 125661 RVA: 0x002D9A85 File Offset: 0x002D7C85
		public TArray<ULandscapeSplineControlPoint> ControlPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeSplineControlPoint> result;
				if ((result = this._ControlPoints) == null)
				{
					result = (this._ControlPoints = new TArray<ULandscapeSplineControlPoint>(base.NativePtr + (IntPtr)ULandscapeSplinesComponent.__PropertyOffset_ControlPoints, this));
				}
				return result;
			}
			set
			{
				this.ControlPoints.CopyAssign(value);
			}
		}

		// Token: 0x17007A36 RID: 31286
		// (get) Token: 0x0601EADE RID: 125662 RVA: 0x002D9A94 File Offset: 0x002D7C94
		// (set) Token: 0x0601EADF RID: 125663 RVA: 0x002D9ACD File Offset: 0x002D7CCD
		public TArray<ULandscapeSplineSegment> Segments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeSplineSegment> result;
				if ((result = this._Segments) == null)
				{
					result = (this._Segments = new TArray<ULandscapeSplineSegment>(base.NativePtr + (IntPtr)ULandscapeSplinesComponent.__PropertyOffset_Segments, this));
				}
				return result;
			}
			set
			{
				this.Segments.CopyAssign(value);
			}
		}

		// Token: 0x17007A37 RID: 31287
		// (get) Token: 0x0601EAE0 RID: 125664 RVA: 0x002D9ADC File Offset: 0x002D7CDC
		// (set) Token: 0x0601EAE1 RID: 125665 RVA: 0x002D9B15 File Offset: 0x002D7D15
		public TArray<UMeshComponent> CookedForeignMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMeshComponent> result;
				if ((result = this._CookedForeignMeshComponents) == null)
				{
					result = (this._CookedForeignMeshComponents = new TArray<UMeshComponent>(base.NativePtr + (IntPtr)ULandscapeSplinesComponent.__PropertyOffset_CookedForeignMeshComponents, this));
				}
				return result;
			}
			set
			{
				this.CookedForeignMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601EAE2 RID: 125666 RVA: 0x002D9B24 File Offset: 0x002D7D24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<USplineMeshComponent> GetSplineMeshComponents()
		{
			ULandscapeSplinesComponent.__GetSplineMeshComponents_FunctionParams* ptr = stackalloc ULandscapeSplinesComponent.__GetSplineMeshComponents_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ULandscapeSplinesComponent.__GetSplineMeshComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ULandscapeSplinesComponent.__GetSplineMeshComponents_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ULandscapeSplinesComponent.__GetSplineMeshComponents_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USplineMeshComponent> result = new TArray<USplineMeshComponent>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(ULandscapeSplinesComponent.__GetSplineMeshComponents_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601EAE3 RID: 125667 RVA: 0x002D9B83 File Offset: 0x002D7D83
		static ULandscapeSplinesComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeSplinesComponent");
		}

		// Token: 0x0601EAE4 RID: 125668 RVA: 0x002D9B91 File Offset: 0x002D7D91
		protected ULandscapeSplinesComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010958 RID: 67928
		public new const string __ObjectPath = "/Script/Landscape.LandscapeSplinesComponent";

		// Token: 0x04010959 RID: 67929
		private static IntPtr _ClassPtr;

		// Token: 0x0401095A RID: 67930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401095B RID: 67931
		internal static int __PropertyOffset_ControlPoints;

		// Token: 0x0401095C RID: 67932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeSplineControlPoint> _ControlPoints;

		// Token: 0x0401095D RID: 67933
		internal static int __PropertyOffset_Segments;

		// Token: 0x0401095E RID: 67934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeSplineSegment> _Segments;

		// Token: 0x0401095F RID: 67935
		internal static int __PropertyOffset_CookedForeignMeshComponents;

		// Token: 0x04010960 RID: 67936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMeshComponent> _CookedForeignMeshComponents;

		// Token: 0x04010961 RID: 67937
		private static IntPtr __GetSplineMeshComponents_NativeFunctionPtr;

		// Token: 0x0200341C RID: 13340
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSplineMeshComponents_FunctionParams
		{
			// Token: 0x040173F5 RID: 95221
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
