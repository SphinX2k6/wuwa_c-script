using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001547 RID: 5447
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoAxisScaleParameterSource")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UGizmoAxisScaleParameterSource : UGizmoBaseFloatParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C36 RID: 80950 RVA: 0x001D0550 File Offset: 0x001CE750
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoAxisScaleParameterSource._ClassPtr;
		}

		// Token: 0x06013C37 RID: 80951 RVA: 0x001D055C File Offset: 0x001CE75C
		public UGizmoAxisScaleParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisScaleParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C38 RID: 80952 RVA: 0x001D0584 File Offset: 0x001CE784
		[NullableContext(1)]
		public UGizmoAxisScaleParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisScaleParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D6A RID: 19818
		// (get) Token: 0x06013C39 RID: 80953 RVA: 0x001D05B7 File Offset: 0x001CE7B7
		// (set) Token: 0x06013C3A RID: 80954 RVA: 0x001D05D1 File Offset: 0x001CE7D1
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D6B RID: 19819
		// (get) Token: 0x06013C3B RID: 80955 RVA: 0x001D05F7 File Offset: 0x001CE7F7
		// (set) Token: 0x06013C3C RID: 80956 RVA: 0x001D0611 File Offset: 0x001CE811
		public unsafe IGizmoTransformSource TransformSource
		{
			get
			{
				return (IGizmoTransformSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_TransformSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_TransformSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D6C RID: 19820
		// (get) Token: 0x06013C3D RID: 80957 RVA: 0x001D0637 File Offset: 0x001CE837
		// (set) Token: 0x06013C3E RID: 80958 RVA: 0x001D0647 File Offset: 0x001CE847
		public unsafe float ScaleMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_ScaleMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_ScaleMultiplier) = value;
			}
		}

		// Token: 0x17004D6D RID: 19821
		// (get) Token: 0x06013C3F RID: 80959 RVA: 0x001D0658 File Offset: 0x001CE858
		// (set) Token: 0x06013C40 RID: 80960 RVA: 0x001D0668 File Offset: 0x001CE868
		public unsafe float Parameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_Parameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_Parameter) = value;
			}
		}

		// Token: 0x17004D6E RID: 19822
		// (get) Token: 0x06013C41 RID: 80961 RVA: 0x001D067C File Offset: 0x001CE87C
		// (set) Token: 0x06013C42 RID: 80962 RVA: 0x001D06B5 File Offset: 0x001CE8B5
		[Nullable(1)]
		public FGizmoFloatParameterChange LastChange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGizmoFloatParameterChange result;
				if ((result = this._LastChange) == null)
				{
					result = (this._LastChange = new FGizmoFloatParameterChange(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoFloatParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D6F RID: 19823
		// (get) Token: 0x06013C43 RID: 80963 RVA: 0x001D06D6 File Offset: 0x001CE8D6
		// (set) Token: 0x06013C44 RID: 80964 RVA: 0x001D06EA File Offset: 0x001CE8EA
		public unsafe FVector CurScaleAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_CurScaleAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_CurScaleAxis) = value;
			}
		}

		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x06013C45 RID: 80965 RVA: 0x001D06FF File Offset: 0x001CE8FF
		// (set) Token: 0x06013C46 RID: 80966 RVA: 0x001D0713 File Offset: 0x001CE913
		public unsafe FVector CurScaleOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_CurScaleOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_CurScaleOrigin) = value;
			}
		}

		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x06013C47 RID: 80967 RVA: 0x001D0728 File Offset: 0x001CE928
		// (set) Token: 0x06013C48 RID: 80968 RVA: 0x001D073C File Offset: 0x001CE93C
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisScaleParameterSource.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x06013C49 RID: 80969 RVA: 0x001D0751 File Offset: 0x001CE951
		static UGizmoAxisScaleParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoAxisScaleParameterSource");
		}

		// Token: 0x06013C4A RID: 80970 RVA: 0x001D075F File Offset: 0x001CE95F
		protected UGizmoAxisScaleParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB10 RID: 43792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoAxisScaleParameterSource";

		// Token: 0x0400AB11 RID: 43793
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB12 RID: 43794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB13 RID: 43795
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400AB14 RID: 43796
		internal static int __PropertyOffset_TransformSource;

		// Token: 0x0400AB15 RID: 43797
		internal static int __PropertyOffset_ScaleMultiplier;

		// Token: 0x0400AB16 RID: 43798
		internal static int __PropertyOffset_Parameter;

		// Token: 0x0400AB17 RID: 43799
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400AB18 RID: 43800
		private FGizmoFloatParameterChange _LastChange;

		// Token: 0x0400AB19 RID: 43801
		internal static int __PropertyOffset_CurScaleAxis;

		// Token: 0x0400AB1A RID: 43802
		internal static int __PropertyOffset_CurScaleOrigin;

		// Token: 0x0400AB1B RID: 43803
		internal static int __PropertyOffset_InitialTransform;
	}
}
