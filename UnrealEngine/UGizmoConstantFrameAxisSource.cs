using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001556 RID: 5462
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoConstantFrameAxisSource")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UGizmoConstantFrameAxisSource : UObject, IUnrealUObject, IUnrealObject, IGizmoAxisSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013CD0 RID: 81104 RVA: 0x001D1370 File Offset: 0x001CF570
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoConstantFrameAxisSource._ClassPtr;
		}

		// Token: 0x06013CD1 RID: 81105 RVA: 0x001D137C File Offset: 0x001CF57C
		int IGizmoAxisSource.InterfaceOffset()
		{
			return UGizmoConstantFrameAxisSource.__InterfaceOffset_IGizmoAxisSource;
		}

		// Token: 0x06013CD2 RID: 81106 RVA: 0x001D1384 File Offset: 0x001CF584
		public UGizmoConstantFrameAxisSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoConstantFrameAxisSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CD3 RID: 81107 RVA: 0x001D13AC File Offset: 0x001CF5AC
		[NullableContext(1)]
		public UGizmoConstantFrameAxisSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoConstantFrameAxisSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x06013CD4 RID: 81108 RVA: 0x001D13DF File Offset: 0x001CF5DF
		// (set) Token: 0x06013CD5 RID: 81109 RVA: 0x001D13F3 File Offset: 0x001CF5F3
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x06013CD6 RID: 81110 RVA: 0x001D1408 File Offset: 0x001CF608
		// (set) Token: 0x06013CD7 RID: 81111 RVA: 0x001D141C File Offset: 0x001CF61C
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x06013CD8 RID: 81112 RVA: 0x001D1431 File Offset: 0x001CF631
		// (set) Token: 0x06013CD9 RID: 81113 RVA: 0x001D1445 File Offset: 0x001CF645
		public unsafe FVector TangentX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_TangentX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_TangentX) = value;
			}
		}

		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x06013CDA RID: 81114 RVA: 0x001D145A File Offset: 0x001CF65A
		// (set) Token: 0x06013CDB RID: 81115 RVA: 0x001D146E File Offset: 0x001CF66E
		public unsafe FVector TangentY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_TangentY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoConstantFrameAxisSource.__PropertyOffset_TangentY) = value;
			}
		}

		// Token: 0x06013CDC RID: 81116 RVA: 0x001D1483 File Offset: 0x001CF683
		static UGizmoConstantFrameAxisSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoConstantFrameAxisSource");
		}

		// Token: 0x06013CDD RID: 81117 RVA: 0x001D1491 File Offset: 0x001CF691
		protected UGizmoConstantFrameAxisSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB65 RID: 43877
		internal static int __InterfaceOffset_IGizmoAxisSource;

		// Token: 0x0400AB66 RID: 43878
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoConstantFrameAxisSource";

		// Token: 0x0400AB67 RID: 43879
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB68 RID: 43880
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB69 RID: 43881
		internal static int __PropertyOffset_Origin;

		// Token: 0x0400AB6A RID: 43882
		internal static int __PropertyOffset_Direction;

		// Token: 0x0400AB6B RID: 43883
		internal static int __PropertyOffset_TangentX;

		// Token: 0x0400AB6C RID: 43884
		internal static int __PropertyOffset_TangentY;
	}
}
