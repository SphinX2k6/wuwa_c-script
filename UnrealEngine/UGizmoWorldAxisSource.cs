using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200156C RID: 5484
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoWorldAxisSource")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UGizmoWorldAxisSource : UObject, IUnrealUObject, IUnrealObject, IGizmoAxisSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013DBA RID: 81338 RVA: 0x001D293A File Offset: 0x001D0B3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoWorldAxisSource._ClassPtr;
		}

		// Token: 0x06013DBB RID: 81339 RVA: 0x001D2946 File Offset: 0x001D0B46
		int IGizmoAxisSource.InterfaceOffset()
		{
			return UGizmoWorldAxisSource.__InterfaceOffset_IGizmoAxisSource;
		}

		// Token: 0x06013DBC RID: 81340 RVA: 0x001D2950 File Offset: 0x001D0B50
		public UGizmoWorldAxisSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoWorldAxisSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DBD RID: 81341 RVA: 0x001D2978 File Offset: 0x001D0B78
		[NullableContext(1)]
		public UGizmoWorldAxisSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoWorldAxisSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x06013DBE RID: 81342 RVA: 0x001D29AB File Offset: 0x001D0BAB
		// (set) Token: 0x06013DBF RID: 81343 RVA: 0x001D29BF File Offset: 0x001D0BBF
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoWorldAxisSource.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoWorldAxisSource.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x06013DC0 RID: 81344 RVA: 0x001D29D4 File Offset: 0x001D0BD4
		// (set) Token: 0x06013DC1 RID: 81345 RVA: 0x001D29E4 File Offset: 0x001D0BE4
		public unsafe int AxisIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoWorldAxisSource.__PropertyOffset_AxisIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoWorldAxisSource.__PropertyOffset_AxisIndex) = value;
			}
		}

		// Token: 0x06013DC2 RID: 81346 RVA: 0x001D29F5 File Offset: 0x001D0BF5
		static UGizmoWorldAxisSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoWorldAxisSource");
		}

		// Token: 0x06013DC3 RID: 81347 RVA: 0x001D2A03 File Offset: 0x001D0C03
		protected UGizmoWorldAxisSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABE2 RID: 44002
		internal static int __InterfaceOffset_IGizmoAxisSource;

		// Token: 0x0400ABE3 RID: 44003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoWorldAxisSource";

		// Token: 0x0400ABE4 RID: 44004
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABE5 RID: 44005
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ABE6 RID: 44006
		internal static int __PropertyOffset_Origin;

		// Token: 0x0400ABE7 RID: 44007
		internal static int __PropertyOffset_AxisIndex;
	}
}
