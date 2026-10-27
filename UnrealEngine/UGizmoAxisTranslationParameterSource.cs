using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001549 RID: 5449
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoAxisTranslationParameterSource")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UGizmoAxisTranslationParameterSource : UGizmoBaseFloatParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C50 RID: 80976 RVA: 0x001D08AE File Offset: 0x001CEAAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoAxisTranslationParameterSource._ClassPtr;
		}

		// Token: 0x06013C51 RID: 80977 RVA: 0x001D08BC File Offset: 0x001CEABC
		public UGizmoAxisTranslationParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisTranslationParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C52 RID: 80978 RVA: 0x001D08E4 File Offset: 0x001CEAE4
		[NullableContext(1)]
		public UGizmoAxisTranslationParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisTranslationParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x06013C53 RID: 80979 RVA: 0x001D0917 File Offset: 0x001CEB17
		// (set) Token: 0x06013C54 RID: 80980 RVA: 0x001D0931 File Offset: 0x001CEB31
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x06013C55 RID: 80981 RVA: 0x001D0957 File Offset: 0x001CEB57
		// (set) Token: 0x06013C56 RID: 80982 RVA: 0x001D0971 File Offset: 0x001CEB71
		public unsafe IGizmoTransformSource TransformSource
		{
			get
			{
				return (IGizmoTransformSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_TransformSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_TransformSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D74 RID: 19828
		// (get) Token: 0x06013C57 RID: 80983 RVA: 0x001D0997 File Offset: 0x001CEB97
		// (set) Token: 0x06013C58 RID: 80984 RVA: 0x001D09A7 File Offset: 0x001CEBA7
		public unsafe float Parameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_Parameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_Parameter) = value;
			}
		}

		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x06013C59 RID: 80985 RVA: 0x001D09B8 File Offset: 0x001CEBB8
		// (set) Token: 0x06013C5A RID: 80986 RVA: 0x001D09F1 File Offset: 0x001CEBF1
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
					result = (this._LastChange = new FGizmoFloatParameterChange(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoFloatParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x06013C5B RID: 80987 RVA: 0x001D0A12 File Offset: 0x001CEC12
		// (set) Token: 0x06013C5C RID: 80988 RVA: 0x001D0A26 File Offset: 0x001CEC26
		public unsafe FVector CurTranslationAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_CurTranslationAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_CurTranslationAxis) = value;
			}
		}

		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x06013C5D RID: 80989 RVA: 0x001D0A3B File Offset: 0x001CEC3B
		// (set) Token: 0x06013C5E RID: 80990 RVA: 0x001D0A4F File Offset: 0x001CEC4F
		public unsafe FVector CurTranslationOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_CurTranslationOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_CurTranslationOrigin) = value;
			}
		}

		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x06013C5F RID: 80991 RVA: 0x001D0A64 File Offset: 0x001CEC64
		// (set) Token: 0x06013C60 RID: 80992 RVA: 0x001D0A78 File Offset: 0x001CEC78
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisTranslationParameterSource.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x06013C61 RID: 80993 RVA: 0x001D0A8D File Offset: 0x001CEC8D
		static UGizmoAxisTranslationParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoAxisTranslationParameterSource");
		}

		// Token: 0x06013C62 RID: 80994 RVA: 0x001D0A9B File Offset: 0x001CEC9B
		protected UGizmoAxisTranslationParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB1D RID: 43805
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoAxisTranslationParameterSource";

		// Token: 0x0400AB1E RID: 43806
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB1F RID: 43807
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB20 RID: 43808
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400AB21 RID: 43809
		internal static int __PropertyOffset_TransformSource;

		// Token: 0x0400AB22 RID: 43810
		internal static int __PropertyOffset_Parameter;

		// Token: 0x0400AB23 RID: 43811
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400AB24 RID: 43812
		private FGizmoFloatParameterChange _LastChange;

		// Token: 0x0400AB25 RID: 43813
		internal static int __PropertyOffset_CurTranslationAxis;

		// Token: 0x0400AB26 RID: 43814
		internal static int __PropertyOffset_CurTranslationOrigin;

		// Token: 0x0400AB27 RID: 43815
		internal static int __PropertyOffset_InitialTransform;
	}
}
