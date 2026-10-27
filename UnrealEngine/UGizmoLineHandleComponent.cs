using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200155B RID: 5467
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoLineHandleComponent")]
	[UnrealStructLayout(1632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class UGizmoLineHandleComponent : UGizmoBaseComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013CFB RID: 81147 RVA: 0x001D171A File Offset: 0x001CF91A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoLineHandleComponent._ClassPtr;
		}

		// Token: 0x06013CFC RID: 81148 RVA: 0x001D1728 File Offset: 0x001CF928
		public UGizmoLineHandleComponent() : this(BuiltinUtils.AllocNativeUObject(UGizmoLineHandleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CFD RID: 81149 RVA: 0x001D1750 File Offset: 0x001CF950
		[NullableContext(1)]
		public UGizmoLineHandleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoLineHandleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x06013CFE RID: 81150 RVA: 0x001D1783 File Offset: 0x001CF983
		// (set) Token: 0x06013CFF RID: 81151 RVA: 0x001D1797 File Offset: 0x001CF997
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x06013D00 RID: 81152 RVA: 0x001D17AC File Offset: 0x001CF9AC
		// (set) Token: 0x06013D01 RID: 81153 RVA: 0x001D17BC File Offset: 0x001CF9BC
		public unsafe float HandleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_HandleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_HandleSize) = value;
			}
		}

		// Token: 0x17004D98 RID: 19864
		// (get) Token: 0x06013D02 RID: 81154 RVA: 0x001D17CD File Offset: 0x001CF9CD
		// (set) Token: 0x06013D03 RID: 81155 RVA: 0x001D17DD File Offset: 0x001CF9DD
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17004D99 RID: 19865
		// (get) Token: 0x06013D04 RID: 81156 RVA: 0x001D17EE File Offset: 0x001CF9EE
		// (set) Token: 0x06013D05 RID: 81157 RVA: 0x001D1802 File Offset: 0x001CFA02
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17004D9A RID: 19866
		// (get) Token: 0x06013D06 RID: 81158 RVA: 0x001D1817 File Offset: 0x001CFA17
		// (set) Token: 0x06013D07 RID: 81159 RVA: 0x001D1827 File Offset: 0x001CFA27
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17004D9B RID: 19867
		// (get) Token: 0x06013D08 RID: 81160 RVA: 0x001D1838 File Offset: 0x001CFA38
		// (set) Token: 0x06013D09 RID: 81161 RVA: 0x001D1848 File Offset: 0x001CFA48
		public unsafe bool bImageScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_bImageScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoLineHandleComponent.__PropertyOffset_bImageScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013D0A RID: 81162 RVA: 0x001D1859 File Offset: 0x001CFA59
		static UGizmoLineHandleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoLineHandleComponent");
		}

		// Token: 0x06013D0B RID: 81163 RVA: 0x001D1867 File Offset: 0x001CFA67
		protected UGizmoLineHandleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB7A RID: 43898
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoLineHandleComponent";

		// Token: 0x0400AB7B RID: 43899
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB7C RID: 43900
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB7D RID: 43901
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400AB7E RID: 43902
		internal static int __PropertyOffset_HandleSize;

		// Token: 0x0400AB7F RID: 43903
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400AB80 RID: 43904
		internal static int __PropertyOffset_Direction;

		// Token: 0x0400AB81 RID: 43905
		internal static int __PropertyOffset_Length;

		// Token: 0x0400AB82 RID: 43906
		internal static int __PropertyOffset_bImageScale;
	}
}
