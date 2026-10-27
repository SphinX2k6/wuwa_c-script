using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001546 RID: 5446
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoAxisRotationParameterSource")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UGizmoAxisRotationParameterSource : UGizmoBaseFloatParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C23 RID: 80931 RVA: 0x001D035C File Offset: 0x001CE55C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoAxisRotationParameterSource._ClassPtr;
		}

		// Token: 0x06013C24 RID: 80932 RVA: 0x001D0368 File Offset: 0x001CE568
		public UGizmoAxisRotationParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisRotationParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C25 RID: 80933 RVA: 0x001D0390 File Offset: 0x001CE590
		[NullableContext(1)]
		public UGizmoAxisRotationParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisRotationParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x06013C26 RID: 80934 RVA: 0x001D03C3 File Offset: 0x001CE5C3
		// (set) Token: 0x06013C27 RID: 80935 RVA: 0x001D03DD File Offset: 0x001CE5DD
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x06013C28 RID: 80936 RVA: 0x001D0403 File Offset: 0x001CE603
		// (set) Token: 0x06013C29 RID: 80937 RVA: 0x001D041D File Offset: 0x001CE61D
		public unsafe IGizmoTransformSource TransformSource
		{
			get
			{
				return (IGizmoTransformSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_TransformSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_TransformSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x06013C2A RID: 80938 RVA: 0x001D0443 File Offset: 0x001CE643
		// (set) Token: 0x06013C2B RID: 80939 RVA: 0x001D0453 File Offset: 0x001CE653
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x17004D66 RID: 19814
		// (get) Token: 0x06013C2C RID: 80940 RVA: 0x001D0464 File Offset: 0x001CE664
		// (set) Token: 0x06013C2D RID: 80941 RVA: 0x001D049D File Offset: 0x001CE69D
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
					result = (this._LastChange = new FGizmoFloatParameterChange(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoFloatParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D67 RID: 19815
		// (get) Token: 0x06013C2E RID: 80942 RVA: 0x001D04BE File Offset: 0x001CE6BE
		// (set) Token: 0x06013C2F RID: 80943 RVA: 0x001D04D2 File Offset: 0x001CE6D2
		public unsafe FVector CurRotationAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_CurRotationAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_CurRotationAxis) = value;
			}
		}

		// Token: 0x17004D68 RID: 19816
		// (get) Token: 0x06013C30 RID: 80944 RVA: 0x001D04E7 File Offset: 0x001CE6E7
		// (set) Token: 0x06013C31 RID: 80945 RVA: 0x001D04FB File Offset: 0x001CE6FB
		public unsafe FVector CurRotationOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_CurRotationOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_CurRotationOrigin) = value;
			}
		}

		// Token: 0x17004D69 RID: 19817
		// (get) Token: 0x06013C32 RID: 80946 RVA: 0x001D0510 File Offset: 0x001CE710
		// (set) Token: 0x06013C33 RID: 80947 RVA: 0x001D0524 File Offset: 0x001CE724
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisRotationParameterSource.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x06013C34 RID: 80948 RVA: 0x001D0539 File Offset: 0x001CE739
		static UGizmoAxisRotationParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoAxisRotationParameterSource");
		}

		// Token: 0x06013C35 RID: 80949 RVA: 0x001D0547 File Offset: 0x001CE747
		protected UGizmoAxisRotationParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB05 RID: 43781
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoAxisRotationParameterSource";

		// Token: 0x0400AB06 RID: 43782
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB07 RID: 43783
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB08 RID: 43784
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400AB09 RID: 43785
		internal static int __PropertyOffset_TransformSource;

		// Token: 0x0400AB0A RID: 43786
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400AB0B RID: 43787
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400AB0C RID: 43788
		private FGizmoFloatParameterChange _LastChange;

		// Token: 0x0400AB0D RID: 43789
		internal static int __PropertyOffset_CurRotationAxis;

		// Token: 0x0400AB0E RID: 43790
		internal static int __PropertyOffset_CurRotationOrigin;

		// Token: 0x0400AB0F RID: 43791
		internal static int __PropertyOffset_InitialTransform;
	}
}
