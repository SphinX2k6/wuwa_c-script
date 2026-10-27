using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001545 RID: 5445
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoAxisIntervalParameterSource")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UGizmoAxisIntervalParameterSource : UGizmoBaseFloatParameterSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C18 RID: 80920 RVA: 0x001D025A File Offset: 0x001CE45A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoAxisIntervalParameterSource._ClassPtr;
		}

		// Token: 0x06013C19 RID: 80921 RVA: 0x001D0268 File Offset: 0x001CE468
		public UGizmoAxisIntervalParameterSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisIntervalParameterSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C1A RID: 80922 RVA: 0x001D0290 File Offset: 0x001CE490
		[NullableContext(1)]
		public UGizmoAxisIntervalParameterSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoAxisIntervalParameterSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x06013C1B RID: 80923 RVA: 0x001D02C3 File Offset: 0x001CE4C3
		// (set) Token: 0x06013C1C RID: 80924 RVA: 0x001D02DD File Offset: 0x001CE4DD
		[Nullable(2)]
		public unsafe IGizmoFloatParameterSource FloatParameterSource
		{
			[NullableContext(2)]
			get
			{
				return (IGizmoFloatParameterSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoAxisIntervalParameterSource.__PropertyOffset_FloatParameterSource));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisIntervalParameterSource.__PropertyOffset_FloatParameterSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x06013C1D RID: 80925 RVA: 0x001D0303 File Offset: 0x001CE503
		// (set) Token: 0x06013C1E RID: 80926 RVA: 0x001D0313 File Offset: 0x001CE513
		public unsafe float MinParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisIntervalParameterSource.__PropertyOffset_MinParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisIntervalParameterSource.__PropertyOffset_MinParameter) = value;
			}
		}

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x06013C1F RID: 80927 RVA: 0x001D0324 File Offset: 0x001CE524
		// (set) Token: 0x06013C20 RID: 80928 RVA: 0x001D0334 File Offset: 0x001CE534
		public unsafe float MaxParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoAxisIntervalParameterSource.__PropertyOffset_MaxParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoAxisIntervalParameterSource.__PropertyOffset_MaxParameter) = value;
			}
		}

		// Token: 0x06013C21 RID: 80929 RVA: 0x001D0345 File Offset: 0x001CE545
		static UGizmoAxisIntervalParameterSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoAxisIntervalParameterSource");
		}

		// Token: 0x06013C22 RID: 80930 RVA: 0x001D0353 File Offset: 0x001CE553
		protected UGizmoAxisIntervalParameterSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAFF RID: 43775
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoAxisIntervalParameterSource";

		// Token: 0x0400AB00 RID: 43776
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB01 RID: 43777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB02 RID: 43778
		internal static int __PropertyOffset_FloatParameterSource;

		// Token: 0x0400AB03 RID: 43779
		internal static int __PropertyOffset_MinParameter;

		// Token: 0x0400AB04 RID: 43780
		internal static int __PropertyOffset_MaxParameter;
	}
}
