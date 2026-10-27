using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001550 RID: 5456
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoCircleComponent")]
	[UnrealStructLayout(1632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class UGizmoCircleComponent : UGizmoBaseComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C96 RID: 81046 RVA: 0x001D0E9C File Offset: 0x001CF09C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoCircleComponent._ClassPtr;
		}

		// Token: 0x06013C97 RID: 81047 RVA: 0x001D0EA8 File Offset: 0x001CF0A8
		public UGizmoCircleComponent() : this(BuiltinUtils.AllocNativeUObject(UGizmoCircleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C98 RID: 81048 RVA: 0x001D0ED0 File Offset: 0x001CF0D0
		[NullableContext(1)]
		public UGizmoCircleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoCircleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x06013C99 RID: 81049 RVA: 0x001D0F03 File Offset: 0x001CF103
		// (set) Token: 0x06013C9A RID: 81050 RVA: 0x001D0F17 File Offset: 0x001CF117
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17004D83 RID: 19843
		// (get) Token: 0x06013C9B RID: 81051 RVA: 0x001D0F2C File Offset: 0x001CF12C
		// (set) Token: 0x06013C9C RID: 81052 RVA: 0x001D0F3C File Offset: 0x001CF13C
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004D84 RID: 19844
		// (get) Token: 0x06013C9D RID: 81053 RVA: 0x001D0F4D File Offset: 0x001CF14D
		// (set) Token: 0x06013C9E RID: 81054 RVA: 0x001D0F5D File Offset: 0x001CF15D
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17004D85 RID: 19845
		// (get) Token: 0x06013C9F RID: 81055 RVA: 0x001D0F6E File Offset: 0x001CF16E
		// (set) Token: 0x06013CA0 RID: 81056 RVA: 0x001D0F7E File Offset: 0x001CF17E
		public unsafe int NumSides
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_NumSides);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_NumSides) = value;
			}
		}

		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x06013CA1 RID: 81057 RVA: 0x001D0F8F File Offset: 0x001CF18F
		// (set) Token: 0x06013CA2 RID: 81058 RVA: 0x001D0F9F File Offset: 0x001CF19F
		public unsafe bool bViewAligned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_bViewAligned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_bViewAligned) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x06013CA3 RID: 81059 RVA: 0x001D0FB0 File Offset: 0x001CF1B0
		// (set) Token: 0x06013CA4 RID: 81060 RVA: 0x001D0FC0 File Offset: 0x001CF1C0
		public unsafe bool bOnlyAllowFrontFacingHits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_bOnlyAllowFrontFacingHits) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoCircleComponent.__PropertyOffset_bOnlyAllowFrontFacingHits) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013CA5 RID: 81061 RVA: 0x001D0FD1 File Offset: 0x001CF1D1
		static UGizmoCircleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoCircleComponent");
		}

		// Token: 0x06013CA6 RID: 81062 RVA: 0x001D0FDF File Offset: 0x001CF1DF
		protected UGizmoCircleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB44 RID: 43844
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoCircleComponent";

		// Token: 0x0400AB45 RID: 43845
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB46 RID: 43846
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB47 RID: 43847
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400AB48 RID: 43848
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400AB49 RID: 43849
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400AB4A RID: 43850
		internal static int __PropertyOffset_NumSides;

		// Token: 0x0400AB4B RID: 43851
		internal static int __PropertyOffset_bViewAligned;

		// Token: 0x0400AB4C RID: 43852
		internal static int __PropertyOffset_bOnlyAllowFrontFacingHits;
	}
}
