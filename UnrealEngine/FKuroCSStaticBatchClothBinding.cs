using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017D0 RID: 6096
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSStaticBatchClothBinding")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroCSStaticBatchClothBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016708 RID: 91912 RVA: 0x0020C990 File Offset: 0x0020AB90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSStaticBatchClothBinding._ScriptStructPtr != 0) ? FKuroCSStaticBatchClothBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSStaticBatchClothBinding", ref FKuroCSStaticBatchClothBinding._ScriptStructPtr);
		}

		// Token: 0x17005A6F RID: 23151
		// (get) Token: 0x06016709 RID: 91913 RVA: 0x0020C9B4 File Offset: 0x0020ABB4
		// (set) Token: 0x0601670A RID: 91914 RVA: 0x0020C9C8 File Offset: 0x0020ABC8
		[Nullable(2)]
		public unsafe UDataTable DataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSStaticBatchClothBinding.__PropertyOffset_DataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSStaticBatchClothBinding.__PropertyOffset_DataTable, value);
			}
		}

		// Token: 0x17005A70 RID: 23152
		// (get) Token: 0x0601670B RID: 91915 RVA: 0x0020C9DD File Offset: 0x0020ABDD
		// (set) Token: 0x0601670C RID: 91916 RVA: 0x0020C9ED File Offset: 0x0020ABED
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x17005A71 RID: 23153
		// (get) Token: 0x0601670D RID: 91917 RVA: 0x0020CA00 File Offset: 0x0020AC00
		// (set) Token: 0x0601670E RID: 91918 RVA: 0x0020CA43 File Offset: 0x0020AC43
		public FKuroCSStaticBatchClothWindParams WindParams
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCSStaticBatchClothWindParams result;
				if ((result = this._WindParams) == null)
				{
					result = (this._WindParams = new FKuroCSStaticBatchClothWindParams(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_WindParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCSStaticBatchClothWindParams.StaticStruct(), base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_WindParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A72 RID: 23154
		// (get) Token: 0x0601670F RID: 91919 RVA: 0x0020CA64 File Offset: 0x0020AC64
		// (set) Token: 0x06016710 RID: 91920 RVA: 0x0020CA74 File Offset: 0x0020AC74
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x17005A73 RID: 23155
		// (get) Token: 0x06016711 RID: 91921 RVA: 0x0020CA85 File Offset: 0x0020AC85
		// (set) Token: 0x06016712 RID: 91922 RVA: 0x0020CA95 File Offset: 0x0020AC95
		public unsafe float BendingStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_BendingStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_BendingStiffness) = value;
			}
		}

		// Token: 0x17005A74 RID: 23156
		// (get) Token: 0x06016713 RID: 91923 RVA: 0x0020CAA6 File Offset: 0x0020ACA6
		// (set) Token: 0x06016714 RID: 91924 RVA: 0x0020CAB6 File Offset: 0x0020ACB6
		public unsafe EKuroCSStaticBatchClothBendingTopology BendingTopology
		{
			get
			{
				return (EKuroCSStaticBatchClothBendingTopology)(*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_BendingTopology));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_BendingTopology) = (byte)value;
			}
		}

		// Token: 0x17005A75 RID: 23157
		// (get) Token: 0x06016715 RID: 91925 RVA: 0x0020CAC7 File Offset: 0x0020ACC7
		// (set) Token: 0x06016716 RID: 91926 RVA: 0x0020CAD7 File Offset: 0x0020ACD7
		public unsafe float VolDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_VolDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSStaticBatchClothBinding.__PropertyOffset_VolDamping) = value;
			}
		}

		// Token: 0x06016717 RID: 91927 RVA: 0x0020CAE8 File Offset: 0x0020ACE8
		public FKuroCSStaticBatchClothBinding()
		{
		}

		// Token: 0x06016718 RID: 91928 RVA: 0x0020CAF0 File Offset: 0x0020ACF0
		public FKuroCSStaticBatchClothBinding(UDataTable DataTable, int XCount, FKuroCSStaticBatchClothWindParams WindParams, float DisStiffness, float BendingStiffness, EKuroCSStaticBatchClothBendingTopology BendingTopology, float VolDamping)
		{
			this.DataTable = DataTable;
			this.XCount = XCount;
			this.WindParams = WindParams;
			this.DisStiffness = DisStiffness;
			this.BendingStiffness = BendingStiffness;
			this.BendingTopology = BendingTopology;
			this.VolDamping = VolDamping;
		}

		// Token: 0x06016719 RID: 91929 RVA: 0x0020CB2D File Offset: 0x0020AD2D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSStaticBatchClothBinding.StaticStruct();
		}

		// Token: 0x0601671A RID: 91930 RVA: 0x0020CB39 File Offset: 0x0020AD39
		[NullableContext(2)]
		public FKuroCSStaticBatchClothBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601671B RID: 91931 RVA: 0x0020CB43 File Offset: 0x0020AD43
		public FKuroCSStaticBatchClothBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601671C RID: 91932 RVA: 0x0020CB4E File Offset: 0x0020AD4E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSStaticBatchClothBinding(Pointer, false, true);
		}

		// Token: 0x0601671D RID: 91933 RVA: 0x0020CB58 File Offset: 0x0020AD58
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSStaticBatchClothBinding(Pointer, MemoryOwner);
		}

		// Token: 0x0400C318 RID: 49944
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSStaticBatchClothBinding";

		// Token: 0x0400C319 RID: 49945
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C31A RID: 49946
		internal static int __PropertyOffset_DataTable;

		// Token: 0x0400C31B RID: 49947
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400C31C RID: 49948
		internal static int __PropertyOffset_WindParams;

		// Token: 0x0400C31D RID: 49949
		[Nullable(2)]
		private FKuroCSStaticBatchClothWindParams _WindParams;

		// Token: 0x0400C31E RID: 49950
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400C31F RID: 49951
		internal static int __PropertyOffset_BendingStiffness;

		// Token: 0x0400C320 RID: 49952
		internal static int __PropertyOffset_BendingTopology;

		// Token: 0x0400C321 RID: 49953
		internal static int __PropertyOffset_VolDamping;
	}
}
