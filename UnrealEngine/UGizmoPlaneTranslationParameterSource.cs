using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001561 RID: 5473
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoPlaneTranslationParameterSource")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UGizmoPlaneTranslationParameterSource : UGizmoBaseVec2ParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D43 RID: 81219 RVA: 0x001D1DEE File Offset: 0x001CFFEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoPlaneTranslationParameterSource._ClassPtr;
		}

		// Token: 0x06013D44 RID: 81220 RVA: 0x001D1DFC File Offset: 0x001CFFFC
		public UGizmoPlaneTranslationParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoPlaneTranslationParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D45 RID: 81221 RVA: 0x001D1E24 File Offset: 0x001D0024
		[NullableContext(1)]
		public UGizmoPlaneTranslationParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoPlaneTranslationParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DAA RID: 19882
		// (get) Token: 0x06013D46 RID: 81222 RVA: 0x001D1E57 File Offset: 0x001D0057
		// (set) Token: 0x06013D47 RID: 81223 RVA: 0x001D1E71 File Offset: 0x001D0071
		public unsafe IGizmoAxisSource AxisSource
		{
			get
			{
				return (IGizmoAxisSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_AxisSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_AxisSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DAB RID: 19883
		// (get) Token: 0x06013D48 RID: 81224 RVA: 0x001D1E97 File Offset: 0x001D0097
		// (set) Token: 0x06013D49 RID: 81225 RVA: 0x001D1EB1 File Offset: 0x001D00B1
		public unsafe IGizmoTransformSource TransformSource
		{
			get
			{
				return (IGizmoTransformSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_TransformSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_TransformSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004DAC RID: 19884
		// (get) Token: 0x06013D4A RID: 81226 RVA: 0x001D1ED7 File Offset: 0x001D00D7
		// (set) Token: 0x06013D4B RID: 81227 RVA: 0x001D1EEB File Offset: 0x001D00EB
		public unsafe FVector2D Parameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_Parameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_Parameter) = value;
			}
		}

		// Token: 0x17004DAD RID: 19885
		// (get) Token: 0x06013D4C RID: 81228 RVA: 0x001D1F00 File Offset: 0x001D0100
		// (set) Token: 0x06013D4D RID: 81229 RVA: 0x001D1F39 File Offset: 0x001D0139
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
					result = (this._LastChange = new FGizmoVec2ParameterChange(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_LastChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGizmoVec2ParameterChange.StaticStruct(), base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_LastChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004DAE RID: 19886
		// (get) Token: 0x06013D4E RID: 81230 RVA: 0x001D1F5A File Offset: 0x001D015A
		// (set) Token: 0x06013D4F RID: 81231 RVA: 0x001D1F6E File Offset: 0x001D016E
		public unsafe FVector CurTranslationOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationOrigin) = value;
			}
		}

		// Token: 0x17004DAF RID: 19887
		// (get) Token: 0x06013D50 RID: 81232 RVA: 0x001D1F83 File Offset: 0x001D0183
		// (set) Token: 0x06013D51 RID: 81233 RVA: 0x001D1F97 File Offset: 0x001D0197
		public unsafe FVector CurTranslationNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationNormal) = value;
			}
		}

		// Token: 0x17004DB0 RID: 19888
		// (get) Token: 0x06013D52 RID: 81234 RVA: 0x001D1FAC File Offset: 0x001D01AC
		// (set) Token: 0x06013D53 RID: 81235 RVA: 0x001D1FC0 File Offset: 0x001D01C0
		public unsafe FVector CurTranslationAxisX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationAxisX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationAxisX) = value;
			}
		}

		// Token: 0x17004DB1 RID: 19889
		// (get) Token: 0x06013D54 RID: 81236 RVA: 0x001D1FD5 File Offset: 0x001D01D5
		// (set) Token: 0x06013D55 RID: 81237 RVA: 0x001D1FE9 File Offset: 0x001D01E9
		public unsafe FVector CurTranslationAxisY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationAxisY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_CurTranslationAxisY) = value;
			}
		}

		// Token: 0x17004DB2 RID: 19890
		// (get) Token: 0x06013D56 RID: 81238 RVA: 0x001D1FFE File Offset: 0x001D01FE
		// (set) Token: 0x06013D57 RID: 81239 RVA: 0x001D2012 File Offset: 0x001D0212
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoPlaneTranslationParameterSource.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x06013D58 RID: 81240 RVA: 0x001D2027 File Offset: 0x001D0227
		static UGizmoPlaneTranslationParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoPlaneTranslationParameterSource");
		}

		// Token: 0x06013D59 RID: 81241 RVA: 0x001D2035 File Offset: 0x001D0235
		protected UGizmoPlaneTranslationParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABA5 RID: 43941
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoPlaneTranslationParameterSource";

		// Token: 0x0400ABA6 RID: 43942
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABA7 RID: 43943
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABA8 RID: 43944
		internal static int __PropertyOffset_AxisSource;

		// Token: 0x0400ABA9 RID: 43945
		internal static int __PropertyOffset_TransformSource;

		// Token: 0x0400ABAA RID: 43946
		internal static int __PropertyOffset_Parameter;

		// Token: 0x0400ABAB RID: 43947
		internal static int __PropertyOffset_LastChange;

		// Token: 0x0400ABAC RID: 43948
		private FGizmoVec2ParameterChange _LastChange;

		// Token: 0x0400ABAD RID: 43949
		internal static int __PropertyOffset_CurTranslationOrigin;

		// Token: 0x0400ABAE RID: 43950
		internal static int __PropertyOffset_CurTranslationNormal;

		// Token: 0x0400ABAF RID: 43951
		internal static int __PropertyOffset_CurTranslationAxisX;

		// Token: 0x0400ABB0 RID: 43952
		internal static int __PropertyOffset_CurTranslationAxisY;

		// Token: 0x0400ABB1 RID: 43953
		internal static int __PropertyOffset_InitialTransform;
	}
}
