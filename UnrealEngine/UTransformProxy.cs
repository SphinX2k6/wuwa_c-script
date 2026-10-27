using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015A2 RID: 5538
	[UnrealObjectPath("/Script/InteractiveToolsFramework.TransformProxy")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UTransformProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013F60 RID: 81760 RVA: 0x001D4EF2 File Offset: 0x001D30F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransformProxy._ClassPtr;
		}

		// Token: 0x06013F61 RID: 81761 RVA: 0x001D4F00 File Offset: 0x001D3100
		public UTransformProxy() : this(BuiltinUtils.AllocNativeUObject(UTransformProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013F62 RID: 81762 RVA: 0x001D4F28 File Offset: 0x001D3128
		[NullableContext(1)]
		public UTransformProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransformProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x06013F63 RID: 81763 RVA: 0x001D4F5B File Offset: 0x001D315B
		// (set) Token: 0x06013F64 RID: 81764 RVA: 0x001D4F6B File Offset: 0x001D316B
		public unsafe bool bRotatePerObject
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_bRotatePerObject) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_bRotatePerObject) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x06013F65 RID: 81765 RVA: 0x001D4F7C File Offset: 0x001D317C
		// (set) Token: 0x06013F66 RID: 81766 RVA: 0x001D4F8C File Offset: 0x001D318C
		public unsafe bool bSetPivotMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_bSetPivotMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_bSetPivotMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x06013F67 RID: 81767 RVA: 0x001D4F9D File Offset: 0x001D319D
		// (set) Token: 0x06013F68 RID: 81768 RVA: 0x001D4FB1 File Offset: 0x001D31B1
		public unsafe FTransform SharedTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_SharedTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_SharedTransform) = value;
			}
		}

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x06013F69 RID: 81769 RVA: 0x001D4FC6 File Offset: 0x001D31C6
		// (set) Token: 0x06013F6A RID: 81770 RVA: 0x001D4FDA File Offset: 0x001D31DA
		public unsafe FTransform InitialSharedTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_InitialSharedTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransformProxy.__PropertyOffset_InitialSharedTransform) = value;
			}
		}

		// Token: 0x06013F6B RID: 81771 RVA: 0x001D4FEF File Offset: 0x001D31EF
		static UTransformProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.TransformProxy");
		}

		// Token: 0x06013F6C RID: 81772 RVA: 0x001D4FFD File Offset: 0x001D31FD
		protected UTransformProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACE2 RID: 44258
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.TransformProxy";

		// Token: 0x0400ACE3 RID: 44259
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACE4 RID: 44260
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ACE5 RID: 44261
		internal static int __PropertyOffset_bRotatePerObject;

		// Token: 0x0400ACE6 RID: 44262
		internal static int __PropertyOffset_bSetPivotMode;

		// Token: 0x0400ACE7 RID: 44263
		internal static int __PropertyOffset_SharedTransform;

		// Token: 0x0400ACE8 RID: 44264
		internal static int __PropertyOffset_InitialSharedTransform;
	}
}
