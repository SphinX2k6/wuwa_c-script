using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001563 RID: 5475
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoScaledTransformSource")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UGizmoScaledTransformSource : UGizmoBaseTransformSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013D6F RID: 81263 RVA: 0x001D21D6 File Offset: 0x001D03D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoScaledTransformSource._ClassPtr;
		}

		// Token: 0x06013D70 RID: 81264 RVA: 0x001D21E4 File Offset: 0x001D03E4
		public UGizmoScaledTransformSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoScaledTransformSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013D71 RID: 81265 RVA: 0x001D220C File Offset: 0x001D040C
		[NullableContext(1)]
		public UGizmoScaledTransformSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoScaledTransformSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DBB RID: 19899
		// (get) Token: 0x06013D72 RID: 81266 RVA: 0x001D223F File Offset: 0x001D043F
		// (set) Token: 0x06013D73 RID: 81267 RVA: 0x001D2259 File Offset: 0x001D0459
		[Nullable(2)]
		public unsafe IGizmoTransformSource ChildTransformSource
		{
			[NullableContext(2)]
			get
			{
				return (IGizmoTransformSource)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UGizmoScaledTransformSource.__PropertyOffset_ChildTransformSource));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoScaledTransformSource.__PropertyOffset_ChildTransformSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x06013D74 RID: 81268 RVA: 0x001D227F File Offset: 0x001D047F
		static UGizmoScaledTransformSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoScaledTransformSource");
		}

		// Token: 0x06013D75 RID: 81269 RVA: 0x001D228D File Offset: 0x001D048D
		protected UGizmoScaledTransformSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABBD RID: 43965
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoScaledTransformSource";

		// Token: 0x0400ABBE RID: 43966
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABBF RID: 43967
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABC0 RID: 43968
		internal static int __PropertyOffset_ChildTransformSource;
	}
}
