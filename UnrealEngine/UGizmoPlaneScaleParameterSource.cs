using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001560 RID: 5472
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoPlaneScaleParameterSource")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UGizmoPlaneScaleParameterSource : UGizmoBaseVec2ParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D2A RID: 81194 RVA: 0x001D1B7A File Offset: 0x001CFD7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoPlaneScaleParameterSource._ClassPtr;
		}

		// Token: 0x06013D2B RID: 81195 RVA: 0x001D1B88 File Offset: 0x001CFD88
		public UGizmoPlaneScaleParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoPlaneScaleParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D2C RID: 81196 RVA: 0x001D1BB0 File Offset: 0x001CFDB0
		[NullableContext(1)]
		public UGizmoPlaneScaleParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoPlaneScaleParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DA0 RID: 19872
		// (get) Token: 0x06013D2D RID: 81197 RVA: 0x001D1BE3 File Offset: 0x001CFDE3
		// (set) Token: 0x06013D2E RID: 81198 RVA: 0x001D1BFD File Offset: 0x001CFDFD
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DA1 RID: 19873
		// (get) Token: 0x06013D2F RID: 81199 RVA: 0x001D1C23 File Offset: 0x001CFE23
		// (set) Token: 0x06013D30 RID: 81200 RVA: 0x001D1C3D File Offset: 0x001CFE3D
		public unsafe IGizmoTransformSource TransformSource
		{
			get
			{
				return (IGizmoTransformSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_TransformSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_TransformSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DA2 RID: 19874
		// (get) Token: 0x06013D31 RID: 81201 RVA: 0x001D1C63 File Offset: 0x001CFE63
		// (set) Token: 0x06013D32 RID: 81202 RVA: 0x001D1C73 File Offset: 0x001CFE73
		public unsafe float ScaleMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_ScaleMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_ScaleMultiplier) = value;
			}
		}

		// Token: 0x17004DA3 RID: 19875
		// (get) Token: 0x06013D33 RID: 81203 RVA: 0x001D1C84 File Offset: 0x001CFE84
		// (set) Token: 0x06013D34 RID: 81204 RVA: 0x001D1C98 File Offset: 0x001CFE98
		public unsafe FVector2D Parameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_Parameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_Parameter) = value;
			}
		}

		// Token: 0x17004DA4 RID: 19876
		// (get) Token: 0x06013D35 RID: 81205 RVA: 0x001D1CB0 File Offset: 0x001CFEB0
		// (set) Token: 0x06013D36 RID: 81206 RVA: 0x001D1CE9 File Offset: 0x001CFEE9
		[Nullable(1)]
		public FGizmoVec2ParameterChange LastChange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGizmoVec2ParameterChange result;
				if ((result = this._LastChange) == null)
				{
					result = (this._LastChange = new FGizmoVec2ParameterChange(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoVec2ParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004DA5 RID: 19877
		// (get) Token: 0x06013D37 RID: 81207 RVA: 0x001D1D0A File Offset: 0x001CFF0A
		// (set) Token: 0x06013D38 RID: 81208 RVA: 0x001D1D1E File Offset: 0x001CFF1E
		public unsafe FVector CurScaleOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleOrigin) = value;
			}
		}

		// Token: 0x17004DA6 RID: 19878
		// (get) Token: 0x06013D39 RID: 81209 RVA: 0x001D1D33 File Offset: 0x001CFF33
		// (set) Token: 0x06013D3A RID: 81210 RVA: 0x001D1D47 File Offset: 0x001CFF47
		public unsafe FVector CurScaleNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleNormal) = value;
			}
		}

		// Token: 0x17004DA7 RID: 19879
		// (get) Token: 0x06013D3B RID: 81211 RVA: 0x001D1D5C File Offset: 0x001CFF5C
		// (set) Token: 0x06013D3C RID: 81212 RVA: 0x001D1D70 File Offset: 0x001CFF70
		public unsafe FVector CurScaleAxisX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleAxisX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleAxisX) = value;
			}
		}

		// Token: 0x17004DA8 RID: 19880
		// (get) Token: 0x06013D3D RID: 81213 RVA: 0x001D1D85 File Offset: 0x001CFF85
		// (set) Token: 0x06013D3E RID: 81214 RVA: 0x001D1D99 File Offset: 0x001CFF99
		public unsafe FVector CurScaleAxisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleAxisY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_CurScaleAxisY) = value;
			}
		}

		// Token: 0x17004DA9 RID: 19881
		// (get) Token: 0x06013D3F RID: 81215 RVA: 0x001D1DAE File Offset: 0x001CFFAE
		// (set) Token: 0x06013D40 RID: 81216 RVA: 0x001D1DC2 File Offset: 0x001CFFC2
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneScaleParameterSource.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x06013D41 RID: 81217 RVA: 0x001D1DD7 File Offset: 0x001CFFD7
		static UGizmoPlaneScaleParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoPlaneScaleParameterSource");
		}

		// Token: 0x06013D42 RID: 81218 RVA: 0x001D1DE5 File Offset: 0x001CFFE5
		protected UGizmoPlaneScaleParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB97 RID: 43927
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoPlaneScaleParameterSource";

		// Token: 0x0400AB98 RID: 43928
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB99 RID: 43929
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB9A RID: 43930
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400AB9B RID: 43931
		internal static int __PropertyOffset_TransformSource;

		// Token: 0x0400AB9C RID: 43932
		internal static int __PropertyOffset_ScaleMultiplier;

		// Token: 0x0400AB9D RID: 43933
		internal static int __PropertyOffset_Parameter;

		// Token: 0x0400AB9E RID: 43934
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400AB9F RID: 43935
		private FGizmoVec2ParameterChange _LastChange;

		// Token: 0x0400ABA0 RID: 43936
		internal static int __PropertyOffset_CurScaleOrigin;

		// Token: 0x0400ABA1 RID: 43937
		internal static int __PropertyOffset_CurScaleNormal;

		// Token: 0x0400ABA2 RID: 43938
		internal static int __PropertyOffset_CurScaleAxisX;

		// Token: 0x0400ABA3 RID: 43939
		internal static int __PropertyOffset_CurScaleAxisY;

		// Token: 0x0400ABA4 RID: 43940
		internal static int __PropertyOffset_InitialTransform;
	}
}
