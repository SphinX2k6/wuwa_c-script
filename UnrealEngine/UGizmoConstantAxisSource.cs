using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001555 RID: 5461
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoConstantAxisSource")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGizmoConstantAxisSource : UObject, IUnrealUObject, IUnrealObject, IGizmoAxisSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013CC6 RID: 81094 RVA: 0x001D1298 File Offset: 0x001CF498
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoConstantAxisSource._ClassPtr;
		}

		// Token: 0x06013CC7 RID: 81095 RVA: 0x001D12A4 File Offset: 0x001CF4A4
		int IGizmoAxisSource.InterfaceOffset()
		{
			return UGizmoConstantAxisSource.__InterfaceOffset_IGizmoAxisSource;
		}

		// Token: 0x06013CC8 RID: 81096 RVA: 0x001D12AC File Offset: 0x001CF4AC
		public UGizmoConstantAxisSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoConstantAxisSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CC9 RID: 81097 RVA: 0x001D12D4 File Offset: 0x001CF4D4
		[NullableContext(1)]
		public UGizmoConstantAxisSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoConstantAxisSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x06013CCA RID: 81098 RVA: 0x001D1307 File Offset: 0x001CF507
		// (set) Token: 0x06013CCB RID: 81099 RVA: 0x001D131B File Offset: 0x001CF51B
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoConstantAxisSource.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoConstantAxisSource.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x06013CCC RID: 81100 RVA: 0x001D1330 File Offset: 0x001CF530
		// (set) Token: 0x06013CCD RID: 81101 RVA: 0x001D1344 File Offset: 0x001CF544
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoConstantAxisSource.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoConstantAxisSource.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x06013CCE RID: 81102 RVA: 0x001D1359 File Offset: 0x001CF559
		static UGizmoConstantAxisSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoConstantAxisSource");
		}

		// Token: 0x06013CCF RID: 81103 RVA: 0x001D1367 File Offset: 0x001CF567
		protected UGizmoConstantAxisSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB5F RID: 43871
		internal static int __InterfaceOffset_IGizmoAxisSource;

		// Token: 0x0400AB60 RID: 43872
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoConstantAxisSource";

		// Token: 0x0400AB61 RID: 43873
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB62 RID: 43874
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB63 RID: 43875
		internal static int __PropertyOffset_Origin;

		// Token: 0x0400AB64 RID: 43876
		internal static int __PropertyOffset_Direction;
	}
}
