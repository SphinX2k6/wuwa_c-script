using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001568 RID: 5480
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoUniformScaleParameterSource")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UGizmoUniformScaleParameterSource : UGizmoBaseVec2ParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D8B RID: 81291 RVA: 0x001D24C2 File Offset: 0x001D06C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoUniformScaleParameterSource._ClassPtr;
		}

		// Token: 0x06013D8C RID: 81292 RVA: 0x001D24D0 File Offset: 0x001D06D0
		public UGizmoUniformScaleParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoUniformScaleParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D8D RID: 81293 RVA: 0x001D24F8 File Offset: 0x001D06F8
		[NullableContext(1)]
		public UGizmoUniformScaleParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoUniformScaleParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DBE RID: 19902
		// (get) Token: 0x06013D8E RID: 81294 RVA: 0x001D252B File Offset: 0x001D072B
		// (set) Token: 0x06013D8F RID: 81295 RVA: 0x001D2545 File Offset: 0x001D0745
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DBF RID: 19903
		// (get) Token: 0x06013D90 RID: 81296 RVA: 0x001D256B File Offset: 0x001D076B
		// (set) Token: 0x06013D91 RID: 81297 RVA: 0x001D2585 File Offset: 0x001D0785
		public unsafe IGizmoTransformSource TransformSource
		{
			get
			{
				return (IGizmoTransformSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_TransformSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_TransformSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DC0 RID: 19904
		// (get) Token: 0x06013D92 RID: 81298 RVA: 0x001D25AB File Offset: 0x001D07AB
		// (set) Token: 0x06013D93 RID: 81299 RVA: 0x001D25BB File Offset: 0x001D07BB
		public unsafe float ScaleMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_ScaleMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_ScaleMultiplier) = value;
			}
		}

		// Token: 0x17004DC1 RID: 19905
		// (get) Token: 0x06013D94 RID: 81300 RVA: 0x001D25CC File Offset: 0x001D07CC
		// (set) Token: 0x06013D95 RID: 81301 RVA: 0x001D25E0 File Offset: 0x001D07E0
		public unsafe FVector2D Parameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_Parameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_Parameter) = value;
			}
		}

		// Token: 0x17004DC2 RID: 19906
		// (get) Token: 0x06013D96 RID: 81302 RVA: 0x001D25F8 File Offset: 0x001D07F8
		// (set) Token: 0x06013D97 RID: 81303 RVA: 0x001D2631 File Offset: 0x001D0831
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
					result = (this._LastChange = new FGizmoVec2ParameterChange(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoVec2ParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x06013D98 RID: 81304 RVA: 0x001D2652 File Offset: 0x001D0852
		// (set) Token: 0x06013D99 RID: 81305 RVA: 0x001D2666 File Offset: 0x001D0866
		public unsafe FVector CurScaleOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleOrigin) = value;
			}
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x06013D9A RID: 81306 RVA: 0x001D267B File Offset: 0x001D087B
		// (set) Token: 0x06013D9B RID: 81307 RVA: 0x001D268F File Offset: 0x001D088F
		public unsafe FVector CurScaleNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleNormal) = value;
			}
		}

		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x06013D9C RID: 81308 RVA: 0x001D26A4 File Offset: 0x001D08A4
		// (set) Token: 0x06013D9D RID: 81309 RVA: 0x001D26B8 File Offset: 0x001D08B8
		public unsafe FVector CurScaleAxisX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleAxisX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleAxisX) = value;
			}
		}

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x06013D9E RID: 81310 RVA: 0x001D26CD File Offset: 0x001D08CD
		// (set) Token: 0x06013D9F RID: 81311 RVA: 0x001D26E1 File Offset: 0x001D08E1
		public unsafe FVector CurScaleAxisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleAxisY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_CurScaleAxisY) = value;
			}
		}

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x06013DA0 RID: 81312 RVA: 0x001D26F6 File Offset: 0x001D08F6
		// (set) Token: 0x06013DA1 RID: 81313 RVA: 0x001D270A File Offset: 0x001D090A
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoUniformScaleParameterSource.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x06013DA2 RID: 81314 RVA: 0x001D271F File Offset: 0x001D091F
		static UGizmoUniformScaleParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoUniformScaleParameterSource");
		}

		// Token: 0x06013DA3 RID: 81315 RVA: 0x001D272D File Offset: 0x001D092D
		protected UGizmoUniformScaleParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABCC RID: 43980
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoUniformScaleParameterSource";

		// Token: 0x0400ABCD RID: 43981
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABCE RID: 43982
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABCF RID: 43983
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400ABD0 RID: 43984
		internal static int __PropertyOffset_TransformSource;

		// Token: 0x0400ABD1 RID: 43985
		internal static int __PropertyOffset_ScaleMultiplier;

		// Token: 0x0400ABD2 RID: 43986
		internal static int __PropertyOffset_Parameter;

		// Token: 0x0400ABD3 RID: 43987
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400ABD4 RID: 43988
		private FGizmoVec2ParameterChange _LastChange;

		// Token: 0x0400ABD5 RID: 43989
		internal static int __PropertyOffset_CurScaleOrigin;

		// Token: 0x0400ABD6 RID: 43990
		internal static int __PropertyOffset_CurScaleNormal;

		// Token: 0x0400ABD7 RID: 43991
		internal static int __PropertyOffset_CurScaleAxisX;

		// Token: 0x0400ABD8 RID: 43992
		internal static int __PropertyOffset_CurScaleAxisY;

		// Token: 0x0400ABD9 RID: 43993
		internal static int __PropertyOffset_InitialTransform;
	}
}
